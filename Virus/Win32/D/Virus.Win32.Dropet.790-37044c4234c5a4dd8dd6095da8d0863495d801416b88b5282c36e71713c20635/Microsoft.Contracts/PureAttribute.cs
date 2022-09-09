using System;

namespace Microsoft.Contracts;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Event, AllowMultiple = false, Inherited = true)]
internal sealed class PureAttribute : Attribute
{
}
