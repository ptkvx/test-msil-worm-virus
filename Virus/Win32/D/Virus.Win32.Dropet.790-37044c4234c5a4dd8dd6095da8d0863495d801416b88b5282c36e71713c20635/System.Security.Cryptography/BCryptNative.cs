using System.Runtime.InteropServices;
using Microsoft.Contracts;
using Microsoft.Win32;
using Microsoft.Win32.SafeHandles;

namespace System.Security.Cryptography;

internal static class BCryptNative
{
	internal static class AlgorithmName
	{
		public const string ECDHP256 = "ECDH_P256";

		public const string ECDHP384 = "ECDH_P384";

		public const string ECDHP521 = "ECDH_P521";

		public const string ECDsaP256 = "ECDSA_P256";

		public const string ECDsaP384 = "ECDSA_P384";

		public const string ECDsaP521 = "ECDSA_P521";

		public const string MD5 = "MD5";

		public const string Sha1 = "SHA1";

		public const string Sha256 = "SHA256";

		public const string Sha384 = "SHA384";

		public const string Sha512 = "SHA512";
	}

	internal enum ErrorCode
	{
		Success = 0,
		BufferToSmall = -1073741789,
		ObjectNameNotFound = -1073741772
	}

	internal static class HashPropertyName
	{
		public const string HashLength = "HashDigestLength";
	}

	internal enum KeyBlobMagicNumber
	{
		ECDHPublicP256 = 827016005,
		ECDHPublicP384 = 860570437,
		ECDHPublicP521 = 894124869,
		ECDsaPublicP256 = 827540293,
		ECDsaPublicP384 = 861094725,
		ECDsaPublicP521 = 894649157
	}

	internal static class KeyDerivationFunction
	{
		public const string Hash = "HASH";

		public const string Hmac = "HMAC";

		public const string Tls = "TLS_PRF";
	}

	internal static class ProviderName
	{
		public const string MicrosoftPrimitiveProvider = "Microsoft Primitive Provider";
	}

	internal static class ObjectPropertyName
	{
		public const string ObjectLength = "ObjectLength";
	}

	[SuppressUnmanagedCodeSecurity]
	[SecurityCritical(SecurityCriticalScope.Everything)]
	internal static class UnsafeNativeMethods
	{
		[DllImport("bcrypt.dll", CharSet = CharSet.Unicode)]
		internal static extern ErrorCode BCryptCreateHash(SafeBCryptAlgorithmHandle hAlgorithm, out SafeBCryptHashHandle phHash, IntPtr pbHashObject, int cbHashObject, IntPtr pbSecret, int cbSecret, int dwFlags);

		[DllImport("bcrypt.dll", CharSet = CharSet.Unicode)]
		internal static extern ErrorCode BCryptGetProperty(SafeBCryptAlgorithmHandle hObject, string pszProperty, [In][Out][MarshalAs(UnmanagedType.LPArray)] byte[] pbOutput, int cbOutput, [In][Out] ref int pcbResult, int flags);

		[DllImport("bcrypt.dll", CharSet = CharSet.Unicode, EntryPoint = "BCryptGetProperty")]
		internal static extern ErrorCode BCryptGetProperty_1(SafeBCryptAlgorithmHandle hObject, string pszProperty, [In][Out][MarshalAs(UnmanagedType.LPArray)] byte[] pbOutput, int cbOutput, [In][Out] ref int pcbResult, int flags);

		[DllImport("bcrypt.dll", CharSet = CharSet.Unicode, EntryPoint = "BCryptGetProperty")]
		internal static extern ErrorCode BCryptGetProperty_2(SafeBCryptHashHandle hObject, string pszProperty, [In][Out][MarshalAs(UnmanagedType.LPArray)] byte[] pbOutput, int cbOutput, [In][Out] ref int pcbResult, int flags);

		[DllImport("bcrypt.dll")]
		internal static extern ErrorCode BCryptFinishHash(SafeBCryptHashHandle hHash, [Out][MarshalAs(UnmanagedType.LPArray)] byte[] pbInput, int cbInput, int dwFlags);

		[DllImport("bcrypt.dll")]
		internal static extern ErrorCode BCryptHashData(SafeBCryptHashHandle hHash, [In][MarshalAs(UnmanagedType.LPArray)] byte[] pbInput, int cbInput, int dwFlags);

		[DllImport("bcrypt.dll", CharSet = CharSet.Unicode)]
		internal static extern ErrorCode BCryptOpenAlgorithmProvider(out SafeBCryptAlgorithmHandle phAlgorithm, string pszAlgId, string pszImplementation, int dwFlags);
	}

	private delegate ErrorCode BCryptPropertyGetter<T>(T hObject, string pszProperty, byte[] pbOutput, int cbOutput, ref int pcbResult, int dwFlags) where T : SafeHandle;

	private static bool? s_bcryptSupported;

	internal static bool BCryptSupported
	{
		[SecurityCritical]
		get
		{
			if (!s_bcryptSupported.HasValue)
			{
				using SafeLibraryHandle safeLibraryHandle = Microsoft.Win32.UnsafeNativeMethods.LoadLibraryEx("bcrypt", IntPtr.Zero, 0);
				s_bcryptSupported = !safeLibraryHandle.IsInvalid;
			}
			return s_bcryptSupported.Value;
		}
	}

	[SecurityCritical]
	internal static int GetInt32Property<T>(T algorithm, string property) where T : SafeHandle
	{
		Contract.Requires(algorithm != null);
		Contract.Requires(property == "HashDigestLength" || property == "ObjectLength");
		return BitConverter.ToInt32(GetProperty(algorithm, property), 0);
	}

	[SecurityCritical]
	internal static byte[] GetProperty<T>(T algorithm, string property) where T : SafeHandle
	{
		Contract.Requires(algorithm != null);
		Contract.Requires(!string.IsNullOrEmpty(property));
		BCryptPropertyGetter<T> bCryptPropertyGetter = null;
		if ((object)typeof(T) == typeof(SafeBCryptAlgorithmHandle))
		{
			bCryptPropertyGetter = new BCryptPropertyGetter<SafeBCryptAlgorithmHandle>(UnsafeNativeMethods.BCryptGetProperty_1) as BCryptPropertyGetter<T>;
		}
		else if ((object)typeof(T) == typeof(SafeBCryptHashHandle))
		{
			bCryptPropertyGetter = new BCryptPropertyGetter<SafeBCryptHashHandle>(UnsafeNativeMethods.BCryptGetProperty_2) as BCryptPropertyGetter<T>;
		}
		int pcbResult = 0;
		ErrorCode errorCode = bCryptPropertyGetter(algorithm, property, null, 0, ref pcbResult, 0);
		if (errorCode != ErrorCode.BufferToSmall && errorCode != 0)
		{
			throw new CryptographicException((int)errorCode);
		}
		byte[] array = new byte[pcbResult];
		errorCode = bCryptPropertyGetter(algorithm, property, array, array.Length, ref pcbResult, 0);
		if (errorCode != 0)
		{
			throw new CryptographicException((int)errorCode);
		}
		return array;
	}

	internal static void MapAlgorithmIdToMagic(string algorithm, out KeyBlobMagicNumber algorithmMagic, out int keySize)
	{
		Contract.Requires(!string.IsNullOrEmpty(algorithm));
		switch (algorithm)
		{
		case "ECDH_P256":
			algorithmMagic = KeyBlobMagicNumber.ECDHPublicP256;
			keySize = 256;
			break;
		case "ECDH_P384":
			algorithmMagic = KeyBlobMagicNumber.ECDHPublicP384;
			keySize = 384;
			break;
		case "ECDH_P521":
			algorithmMagic = KeyBlobMagicNumber.ECDHPublicP521;
			keySize = 521;
			break;
		case "ECDSA_P256":
			algorithmMagic = KeyBlobMagicNumber.ECDsaPublicP256;
			keySize = 256;
			break;
		case "ECDSA_P384":
			algorithmMagic = KeyBlobMagicNumber.ECDsaPublicP384;
			keySize = 384;
			break;
		default:
			throw new ArgumentException(SR.GetString("Cryptography_UnknownEllipticCurveAlgorithm"));
		case "ECDSA_P521":
			algorithmMagic = KeyBlobMagicNumber.ECDsaPublicP521;
			keySize = 521;
			break;
		}
	}

	[SecurityCritical]
	internal static SafeBCryptAlgorithmHandle OpenAlgorithm(string algorithm, string implementation)
	{
		Contract.Requires(!string.IsNullOrEmpty(algorithm));
		Contract.Requires(!string.IsNullOrEmpty(implementation));
		SafeBCryptAlgorithmHandle phAlgorithm = null;
		ErrorCode errorCode = UnsafeNativeMethods.BCryptOpenAlgorithmProvider(out phAlgorithm, algorithm, implementation, 0);
		if (errorCode != 0)
		{
			throw new CryptographicException((int)errorCode);
		}
		return phAlgorithm;
	}
}
