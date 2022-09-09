#define TRACE
using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;

namespace Intuit.QuickBooks.FCS;

[Guid("E2F551B5-D7E4-351C-A975-2E8EEE4D1917")]
[ComVisible(true)]
[ClassInterface(ClassInterfaceType.None)]
public class FcsSession : IFcsSession
{
	private const string NamedPipeSeparator = "\\pipe\\";

	private TransactionClerk _Clerk;

	private string FcsWorkingRoot;

	private string FcsTxLogDir;

	private string FcsAuthDir;

	private Authenticator authenticator;

	private string AuthFileCopy;

	public FcsSession()
	{
		FCService.AdjustTraceFileSize();
		Trace.WriteLine("========================================================================================");
		FCService.WriteTraceLine("FcsSession component just Constructed");
		Process currentProcess = Process.GetCurrentProcess();
		FCService.WriteTraceLine("FcsSession Component runs inside Process ID: " + currentProcess.Id + " , Main module: " + currentProcess.MainModule!.ModuleName);
		authenticator = new Authenticator();
		FCService.WriteTraceLine("Created Authenticator");
		_Clerk = null;
		try
		{
			SetupWorkingDirectories();
		}
		catch (Exception ex)
		{
			FCService.WriteTraceLine("Error setting up directories: " + ex.Message);
			FCService.DumpStackTrace(ex);
		}
		FCService.FixRegistry();
	}

	protected FCSErrors CopyFile(string Src, string Dest)
	{
		FCService.WriteTraceLine("FileCopy is called.");
		FCService.WriteTraceLine("Source: " + Src);
		FCService.WriteTraceLine("Destination: " + Dest);
		if (Src.ToLower().IndexOf("\\pipe\\") < 0 && Dest.ToLower().IndexOf("\\pipe\\") < 0)
		{
			if (!File.Exists(Src))
			{
				FCService.WriteTraceLine("Source File not found: " + Src);
				Abort();
				return FCSErrors.File_NotFound;
			}
			if (Path.IsPathRooted(Src) && Path.IsPathRooted(Dest))
			{
				Path.GetDirectoryName(Src);
				string directoryName = Path.GetDirectoryName(Dest);
				if (!Directory.Exists(directoryName))
				{
					RecordAction(null, directoryName, Actions.CreateDirectory);
					try
					{
						Directory.CreateDirectory(directoryName);
					}
					catch (UnauthorizedAccessException ex)
					{
						FCService.WriteTraceLine(FCSErrors.DestFile_NoWritePermission.ToString() + " - " + ex.Message);
						Abort();
						return FCSErrors.DestFile_NoWritePermission;
					}
					catch (Exception ex2)
					{
						FCService.WriteTraceLine(FCSErrors.DestFile_NoWritePermission.ToString() + " - " + ex2.Message);
						FCService.DumpStackTrace(ex2);
						Abort();
						return FCSErrors.DestFile_NoWritePermission;
					}
				}
				else if (File.Exists(Dest))
				{
					FCService.WriteTraceLine("Destination file exists: " + Dest);
					string text = Path.Combine(directoryName, string.Concat(Guid.NewGuid(), ""));
					RecordAction(Dest, text, Actions.Rename);
					FCService.WriteTraceLine("File will be renamed to: " + text);
					FCSErrors fCSErrors = MoveFile(Dest, text);
					if (fCSErrors != 0)
					{
						return fCSErrors;
					}
				}
				string text2 = Path.Combine(directoryName, string.Concat(Guid.NewGuid(), ""));
				RecordAction(text2, Dest, Actions.CopyFile);
				FCService.WriteTraceLine("Source file will be copied to a temp name");
				try
				{
					File.Copy(Src, text2);
				}
				catch (UnauthorizedAccessException ex3)
				{
					FCService.WriteTraceLine(FCSErrors.DestFile_NoWritePermission.ToString() + " - (uae exp)->" + ex3.Message);
					Abort();
					return FCSErrors.DestFile_NoWritePermission;
				}
				catch (IOException ex4)
				{
					FCService.WriteTraceLine(FCSErrors.DestFile_NoWritePermission.ToString() + " - (io exp)->" + ex4.Message);
					Abort();
					return FCSErrors.DestFile_NoWritePermission;
				}
				catch (Exception ex5)
				{
					FCService.WriteTraceLine(FCSErrors.DestFile_NoWritePermission.ToString() + " - (exp)->" + ex5.Message);
					FCService.DumpStackTrace(ex5);
					Abort();
					return FCSErrors.DestFile_NoWritePermission;
				}
				FCService.WriteTraceLine("End of Copy file().");
				return FCSErrors.Operation_Success;
			}
			FCService.WriteTraceLine("Bad argument: File relative path is passed. Absolute path is required.");
			Abort();
			return FCSErrors.File_FullPathRequired;
		}
		FCService.WriteTraceLine("Argument file type is a named pipe: " + Src + ", " + Dest);
		Abort();
		return FCSErrors.File_NamedPipesNotSupported;
	}

	public FCSErrors CopyFiles(COPYREC[] CopyRecords, string AuthFile)
	{
		FCService.WriteTraceLine("CopyFiles() method is invoked with an array of: " + CopyRecords.Length + " records");
		FCSErrors fCSErrors = FCSErrors.Operation_Success;
		_Clerk = CreateClerk();
		if (_Clerk == null)
		{
			return FCSErrors.Tx_AbortedByServer;
		}
		FCService.StopTimer();
		fCSErrors = RegisterAuthFile(AuthFile);
		if (fCSErrors != 0)
		{
			Abort();
			return fCSErrors;
		}
		int num = 0;
		while (true)
		{
			if (num < CopyRecords.Length)
			{
				COPYREC cOPYREC = CopyRecords[num];
				string text = cOPYREC.Src;
				if (text.ToLower() != AuthFile.ToLower())
				{
					fCSErrors = VerifyFile(text);
				}
				else
				{
					text = AuthFileCopy;
				}
				if (fCSErrors == FCSErrors.Operation_Success)
				{
					fCSErrors = CopyFile(text, cOPYREC.Dest);
				}
				if (fCSErrors != 0)
				{
					break;
				}
				num++;
				continue;
			}
			try
			{
				Commit();
				return fCSErrors;
			}
			catch (Exception ex)
			{
				FCService.WriteTraceLine(FCSErrors.Tx_AbortedByServer.ToString() + " - Failed to commit transaction. An exception was caught: " + ex.Message);
				FCService.DumpStackTrace(ex);
				Abort();
				return FCSErrors.Tx_AbortedByServer;
			}
		}
		FCService.WriteTraceLine(fCSErrors.ToString());
		Abort();
		return fCSErrors;
	}

	protected void Abort()
	{
		FCService.WriteTraceLine("Transaction aborted on the server side");
		if (_Clerk != null)
		{
			_Clerk.Abort();
			_Clerk = null;
			DeleteAuthFileCopy();
		}
		FCService.StartTimer();
	}

	protected void Commit()
	{
		if (_Clerk != null)
		{
			_Clerk.Commit();
			_Clerk = null;
			DeleteAuthFileCopy();
		}
		FCService.StartTimer();
	}

	protected void DeleteAuthFileCopy()
	{
		if (AuthFileCopy != null && File.Exists(AuthFileCopy))
		{
			try
			{
				File.Delete(AuthFileCopy);
			}
			catch (Exception ex)
			{
				FCService.WriteTraceLine("Unable to delete the secured AuthFile Copy: " + ex.Message);
				FCService.DumpStackTrace(ex);
			}
		}
	}

	protected void RecordAction(string Src, string Dest, Actions Action)
	{
		FcsLogRecord rec = default(FcsLogRecord);
		rec.Source = Src;
		rec.Destination = Dest;
		rec.Actions = Action;
		if (_Clerk != null)
		{
			_Clerk.WriteLogRecord(rec);
		}
		else
		{
			FCService.WriteTraceLine("RecordAction() did not record anything because no Clerk is available");
		}
	}

	protected FCSErrors VerifyFile(string FileName)
	{
		FCSErrors result = FCSErrors.Operation_Success;
		try
		{
			authenticator.VerifyFile(FileName, AuthFileCopy);
			return result;
		}
		catch (AuthenticatorException ex)
		{
			FCService.WriteTraceLine(ex.ErrorCode.ToString() + "-" + ex.Message);
			return ex.ErrorCode;
		}
		catch (Exception ex2)
		{
			FCService.WriteTraceLine(FCSErrors.File_NotAuthorized.ToString() + " An exception was thrown-> " + ex2.Message);
			FCService.DumpStackTrace(ex2);
			return FCSErrors.File_NotAuthorized;
		}
	}

	protected void SetupWorkingDirectories()
	{
		try
		{
			FcsWorkingRoot = FCService.GetWorkingRootDir();
		}
		catch (Exception ex)
		{
			FCService.WriteTraceLine("Setting the working Dir: " + ex.Message);
			FCService.DumpStackTrace(ex);
		}
		FcsTxLogDir = FcsWorkingRoot + "\\TxLog";
		FcsAuthDir = FcsWorkingRoot + "\\Auth";
		if (!Directory.Exists(FcsTxLogDir))
		{
			Directory.CreateDirectory(FcsTxLogDir);
		}
		if (!Directory.Exists(FcsAuthDir))
		{
			Directory.CreateDirectory(FcsAuthDir);
		}
	}

	protected TransactionClerk CreateClerk()
	{
		if (_Clerk != null)
		{
			return _Clerk;
		}
		_Clerk = new TransactionClerk(new FcsCompensator(), FcsTxLogDir);
		FCService.WriteTraceLine("A new Clerk object was created");
		return _Clerk;
	}

	protected FCSErrors MoveFile(string Src, string Dest)
	{
		try
		{
			File.Move(Src, Dest);
		}
		catch (UnauthorizedAccessException ex)
		{
			FCService.WriteTraceLine("Source or Destination may be in use");
			FCService.WriteTraceLine(FCSErrors.File_NoWritePermission.ToString() + "-(uae exp)->" + ex.Message);
			Abort();
			return FCSErrors.File_NoWritePermission;
		}
		catch (IOException ex2)
		{
			FCService.WriteTraceLine(FCSErrors.File_NoWritePermission.ToString() + "-(ioexp)->" + ex2.Message);
			Abort();
			return FCSErrors.File_NoWritePermission;
		}
		catch (Exception ex3)
		{
			FCService.WriteTraceLine(FCSErrors.File_NoWritePermission.ToString() + "-(exp)->" + ex3.Message);
			FCService.DumpStackTrace(ex3);
			Abort();
			return FCSErrors.File_NoWritePermission;
		}
		return FCSErrors.Operation_Success;
	}

	public FCSErrors FcsMoveFile(string Src, string Dest, bool bOverWrite)
	{
		FCService.WriteTraceLine("FcsMoveFile is called.");
		FCService.WriteTraceLine("Source: " + Src);
		FCService.WriteTraceLine("Dest: " + Dest);
		if (Src.ToLower().IndexOf("\\pipe\\") < 0 && Dest.ToLower().IndexOf("\\pipe\\") < 0)
		{
			if (!File.Exists(Src))
			{
				FCService.WriteTraceLine("Source File not found: " + Src);
				Abort();
				return FCSErrors.File_NotFound;
			}
			if (File.Exists(Dest) && !bOverWrite)
			{
				FCService.WriteTraceLine("Destination File Exists. Overwrite is false: " + Dest);
				Abort();
				return FCSErrors.DestFile_ExistsWithNoOverwrite;
			}
			string directoryName = Path.GetDirectoryName(Src);
			string text = Path.Combine(directoryName, string.Concat(Guid.NewGuid(), ""));
			RecordAction(Src, text, Actions.Rename);
			FCService.WriteTraceLine("File will be renamed to: " + text);
			FCSErrors fCSErrors = MoveFile(Src, text);
			if (fCSErrors != 0)
			{
				return fCSErrors;
			}
			FCSErrors fCSErrors2 = CopyFile(text, Dest);
			if (fCSErrors2 != 0)
			{
				FCService.WriteTraceLine("File Copy Failed");
				Abort();
				return fCSErrors2;
			}
			RecordAction(Src, "", Actions.DeleteFile);
			return FCSErrors.Operation_Success;
		}
		FCService.WriteTraceLine("Argument file type is a named pipe: " + Src + ", " + Dest);
		Abort();
		return FCSErrors.File_NamedPipesNotSupported;
	}

	public FCSErrors MoveFiles(COPYREC[] CopyRecords, bool bOverWrite, string AuthFile)
	{
		FCService.WriteTraceLine("MoveFiles() method is invoked with an array of: " + CopyRecords.Length + " records");
		FCSErrors fCSErrors = FCSErrors.Operation_Success;
		_Clerk = CreateClerk();
		int num = 0;
		while (true)
		{
			if (num < CopyRecords.Length)
			{
				COPYREC cOPYREC = CopyRecords[num];
				try
				{
					fCSErrors = FcsMoveFile(cOPYREC.Src, cOPYREC.Dest, bOverWrite);
				}
				catch (Exception ex)
				{
					FCService.WriteTraceLine(FCSErrors.Tx_AbortedByServer.ToString() + " - An exception was thrown-> " + ex.Message);
					FCService.DumpStackTrace(ex);
					Abort();
					fCSErrors = FCSErrors.Tx_AbortedByServer;
				}
				if (fCSErrors == FCSErrors.Operation_Success)
				{
					num++;
					continue;
				}
				break;
			}
			try
			{
				Commit();
				return fCSErrors;
			}
			catch (Exception ex2)
			{
				FCService.WriteTraceLine(FCSErrors.Tx_AbortedByServer.ToString() + ": Failed to commit transaction. An exception was caught: " + ex2.Message);
				FCService.DumpStackTrace(ex2);
				Abort();
				return FCSErrors.Tx_AbortedByServer;
			}
		}
		FCService.WriteTraceLine(fCSErrors.ToString());
		return fCSErrors;
	}

	public FCSErrors RegisterAuthFile(string AuthFile)
	{
		FCService.WriteTraceLine("Calling RegisterAuthFile: ");
		FCSErrors result = FCSErrors.Operation_Success;
		try
		{
			if (AuthFile != null && AuthFile.Length != 0)
			{
				if (File.Exists(AuthFile))
				{
					AuthFileCopy = Path.Combine(FcsAuthDir, Path.GetFileName(AuthFile));
					try
					{
						File.Copy(AuthFile, AuthFileCopy, overwrite: true);
					}
					catch (Exception ex)
					{
						FCService.WriteTraceLine("Copying the AuthFile failed. Security layer will examine it: " + ex.Message);
						FCService.DumpStackTrace(ex);
					}
					authenticator.RegisterAuthFile(AuthFileCopy);
					return result;
				}
				FCService.WriteTraceLine(FCSErrors.AuthFile_NotFound.ToString() + " - AuthFile not found");
				return FCSErrors.AuthFile_NotFound;
			}
			FCService.WriteTraceLine(FCSErrors.AuthFile_NotFound.ToString() + " - No AuthFile was passed");
			return FCSErrors.AuthFile_NotFound;
		}
		catch (AuthenticatorException ex2)
		{
			FCService.WriteTraceLine("AuthFile issue: " + ex2.Message);
			return ex2.ErrorCode;
		}
		catch (Exception ex3)
		{
			FCService.WriteTraceLine(FCSErrors.Tx_AbortedByServer.ToString() + " - AuthFile issue: An exception was thrown-> " + ex3.Message);
			FCService.DumpStackTrace(ex3);
			return FCSErrors.Tx_AbortedByServer;
		}
	}
}
