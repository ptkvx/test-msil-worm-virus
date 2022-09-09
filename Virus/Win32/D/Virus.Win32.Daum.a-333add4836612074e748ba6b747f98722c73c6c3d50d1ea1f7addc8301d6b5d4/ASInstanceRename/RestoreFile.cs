using System.IO;

namespace ASInstanceRename;

internal class RestoreFile : IInstCommand
{
	public const string BackupFileSuffix = ".bak";

	private string fileName = string.Empty;

	private string description = string.Empty;

	public string Description => description;

	public RestoreFile(string fileName, string description)
	{
		Argument.NullCheck(fileName, "fileName");
		Argument.NullCheck(description, "description");
		this.fileName = fileName;
		this.description = description;
	}

	public void Execute()
	{
		string text = fileName + ".bak";
		if (!File.Exists(text))
		{
			string message = $"Backup file {text} has not been found.";
			throw new InstanceRenameException(message);
		}
		if (File.Exists(fileName))
		{
			File.Delete(fileName);
		}
		File.Move(text, fileName);
	}
}
