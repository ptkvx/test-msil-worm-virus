using System;
using System.Diagnostics;
using System.Security.Cryptography;
using Microsoft.VisualBasic.CompilerServices;

[StandardModule]
internal sealed class Pass
{
	public class RandomPassword
	{
		private static int DEFAULT_MIN_PASSWORD_LENGTH = 8;

		private static int DEFAULT_MAX_PASSWORD_LENGTH = 10;

		private static string PASSWORD_CHARS_LCASE = "abcdefgijkmnopqrstwxyz";

		private static string PASSWORD_CHARS_UCASE = "ABCDEFGHJKLMNPQRSTWXYZ";

		private static string PASSWORD_CHARS_NUMERIC = "0123456789";

		private static string PASSWORD_CHARS_SPECIAL = "*$-+?_&=!%{}/";

		[DebuggerNonUserCode]
		public RandomPassword()
		{
		}

		public static string Generate()
		{
			return Generate(DEFAULT_MIN_PASSWORD_LENGTH, DEFAULT_MAX_PASSWORD_LENGTH);
		}

		public static string Generate(int length)
		{
			return Generate(length, length);
		}

		public static string Generate(int minLength, int maxLength)
		{
			if (minLength <= 0 || maxLength <= 0 || minLength > maxLength)
			{
				string text = null;
			}
			char[][] array = new char[4][]
			{
				PASSWORD_CHARS_LCASE.ToCharArray(),
				PASSWORD_CHARS_UCASE.ToCharArray(),
				PASSWORD_CHARS_NUMERIC.ToCharArray(),
				PASSWORD_CHARS_SPECIAL.ToCharArray()
			};
			checked
			{
				int[] array2 = new int[array.Length - 1 + 1];
				int num = array2.Length - 1;
				for (int i = 0; i <= num; i++)
				{
					array2[i] = array[i].Length;
				}
				int[] array3 = new int[array.Length - 1 + 1];
				int num2 = array3.Length - 1;
				for (int i = 0; i <= num2; i++)
				{
					array3[i] = i;
				}
				byte[] array4 = new byte[4];
				RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
				rNGCryptoServiceProvider.GetBytes(array4);
				int seed = unchecked(((array4[0] & 0x7F) << 24) | (byte)(array4[1] << 0) | (byte)(array4[2] << 0)) | array4[3];
				Random random = new Random(seed);
				char[] array5 = null;
				array5 = ((minLength >= maxLength) ? new char[minLength - 1 + 1] : new char[random.Next(minLength - 1, maxLength) + 1]);
				int num3 = array3.Length - 1;
				int num4 = array5.Length - 1;
				for (int i = 0; i <= num4; i++)
				{
					int num5 = ((num3 != 0) ? random.Next(0, num3) : 0);
					int num6 = array3[num5];
					int num7 = array2[num6] - 1;
					int num8 = ((num7 != 0) ? random.Next(0, num7 + 1) : 0);
					array5[i] = array[num6][num8];
					if (num7 == 0)
					{
						array2[num6] = array[num6].Length;
					}
					else
					{
						if (num7 != num8)
						{
							char c = array[num6][num7];
							array[num6][num7] = array[num6][num8];
							array[num6][num8] = c;
						}
						array2[num6]--;
					}
					if (num3 == 0)
					{
						num3 = array3.Length - 1;
						continue;
					}
					if (num3 != num5)
					{
						int num9 = array3[num3];
						array3[num3] = array3[num5];
						array3[num5] = num9;
					}
					num3--;
				}
				return new string(array5);
			}
		}
	}
}
