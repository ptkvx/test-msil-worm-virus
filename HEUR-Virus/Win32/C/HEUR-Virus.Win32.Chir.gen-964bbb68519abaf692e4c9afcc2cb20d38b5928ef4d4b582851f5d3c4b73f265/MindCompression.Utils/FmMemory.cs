using System;
using System.Collections;
using MindCompression.DataObjects;
using MindCompression.Memory;

namespace MindCompression.Utils;

public sealed class FmMemory
{
	public static int cntPlayers = 0;

	public static int cntPlayerCoaches = 0;

	public static int cntCoaches = 0;

	public static int cntCities = 0;

	public static int cntCountries = 0;

	public static int cntTeams = 0;

	private static VersionInfo _version;

	public static VersionInfo Version
	{
		get
		{
			return _version;
		}
		set
		{
			_version = value;
		}
	}

	public static int GetAddress(byte[] buffer, int index)
	{
		int num = 0;
		num = 0 + buffer[index];
		num += buffer[index + 1] * 256;
		num += buffer[index + 2] * 65536;
		return num + buffer[index + 3] * 16777216;
	}

	public static string GetName(ProcessMemory pReader, int addr, int po1, int po2)
	{
		string text = "";
		int bytesRead = 0;
		if (addr >= pReader.ProcessStart && addr <= pReader.ProcessEnd)
		{
			byte[] buffer = pReader.ReadProcessMemory(addr, 48u, out bytesRead);
			if (bytesRead < 48)
			{
				return "";
			}
			if (po1 != -1)
			{
				int address = GetAddress(buffer, po1);
				if (address < pReader.ProcessStart || address > pReader.ProcessEnd)
				{
					return "";
				}
				buffer = pReader.ReadProcessMemory(address, 48u, out bytesRead);
				if (bytesRead < 48)
				{
					return "";
				}
			}
			int address2 = GetAddress(buffer, po2);
			if (address2 >= pReader.ProcessStart && address2 <= pReader.ProcessEnd)
			{
				buffer = pReader.ReadProcessMemory(address2, 96u, out bytesRead);
				if (bytesRead < 96)
				{
					return "";
				}
				for (int i = 0; i < 96 && buffer[i] != 0; i += 2)
				{
					text += Convert.ToChar(buffer[i]);
				}
				return text;
			}
			return "";
		}
		return "";
	}

	public static ArrayList LoadFmMItems(ProcessMemory pReader, byte[] sb)
	{
		ArrayList arrayList = new ArrayList();
		uint num = 65536u;
		int num2 = pReader.ProcessStart;
		int bytesRead = 0;
		int num3 = 0;
		while (num2 < pReader.ProcessEnd)
		{
			byte[] array = pReader.ReadProcessMemory(num2, num, out bytesRead);
			for (int i = 0; i < bytesRead - 16; i += 4)
			{
				if (array[i + 3] != 0 || array[i + 7] != 0 || ((array[i + 2] != sb[2] || array[i + 6] != sb[6]) && (array[i + 2] != sb[10] || array[i + 6] != sb[14]) && (array[i + 2] != sb[18] || array[i + 6] != sb[22]) && (array[i + 2] != sb[34] || array[i + 6] != sb[38])))
				{
					continue;
				}
				if (array[i] == sb[0] && array[i + 1] == sb[1] && array[i + 4] == sb[4] && array[i + 5] == sb[5])
				{
					if (bytesRead > i + 32)
					{
						string name = GetName(pReader, GetAddress(array, i + 28), -1, 8);
						arrayList.Add(new FmObject(num2 + i, name, FmObjectType.City, pReader));
						cntCities++;
					}
					else
					{
						num3 = 32;
					}
				}
				else if (array[i] == sb[8] && array[i + 1] == sb[9] && array[i + 4] == sb[12] && array[i + 5] == sb[13])
				{
					if (bytesRead > i + 256)
					{
						string name2 = GetName(pReader, GetAddress(array, i + 244), 28, 8);
						string name3 = GetName(pReader, GetAddress(array, i + 248), 28, 8);
						string name4 = GetName(pReader, GetAddress(array, i + 252), 28, 8);
						string text = name2 + " " + name3;
						if (!name4.Equals(""))
						{
							text = name4 + " (" + text + ")";
						}
						int id = pReader.ReadInt32(num2 + i + PlayerOffsets.Id);
						arrayList.Add(new FmObject(num2 + i, text, FmObjectType.Player, pReader, id));
						cntPlayers++;
					}
					else
					{
						num3 = 256;
					}
				}
				else if (array[i] == sb[16] && array[i + 1] == sb[17] && array[i + 4] == sb[20] && array[i + 5] == sb[21])
				{
					if (bytesRead > i + 336)
					{
						string name5 = GetName(pReader, GetAddress(array, i + 308), 28, 8);
						string name6 = GetName(pReader, GetAddress(array, i + 312), 28, 8);
						string name7 = GetName(pReader, GetAddress(array, i + 316), 28, 8);
						string text2 = name5 + " " + name6;
						if (!name7.Equals(""))
						{
							text2 = name7 + " (" + text2 + ")";
						}
						int id2 = pReader.ReadInt32(num2 + i + PlayerCoachOffsets.Id);
						arrayList.Add(new FmObject(num2 + i, text2, FmObjectType.PlayerCoach, pReader, id2));
						cntPlayerCoaches++;
					}
					else
					{
						num3 = 336;
					}
				}
				else if (array[i] == sb[24] && array[i + 1] == sb[25] && array[i + 4] == sb[28] && array[i + 5] == sb[29])
				{
					if (bytesRead > i + 112)
					{
						string name8 = GetName(pReader, GetAddress(array, i + 100), 28, 8);
						string name9 = GetName(pReader, GetAddress(array, i + 104), 28, 8);
						string name10 = GetName(pReader, GetAddress(array, i + 108), 28, 8);
						string text3 = name8 + " " + name9;
						if (!name10.Equals(""))
						{
							text3 = name10 + " (" + text3 + ")";
						}
						int id3 = pReader.ReadInt32(num2 + i + CoachOffsets.Id);
						arrayList.Add(new FmObject(num2 + i, text3, FmObjectType.Coach, pReader, id3));
						cntCoaches++;
					}
					else
					{
						num3 = 112;
					}
				}
				else if (array[i] == sb[32] && array[i + 1] == sb[33] && array[i + 4] == sb[36] && array[i + 5] == sb[37])
				{
					if (bytesRead > i + 64)
					{
						string name11 = GetName(pReader, GetAddress(array, i + 44), 32, 8);
						name11 = array[i + 48] switch
						{
							0 => name11 + "", 
							1 => name11 + " Reserves", 
							3 => name11 + " B team", 
							9 => name11 + " Under 23", 
							10 => name11 + " Under 21", 
							11 => name11 + " Under 19", 
							12 => name11 + " Under 18", 
							13 => name11 + " C team", 
							14 => name11 + " Amateur team", 
							16 => name11 + " 2nd team", 
							17 => name11 + " 3rd team", 
							_ => name11 + "[" + array[i + 48] + "]", 
						};
						int id4 = pReader.ReadInt32(num2 + i + TeamOffsets.Id);
						arrayList.Add(new FmObject(num2 + i, name11, FmObjectType.Team, pReader, id4));
						cntTeams++;
					}
					else
					{
						num3 = 64;
					}
				}
				if (array[i] == sb[40] && array[i + 1] == sb[41] && array[i + 4] == sb[44] && array[i + 5] == sb[45])
				{
					if (bytesRead > i + 48)
					{
						string name12 = GetName(pReader, GetAddress(array, i + 32), -1, 8);
						arrayList.Add(new FmObject(num2 + i, name12, FmObjectType.Country, pReader));
						cntCountries++;
					}
					else
					{
						num3 = 48;
					}
				}
			}
			num2 += (int)num - num3;
			num3 = 0;
		}
		return arrayList;
	}
}
