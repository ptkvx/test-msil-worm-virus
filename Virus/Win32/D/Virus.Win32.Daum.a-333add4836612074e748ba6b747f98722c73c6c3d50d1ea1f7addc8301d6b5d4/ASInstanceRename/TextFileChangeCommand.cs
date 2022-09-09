using System.IO;
using System.Text;

namespace ASInstanceRename;

internal abstract class TextFileChangeCommand : IInstCommand
{
	private string fileName = string.Empty;

	private string description = string.Empty;

	public string Description => description;

	public TextFileChangeCommand(string fileName, string description)
	{
		Argument.NullCheck(fileName, "fileName");
		Argument.NullCheck(description, "description");
		this.fileName = fileName;
		this.description = description;
	}

	private string GetTempFileNameInSameFolder()
	{
		string empty = string.Empty;
		int num = 0;
		while (true)
		{
			if (num < 300)
			{
				empty = fileName + num;
				if (!File.Exists(empty))
				{
					break;
				}
				num++;
				continue;
			}
			string message = $"Could not construct temporary file name for {fileName}";
			throw new InstanceRenameException(message);
		}
		return empty;
	}

	protected abstract string ModifyContents(string text);

	public void Execute()
	{
		string tempFileNameInSameFolder = GetTempFileNameInSameFolder();
		try
		{
			string text = File.ReadAllText(fileName);
			text = ModifyContents(text);
			File.WriteAllText(tempFileNameInSameFolder, text, Encoding.Unicode);
			string text2 = fileName + ".bak";
			if (File.Exists(text2))
			{
				File.Delete(text2);
			}
			File.Replace(tempFileNameInSameFolder, fileName, text2);
		}
		finally
		{
			if (File.Exists(tempFileNameInSameFolder))
			{
				File.Delete(tempFileNameInSameFolder);
			}
		}
	}
}
