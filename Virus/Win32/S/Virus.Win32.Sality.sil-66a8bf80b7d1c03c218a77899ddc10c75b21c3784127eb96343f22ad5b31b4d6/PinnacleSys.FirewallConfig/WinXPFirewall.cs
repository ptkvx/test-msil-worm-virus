using System;
using System.Collections;

namespace PinnacleSys.FirewallConfig;

public class WinXPFirewall
{
	private INetFwMgr m_Mgr = null;

	public bool Available => m_Mgr != null;

	public WinXPFirewall()
	{
		try
		{
			m_Mgr = (INetFwMgr)Activator.CreateInstance(Type.GetTypeFromProgID("hnetcfg.fwmgr"));
		}
		catch (Exception)
		{
		}
	}

	public bool AddApp(string AppName, string ProcessImageFileName, bool bEnable, NET_FW_SCOPE_ scope)
	{
		bool result = false;
		try
		{
			INetFwAuthorizedApplication netFwAuthorizedApplication = (INetFwAuthorizedApplication)Activator.CreateInstance(Type.GetTypeFromProgID("hnetcfg.fwauthorizedapplication"));
			netFwAuthorizedApplication.Name = AppName;
			netFwAuthorizedApplication.ProcessImageFileName = ProcessImageFileName;
			netFwAuthorizedApplication.Enabled = bEnable;
			netFwAuthorizedApplication.Scope = scope;
			m_Mgr.LocalPolicy.CurrentProfile.AuthorizedApplications.Add(netFwAuthorizedApplication);
			result = true;
			return result;
		}
		catch
		{
			return result;
		}
	}

	public bool AddPort(int port, NET_FW_IP_PROTOCOL_ protocol, string name, bool enable, bool local)
	{
		try
		{
			INetFwOpenPort port2 = GetPort(port, protocol);
			if (port2 != null)
			{
				port2.Enabled = enable;
				port2.Scope = NET_FW_SCOPE_.NET_FW_SCOPE_LOCAL_SUBNET;
				return true;
			}
			port2 = (INetFwOpenPort)Activator.CreateInstance(Type.GetTypeFromProgID("hnetcfg.FwOpenPort"));
			port2.Enabled = enable;
			port2.Scope = NET_FW_SCOPE_.NET_FW_SCOPE_LOCAL_SUBNET;
			port2.Name = name;
			port2.Port = port;
			port2.Protocol = protocol;
			INetFwProfile currentProfile = m_Mgr.LocalPolicy.CurrentProfile;
			currentProfile.GloballyOpenPorts.Add(port2);
			return true;
		}
		catch (Exception)
		{
			return false;
		}
	}

	public bool RemovePort(int port, NET_FW_IP_PROTOCOL_ protocol)
	{
		try
		{
			INetFwProfile currentProfile = m_Mgr.LocalPolicy.CurrentProfile;
			currentProfile.GloballyOpenPorts.Remove(port, protocol);
			return true;
		}
		catch (Exception)
		{
			return false;
		}
	}

	public bool IsPortEnabled(int port, NET_FW_IP_PROTOCOL_ protocol)
	{
		return GetPort(port, protocol)?.Enabled ?? false;
	}

	public INetFwOpenPort GetPort(int port, NET_FW_IP_PROTOCOL_ protocol)
	{
		INetFwProfile currentProfile = m_Mgr.LocalPolicy.CurrentProfile;
		IEnumerator enumerator = currentProfile.GloballyOpenPorts.GetEnumerator();
		INetFwOpenPort netFwOpenPort = __GetPort(port, protocol, enumerator);
		if (netFwOpenPort != null)
		{
			return netFwOpenPort;
		}
		IEnumerator enumerator2 = currentProfile.Services.GetEnumerator();
		do
		{
			if (enumerator2.MoveNext())
			{
				INetFwService netFwService = (INetFwService)enumerator2.Current;
				enumerator = netFwService.GloballyOpenPorts.GetEnumerator();
				netFwOpenPort = __GetPort(port, protocol, enumerator);
				continue;
			}
			return null;
		}
		while (netFwOpenPort == null);
		return netFwOpenPort;
	}

	private INetFwOpenPort __GetPort(int port, NET_FW_IP_PROTOCOL_ protocol, IEnumerator iter)
	{
		iter.Reset();
		INetFwOpenPort netFwOpenPort;
		do
		{
			if (iter.MoveNext())
			{
				netFwOpenPort = (INetFwOpenPort)iter.Current;
				continue;
			}
			return null;
		}
		while (netFwOpenPort.Port != port || netFwOpenPort.Protocol != protocol);
		return netFwOpenPort;
	}
}
