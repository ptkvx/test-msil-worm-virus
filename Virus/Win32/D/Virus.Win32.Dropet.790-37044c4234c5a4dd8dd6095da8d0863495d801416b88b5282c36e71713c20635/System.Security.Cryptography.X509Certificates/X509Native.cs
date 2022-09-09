using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Permissions;
using Microsoft.Win32.SafeHandles;

namespace System.Security.Cryptography.X509Certificates;

internal static class X509Native
{
	[Flags]
	public enum AxlVerificationFlags
	{
		None = 0,
		NoRevocationCheck = 1,
		RevocationCheckEndCertOnly = 2,
		RevocationCheckEntireChain = 4,
		UrlOnlyCacheRetrieval = 8,
		LifetimeSigning = 0x10,
		TrustMicrosoftRootOnly = 0x20
	}

	[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
	public struct AXL_AUTHENTICODE_SIGNER_INFO
	{
		public int cbSize;

		public int dwError;

		public CapiNative.AlgorithmId algHash;

		[MarshalAs(UnmanagedType.LPWStr)]
		public string pwszHash;

		[MarshalAs(UnmanagedType.LPWStr)]
		public string pwszDescription;

		[MarshalAs(UnmanagedType.LPWStr)]
		public string pwszDescriptionUrl;

		public IntPtr pChainContext;
	}

	[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
	public struct AXL_AUTHENTICODE_TIMESTAMPER_INFO
	{
		public int cbsize;

		public int dwError;

		public CapiNative.AlgorithmId algHash;

		public FILETIME ftTimestamp;

		public IntPtr pChainContext;
	}

	[SuppressUnmanagedCodeSecurity]
	[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
	public static class UnsafeNativeMethods
	{
		[DllImport("mscorwks")]
		public static extern int _AxlGetIssuerPublicKeyHash(IntPtr pCertContext, out SafeAxlBufferHandle ppwszPublicKeyHash);

		[DllImport("mscorwks")]
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public static extern int CertFreeAuthenticodeSignerInfo(ref AXL_AUTHENTICODE_SIGNER_INFO pSignerInfo);

		[DllImport("mscorwks")]
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public static extern int CertFreeAuthenticodeTimestamperInfo(ref AXL_AUTHENTICODE_TIMESTAMPER_INFO pTimestamperInfo);

		[DllImport("mscorwks")]
		public static extern int CertVerifyAuthenticodeLicense(ref CapiNative.CRYPTOAPI_BLOB pLicenseBlob, AxlVerificationFlags dwFlags, [In][Out] ref AXL_AUTHENTICODE_SIGNER_INFO pSignerInfo, [In][Out] ref AXL_AUTHENTICODE_TIMESTAMPER_INFO pTimestamperInfo);
	}
}
