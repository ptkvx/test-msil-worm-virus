using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Cryptography.X509Certificates;

namespace Intuit.QuickBooks.XmlDigitalSignature;

internal class Pfx
{
	public enum pfxError
	{
		PFX_OK,
		PFX_FILENOTFOUND,
		PFX_CERTIMPORTFAILURE,
		PFX_INVALIDPFXDATA,
		PFX_PFXINCOMPLETEDATA,
		PFX_PUBLICKEYRETRIEVALERROR,
		PFX_PUBLICKEYINITIALIZATIONERROR,
		PFX_UNAUTHORIZEDACCESSERROR,
		PFX_ARGUMENTERROR,
		PFX_SECURITYERROR,
		PFX_ARGUMENTOUTOFRANGE,
		PFX_IOERROR,
		PFX_OBJECTDISPOSEDERROR,
		PFX_OUTOFMEMORYERROR,
		PFX_CERTIFICATERETRIEVALERROR,
		PFX_INITIALIZEERROR
	}

	public struct CERT_CONTEXT
	{
		public uint dwCertEncodingType;

		public IntPtr pbCertEncoded;

		public int cbCertEncoded;

		public IntPtr pCertInfo;

		public IntPtr hCertStore;
	}

	public struct CRYPT_DATA_BLOB
	{
		public int cbData;

		public IntPtr pbData;
	}

	public struct CRYPT_KEY_PROV_INFO
	{
		[MarshalAs(UnmanagedType.LPWStr)]
		public string ContainerName;

		[MarshalAs(UnmanagedType.LPWStr)]
		public string ProvName;

		public uint ProvType;

		public uint Flags;

		public uint ProvParam;

		public IntPtr rgProvParam;

		public uint KeySpec;
	}

	public struct PUBKEYBLOBHEADERS
	{
		public byte bType;

		public byte bVersion;

		public short reserved;

		public uint aiKeyAlg;

		public uint magic;

		public uint bitlen;

		public uint pubexp;
	}

	private const uint CERT_SYSTEM_STORE_CURRENT_USER = 65536u;

	private const uint CERT_SYSTEM_STORE_LOCAL_MACHINE = 131072u;

	private const uint CERT_STORE_READONLY_FLAG = 32768u;

	private const uint CERT_STORE_OPEN_EXISTING_FLAG = 16384u;

	private const string MYSTORE = "MY";

	private const uint CERT_FIND_SUBJECT_STR = 524295u;

	private const uint PKCS_7_ASN_ENCODING = 65536u;

	private const uint X509_ASN_ENCODING = 1u;

	private const uint CERT_KEY_PROV_INFO_PROP_ID = 2u;

	private const uint RSA_CSP_PUBLICKEYBLOB = 19u;

	private const uint CRYPT_EXPORTABLE = 1u;

	private const uint CRYPT_USER_PROTECTED = 2u;

	private const uint CRYPT_MACHINE_KEYSET = 32u;

	private const uint CRYPT_USER_KEYSET = 4096u;

	private static CRYPT_DATA_BLOB PfxBlob;

	private static X509Certificate certificate;

	private static string keyContainer;

	private static string providerName;

	private static int providerType;

	private static int keySpec;

	private static int certificateKeySize;

	private static byte[] publicExponent;

	private static byte[] keyModulus;

	private static uint ENCODING_TYPE = 65537u;

	private static uint storetype = 65536u;

	private static uint CRYPT_E_NOT_FOUND = 2148081668u;

	private static uint E_INVALIDARG = 2147483651u;

	public static string Container => keyContainer;

	public static string ProviderName => providerName;

	public static int ProviderType => providerType;

	public static int KeySpec => keySpec;

	public static X509Certificate Certificate => certificate;

	public static int KeySize => certificateKeySize;

	public static byte[] PublicExponent => publicExponent;

	public static byte[] KeyModulus => keyModulus;

	[DllImport("crypt32.dll", SetLastError = true)]
	public static extern IntPtr PFXImportCertStore(ref CRYPT_DATA_BLOB pPFX, [MarshalAs(UnmanagedType.LPWStr)] string szPassword, uint dwFlags);

	[DllImport("crypt32.dll", SetLastError = true)]
	public static extern bool PFXIsPFXBlob(ref CRYPT_DATA_BLOB pPFX);

	[DllImport("crypt32.dll", SetLastError = true)]
	public static extern bool PFXVerifyPassword(ref CRYPT_DATA_BLOB pPfx, [MarshalAs(UnmanagedType.LPWStr)] string szPassword, uint dwFlags);

	[DllImport("crypt32.dll", SetLastError = true)]
	public static extern bool CryptDecodeObject(uint CertEncodingType, uint lpszStructType, byte[] pbEncoded, uint cbEncoded, uint flags, [In][Out] byte[] pvStructInfo, ref uint cbStructInfo);

	[DllImport("crypt32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern IntPtr CertOpenStore([MarshalAs(UnmanagedType.LPStr)] string storeProvider, uint dwMsgAndCertEncodingType, IntPtr hCryptProv, uint dwFlags, string pfxFileName);

	[DllImport("crypt32.dll", SetLastError = true)]
	public static extern bool CertCloseStore(IntPtr hCertStore, uint dwFlags);

	[DllImport("crypt32.dll", SetLastError = true)]
	public static extern bool CertFreeCertificateContext(IntPtr hCertStore);

	[DllImport("crypt32.dll", SetLastError = true)]
	public static extern IntPtr CertEnumCertificatesInStore(IntPtr hCertStore, IntPtr pPrevCertContext);

	[DllImport("crypt32.dll", SetLastError = true)]
	public static extern IntPtr CertFindCertificateInStore(IntPtr hCertStore, uint dwCertEncodingType, uint dwFindFlags, uint dwFindType, IntPtr pvFindPara, IntPtr pPrevCertCntxt);

	[DllImport("crypt32.dll", SetLastError = true)]
	public static extern bool CertGetCertificateContextProperty(IntPtr pCertContext, uint dwPropId, IntPtr pvData, ref uint pcbData);

	public static pfxError pfx(string fileName, string password, bool exportCertificate)
	{
		pfxError error = pfxError.PFX_INITIALIZEERROR;
		IntPtr zero = IntPtr.Zero;
		if (File.Exists(fileName))
		{
			if (GetPfxDataBlob(fileName, ref error))
			{
				zero = PFXImportCertStore(ref PfxBlob, password, 0u);
				error = ((!(zero != IntPtr.Zero)) ? pfxError.PFX_CERTIMPORTFAILURE : LoadFromPfxFile(zero, exportCertificate));
			}
		}
		else
		{
			error = pfxError.PFX_FILENOTFOUND;
		}
		return error;
	}

	private static pfxError LoadFromPfxFile(IntPtr pfxStore, bool exportCertificate)
	{
		pfxError result = pfxError.PFX_INITIALIZEERROR;
		IntPtr intPtr = IntPtr.Zero;
		IntPtr zero = IntPtr.Zero;
		uint pcbData = 0u;
		while ((intPtr = CertEnumCertificatesInStore(pfxStore, intPtr)) != IntPtr.Zero)
		{
			if (CertGetCertificateContextProperty(intPtr, 2u, IntPtr.Zero, ref pcbData))
			{
				zero = Marshal.AllocHGlobal((int)pcbData);
				if (CertGetCertificateContextProperty(intPtr, 2u, zero, ref pcbData))
				{
					CRYPT_KEY_PROV_INFO cRYPT_KEY_PROV_INFO = (CRYPT_KEY_PROV_INFO)Marshal.PtrToStructure(zero, typeof(CRYPT_KEY_PROV_INFO));
					Marshal.FreeHGlobal(zero);
					keyContainer = cRYPT_KEY_PROV_INFO.ContainerName;
					providerName = cRYPT_KEY_PROV_INFO.ProvName;
					providerType = (int)cRYPT_KEY_PROV_INFO.ProvType;
					keySpec = (int)cRYPT_KEY_PROV_INFO.KeySpec;
					certificate = new X509Certificate(intPtr);
					result = GetCertPublicKey(certificate, exportCertificate);
					break;
				}
			}
		}
		return result;
	}

	private static bool GetPfxDataBlob(string fileName, ref pfxError error)
	{
		bool result = false;
		FileInfo fileInfo = new FileInfo(fileName);
		int num = (int)fileInfo.Length;
		try
		{
			FileStream input = new FileStream(fileName, FileMode.Open, FileAccess.Read);
			BinaryReader binaryReader = new BinaryReader(input);
			byte[] source = binaryReader.ReadBytes(num);
			PfxBlob.cbData = num;
			PfxBlob.pbData = Marshal.AllocHGlobal(num);
			Marshal.Copy(source, 0, PfxBlob.pbData, num);
			if (PFXIsPFXBlob(ref PfxBlob))
			{
				result = true;
				return result;
			}
			result = false;
			return result;
		}
		catch (UnauthorizedAccessException)
		{
			error = pfxError.PFX_UNAUTHORIZEDACCESSERROR;
			return result;
		}
		catch (ArgumentException)
		{
			error = pfxError.PFX_ARGUMENTERROR;
			return result;
		}
		catch (SecurityException)
		{
			error = pfxError.PFX_SECURITYERROR;
			return result;
		}
		catch (IOException)
		{
			error = pfxError.PFX_IOERROR;
			return result;
		}
		catch (ObjectDisposedException)
		{
			error = pfxError.PFX_OBJECTDISPOSEDERROR;
			return result;
		}
		catch (OutOfMemoryException)
		{
			error = pfxError.PFX_OUTOFMEMORYERROR;
			return result;
		}
	}

	private static pfxError GetCertPublicKey(X509Certificate cert, bool exportCertificate)
	{
		pfxError result = pfxError.PFX_INITIALIZEERROR;
		byte[] publicKey = cert.GetPublicKey();
		uint cbStructInfo = 0u;
		if (CryptDecodeObject(ENCODING_TYPE, 19u, publicKey, (uint)publicKey.Length, 0u, null, ref cbStructInfo))
		{
			byte[] array = new byte[cbStructInfo];
			if (CryptDecodeObject(ENCODING_TYPE, 19u, publicKey, (uint)publicKey.Length, 0u, array, ref cbStructInfo))
			{
				try
				{
					int num = Marshal.SizeOf((object)default(PUBKEYBLOBHEADERS));
					IntPtr intPtr = Marshal.AllocHGlobal(num);
					Marshal.Copy(array, 0, intPtr, num);
					PUBKEYBLOBHEADERS pUBKEYBLOBHEADERS = (PUBKEYBLOBHEADERS)Marshal.PtrToStructure(intPtr, typeof(PUBKEYBLOBHEADERS));
					Marshal.FreeHGlobal(intPtr);
					certificateKeySize = (int)pUBKEYBLOBHEADERS.bitlen;
					byte[] bytes = BitConverter.GetBytes(pUBKEYBLOBHEADERS.pubexp);
					Array.Reverse((Array)bytes);
					publicExponent = bytes;
					int num2 = (int)pUBKEYBLOBHEADERS.bitlen / 8;
					byte[] array2 = new byte[num2];
					Array.Copy(array, num, array2, 0, num2);
					Array.Reverse((Array)array2);
					keyModulus = array2;
					if (exportCertificate)
					{
						string text = cert.Subject + ".cer";
						string path = text.Substring(3);
						using StreamWriter streamWriter = new StreamWriter(path);
						streamWriter.Write(cert.ToString());
					}
					return pfxError.PFX_OK;
				}
				catch (Exception)
				{
					return pfxError.PFX_CERTIFICATERETRIEVALERROR;
				}
			}
		}
		else
		{
			result = pfxError.PFX_PUBLICKEYINITIALIZATIONERROR;
		}
		return result;
	}

	public static pfxError FindMyCertificate(string subjectName, string pfxFileName, string password)
	{
		pfxError error = pfxError.PFX_INITIALIZEERROR;
		IntPtr intPtr = IntPtr.Zero;
		IntPtr intPtr2 = IntPtr.Zero;
		IntPtr pvFindPara = Marshal.StringToHGlobalUni(subjectName);
		if (GetPfxDataBlob(pfxFileName, ref error))
		{
			intPtr = PFXImportCertStore(ref PfxBlob, password, 0u);
			if (intPtr == IntPtr.Zero)
			{
				error = pfxError.PFX_CERTIFICATERETRIEVALERROR;
			}
			else
			{
				intPtr2 = CertFindCertificateInStore(intPtr, ENCODING_TYPE, 0u, 524295u, pvFindPara, IntPtr.Zero);
				int lastWin32Error = Marshal.GetLastWin32Error();
				if (lastWin32Error != 0)
				{
					error = ((lastWin32Error == CRYPT_E_NOT_FOUND) ? pfxError.PFX_CERTIFICATERETRIEVALERROR : ((lastWin32Error != E_INVALIDARG) ? pfxError.PFX_INITIALIZEERROR : pfxError.PFX_ARGUMENTERROR));
				}
			}
		}
		if (intPtr2 != IntPtr.Zero)
		{
			certificate = new X509Certificate(intPtr2);
		}
		if (intPtr2 != IntPtr.Zero)
		{
			CertFreeCertificateContext(intPtr2);
		}
		if (intPtr != IntPtr.Zero)
		{
			CertCloseStore(intPtr, 0u);
		}
		return error;
	}
}
