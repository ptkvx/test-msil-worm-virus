using System.Collections;
using Microsoft.Win32;

namespace ASInstanceRename;

internal class CreateRegistryKeyCommand : IInstCommand
{
	internal class ValueParam
	{
		private string nameOfProp = string.Empty;

		private object valueOfProp = string.Empty;

		public string Name => nameOfProp;

		public object Value => valueOfProp;

		public ValueParam(string name, object value)
		{
			nameOfProp = name;
			Argument.NullCheck(value, "value");
			valueOfProp = value;
		}
	}

	private string nameOfKey = string.Empty;

	private IEnumerable enumerableOfValueParams;

	private string description = string.Empty;

	public string Description => description;

	public CreateRegistryKeyCommand(string nameOfKey, IEnumerable enumerableOfValueParams, string description)
	{
		Argument.NullCheck(nameOfKey, "nameOfKey");
		Argument.NullCheck(enumerableOfValueParams, "enumerableOfValueParams");
		Argument.NullCheck(description, "description");
		this.nameOfKey = nameOfKey;
		this.enumerableOfValueParams = enumerableOfValueParams;
		this.description = description;
	}

	public CreateRegistryKeyCommand(string nameOfKey, ValueParam param, string description)
		: this(nameOfKey, new ValueParam[1] { param }, description)
	{
	}

	public CreateRegistryKeyCommand(string nameOfKey, string description)
		: this(nameOfKey, new ValueParam[0], description)
	{
	}

	public void Execute()
	{
		bool flag = false;
		try
		{
			using RegistryKey registryKey = Registry.LocalMachine.CreateSubKey(nameOfKey);
			flag = true;
			foreach (ValueParam enumerableOfValueParam in enumerableOfValueParams)
			{
				registryKey.SetValue(enumerableOfValueParam.Name, enumerableOfValueParam.Value);
			}
			flag = false;
		}
		finally
		{
			if (flag)
			{
				Registry.LocalMachine.DeleteSubKey(nameOfKey);
			}
		}
	}
}
