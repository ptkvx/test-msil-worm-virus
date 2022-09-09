using System;
using Microsoft.MediaCenter.TV.Tuning;

namespace Microsoft.MediaCenter.TV.Tuners;

public class SmartCardApplication
{
	private ApplicationTypeType m_AppType;

	private ushort m_Version;

	private string m_Name;

	private Uri m_URL;

	public Uri URL
	{
		get
		{
			return m_URL;
		}
		internal set
		{
			m_URL = value;
		}
	}

	public string Name
	{
		get
		{
			return m_Name;
		}
		internal set
		{
			m_Name = value;
		}
	}

	public ushort Version
	{
		get
		{
			return m_Version;
		}
		internal set
		{
			m_Version = value;
		}
	}

	public ApplicationTypeType ApplicationType
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return m_AppType;
		}
		internal set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			m_AppType = value;
		}
	}

	internal SmartCardApplication(ApplicationTypeType appType, ushort version, string name, Uri url)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		m_AppType = appType;
		m_Version = version;
		m_Name = name;
		m_URL = url;
		base._002Ector();
	}
}
