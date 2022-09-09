using System;
using System.Collections;
using System.Runtime.CompilerServices;

public class cqj : MarshalByRefObject
{
	private cu8 m_a;

	private bfo m_b;

	private c21 c;

	private etk d;

	private bsh e;

	private c2q f;

	private a97 g;

	private static ArrayList h = null;

	public event a97 _Deleted
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			g = (a97)Delegate.Combine(g, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			g = (a97)Delegate.Remove(g, value);
		}
	}

	public event c2q _Deleted
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			f = (c2q)Delegate.Combine(f, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			f = (c2q)Delegate.Remove(f, value);
		}
	}

	public event bsh _Deleted
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			e = (bsh)Delegate.Combine(e, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			e = (bsh)Delegate.Remove(e, value);
		}
	}

	public event etk _Deleted
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			d = (etk)Delegate.Combine(d, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			d = (etk)Delegate.Remove(d, value);
		}
	}

	public event c21 _Deleted
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			c = (c21)Delegate.Combine(c, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			c = (c21)Delegate.Remove(c, value);
		}
	}

	public event bfo _Deleted
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			this.m_b = (bfo)Delegate.Combine(this.m_b, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			this.m_b = (bfo)Delegate.Remove(this.m_b, value);
		}
	}

	public event cu8 _Deleted
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			this.m_a = (cu8)Delegate.Combine(this.m_a, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			this.m_a = (cu8)Delegate.Remove(this.m_a, value);
		}
	}

	public void a()
	{
		if (h == null)
		{
			h = new ArrayList();
		}
		h.Add(this);
	}

	public void b()
	{
		if (h != null)
		{
			h.Remove(this);
		}
	}

	[SpecialName]
	protected void raise__Deleted(string string_0, dg7 dg7_0)
	{
		this.m_a?.Invoke(string_0, dg7_0);
	}

	[SpecialName]
	protected void raise__Deleted(string string_0, asz asz_0)
	{
		this.m_b?.Invoke(string_0, asz_0);
	}

	[SpecialName]
	protected void raise__Deleted(ctd ctd_0)
	{
		c?.Invoke(ctd_0);
	}

	[SpecialName]
	protected void raise__Deleted(ba7 ba7_0)
	{
		d?.Invoke(ba7_0);
	}

	[SpecialName]
	protected void raise__Deleted(cnw cnw_0)
	{
		e?.Invoke(cnw_0);
	}

	[SpecialName]
	protected void raise__Deleted(string string_0, wk wk_0)
	{
		f?.Invoke(string_0, wk_0);
	}

	[SpecialName]
	protected void raise__Deleted(eha eha_0, ca9 ca9_0)
	{
		g?.Invoke(eha_0, ca9_0);
	}

	public static void a(string string_0, dg7 dg7_0)
	{
		if (h == null)
		{
			return;
		}
		for (int i = 0; i < h.Count; i++)
		{
			try
			{
				((cqj)(h[i]!)).raise__Deleted(string_0, dg7_0);
				break;
			}
			catch (Exception)
			{
			}
		}
	}

	public static void a(string string_0, asz asz_0)
	{
		if (h == null)
		{
			return;
		}
		for (int i = 0; i < h.Count; i++)
		{
			try
			{
				((cqj)(h[i]!)).raise__Deleted(string_0, asz_0);
				break;
			}
			catch (Exception)
			{
			}
		}
	}

	public static void a(ctd ctd_0)
	{
		if (h == null)
		{
			return;
		}
		for (int i = 0; i < h.Count; i++)
		{
			try
			{
				((cqj)(h[i]!)).raise__Deleted(ctd_0);
				break;
			}
			catch (Exception)
			{
			}
		}
	}

	public static void a(ba7 ba7_0)
	{
		if (h == null)
		{
			return;
		}
		for (int i = 0; i < h.Count; i++)
		{
			try
			{
				((cqj)(h[i]!)).raise__Deleted(ba7_0);
				break;
			}
			catch (Exception)
			{
			}
		}
	}

	public static void a(cnw cnw_0)
	{
		if (h == null)
		{
			return;
		}
		for (int i = 0; i < h.Count; i++)
		{
			try
			{
				((cqj)(h[i]!)).raise__Deleted(cnw_0);
				break;
			}
			catch (Exception)
			{
			}
		}
	}

	public static void a(string string_0, wk wk_0)
	{
		if (h == null)
		{
			return;
		}
		for (int i = 0; i < h.Count; i++)
		{
			try
			{
				((cqj)(h[i]!)).raise__Deleted(string_0, wk_0);
				break;
			}
			catch (Exception)
			{
			}
		}
	}

	public static void a(eha eha_0, ca9 ca9_0)
	{
		if (h == null)
		{
			return;
		}
		for (int i = 0; i < h.Count; i++)
		{
			try
			{
				((cqj)(h[i]!)).raise__Deleted(eha_0, ca9_0);
				break;
			}
			catch (Exception)
			{
			}
		}
	}
}
