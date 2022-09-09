using System.Collections.Generic;
using System.Security.Permissions;
using Microsoft.Contracts;

namespace System.Security.Cryptography;

internal static class CoreCryptoConfig
{
	private static Dictionary<string, Type> s_nameMap;

	private static bool? s_enforceFipsAlgorithms;

	private static Dictionary<string, Type> AlgorithmNameMap
	{
		get
		{
			if (s_nameMap == null)
			{
				Dictionary<string, Type> dictionary = new Dictionary<string, Type>(StringComparer.OrdinalIgnoreCase);
				dictionary.Add("AES", typeof(AesCryptoServiceProvider));
				dictionary.Add(typeof(AesCryptoServiceProvider).Name, typeof(AesCryptoServiceProvider));
				dictionary.Add(typeof(AesCryptoServiceProvider).FullName, typeof(AesCryptoServiceProvider));
				dictionary.Add(typeof(AesManaged).Name, typeof(AesManaged));
				dictionary.Add(typeof(AesManaged).FullName, typeof(AesManaged));
				dictionary.Add("ECDsa", typeof(ECDsaCng));
				dictionary.Add(typeof(ECDsaCng).Name, typeof(ECDsaCng));
				dictionary.Add(typeof(ECDsaCng).FullName, typeof(ECDsaCng));
				dictionary.Add("ECDH", typeof(ECDiffieHellmanCng));
				dictionary.Add("ECDiffieHellman", typeof(ECDiffieHellmanCng));
				dictionary.Add(typeof(ECDiffieHellmanCng).Name, typeof(ECDiffieHellmanCng));
				dictionary.Add(typeof(ECDiffieHellmanCng).FullName, typeof(ECDiffieHellmanCng));
				s_nameMap = dictionary;
			}
			return s_nameMap;
		}
	}

	internal static bool EnforceFipsAlgorithms
	{
		get
		{
			if (!s_enforceFipsAlgorithms.HasValue)
			{
				try
				{
					using (new SHA1Managed())
					{
						s_enforceFipsAlgorithms = false;
					}
				}
				catch (InvalidOperationException)
				{
					s_enforceFipsAlgorithms = true;
				}
			}
			return s_enforceFipsAlgorithms.Value;
		}
	}

	[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
	public static T CreateFromName<T>(string name) where T : class
	{
		Contract.Requires(name != null);
		if (AlgorithmNameMap.TryGetValue(name, out var value))
		{
			return (T)Activator.CreateInstance(value);
		}
		return (T)CryptoConfig.CreateFromName(name);
	}
}
