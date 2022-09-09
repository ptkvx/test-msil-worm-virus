using System;
using System.Collections;
using System.IO;

internal sealed class Class9
{
	public sealed class Stream0 : Stream, IDisposable
	{
		private const int int_0 = 8192;

		private Stream stream_0;

		private bool bool_0;

		private bool bool_1;

		private Class10 class10_0;

		private byte[] byte_0;

		private int int_1;

		public Stream Stream_0 => stream_0;

		public override bool CanSeek => false;

		public override bool CanRead => false;

		public override bool CanWrite => true;

		public override long Length
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		public override long Position
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		public Stream0(Stream stream_1)
			: this(stream_1, bool_2: false)
		{
		}

		public Stream0(Stream stream_1, bool bool_2)
		{
			if (stream_1 == null && 0 == 0)
			{
				throw new ArgumentNullException();
			}
			stream_0 = stream_1;
			bool_0 = bool_2;
			bool_1 = true;
			byte_0 = new byte[8192];
			class10_0 = new Class10(stream_1);
		}

		public override long Seek(long offset, SeekOrigin origin)
		{
			throw new NotImplementedException();
		}

		public override void SetLength(long value)
		{
			throw new NotImplementedException();
		}

		private void method_0()
		{
			if (!bool_1)
			{
				throw new InvalidOperationException("Stream is closed.");
			}
		}

		public override int Read(byte[] buffer, int offset, int count)
		{
			throw new NotSupportedException();
		}

		public override void Write(byte[] buffer, int offset, int count)
		{
			if (count >= 0 && 0 == 0 && count <= buffer.Length)
			{
				if (offset >= 0 && offset <= buffer.Length)
				{
					if (offset + count > buffer.Length)
					{
						throw new ArgumentException("offset + count out of Ţŵffer");
					}
					method_0();
					if (int_1 + count > 8192)
					{
						method_1();
					}
					if (count >= 8192)
					{
						int i;
						for (i = 0; count - i > 32768; i += 32768)
						{
							class10_0.method_2(buffer, offset + i, 32768, bool_0: false);
						}
						class10_0.method_2(buffer, offset + i, count - i, bool_0: false);
						return;
					}
					Array.Copy(buffer, offset, byte_0, int_1, count);
					int_1 += count;
					if (int_1 == 8192)
					{
						method_1();
					}
					return;
				}
				throw new ArgumentOutOfRangeException("offset");
			}
			throw new ArgumentOutOfRangeException("count");
		}

		private void method_1()
		{
			if (int_1 > 0)
			{
				class10_0.method_2(byte_0, 0, int_1, bool_0: false);
				int_1 = 0;
			}
		}

		public override void Flush()
		{
			method_0();
			if (int_1 > 0)
			{
				method_1();
			}
			class10_0.method_1(bool_0: true, bool_1: false);
			Stream_0.Flush();
		}

		private void method_2()
		{
			if (int_1 > 0)
			{
				class10_0.method_2(byte_0, 0, int_1, bool_0: true);
			}
			else
			{
				class10_0.method_1(bool_0: false, bool_1: true);
			}
		}

		void IDisposable.Dispose()
		{
			if (bool_1 || 1 == 0)
			{
				method_2();
				byte_0 = null;
				class10_0 = null;
				if (!bool_0)
				{
					stream_0.Close();
					stream_0 = null;
				}
				bool_1 = false;
			}
			base.Close();
		}
	}

	private sealed class Class10
	{
		public const int int_0 = 32768;

		private Stream stream_0;

		private Class17 class17_0;

		private Class12 class12_0;

		public Stream Stream_0 => stream_0;

		public Class10(Stream stream_1)
		{
			if (stream_1 == null && 0 == 0)
			{
				throw new ArgumentNullException();
			}
			stream_0 = stream_1;
			class17_0 = new Class17(stream_1);
			class12_0 = new Class12();
		}

		internal void method_0(Class16 class16_0, out int[] int_1, out int[] int_2, out int int_3)
		{
			int_1 = new int[286];
			int_2 = new int[30];
			int_3 = 0;
			int num = 0;
			int num2 = 0;
			while (num < class16_0.arrayList_0.Count)
			{
				ushort num3 = (ushort)class16_0.arrayList_0[num];
				if (num3 <= 256)
				{
					int_1[num3]++;
					num++;
					continue;
				}
				int_1[num3]++;
				int_2[(ushort)class16_0.arrayList_0[num + 2]]++;
				num += 4;
				int_3 += (byte)class16_0.arrayList_1[num2] + (byte)class16_0.arrayList_1[num2 + 1];
				num2 += 2;
			}
		}

		public void method_1(bool bool_0, bool bool_1)
		{
			class17_0.method_0(bool_1);
			if (bool_0 || 1 == 0)
			{
				class17_0.method_1(0, 2);
				class17_0.method_3();
				class17_0.method_1(0, 16);
				class17_0.method_1(65535, 16);
			}
			else
			{
				class17_0.method_1(1, 2);
				Struct1 @struct = Class1.struct1_0[256];
				class17_0.method_2(@struct.int_0, @struct.int_1);
			}
			if (bool_1)
			{
				class17_0.method_3();
			}
		}

		public void method_2(byte[] byte_0, int int_1, int int_2, bool bool_0)
		{
			if (int_2 > 32768)
			{
				throw new ArgumentOutOfRangeException();
			}
			Class16 @class = class12_0.method_0(byte_0, int_1, int_2);
			if (@class == null && 0 == 0)
			{
				throw new InvalidOperationException();
			}
			if (@class.int_0 != int_2)
			{
				throw new InvalidOperationException();
			}
			@class.method_2();
			method_0(@class, out var int_3, out var int_4, out var int_5);
			int[] array = Class1.smethod_11(int_3);
			int[] array2 = Class1.smethod_11(int_4);
			int num = (4 + int_2) * 8;
			num = ((class17_0.Int32_0 >= 3) ? (num + (class17_0.Int32_0 - 3)) : (num + (5 + class17_0.Int32_0)));
			int num2 = Class1.smethod_0(array, int_3) + Class1.smethod_0(array2, int_4) + int_5;
			int num3 = Class1.smethod_1(array, array2) + int_5;
			bool flag;
			if (!(flag = num3 <= num2 || num <= num2))
			{
				int num4 = num2 + method_6(array, array2);
				flag = num3 <= num4 || num <= num4;
			}
			bool flag2 = num < num3;
			class17_0.method_0(bool_0);
			if (flag2 && flag)
			{
				class17_0.method_1(0, 2);
				class17_0.method_3();
				int int_6 = ~int_2 & 0xFFFF;
				class17_0.method_1(int_2, 16);
				class17_0.method_1(int_6, 16);
				class17_0.method_3();
				method_4(byte_0, int_1, int_2);
			}
			else
			{
				Struct1[] struct1_;
				Struct1[] struct1_2;
				if (flag)
				{
					class17_0.method_1(1, 2);
					struct1_ = Class1.struct1_0;
					struct1_2 = Class1.struct1_1;
				}
				else
				{
					class17_0.method_1(2, 2);
					method_5(array, array2);
					struct1_ = Class1.smethod_2(array);
					struct1_2 = Class1.smethod_2(array2);
				}
				method_3(@class, struct1_, struct1_2);
			}
			if (bool_0)
			{
				class17_0.method_3();
			}
		}

		private void method_3(Class16 class16_0, Struct1[] struct1_0, Struct1[] struct1_1)
		{
			int num = 0;
			int num2 = 0;
			while (num < class16_0.arrayList_0.Count)
			{
				int num3 = (ushort)class16_0.arrayList_0[num];
				if (num3 <= 256)
				{
					Struct1 @struct = struct1_0[num3];
					class17_0.method_2(@struct.int_0, @struct.int_1);
					num++;
					continue;
				}
				Struct1 struct2 = struct1_0[num3];
				class17_0.method_2(struct2.int_0, struct2.int_1);
				if ((byte)class16_0.arrayList_1[num2] > 0)
				{
					class17_0.method_1((ushort)class16_0.arrayList_0[num + 1], (byte)class16_0.arrayList_1[num2]);
				}
				num += 2;
				num2++;
				struct2 = struct1_1[(ushort)class16_0.arrayList_0[num]];
				class17_0.method_2(struct2.int_0, struct2.int_1);
				if ((byte)class16_0.arrayList_1[num2] > 0)
				{
					class17_0.method_1((ushort)class16_0.arrayList_0[num + 1], (byte)class16_0.arrayList_1[num2]);
				}
				num += 2;
				num2++;
			}
		}

		private void method_4(byte[] byte_0, int int_1, int int_2)
		{
			Stream_0.Write(byte_0, int_1, int_2);
		}

		private void method_5(int[] int_1, int[] int_2)
		{
			int[] array = new int[19];
			int num = 286;
			while (num > 257 && int_1[num - 1] == 0)
			{
				num--;
			}
			int num2 = 30;
			while (num2 > 1 && int_2[num2 - 1] == 0)
			{
				num2--;
			}
			int[] array2 = new int[num + num2];
			Array.Copy(int_1, 0, array2, 0, num);
			Array.Copy(int_2, 0, array2, num, num2);
			int[] array3 = Class1.smethod_13(array2, 0, array2.Length);
			for (int i = 0; i < array3.Length; i++)
			{
				array[array3[i]]++;
				if (array3[i] >= 16)
				{
					i++;
				}
			}
			int[] array4 = Class1.smethod_10(array, 7);
			int[] int_3 = Class1.int_17;
			int num3 = 19;
			while (num3 > 4 && array4[int_3[num3 - 1]] == 0)
			{
				num3--;
			}
			int int_4 = num - 257;
			int int_5 = num2 - 1;
			int int_6 = num3 - 4;
			Struct1[] array5 = Class1.smethod_2(array4);
			class17_0.method_1(int_4, 5);
			class17_0.method_1(int_5, 5);
			class17_0.method_1(int_6, 4);
			for (int j = 0; j < num3; j++)
			{
				class17_0.method_1(array4[int_3[j]], 3);
			}
			for (int k = 0; k < array3.Length; k++)
			{
				int num4 = array3[k];
				Struct1 @struct = array5[num4];
				class17_0.method_2(@struct.int_0, @struct.int_1);
				if (num4 >= 16)
				{
					k++;
					class17_0.method_1(array3[k], Class1.smethod_12(num4));
				}
			}
		}

		private int method_6(int[] int_1, int[] int_2)
		{
			int[] array = new int[19];
			int num = 0;
			int num2 = 286;
			while (num2 > 257 && int_1[num2 - 1] == 0)
			{
				num2--;
			}
			int[] array2 = Class1.smethod_13(int_1, 0, num2);
			for (int i = 0; i < array2.Length; i++)
			{
				array[array2[i]]++;
				if (array2[i] >= 16)
				{
					num += Class1.smethod_12(array2[i]);
					i++;
				}
			}
			int num3 = 30;
			while (num3 > 1 && int_2[num3 - 1] == 0)
			{
				num3--;
			}
			int[] array3 = Class1.smethod_13(int_2, 0, num3);
			for (int j = 0; j < array3.Length; j++)
			{
				array[array3[j]]++;
				if (array3[j] >= 16)
				{
					num += Class1.smethod_12(array3[j]);
					j++;
				}
			}
			int[] array4 = Class1.smethod_11(array);
			int num4 = Class1.smethod_0(array, array4);
			int[] int_3 = Class1.int_17;
			int num5 = 19;
			while (num5 > 4 && array4[int_3[num5 - 1]] == 0)
			{
				num5--;
			}
			int num6 = num5 - 4;
			return 14 + (num6 + 4) * 3 + num4 + num;
		}
	}

	private sealed class Class11
	{
		public static readonly Class11 class11_0;

		public int int_0;

		public int int_1;

		public int int_2;

		public int int_3;

		static Class11()
		{
			class11_0 = new Class11
			{
				int_0 = 8,
				int_1 = 32,
				int_2 = 128,
				int_3 = 256
			};
		}
	}

	private sealed class Class12
	{
		private struct Struct2
		{
			public int int_0;

			public int int_1;
		}

		private const int int_0 = 258;

		private const int int_1 = 32768;

		private Class15 class15_0;

		private Class13 class13_0;

		private Class11 class11_0;

		private int int_2;

		internal Class11 Class11_0 => class11_0;

		internal Class12()
			: this(Class11.class11_0)
		{
		}

		internal Class12(Class11 class11_1)
		{
			class11_0 = class11_1;
			class15_0 = new Class15(65536);
			class13_0 = new Class13(32768);
			int_2 = 0;
		}

		public Class16 method_0(byte[] byte_0, int int_3, int int_4)
		{
			if (class15_0.Int32_1 + int_4 > class15_0.Int32_0)
			{
				int num = class15_0.Int32_1 - 32768;
				class15_0.method_1(num);
				if (int_2 >= num && 0 == 0)
				{
					int_2 -= num;
				}
				else
				{
					class13_0.method_3(num - int_2);
					int_2 = 0;
				}
			}
			int int32_ = class15_0.Int32_1;
			class15_0.method_0(byte_0, int_3, int_4);
			if (int_2 < int32_)
			{
				class13_0.method_2(class15_0.Byte_0, int_2, int32_ - int_2);
			}
			if (Class11_0.int_2 > 0)
			{
				return method_2(class13_0, class15_0.Byte_0, int32_, int_4, out int_2);
			}
			return method_1(class15_0.Byte_0, int32_, int_4);
		}

		private Class16 method_1(byte[] byte_0, int int_3, int int_4)
		{
			Class16 @class = new Class16();
			@class.arrayList_0.Capacity = int_4 + 1;
			for (int i = 0; i < int_4; i++)
			{
				@class.method_0(byte_0[i]);
			}
			return @class;
		}

		private Class16 method_2(Class13 class13_1, byte[] byte_0, int int_3, int int_4, out int int_5)
		{
			Class16 @class = new Class16();
			object obj = null;
			int i = 0;
			while (i < int_4 - 2)
			{
				Class13.Class14 class2 = class13_1.method_0(byte_0, int_3 + i);
				if (class2 != null)
				{
					object obj2;
					if (obj != null)
					{
						obj2 = obj;
						obj = null;
					}
					else
					{
						obj2 = method_3(byte_0, int_3, int_4, i, class2, 3);
					}
					Struct2 @struct = (Struct2)obj2;
					bool flag;
					if ((flag = @struct.int_1 >= 3) && i < int_4 - 3 && @struct.int_1 < class11_0.int_1)
					{
						Class13.Class14 class3 = class13_1.method_0(byte_0, int_3 + i + 1);
						if (class3 != null)
						{
							Struct2 struct2 = method_3(byte_0, int_3, int_4, i + 1, class3, @struct.int_1 + 1);
							if (struct2.int_1 > @struct.int_1)
							{
								obj = struct2;
								flag = false;
							}
						}
					}
					if (flag)
					{
						@class.method_1(i - @struct.int_0, @struct.int_1);
						class13_1.method_1(byte_0, int_3 + i);
						i += @struct.int_1;
						class13_1.method_3(@struct.int_1 - 1);
					}
					else
					{
						@class.method_0(byte_0[int_3 + i]);
						class13_1.method_1(byte_0, int_3 + i);
						i++;
					}
				}
				else
				{
					@class.method_0(byte_0[int_3 + i]);
					class13_1.method_1(byte_0, int_3 + i);
					i++;
				}
			}
			int_5 = int_3 + i;
			for (; i < int_4; i++)
			{
				@class.method_0(byte_0[int_3 + i]);
			}
			return @class;
		}

		private Struct2 method_3(byte[] byte_0, int int_3, int int_4, int int_5, Class13.Class14 class14_0, int int_6)
		{
			int num = class11_0.int_3;
			int num2 = 0;
			int num3 = -1;
			int num4 = 0;
			int num5 = int_6 - 1;
			int num6 = int_3 + int_5;
			while (class14_0.method_0())
			{
				int i = 0;
				int num7 = int_5 - class14_0.Int32_0;
				if (int_5 + num5 >= int_4)
				{
					break;
				}
				int num8 = int_3 + num7;
				if (byte_0[num8 + num5] == byte_0[num6 + num5])
				{
					for (; i < 258 && int_5 + i < int_4 && byte_0[num8 + i] == byte_0[num6 + i]; i++)
					{
					}
					if (i >= num2 && 0 == 0)
					{
						num2 = i;
						num5 = i;
						num3 = num7;
						if (num2 >= class11_0.int_2)
						{
							break;
						}
					}
					if (num2 >= class11_0.int_0)
					{
						num >>= 2;
					}
				}
				if (++num4 >= num)
				{
					break;
				}
			}
			Struct2 result = default(Struct2);
			result.int_1 = num2;
			result.int_0 = num3;
			return result;
		}
	}

	private sealed class Class13
	{
		internal sealed class Class14
		{
			private Class13 class13_0;

			private int int_0;

			private int int_1;

			internal int Int32_0 => int_0;

			internal Class14(Class13 class13_1, int int_2)
			{
				class13_0 = class13_1;
				int_0 = int_2;
			}

			internal bool method_0()
			{
				if (int_1 == 0 && 0 == 0)
				{
					int_1 = 1;
					return true;
				}
				if (int_1 == 1)
				{
					ushort num = class13_0.ushort_2[(class13_0.int_4 - int_0) % class13_0.int_2];
					if (num != 0)
					{
						int_0 += num;
						if (int_0 <= class13_0.int_2)
						{
							return true;
						}
					}
					int_1 = 2;
				}
				return false;
			}
		}

		private const int int_0 = 16777216;

		private const int int_1 = 256;

		private const ushort ushort_0 = ushort.MaxValue;

		private const ushort ushort_1 = 0;

		private int int_2;

		private ushort[] ushort_2;

		private int[] int_3;

		private int int_4;

		internal Class13(int int_5)
		{
			int_2 = int_5;
			ushort_2 = new ushort[int_2];
			int_3 = new int[256];
			for (int i = 0; i < 256; i++)
			{
				int_3[i] = 65535;
			}
		}

		internal Class14 method_0(byte[] byte_0, int int_5)
		{
			int num = smethod_0(byte_0, int_5);
			if (int_3[num] != 65535 && int_4 - int_3[num] <= int_2)
			{
				return new Class14(this, int_4 - int_3[num]);
			}
			return null;
		}

		internal void method_1(byte[] byte_0, int int_5)
		{
			int num = smethod_0(byte_0, int_5);
			int num2 = int_4 % int_2;
			if (int_3[num] != 65535 && ((int_4 - int_3[num] < int_2) ? true : false))
			{
				ushort_2[num2] = (ushort)(int_4 - int_3[num]);
			}
			else
			{
				ushort_2[num2] = 0;
			}
			int_3[num] = int_4;
			if (++int_4 < 16777216)
			{
				return;
			}
			int num3 = int_4 - int_2;
			num3 -= num3 % int_2;
			for (int i = 0; i < int_3.Length; i++)
			{
				if (int_3[i] >= num3)
				{
					int_3[i] -= num3;
				}
				else
				{
					int_3[i] = 0;
				}
			}
			int_4 -= num3;
		}

		internal void method_2(byte[] byte_0, int int_5, int int_6)
		{
			for (int i = 0; i < int_6; i++)
			{
				method_1(byte_0, int_5 + i);
			}
		}

		internal void method_3(int int_5)
		{
			int_4 += int_5;
		}

		private static int smethod_0(byte[] byte_0, int int_5)
		{
			return (byte)(byte_0[int_5] + byte_0[int_5 + 1] + byte_0[int_5 + 2]);
		}
	}

	private sealed class Class15
	{
		private int int_0;

		private byte[] byte_0;

		private int int_1;

		public byte[] Byte_0 => byte_0;

		public int Int32_0 => int_0;

		public int Int32_1 => int_1;

		public Class15(int int_2)
		{
			int_0 = int_2;
			byte_0 = new byte[int_2];
			int_1 = 0;
		}

		public void method_0(byte[] byte_1, int int_2, int int_3)
		{
			Array.Copy(byte_1, int_2, byte_0, int_1, int_3);
			int_1 += int_3;
		}

		public void method_1(int int_2)
		{
			Array.Copy(byte_0, int_2, byte_0, 0, Int32_1 - int_2);
			int_1 -= int_2;
		}
	}

	private sealed class Class16
	{
		internal ArrayList arrayList_0 = new ArrayList();

		internal ArrayList arrayList_1 = new ArrayList();

		internal int int_0;

		public void method_0(byte byte_0)
		{
			arrayList_0.Add((ushort)byte_0);
			int_0++;
		}

		public void method_1(int int_1, int int_2)
		{
			if (int_1 >= 1 && 0 == 0 && int_1 <= 32768)
			{
				if (int_2 < 3 || int_2 > 258)
				{
					throw new ArgumentOutOfRangeException();
				}
				Class1.smethod_8(int_2, out var int_3, out var int_4, out var int_5);
				Class1.smethod_9(int_1, out var int_6, out var int_7, out var int_8);
				arrayList_0.Add((ushort)int_3);
				arrayList_0.Add((ushort)int_4);
				arrayList_1.Add((byte)int_5);
				arrayList_0.Add((ushort)int_6);
				arrayList_0.Add((ushort)int_7);
				arrayList_1.Add((byte)int_8);
				int_0 += int_2;
				return;
			}
			throw new ArgumentOutOfRangeException();
		}

		internal void method_2()
		{
			arrayList_0.Add((ushort)256);
		}
	}

	private sealed class Class17
	{
		private uint uint_0;

		private int int_0;

		private Stream stream_0;

		internal Stream Stream_0 => stream_0;

		internal int Int32_0 => (32 - int_0) % 8;

		internal Class17(Stream stream_1)
		{
			stream_0 = stream_1;
		}

		internal void method_0(bool bool_0)
		{
			method_1(bool_0 ? 1 : 0, 1);
		}

		internal void method_1(int int_1, int int_2)
		{
			uint num = uint_0 | (checked((uint)int_1) << int_0);
			int num2;
			for (num2 = int_0 + int_2; num2 >= 8; num2 -= 8)
			{
				Stream_0.WriteByte((byte)num);
				num >>= 8;
			}
			uint_0 = num;
			int_0 = num2;
		}

		internal void method_2(int int_1, int int_2)
		{
			int num = 0;
			for (int num2 = int_2 - 1; num2 >= 0; num2--)
			{
				num <<= 1;
				num |= int_1 & 1;
				int_1 >>= 1;
			}
			method_1(num, int_2);
		}

		internal void method_3()
		{
			if (int_0 > 0)
			{
				Stream_0.WriteByte((byte)uint_0);
				uint_0 = 0u;
				int_0 = 0;
			}
		}
	}
}
