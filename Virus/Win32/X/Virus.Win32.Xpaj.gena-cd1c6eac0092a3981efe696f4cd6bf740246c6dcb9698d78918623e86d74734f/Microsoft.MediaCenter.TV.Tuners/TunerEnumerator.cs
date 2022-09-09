using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using msclr;

namespace Microsoft.MediaCenter.TV.Tuners;

public class TunerEnumerator : ITunerEnumerator
{
	private IEnumerator<Tuner> m_enum = ((IEnumerable<Tuner>)a).GetEnumerator();

	private object m_Lock = new object();

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public virtual Tuner Current
	{
		get
		{
			@lock @lock = null;
			@lock lock2 = new @lock(m_Lock);
			Tuner result;
			try
			{
				@lock = lock2;
				result = _003CModule_003E.smethod_113(m_enum.Current);
			}
			catch
			{
				//try-fault
				((IDisposable)@lock).Dispose();
				throw;
			}
			((IDisposable)@lock).Dispose();
			return result;
		}
	}

	virtual object IEnumerator.Current
	{
		get
		{
			@lock @lock = null;
			@lock lock2 = new @lock(m_Lock);
			object result;
			try
			{
				@lock = lock2;
				result = _003CModule_003E.smethod_113(m_enum.Current);
			}
			catch
			{
				//try-fault
				((IDisposable)@lock).Dispose();
				throw;
			}
			((IDisposable)@lock).Dispose();
			return result;
		}
	}

	[CLSCompliant(false)]
	internal TunerEnumerator(Tuner[] a)
	{
	}

	private void method_0()
	{
		@lock @lock = null;
		@lock lock2 = new @lock(m_Lock);
		try
		{
			@lock = lock2;
			m_enum?.Dispose();
			m_enum = null;
		}
		catch
		{
			//try-fault
			((IDisposable)@lock).Dispose();
			throw;
		}
		((IDisposable)@lock).Dispose();
	}

	private void method_1()
	{
		method_0();
	}

	public virtual void Reset()
	{
		m_enum.Reset();
	}

	[return: MarshalAs(UnmanagedType.U1)]
	public virtual bool MoveNext()
	{
		return m_enum.MoveNext();
	}

	protected virtual void Dispose([MarshalAs(UnmanagedType.U1)] bool bool_0)
	{
		if (bool_0)
		{
			method_0();
			return;
		}
		try
		{
			method_0();
		}
		finally
		{
			base.Finalize();
		}
	}

	public sealed override void Dispose()
	{
		Dispose(bool_0: true);
		GC.SuppressFinalize(this);
	}

	~TunerEnumerator()
	{
		Dispose(bool_0: false);
	}
}
