using System.Collections.Generic;
using System.Numeric;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using Microsoft.Contracts;
using Microsoft.Win32;
using Microsoft.Win32.SafeHandles;

namespace System.Security.Cryptography;

internal static class NCryptNative
{
	internal enum BufferType
	{
		KdfHashAlgorithm,
		KdfSecretPrepend,
		KdfSecretAppend,
		KdfHmacKey,
		KdfTlsLabel,
		KdfTlsSeed
	}

	internal enum ErrorCode
	{
		Success = 0,
		BadSignature = -2146893818,
		NotFound = -2146893807,
		KeyDoesNotExist = -2146893802,
		BufferTooSmall = -2146893784
	}

	internal static class KeyPropertyName
	{
		internal const string Algorithm = "Algorithm Name";

		internal const string AlgorithmGroup = "Algorithm Group";

		internal const string ExportPolicy = "Export Policy";

		internal const string KeyType = "Key Type";

		internal const string KeyUsage = "Key Usage";

		internal const string Length = "Length";

		internal const string Name = "Name";

		internal const string ParentWindowHandle = "HWND Handle";

		internal const string ProviderHandle = "Provider Handle";

		internal const string UIPolicy = "UI Policy";

		internal const string UniqueName = "Unique Name";

		internal const string UseContext = "Use Context";

		internal const string ClrIsEphemeral = "CLR IsEphemeral";
	}

	internal static class ProviderPropertyName
	{
		internal const string Name = "Name";
	}

	[Flags]
	internal enum SecretAgreementFlags
	{
		None = 0,
		UseSecretAsHmacKey = 1
	}

	internal struct NCRYPT_UI_POLICY
	{
		public int dwVersion;

		public CngUIProtectionLevels dwFlags;

		[MarshalAs(UnmanagedType.LPWStr)]
		public string pszCreationTitle;

		[MarshalAs(UnmanagedType.LPWStr)]
		public string pszFriendlyName;

		[MarshalAs(UnmanagedType.LPWStr)]
		public string pszDescription;
	}

	internal struct NCryptBuffer
	{
		public int cbBuffer;

		public BufferType BufferType;

		public IntPtr pvBuffer;
	}

	internal struct NCryptBufferDesc
	{
		public int ulVersion;

		public int cBuffers;

		public IntPtr pBuffers;
	}

	[SuppressUnmanagedCodeSecurity]
	internal static class UnsafeNativeMethods
	{
		[DllImport("ncrypt.dll", CharSet = CharSet.Unicode)]
		internal static extern ErrorCode NCryptCreatePersistedKey(SafeNCryptProviderHandle hProvider, out SafeNCryptKeyHandle phKey, string pszAlgId, string pszKeyName, int dwLegacyKeySpec, CngKeyCreationOptions dwFlags);

		[DllImport("ncrypt.dll")]
		internal static extern ErrorCode NCryptDeleteKey(SafeNCryptKeyHandle hKey, int flags);

		[DllImport("ncrypt.dll", CharSet = CharSet.Unicode)]
		internal static extern ErrorCode NCryptDeriveKey(SafeNCryptSecretHandle hSharedSecret, string pwszKDF, [In] ref NCryptBufferDesc pParameterList, [Out][MarshalAs(UnmanagedType.LPArray)] byte[] pbDerivedKey, int cbDerivedKey, out int pcbResult, SecretAgreementFlags dwFlags);

		[DllImport("ncrypt.dll", CharSet = CharSet.Unicode)]
		internal static extern ErrorCode NCryptExportKey(SafeNCryptKeyHandle hKey, IntPtr hExportKey, string pszBlobType, IntPtr pParameterList, [Out][MarshalAs(UnmanagedType.LPArray)] byte[] pbOutput, int cbOutput, out int pcbResult, int dwFlags);

		[DllImport("ncrypt.dll")]
		internal static extern ErrorCode NCryptFinalizeKey(SafeNCryptKeyHandle hKey, int dwFlags);

		[DllImport("ncrypt.dll", CharSet = CharSet.Unicode)]
		internal static extern ErrorCode NCryptGetProperty(SafeNCryptHandle hObject, string pszProperty, [Out][MarshalAs(UnmanagedType.LPArray)] byte[] pbOutput, int cbOutput, out int pcbResult, CngPropertyOptions dwFlags);

		[DllImport("ncrypt.dll", CharSet = CharSet.Unicode)]
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
		internal static extern ErrorCode NCryptGetProperty(SafeNCryptHandle hObject, string pszProperty, out IntPtr pbOutput, int cbOutput, out int pcbResult, CngPropertyOptions dwFlags);

		[DllImport("ncrypt.dll", CharSet = CharSet.Unicode)]
		internal static extern ErrorCode NCryptImportKey(SafeNCryptProviderHandle hProvider, IntPtr hImportKey, string pszBlobType, IntPtr pParameterList, out SafeNCryptKeyHandle phKey, [MarshalAs(UnmanagedType.LPArray)] byte[] pbData, int cbData, int dwFlags);

		[DllImport("ncrypt.dll", CharSet = CharSet.Unicode)]
		internal static extern ErrorCode NCryptOpenKey(SafeNCryptProviderHandle hProvider, out SafeNCryptKeyHandle phKey, string pszKeyName, int dwLegacyKeySpec, CngKeyOpenOptions dwFlags);

		[DllImport("ncrypt.dll", CharSet = CharSet.Unicode)]
		internal static extern ErrorCode NCryptOpenStorageProvider(out SafeNCryptProviderHandle phProvider, string pszProviderName, int dwFlags);

		[DllImport("ncrypt.dll")]
		internal static extern ErrorCode NCryptSecretAgreement(SafeNCryptKeyHandle hPrivKey, SafeNCryptKeyHandle hPubKey, out SafeNCryptSecretHandle phSecret, int dwFlags);

		[DllImport("ncrypt.dll", CharSet = CharSet.Unicode)]
		internal static extern ErrorCode NCryptSetProperty(SafeNCryptHandle hObject, string pszProperty, [MarshalAs(UnmanagedType.LPArray)] byte[] pbInput, int cbInput, CngPropertyOptions dwFlags);

		[DllImport("ncrypt.dll", CharSet = CharSet.Unicode)]
		internal static extern ErrorCode NCryptSetProperty(SafeNCryptHandle hObject, string pszProperty, string pbInput, int cbInput, CngPropertyOptions dwFlags);

		[DllImport("ncrypt.dll", CharSet = CharSet.Unicode)]
		internal static extern ErrorCode NCryptSetProperty(SafeNCryptHandle hObject, string pszProperty, IntPtr pbInput, int cbInput, CngPropertyOptions dwFlags);

		[DllImport("ncrypt.dll")]
		internal static extern ErrorCode NCryptSignHash(SafeNCryptKeyHandle hKey, IntPtr pPaddingInfo, [MarshalAs(UnmanagedType.LPArray)] byte[] pbHashValue, int cbHashValue, [MarshalAs(UnmanagedType.LPArray)] byte[] pbSignature, int cbSignature, out int pcbResult, int dwFlags);

		[DllImport("ncrypt.dll")]
		internal static extern ErrorCode NCryptVerifySignature(SafeNCryptKeyHandle hKey, IntPtr pPaddingInfo, [MarshalAs(UnmanagedType.LPArray)] byte[] pbHashValue, int cbHashValue, [MarshalAs(UnmanagedType.LPArray)] byte[] pbSignature, int cbSignature, int dwFlags);
	}

	private static bool? s_ncryptSupported;

	internal static bool NCryptSupported
	{
		[SecurityCritical]
		get
		{
			if (!s_ncryptSupported.HasValue)
			{
				using SafeLibraryHandle safeLibraryHandle = Microsoft.Win32.UnsafeNativeMethods.LoadLibraryEx("ncrypt", IntPtr.Zero, 0);
				s_ncryptSupported = !safeLibraryHandle.IsInvalid;
			}
			return s_ncryptSupported.Value;
		}
	}

	internal static byte[] BuildEccPublicBlob(string algorithm, BigInteger x, BigInteger y)
	{
		Contract.Requires(!string.IsNullOrEmpty(algorithm));
		BCryptNative.MapAlgorithmIdToMagic(algorithm, out var algorithmMagic, out var keySize);
		byte[] array = ReverseBytes(FillKeyParameter(x.ToByteArray(), keySize));
		byte[] array2 = ReverseBytes(FillKeyParameter(y.ToByteArray(), keySize));
		byte[] array3 = new byte[8 + array.Length + array2.Length];
		Buffer.BlockCopy(BitConverter.GetBytes((int)algorithmMagic), 0, array3, 0, 4);
		Buffer.BlockCopy(BitConverter.GetBytes(array.Length), 0, array3, 4, 4);
		Buffer.BlockCopy(array, 0, array3, 8, array.Length);
		Buffer.BlockCopy(array2, 0, array3, 8 + array.Length, array2.Length);
		return array3;
	}

	[SecurityCritical]
	internal static SafeNCryptKeyHandle CreatePersistedKey(SafeNCryptProviderHandle provider, string algorithm, string name, CngKeyCreationOptions options)
	{
		Contract.Requires(provider != null && !provider.IsInvalid && !provider.IsClosed);
		Contract.Requires(!string.IsNullOrEmpty(algorithm));
		SafeNCryptKeyHandle phKey = null;
		ErrorCode errorCode = UnsafeNativeMethods.NCryptCreatePersistedKey(provider, out phKey, algorithm, name, 0, options);
		if (errorCode != 0)
		{
			throw new CryptographicException((int)errorCode);
		}
		return phKey;
	}

	[SecurityCritical]
	internal static void DeleteKey(SafeNCryptKeyHandle key)
	{
		Contract.Requires(key != null);
		ErrorCode errorCode = UnsafeNativeMethods.NCryptDeleteKey(key, 0);
		if (errorCode != 0)
		{
			throw new CryptographicException((int)errorCode);
		}
		key.Dispose();
	}

	[SecurityCritical]
	private unsafe static byte[] DeriveKeyMaterial(SafeNCryptSecretHandle secretAgreement, string kdf, string hashAlgorithm, byte[] hmacKey, byte[] secretPrepend, byte[] secretAppend, SecretAgreementFlags flags)
	{
		Contract.Requires(secretAgreement != null);
		Contract.Requires(!string.IsNullOrEmpty(kdf));
		Contract.Requires(!string.IsNullOrEmpty(hashAlgorithm));
		Contract.Requires(hmacKey == null || kdf == "HMAC");
		List<NCryptBuffer> list = new List<NCryptBuffer>();
		IntPtr intPtr = IntPtr.Zero;
		RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
			RuntimeHelpers.PrepareConstrainedRegions();
			try
			{
			}
			finally
			{
				intPtr = Marshal.StringToCoTaskMemUni(hashAlgorithm);
			}
			NCryptBuffer item = default(NCryptBuffer);
			item.cbBuffer = (hashAlgorithm.Length + 1) * 2;
			item.BufferType = BufferType.KdfHashAlgorithm;
			item.pvBuffer = intPtr;
			list.Add(item);
			fixed (byte* ptr = hmacKey)
			{
				fixed (byte* ptr2 = secretPrepend)
				{
					fixed (byte* ptr3 = secretAppend)
					{
						if (ptr != null)
						{
							NCryptBuffer item2 = default(NCryptBuffer);
							item2.cbBuffer = hmacKey.Length;
							item2.BufferType = BufferType.KdfHmacKey;
							item2.pvBuffer = new IntPtr(ptr);
							list.Add(item2);
						}
						if (ptr2 != null)
						{
							NCryptBuffer item3 = default(NCryptBuffer);
							item3.cbBuffer = secretPrepend.Length;
							item3.BufferType = BufferType.KdfSecretPrepend;
							item3.pvBuffer = new IntPtr(ptr2);
							list.Add(item3);
						}
						if (ptr3 != null)
						{
							NCryptBuffer item4 = default(NCryptBuffer);
							item4.cbBuffer = secretAppend.Length;
							item4.BufferType = BufferType.KdfSecretAppend;
							item4.pvBuffer = new IntPtr(ptr3);
							list.Add(item4);
						}
						return DeriveKeyMaterial(secretAgreement, kdf, list.ToArray(), flags);
					}
				}
			}
		}
		finally
		{
			if (intPtr != IntPtr.Zero)
			{
				Marshal.FreeCoTaskMem(intPtr);
			}
		}
	}

	[SecurityCritical]
	private unsafe static byte[] DeriveKeyMaterial(SafeNCryptSecretHandle secretAgreement, string kdf, NCryptBuffer[] parameters, SecretAgreementFlags flags)
	{
		Contract.Requires(secretAgreement != null);
		Contract.Requires(!string.IsNullOrEmpty(kdf));
		Contract.Requires(parameters != null);
		fixed (NCryptBuffer* value = parameters)
		{
			NCryptBufferDesc pParameterList = default(NCryptBufferDesc);
			pParameterList.ulVersion = 0;
			pParameterList.cBuffers = parameters.Length;
			pParameterList.pBuffers = new IntPtr(value);
			int pcbResult = 0;
			ErrorCode errorCode = UnsafeNativeMethods.NCryptDeriveKey(secretAgreement, kdf, ref pParameterList, null, 0, out pcbResult, flags);
			if (errorCode != 0 && errorCode != ErrorCode.BufferTooSmall)
			{
				throw new CryptographicException((int)errorCode);
			}
			byte[] array = new byte[pcbResult];
			errorCode = UnsafeNativeMethods.NCryptDeriveKey(secretAgreement, kdf, ref pParameterList, array, array.Length, out pcbResult, flags);
			if (errorCode != 0)
			{
				throw new CryptographicException((int)errorCode);
			}
			return array;
		}
	}

	[SecurityCritical]
	internal static byte[] DeriveKeyMaterialHash(SafeNCryptSecretHandle secretAgreement, string hashAlgorithm, byte[] secretPrepend, byte[] secretAppend, SecretAgreementFlags flags)
	{
		Contract.Requires(secretAgreement != null);
		Contract.Requires(!string.IsNullOrEmpty(hashAlgorithm));
		return DeriveKeyMaterial(secretAgreement, "HASH", hashAlgorithm, null, secretPrepend, secretAppend, flags);
	}

	[SecurityCritical]
	internal static byte[] DeriveKeyMaterialHmac(SafeNCryptSecretHandle secretAgreement, string hashAlgorithm, byte[] hmacKey, byte[] secretPrepend, byte[] secretAppend, SecretAgreementFlags flags)
	{
		Contract.Requires(secretAgreement != null);
		Contract.Requires(!string.IsNullOrEmpty(hashAlgorithm));
		return DeriveKeyMaterial(secretAgreement, "HMAC", hashAlgorithm, hmacKey, secretPrepend, secretAppend, flags);
	}

	[SecurityCritical]
	internal unsafe static byte[] DeriveKeyMaterialTls(SafeNCryptSecretHandle secretAgreement, byte[] label, byte[] seed, SecretAgreementFlags flags)
	{
		Contract.Requires(secretAgreement != null);
		Contract.Requires(label != null && seed != null);
		NCryptBuffer[] array = new NCryptBuffer[2];
		fixed (byte* value = label)
		{
			fixed (byte* value2 = seed)
			{
				NCryptBuffer nCryptBuffer = default(NCryptBuffer);
				nCryptBuffer.cbBuffer = label.Length;
				nCryptBuffer.BufferType = BufferType.KdfTlsLabel;
				nCryptBuffer.pvBuffer = new IntPtr(value);
				array[0] = nCryptBuffer;
				NCryptBuffer nCryptBuffer2 = default(NCryptBuffer);
				nCryptBuffer2.cbBuffer = seed.Length;
				nCryptBuffer2.BufferType = BufferType.KdfTlsSeed;
				nCryptBuffer2.pvBuffer = new IntPtr(value2);
				array[1] = nCryptBuffer2;
				return DeriveKeyMaterial(secretAgreement, "TLS_PRF", array, flags);
			}
		}
	}

	[SecurityCritical]
	internal static SafeNCryptSecretHandle DeriveSecretAgreement(SafeNCryptKeyHandle privateKey, SafeNCryptKeyHandle otherPartyPublicKey)
	{
		Contract.Requires(privateKey != null);
		Contract.Requires(otherPartyPublicKey != null);
		SafeNCryptSecretHandle phSecret;
		ErrorCode errorCode = UnsafeNativeMethods.NCryptSecretAgreement(privateKey, otherPartyPublicKey, out phSecret, 0);
		if (errorCode != 0)
		{
			throw new CryptographicException((int)errorCode);
		}
		return phSecret;
	}

	[SecurityCritical]
	internal static byte[] ExportKey(SafeNCryptKeyHandle key, string format)
	{
		Contract.Requires(key != null);
		Contract.Requires(!string.IsNullOrEmpty(format));
		int pcbResult = 0;
		ErrorCode errorCode = UnsafeNativeMethods.NCryptExportKey(key, IntPtr.Zero, format, IntPtr.Zero, null, 0, out pcbResult, 0);
		if (errorCode != 0 && errorCode != ErrorCode.BufferTooSmall)
		{
			throw new CryptographicException((int)errorCode);
		}
		byte[] array = new byte[pcbResult];
		errorCode = UnsafeNativeMethods.NCryptExportKey(key, IntPtr.Zero, format, IntPtr.Zero, array, array.Length, out pcbResult, 0);
		if (errorCode != 0)
		{
			throw new CryptographicException((int)errorCode);
		}
		return array;
	}

	private static byte[] FillKeyParameter(byte[] key, int keySize)
	{
		Contract.Requires(key != null);
		Contract.Requires(keySize > 0);
		int num = keySize / 8 + ((keySize % 8 != 0) ? 1 : 0);
		if (key.Length == num)
		{
			return key;
		}
		byte[] array = new byte[num];
		Buffer.BlockCopy(key, 0, array, 0, Math.Min(key.Length, array.Length));
		return array;
	}

	[SecurityCritical]
	internal static void FinalizeKey(SafeNCryptKeyHandle key)
	{
		Contract.Requires(key != null && !key.IsInvalid && !key.IsClosed);
		ErrorCode errorCode = UnsafeNativeMethods.NCryptFinalizeKey(key, 0);
		if (errorCode != 0)
		{
			throw new CryptographicException((int)errorCode);
		}
	}

	[SecurityCritical]
	internal static byte[] GetProperty(SafeNCryptHandle ncryptObject, string propertyName, CngPropertyOptions propertyOptions, out bool foundProperty)
	{
		Contract.Requires(ncryptObject != null);
		Contract.Requires(propertyName != null);
		int pcbResult = 0;
		ErrorCode errorCode = UnsafeNativeMethods.NCryptGetProperty(ncryptObject, propertyName, null, 0, out pcbResult, propertyOptions);
		if (errorCode != 0 && errorCode != ErrorCode.BufferTooSmall && errorCode != ErrorCode.NotFound)
		{
			throw new CryptographicException((int)errorCode);
		}
		foundProperty = errorCode != ErrorCode.NotFound;
		byte[] array = null;
		if (errorCode != ErrorCode.NotFound && pcbResult > 0)
		{
			array = new byte[pcbResult];
			errorCode = UnsafeNativeMethods.NCryptGetProperty(ncryptObject, propertyName, array, array.Length, out pcbResult, propertyOptions);
			if (errorCode != 0)
			{
				throw new CryptographicException((int)errorCode);
			}
			foundProperty = true;
		}
		return array;
	}

	[SecurityCritical]
	internal static int GetPropertyAsDWord(SafeNCryptHandle ncryptObject, string propertyName, CngPropertyOptions propertyOptions)
	{
		Contract.Requires(ncryptObject != null);
		Contract.Requires(propertyName != null);
		bool foundProperty;
		byte[] property = GetProperty(ncryptObject, propertyName, propertyOptions, out foundProperty);
		if (foundProperty && property != null)
		{
			return BitConverter.ToInt32(property, 0);
		}
		return 0;
	}

	[SecurityCritical]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
	internal static IntPtr GetPropertyAsIntPtr(SafeNCryptHandle ncryptObject, string propertyName, CngPropertyOptions propertyOptions)
	{
		Contract.Requires(ncryptObject != null);
		Contract.Requires(propertyName != null);
		int pcbResult = IntPtr.Size;
		IntPtr pbOutput = IntPtr.Zero;
		ErrorCode errorCode = UnsafeNativeMethods.NCryptGetProperty(ncryptObject, propertyName, out pbOutput, IntPtr.Size, out pcbResult, propertyOptions);
		return errorCode switch
		{
			ErrorCode.NotFound => IntPtr.Zero, 
			ErrorCode.Success => pbOutput, 
			_ => throw new CryptographicException((int)errorCode), 
		};
	}

	[SecurityCritical]
	internal unsafe static string GetPropertyAsString(SafeNCryptHandle ncryptObject, string propertyName, CngPropertyOptions propertyOptions)
	{
		Contract.Requires(ncryptObject != null);
		Contract.Requires(propertyName != null);
		bool foundProperty;
		byte[] property = GetProperty(ncryptObject, propertyName, propertyOptions, out foundProperty);
		if (foundProperty && property != null)
		{
			if (property.Length == 0)
			{
				return string.Empty;
			}
			fixed (byte* value = property)
			{
				return Marshal.PtrToStringUni(new IntPtr(value));
			}
		}
		return null;
	}

	[SecurityCritical]
	internal unsafe static T GetPropertyAsStruct<T>(SafeNCryptHandle ncryptObject, string propertyName, CngPropertyOptions propertyOptions) where T : struct
	{
		Contract.Requires(ncryptObject != null);
		Contract.Requires(propertyName != null);
		bool foundProperty;
		byte[] property = GetProperty(ncryptObject, propertyName, propertyOptions, out foundProperty);
		if (foundProperty && property != null)
		{
			fixed (byte* value = property)
			{
				return (T)Marshal.PtrToStructure(new IntPtr(value), typeof(T));
			}
		}
		return default(T);
	}

	[SecurityCritical]
	internal static SafeNCryptKeyHandle ImportKey(SafeNCryptProviderHandle provider, byte[] keyBlob, string format)
	{
		Contract.Requires(provider != null);
		Contract.Requires(keyBlob != null);
		Contract.Requires(!string.IsNullOrEmpty(format));
		SafeNCryptKeyHandle phKey = null;
		ErrorCode errorCode = UnsafeNativeMethods.NCryptImportKey(provider, IntPtr.Zero, format, IntPtr.Zero, out phKey, keyBlob, keyBlob.Length, 0);
		if (errorCode != 0)
		{
			throw new CryptographicException((int)errorCode);
		}
		return phKey;
	}

	[SecurityCritical]
	internal static SafeNCryptKeyHandle OpenKey(SafeNCryptProviderHandle provider, string name, CngKeyOpenOptions options)
	{
		Contract.Requires(provider != null && !provider.IsInvalid && !provider.IsClosed);
		Contract.Requires(name != null);
		SafeNCryptKeyHandle phKey = null;
		ErrorCode errorCode = UnsafeNativeMethods.NCryptOpenKey(provider, out phKey, name, 0, options);
		if (errorCode != 0)
		{
			throw new CryptographicException((int)errorCode);
		}
		return phKey;
	}

	[SecurityCritical]
	internal static SafeNCryptProviderHandle OpenStorageProvider(string providerName)
	{
		Contract.Requires(!string.IsNullOrEmpty(providerName));
		SafeNCryptProviderHandle phProvider = null;
		ErrorCode errorCode = UnsafeNativeMethods.NCryptOpenStorageProvider(out phProvider, providerName, 0);
		if (errorCode != 0)
		{
			throw new CryptographicException((int)errorCode);
		}
		return phProvider;
	}

	private static byte[] ReverseBytes(byte[] buffer)
	{
		Contract.Requires(buffer != null);
		return ReverseBytes(buffer, 0, buffer.Length);
	}

	private static byte[] ReverseBytes(byte[] buffer, int offset, int count)
	{
		Contract.Requires(buffer != null);
		Contract.Requires(offset >= 0 && offset < buffer.Length);
		Contract.Requires(count >= 0 && buffer.Length - count >= offset);
		byte[] array = new byte[count];
		int num = offset + count - 1;
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = buffer[num - i];
		}
		return array;
	}

	[SecurityCritical]
	internal static void SetProperty(SafeNCryptHandle ncryptObject, string propertyName, int value, CngPropertyOptions propertyOptions)
	{
		Contract.Requires(ncryptObject != null);
		Contract.Requires(propertyName != null);
		SetProperty(ncryptObject, propertyName, BitConverter.GetBytes(value), propertyOptions);
	}

	[SecurityCritical]
	internal static void SetProperty(SafeNCryptHandle ncryptObject, string propertyName, string value, CngPropertyOptions propertyOptions)
	{
		Contract.Requires(ncryptObject != null);
		Contract.Requires(propertyName != null);
		ErrorCode errorCode = UnsafeNativeMethods.NCryptSetProperty(ncryptObject, propertyName, value, (value.Length + 1) * 2, propertyOptions);
		if (errorCode != 0)
		{
			throw new CryptographicException((int)errorCode);
		}
	}

	[SecurityCritical]
	internal unsafe static void SetProperty<T>(SafeNCryptHandle ncryptObject, string propertyName, T value, CngPropertyOptions propertyOptions) where T : struct
	{
		Contract.Requires(ncryptObject != null);
		Contract.Requires(propertyName != null);
		byte[] array = new byte[Marshal.SizeOf(typeof(T))];
		fixed (byte* value2 = array)
		{
			bool flag = false;
			RuntimeHelpers.PrepareConstrainedRegions();
			try
			{
				RuntimeHelpers.PrepareConstrainedRegions();
				try
				{
				}
				finally
				{
					Marshal.StructureToPtr((object)value, new IntPtr(value2), fDeleteOld: false);
					flag = true;
				}
				SetProperty(ncryptObject, propertyName, array, propertyOptions);
			}
			finally
			{
				if (flag)
				{
					Marshal.DestroyStructure(new IntPtr(value2), typeof(T));
				}
			}
		}
	}

	[SecurityCritical]
	internal static void SetProperty(SafeNCryptHandle ncryptObject, string propertyName, byte[] value, CngPropertyOptions propertyOptions)
	{
		Contract.Requires(ncryptObject != null);
		Contract.Requires(propertyName != null);
		ErrorCode errorCode = UnsafeNativeMethods.NCryptSetProperty(ncryptObject, propertyName, value, (value != null) ? value.Length : 0, propertyOptions);
		if (errorCode != 0)
		{
			throw new CryptographicException((int)errorCode);
		}
	}

	[SecurityCritical]
	internal static byte[] SignHash(SafeNCryptKeyHandle key, byte[] hash)
	{
		Contract.Requires(key != null);
		Contract.Requires(hash != null);
		int pcbResult = 0;
		ErrorCode errorCode = UnsafeNativeMethods.NCryptSignHash(key, IntPtr.Zero, hash, hash.Length, null, 0, out pcbResult, 0);
		if (errorCode != 0 && errorCode != ErrorCode.BufferTooSmall)
		{
			throw new CryptographicException((int)errorCode);
		}
		byte[] array = new byte[pcbResult];
		errorCode = UnsafeNativeMethods.NCryptSignHash(key, IntPtr.Zero, hash, hash.Length, array, array.Length, out pcbResult, 0);
		if (errorCode != 0)
		{
			throw new CryptographicException((int)errorCode);
		}
		return array;
	}

	internal static void UnpackEccPublicBlob(byte[] blob, out BigInteger x, out BigInteger y)
	{
		Contract.Requires(blob != null && blob.Length > 8);
		int num = BitConverter.ToInt32(blob, 4);
		x = new BigInteger(ReverseBytes(blob, 8, num), negative: false);
		y = new BigInteger(ReverseBytes(blob, 8 + num, num), negative: false);
	}

	[SecurityCritical]
	internal static bool VerifySignature(SafeNCryptKeyHandle key, byte[] hash, byte[] signature)
	{
		Contract.Requires(key != null);
		Contract.Requires(hash != null);
		Contract.Requires(signature != null);
		ErrorCode errorCode = UnsafeNativeMethods.NCryptVerifySignature(key, IntPtr.Zero, hash, hash.Length, signature, signature.Length, 0);
		if (errorCode != 0 && errorCode != ErrorCode.BadSignature)
		{
			throw new CryptographicException((int)errorCode);
		}
		return errorCode == ErrorCode.Success;
	}
}
