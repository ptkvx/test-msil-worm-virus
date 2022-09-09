using System;
using System.Runtime.InteropServices;
using System.Threading;

namespace msclr;

internal class @lock : IDisposable
{
	private object m_object;

	private bool m_locked;

	public @lock(object _object)
	{
		m_object = _object;
		m_locked = false;
		base._002Ector();
		acquire(-1);
	}

	private void method_0()
	{
		release();
	}

	[return: MarshalAs(UnmanagedType.U1)]
	public bool is_locked()
	{
		return m_locked;
	}

	public implicit operator string()
	{
		return (!m_locked) ? _detail_class._safe_false : _detail_class._safe_true;
	}

	public void acquire(TimeSpan _timeout)
	{
		if (!m_locked)
		{
			if (!Monitor.TryEnter(m_object, _timeout))
			{
				throw new ApplicationException("lock timeout");
			}
			m_locked = true;
		}
	}

	public void acquire()
	{
		if (!m_locked)
		{
			if (!Monitor.TryEnter(m_object, -1))
			{
				throw new ApplicationException("lock timeout");
			}
			m_locked = true;
		}
	}

	public void acquire(int _timeout)
	{
		if (!m_locked)
		{
			if (!Monitor.TryEnter(m_object, _timeout))
			{
				throw new ApplicationException("lock timeout");
			}
			m_locked = true;
		}
	}

	[return: MarshalAs(UnmanagedType.U1)]
	public bool try_acquire(TimeSpan _timeout)
	{
		if (!m_locked)
		{
			if (!Monitor.TryEnter(m_object, _timeout))
			{
				return false;
			}
			m_locked = true;
		}
		return true;
	}

	[return: MarshalAs(UnmanagedType.U1)]
	public bool try_acquire(int _timeout)
	{
		if (!m_locked)
		{
			if (!Monitor.TryEnter(m_object, _timeout))
			{
				return false;
			}
			m_locked = true;
		}
		return true;
	}

	public void release()
	{
		if (m_locked)
		{
			m_locked = false;
			Monitor.Exit(m_object);
		}
	}

	protected virtual void Dispose([MarshalAs(UnmanagedType.U1)] bool bool_0)
	{
		if (bool_0)
		{
			release();
		}
		else
		{
			base.Finalize();
		}
	}

	public sealed override void Dispose()
	{
		Dispose(bool_0: true);
		GC.SuppressFinalize(this);
	}
}
