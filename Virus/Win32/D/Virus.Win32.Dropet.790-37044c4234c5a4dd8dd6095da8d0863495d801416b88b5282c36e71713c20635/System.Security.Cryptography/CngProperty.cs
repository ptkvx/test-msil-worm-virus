using System.Security.Permissions;
using Microsoft.Contracts;

namespace System.Security.Cryptography;

[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
public struct CngProperty : IEquatable<CngProperty>
{
	private string m_name;

	private CngPropertyOptions m_propertyOptions;

	private byte[] m_value;

	private int? m_hashCode;

	public string Name => m_name;

	public CngPropertyOptions Options => m_propertyOptions;

	internal byte[] Value => m_value;

	public CngProperty(string name, byte[] value, CngPropertyOptions options)
	{
		Contract.Requires((name != null) ? null : new ArgumentNullException("name"));
		m_name = name;
		m_propertyOptions = options;
		m_hashCode = null;
		if (value != null)
		{
			m_value = value.Clone() as byte[];
		}
		else
		{
			m_value = null;
		}
	}

	public byte[] GetValue()
	{
		byte[] result = null;
		if (m_value != null)
		{
			result = m_value.Clone() as byte[];
		}
		return result;
	}

	public static bool operator ==(CngProperty left, CngProperty right)
	{
		return left.Equals(right);
	}

	public static bool operator !=(CngProperty left, CngProperty right)
	{
		return !left.Equals(right);
	}

	public override bool Equals(object obj)
	{
		if (obj != null && obj is CngProperty)
		{
			return Equals((CngProperty)obj);
		}
		return false;
	}

	public bool Equals(CngProperty other)
	{
		if (!string.Equals(Name, other.Name, StringComparison.Ordinal))
		{
			return false;
		}
		if (Options != other.Options)
		{
			return false;
		}
		if (m_value == null)
		{
			return other.m_value == null;
		}
		if (other.m_value == null)
		{
			return false;
		}
		if (m_value.Length != other.m_value.Length)
		{
			return false;
		}
		int num = 0;
		while (true)
		{
			if (num < m_value.Length)
			{
				if (m_value[num] != other.m_value[num])
				{
					break;
				}
				num++;
				continue;
			}
			return true;
		}
		return false;
	}

	public override int GetHashCode()
	{
		if (!m_hashCode.HasValue)
		{
			int num = Name.GetHashCode() ^ Options.GetHashCode();
			if (m_value != null)
			{
				for (int i = 0; i < m_value.Length; i++)
				{
					int num2 = m_value[i] << i % 4 * 8;
					num ^= num2;
				}
			}
			m_hashCode = num;
		}
		return m_hashCode.Value;
	}
}
