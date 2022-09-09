using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;

namespace Stub_back.My;

[HideModuleName]
[GeneratedCode("MyTemplate", "10.0.0.0")]
[StandardModule]
internal sealed class MyProject
{
	[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class r
	{
		[ThreadStatic]
		private static Hashtable n;

		private static T a<T>(T p) where T : Form, new()
		{
			if (p != null && !((Control)p).get_IsDisposed())
			{
				return p;
			}
			if (n != null)
			{
				if (n.ContainsKey(typeof(T)))
				{
					throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", new string[0]));
				}
			}
			else
			{
				n = new Hashtable();
			}
			n.Add(typeof(T), null);
			try
			{
				return new T();
			}
			catch (TargetInvocationException ex) when (((Func<bool>)delegate
			{
				// Could not convert BlockContainer to single expression
				ProjectData.SetProjectError((Exception)ex);
				return ex.InnerException != null;
			}).Invoke())
			{
				string resourceString = Utils.GetResourceString("WinForms_SeeInnerException", new string[1] { ex.InnerException!.Message });
				throw new InvalidOperationException(resourceString, ex.InnerException);
			}
			finally
			{
				n.Remove(typeof(T));
			}
		}

		private void s<T>(ref T c) where T : Form
		{
			((Component)c).Dispose();
			c = default(T);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public r()
		{
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Equals(object b)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(b));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type o()
		{
			return typeof(r);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string ToString()
		{
			return base.ToString();
		}
	}

	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class s
	{
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Equals(object p)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(p));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type w()
		{
			return typeof(s);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string ToString()
		{
			return base.ToString();
		}

		private static T g<T>(T w) where T : new()
		{
			if (w == null)
			{
				return new T();
			}
			return w;
		}

		private void m<T>(ref T v)
		{
			v = default(T);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public s()
		{
		}
	}

	[ComVisible(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class v<i> where i : new()
	{
		[ThreadStatic]
		private static i e;

		[SpecialName]
		internal i k()
		{
			if (e == null)
			{
				e = new i();
			}
			return e;
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public v()
		{
		}
	}

	private static readonly v<MyComputer> d = new v<MyComputer>();

	private static readonly v<MyApplication> w = new v<MyApplication>();

	private static readonly v<User> p = new v<User>();

	private static v<r> m_v = new v<r>();

	private static readonly v<s> d = new v<s>();

	[HelpKeyword("My.Computer")]
	internal static MyComputer y => MyProject.d.k();

	[HelpKeyword("My.Application")]
	internal static MyApplication l => w.k();

	[HelpKeyword("My.User")]
	internal static User n => p.k();

	[HelpKeyword("My.Forms")]
	internal static r h => m_v.k();

	[HelpKeyword("My.WebServices")]
	internal static s u => d.k();
}
