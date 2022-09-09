using System.Runtime.CompilerServices;
using System.Security.Permissions;
using Microsoft.Contracts;
using Microsoft.Win32.SafeHandles;

namespace System.Security.Cryptography;

[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
public sealed class CngKey : IDisposable
{
	private SafeNCryptKeyHandle m_keyHandle;

	private SafeNCryptProviderHandle m_kspHandle;

	public CngAlgorithmGroup AlgorithmGroup
	{
		[SecurityCritical]
		[Pure]
		get
		{
			string propertyAsString = NCryptNative.GetPropertyAsString(m_keyHandle, "Algorithm Group", CngPropertyOptions.None);
			if (propertyAsString == null)
			{
				return null;
			}
			return new CngAlgorithmGroup(propertyAsString);
		}
	}

	public CngAlgorithm Algorithm
	{
		[SecurityCritical]
		get
		{
			string propertyAsString = NCryptNative.GetPropertyAsString(m_keyHandle, "Algorithm Name", CngPropertyOptions.None);
			return new CngAlgorithm(propertyAsString);
		}
	}

	public CngExportPolicies ExportPolicy
	{
		[SecurityCritical]
		get
		{
			return (CngExportPolicies)NCryptNative.GetPropertyAsDWord(m_keyHandle, "Export Policy", CngPropertyOptions.None);
		}
	}

	public SafeNCryptKeyHandle Handle
	{
		[SecurityCritical]
		[SecurityPermission(SecurityAction.Demand, UnmanagedCode = true)]
		get
		{
			return m_keyHandle.Duplicate();
		}
	}

	public bool IsEphemeral
	{
		[SecurityCritical]
		[Pure]
		get
		{
			bool foundProperty;
			byte[] property = NCryptNative.GetProperty(m_keyHandle, "CLR IsEphemeral", CngPropertyOptions.CustomProperty, out foundProperty);
			if (foundProperty && property != null && property.Length == 1)
			{
				return property[0] == 1;
			}
			return false;
		}
		[SecurityCritical]
		private set
		{
			NCryptNative.SetProperty(m_keyHandle, "CLR IsEphemeral", new byte[1] { (byte)(value ? 1 : 0) }, CngPropertyOptions.CustomProperty);
		}
	}

	public bool IsMachineKey
	{
		[SecurityCritical]
		get
		{
			int propertyAsDWord = NCryptNative.GetPropertyAsDWord(m_keyHandle, "Key Type", CngPropertyOptions.None);
			return (propertyAsDWord & 0x20) == 32;
		}
	}

	public string KeyName
	{
		[SecurityCritical]
		get
		{
			if (IsEphemeral)
			{
				return null;
			}
			return NCryptNative.GetPropertyAsString(m_keyHandle, "Name", CngPropertyOptions.None);
		}
	}

	public int KeySize
	{
		[SecurityCritical]
		get
		{
			return NCryptNative.GetPropertyAsDWord(m_keyHandle, "Length", CngPropertyOptions.None);
		}
	}

	public CngKeyUsages KeyUsage
	{
		[SecurityCritical]
		get
		{
			return (CngKeyUsages)NCryptNative.GetPropertyAsDWord(m_keyHandle, "Key Usage", CngPropertyOptions.None);
		}
	}

	public IntPtr ParentWindowHandle
	{
		[SecurityCritical]
		get
		{
			return NCryptNative.GetPropertyAsIntPtr(m_keyHandle, "HWND Handle", CngPropertyOptions.None);
		}
		[SecurityCritical]
		[SecurityPermission(SecurityAction.Demand, UnmanagedCode = true)]
		set
		{
			NCryptNative.SetProperty(m_keyHandle, "HWND Handle", value, CngPropertyOptions.None);
		}
	}

	public CngProvider Provider
	{
		[SecurityCritical]
		get
		{
			string propertyAsString = NCryptNative.GetPropertyAsString(m_kspHandle, "Name", CngPropertyOptions.None);
			if (propertyAsString == null)
			{
				return null;
			}
			return new CngProvider(propertyAsString);
		}
	}

	public SafeNCryptProviderHandle ProviderHandle
	{
		[SecurityCritical]
		[SecurityPermission(SecurityAction.Demand, UnmanagedCode = true)]
		get
		{
			return m_kspHandle.Duplicate();
		}
	}

	public string UniqueName
	{
		[SecurityCritical]
		get
		{
			if (IsEphemeral)
			{
				return null;
			}
			return NCryptNative.GetPropertyAsString(m_keyHandle, "Unique Name", CngPropertyOptions.None);
		}
	}

	public CngUIPolicy UIPolicy
	{
		[SecurityCritical]
		get
		{
			NCryptNative.NCRYPT_UI_POLICY propertyAsStruct = NCryptNative.GetPropertyAsStruct<NCryptNative.NCRYPT_UI_POLICY>(m_keyHandle, "UI Policy", CngPropertyOptions.None);
			string propertyAsString = NCryptNative.GetPropertyAsString(m_keyHandle, "Use Context", CngPropertyOptions.None);
			return new CngUIPolicy(propertyAsStruct.dwFlags, propertyAsStruct.pszFriendlyName, propertyAsStruct.pszDescription, propertyAsString, propertyAsStruct.pszCreationTitle);
		}
	}

	[SecurityCritical]
	private CngKey(SafeNCryptProviderHandle kspHandle, SafeNCryptKeyHandle keyHandle)
	{
		Contract.Requires(keyHandle != null && !keyHandle.IsInvalid && !keyHandle.IsClosed);
		Contract.Requires(kspHandle != null && !kspHandle.IsInvalid && !kspHandle.IsClosed);
		m_keyHandle = keyHandle;
		m_kspHandle = kspHandle;
	}

	[SecurityCritical]
	internal KeyContainerPermission BuildKeyContainerPermission(KeyContainerPermissionFlags flags)
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected O, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		KeyContainerPermission val = null;
		if (!IsEphemeral)
		{
			string text = null;
			string providerName = null;
			try
			{
				text = KeyName;
				providerName = NCryptNative.GetPropertyAsString(m_kspHandle, "Name", CngPropertyOptions.None);
			}
			catch (CryptographicException)
			{
			}
			if (text != null)
			{
				KeyContainerPermissionAccessEntry val2 = new KeyContainerPermissionAccessEntry(text, flags);
				val2.set_ProviderName(providerName);
				val = new KeyContainerPermission((KeyContainerPermissionFlags)0);
				val.get_AccessEntries().Add(val2);
			}
			else
			{
				val = new KeyContainerPermission(flags);
			}
		}
		return val;
	}

	public static CngKey Create(CngAlgorithm algorithm)
	{
		return Create(algorithm, null);
	}

	public static CngKey Create(CngAlgorithm algorithm, string keyName)
	{
		return Create(algorithm, keyName, null);
	}

	[SecurityCritical]
	public static CngKey Create(CngAlgorithm algorithm, string keyName, CngKeyCreationParameters creationParameters)
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		if (algorithm == null)
		{
			throw new ArgumentNullException("algorithm");
		}
		if (creationParameters == null)
		{
			creationParameters = new CngKeyCreationParameters();
		}
		if (!NCryptNative.NCryptSupported)
		{
			throw new PlatformNotSupportedException(SR.GetString("Cryptography_PlatformNotSupported"));
		}
		if (keyName != null)
		{
			KeyContainerPermissionAccessEntry val = new KeyContainerPermissionAccessEntry(keyName, (KeyContainerPermissionFlags)1);
			val.set_ProviderName(creationParameters.Provider.Provider);
			KeyContainerPermission val2 = new KeyContainerPermission((KeyContainerPermissionFlags)0);
			val2.get_AccessEntries().Add(val);
			((CodeAccessPermission)val2).Demand();
		}
		SafeNCryptProviderHandle safeNCryptProviderHandle = NCryptNative.OpenStorageProvider(creationParameters.Provider.Provider);
		SafeNCryptKeyHandle safeNCryptKeyHandle = NCryptNative.CreatePersistedKey(safeNCryptProviderHandle, algorithm.Algorithm, keyName, creationParameters.KeyCreationOptions);
		SetKeyProperties(safeNCryptKeyHandle, creationParameters);
		NCryptNative.FinalizeKey(safeNCryptKeyHandle);
		CngKey cngKey = new CngKey(safeNCryptProviderHandle, safeNCryptKeyHandle);
		if (keyName == null)
		{
			cngKey.IsEphemeral = true;
		}
		return cngKey;
	}

	[SecurityCritical]
	public void Delete()
	{
		KeyContainerPermission val = BuildKeyContainerPermission((KeyContainerPermissionFlags)4);
		if (val != null)
		{
			((CodeAccessPermission)val).Demand();
		}
		NCryptNative.DeleteKey(m_keyHandle);
		Dispose();
	}

	[SecurityCritical]
	public void Dispose()
	{
		if (m_kspHandle != null)
		{
			m_kspHandle.Dispose();
		}
		if (m_keyHandle != null)
		{
			m_keyHandle.Dispose();
		}
	}

	public static bool Exists(string keyName)
	{
		return Exists(keyName, CngProvider.MicrosoftSoftwareKeyStorageProvider);
	}

	public static bool Exists(string keyName, CngProvider provider)
	{
		return Exists(keyName, provider, CngKeyOpenOptions.None);
	}

	[SecurityCritical]
	public static bool Exists(string keyName, CngProvider provider, CngKeyOpenOptions options)
	{
		if (keyName == null)
		{
			throw new ArgumentNullException("keyName");
		}
		if (provider == null)
		{
			throw new ArgumentNullException("provider");
		}
		if (!NCryptNative.NCryptSupported)
		{
			throw new PlatformNotSupportedException(SR.GetString("Cryptography_PlatformNotSupported"));
		}
		using SafeNCryptProviderHandle hProvider = NCryptNative.OpenStorageProvider(provider.Provider);
		SafeNCryptKeyHandle phKey = null;
		try
		{
			NCryptNative.ErrorCode errorCode = NCryptNative.UnsafeNativeMethods.NCryptOpenKey(hProvider, out phKey, keyName, 0, options);
			bool flag = errorCode == NCryptNative.ErrorCode.KeyDoesNotExist || errorCode == NCryptNative.ErrorCode.NotFound;
			if (errorCode != 0 && !flag)
			{
				throw new CryptographicException((int)errorCode);
			}
			return errorCode == NCryptNative.ErrorCode.Success;
		}
		finally
		{
			phKey?.Dispose();
		}
	}

	public static CngKey Import(byte[] keyBlob, CngKeyBlobFormat format)
	{
		return Import(keyBlob, format, CngProvider.MicrosoftSoftwareKeyStorageProvider);
	}

	[SecurityCritical]
	public static CngKey Import(byte[] keyBlob, CngKeyBlobFormat format, CngProvider provider)
	{
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		if (keyBlob == null)
		{
			throw new ArgumentNullException("keyBlob");
		}
		if (format == null)
		{
			throw new ArgumentNullException("format");
		}
		if (provider == null)
		{
			throw new ArgumentNullException("provider");
		}
		if (!NCryptNative.NCryptSupported)
		{
			throw new PlatformNotSupportedException(SR.GetString("Cryptography_PlatformNotSupported"));
		}
		if (!(format == CngKeyBlobFormat.EccPublicBlob) && !(format == CngKeyBlobFormat.GenericPublicBlob))
		{
			((CodeAccessPermission)new KeyContainerPermission((KeyContainerPermissionFlags)16)).Demand();
		}
		SafeNCryptProviderHandle safeNCryptProviderHandle = NCryptNative.OpenStorageProvider(provider.Provider);
		SafeNCryptKeyHandle keyHandle = NCryptNative.ImportKey(safeNCryptProviderHandle, keyBlob, format.Format);
		CngKey cngKey = new CngKey(safeNCryptProviderHandle, keyHandle);
		cngKey.IsEphemeral = format != CngKeyBlobFormat.OpaqueTransportBlob;
		return cngKey;
	}

	[SecurityCritical]
	public byte[] Export(CngKeyBlobFormat format)
	{
		if (format == null)
		{
			throw new ArgumentNullException("format");
		}
		KeyContainerPermission val = BuildKeyContainerPermission((KeyContainerPermissionFlags)32);
		if (val != null)
		{
			((CodeAccessPermission)val).Demand();
		}
		return NCryptNative.ExportKey(m_keyHandle, format.Format);
	}

	[SecurityCritical]
	[SecurityPermission(SecurityAction.Demand, UnmanagedCode = true)]
	public CngProperty GetProperty(string name, CngPropertyOptions options)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		bool foundProperty;
		byte[] property = NCryptNative.GetProperty(m_keyHandle, name, options, out foundProperty);
		if (!foundProperty)
		{
			throw new CryptographicException(-2146893807);
		}
		return new CngProperty(name, property, options);
	}

	[SecurityCritical]
	[SecurityPermission(SecurityAction.Demand, UnmanagedCode = true)]
	public bool HasProperty(string name, CngPropertyOptions options)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		NCryptNative.GetProperty(m_keyHandle, name, options, out var foundProperty);
		return foundProperty;
	}

	public static CngKey Open(string keyName)
	{
		return Open(keyName, CngProvider.MicrosoftSoftwareKeyStorageProvider);
	}

	public static CngKey Open(string keyName, CngProvider provider)
	{
		return Open(keyName, provider, CngKeyOpenOptions.None);
	}

	[SecurityCritical]
	public static CngKey Open(string keyName, CngProvider provider, CngKeyOpenOptions openOptions)
	{
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		if (keyName == null)
		{
			throw new ArgumentNullException("keyName");
		}
		if (provider == null)
		{
			throw new ArgumentNullException("provider");
		}
		if (!NCryptNative.NCryptSupported)
		{
			throw new PlatformNotSupportedException(SR.GetString("Cryptography_PlatformNotSupported"));
		}
		KeyContainerPermissionAccessEntry val = new KeyContainerPermissionAccessEntry(keyName, (KeyContainerPermissionFlags)2);
		val.set_ProviderName(provider.Provider);
		KeyContainerPermission val2 = new KeyContainerPermission((KeyContainerPermissionFlags)0);
		val2.get_AccessEntries().Add(val);
		((CodeAccessPermission)val2).Demand();
		SafeNCryptProviderHandle safeNCryptProviderHandle = NCryptNative.OpenStorageProvider(provider.Provider);
		SafeNCryptKeyHandle keyHandle = NCryptNative.OpenKey(safeNCryptProviderHandle, keyName, openOptions);
		return new CngKey(safeNCryptProviderHandle, keyHandle);
	}

	[SecurityCritical]
	[SecurityPermission(SecurityAction.Demand, UnmanagedCode = true)]
	public static CngKey Open(SafeNCryptKeyHandle keyHandle, CngKeyHandleOpenOptions keyHandleOpenOptions)
	{
		if (keyHandle == null)
		{
			throw new ArgumentNullException("keyHandle");
		}
		if (!keyHandle.IsClosed && !keyHandle.IsInvalid)
		{
			SafeNCryptKeyHandle keyHandle2 = keyHandle.Duplicate();
			SafeNCryptProviderHandle safeNCryptProviderHandle = new SafeNCryptProviderHandle();
			RuntimeHelpers.PrepareConstrainedRegions();
			try
			{
			}
			finally
			{
				IntPtr propertyAsIntPtr = NCryptNative.GetPropertyAsIntPtr(keyHandle, "Provider Handle", CngPropertyOptions.None);
				safeNCryptProviderHandle.SetHandleValue(propertyAsIntPtr);
			}
			CngKey cngKey = null;
			bool flag = false;
			try
			{
				cngKey = new CngKey(safeNCryptProviderHandle, keyHandle2);
				bool flag2 = (keyHandleOpenOptions & CngKeyHandleOpenOptions.EphemeralKey) == CngKeyHandleOpenOptions.EphemeralKey;
				if (!cngKey.IsEphemeral && flag2)
				{
					cngKey.IsEphemeral = true;
				}
				else if (cngKey.IsEphemeral && !flag2)
				{
					throw new ArgumentException(SR.GetString("Cryptography_OpenEphemeralKeyHandleWithoutEphemeralFlag"), "keyHandleOpenOptions");
				}
				flag = true;
			}
			finally
			{
				if (!flag)
				{
					cngKey?.Dispose();
				}
			}
			return cngKey;
		}
		throw new ArgumentException(SR.GetString("Cryptography_OpenInvalidHandle"), "keyHandle");
	}

	[SecurityCritical]
	private static void SetKeyProperties(SafeNCryptKeyHandle keyHandle, CngKeyCreationParameters creationParameters)
	{
		Contract.Requires(keyHandle != null && !keyHandle.IsInvalid && !keyHandle.IsClosed);
		Contract.Requires(creationParameters != null);
		if (creationParameters.ExportPolicy.HasValue)
		{
			NCryptNative.SetProperty(keyHandle, "Export Policy", (int)creationParameters.ExportPolicy.Value, CngPropertyOptions.Persist);
		}
		if (creationParameters.KeyUsage.HasValue)
		{
			NCryptNative.SetProperty(keyHandle, "Key Usage", (int)creationParameters.KeyUsage.Value, CngPropertyOptions.Persist);
		}
		if (creationParameters.ParentWindowHandle != IntPtr.Zero)
		{
			NCryptNative.SetProperty(keyHandle, "HWND Handle", creationParameters.ParentWindowHandle, CngPropertyOptions.None);
		}
		if (creationParameters.UIPolicy != null)
		{
			NCryptNative.NCRYPT_UI_POLICY value = default(NCryptNative.NCRYPT_UI_POLICY);
			value.dwVersion = 1;
			value.dwFlags = creationParameters.UIPolicy.ProtectionLevel;
			value.pszCreationTitle = creationParameters.UIPolicy.CreationTitle;
			value.pszFriendlyName = creationParameters.UIPolicy.FriendlyName;
			value.pszDescription = creationParameters.UIPolicy.Description;
			NCryptNative.SetProperty(keyHandle, "UI Policy", value, CngPropertyOptions.Persist);
			if (creationParameters.UIPolicy.UseContext != null)
			{
				NCryptNative.SetProperty(keyHandle, "Use Context", creationParameters.UIPolicy.UseContext, CngPropertyOptions.Persist);
			}
		}
		foreach (CngProperty item in creationParameters.ParametersNoDemand)
		{
			NCryptNative.SetProperty(keyHandle, item.Name, item.Value, item.Options);
		}
	}

	[SecurityCritical]
	[SecurityPermission(SecurityAction.Demand, UnmanagedCode = true)]
	public void SetProperty(CngProperty property)
	{
		NCryptNative.SetProperty(m_keyHandle, property.Name, property.Value, property.Options);
	}
}
