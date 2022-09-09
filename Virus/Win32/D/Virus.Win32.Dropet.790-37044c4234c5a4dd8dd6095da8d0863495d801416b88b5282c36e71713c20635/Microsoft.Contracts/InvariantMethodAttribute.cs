using System;

namespace Microsoft.Contracts;

[AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = false)]
internal sealed class InvariantMethodAttribute : Attribute
{
}
