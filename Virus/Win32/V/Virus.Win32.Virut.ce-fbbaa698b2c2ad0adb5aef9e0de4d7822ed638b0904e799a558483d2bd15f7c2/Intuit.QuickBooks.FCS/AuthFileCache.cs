using System;
using System.Collections;
using System.IO;
using System.Runtime.InteropServices;
using System.Xml;

namespace Intuit.QuickBooks.FCS;

[ComVisible(false)]
internal class AuthFileCache
{
	private const string HASH_CODE_ELEMENT_NAME = "HashCode2";

	private Hashtable hashTable;

	private XmlTextReader reader;

	private string hashCode = "";

	public bool Create(string authFileName)
	{
		reader = new XmlTextReader(authFileName);
		hashTable = new Hashtable();
		try
		{
			while (reader.Read())
			{
				if (reader.MoveToContent() == XmlNodeType.Element && reader.Name == "File")
				{
					authFileName = reader.GetAttribute("Name");
					reader.ReadToFollowing("HashCode2");
					if (reader.MoveToContent() == XmlNodeType.Element && reader.Name == "HashCode2")
					{
						hashCode = reader.ReadInnerXml();
					}
					ArrayList arrayList;
					if (hashTable[hashCode] != null)
					{
						arrayList = (ArrayList)hashTable[hashCode];
						arrayList.Add(authFileName.ToUpper());
					}
					else
					{
						arrayList = new ArrayList();
						arrayList.Add(authFileName.ToUpper());
					}
					hashTable[hashCode] = arrayList;
				}
			}
		}
		finally
		{
			reader.Close();
		}
		return true;
	}

	public bool CheckFileNameMatches(string fileHash, string fileName)
	{
		FCService.WriteTraceLine("File: " + fileName);
		FCService.WriteTraceLine("HVAL: " + fileHash);
		ArrayList arrayList = null;
		try
		{
			arrayList = (ArrayList)hashTable[fileHash];
		}
		catch (Exception ex)
		{
			FCService.WriteTraceLine("File not found in the AuthFile: " + fileName);
			FCService.DumpStackTrace(ex);
			return false;
		}
		if (arrayList != null && arrayList.Count != 0)
		{
			string text = Path.GetFileName(fileName)!.ToUpper();
			bool result;
			if (!(result = arrayList.Contains(text)))
			{
				FCService.WriteTraceLine("Bare file name: " + text);
				FCService.WriteTraceLine("List of files that share the same HVAL:");
				{
					foreach (string item in arrayList)
					{
						FCService.WriteTraceLine(item);
					}
					return result;
				}
			}
			return result;
		}
		FCService.WriteTraceLine("File not found in the AuthFile: " + fileName);
		return false;
	}
}
