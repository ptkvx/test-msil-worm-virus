using System;
using System.Collections;

internal sealed class Class1
{
	private sealed class Class2
	{
		internal static int[] smethod_0(int[] int_0, int int_1)
		{
			int[] array = new int[int_0.Length];
			int[] array2 = new int[int_0.Length];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = i;
			}
			Array.Copy(int_0, array2, int_0.Length);
			Array.Sort(array2, array);
			int j;
			for (j = 0; j < array2.Length && array2[j] == 0; j++)
			{
			}
			int[] array3 = new int[array2.Length - j];
			Array.Copy(array2, j, array3, 0, array3.Length);
			int[] array4 = ((array3.Length == 0) ? new int[0] : ((array3.Length != 1) ? smethod_1(array3, int_1) : new int[1] { 1 }));
			int[] array5 = new int[int_0.Length];
			for (int k = 0; k < array4.Length; k++)
			{
				array5[array[k + j]] = array4[k];
			}
			return array5;
		}

		private static int[] smethod_1(int[] int_0, int int_1)
		{
			int num = int_0.Length;
			int[][] array = new int[int_1][];
			array[0] = int_0;
			int[] array2 = new int[int_0.Length / 2];
			for (int i = 0; i < array2.Length; i++)
			{
				array2[i] = int_0[i * 2] + int_0[i * 2 + 1];
			}
			for (int j = 1; j < int_1; j++)
			{
				int[] array3 = (array[j] = smethod_2(array2, int_0));
				array2 = new int[array3.Length / 2];
				for (int k = 0; k < array2.Length; k++)
				{
					array2[k] = array3[k * 2] + array3[k * 2 + 1];
				}
			}
			int[] array4 = new int[num];
			int num2 = num - 1;
			for (int num3 = int_1 - 1; num3 >= 0; num3--)
			{
				int[] array5 = array[num3];
				int num4 = 0;
				int num5 = 0;
				for (int l = 0; l < num2 * 2; l++)
				{
					if (num5 < int_0.Length && int_0[num5] == array5[l])
					{
						array4[num5]++;
						num5++;
					}
					else
					{
						num4++;
					}
				}
				num2 = num4;
			}
			return array4;
		}

		private static int[] smethod_2(int[] int_0, int[] int_1)
		{
			int[] array = new int[int_0.Length + int_1.Length];
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			while (num < int_0.Length && num2 < int_1.Length)
			{
				if (int_0[num] < int_1[num2])
				{
					array[num3++] = int_0[num++];
				}
				else
				{
					array[num3++] = int_1[num2++];
				}
			}
			while (num < int_0.Length)
			{
				array[num3++] = int_0[num++];
			}
			while (num2 < int_1.Length)
			{
				array[num3++] = int_1[num2++];
			}
			return array;
		}
	}

	private struct Struct0
	{
		internal Struct1 struct1_0;

		internal ushort ushort_0;
	}

	internal const int int_0 = 32768;

	internal const int int_1 = 258;

	internal const int int_2 = 285;

	internal const int int_3 = 287;

	internal const int int_4 = 29;

	internal const int int_5 = 31;

	internal const int int_6 = 15;

	internal const int int_7 = 256;

	internal const int int_8 = 0;

	internal const int int_9 = 1;

	internal const int int_10 = 2;

	internal const int int_11 = 16;

	internal const int int_12 = 18;

	internal const int int_13 = 16;

	internal const int int_14 = 17;

	internal const int int_15 = 18;

	private const int int_16 = 257;

	internal static Struct1[] struct1_0;

	internal static Struct1[] struct1_1;

	internal static Class4 class4_0;

	internal static readonly int[] int_17;

	internal static readonly int[] int_18;

	internal static readonly int[] int_19;

	internal static readonly int[] int_20;

	internal static readonly int[] int_21;

	static Class1()
	{
		struct1_0 = new Struct1[288];
		struct1_1 = new Struct1[32];
		int_17 = new int[19];
		int_17[0] = 16;
		int_17[1] = 17;
		int_17[2] = 18;
		int_17[4] = 8;
		int_17[5] = 7;
		int_17[6] = 9;
		int_17[7] = 6;
		int_17[8] = 10;
		int_17[9] = 5;
		int_17[10] = 11;
		int_17[11] = 4;
		int_17[12] = 12;
		int_17[13] = 3;
		int_17[14] = 13;
		int_17[15] = 2;
		int_17[16] = 14;
		int_17[17] = 1;
		int_17[18] = 15;
		int_18 = new int[29];
		int_18[0] = 3;
		int_18[1] = 4;
		int_18[2] = 5;
		int_18[3] = 6;
		int_18[4] = 7;
		int_18[5] = 8;
		int_18[6] = 9;
		int_18[7] = 10;
		int_18[8] = 11;
		int_18[9] = 13;
		int_18[10] = 15;
		int_18[11] = 17;
		int_18[12] = 19;
		int_18[13] = 23;
		int_18[14] = 27;
		int_18[15] = 31;
		int_18[16] = 35;
		int_18[17] = 43;
		int_18[18] = 51;
		int_18[19] = 59;
		int_18[20] = 67;
		int_18[21] = 83;
		int_18[22] = 99;
		int_18[23] = 115;
		int_18[24] = 131;
		int_18[25] = 163;
		int_18[26] = 195;
		int_18[27] = 227;
		int_18[28] = 258;
		int_19 = new int[29];
		int i = 8;
		int num = 0;
		for (; i < 28; i++)
		{
			if (i % 4 == 0)
			{
				num++;
			}
			int_19[i] = num;
		}
		int_20 = new int[30];
		int_20[0] = 1;
		int_20[1] = 2;
		int_20[2] = 3;
		int_20[3] = 4;
		int_20[4] = 5;
		int_20[5] = 7;
		int_20[6] = 9;
		int_20[7] = 13;
		int_20[8] = 17;
		int_20[9] = 25;
		int_20[10] = 33;
		int_20[11] = 49;
		int_20[12] = 65;
		int_20[13] = 97;
		int_20[14] = 129;
		int_20[15] = 193;
		int_20[16] = 257;
		int_20[17] = 385;
		int_20[18] = 513;
		int_20[19] = 769;
		int_20[20] = 1025;
		int_20[21] = 1537;
		int_20[22] = 2049;
		int_20[23] = 3073;
		int_20[24] = 4097;
		int_20[25] = 6145;
		int_20[26] = 8193;
		int_20[27] = 12289;
		int_20[28] = 16385;
		int_20[29] = 24577;
		int_21 = new int[30];
		int j = 4;
		int num2 = 0;
		for (; j < 30; j++)
		{
			if (j % 2 == 0)
			{
				num2++;
			}
			int_21[j] = num2;
		}
		for (int k = 0; k <= 143; k++)
		{
			struct1_0[k].int_0 = 48 + k;
			struct1_0[k].int_1 = 8;
		}
		for (int l = 144; l <= 255; l++)
		{
			struct1_0[l].int_0 = 400 + l - 144;
			struct1_0[l].int_1 = 9;
		}
		for (int m = 256; m <= 279; m++)
		{
			struct1_0[m].int_0 = m - 256;
			struct1_0[m].int_1 = 7;
		}
		for (int n = 280; n <= 287; n++)
		{
			struct1_0[n].int_0 = 192 + n - 280;
			struct1_0[n].int_1 = 8;
		}
		for (int num3 = 0; num3 <= 31; num3++)
		{
			struct1_1[num3].int_0 = num3;
			struct1_1[num3].int_1 = 5;
		}
		class4_0 = smethod_4(struct1_0, struct1_1);
	}

	internal static int smethod_0(int[] int_22, int[] int_23)
	{
		int num = 0;
		for (int i = 0; i < int_22.Length; i++)
		{
			num += int_22[i] * int_23[i];
		}
		return num;
	}

	internal static int smethod_1(int[] int_22, int[] int_23)
	{
		int num = 0;
		for (int i = 0; i < int_22.Length; i++)
		{
			num += int_22[i] * struct1_0[i].int_1;
		}
		for (int j = 0; j < int_23.Length; j++)
		{
			num += int_23[j] * struct1_1[j].int_1;
		}
		return num;
	}

	internal static Struct1[] smethod_2(int[] int_22)
	{
		Struct1[] array = new Struct1[int_22.Length];
		for (int i = 0; i < int_22.Length; i++)
		{
			array[i].int_1 = int_22[i];
		}
		smethod_3(array);
		return array;
	}

	internal static void smethod_3(Struct1[] struct1_2)
	{
		int num = struct1_2[0].int_1;
		for (int i = 1; i < struct1_2.Length; i++)
		{
			if (num < struct1_2[i].int_1)
			{
				num = struct1_2[i].int_1;
			}
		}
		int[] array = new int[num + 1];
		for (int j = 0; j < struct1_2.Length; j++)
		{
			array[struct1_2[j].int_1]++;
		}
		int[] array2 = new int[num + 1];
		int num2 = 0;
		array[0] = 0;
		for (int k = 1; k <= num; k++)
		{
			num2 = (array2[k] = num2 + array[k - 1] << 1);
		}
		for (int l = 0; l < struct1_2.Length; l++)
		{
			int num3 = struct1_2[l].int_1;
			if (num3 != 0)
			{
				struct1_2[l].int_0 = array2[num3];
				array2[num3]++;
			}
		}
	}

	internal static Class4 smethod_4(Struct1[] struct1_2, Struct1[] struct1_3)
	{
		Class4 @class = new Class4();
		@class.class3_0 = smethod_5(struct1_2);
		@class.class3_1 = smethod_5(struct1_3);
		return @class;
	}

	internal static Class3 smethod_5(Struct1[] struct1_2)
	{
		Struct0[] array = new Struct0[struct1_2.Length];
		int int_ = 0;
		for (int i = 0; i < struct1_2.Length; i++)
		{
			if (struct1_2[i].int_1 > 0)
			{
				Struct0 @struct = default(Struct0);
				@struct.struct1_0 = struct1_2[i];
				@struct.ushort_0 = (ushort)i;
				array[int_++] = @struct;
			}
		}
		if (struct1_2.Length < 1)
		{
			throw new InvalidOperationException();
		}
		return smethod_6(array, int_, 0, 0);
	}

	private static Class3 smethod_6(Struct0[] struct0_0, int int_22, int int_23, int int_24)
	{
		Struct0[] array = new Struct0[int_22];
		Struct0[] array2 = new Struct0[int_22];
		Class3 @class = new Class3();
		@class.bool_0 = false;
		int num = 0;
		int num2 = 0;
		for (int i = 0; i < int_22; i++)
		{
			Struct0 @struct = struct0_0[i];
			if (@struct.struct1_0.int_1 == int_24 && @struct.struct1_0.int_0 == int_23)
			{
				@class.bool_0 = true;
				@class.ushort_0 = @struct.ushort_0;
			}
			else if (((uint)(@struct.struct1_0.int_0 >> @struct.struct1_0.int_1 - int_24 - 1) & (true ? 1u : 0u)) != 0)
			{
				array2[num2++] = @struct;
			}
			else
			{
				array[num++] = @struct;
			}
		}
		if (@class.bool_0)
		{
			if (num2 > 0 || num > 0)
			{
				throw new InvalidOperationException();
			}
		}
		else
		{
			if (num > 0)
			{
				@class.class3_0 = smethod_6(array, num, int_23 << 1, int_24 + 1);
			}
			if (num2 > 0)
			{
				@class.class3_1 = smethod_6(array2, num2, (int_23 << 1) | 1, int_24 + 1);
			}
		}
		return @class;
	}

	internal static void smethod_7(int int_22, out int int_23, out int int_24)
	{
		int_23 = int_18[int_22 - 257];
		int_24 = int_19[int_22 - 257];
	}

	internal static void smethod_8(int int_22, out int int_23, out int int_24, out int int_25)
	{
		//Discarded unreachable code: IL_000b, IL_0010, IL_0015
		_ = int_18;
		/*Error near IL_0006: Read out of bounds.*/;
	}

	internal static void smethod_9(int int_22, out int int_23, out int int_24, out int int_25)
	{
		//Discarded unreachable code: IL_000b, IL_0010, IL_0015
		_ = int_20;
		/*Error near IL_0006: Read out of bounds.*/;
	}

	internal static int[] smethod_10(int[] int_22, int int_23)
	{
		return Class2.smethod_0(int_22, int_23);
	}

	internal static int[] smethod_11(int[] int_22)
	{
		return Class2.smethod_0(int_22, 15);
	}

	internal static int smethod_12(int int_22)
	{
		return int_22 switch
		{
			16 => 2, 
			17 => 3, 
			18 => 7, 
			_ => 0, 
		};
	}

	internal static int[] smethod_13(int[] int_22, int int_23, int int_24)
	{
		ArrayList arrayList = new ArrayList();
		int num = 0;
		while (num < int_24)
		{
			if (int_22[int_23 + num] == 0)
			{
				int num2 = 0;
				do
				{
					num2++;
				}
				while (num + num2 < int_24 && num2 < 138 && int_22[int_23 + num + num2] == 0);
				if (num2 < 3)
				{
					if (num2 >= 1)
					{
						arrayList.Add(0);
					}
					if (num2 >= 2)
					{
						arrayList.Add(0);
					}
				}
				else if (num2 < 11)
				{
					arrayList.Add(17);
					arrayList.Add(num2 - 3);
				}
				else
				{
					arrayList.Add(18);
					arrayList.Add(num2 - 11);
				}
				num += num2;
			}
			else
			{
				int num3 = int_22[int_23 + num++];
				arrayList.Add(num3);
				int i;
				for (i = 0; num + i < int_24 && i < 6 && int_22[int_23 + num + i] == num3; i++)
				{
				}
				if (i >= 3)
				{
					arrayList.Add(16);
					arrayList.Add(i - 3);
					num += i;
				}
			}
		}
		return (int[])arrayList.ToArray(typeof(int));
	}
}
