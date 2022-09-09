using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Media;
using System.Net;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using W3DR.Properties;
using a;

namespace A
{
	public class A
	{
		private static global::a.A m_A;

		private string m_A;

		private string m_a;

		private string m_B;

		private string m_b;

		private string m_C;

		private string m_c;

		private string m_D;

		private string m_d;

		private string m_E;

		private string m_e;

		private string m_F;

		private string m_f;

		private string m_G;

		private string m_g;

		private string m_H;

		private string m_h;

		private string m_I;

		private string m_i;

		private string m_J;

		private string m_j;

		private string m_K;

		private string m_k;

		private string m_L;

		[SpecialName]
		public string A()
		{
			return this.m_d;
		}

		[SpecialName]
		public string a()
		{
			return this.m_A;
		}

		[SpecialName]
		public string B()
		{
			return this.m_a;
		}

		[SpecialName]
		public string b()
		{
			return this.m_B;
		}

		[SpecialName]
		public string C()
		{
			return this.m_b;
		}

		[SpecialName]
		public string c()
		{
			return this.m_C;
		}

		[SpecialName]
		public string D()
		{
			return this.m_c;
		}

		[SpecialName]
		public string d()
		{
			return this.m_D;
		}

		[SpecialName]
		public string E()
		{
			return this.m_E;
		}

		[SpecialName]
		public string e()
		{
			return this.m_e;
		}

		[SpecialName]
		public string F()
		{
			return this.m_f;
		}

		[SpecialName]
		public string f()
		{
			return this.m_F;
		}

		[SpecialName]
		public string G()
		{
			return this.m_G;
		}

		[SpecialName]
		public string g()
		{
			return this.m_g;
		}

		[SpecialName]
		public string H()
		{
			return this.m_H;
		}

		[SpecialName]
		public string h()
		{
			return this.m_h;
		}

		[SpecialName]
		public string I()
		{
			return this.m_I;
		}

		[SpecialName]
		public string i()
		{
			return this.m_i;
		}

		[SpecialName]
		public string J()
		{
			return this.m_J;
		}

		[SpecialName]
		public string j()
		{
			return this.m_j;
		}

		[SpecialName]
		public string K()
		{
			return this.m_K;
		}

		[SpecialName]
		public string k()
		{
			return this.m_k;
		}

		[SpecialName]
		public string L()
		{
			return this.m_L;
		}

		private bool A(ref string string_0, string string_1)
		{
			string_0 = global::A.A.m_A.A(string_1);
			if (string_0 == null)
			{
				this.A();
				return true;
			}
			return false;
		}

		public void A(string string_0)
		{
			if (!File.Exists(string_0))
			{
				this.A();
				return;
			}
			global::A.A.m_A = new global::a.A(string_0);
			if (!A(ref this.m_A, "error1") && !A(ref this.m_a, "error6") && !A(ref this.m_B, "error8") && !A(ref this.m_b, "error10") && !A(ref this.m_C, "error11") && !A(ref this.m_c, "error12") && !A(ref this.m_D, "error13") && !A(ref this.m_d, "error15") && !A(ref this.m_E, "string1") && !A(ref this.m_e, "string2") && !A(ref this.m_F, "string3") && !A(ref this.m_f, "string4") && !A(ref this.m_G, "string5") && !A(ref this.m_g, "string6") && !A(ref this.m_H, "string7") && !A(ref this.m_h, "string8") && !A(ref this.m_I, "string9") && !A(ref this.m_i, "string10") && !A(ref this.m_J, "string11") && !A(ref this.m_j, "string12") && !A(ref this.m_K, "string13") && !A(ref this.m_k, "string14") && A(ref this.m_L, "string15"))
			{
			}
		}

		private void A()
		{
			this.m_A = "Delay value must be between 0 and 550";
			this.m_a = "Could not retrieve in game delay value";
			this.m_B = "Could not retrieve pre game delay value";
			this.m_b = "Could not change in game delay value";
			this.m_C = "Could not change pre game delay value";
			this.m_c = "Could not change pre/in game delay value";
			this.m_D = "Could not retrieve players";
			this.m_d = "Could not access W3";
			this.m_E = "Error:";
			this.m_e = "Version";
			this.m_F = "is available";
			this.m_f = "W3 not open";
			this.m_G = "Another instance is already running";
			this.m_g = "Support";
			this.m_H = "Exit";
			this.m_h = "Changed pre/in game delay for hosting";
			this.m_I = "Changed pre game delay value for hosting";
			this.m_i = "Language";
			this.m_J = "Update";
			this.m_j = "No players to query";
			this.m_K = "No players to ping";
			this.m_k = "No pings";
			this.m_L = "No country checks";
		}
	}
	internal static class a
	{
		[Flags]
		public enum A : uint
		{
			A = 0x1F0FFFu,
			a = 1u,
			B = 2u,
			b = 8u,
			C = 0x10u,
			c = 0x20u,
			D = 0x40u,
			d = 0x200u,
			E = 0x400u,
			e = 0x100000u
		}

		public enum a : byte
		{
			A,
			a,
			B,
			b,
			C
		}

		private struct B
		{
			public IntPtr A;

			public long A;
		}

		private struct b
		{
			public string A;

			public string a;
		}

		private struct C
		{
			public int A;

			public B A;

			public IntPtr A;

			public Process A;
		}

		public enum c : byte
		{
			A = 1,
			a,
			B
		}

		private const string m_A = "http://vt-s.tk";

		private const string m_a = "Warcraft III Delay Reducer";

		private static NotifyIcon m_A;

		private static ContextMenuStrip m_A;

		private static ToolStripTextBox m_A;

		private static bool m_A = true;

		private static uint m_A;

		private static Timer m_A = new Timer();

		private static Timer m_a = new Timer();

		private static Timer m_B = new Timer();

		private static IntPtr m_A;

		private static IntPtr m_a;

		private static IntPtr m_B;

		private static bool m_a;

		private static global::A.A m_A;

		private static string m_B = string.Empty;

		private static string m_b = string.Empty;

		private static a m_A = global::A.a.a.A;

		private static IntPtr m_b = IntPtr.Zero;

		private static C m_A;

		private static byte[] m_A = null;

		private static byte[] m_a = null;

		private static byte[] m_B = null;

		private static IntPtr m_C = IntPtr.Zero;

		private static IntPtr m_c = IntPtr.Zero;

		private static byte[] m_b = null;

		private static bool m_B = false;

		private static bool m_b = false;

		[DllImport("Kernel32", SetLastError = true)]
		public static extern IntPtr OpenProcess(IntPtr intptr_0, bool bool_0, int int_0);

		[DllImport("Kernel32")]
		[return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool CloseHandle(IntPtr intptr_0);

		[DllImport("Kernel32", SetLastError = true)]
		private static extern bool ReadProcessMemory(IntPtr intptr_0, IntPtr intptr_1, [Out] byte[] byte_0, int int_0, out int int_1);

		[DllImport("Kernel32", SetLastError = true)]
		private static extern bool WriteProcessMemory(IntPtr intptr_0, IntPtr intptr_1, byte[] byte_0, int int_0, out int int_1);

		[DllImport("User32", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool PostMessage(IntPtr intptr_0, uint uint_0, uint uint_1, uint uint_2);

		[STAThread]
		private static void A()
		{
			//IL_0059: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cd: Expected O, but got Unknown
			//IL_0102: Unknown result type (might be due to invalid IL or missing references)
			//IL_010c: Expected O, but got Unknown
			//IL_010c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0116: Expected O, but got Unknown
			//IL_0125: Unknown result type (might be due to invalid IL or missing references)
			//IL_012b: Expected O, but got Unknown
			//IL_013d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0147: Expected O, but got Unknown
			//IL_015f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0169: Expected O, but got Unknown
			//IL_0175: Unknown result type (might be due to invalid IL or missing references)
			//IL_017f: Expected O, but got Unknown
			//IL_0189: Unknown result type (might be due to invalid IL or missing references)
			//IL_018f: Expected O, but got Unknown
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			int num = Process.GetProcessesByName(Process.GetCurrentProcess().ProcessName).Length;
			global::A.a.m_A = new global::A.A();
			global::A.a.m_A.A(".\\language\\" + W3DR.Properties.a.Default.language);
			switch (num)
			{
			case 2:
				MessageBox.Show(global::A.a.m_A.G(), "Warcraft III Delay Reducer", (MessageBoxButtons)0);
				break;
			case 1:
			{
				if (W3DR.Properties.a.Default.lastCheck + 864000000000L <= DateTime.Now.Ticks)
				{
					Thread thread = new Thread(b);
					thread.Start();
				}
				global::A.a.m_A = default(C);
				global::A.a.m_A.A = default(B);
				E();
				global::A.a.m_A = new NotifyIcon();
				global::A.a.m_A.set_Visible(true);
				global::A.a.m_A.set_Text("Warcraft III Delay Reducer");
				global::A.a.m_A.set_Icon(W3DR.Properties.A.A());
				global::A.a.m_A.add_MouseClick(new MouseEventHandler(A));
				global::A.a.m_A = new ContextMenuStrip();
				c();
				ToolStripMenuItem val = new ToolStripMenuItem(global::A.a.m_A.g());
				((ToolStripItem)val).add_Click((EventHandler)c);
				global::A.a.m_A = new ToolStripTextBox();
				global::A.a.m_A.set_MaxLength(10);
				((ToolStripControlHost)global::A.a.m_A).add_KeyUp(new KeyEventHandler(A));
				((ToolStripControlHost)global::A.a.m_A).add_KeyPress(new KeyPressEventHandler(A));
				ToolStripMenuItem val2 = new ToolStripMenuItem(global::A.a.m_A.H());
				((ToolStripItem)val2).add_Click((EventHandler)C);
				((ToolStrip)global::A.a.m_A).get_Items().Add((ToolStripItem)(object)val);
				((ToolStrip)global::A.a.m_A).get_Items().Add((ToolStripItem)(object)global::A.a.m_A);
				((ToolStrip)global::A.a.m_A).get_Items().Add((ToolStripItem)(object)val2);
				global::A.a.m_A.set_ContextMenuStrip(global::A.a.m_A);
				global::A.a.m_A = W3DR.Properties.a.Default.delay;
				((ToolStripItem)global::A.a.m_A).set_Text(W3DR.Properties.a.Default.delay.ToString());
				try
				{
					Process.EnterDebugMode();
				}
				catch (Win32Exception ex)
				{
					A(global::A.a.m_A.E() + " Process.EnterDebugMode (" + ex.NativeErrorCode + ")", bool_0: true);
				}
				catch (Exception)
				{
					A(global::A.a.m_A.E() + " Process.EnterDebugMode (?)", bool_0: true);
				}
				global::A.a.m_A.add_Tick((EventHandler)a);
				global::A.a.m_A.set_Interval(500);
				global::A.a.m_A.set_Enabled(true);
				global::A.a.m_a.add_Tick((EventHandler)A);
				global::A.a.m_a.set_Interval(250);
				global::A.a.m_B.add_Tick((EventHandler)B);
				global::A.a.m_B.set_Interval(1000);
				if (global::A.a.A() == global::A.a.c.a && global::A.a.A())
				{
					global::A.a.B();
					global::A.a.m_b = true;
					global::A.a.m_B = global::A.a.A() != null;
					if (global::A.a.m_B)
					{
						if (global::A.a.m_B != IntPtr.Zero)
						{
							global::A.a.m_B.set_Enabled(true);
						}
						global::A.a.m_a.set_Enabled(false);
					}
				}
				d();
				Application.Run();
				break;
			}
			}
		}

		private static bool A(long long_0, long long_1)
		{
			while (long_0 > long_1)
			{
				long_0 /= 10L;
			}
			return long_0 == long_1;
		}

		private static void A(object sender, EventArgs e)
		{
			if (global::A.a.m_b)
			{
				if (global::A.a.m_B)
				{
					if (global::A.a.m_a == IntPtr.Zero && (global::A.a.m_A.A.A != 0L || global::A.a.m_A.A.A != IntPtr.Zero))
					{
						if (A(global::A.a.m_A.A.A, 122L))
						{
							byte[] byte_ = (global::A.a.m_A = new byte[5] { 156, 200, 121, 100, 156 });
							global::A.a.m_a = A(ref byte_, 2147483647u, 4u);
						}
						else if (A(global::A.a.m_A.A.A, 1020604L))
						{
							byte[] byte_2 = (global::A.a.m_A = new byte[5] { 82, 181, 89, 36, 82 });
							global::A.a.m_a = A(ref byte_2, 2147483647u, 4u);
						}
						else if (A(global::A.a.m_A.A.A, 107L))
						{
							byte[] byte_3 = (global::A.a.m_A = new byte[5] { 220, 169, 151, 105, 220 });
							global::A.a.m_a = A(ref byte_3, 2147483647u, 4u);
						}
						else
						{
							byte[] byte_4 = (global::A.a.m_A = new byte[5] { 184, 84, 141, 34, 184 });
							global::A.a.m_a = A(ref byte_4, 2147483647u, 4u);
						}
					}
					if (global::A.a.m_a != IntPtr.Zero)
					{
						byte[] byte_5 = new byte[5];
						if (ReadProcessMemory(global::A.a.m_A.A, global::A.a.m_a, byte_5, 5, out var int_))
						{
							if (!A(ref global::A.a.m_A, ref byte_5, 5))
							{
								global::A.a.m_a = IntPtr.Zero;
								global::A.a.m_b = IntPtr.Zero;
								global::A.a.m_B.set_Enabled(true);
							}
							byte[] array = new byte[4];
							if (!ReadProcessMemory(global::A.a.m_A.A, (IntPtr)(global::A.a.m_a.ToInt32() + 28), array, 4, out int_))
							{
								return;
							}
							IntPtr intPtr = (IntPtr)BitConverter.ToUInt32(array, 0);
							if (global::A.a.m_b == IntPtr.Zero)
							{
								global::A.a.m_b = intPtr;
							}
							if (!(global::A.a.m_b != intPtr))
							{
								return;
							}
							byte[] array2 = new byte[1];
							if (ReadProcessMemory(global::A.a.m_A.A, global::A.a.m_b, array2, 1, out int_) && array2[0] != 0)
							{
								byte[] byte_6 = new byte[array2[0]];
								if (ReadProcessMemory(global::A.a.m_A.A, global::A.a.m_b, byte_6, array2[0], out int_))
								{
									global::A.a.A(ref byte_6);
									global::A.a.m_b = intPtr;
								}
							}
						}
						else
						{
							global::A.a.m_a = IntPtr.Zero;
						}
					}
					else
					{
						Thread.Sleep(500);
					}
				}
				else
				{
					global::A.a.m_a = IntPtr.Zero;
					global::A.a.m_b = IntPtr.Zero;
				}
			}
			else
			{
				global::A.a.m_a = IntPtr.Zero;
				global::A.a.m_b = IntPtr.Zero;
			}
		}

		private static void a(object sender, EventArgs e)
		{
			if (global::A.a.A() == global::A.a.c.a)
			{
				if (global::A.a.A())
				{
					global::A.a.m_b = true;
					if (global::A.a.m_A == IntPtr.Zero && (global::A.a.m_A.A.A != 0L || global::A.a.m_A.A.A != IntPtr.Zero))
					{
						if (A(global::A.a.m_A.A.A, 122L))
						{
							byte[] byte_ = (global::A.a.m_B = new byte[5] { 107, 155, 3, 54, 107 });
							global::A.a.m_A = A(ref byte_, 2147483647u, 4u);
						}
						else if (A(global::A.a.m_A.A.A, 121L))
						{
							byte[] byte_2 = (global::A.a.m_B = new byte[5] { 207, 23, 236, 6, 207 });
							global::A.a.m_A = A(ref byte_2, 2147483647u, 4u);
						}
						else if (A(global::A.a.m_A.A.A, 107L))
						{
							byte[] byte_3 = (global::A.a.m_B = new byte[5] { 187, 71, 250, 15, 187 });
							global::A.a.m_A = A(ref byte_3, 2147483647u, 4u);
						}
						else
						{
							byte[] byte_4 = (global::A.a.m_B = new byte[5] { 114, 188, 148, 56, 114 });
							global::A.a.m_A = A(ref byte_4, 2147483647u, 164u);
						}
					}
					if (!(global::A.a.m_A != IntPtr.Zero))
					{
						return;
					}
					byte[] byte_5 = new byte[5];
					if (ReadProcessMemory(global::A.a.m_A.A, global::A.a.m_A, byte_5, 5, out var int_))
					{
						if (!A(ref global::A.a.m_B, ref byte_5, 5))
						{
							global::A.a.m_A = IntPtr.Zero;
						}
						byte[] byte_6 = new byte[8];
						if (ReadProcessMemory(global::A.a.m_A.A, (IntPtr)(global::A.a.m_A.ToInt32() + 132), byte_6, 8, out int_))
						{
							if (byte_6[0] == 47)
							{
								string text = Encoding.ASCII.GetString(byte_6, 1, 6).ToLower();
								if (text.StartsWith("dri") || text.StartsWith("drp") || text.StartsWith("drlc") || text.StartsWith("drlp") || text.StartsWith("drc"))
								{
									global::A.a.m_a = true;
								}
							}
							else if (byte_6[0] == 33)
							{
								string text2 = Encoding.ASCII.GetString(byte_6, 1, 6).ToLower();
								if (text2.StartsWith("dr "))
								{
									global::A.a.m_a = true;
								}
							}
							else if (byte_6[0] == 0)
							{
								if (global::A.a.m_a)
								{
									string text3 = Encoding.ASCII.GetString(byte_6, 1, 6).ToLower();
									if (text3.StartsWith("dri"))
									{
										D();
										global::A.a.m_A = global::A.a.a.C;
									}
									else if (text3.StartsWith("drc"))
									{
										D();
										StringBuilder stringBuilder = new StringBuilder(512);
										b[] array = global::A.a.A();
										if (array == null)
										{
											return;
										}
										for (int i = 0; i < 11; i++)
										{
											if (!array[i].a.StartsWith("0") && !array[i].a.StartsWith("127"))
											{
												stringBuilder.Append(array[i].A);
												stringBuilder.Append(' ');
												stringBuilder.Append(A(ref array[i].a));
												stringBuilder.Append(' ');
											}
										}
										if (stringBuilder.ToString().Length != 0)
										{
											global::A.a.m_b = stringBuilder.ToString();
											A(global::A.a.m_b);
											global::A.a.m_A = global::A.a.a.B;
										}
										else
										{
											global::A.a.m_b = global::A.a.m_A.j();
											A(global::A.a.m_A.j());
											global::A.a.m_A = global::A.a.a.B;
										}
										SystemSounds.get_Asterisk().Play();
									}
									else if (text3.StartsWith("drp"))
									{
										D();
										b[] array2 = global::A.a.A();
										StringBuilder stringBuilder2 = new StringBuilder(276);
										if (array2 == null)
										{
											return;
										}
										Ping ping = new Ping();
										byte[] bytes = Encoding.ASCII.GetBytes("Warcraft III Delay Reducer".PadRight(32, '.'));
										for (int j = 0; j < 11; j++)
										{
											if (!array2[j].a.StartsWith("0") && !array2[j].a.StartsWith("127"))
											{
												stringBuilder2.Append(array2[j].A);
												stringBuilder2.Append(": ");
												PingReply pingReply = ping.Send(array2[j].a, 1000, bytes, new PingOptions(15, dontFragment: true));
												if (pingReply.Status == IPStatus.Success)
												{
													stringBuilder2.Append(pingReply.RoundtripTime);
													stringBuilder2.Append("ms ");
												}
												else
												{
													stringBuilder2.Append("t/o ");
												}
											}
										}
										if (stringBuilder2.ToString().Length != 0)
										{
											global::A.a.m_B = stringBuilder2.ToString();
											A(global::A.a.m_B);
											global::A.a.m_A = global::A.a.a.a;
										}
										else
										{
											global::A.a.m_B = global::A.a.m_A.K();
											A(global::A.a.m_B);
											global::A.a.m_A = global::A.a.a.a;
										}
										SystemSounds.get_Asterisk().Play();
									}
									else if (text3.StartsWith("drlp"))
									{
										D();
										if (global::A.a.m_B != string.Empty)
										{
											A(global::A.a.m_B);
										}
										else
										{
											A(global::A.a.m_A.k());
										}
									}
									else if (text3.StartsWith("drlc"))
									{
										D();
										if (global::A.a.m_b != string.Empty)
										{
											A(global::A.a.m_b);
										}
										else
										{
											A(global::A.a.m_A.L());
										}
									}
									else
									{
										if (!text3.StartsWith("dr"))
										{
											global::A.a.m_A = IntPtr.Zero;
											return;
										}
										global::A.a.m_a = false;
										a(ref byte_6);
									}
								}
								else if (global::A.a.m_A != 0)
								{
									byte[] array3 = null;
									switch (global::A.a.m_A)
									{
									case global::A.a.a.a:
										array3 = Encoding.UTF8.GetBytes(global::A.a.m_B);
										break;
									case global::A.a.a.B:
										array3 = Encoding.UTF8.GetBytes(global::A.a.m_b);
										break;
									case global::A.a.a.b:
										array3 = Encoding.UTF8.GetBytes("W3DR: " + BitConverter.ToInt32(global::A.a.B(), 0) + "ms");
										break;
									case global::A.a.a.C:
										array3 = Encoding.UTF8.GetBytes("Warcraft III Delay Reducer v" + Application.get_ProductVersion() + " by VT Software: http://vt-s.tk");
										break;
									}
									WriteProcessMemory(global::A.a.m_A.A, (IntPtr)(global::A.a.m_A.ToInt32() + 132), array3, array3.Length + 1, out int_);
									PostMessage(global::A.a.m_A.A.MainWindowHandle, 256u, 16u, 0u);
									PostMessage(global::A.a.m_A.A.MainWindowHandle, 256u, 13u, 0u);
									PostMessage(global::A.a.m_A.A.MainWindowHandle, 257u, 13u, 0u);
									PostMessage(global::A.a.m_A.A.MainWindowHandle, 257u, 16u, 0u);
									PostMessage(global::A.a.m_A.A.MainWindowHandle, 256u, 13u, 0u);
									PostMessage(global::A.a.m_A.A.MainWindowHandle, 257u, 13u, 0u);
									global::A.a.m_A = global::A.a.a.A;
									return;
								}
							}
							else
							{
								global::A.a.m_A = IntPtr.Zero;
							}
						}
						else
						{
							global::A.a.m_A = IntPtr.Zero;
						}
						global::A.a.m_B = global::A.a.A() != null;
						if (global::A.a.m_B)
						{
							global::A.a.m_a.set_Enabled(true);
						}
					}
					else
					{
						global::A.a.m_A = IntPtr.Zero;
					}
				}
				else
				{
					global::A.a.a();
				}
			}
			else
			{
				global::A.a.a();
			}
		}

		private static void a()
		{
			global::A.a.m_B.set_Enabled(false);
			global::A.a.m_a.set_Enabled(false);
			global::A.a.m_A = IntPtr.Zero;
			global::A.a.m_b = false;
			global::A.a.m_B = false;
		}

		private static void B(object sender, EventArgs e)
		{
			if (global::A.a.m_b)
			{
				if (global::A.a.m_B)
				{
					if (global::A.a.m_B == IntPtr.Zero)
					{
						global::A.a.B();
					}
					if (global::A.a.m_B != IntPtr.Zero)
					{
						byte[] byte_ = new byte[32];
						if (ReadProcessMemory(global::A.a.m_A.A, global::A.a.m_B, byte_, 32, out var int_))
						{
							if (!A(ref global::A.a.m_a, ref byte_, 5))
							{
								global::A.a.m_B.set_Enabled(false);
								global::A.a.C();
								return;
							}
							global::A.a.m_C = (IntPtr)BitConverter.ToUInt32(byte_, 24);
							global::A.a.m_c = (IntPtr)BitConverter.ToUInt32(byte_, 28);
							int num = global::A.a.m_c.ToInt32() - global::A.a.m_C.ToInt32();
							byte[] array = new byte[num];
							if (!ReadProcessMemory(global::A.a.m_A.A, global::A.a.m_C, array, num, out int_))
							{
								global::A.a.C();
								return;
							}
							if (global::A.a.m_b == null)
							{
								global::A.a.m_b = array;
								return;
							}
							int num2 = 0;
							while (num2 < num)
							{
								int num3 = array[num2];
								if (num3 == 168)
								{
									int i = 0;
									int num4 = num3 - 8;
									if (num4 > 0)
									{
										StringBuilder stringBuilder = new StringBuilder(num4);
										for (; array[i + num2 + 8] != 0 && i < num4; i++)
										{
											stringBuilder.Append((char)array[i + num2 + 8]);
										}
										string text = stringBuilder.ToString();
										if (!text.Contains(":|R |"))
										{
											int num5 = text.IndexOf(": |r!dr", 0, StringComparison.CurrentCultureIgnoreCase);
											if (num5 != -1 && array[num2 + 8 + num5 + 8] == 0)
											{
												for (int j = 0; j < num3; j++)
												{
													if (array[num2 + j] != global::A.a.m_b[num2 + j])
													{
														global::A.a.m_A = global::A.a.a.b;
														break;
													}
												}
											}
										}
									}
								}
								num2 += num3;
								Thread.Sleep(100);
							}
							global::A.a.m_b = array;
						}
						else
						{
							global::A.a.C();
						}
					}
					else
					{
						Thread.Sleep(500);
					}
				}
				else
				{
					global::A.a.C();
				}
			}
			else
			{
				global::A.a.C();
			}
		}

		private static void B()
		{
			if (global::A.a.m_A.A.A != 0L || global::A.a.m_A.A.A != IntPtr.Zero)
			{
				if (A(global::A.a.m_A.A.A, 122L))
				{
					byte[] byte_ = (global::A.a.m_a = new byte[5] { 177, 83, 117, 21, 177 });
					global::A.a.m_B = A(ref byte_, 2147483647u, 4u);
				}
				else if (A(global::A.a.m_A.A.A, 1020604L))
				{
					byte[] byte_2 = (global::A.a.m_a = new byte[5] { 82, 181, 89, 36, 82 });
					global::A.a.m_B = A(ref byte_2, 2147483647u, 4u);
				}
				else if (A(global::A.a.m_A.A.A, 107L))
				{
					byte[] byte_3 = (global::A.a.m_a = new byte[5] { 220, 169, 151, 105, 220 });
					global::A.a.m_B = A(ref byte_3, 2147483647u, 4u);
				}
				else
				{
					byte[] byte_4 = (global::A.a.m_a = new byte[5] { 184, 84, 141, 34, 184 });
					global::A.a.m_B = A(ref byte_4, 2147483647u, 4u);
				}
			}
		}

		private static void b()
		{
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00aa: Expected O, but got Unknown
			try
			{
				WebRequest webRequest = WebRequest.Create("http://vt-s.110mb.com/version.php?p=w3dr");
				WebResponse response = webRequest.GetResponse();
				Stream responseStream = response.GetResponseStream();
				Encoding encoding = Encoding.GetEncoding("utf-8");
				StreamReader streamReader = new StreamReader(responseStream, encoding);
				string text = streamReader.ReadToEnd();
				streamReader.Close();
				response.Close();
				if (int.TryParse(Application.get_ProductVersion().Replace(".", null), out var result) && int.TryParse(text, out var result2))
				{
					W3DR.Properties.a.Default.lastCheck = DateTime.Now.Ticks;
					((SettingsBase)W3DR.Properties.a.Default).Save();
					if (result2 > result)
					{
						ToolStripMenuItem val = new ToolStripMenuItem(global::A.a.m_A.J());
						((ToolStripItem)val).add_Click((EventHandler)b);
						((ToolStrip)global::A.a.m_A).get_Items().Add((ToolStripItem)(object)val);
						A(global::A.a.m_A.e() + " " + text + " " + global::A.a.m_A.f(), bool_0: false);
					}
				}
			}
			catch (Exception)
			{
			}
		}

		private static void C()
		{
			global::A.a.m_B = IntPtr.Zero;
			global::A.a.m_C = IntPtr.Zero;
			global::A.a.m_c = IntPtr.Zero;
			global::A.a.m_b = null;
		}

		private static void c()
		{
			//IL_002c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0032: Expected O, but got Unknown
			//IL_0075: Unknown result type (might be due to invalid IL or missing references)
			//IL_007b: Expected O, but got Unknown
			if (!Directory.Exists(".\\language"))
			{
				return;
			}
			string[] files = Directory.GetFiles(".\\language\\");
			if (files.Length == 0)
			{
				return;
			}
			ToolStripMenuItem val = new ToolStripMenuItem(global::A.a.m_A.i());
			((ToolStrip)global::A.a.m_A).get_Items().Add((ToolStripItem)(object)val);
			for (int i = 0; i < files.Length; i++)
			{
				if (files[i].EndsWith(".lang"))
				{
					ToolStripMenuItem val2 = new ToolStripMenuItem(files[i].Substring(files[i].LastIndexOf('\\') + 1).Replace(".lang", null));
					((ToolStripItem)val2).add_Click((EventHandler)D);
					((ToolStripDropDownItem)val).get_DropDownItems().Add((ToolStripItem)(object)val2);
				}
			}
		}

		private static void A(ref byte[] byte_0)
		{
			int num = byte_0[0] - byte_0[2] - 8;
			if (num <= 0)
			{
				return;
			}
			StringBuilder stringBuilder = new StringBuilder(num);
			try
			{
				for (int i = 8; byte_0[i] != 0; i++)
				{
					stringBuilder.Append((char)byte_0[i]);
				}
			}
			catch (Exception)
			{
				return;
			}
			string text = stringBuilder.ToString();
			if (text.StartsWith("|CFFFED312"))
			{
				int num2 = text.IndexOf(":|R !dr");
				if (num2 != -1 && byte_0[num2 + 15] == 0)
				{
					global::A.a.m_A = global::A.a.a.b;
				}
			}
			else if (text.StartsWith("|Cffff0000G"))
			{
				global::A.a.m_a.set_Enabled(false);
				global::A.a.m_a = IntPtr.Zero;
				global::A.a.m_b = IntPtr.Zero;
			}
		}

		private static void a(ref byte[] byte_0)
		{
			if (byte_0[3] != 0)
			{
				StringBuilder stringBuilder = new StringBuilder(4);
				for (int i = 4; i < byte_0.Length && byte_0[i] != 0; i++)
				{
					stringBuilder.Append((char)byte_0[i]);
				}
				if (uint.TryParse(stringBuilder.ToString(), out var result) && result <= 550)
				{
					SystemSounds.get_Beep().Play();
					A(result);
				}
				else
				{
					A(global::A.a.m_A.a(), bool_0: true);
				}
			}
		}

		private static void A(string string_0)
		{
			Clipboard.SetText(Encoding.Default.GetString(Encoding.UTF8.GetBytes(string_0)));
		}

		private static void D()
		{
			SystemSounds.get_Beep().Play();
			global::A.a.m_a = false;
		}

		private static string A(ref string string_0)
		{
			try
			{
				HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create("http://www.wc3banlist.de/iptc.php?addr=" + string_0);
				httpWebRequest.UserAgent = "Mozilla/3.0 (compatible; Indy Library)";
				WebResponse response = httpWebRequest.GetResponse();
				StreamReader streamReader = new StreamReader(response.GetResponseStream());
				return streamReader.ReadToEnd();
			}
			catch (Exception)
			{
				return "Err";
			}
		}

		private static int A(ref byte[] byte_0)
		{
			int num = 0;
			while (true)
			{
				if (num < byte_0.Length)
				{
					if (byte_0[num] == 46 && byte_0[num + 1] == 99 && byte_0[num + 2] == 112 && byte_0[num + 3] == 112)
					{
						break;
					}
					num++;
					continue;
				}
				return -1;
			}
			return num + 4;
		}

		private static bool A(int int_0, int int_1, ref b b_0, ref byte[] byte_0)
		{
			StringBuilder stringBuilder = new StringBuilder(15);
			int num = int_1 + 232 * int_0;
			b_0 = default(b);
			b_0.a = "0.0.0.0";
			b_0.A = string.Empty;
			for (int i = 1; byte_0[i + num] != 0; i++)
			{
				stringBuilder.Append((char)byte_0[i + num]);
			}
			if (stringBuilder.ToString().Length == 0)
			{
				return false;
			}
			b_0.A = stringBuilder.ToString();
			num -= 32;
			StringBuilder stringBuilder2 = new StringBuilder(15);
			stringBuilder2.Append(byte_0[num]);
			stringBuilder2.Append('.');
			stringBuilder2.Append(byte_0[num + 1]);
			stringBuilder2.Append('.');
			stringBuilder2.Append(byte_0[num + 2]);
			stringBuilder2.Append('.');
			stringBuilder2.Append(byte_0[num + 3]);
			b_0.a = stringBuilder2.ToString();
			return true;
		}

		private static IntPtr A(ref byte[] byte_0, uint uint_0, uint uint_1)
		{
			byte[] byte_ = new byte[byte_0.Length];
			uint num = 65536u;
			int int_ = byte_0.Length;
			IntPtr intPtr;
			while (true)
			{
				if (num <= uint_0)
				{
					intPtr = (IntPtr)(num + uint_1);
					if (ReadProcessMemory(global::A.a.m_A.A, intPtr, byte_, int_, out var int_2) && A(ref byte_0, ref byte_, int_2))
					{
						break;
					}
					num += 65536;
					continue;
				}
				return IntPtr.Zero;
			}
			return intPtr;
		}

		private static bool A(ref byte[] byte_0, ref byte[] byte_1, int int_0)
		{
			int num = 0;
			while (true)
			{
				if (num < int_0)
				{
					if (byte_0[num] != byte_1[num])
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

		private static void d()
		{
			//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d0: Expected O, but got Unknown
			//IL_0114: Unknown result type (might be due to invalid IL or missing references)
			//IL_011e: Expected O, but got Unknown
			c c = global::A.a.A();
			if (c == c.a)
			{
				if (!global::A.a.m_A)
				{
					if (!global::A.a.A())
					{
						((ToolStripItem)global::A.a.m_A).set_Text(BitConverter.ToUInt32(global::A.a.a(), 0).ToString());
					}
					else
					{
						((ToolStripItem)global::A.a.m_A).set_Text(BitConverter.ToUInt32(global::A.a.B(), 0).ToString());
					}
				}
				else
				{
					if (!global::A.a.A())
					{
						A(global::A.a.m_A);
						((ToolStripItem)global::A.a.m_A).set_Text(BitConverter.ToUInt32(global::A.a.a(), 0).ToString());
					}
					else
					{
						((ToolStripItem)global::A.a.m_A).set_Text(BitConverter.ToUInt32(global::A.a.B(), 0).ToString());
					}
					global::A.a.m_A = false;
				}
				((ToolStripItem)global::A.a.m_A).set_Font(new Font(((ToolStripItem)global::A.a.m_A).get_Font().get_Name(), 9f));
				((ToolStripItem)global::A.a.m_A).set_Enabled(true);
			}
			else
			{
				((ToolStripItem)global::A.a.m_A).set_Enabled(false);
				((ToolStripItem)global::A.a.m_A).set_Text(global::A.a.m_A.F());
				((ToolStripItem)global::A.a.m_A).set_Font(new Font(((ToolStripItem)global::A.a.m_A).get_Font().get_Name(), 7.5f));
			}
		}

		private static bool A(ref B b_0)
		{
			try
			{
				ProcessModuleCollection modules = global::A.a.m_A.A.Modules;
				for (int i = 0; i < modules.Count; i++)
				{
					if (modules[i].ModuleName!.ToLower() == "game.dll")
					{
						global::A.a.m_A.A.A = modules[i].BaseAddress;
						global::A.a.m_A.A.A = int.Parse(modules[i].FileVersionInfo.FileVersion!.Replace(" ", null).Replace(",", null));
						return true;
					}
				}
			}
			catch (Exception)
			{
				global::A.a.m_A.A.A = 0L;
				global::A.a.m_A.A.A = IntPtr.Zero;
				return false;
			}
			return false;
		}

		private static b[] A()
		{
			byte[] byte_ = new byte[3000];
			IntPtr intPtr = global::A.a.C();
			if (intPtr == IntPtr.Zero)
			{
				return null;
			}
			ReadProcessMemory(global::A.a.m_A.A, intPtr, byte_, 3000, out var _);
			int num = global::A.a.A(ref byte_);
			if (num != -1)
			{
				num += 193;
				b[] array = new b[11];
				for (int i = 0; i < 11; i++)
				{
					A(i, num, ref array[i], ref byte_);
				}
				return array;
			}
			A(global::A.a.m_A.d(), bool_0: true);
			return null;
		}

		private static IntPtr A()
		{
			if (global::A.a.m_A.A.A != 0L || global::A.a.m_A.A.A != IntPtr.Zero)
			{
				if (A(global::A.a.m_A.A.A, 122L))
				{
					return (IntPtr)(global::A.a.m_A.A.A.ToInt32() + 11154132);
				}
				if (A(global::A.a.m_A.A.A, 1211L))
				{
					return (IntPtr)(global::A.a.m_A.A.A.ToInt32() + 8906284);
				}
				if (A(global::A.a.m_A.A.A, 1210L))
				{
					return (IntPtr)(global::A.a.m_A.A.A.ToInt32() + 8785873);
				}
				if (A(global::A.a.m_A.A.A, 1204L))
				{
					return (IntPtr)(global::A.a.m_A.A.A.ToInt32() + 8781721);
				}
				if (A(global::A.a.m_A.A.A, 1203L))
				{
					return (IntPtr)(global::A.a.m_A.A.A.ToInt32() + 8781721);
				}
				if (A(global::A.a.m_A.A.A, 1202606L))
				{
					return (IntPtr)(global::A.a.m_A.A.A.ToInt32() + 8781721);
				}
				if (A(global::A.a.m_A.A.A, 1020605L))
				{
					return (IntPtr)(global::A.a.m_A.A.A.ToInt32() + 8781689);
				}
				if (A(global::A.a.m_A.A.A, 1020604L))
				{
					return (IntPtr)(global::A.a.m_A.A.A.ToInt32() + 8781689);
				}
				if (A(global::A.a.m_A.A.A, 1019L))
				{
					return (IntPtr)(global::A.a.m_A.A.A.ToInt32() + 8777529);
				}
				if (A(global::A.a.m_A.A.A, 1018L))
				{
					return (IntPtr)(global::A.a.m_A.A.A.ToInt32() + 8777529);
				}
				if (A(global::A.a.m_A.A.A, 1017L))
				{
					return (IntPtr)(global::A.a.m_A.A.A.ToInt32() + 8747617);
				}
				if (A(global::A.a.m_A.A.A, 1016L))
				{
					return (IntPtr)(global::A.a.m_A.A.A.ToInt32() + 8476673);
				}
				if (A(global::A.a.m_A.A.A, 1015L))
				{
					return (IntPtr)(global::A.a.m_A.A.A.ToInt32() + 8476673);
				}
				if (A(global::A.a.m_A.A.A, 10145846L))
				{
					return (IntPtr)(global::A.a.m_A.A.A.ToInt32() + 8333937);
				}
				if (A(global::A.a.m_A.A.A, 10145840L))
				{
					return (IntPtr)(global::A.a.m_A.A.A.ToInt32() + 8333825);
				}
				if (A(global::A.a.m_A.A.A, 10135816L))
				{
					return (IntPtr)(global::A.a.m_A.A.A.ToInt32() + 8329729);
				}
				if (A(global::A.a.m_A.A.A, 10135813L))
				{
					return (IntPtr)(global::A.a.m_A.A.A.ToInt32() + 8329729);
				}
				if (A(global::A.a.m_A.A.A, 1012L))
				{
					return (IntPtr)(global::A.a.m_A.A.A.ToInt32() + 8193993);
				}
				if (A(global::A.a.m_A.A.A, 1011L))
				{
					return (IntPtr)(global::A.a.m_A.A.A.ToInt32() + 8193993);
				}
				if (A(global::A.a.m_A.A.A, 107L))
				{
					return (IntPtr)(global::A.a.m_A.A.A.ToInt32() + 8162033);
				}
				A(global::A.a.m_A.E() + " Game.dll (-1)", bool_0: true);
			}
			return IntPtr.Zero;
		}

		private static IntPtr a()
		{
			if (global::A.a.m_A.A.A != 0L || global::A.a.m_A.A.A != IntPtr.Zero)
			{
				if (A(global::A.a.m_A.A.A, 122L))
				{
					return (IntPtr)(global::A.a.m_A.A.A.ToInt32() + 6609809);
				}
				if (A(global::A.a.m_A.A.A, 1211L))
				{
					return (IntPtr)(global::A.a.m_A.A.A.ToInt32() + 7230065);
				}
				if (A(global::A.a.m_A.A.A, 1210L))
				{
					return (IntPtr)(global::A.a.m_A.A.A.ToInt32() + 7230033);
				}
				if (A(global::A.a.m_A.A.A, 1204L))
				{
					return (IntPtr)(global::A.a.m_A.A.A.ToInt32() + 7213537);
				}
				if (A(global::A.a.m_A.A.A, 1203L))
				{
					return (IntPtr)(global::A.a.m_A.A.A.ToInt32() + 7213521);
				}
				if (A(global::A.a.m_A.A.A, 1202606L))
				{
					return (IntPtr)(global::A.a.m_A.A.A.ToInt32() + 7213585);
				}
				if (A(global::A.a.m_A.A.A, 1020604L))
				{
					return (IntPtr)(global::A.a.m_A.A.A.ToInt32() + 7211169);
				}
				if (A(global::A.a.m_A.A.A, 1020605L))
				{
					return (IntPtr)(global::A.a.m_A.A.A.ToInt32() + 7211441);
				}
				if (A(global::A.a.m_A.A.A, 1019L))
				{
					return (IntPtr)(global::A.a.m_A.A.A.ToInt32() + 7211169);
				}
				if (A(global::A.a.m_A.A.A, 1018L))
				{
					return (IntPtr)(global::A.a.m_A.A.A.ToInt32() + 7209889);
				}
				if (A(global::A.a.m_A.A.A, 1017L))
				{
					return (IntPtr)(global::A.a.m_A.A.A.ToInt32() + 7205265);
				}
				if (A(global::A.a.m_A.A.A, 1016L))
				{
					return (IntPtr)(global::A.a.m_A.A.A.ToInt32() + 7020849);
				}
				if (A(global::A.a.m_A.A.A, 1015L))
				{
					return (IntPtr)(global::A.a.m_A.A.A.ToInt32() + 7020849);
				}
				if (A(global::A.a.m_A.A.A, 10145846L))
				{
					return (IntPtr)(global::A.a.m_A.A.A.ToInt32() + 6905345);
				}
				if (A(global::A.a.m_A.A.A, 10145840L))
				{
					return (IntPtr)(global::A.a.m_A.A.A.ToInt32() + 6903569);
				}
				if (A(global::A.a.m_A.A.A, 10135816L))
				{
					return (IntPtr)(global::A.a.m_A.A.A.ToInt32() + 6903041);
				}
				if (A(global::A.a.m_A.A.A, 10135813L))
				{
					return (IntPtr)(global::A.a.m_A.A.A.ToInt32() + 6903041);
				}
				if (A(global::A.a.m_A.A.A, 1012L))
				{
					return (IntPtr)(global::A.a.m_A.A.A.ToInt32() + 6780337);
				}
				if (A(global::A.a.m_A.A.A, 1011L))
				{
					return (IntPtr)(global::A.a.m_A.A.A.ToInt32() + 6780353);
				}
				if (A(global::A.a.m_A.A.A, 107L))
				{
					return (IntPtr)(global::A.a.m_A.A.A.ToInt32() + 6756609);
				}
				A(global::A.a.m_A.E() + " Game.dll (-2)", bool_0: true);
			}
			return IntPtr.Zero;
		}

		private static IntPtr B()
		{
			if (global::A.a.m_A.A.A != 0L || global::A.a.m_A.A.A != IntPtr.Zero)
			{
				if (A(global::A.a.m_A.A.A, 122L))
				{
					return (IntPtr)(global::A.a.m_A.A.A.ToInt32() + 6625249);
				}
				if (A(global::A.a.m_A.A.A, 1211L))
				{
					return (IntPtr)(global::A.a.m_A.A.A.ToInt32() + 7242321);
				}
				if (A(global::A.a.m_A.A.A, 1210L))
				{
					return (IntPtr)(global::A.a.m_A.A.A.ToInt32() + 7242289);
				}
				if (A(global::A.a.m_A.A.A, 1204L))
				{
					return (IntPtr)(global::A.a.m_A.A.A.ToInt32() + 7225825);
				}
				if (A(global::A.a.m_A.A.A, 1203L))
				{
					return (IntPtr)(global::A.a.m_A.A.A.ToInt32() + 7225809);
				}
				if (A(global::A.a.m_A.A.A, 1202606L))
				{
					return (IntPtr)(global::A.a.m_A.A.A.ToInt32() + 7225873);
				}
				if (A(global::A.a.m_A.A.A, 1020605L))
				{
					return (IntPtr)(global::A.a.m_A.A.A.ToInt32() + 7223729);
				}
				if (A(global::A.a.m_A.A.A, 1020604L))
				{
					return (IntPtr)(global::A.a.m_A.A.A.ToInt32() + 7223457);
				}
				if (A(global::A.a.m_A.A.A, 1019L))
				{
					return (IntPtr)(global::A.a.m_A.A.A.ToInt32() + 7223457);
				}
				if (A(global::A.a.m_A.A.A, 1018L))
				{
					return (IntPtr)(global::A.a.m_A.A.A.ToInt32() + 7222177);
				}
				if (A(global::A.a.m_A.A.A, 1017L))
				{
					return (IntPtr)(global::A.a.m_A.A.A.ToInt32() + 7217457);
				}
				if (A(global::A.a.m_A.A.A, 1016L))
				{
					return (IntPtr)(global::A.a.m_A.A.A.ToInt32() + 7033041);
				}
				if (A(global::A.a.m_A.A.A, 1015L))
				{
					return (IntPtr)(global::A.a.m_A.A.A.ToInt32() + 7033041);
				}
				if (A(global::A.a.m_A.A.A, 10145846L))
				{
					return (IntPtr)(global::A.a.m_A.A.A.ToInt32() + 6917537);
				}
				if (A(global::A.a.m_A.A.A, 10145840L))
				{
					return (IntPtr)(global::A.a.m_A.A.A.ToInt32() + 6915761);
				}
				if (A(global::A.a.m_A.A.A, 10135816L))
				{
					return (IntPtr)(global::A.a.m_A.A.A.ToInt32() + 6915233);
				}
				if (A(global::A.a.m_A.A.A, 10135813L))
				{
					return (IntPtr)(global::A.a.m_A.A.A.ToInt32() + 6915233);
				}
				if (A(global::A.a.m_A.A.A, 1012L))
				{
					return (IntPtr)(global::A.a.m_A.A.A.ToInt32() + 6792641);
				}
				if (A(global::A.a.m_A.A.A, 1011L))
				{
					return (IntPtr)(global::A.a.m_A.A.A.ToInt32() + 6792657);
				}
				if (A(global::A.a.m_A.A.A, 107L))
				{
					return (IntPtr)(global::A.a.m_A.A.A.ToInt32() + 6768913);
				}
				A(global::A.a.m_A.E() + " Game.dll (-3)", bool_0: true);
			}
			return IntPtr.Zero;
		}

		private static IntPtr b()
		{
			if (global::A.a.m_A.A.A == 0L && !(global::A.a.m_A.A.A != IntPtr.Zero))
			{
				return IntPtr.Zero;
			}
			byte[] array = null;
			ushort num = 0;
			if (A(global::A.a.m_A.A.A, 122L))
			{
				array = new byte[5] { 113, 6, 138, 15, 113 };
				num = 745;
			}
			else if (A(global::A.a.m_A.A.A, 107L))
			{
				array = new byte[5] { 208, 161, 137, 124, 208 };
				num = 793;
			}
			else
			{
				array = new byte[5] { 129, 132, 211, 100, 129 };
				num = 793;
			}
			IntPtr intPtr = A(ref array, 2147483647u, 4u);
			if (intPtr != IntPtr.Zero)
			{
				return (IntPtr)(intPtr.ToInt32() + num);
			}
			return IntPtr.Zero;
		}

		private static IntPtr C()
		{
			if (global::A.a.m_A.A.A == 0L && !(global::A.a.m_A.A.A != IntPtr.Zero))
			{
				return IntPtr.Zero;
			}
			byte[] byte_ = null;
			if (A(global::A.a.m_A.A.A, 122L))
			{
				byte_ = new byte[5] { 11, 163, 205, 17, 11 };
			}
			else if (A(global::A.a.m_A.A.A, 121L))
			{
				byte_ = new byte[5] { 11, 252, 121, 75, 11 };
			}
			else if (!A(global::A.a.m_A.A.A, 1204L) && !A(global::A.a.m_A.A.A, 1203L) && !A(global::A.a.m_A.A.A, 1202606L))
			{
				if (A(global::A.a.m_A.A.A, 1020605L))
				{
					byte_ = new byte[5] { 207, 144, 247, 104, 207 };
				}
				else if (A(global::A.a.m_A.A.A, 10196046L))
				{
					byte_ = new byte[5] { 210, 183, 207, 42, 210 };
				}
				else if (!A(global::A.a.m_A.A.A, 1020604L) && !A(global::A.a.m_A.A.A, 1019L))
				{
					if (A(global::A.a.m_A.A.A, 1018L))
					{
						byte_ = new byte[5] { 33, 129, 13, 103, 33 };
					}
					else if (A(global::A.a.m_A.A.A, 1017L))
					{
						byte_ = new byte[5] { 107, 98, 153, 59, 107 };
					}
					else if (!A(global::A.a.m_A.A.A, 1016L) && !A(global::A.a.m_A.A.A, 1015L))
					{
						if (!A(global::A.a.m_A.A.A, 1014L) && !A(global::A.a.m_A.A.A, 1013L))
						{
							if (!A(global::A.a.m_A.A.A, 1012L) && !A(global::A.a.m_A.A.A, 1011L))
							{
								if (A(global::A.a.m_A.A.A, 107L))
								{
									byte_ = new byte[5] { 73, 179, 213, 41, 73 };
								}
								else
								{
									A(global::A.a.m_A.E() + " Game.dll (-4)", bool_0: true);
								}
							}
							else
							{
								byte_ = new byte[5] { 180, 31, 178, 48, 180 };
							}
						}
						else
						{
							byte_ = new byte[5] { 252, 139, 38, 42, 252 };
						}
					}
					else
					{
						byte_ = new byte[5] { 254, 212, 158, 60, 254 };
					}
				}
				else
				{
					byte_ = new byte[5] { 66, 32, 58, 1, 66 };
				}
			}
			else
			{
				byte_ = new byte[5] { 133, 29, 117, 78, 133 };
			}
			return A(ref byte_, 2147483647u, 4u);
		}

		private static byte[] A()
		{
			byte[] array = new byte[4];
			IntPtr intPtr = global::A.a.B();
			if (intPtr == IntPtr.Zero)
			{
				A(global::A.a.m_A.b() + " (LAN, -3)", bool_0: true);
				return BitConverter.GetBytes(553);
			}
			if (!ReadProcessMemory(global::A.a.m_A.A, intPtr, array, 4, out var _))
			{
				A(global::A.a.m_A.b() + " (LAN, " + Marshal.GetLastWin32Error() + ")", bool_0: true);
			}
			return array;
		}

		private static byte[] a()
		{
			byte[] array = new byte[4];
			IntPtr intPtr = global::A.a.a();
			if (intPtr == IntPtr.Zero)
			{
				A(global::A.a.m_A.b() + " (NET, -3)", bool_0: true);
				return BitConverter.GetBytes(563);
			}
			if (!ReadProcessMemory(global::A.a.m_A.A, intPtr, array, 4, out var _))
			{
				A(global::A.a.m_A.b() + " (NET, " + Marshal.GetLastWin32Error() + ")", bool_0: true);
			}
			return array;
		}

		private static byte[] B()
		{
			IntPtr intPtr = global::A.a.b();
			if (intPtr == IntPtr.Zero)
			{
				A(global::A.a.m_A.B() + " (-2)", bool_0: true);
				return BitConverter.GetBytes(573);
			}
			byte[] array = new byte[4];
			if (!ReadProcessMemory(global::A.a.m_A.A, (IntPtr)(intPtr.ToInt32() + 3), array, 4, out var _))
			{
				A(global::A.a.m_A.B() + " (" + Marshal.GetLastWin32Error() + ")", bool_0: true);
			}
			return array;
		}

		private static bool A()
		{
			byte[] array = new byte[1];
			IntPtr intPtr = global::A.a.A();
			if (intPtr == IntPtr.Zero)
			{
				return false;
			}
			ReadProcessMemory(global::A.a.m_A.A, intPtr, array, 1, out var _);
			return array[0] != 0;
		}

		private static void A(uint uint_0)
		{
			bool bool_ = true;
			byte[] bytes = BitConverter.GetBytes(uint_0);
			StringBuilder stringBuilder_ = new StringBuilder(64);
			int int_;
			if (global::A.a.m_b)
			{
				IntPtr intPtr = global::A.a.b();
				if (intPtr == IntPtr.Zero)
				{
					stringBuilder_.Append("-1");
					bool_ = false;
				}
				else
				{
					List<int> list_ = new List<int>(6);
					if (!WriteProcessMemory(global::A.a.m_A.A, (IntPtr)(intPtr.ToInt32() + 3), bytes, 4, out int_))
					{
						A(ref list_, ref bool_);
					}
					if (!WriteProcessMemory(global::A.a.m_A.A, (IntPtr)(intPtr.ToInt32() + 7), bytes, 4, out int_))
					{
						A(ref list_, ref bool_);
					}
					if (!WriteProcessMemory(global::A.a.m_A.A, (IntPtr)(intPtr.ToInt32() + 547), bytes, 4, out int_))
					{
						A(ref list_, ref bool_);
					}
					if (!WriteProcessMemory(global::A.a.m_A.A, (IntPtr)(intPtr.ToInt32() + 551), bytes, 4, out int_))
					{
						A(ref list_, ref bool_);
					}
					byte[] array = new byte[1];
					ReadProcessMemory(global::A.a.m_A.A, (IntPtr)(intPtr.ToInt32() + 1091), array, 1, out var int_2);
					if (array[0] != 0 && !WriteProcessMemory(global::A.a.m_A.A, (IntPtr)(intPtr.ToInt32() + 1091), bytes, 4, out int_))
					{
						A(ref list_, ref bool_);
					}
					array[0] = 0;
					ReadProcessMemory(global::A.a.m_A.A, (IntPtr)(intPtr.ToInt32() + 1095), array, 1, out int_2);
					if (array[0] != 0 && !WriteProcessMemory(global::A.a.m_A.A, (IntPtr)(intPtr.ToInt32() + 1095), bytes, 4, out int_))
					{
						A(ref list_, ref bool_);
					}
					if (!bool_)
					{
						for (int i = 0; i < list_.Count; i++)
						{
							if (i == 0)
							{
								stringBuilder_.Append(list_[i]);
								continue;
							}
							stringBuilder_.Append(", ");
							stringBuilder_.Append(list_[i]);
						}
					}
				}
			}
			IntPtr intPtr2 = global::A.a.a();
			bool flag = false;
			if (intPtr2 == IntPtr.Zero)
			{
				if (stringBuilder_.Length != 0)
				{
					stringBuilder_.Append(", ");
				}
				stringBuilder_.Append(-3);
			}
			else
			{
				flag = WriteProcessMemory(global::A.a.m_A.A, intPtr2, bytes, 4, out int_);
			}
			if (!flag)
			{
				if (stringBuilder_.Length != 0)
				{
					stringBuilder_.Append(", ");
				}
				stringBuilder_.Append(Marshal.GetLastWin32Error());
			}
			intPtr2 = global::A.a.B();
			bool flag2 = false;
			if (intPtr2 == IntPtr.Zero)
			{
				if (stringBuilder_.Length != 0)
				{
					stringBuilder_.Append(", ");
				}
				stringBuilder_.Append(-3);
			}
			else
			{
				flag2 = WriteProcessMemory(global::A.a.m_A.A, global::A.a.B(), bytes, 4, out int_);
			}
			if (!flag2)
			{
				if (stringBuilder_.Length != 0)
				{
					stringBuilder_.Append(", ");
				}
				stringBuilder_.Append(Marshal.GetLastWin32Error());
			}
			A(bool_, global::A.a.m_b, ref stringBuilder_, flag, flag2);
		}

		private static void A(bool bool_0, bool bool_1, ref StringBuilder stringBuilder_0, bool bool_2, bool bool_3)
		{
			if (bool_1)
			{
				if (bool_2 && bool_3 && bool_0)
				{
					A(global::A.a.m_A.h() + " (LAN/NET)", bool_0: false);
					global::A.a.m_A = global::A.a.a.b;
				}
				else if (!bool_2 && bool_0 && bool_3)
				{
					A(global::A.a.m_A.c() + " (NET, " + stringBuilder_0.ToString() + ")", bool_0: true);
				}
				else if (!bool_2 && bool_0 && !bool_3)
				{
					A(global::A.a.m_A.c() + " (LAN/NET, " + stringBuilder_0.ToString() + ")", bool_0: true);
				}
				else if (bool_2 && !bool_0 && bool_3)
				{
					A(global::A.a.m_A.C() + " (" + stringBuilder_0.ToString() + ")", bool_0: true);
				}
				else if (bool_2 && bool_0 && !bool_3)
				{
					A(global::A.a.m_A.c() + " (LAN, " + stringBuilder_0.ToString() + ")", bool_0: true);
				}
				else if (!bool_2 && !bool_0 && !bool_3)
				{
					A(global::A.a.m_A.D() + " (LAN/NET, " + stringBuilder_0.ToString() + ")", bool_0: true);
				}
			}
			else if (bool_2 && bool_3)
			{
				A(global::A.a.m_A.I() + " (LAN/NET)", bool_0: false);
			}
			else if (bool_2 && !bool_3)
			{
				A(global::A.a.m_A.c() + " (LAN, " + stringBuilder_0.ToString() + ")", bool_0: true);
			}
			else if (!bool_2 && bool_3)
			{
				A(global::A.a.m_A.c() + " (NET, " + stringBuilder_0.ToString() + ")", bool_0: true);
			}
			else
			{
				A(global::A.a.m_A.c() + " (LAN/NET, " + stringBuilder_0.ToString() + ")", bool_0: true);
			}
		}

		private static void A(ref List<int> list_0, ref bool bool_0)
		{
			bool_0 = false;
			int lastWin32Error = Marshal.GetLastWin32Error();
			if (!list_0.Contains(lastWin32Error))
			{
				list_0.Add(lastWin32Error);
			}
		}

		private static void A(string string_0, bool bool_0)
		{
			//IL_0004: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			ToolTipIcon val = ((!bool_0) ? ((ToolTipIcon)0) : ((ToolTipIcon)3));
			global::A.a.m_A.ShowBalloonTip(1000, "Warcraft III Delay Reducer", string_0, val);
		}

		private static void A(object sender, MouseEventArgs e)
		{
			d();
		}

		private static void b(object sender, EventArgs e)
		{
			Process.Start("http://vt-s.tk");
		}

		private static void C(object sender, EventArgs e)
		{
			global::A.a.m_A.set_Visible(false);
			W3DR.Properties.a.Default.delay = global::A.a.m_A;
			((SettingsBase)W3DR.Properties.a.Default).Save();
			Application.Exit();
		}

		private static void c(object sender, EventArgs e)
		{
			Process.Start("http://vt-s.tk");
		}

		private static void D(object sender, EventArgs e)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			string text = ((ToolStripItem)(ToolStripMenuItem)sender).get_Text() + ".lang";
			W3DR.Properties.a.Default.language = text;
			((SettingsBase)W3DR.Properties.a.Default).Save();
			global::A.a.m_A.A(".\\Language\\" + text);
		}

		private static void A(object sender, KeyPressEventArgs e)
		{
			if (!char.IsDigit(e.get_KeyChar()) && !char.IsControl(e.get_KeyChar()))
			{
				e.set_Handled(true);
			}
		}

		private static void A(object sender, KeyEventArgs e)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Invalid comparison between Unknown and I4
			if ((int)e.get_KeyCode() == 13)
			{
				if (uint.TryParse(((ToolStripItem)global::A.a.m_A).get_Text(), out var result) && result <= 550)
				{
					global::A.a.m_A = result;
					A(result);
					((Control)global::A.a.m_A).Hide();
				}
				else
				{
					((ToolStripItem)global::A.a.m_A).set_Text(global::A.a.m_A.ToString());
					A(global::A.a.m_A.a(), bool_0: true);
				}
			}
		}

		private static c A()
		{
			Process[] processesByName = Process.GetProcessesByName("war3");
			if (processesByName.Length == 0)
			{
				E();
				return global::A.a.c.A;
			}
			global::A.a.m_A.A = processesByName[0];
			if (global::A.a.m_A.A.Id != global::A.a.m_A.A)
			{
				CloseHandle(global::A.a.m_A.A);
				global::A.a.m_A.A = processesByName[0].Id;
				global::A.a.m_A.A = OpenProcess((IntPtr)56L, bool_0: false, global::A.a.m_A.A);
				if (global::A.a.m_A.A == IntPtr.Zero)
				{
					E();
					A(global::A.a.m_A.A() + " (" + Marshal.GetLastWin32Error() + ")", bool_0: true);
					return global::A.a.c.B;
				}
				if (!A(ref global::A.a.m_A.A))
				{
					global::A.a.m_A.A.A = IntPtr.Zero;
					global::A.a.m_A.A.A = 0L;
					A(global::A.a.m_A.E() + " Game.dll (-5)", bool_0: true);
					return global::A.a.c.B;
				}
			}
			if ((global::A.a.m_A.A.A == IntPtr.Zero || global::A.a.m_A.A.A == 0L) && !A(ref global::A.a.m_A.A))
			{
				E();
				A(global::A.a.m_A.E() + " Game.dll (-5)", bool_0: true);
				return global::A.a.c.B;
			}
			return global::A.a.c.a;
		}

		private static void E()
		{
			global::A.a.m_A.A.A = IntPtr.Zero;
			global::A.a.m_A.A = IntPtr.Zero;
			global::A.a.m_A.A.A = 0L;
			global::A.a.m_A.A = 0;
			global::A.a.m_A.A = null;
		}
	}
}
namespace a
{
	public class A
	{
		private const char m_A = '=';

		private string m_A = string.Empty;

		public A(string string_0)
		{
			if (File.Exists(string_0))
			{
				this.m_A = string_0;
			}
		}

		public string A(string string_0)
		{
			if (!File.Exists(this.m_A))
			{
				return null;
			}
			TextReader textReader = null;
			string result = null;
			try
			{
				textReader = new StreamReader(new FileStream(this.m_A, FileMode.Open));
				string text;
				while ((text = textReader.ReadLine()) != null)
				{
					if (text.IndexOf(string_0 + '=') != -1)
					{
						result = text.Substring(string_0.Length + 1);
					}
				}
				return result;
			}
			catch (Exception)
			{
				return null;
			}
			finally
			{
				textReader?.Close();
			}
		}
	}
	[CompilerGenerated]
	internal class a
	{
		[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 5)]
		private struct A
		{
		}

		internal static A A/* Not supported: data(9C C8 79 64 9C) */;

		internal static A a/* Not supported: data(52 B5 59 24 52) */;

		internal static A B/* Not supported: data(DC A9 97 69 DC) */;

		internal static A b/* Not supported: data(B8 54 8D 22 B8) */;

		internal static A C/* Not supported: data(6B 9B 03 36 6B) */;

		internal static A c/* Not supported: data(CF 17 EC 06 CF) */;

		internal static A D/* Not supported: data(BB 47 FA 0F BB) */;

		internal static A d/* Not supported: data(72 BC 94 38 72) */;

		internal static A E/* Not supported: data(B1 53 75 15 B1) */;

		internal static A e/* Not supported: data(52 B5 59 24 52) */;

		internal static A F/* Not supported: data(DC A9 97 69 DC) */;

		internal static A f/* Not supported: data(B8 54 8D 22 B8) */;

		internal static A G/* Not supported: data(71 06 8A 0F 71) */;

		internal static A g/* Not supported: data(D0 A1 89 7C D0) */;

		internal static A H/* Not supported: data(81 84 D3 64 81) */;

		internal static A h/* Not supported: data(0B A3 CD 11 0B) */;

		internal static A I/* Not supported: data(0B FC 79 4B 0B) */;

		internal static A i/* Not supported: data(85 1D 75 4E 85) */;

		internal static A J/* Not supported: data(CF 90 F7 68 CF) */;

		internal static A j/* Not supported: data(D2 B7 CF 2A D2) */;

		internal static A K/* Not supported: data(42 20 3A 01 42) */;

		internal static A k/* Not supported: data(21 81 0D 67 21) */;

		internal static A L/* Not supported: data(6B 62 99 3B 6B) */;

		internal static A l/* Not supported: data(FE D4 9E 3C FE) */;

		internal static A M/* Not supported: data(FC 8B 26 2A FC) */;

		internal static A m/* Not supported: data(B4 1F B2 30 B4) */;

		internal static A N/* Not supported: data(49 B3 D5 29 49) */;
	}
}
