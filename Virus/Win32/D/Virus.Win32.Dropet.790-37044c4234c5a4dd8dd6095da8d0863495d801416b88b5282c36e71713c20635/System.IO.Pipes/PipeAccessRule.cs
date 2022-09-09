using System.Security.AccessControl;
using System.Security.Permissions;
using System.Security.Principal;

namespace System.IO.Pipes;

[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
public sealed class PipeAccessRule : AccessRule
{
	public PipeAccessRights PipeAccessRights => RightsFromAccessMask(base.AccessMask);

	public PipeAccessRule(string identity, PipeAccessRights rights, AccessControlType type)
		: this(new NTAccount(identity), AccessMaskFromRights(rights, type), isInherited: false, type)
	{
	}

	public PipeAccessRule(IdentityReference identity, PipeAccessRights rights, AccessControlType type)
		: this(identity, AccessMaskFromRights(rights, type), isInherited: false, type)
	{
	}

	internal PipeAccessRule(IdentityReference identity, int accessMask, bool isInherited, AccessControlType type)
		: base(identity, accessMask, isInherited, InheritanceFlags.None, PropagationFlags.None, type)
	{
	}

	internal static int AccessMaskFromRights(PipeAccessRights rights, AccessControlType controlType)
	{
		if (rights >= (PipeAccessRights)0 && rights <= (PipeAccessRights.FullControl | PipeAccessRights.AccessSystemSecurity))
		{
			switch (controlType)
			{
			case AccessControlType.Allow:
				rights |= PipeAccessRights.Synchronize;
				break;
			case AccessControlType.Deny:
				if (rights != PipeAccessRights.FullControl)
				{
					rights &= ~PipeAccessRights.Synchronize;
				}
				break;
			}
			return (int)rights;
		}
		throw new ArgumentOutOfRangeException("rights", SR.GetString("ArgumentOutOfRange_NeedValidPipeAccessRights"));
	}

	internal static PipeAccessRights RightsFromAccessMask(int accessMask)
	{
		return (PipeAccessRights)accessMask;
	}
}
