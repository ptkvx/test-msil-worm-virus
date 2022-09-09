using System;

namespace Microsoft.Contracts;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct, AllowMultiple = false, Inherited = false)]
internal sealed class ImmutableAttribute : Attribute
{
}
