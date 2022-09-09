using System;
using System.Runtime.CompilerServices;
using GenericPolicy;

namespace hpCasl;

internal class Class0 : GClass0
{
	public enum enKnownPolicies
	{
		MaxToasterDuration,
		MaxToasterNumber,
		CaslNotificationDebug
	}

	public Class0(enPolicyType enPolicyType_1, string string_3)
		: base(enPolicyType_1, string_3)
	{
	}

	[SpecialName]
	public uint method_22()
	{
		uint result = uint.MaxValue;
		if (method_11(enKnownPolicies.MaxToasterDuration.ToString(), out var object_) == 0)
		{
			result = (uint)Convert.ToInt32(object_);
		}
		return result;
	}

	[SpecialName]
	public uint method_23()
	{
		uint result = uint.MaxValue;
		if (method_11(enKnownPolicies.MaxToasterNumber.ToString(), out var object_) == 0)
		{
			result = (uint)Convert.ToInt32(object_);
		}
		return result;
	}

	[SpecialName]
	public bool method_24()
	{
		bool bool_ = false;
		method_12(enKnownPolicies.CaslNotificationDebug.ToString(), ref bool_);
		return bool_;
	}
}
