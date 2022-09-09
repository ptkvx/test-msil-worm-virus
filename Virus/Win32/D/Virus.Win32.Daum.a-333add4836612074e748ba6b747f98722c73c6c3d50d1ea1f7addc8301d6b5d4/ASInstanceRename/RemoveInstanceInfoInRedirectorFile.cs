using System;
using System.Collections;
using System.Text;

namespace ASInstanceRename;

internal class RemoveInstanceInfoInRedirectorFile : TextFileChangeCommand
{
	private string nameOfServiceInstance = string.Empty;

	public RemoveInstanceInfoInRedirectorFile(string fileName, string nameOfServiceInstance, string description)
		: base(fileName, description)
	{
		Argument.NullCheck(nameOfServiceInstance, "nameOfServiceInstance");
		this.nameOfServiceInstance = nameOfServiceInstance;
	}

	private static string CutText(string text, ArrayList listOfLeftMarkerIndices, ArrayList listOfLengths)
	{
		if (text.Length == 0)
		{
			throw new ArgumentException("CutText method does not accept empty text.");
		}
		if (listOfLeftMarkerIndices.Count == 0)
		{
			throw new ArgumentException("CutText method should have something to cut.", "listOfLeftMarkerIndices");
		}
		if (listOfLeftMarkerIndices.Count != listOfLengths.Count)
		{
			throw new ArgumentException("CutText method expects the list of text lengths to be of the same size with the list of marker indices.", "listOfLengths");
		}
		StringBuilder stringBuilder = new StringBuilder();
		int num = 0;
		int i = 0;
		for (int count = listOfLeftMarkerIndices.Count; i < count; i++)
		{
			int num2 = (int)listOfLeftMarkerIndices[i];
			if (num2 >= num)
			{
				int num3 = (int)listOfLengths[i];
				stringBuilder.Append(text.Substring(num, num2 - num));
				num = num2 + num3;
				continue;
			}
			throw new ArgumentException("CutText method was passed some overlapped ranges.");
		}
		stringBuilder.Append(text.Substring(num));
		return stringBuilder.ToString();
	}

	private bool FindRange(string text, string textAtLeft, string textAtRight, int indexOfStart, int count, out int indexOfLeft, out int indexOfRight)
	{
		indexOfRight = 0;
		indexOfLeft = 0;
		indexOfLeft = text.IndexOf(textAtLeft, indexOfStart, count);
		if (indexOfLeft < 0)
		{
			return false;
		}
		int num = indexOfLeft + textAtLeft.Length;
		indexOfRight = text.IndexOf(textAtRight, num, count - num + indexOfStart);
		return indexOfRight >= 0;
	}

	private string ModifyText(string text)
	{
		if (!FindRange(text, "<Instances>", "</Instances>", 0, text.Length, out var indexOfLeft, out var indexOfRight))
		{
			return string.Empty;
		}
		int indexOfLeft2 = indexOfLeft + "<Instances>".Length;
		int num = indexOfRight - indexOfLeft2;
		ArrayList arrayList = new ArrayList();
		ArrayList arrayList2 = new ArrayList();
		int indexOfRight2;
		while (num > 0 && FindRange(text, "<Instance>", "</Instance>", indexOfLeft2, num, out indexOfLeft2, out indexOfRight2))
		{
			if (text.IndexOf(nameOfServiceInstance, indexOfLeft2 + "<Instances>".Length, indexOfRight2 - indexOfLeft2 - "<Instance>".Length) >= 0)
			{
				arrayList.Add(indexOfLeft2);
				arrayList2.Add(indexOfRight2 + "</Instance>".Length - indexOfLeft2);
			}
			indexOfLeft2 = indexOfRight2 + "</Instance>".Length;
			num = indexOfRight - indexOfLeft2;
		}
		if (arrayList.Count > 0)
		{
			return CutText(text, arrayList, arrayList2);
		}
		return string.Empty;
	}

	protected override string ModifyContents(string text)
	{
		string text2 = ModifyText(text);
		if (text2.Length == 0)
		{
			text2 = text;
		}
		return text2;
	}
}
