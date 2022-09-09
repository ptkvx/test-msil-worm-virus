using System;
using System.Collections;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Intuit.QuickBooks.FCS;

[ComVisible(false)]
public class ActionsLogger : IDisposable
{
	private bool disposed;

	private string TxLogFile;

	private Stream TxStream;

	private IFormatter formatter;

	public ActionsLogger(string sTxLogFile, TxLogAccess logAccess)
	{
		TxLogFile = sTxLogFile;
		CreateLogFile(logAccess);
		formatter = new BinaryFormatter();
	}

	~ActionsLogger()
	{
		Dispose(disposing: false);
	}

	private void Destroy()
	{
		ClearStream();
		if (File.Exists(TxLogFile))
		{
			File.Delete(TxLogFile);
		}
	}

	private void CreateLogFile(TxLogAccess logAccess)
	{
		FCService.WriteTraceLine("TxLogFile: " + TxLogFile);
		FCService.WriteTraceLine("Open Mode: " + logAccess);
		if (logAccess == TxLogAccess.CreateNew)
		{
			try
			{
				TxStream = new FileStream(TxLogFile, FileMode.CreateNew, FileAccess.Write, FileShare.None);
				return;
			}
			catch (Exception ex)
			{
				FCService.WriteTraceLine("Failed to create TxLog file: " + ex.Message);
				FCService.DumpStackTrace(ex);
				FCService.WriteTraceLine("Will automatically recover and find an alternative");
				string tempPath = Path.GetTempPath();
				string fileName = Path.GetFileName(TxLogFile);
				TxLogFile = Path.Combine(tempPath, fileName);
				FCService.WriteTraceLine("TxLog file: " + TxLogFile);
				try
				{
					TxStream = new FileStream(TxLogFile, FileMode.CreateNew, FileAccess.Write, FileShare.None);
					return;
				}
				catch (Exception ex2)
				{
					FCService.WriteTraceLine("2nd trial to creat TxLog file failed: " + ex2.Message);
					FCService.DumpStackTrace(ex2);
					FCService.WriteTraceLine("will try to use a memory stream");
					TxStream = new MemoryStream();
					return;
				}
			}
		}
		TxStream = new FileStream(TxLogFile, FileMode.Open);
	}

	public ArrayList GetTransactionActions()
	{
		SetupReaderStream();
		FileInfo fileInfo = new FileInfo(TxLogFile);
		if (fileInfo.Length == 0L)
		{
			ClearStream();
			return null;
		}
		ArrayList arrayList = new ArrayList();
		try
		{
			while (true)
			{
				FcsLogRecord fcsLogRecord = (FcsLogRecord)formatter.Deserialize(TxStream);
				arrayList.Add(fcsLogRecord);
			}
		}
		catch (SerializationException)
		{
			FCService.WriteTraceLine("TxFile Parsed. ");
		}
		catch (Exception ex2)
		{
			FCService.WriteTraceLine("TxFile Parsed. " + ex2.Message);
		}
		ClearStream();
		return arrayList;
	}

	protected void SetupReaderStream()
	{
		ClearStream();
		TxStream = new FileStream(TxLogFile, FileMode.Open);
	}

	private void ClearStream()
	{
		if (TxStream != null)
		{
			TxStream.Close();
			TxStream = null;
		}
	}

	public void SealTxLog()
	{
		ClearStream();
	}

	public void WriteLogRecord(FcsLogRecord rec)
	{
		if (TxStream != null && TxStream.CanWrite)
		{
			formatter.Serialize(TxStream, rec);
			TxStream.Flush();
		}
	}

	protected void Dispose(bool disposing)
	{
		if (!disposed)
		{
			if (disposing)
			{
				ClearStream();
			}
			if (File.Exists(TxLogFile))
			{
				File.Delete(TxLogFile);
			}
		}
		disposed = true;
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}
}
