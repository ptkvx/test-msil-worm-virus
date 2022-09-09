using System;

namespace Microsoft.Contracts;

[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property)]
internal sealed class VerifyAttribute : Attribute
{
	private bool _value;

	public bool Value => _value;

	public VerifyAttribute()
	{
		_value = true;
	}

	public VerifyAttribute(bool value)
	{
		_value = value;
	}
}
