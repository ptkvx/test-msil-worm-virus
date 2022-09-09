using System;
using System.Text;

public class CD
{
	public static string format(string input)
	{
		StringBuilder stringBuilder = new StringBuilder();
		string[] array = SplitString(input, 50000L);
		checked
		{
			int num = array.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				if (i == array.Length - 1)
				{
					stringBuilder.Append("\"" + array[i] + "\"");
				}
				else
				{
					stringBuilder.Append("\"" + array[i] + "\" & _\r\n");
				}
			}
			return stringBuilder.ToString();
		}
	}

	private static string[] SplitString(string input, long partsize)
	{
		checked
		{
			long num = (long)Math.Round(Math.Ceiling((double)input.Length / (double)partsize));
			string[] array = new string[(int)(num - 1L) + 1];
			long num2 = 0L;
			int num3 = (int)(num - 1L);
			for (int i = 0; i <= num3; i++)
			{
				if (i == num - 1L)
				{
					char[] array2 = new char[(int)(input.Length - num2 - 1L) + 1];
					input.CopyTo((int)num2, array2, 0, (int)(input.Length - num2));
					array[i] = Convert.ToString(new string(array2));
				}
				else
				{
					char[] array3 = new char[(int)(partsize - 1L) + 1];
					input.CopyTo((int)num2, array3, 0, (int)partsize);
					array[i] = Convert.ToString(new string(array3));
					num2 += partsize;
				}
			}
			return array;
		}
	}
}
