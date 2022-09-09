using System;
using System.IO;
using System.Xml.Serialization;
using Arbus.Common;

namespace MBackMonitor;

public class ScheduleHelper
{
	private static ScheduleHelper objScheduleHelper;

	private ScheduleHelper()
	{
	}

	public static ScheduleHelper CreateScheduleHelper()
	{
		if (objScheduleHelper == null)
		{
			objScheduleHelper = new ScheduleHelper();
		}
		return objScheduleHelper;
	}

	public void PersistStartTime(DateTime dtStartTime)
	{
		MBackMonitorInfo mBackMonitorInfo = ReadInfo();
		if (mBackMonitorInfo == null)
		{
			mBackMonitorInfo = new MBackMonitorInfo();
			mBackMonitorInfo.ShouldVerify = true;
		}
		else if (mBackMonitorInfo.ServiceEndTime == DateTime.MinValue)
		{
			mBackMonitorInfo.ShouldVerify = true;
		}
		mBackMonitorInfo.ServiceStartTime = dtStartTime;
		mBackMonitorInfo.ServiceEndTime = DateTime.MinValue;
		PersistInfo(mBackMonitorInfo);
	}

	public void PersistEndTime(DateTime dtEndTime)
	{
		MBackMonitorInfo mBackMonitorInfo = ReadInfo();
		if (mBackMonitorInfo == null)
		{
			mBackMonitorInfo = new MBackMonitorInfo();
		}
		mBackMonitorInfo.ServiceEndTime = dtEndTime;
		mBackMonitorInfo.SessionEndReason = SessionEndReason.None;
		PersistInfo(mBackMonitorInfo);
	}

	public void PersistSystemShutdown(SessionEndReason sessionEndReason, DateTime dtEndTime)
	{
		MBackMonitorInfo mBackMonitorInfo = ReadInfo();
		if (mBackMonitorInfo == null)
		{
			mBackMonitorInfo = new MBackMonitorInfo();
		}
		mBackMonitorInfo.SessionEndReason = sessionEndReason;
		mBackMonitorInfo.ServiceEndTime = dtEndTime;
		PersistInfo(mBackMonitorInfo);
	}

	public void PersistShouldVerify(bool shouldVerify)
	{
		MBackMonitorInfo mBackMonitorInfo = ReadInfo();
		if (mBackMonitorInfo == null)
		{
			mBackMonitorInfo = new MBackMonitorInfo();
		}
		mBackMonitorInfo.ShouldVerify = shouldVerify;
		PersistInfo(mBackMonitorInfo);
	}

	public bool CheckAppEndTimeDiffrenece(DateTime dtTimeToCheck, TimeSpan allowableTimeSpan)
	{
		bool result = false;
		MBackMonitorInfo mBackMonitorInfo = ReadInfo();
		if (mBackMonitorInfo != null)
		{
			double num = Math.Abs((dtTimeToCheck - mBackMonitorInfo.ApplicationEndTime).TotalMilliseconds);
			if (mBackMonitorInfo.ServiceStartTime == DateTime.MinValue || num < allowableTimeSpan.TotalMilliseconds)
			{
				result = true;
			}
		}
		return result;
	}

	private MBackMonitorInfo ReadInfo()
	{
		string monitorInformationFilePath = Helper.GetMonitorInformationFilePath();
		FileStream fileStream = null;
		MBackMonitorInfo result = null;
		try
		{
			fileStream = new FileStream(monitorInformationFilePath, FileMode.Open, FileAccess.Read, FileShare.Read);
			if (fileStream != null)
			{
				XmlSerializer xmlSerializer = new XmlSerializer(typeof(MBackMonitorInfo));
				result = (MBackMonitorInfo)xmlSerializer.Deserialize(fileStream);
				return result;
			}
			return result;
		}
		catch (Exception)
		{
			return result;
		}
		finally
		{
			if (fileStream != null)
			{
				fileStream.Close();
				fileStream = null;
			}
		}
	}

	private void PersistInfo(MBackMonitorInfo objMBackMonitorInfo)
	{
		string monitorInformationFilePath = Helper.GetMonitorInformationFilePath();
		FileStream fileStream = null;
		try
		{
			if (!File.Exists(monitorInformationFilePath))
			{
				IntPtr intPtr = Win32Interop.CreateFileWrapper(monitorInformationFilePath, (EFileAccess)536870912, (EFileShare)2, false, (ECreationDisposition)1);
				if (intPtr.ToInt32() != -1)
				{
					Win32Interop.CloseHandle(intPtr);
				}
			}
			fileStream = new FileStream(monitorInformationFilePath, FileMode.Truncate, FileAccess.Write);
			if (fileStream != null)
			{
				XmlSerializer xmlSerializer = new XmlSerializer(typeof(MBackMonitorInfo));
				xmlSerializer.Serialize(fileStream, objMBackMonitorInfo);
			}
		}
		finally
		{
			if (fileStream != null)
			{
				fileStream.Close();
				fileStream = null;
			}
		}
	}
}
