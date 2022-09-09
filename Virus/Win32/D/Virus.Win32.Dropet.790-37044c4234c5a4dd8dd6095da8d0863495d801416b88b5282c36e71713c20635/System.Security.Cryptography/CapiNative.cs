using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using Microsoft.Contracts;
using Microsoft.Win32.SafeHandles;

namespace System.Security.Cryptography;

internal static class CapiNative
{
	internal enum AlgorithmClass
	{
		DataEncryption = 24576,
		Hash = 32768
	}

	internal enum AlgorithmType
	{
		Any = 0,
		Block = 1536
	}

	internal enum AlgorithmSubId
	{
		MD5 = 3,
		Sha1 = 4,
		Sha256 = 12,
		Sha384 = 13,
		Sha512 = 14,
		Aes128 = 14,
		Aes192 = 15,
		Aes256 = 16
	}

	internal enum AlgorithmId
	{
		None = 0,
		Aes128 = 26126,
		Aes192 = 26127,
		Aes256 = 26128,
		MD5 = 32771,
		Sha1 = 32772,
		Sha256 = 32780,
		Sha384 = 32781,
		Sha512 = 32782
	}

	[Flags]
	internal enum CryptAcquireContextFlags
	{
		None = 0,
		VerifyContext = -268435456
	}

	internal enum ErrorCode
	{
		Success = 0,
		MoreData = 234,
		NoMoreItems = 259,
		BadData = -2146893819,
		BadAlgorithmId = -2146893816,
		ProviderTypeNotDefined = -2146893801,
		KeysetNotDefined = -2146893799
	}

	internal enum HashParameter
	{
		None = 0,
		AlgorithmId = 1,
		HashValue = 2,
		HashSize = 4
	}

	internal enum KeyBlobType : byte
	{
		PlainText = 8
	}

	[Flags]
	internal enum KeyFlags
	{
		None = 0,
		Exportable = 1
	}

	internal enum KeyParameter
	{
		None = 0,
		IV = 1,
		Mode = 4,
		ModeBits = 5
	}

	internal static class ProviderNames
	{
		public const string MicrosoftEnhancedRsaAes = "Microsoft Enhanced RSA and AES Cryptographic Provider";

		public const string MicrosoftEnhancedRsaAesPrototype = "Microsoft Enhanced RSA and AES Cryptographic Provider (Prototype)";
	}

	internal enum ProviderParameter
	{
		None,
		EnumerateAlgorithms
	}

	[Flags]
	internal enum ProviderParameterFlags
	{
		None = 0,
		RestartEnumeration = 1
	}

	internal enum ProviderType
	{
		None = 0,
		RsaAes = 24
	}

	internal struct BLOBHEADER
	{
		public KeyBlobType bType;

		public byte bVersion;

		public short reserved;

		public AlgorithmId aiKeyAlg;
	}

	internal struct CRYPTOAPI_BLOB
	{
		public int cbData;

		public IntPtr pbData;
	}

	internal struct PROV_ENUMALGS
	{
		public AlgorithmId aiAlgId;

		public int dwBitLen;

		public int dwNameLen;

		public unsafe fixed byte szName[20];
	}

	[SecurityCritical(SecurityCriticalScope.Everything)]
	[SuppressUnmanagedCodeSecurity]
	internal static class UnsafeNativeMethods
	{
		[DllImport("mscorwks")]
		public static extern int _AxlPublicKeyBlobToPublicKeyToken(ref CRYPTOAPI_BLOB pCspPublicKeyBlob, out SafeAxlBufferHandle ppwszPublicKeyToken);

		[DllImport("advapi32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool CryptAcquireContext(out SafeCspHandle phProv, string pszContainer, string pszProvider, ProviderType dwProvType, CryptAcquireContextFlags dwFlags);

		[DllImport("advapi32", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool CryptCreateHash(SafeCspHandle hProv, AlgorithmId Algid, SafeCapiKeyHandle hKey, int dwFlags, out SafeCapiHashHandle phHash);

		[DllImport("advapi32", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool CryptDecrypt(SafeCapiKeyHandle hKey, SafeCapiHashHandle hHash, [MarshalAs(UnmanagedType.Bool)] bool Final, int dwFlags, IntPtr pbData, [In][Out] ref int pdwDataLen);

		[DllImport("advapi32")]
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		[SuppressUnmanagedCodeSecurity]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool CryptDuplicateKey(SafeCapiKeyHandle hKey, IntPtr pdwReserved, int dwFlags, out SafeCapiKeyHandle phKey);

		[DllImport("advapi32", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool CryptEncrypt(SafeCapiKeyHandle hKey, SafeCapiHashHandle hHash, [MarshalAs(UnmanagedType.Bool)] bool Final, int dwFlags, IntPtr pbData, [In][Out] ref int pdwDataLen, int dwBufLen);

		[DllImport("advapi32", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool CryptExportKey(SafeCapiKeyHandle hKey, SafeCapiKeyHandle hExpKey, int dwBlobType, int dwExportFlags, [Out][MarshalAs(UnmanagedType.LPArray)] byte[] pbData, [In][Out] ref int pdwDataLen);

		[DllImport("advapi32", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool CryptGenKey(SafeCspHandle hProv, AlgorithmId Algid, KeyFlags dwFlags, out SafeCapiKeyHandle phKey);

		[DllImport("advapi32", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool CryptGenRandom(SafeCspHandle hProv, int dwLen, [Out][MarshalAs(UnmanagedType.LPArray)] byte[] pbBuffer);

		[DllImport("advapi32", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool CryptGetHashParam(SafeCapiHashHandle hHash, HashParameter dwParam, [Out][MarshalAs(UnmanagedType.LPArray)] byte[] pbData, [In][Out] ref int pdwDataLen, int dwFlags);

		[DllImport("advapi32", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool CryptGetProvParam(SafeCspHandle hProv, ProviderParameter dwParam, IntPtr pbData, [In][Out] ref int pdwDataLen, ProviderParameterFlags dwFlags);

		[DllImport("advapi32", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool CryptHashData(SafeCapiHashHandle hHash, [MarshalAs(UnmanagedType.LPArray)] byte[] pbData, int dwDataLen, int dwFlags);

		[DllImport("advapi32", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool CryptImportKey(SafeCspHandle hProv, [MarshalAs(UnmanagedType.LPArray)] byte[] pbData, int dwDataLen, SafeCapiKeyHandle hPubKey, KeyFlags dwFlags, out SafeCapiKeyHandle phKey);

		[DllImport("advapi32", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool CryptSetKeyParam(SafeCapiKeyHandle hKey, KeyParameter dwParam, [MarshalAs(UnmanagedType.LPArray)] byte[] pbData, int dwFlags);
	}

	[SecurityCritical]
	internal static SafeCspHandle AcquireCsp(string keyContainer, string providerName, ProviderType providerType, CryptAcquireContextFlags flags, bool throwPlatformException)
	{
		SafeCspHandle phProv = null;
		if (!UnsafeNativeMethods.CryptAcquireContext(out phProv, keyContainer, providerName, providerType, flags))
		{
			int lastWin32Error = Marshal.GetLastWin32Error();
			if (throwPlatformException && (lastWin32Error == -2146893801 || lastWin32Error == -2146893799))
			{
				throw new PlatformNotSupportedException(SR.GetString("Cryptography_PlatformNotSupported"));
			}
			throw new CryptographicException(lastWin32Error);
		}
		return phProv;
	}

	[SecurityCritical]
	internal static byte[] ExportSymmetricKey(SafeCapiKeyHandle key)
	{
		Contract.Requires(key != null);
		int pdwDataLen = 0;
		if (!UnsafeNativeMethods.CryptExportKey(key, SafeCapiKeyHandle.InvalidHandle, 8, 0, null, ref pdwDataLen))
		{
			int lastWin32Error = Marshal.GetLastWin32Error();
			if (lastWin32Error != 234)
			{
				throw new CryptographicException(lastWin32Error);
			}
		}
		byte[] array = new byte[pdwDataLen];
		if (!UnsafeNativeMethods.CryptExportKey(key, SafeCapiKeyHandle.InvalidHandle, 8, 0, array, ref pdwDataLen))
		{
			throw new CryptographicException(Marshal.GetLastWin32Error());
		}
		int srcOffset = Marshal.SizeOf(typeof(BLOBHEADER)) + Marshal.SizeOf(typeof(int));
		int num = BitConverter.ToInt32(array, Marshal.SizeOf(typeof(BLOBHEADER)));
		byte[] array2 = new byte[num];
		Buffer.BlockCopy(array, srcOffset, array2, 0, array2.Length);
		return array2;
	}

	internal static string GetAlgorithmName(AlgorithmId algorithm)
	{
		return algorithm.ToString().ToUpper(CultureInfo.InvariantCulture);
	}

	[SecurityCritical]
	internal static byte[] GetHashParameter(SafeCapiHashHandle hashHandle, HashParameter parameter)
	{
		Contract.Requires(hashHandle != null);
		Contract.Requires(HashParameter.AlgorithmId <= parameter && parameter <= HashParameter.HashSize);
		int pdwDataLen = 0;
		if (!UnsafeNativeMethods.CryptGetHashParam(hashHandle, parameter, null, ref pdwDataLen, 0))
		{
			throw new CryptographicException(Marshal.GetLastWin32Error());
		}
		byte[] array = new byte[pdwDataLen];
		if (!UnsafeNativeMethods.CryptGetHashParam(hashHandle, parameter, array, ref pdwDataLen, 0))
		{
			throw new CryptographicException(Marshal.GetLastWin32Error());
		}
		if (pdwDataLen != array.Length)
		{
			byte[] array2 = new byte[pdwDataLen];
			Buffer.BlockCopy(array, 0, array2, 0, pdwDataLen);
			array = array2;
		}
		return array;
	}

	[SecurityCritical]
	internal static T GetProviderParameterStruct<T>(SafeCspHandle provider, ProviderParameter parameter, ProviderParameterFlags flags) where T : struct
	{
		Contract.Requires(provider != null);
		Contract.Requires(parameter == ProviderParameter.EnumerateAlgorithms);
		int pdwDataLen = 0;
		IntPtr intPtr = IntPtr.Zero;
		if (!UnsafeNativeMethods.CryptGetProvParam(provider, parameter, intPtr, ref pdwDataLen, flags))
		{
			int lastWin32Error = Marshal.GetLastWin32Error();
			switch (lastWin32Error)
			{
			case 259:
				return default(T);
			default:
				throw new CryptographicException(lastWin32Error);
			case 234:
				break;
			}
		}
		RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
			RuntimeHelpers.PrepareConstrainedRegions();
			try
			{
			}
			finally
			{
				intPtr = Marshal.AllocCoTaskMem(pdwDataLen);
			}
			if (!UnsafeNativeMethods.CryptGetProvParam(provider, parameter, intPtr, ref pdwDataLen, flags))
			{
				throw new CryptographicException(Marshal.GetLastWin32Error());
			}
			return (T)Marshal.PtrToStructure(intPtr, typeof(T));
		}
		finally
		{
			if (intPtr != IntPtr.Zero)
			{
				Marshal.FreeCoTaskMem(intPtr);
			}
		}
	}

	internal static int HResultForVerificationResult(SignatureVerificationResult verificationResult)
	{
		switch (verificationResult)
		{
		default:
			return (int)verificationResult;
		case SignatureVerificationResult.ContainingSignatureInvalid:
			return -2146869232;
		case SignatureVerificationResult.AssemblyIdentityMismatch:
		case SignatureVerificationResult.PublicKeyTokenMismatch:
		case SignatureVerificationResult.PublisherMismatch:
			return -2146762749;
		}
	}

	[SecurityCritical]
	internal unsafe static SafeCapiKeyHandle ImportSymmetricKey(SafeCspHandle provider, AlgorithmId algorithm, byte[] key)
	{
		Contract.Requires(provider != null);
		Contract.Requires((algorithm & (AlgorithmId)24576) == (AlgorithmId)24576);
		Contract.Requires(key != null);
		int num = Marshal.SizeOf(typeof(BLOBHEADER)) + Marshal.SizeOf(typeof(int)) + key.Length;
		byte[] array = new byte[num];
		fixed (byte* ptr = array)
		{
			BLOBHEADER* ptr2 = (BLOBHEADER*)ptr;
			ptr2->bType = KeyBlobType.PlainText;
			ptr2->bVersion = 2;
			ptr2->reserved = 0;
			ptr2->aiKeyAlg = algorithm;
			int* ptr3 = (int*)(ptr + Marshal.SizeOf((object)(*ptr2)));
			*ptr3 = key.Length;
		}
		Buffer.BlockCopy(key, 0, array, Marshal.SizeOf(typeof(BLOBHEADER)) + Marshal.SizeOf(typeof(int)), key.Length);
		SafeCapiKeyHandle phKey = null;
		if (!UnsafeNativeMethods.CryptImportKey(provider, array, array.Length, SafeCapiKeyHandle.InvalidHandle, KeyFlags.Exportable, out phKey))
		{
			throw new CryptographicException(Marshal.GetLastWin32Error());
		}
		return phKey;
	}

	[SecurityCritical]
	internal static void SetKeyParameter(SafeCapiKeyHandle key, KeyParameter parameter, int value)
	{
		Contract.Requires(key != null);
		Contract.Requires(parameter == KeyParameter.Mode || parameter == KeyParameter.ModeBits);
		SetKeyParameter(key, parameter, BitConverter.GetBytes(value));
	}

	[SecurityCritical]
	internal static void SetKeyParameter(SafeCapiKeyHandle key, KeyParameter parameter, byte[] value)
	{
		Contract.Requires(key != null && !key.IsInvalid && !key.IsClosed);
		Contract.Requires(value != null);
		if (!UnsafeNativeMethods.CryptSetKeyParam(key, parameter, value, 0))
		{
			throw new CryptographicException(Marshal.GetLastWin32Error());
		}
	}
}
