using System.Security;
using System.Security.Permissions;

namespace System.Diagnostics.PerformanceData;

[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
public sealed class CounterData
{
	private unsafe long* m_offset;

	public unsafe long Value
	{
		[SecurityCritical]
		get
		{
			return *m_offset;
		}
		[SecurityCritical]
		set
		{
			*m_offset = value;
		}
	}

	[SecurityCritical]
	internal unsafe CounterData(long* pCounterData)
	{
		m_offset = pCounterData;
		*m_offset = 0L;
	}
}
