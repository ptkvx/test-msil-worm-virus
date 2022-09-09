using System.ComponentModel;
using MindCompression.Memory;

namespace MindCompression.DataObjects;

[TypeConverter(typeof(ExpandableObjectConverter))]
public class Finances : PropertyObject
{
	protected int _financialAddress;

	private ProcessMemory _pm;

	[PropertyInfo("Balance", "The balance of the club.", 1)]
	public int Balance
	{
		get
		{
			return _pm.ReadInt32(_financialAddress + FinancialOffsets.Balance);
		}
		set
		{
			_pm.WriteInt32(value, _financialAddress + FinancialOffsets.Balance);
		}
	}

	[PropertyInfo("Transfer budget (Season)", "This seasons transfer budget.", 2)]
	public int SeasonTransferBudget
	{
		get
		{
			return _pm.ReadInt32(_financialAddress + FinancialOffsets.SeasonTransferBudget);
		}
		set
		{
			_pm.WriteInt32(value, _financialAddress + FinancialOffsets.SeasonTransferBudget);
		}
	}

	[PropertyInfo("Transfer budget (Remaining)", "This seasons remaining transfer budget.", 3)]
	public int RemainingTransferBudget
	{
		get
		{
			return _pm.ReadInt32(_financialAddress + FinancialOffsets.RemainingTransferBudget);
		}
		set
		{
			_pm.WriteInt32(value, _financialAddress + FinancialOffsets.RemainingTransferBudget);
		}
	}

	[PropertyInfo("Transfer revenue made available", "% of transfer revenue made available (0-100%)", 4)]
	public sbyte TransferRevenueMadeAvailable
	{
		get
		{
			return _pm.ReadSByte(_financialAddress + FinancialOffsets.TransferRevenueMadeAvailable);
		}
		set
		{
			_pm.WriteSByte(value, _financialAddress + FinancialOffsets.TransferRevenueMadeAvailable);
		}
	}

	[PropertyInfo("Wage budget", "Wage budget of the club.", 5)]
	public int WageBudget
	{
		get
		{
			return _pm.ReadInt32(_financialAddress + FinancialOffsets.WageBudget);
		}
		set
		{
			_pm.WriteInt32(value, _financialAddress + FinancialOffsets.WageBudget);
		}
	}

	public Finances(int financialAddress, ProcessMemory pm)
	{
		_pm = pm;
		_financialAddress = financialAddress;
	}

	public override string ToString()
	{
		return "This clubs financial information.";
	}
}
