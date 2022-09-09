using System;
using System.ComponentModel;
using MindCompression.Memory;

namespace MindCompression.DataObjects;

[TypeConverter(typeof(ExpandableObjectConverter))]
public class Contract : PropertyObject
{
	protected int _contractAddress;

	private ProcessMemory _pm;

	[PropertyInfo("Wages", "The players wages (in UK Pound Sterling).")]
	public int Wages
	{
		get
		{
			return _pm.ReadInt32(_contractAddress + ContractOffsets.Wages);
		}
		set
		{
			_pm.WriteInt32(value, _contractAddress + ContractOffsets.Wages);
		}
	}

	[PropertyInfo("Appearance bonus", "The players appearance bonus (in UK Pound Sterling).")]
	public int AppearanceBonus
	{
		get
		{
			return _pm.ReadInt32(_contractAddress + ContractOffsets.AppearanceBonus);
		}
		set
		{
			_pm.WriteInt32(value, _contractAddress + ContractOffsets.AppearanceBonus);
		}
	}

	[PropertyInfo("Goal bonus", "The players goal bonus (in UK Pound Sterling).")]
	public int GoalBonus
	{
		get
		{
			return _pm.ReadInt32(_contractAddress + ContractOffsets.GoalBonus);
		}
		set
		{
			_pm.WriteInt32(value, _contractAddress + ContractOffsets.GoalBonus);
		}
	}

	[PropertyInfo("Assist bonus", "The players assist bonus (in UK Pound Sterling).")]
	public int AssistBonus
	{
		get
		{
			return _pm.ReadInt32(_contractAddress + ContractOffsets.AssistBonus);
		}
		set
		{
			_pm.WriteInt32(value, _contractAddress + ContractOffsets.AssistBonus);
		}
	}

	[PropertyInfo("Clean sheet bonus", "The players clean sheet bonus (in UK Pound Sterling).")]
	public int CleanSheetBonus
	{
		get
		{
			return _pm.ReadInt32(_contractAddress + ContractOffsets.CleanSheetBonus);
		}
		set
		{
			_pm.WriteInt32(value, _contractAddress + ContractOffsets.CleanSheetBonus);
		}
	}

	[PropertyInfo("Contract expires", "Date that the contract expires.")]
	public DateTime ContractExpires
	{
		get
		{
			return _pm.ReadDateTime(_contractAddress + ContractOffsets.ContractExpires);
		}
		set
		{
			_pm.WriteDateTime(value, _contractAddress + ContractOffsets.ContractExpires);
		}
	}

	[PropertyInfo("Contract started", "Date that the contract started.")]
	public DateTime ContractStarted
	{
		get
		{
			return _pm.ReadDateTime(_contractAddress + ContractOffsets.ContractStarted);
		}
		set
		{
			_pm.WriteDateTime(value, _contractAddress + ContractOffsets.ContractStarted);
		}
	}

	public Contract(int contractAddress, ProcessMemory pm)
	{
		_pm = pm;
		_contractAddress = contractAddress;
	}

	public override string ToString()
	{
		return "This person's contract options.";
	}
}
