using System;
using System.IO;

internal sealed class Class5
{
	public sealed class Class6
	{
		private Class8 class8_0 = new Class8(32769);

		private Class7 class7_0;

		private Class4 class4_0;

		private int int_0 = -1;

		private int int_1 = -1;

		private bool bool_0;

		private int int_2;

		private long long_0;

		private long long_1;

		private bool bool_1;

		private int int_3;

		private bool bool_2;

		public Class6(Stream stream_0)
		{
			class7_0 = new Class7(stream_0);
		}

		public int method_0(byte[] byte_0, int int_4, int int_5)
		{
			if (byte_0 == null && 0 == 0)
			{
				throw new ArgumentNullException();
			}
			if (int_5 != 0 && !bool_1)
			{
				int num = 0;
				while (num < int_5)
				{
					while (int_0 < 0 && !bool_1)
					{
						bool_1 = !method_1();
					}
					if (bool_1)
					{
						break;
					}
					int num2 = method_2(byte_0, int_4 + num, int_5 - num);
					if (num2 > 0)
					{
						num += num2;
					}
					else
					{
						int_0 = -1;
					}
				}
				return num;
			}
			return 0;
		}

		private bool method_1()
		{
			if (bool_0 || 1 == 0)
			{
				return false;
			}
			long_0 = class7_0.long_0;
			bool_0 = class7_0.method_0(1) > 0;
			int_0 = class7_0.method_0(2);
			switch (int_0)
			{
			default:
				throw new InvalidOperationException();
			case 0:
			{
				class7_0.method_1();
				int num = class7_0.method_0(16);
				int num2 = class7_0.method_0(16);
				if ((num & ~num2) != num)
				{
					throw new InvalidOperationException();
				}
				int_2 = num;
				class4_0 = null;
				bool_2 = true;
				break;
			}
			case 1:
			{
				Struct1[] struct1_ = Class1.struct1_0;
				Struct1[] struct1_2 = Class1.struct1_1;
				int_2 = 0;
				class4_0 = Class1.class4_0;
				bool_2 = false;
				break;
			}
			case 2:
			{
				method_6(class7_0, out var struct1_, out var struct1_2);
				int_2 = 0;
				class4_0 = Class1.smethod_4(struct1_, struct1_2);
				bool_2 = false;
				break;
			}
			}
			long_1 = class7_0.long_0;
			return true;
		}

		private int method_2(byte[] byte_0, int int_4, int int_5)
		{
			int num = int_4;
			if (int_0 == 0 && 0 == 0)
			{
				if (int_2 > 0)
				{
					int num2 = Math.Min(int_5, int_2);
					class7_0.method_2(byte_0, int_4, num2);
					class8_0.method_1(byte_0, int_4, num2);
					int_2 -= num2;
					int_5 -= num2;
					int_4 += num2;
				}
			}
			else if (!bool_2)
			{
				if (int_3 > 0)
				{
					method_3(byte_0, ref int_4, ref int_5);
				}
				if (int_5 > 0)
				{
					do
					{
						int num3 = smethod_0(class7_0, class4_0.class3_0);
						bool_2 = num3 == 256;
						if (bool_2)
						{
							break;
						}
						if (num3 < 256)
						{
							byte_0[int_4++] = (byte)num3;
							class8_0.method_0((byte)num3);
							int_5--;
						}
						else if (num3 <= 285)
						{
							int num4 = smethod_1(class7_0, num3);
							int num5 = smethod_2(class7_0, class4_0.class3_1);
							if (num5 > class8_0.long_0)
							{
								throw new InvalidOperationException();
							}
							int_1 = num5;
							int_3 = num4;
							method_3(byte_0, ref int_4, ref int_5);
						}
					}
					while (int_5 > 0);
				}
			}
			long_1 = class7_0.long_0;
			return int_4 - num;
		}

		private void method_3(byte[] byte_0, ref int int_4, ref int int_5)
		{
			int num = Math.Min(int_3, int_5);
			byte[] array = class8_0.method_2(int_1, Math.Min(num, int_1));
			int_5 -= num;
			int_3 -= num;
			while ((num > array.Length) ? true : false)
			{
				Array.Copy(array, 0, byte_0, int_4, array.Length);
				int_4 += array.Length;
				num -= array.Length;
				class8_0.method_1(array, 0, array.Length);
			}
			Array.Copy(array, 0, byte_0, int_4, num);
			int_4 += num;
			class8_0.method_1(array, 0, num);
		}

		public bool method_4(int int_4)
		{
			byte[] byte_ = new byte[1024];
			int num;
			while (int_4 > 0 && (num = method_0(byte_, 0, Math.Min(1024, int_4))) > 0)
			{
				int_4 -= num;
			}
			return int_4 <= 0;
		}

		public void method_5()
		{
			byte[] byte_ = new byte[1024];
			while (method_0(byte_, 0, 1024) > 0)
			{
			}
		}

		private static int smethod_0(Class7 class7_1, Class3 class3_0)
		{
			while (class3_0 != null && !class3_0.bool_0)
			{
				class3_0 = ((class7_1.method_0(1) > 0) ? class3_0.class3_1 : class3_0.class3_0);
			}
			if (class3_0 == null)
			{
				throw new InvalidOperationException();
			}
			return class3_0.ushort_0;
		}

		private static int smethod_1(Class7 class7_1, int int_4)
		{
			Class1.smethod_7(int_4, out var int_5, out var int_6);
			if (int_6 > 0)
			{
				return int_5 + class7_1.method_0(int_6);
			}
			return int_5;
		}

		private static int smethod_2(Class7 class7_1, Class3 class3_0)
		{
			int num = smethod_0(class7_1, class3_0);
			if (num > 29)
			{
				throw new InvalidOperationException();
			}
			int num2 = Class1.int_20[num];
			int num3 = Class1.int_21[num];
			if (num3 > 0)
			{
				int num4 = class7_1.method_0(num3);
				if (num == 284 && num4 > 30)
				{
					throw new InvalidOperationException();
				}
				return num2 + num4;
			}
			return num2;
		}

		private void method_6(Class7 class7_1, out Struct1[] struct1_0, out Struct1[] struct1_1)
		{
			int num = class7_1.method_0(5) + 257;
			int num2 = class7_1.method_0(5) + 1;
			int num3 = class7_1.method_0(4) + 4;
			if (num > 286)
			{
				throw new InvalidOperationException();
			}
			int[] int_ = Class1.int_17;
			int[] array = new int[19];
			for (int i = 0; i < num3; i++)
			{
				array[int_[i]] = class7_1.method_0(3);
			}
			Struct1[] struct1_2 = Class1.smethod_2(array);
			Class3 class3_ = Class1.smethod_5(struct1_2);
			int[] array2 = smethod_3(class7_1, class3_, num + num2);
			struct1_0 = new Struct1[num];
			for (int j = 0; j < num; j++)
			{
				struct1_0[j].int_1 = array2[j];
			}
			Class1.smethod_3(struct1_0);
			struct1_1 = new Struct1[num2];
			for (int k = 0; k < num2; k++)
			{
				struct1_1[k].int_1 = array2[k + num];
			}
			Class1.smethod_3(struct1_1);
		}

		private static int[] smethod_3(Class7 class7_1, Class3 class3_0, int int_4)
		{
			int[] array = new int[int_4];
			for (int i = 0; i < int_4; i++)
			{
				int num = smethod_0(class7_1, class3_0);
				if (num < 16)
				{
					array[i] = num;
					continue;
				}
				switch (num)
				{
				case 16:
				{
					int num4 = class7_1.method_0(2) + 3;
					if (num4 + i <= array.Length)
					{
						for (int j = 0; j < num4; j++)
						{
							array[i + j] = array[i - 1];
						}
						i += num4 - 1;
						break;
					}
					throw new InvalidOperationException();
				}
				case 17:
				{
					int num3 = class7_1.method_0(3) + 3;
					if (num3 + i <= array.Length)
					{
						i += num3 - 1;
						break;
					}
					throw new InvalidOperationException();
				}
				case 18:
				{
					int num2 = class7_1.method_0(7) + 11;
					if (num2 + i <= array.Length)
					{
						i += num2 - 1;
						break;
					}
					throw new InvalidOperationException();
				}
				default:
					throw new InvalidOperationException();
				}
			}
			return array;
		}
	}

	private sealed class Class7
	{
		private uint uint_0;

		private int int_0;

		private int int_1;

		private Stream stream_0;

		internal long long_0;

		internal Class7(Stream stream_1)
		{
			stream_0 = stream_1;
		}

		internal int method_0(int int_2)
		{
			long_0 += int_2;
			for (int num = int_2 - (int_1 - int_0); num > 0; num -= 8)
			{
				uint_0 |= checked((uint)stream_0.ReadByte()) << int_1;
				int_1 += 8;
			}
			int result = (int)(uint_0 >> int_0) & ((1 << int_2) - 1);
			int_0 += int_2;
			if (int_1 == int_0)
			{
				int_0 = 0;
				int_1 = 0;
				uint_0 = 0u;
			}
			else if (int_0 >= 8)
			{
				uint_0 >>= int_0;
				int_1 -= int_0;
				int_0 = 0;
			}
			return result;
		}

		internal void method_1()
		{
			if (int_1 != int_0)
			{
				long_0 += int_1 - int_0;
			}
			int_0 = 0;
			int_1 = 0;
			uint_0 = 0u;
		}

		internal void method_2(byte[] byte_0, int int_2, int int_3)
		{
			if (int_1 != int_0)
			{
				throw new InvalidOperationException();
			}
			int num = stream_0.Read(byte_0, int_2, int_3);
			long_0 += num << 3;
			if (num != int_3)
			{
				throw new InvalidOperationException();
			}
		}
	}

	private sealed class Class8
	{
		private byte[] byte_0;

		private int int_0;

		internal int int_1;

		internal long long_0;

		internal Class8(int int_2)
		{
			int_1 = int_2;
			byte_0 = new byte[int_2];
		}

		internal void method_0(byte byte_1)
		{
			byte_0[int_0++] = byte_1;
			if (int_0 >= int_1 && 0 == 0)
			{
				int_0 = 0;
			}
			long_0++;
		}

		internal void method_1(byte[] byte_1, int int_2, int int_3)
		{
			long_0 += int_3;
			if (int_3 >= int_1 && 0 == 0)
			{
				Array.Copy(byte_1, int_2, byte_0, 0, int_1);
				int_0 = 0;
			}
			else if (int_0 + int_3 > int_1)
			{
				int num = int_1 - int_0;
				int length = int_0 + int_3 - int_1;
				Array.Copy(byte_1, int_2, byte_0, int_0, num);
				Array.Copy(byte_1, int_2 + num, byte_0, 0, length);
				int_0 = length;
			}
			else
			{
				Array.Copy(byte_1, int_2, byte_0, int_0, int_3);
				int_0 += int_3;
				if (int_0 == int_1)
				{
					int_0 = 0;
				}
			}
		}

		internal byte[] method_2(int int_2, int int_3)
		{
			byte[] array = new byte[int_3];
			if (int_0 >= int_2 && 0 == 0)
			{
				Array.Copy(byte_0, int_0 - int_2, array, 0, int_3);
			}
			else
			{
				int num = int_2 - int_0;
				if (num < int_3)
				{
					Array.Copy(byte_0, int_1 - num, array, 0, num);
					Array.Copy(byte_0, 0, array, num, int_3 - num);
				}
				else
				{
					Array.Copy(byte_0, int_1 - num, array, 0, int_3);
				}
			}
			return array;
		}
	}

	public static void smethod_0(Stream stream_0, Stream stream_1)
	{
		byte[] array = new byte[4096];
		Class6 @class = new Class6(stream_0);
		while (true)
		{
			int num = @class.method_0(array, 0, array.Length);
			if (num > 0)
			{
				stream_1.Write(array, 0, num);
				continue;
			}
			break;
		}
	}
}
