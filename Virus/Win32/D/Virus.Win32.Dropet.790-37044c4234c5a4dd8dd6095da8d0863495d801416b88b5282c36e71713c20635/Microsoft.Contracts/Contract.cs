using System;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Microsoft.Contracts;

internal static class Contract
{
	[Serializable]
	public sealed class PreconditionException : Exception
	{
		public PreconditionException()
			: this("Precondition failed.")
		{
		}

		public PreconditionException(string s)
			: base(s)
		{
		}

		public PreconditionException(string s, Exception inner)
			: base(s, inner)
		{
		}

		private PreconditionException(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
		}
	}

	[Serializable]
	public sealed class PostconditionException : Exception
	{
		public PostconditionException()
			: this("Postcondition failed.")
		{
		}

		public PostconditionException(string s)
			: base(s)
		{
		}

		public PostconditionException(string s, Exception inner)
			: base(s, inner)
		{
		}

		private PostconditionException(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
		}
	}

	[Serializable]
	public sealed class InvariantException : Exception
	{
		public InvariantException()
		{
		}

		public InvariantException(string s)
			: base(s)
		{
		}

		public InvariantException(string s, Exception inner)
			: base(s, inner)
		{
		}

		private InvariantException(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
		}
	}

	[Serializable]
	public sealed class AssertionException : Exception
	{
		public AssertionException()
		{
		}

		public AssertionException(string s)
			: base(s)
		{
		}

		public AssertionException(string s, Exception inner)
			: base(s, inner)
		{
		}

		private AssertionException(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
		}
	}

	[Serializable]
	public sealed class AssumptionException : Exception
	{
		public AssumptionException()
		{
		}

		public AssumptionException(string s)
			: base(s)
		{
		}

		public AssumptionException(string s, Exception inner)
			: base(s, inner)
		{
		}

		private AssumptionException(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
		}
	}

	[Pure]
	[Conditional("DEBUG")]
	public static void Assume(bool b)
	{
	}

	[Conditional("DEBUG")]
	[Pure]
	public static void Assume(bool b, string message)
	{
		if (!b)
		{
			throw new AssumptionException(message);
		}
	}

	[Pure]
	[Conditional("DEBUG")]
	public static void Assert(bool b)
	{
	}

	[Conditional("DEBUG")]
	[Pure]
	public static void Assert(bool b, string message)
	{
	}

	[Pure]
	public static void Requires(bool b)
	{
		if (!b)
		{
			throw new PreconditionException();
		}
	}

	[Pure]
	public static void Requires(Exception x)
	{
		if (x != null)
		{
			throw x;
		}
	}

	[Pure]
	[Conditional("DEBUG")]
	public static void DebugRequires(bool b)
	{
	}

	[Conditional("USE_SPECSHARP_ASSEMBLY_REWRITER")]
	[Pure]
	public static void Ensures(bool b)
	{
		_ = "This method will be modified to the following after rewriting:" + "if (!b) throw new PostConditionException();";
	}

	[Conditional("USE_SPECSHARP_ASSEMBLY_REWRITER")]
	[Pure]
	public static void Throws<E>() where E : Exception
	{
	}

	[Conditional("USE_SPECSHARP_ASSEMBLY_REWRITER")]
	[Pure]
	public static void ThrowsEnsures<E>(bool b) where E : Exception
	{
		_ = "This method will be modified to the following after rewriting:" + "if (!b) throw new PostconditionException();";
	}

	[Pure]
	[Conditional("USE_SPECSHARP_ASSEMBLY_REWRITER")]
	public static void AssertOnReturn(bool b)
	{
		_ = "This method will be modified to the following after rewriting:" + "if (!b) throw new AssertionException();";
	}

	[Pure]
	[Conditional("USE_SPECSHARP_ASSEMBLY_REWRITER")]
	public static void AssertOnException<E>(bool b) where E : Exception
	{
		_ = "This method will be modified to the following after rewriting:" + "if (!b) throw new AssertionException();";
	}

	[Pure]
	public static T Result<T>()
	{
		return default(T);
	}

	[Pure]
	public static T Parameter<T>(out T t)
	{
		t = default(T);
		return t;
	}

	[Pure]
	public static T Old<T>(T t)
	{
		return t;
	}

	[Conditional("USE_SPECSHARP_ASSEMBLY_REWRITER")]
	[Pure]
	public static void Invariant(bool b)
	{
		_ = "This method will be modified to the following after rewriting:" + "if (!b) throw new InvariantException();";
	}

	public static bool ForAll(int lo, int hi, Predicate<int> p)
	{
		Requires(lo <= hi);
		Requires(p != null);
		int num = lo;
		while (true)
		{
			if (num < hi)
			{
				if (!p(num))
				{
					break;
				}
				num++;
				continue;
			}
			return true;
		}
		return false;
	}

	public static bool Exists(int lo, int hi, Predicate<int> p)
	{
		Requires(lo <= hi);
		Requires(p != null);
		int num = lo;
		while (true)
		{
			if (num < hi)
			{
				if (p(num))
				{
					break;
				}
				num++;
				continue;
			}
			return false;
		}
		return true;
	}

	[Pure]
	public static void RewriterEnsures(bool b)
	{
		if (!b)
		{
			throw new PostconditionException();
		}
	}

	[Pure]
	public static void RewriterInvariant(bool b)
	{
		if (!b)
		{
			throw new InvariantException();
		}
	}
}
