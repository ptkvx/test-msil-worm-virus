using System.Collections;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Xml;
using Intuit.QuickBooks.XmlDigitalSignature;

namespace Intuit.QuickBooks.FCS;

[ComVisible(false)]
internal class Authenticator
{
	private Hashtable authFileCacheMap;

	public Authenticator()
	{
		authFileCacheMap = new Hashtable();
	}

	public void RegisterAuthFile(string authFile)
	{
		if (!File.Exists(authFile))
		{
			FCService.WriteTraceLine("Auth File not found: " + authFile);
			AuthenticatorException ex = new AuthenticatorException("Auth File not found: " + authFile);
			ex.ErrorCode = FCSErrors.AuthFile_NotFound;
			throw ex;
		}
		if (authFileCacheMap[authFile] != null)
		{
			FCService.WriteTraceLine("Authfile " + authFile + " already registered");
			return;
		}
		AuthFileCache authFileCache = new AuthFileCache();
		XmlSigner.ErrorCodes errorCode = XmlSigner.ErrorCodes.NoError;
		if (XmlVerifier.VerifyXmlFile(authFile, ref errorCode))
		{
			try
			{
				authFileCache.Create(authFile);
			}
			catch (XmlException ex2)
			{
				FCService.WriteTraceLine("Authfile " + authFile + " is poorly formatted or corrupt");
				AuthenticatorException ex3 = new AuthenticatorException(authFile + " poorly formatted\n" + ex2.Message);
				ex3.ErrorCode = FCSErrors.AuthFile_Invalid;
				throw ex3;
			}
			FCService.WriteTraceLine("Authfile " + authFile + " succesfully verified and cached");
			authFileCacheMap.Add(authFile, authFileCache);
			return;
		}
		AuthenticatorException ex4 = new AuthenticatorException("Authfile " + authFile + " failed to verify");
		ex4.ErrorCode = FCSErrors.AuthFile_NotSigned;
		throw ex4;
	}

	public void UnregisterAuthFile(string authFile)
	{
		authFileCacheMap.Remove(authFile);
		FCService.WriteTraceLine("" + authFile + " removed cache contents");
	}

	public void VerifyFile(string fileName, string authFile)
	{
		if (fileName != null && authFile != null)
		{
			if (!VerifyFileHash(fileName, authFile))
			{
				FCService.WriteTraceLine("Failed to verify" + fileName);
				AuthenticatorException ex = new AuthenticatorException("Failed to match computed file hash " + fileName + " with the one stored in Authfile");
				ex.ErrorCode = FCSErrors.File_NotAuthorized;
				throw ex;
			}
			return;
		}
		AuthenticatorException ex2 = new AuthenticatorException("Invalid argument passed into VerifyFile");
		ex2.ErrorCode = FCSErrors.NetError_InvalidParameter;
		throw ex2;
	}

	public void VerifyFiles(string[] fileNameArray, string authFile)
	{
		if (fileNameArray.Length != 0 && authFile != null)
		{
			AuthFileCache authFileCache = (AuthFileCache)authFileCacheMap[authFile];
			if (authFileCache == null)
			{
				FCService.WriteTraceLine("No cache created for " + authFile + " . AuthFile may not be registered previously");
				AuthenticatorException ex = new AuthenticatorException("Input authfile is invalid inside VerifyFileHash");
				ex.ErrorCode = FCSErrors.AuthFile_Invalid;
				throw ex;
			}
			bool flag = false;
			string text = "";
			foreach (string text2 in fileNameArray)
			{
				text = text2;
				if (!(flag = VerifyFileHash(text2, authFile)))
				{
					break;
				}
			}
			if (!flag)
			{
				FCService.WriteTraceLine("Failed to verify " + text);
				AuthenticatorException ex2 = new AuthenticatorException("Failed to match computed file hash " + text + " with the one stored in Authfile");
				ex2.ErrorCode = FCSErrors.File_NotAuthorized;
				throw ex2;
			}
			return;
		}
		FCService.WriteTraceLine("Invalid argument received in VerifyFile");
		AuthenticatorException ex3 = new AuthenticatorException("Invalid argument passed into VerifyFile");
		ex3.ErrorCode = FCSErrors.NetError_InvalidParameter;
		throw ex3;
	}

	private bool VerifyFileHash(string fileName, string authFile)
	{
		bool result = false;
		AuthFileCache authFileCache = (AuthFileCache)authFileCacheMap[authFile];
		if (authFileCache == null)
		{
			FCService.WriteTraceLine("" + authFile + "not registered");
			return result;
		}
		string hashForFile = GetHashForFile(fileName);
		if (result = authFileCache.CheckFileNameMatches(hashForFile, fileName))
		{
			FCService.WriteTraceLine("" + fileName + "- Hash verification succeded");
		}
		else
		{
			FCService.WriteTraceLine("" + fileName + "- Hash verification Failed");
		}
		return result;
	}

	private string GetHashForFile(string fileName)
	{
		if (!File.Exists(fileName))
		{
			AuthenticatorException ex = new AuthenticatorException("Source File not found: " + fileName);
			ex.ErrorCode = FCSErrors.File_NotFound;
			throw ex;
		}
		byte[] array = null;
		using (FileStream inputStream = File.Open(fileName, FileMode.Open, FileAccess.Read))
		{
			SHA256Managed sHA256Managed = new SHA256Managed();
			array = sHA256Managed.ComputeHash(inputStream);
		}
		StringBuilder stringBuilder = new StringBuilder();
		byte[] array2 = array;
		foreach (byte value in array2)
		{
			stringBuilder.Append(value);
		}
		return stringBuilder.ToString();
	}
}
