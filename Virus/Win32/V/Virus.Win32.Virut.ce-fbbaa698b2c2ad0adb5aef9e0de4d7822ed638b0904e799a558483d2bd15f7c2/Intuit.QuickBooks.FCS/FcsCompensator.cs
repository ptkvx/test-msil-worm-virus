#define TRACE
using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;

namespace Intuit.QuickBooks.FCS;

[ComVisible(false)]
public class FcsCompensator
{
	public bool CommitRecord(FcsLogRecord logRecord)
	{
		FCService.WriteTraceLine("FcsCompensator::CommitRecord()");
		switch (logRecord.Actions)
		{
		case Actions.CopyFile:
			FCService.WriteTraceLine("Action: CopyFile - Source: " + logRecord.Source);
			if (File.Exists(logRecord.Source))
			{
				FCService.WriteTraceLine("Destination File: " + logRecord.Destination);
				try
				{
					File.Move(logRecord.Source, logRecord.Destination);
					FCService.WriteTraceLine("Source file was successfully copied");
				}
				catch (Exception ex)
				{
					FCService.WriteTraceLine("" + ex.Message);
					FCService.DumpStackTrace(ex);
				}
			}
			else
			{
				FCService.WriteTraceLine("Temp file does not exist: " + logRecord.Source);
			}
			break;
		case Actions.Rename:
			FCService.WriteTraceLine("Action: Rename - Temp file will be deleted: " + logRecord.Destination);
			if (File.Exists(logRecord.Destination))
			{
				DeleteFile(logRecord.Destination);
			}
			else
			{
				FCService.WriteTraceLine("Temporary file does not exist");
			}
			break;
		}
		return true;
	}

	public bool AbortRecord(FcsLogRecord logRecord)
	{
		FCService.WriteTraceLine("FileCompensator::AbortRecord()");
		switch (logRecord.Actions)
		{
		case Actions.CopyFile:
			FCService.WriteTraceLine("Action: CopyFile - Destination file will be deleted: " + logRecord.Destination);
			if (File.Exists(logRecord.Source))
			{
				try
				{
					File.Delete(logRecord.Source);
				}
				catch (Exception ex2)
				{
					FCService.WriteTraceLine("" + ex2.Message);
					FCService.WriteTraceLine("Failed to delete the file: " + logRecord.Source);
					FCService.DumpStackTrace(ex2);
				}
			}
			else
			{
				FCService.WriteTraceLine("File " + logRecord.Source + " was not available for rollback delete");
			}
			break;
		case Actions.Rename:
			Trace.Write("Action: Rename - Original file will be restored: ");
			FCService.WriteTraceLine(logRecord.Source + ", Temp: " + logRecord.Destination);
			if (File.Exists(logRecord.Destination))
			{
				try
				{
					File.Move(logRecord.Destination, logRecord.Source);
				}
				catch (Exception ex3)
				{
					FCService.WriteTraceLine("" + ex3.Message);
					Trace.Write("Failed to move the file: " + logRecord.Source);
					FCService.WriteTraceLine(" to its original name : " + logRecord.Destination);
					FCService.DumpStackTrace(ex3);
				}
			}
			else
			{
				FCService.WriteTraceLine("Temp file does not exist: " + logRecord.Destination);
			}
			break;
		case Actions.CreateDirectory:
			if (Directory.Exists(logRecord.Destination))
			{
				try
				{
					Directory.Delete(logRecord.Destination);
				}
				catch (Exception ex)
				{
					FCService.WriteTraceLine("" + ex.Message);
					FCService.DumpStackTrace(ex);
				}
			}
			break;
		case Actions.DeleteFile:
			DeleteFile(logRecord.Source);
			break;
		}
		return true;
	}

	protected void DeleteFile(string sFile)
	{
		bool flag = false;
		try
		{
			File.Delete(sFile);
			flag = true;
		}
		catch (Exception ex)
		{
			FCService.WriteTraceLine("" + ex.Message);
			FCService.WriteTraceLine("Failed to delete the file: " + sFile);
			FCService.DumpStackTrace(ex);
			FileAttributes attributes = File.GetAttributes(sFile);
			if ((attributes & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
			{
				FCService.WriteTraceLine("The file is read-only. Delete will be forced.");
				try
				{
					File.SetAttributes(sFile, attributes & ~FileAttributes.ReadOnly);
					File.Delete(sFile);
					flag = true;
					FCService.WriteTraceLine("File was successfully deleted");
				}
				catch (Exception ex2)
				{
					FCService.WriteTraceLine("" + ex2.Message);
					FCService.DumpStackTrace(ex);
				}
			}
		}
		if (!flag)
		{
			DeleteFileAfterReboot(sFile);
		}
	}

	protected void DeleteFileAfterReboot(string FileName)
	{
		FCService.WriteTraceLine("This file will be deleted after system reboot: " + FileName);
		try
		{
			Win32API.MoveFileEx(FileName, "", 4);
		}
		catch (Exception ex)
		{
			FCService.WriteTraceLine("Failed to mark the file for delete on reboot: " + ex.Message);
			FCService.DumpStackTrace(ex);
		}
	}
}
