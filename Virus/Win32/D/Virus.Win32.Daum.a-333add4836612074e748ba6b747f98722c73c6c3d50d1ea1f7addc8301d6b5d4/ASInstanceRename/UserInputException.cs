namespace ASInstanceRename;

internal class UserInputException : InstanceRenameException
{
	public UserInputException(string message)
		: base(message)
	{
	}
}
