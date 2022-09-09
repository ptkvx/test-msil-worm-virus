using System;

namespace MBackMonitor;

public class MBackMonitorInfo
{
	private DateTime dtSvcStartTime;

	private DateTime dtSvcEndTime;

	private DateTime dtAppStartTime;

	private DateTime dtAppEndTime;

	private bool shouldVerify;

	private SessionEndReason _SessionEndReason;

	public DateTime ServiceStartTime
	{
		get
		{
			return dtSvcStartTime;
		}
		set
		{
			dtSvcStartTime = value;
		}
	}

	public DateTime ServiceEndTime
	{
		get
		{
			return dtSvcEndTime;
		}
		set
		{
			dtSvcEndTime = value;
		}
	}

	public DateTime ApplicationStartTime
	{
		get
		{
			return dtAppStartTime;
		}
		set
		{
			dtAppStartTime = value;
		}
	}

	public DateTime ApplicationEndTime
	{
		get
		{
			return dtAppEndTime;
		}
		set
		{
			dtAppEndTime = value;
		}
	}

	public bool ShouldVerify
	{
		get
		{
			return shouldVerify;
		}
		set
		{
			shouldVerify = value;
		}
	}

	public SessionEndReason SessionEndReason
	{
		get
		{
			return _SessionEndReason;
		}
		set
		{
			_SessionEndReason = value;
		}
	}
}
