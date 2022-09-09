using System;
using System.Collections;
using System.Text;

namespace ASInstanceRename;

internal class TextReplaceInFile : TextFileChangeCommand
{
	internal class Param
	{
		private string textToFind = string.Empty;

		private string textToReplaceWith = string.Empty;

		private string textToBePresent = string.Empty;

		public string TextToReplaceWith
		{
			get
			{
				return textToReplaceWith;
			}
			set
			{
				textToReplaceWith = value;
			}
		}

		public string TextToFind
		{
			get
			{
				return textToFind;
			}
			set
			{
				textToFind = value;
			}
		}

		public string TextToBePresent
		{
			get
			{
				return textToBePresent;
			}
			set
			{
				textToBePresent = value;
			}
		}
	}

	private IEnumerable enumerableOfParams;

	public TextReplaceInFile(string fileName, IEnumerable enumerableOfParams, string description)
		: base(fileName, description)
	{
		Argument.NullCheck(enumerableOfParams, "enumerableOfParams");
		this.enumerableOfParams = enumerableOfParams;
	}

	protected override string ModifyContents(string text)
	{
		string[] array = text.Split(new string[1] { Environment.NewLine }, StringSplitOptions.None);
		StringBuilder stringBuilder = new StringBuilder(text.Length);
		for (int i = 0; i < array.Length; i++)
		{
			string text2 = array[i];
			foreach (Param enumerableOfParam in enumerableOfParams)
			{
				if (enumerableOfParam.TextToBePresent.Length == 0 || text2.Contains(enumerableOfParam.TextToBePresent))
				{
					text2 = text2.Replace(enumerableOfParam.TextToFind, enumerableOfParam.TextToReplaceWith);
				}
			}
			stringBuilder.AppendLine(text2);
		}
		return stringBuilder.ToString();
	}
}
