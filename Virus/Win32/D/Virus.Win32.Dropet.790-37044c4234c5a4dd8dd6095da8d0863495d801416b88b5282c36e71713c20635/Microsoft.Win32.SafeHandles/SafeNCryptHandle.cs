using System;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Security;
using System.Security.Permissions;
using Microsoft.Contracts;

namespace Microsoft.Win32.SafeHandles;

[SecurityCritical(SecurityCriticalScope.Everything)]
[SecurityPermission(SecurityAction.InheritanceDemand, UnmanagedCode = true)]
[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
[SecurityPermission(SecurityAction.LinkDemand, UnmanagedCode = true)]
public abstract class SafeNCryptHandle : SafeHandleZeroOrMinusOneIsInvalid
{
	private enum OwnershipState
	{
		Owner,
		Duplicate,
		Holder
	}

	private OwnershipState m_ownershipState;

	private SafeNCryptHandle m_holder;

	private SafeNCryptHandle Holder
	{
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		get
		{
			Contract.Requires((m_ownershipState == OwnershipState.Duplicate && m_holder != null) || (m_ownershipState != OwnershipState.Duplicate && m_holder == null));
			Contract.Requires(m_holder == null || m_holder.m_ownershipState == OwnershipState.Holder);
			return m_holder;
		}
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		set
		{
			m_holder = value;
			m_ownershipState = OwnershipState.Duplicate;
		}
	}

	protected SafeNCryptHandle()
		: base(ownsHandle: true)
	{
	}

	internal T Duplicate<T>() where T : SafeNCryptHandle, new()
	{
		if (m_ownershipState == OwnershipState.Owner)
		{
			return DuplicateOwnerHandle<T>();
		}
		return DuplicateDuplicatedHandle<T>();
	}

	private T DuplicateDuplicatedHandle<T>() where T : SafeNCryptHandle, new()
	{
		bool success = false;
		T result = new T();
		RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
		}
		finally
		{
			Holder.DangerousAddRef(ref success);
			result.SetHandle(Holder.DangerousGetHandle());
			result.Holder = Holder;
		}
		return result;
	}

	private T DuplicateOwnerHandle<T>() where T : SafeNCryptHandle, new()
	{
		bool success = false;
		T val = new T();
		T result = new T();
		RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
		}
		finally
		{
			val.m_ownershipState = OwnershipState.Holder;
			val.SetHandle(DangerousGetHandle());
			GC.SuppressFinalize(val);
			Holder = val;
			val.DangerousAddRef(ref success);
			result.SetHandle(val.DangerousGetHandle());
			result.Holder = val;
		}
		return result;
	}

	protected override bool ReleaseHandle()
	{
		if (m_ownershipState == OwnershipState.Duplicate)
		{
			Holder.DangerousRelease();
			return true;
		}
		return ReleaseNativeHandle();
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	protected abstract bool ReleaseNativeHandle();
}
