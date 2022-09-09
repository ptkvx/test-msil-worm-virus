using System;
using System.Net;
using System.Web.Services.Protocols;
using SmartAssembly.SmartExceptionsCore;
using ns5;

namespace ns6;

internal class Class28
{
	private string string_0;

	private string string_1;

	private IWebProxy iwebProxy_0;

	public void method_0(IWebProxy iwebProxy_1)
	{
		iwebProxy_0 = iwebProxy_1;
	}

	public void method_1(Delegate2 delegate2_0)
	{
		if (string_1 == null)
		{
			try
			{
				UploadReportLoginService uploadReportLoginService = new UploadReportLoginService();
				if (iwebProxy_0 != null)
				{
					((HttpWebClientProtocol)uploadReportLoginService).set_Proxy(iwebProxy_0);
				}
				string_1 = uploadReportLoginService.GetServerURL(string_0);
				if (string_1.Length == 0)
				{
					throw new ApplicationException("Cannot connect to webservice");
				}
				if (string_1 == "ditto")
				{
					string_1 = Class26.string_0;
				}
			}
			catch (Exception ex)
			{
				delegate2_0("ERR 2001: " + ex.Message);
				return;
			}
		}
		delegate2_0(string_1.StartsWith("ERR") ? string_1 : "OK");
	}

	public void method_2(byte[] byte_0, string string_2, Delegate2 delegate2_0)
	{
		try
		{
			ReportingService reportingService = new ReportingService(string_1);
			if (iwebProxy_0 != null)
			{
				((HttpWebClientProtocol)reportingService).set_Proxy(iwebProxy_0);
			}
			delegate2_0(reportingService.UploadReport(string_0, byte_0, string_2));
		}
		catch (Exception ex)
		{
			delegate2_0("ERR 2002: " + ex.Message);
		}
	}

	public Class28(string string_2)
	{
		string_0 = string_2;
	}
}
