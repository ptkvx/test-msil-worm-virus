using System;
using System.Collections;
using System.IO;
using System.Runtime.InteropServices;

namespace Intuit.QuickBooks.FCS;

[ComVisible(false)]
public class TransactionClerk
{
	private FcsCompensator _comp;

	private ActionsLogger actionsLog;

	private string TransactionID;

	private string FcsTxLogDir;

	public TransactionClerk(FcsCompensator compensator, string sFcsTxLogDir)
	{
		_comp = compensator;
		TransactionID = Guid.NewGuid().ToString();
		if (Directory.Exists(sFcsTxLogDir))
		{
			FcsTxLogDir = sFcsTxLogDir;
		}
		else
		{
			FcsTxLogDir = ".\\";
		}
		string text = Path.Combine(FcsTxLogDir, TransactionID);
		text += ".qbtxlog";
		FCService.WriteTraceLine("TxLog Directory: " + FcsTxLogDir);
		actionsLog = new ActionsLogger(text, TxLogAccess.CreateNew);
	}

	public void WriteLogRecord(FcsLogRecord rec)
	{
		actionsLog.WriteLogRecord(rec);
	}

	public void Commit()
	{
		ArrayList transactionActions = actionsLog.GetTransactionActions();
		if (transactionActions != null && transactionActions.Count != 0)
		{
			foreach (object item in transactionActions)
			{
				FcsLogRecord logRecord = (FcsLogRecord)item;
				_comp.CommitRecord(logRecord);
			}
		}
		actionsLog.Dispose();
	}

	public void Abort()
	{
		ArrayList transactionActions = actionsLog.GetTransactionActions();
		if (transactionActions != null && transactionActions.Count != 0)
		{
			transactionActions.Reverse();
			foreach (object item in transactionActions)
			{
				FcsLogRecord logRecord = (FcsLogRecord)item;
				_comp.AbortRecord(logRecord);
			}
		}
		actionsLog.Dispose();
	}
}
