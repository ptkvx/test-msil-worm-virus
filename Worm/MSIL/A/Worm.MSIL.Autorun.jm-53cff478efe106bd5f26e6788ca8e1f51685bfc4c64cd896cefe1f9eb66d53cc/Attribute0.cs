using System;
using System.Runtime.InteropServices;

[ComVisible(true)]
[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Parameter | AttributeTargets.Delegate, Inherited = false, AllowMultiple = true)]
internal sealed class Attribute0 : Attribute
{
	private bool applyToMembers = true;

	private bool exclude = true;

	private bool strip = true;

	public bool ApplyToMembers
	{
		get
		{
			return applyToMembers;
		}
		set
		{
			applyToMembers = value;
		}
	}

	public bool Exclude
	{
		get
		{
			return exclude;
		}
		set
		{
			exclude = value;
		}
	}

	public bool StripAfterObfuscation
	{
		get
		{
			return strip;
		}
		set
		{
			strip = value;
		}
	}
}
