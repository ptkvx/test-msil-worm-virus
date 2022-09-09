using System;

namespace Microsoft.Contracts;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, AllowMultiple = false, Inherited = false)]
internal sealed class ContractClassAttribute : Attribute
{
	private Type _typeWithContracts;

	public Type Type => _typeWithContracts;

	public ContractClassAttribute(Type t)
	{
		_typeWithContracts = t;
	}
}
