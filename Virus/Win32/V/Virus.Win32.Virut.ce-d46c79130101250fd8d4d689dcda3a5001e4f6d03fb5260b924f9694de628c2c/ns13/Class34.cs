using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;

namespace ns13;

internal sealed class Class34
{
	internal delegate uint Delegate12([MarshalAs(UnmanagedType.U8)] ref ulong ulong_0, IntPtr intptr_0, IntPtr intptr_1, [MarshalAs(UnmanagedType.U4)] uint uint_0, ref IntPtr intptr_2, ref uint uint_1);

	internal struct Struct16
	{
		internal bool bool_0;

		internal byte[] byte_0;
	}

	private static byte[] byte_0;

	private static byte[] byte_1;

	private static byte[] byte_2;

	private static IntPtr intptr_0;

	private static bool bool_0;

	private static int int_0;

	internal static Delegate12 delegate12_0;

	private static long long_0;

	private static bool bool_1;

	private static SortedList sortedList_0;

	private static byte[] byte_3;

	private static int int_1;

	internal static Dictionary<long, Struct16> dictionary_0;

	private static long long_1;

	private static IntPtr intptr_1;

	private static object object_0;

	private static IntPtr intptr_2;

	private static int int_2;

	private static int[] int_3;

	private static int int_4;

	internal static Delegate12 delegate12_1;

	static Class34()
	{
		byte_0 = new byte[0];
		byte_1 = new byte[0];
		byte_3 = new byte[0];
		byte_2 = new byte[0];
		intptr_2 = IntPtr.Zero;
		intptr_0 = IntPtr.Zero;
		object_0 = new string[0];
		int_3 = new int[0];
		int_2 = 1;
		bool_0 = false;
		sortedList_0 = new SortedList();
		int_0 = 0;
		long_1 = 0L;
		delegate12_1 = null;
		delegate12_0 = null;
		long_0 = 0L;
		int_1 = 0;
		bool_1 = false;
		int_4 = 0;
		intptr_1 = IntPtr.Zero;
		dictionary_0 = new Dictionary<long, Struct16>();
	}

	static string smethod_0(int int_5)
	{
		int num = 233;
		byte[] array = default(byte[]);
		int int_6 = default(int);
		int num2 = default(int);
		byte[] array2 = default(byte[]);
		int num3 = default(int);
		byte[] object_4 = default(byte[]);
		CryptoStream object_ = default(CryptoStream);
		MemoryStream memoryStream = default(MemoryStream);
		ICryptoTransform transform = default(ICryptoTransform);
		byte[] array4 = default(byte[]);
		byte[] array5 = default(byte[]);
		RijndaelManaged object_3 = default(RijndaelManaged);
		byte[] array3 = default(byte[]);
		BinaryReader object_2 = default(BinaryReader);
		while (true)
		{
			IL_20eb:
			if (byte_3.Length == 0)
			{
				num = 193;
				goto IL_1789;
			}
			goto IL_20bb;
			IL_18c1:
			array[15] = 90;
			goto IL_00b8;
			IL_20bb:
			int_6 = smethod_17(byte_3, int_5);
			num = 344;
			if (!smethod_21())
			{
				goto IL_195f;
			}
			goto IL_2087;
			IL_2087:
			num2 = 110;
			num = 141;
			goto IL_1f8d;
			IL_1f8d:
			array2[2] = (byte)num2;
			num = 79;
			goto IL_1f79;
			IL_1f79:
			num2 = 134;
			num = 175;
			goto IL_1f69;
			IL_1f69:
			array2[3] = (byte)num2;
			goto IL_1f58;
			IL_1f58:
			array2[3] = 168;
			goto IL_1f4a;
			IL_1f4a:
			array2[3] = 102;
			goto IL_1f36;
			IL_1f36:
			num2 = 152;
			num = 280;
			goto IL_1f26;
			IL_1f26:
			array2[3] = (byte)num2;
			goto IL_1f0c;
			IL_1f0c:
			array2[3] = 129;
			num = 330;
			goto IL_1ef5;
			IL_1ef5:
			array2[3] = 58;
			num = 190;
			goto IL_1ed1;
			IL_1ed1:
			array2[4] = 87;
			num = 70;
			if (smethod_21())
			{
				goto IL_000e;
			}
			goto IL_195f;
			IL_000e:
			num3 = 159;
			goto IL_0017;
			IL_0017:
			array[20] = (byte)num3;
			num = 227;
			goto IL_002e;
			IL_002e:
			array[20] = 53;
			num = 135;
			if (!smethod_20())
			{
				goto IL_004d;
			}
			goto IL_195f;
			IL_195f:
			while (true)
			{
				switch (num)
				{
				case 252:
					break;
				case 137:
					goto IL_0017;
				case 227:
					goto IL_002e;
				case 46:
					goto IL_004d;
				case 176:
					goto IL_005f;
				case 223:
					goto IL_0076;
				case 342:
					goto IL_007c;
				case 326:
					goto IL_0093;
				case 207:
					goto IL_009f;
				case 138:
					goto IL_00b8;
				case 338:
					goto IL_00ca;
				case 128:
					goto IL_00e1;
				case 230:
					goto IL_00f6;
				case 260:
					goto IL_0102;
				case 232:
					goto IL_0117;
				case 266:
					goto IL_012c;
				case 317:
					goto IL_013e;
				case 323:
					goto IL_015f;
				case 8:
					goto IL_0178;
				case 131:
					goto IL_0181;
				case 274:
					goto IL_0198;
				case 212:
					goto IL_01b0;
				case 246:
					goto IL_01c9;
				case 144:
					goto IL_01e5;
				case 106:
					goto IL_01f7;
				case 331:
					goto IL_020e;
				case 277:
					goto IL_021d;
				case 14:
					goto IL_0234;
				case 183:
					goto IL_0249;
				case 0:
					goto IL_0258;
				case 208:
					goto IL_025e;
				case 75:
					goto IL_026c;
				case 151:
					goto IL_0281;
				case 155:
				case 321:
					goto IL_02a0;
				case 241:
					goto IL_02a6;
				case 55:
					goto IL_02b4;
				case 161:
					goto IL_02c3;
				case 157:
					goto IL_02d1;
				case 2:
					goto IL_02f0;
				case 121:
					goto IL_030f;
				case 229:
					goto IL_0315;
				case 222:
					goto IL_032c;
				case 303:
					goto IL_0338;
				case 38:
					goto IL_0350;
				case 262:
					goto IL_0356;
				case 68:
					goto IL_0364;
				case 117:
					goto IL_0373;
				case 173:
					goto IL_0394;
				case 36:
					goto IL_03a3;
				case 113:
					goto IL_03ba;
				case 9:
					goto IL_03d2;
				case 90:
					goto IL_03d8;
				case 136:
					goto IL_040b;
				case 313:
					goto IL_041a;
				case 308:
					goto IL_0431;
				case 293:
					goto IL_0453;
				case 329:
					goto IL_045f;
				case 122:
					goto IL_0465;
				case 5:
					goto IL_047c;
				case 286:
					goto IL_0482;
				case 310:
					goto IL_0490;
				case 324:
					goto IL_04a8;
				case 10:
					goto IL_04b7;
				case 3:
					goto IL_04ce;
				case 168:
					goto IL_04e3;
				case 283:
					goto IL_04ef;
				case 111:
					goto IL_0507;
				case 292:
					goto IL_051b;
				case 174:
					goto IL_052a;
				case 132:
					goto IL_054b;
				case 43:
					goto IL_055d;
				case 28:
					goto IL_056b;
				case 83:
					goto IL_057a;
				case 264:
					goto IL_0591;
				case 30:
					goto IL_059c;
				case 145:
					goto IL_05b4;
				case 60:
					goto IL_05c6;
				case 195:
					goto IL_05dd;
				case 97:
					goto IL_05f2;
				case 322:
					goto IL_0607;
				case 134:
					goto IL_061f;
				case 307:
					goto IL_062e;
				case 45:
					goto IL_0646;
				case 328:
					goto IL_0658;
				case 126:
					goto IL_066f;
				case 273:
					goto IL_0684;
				case 24:
					goto IL_0690;
				case 102:
					goto IL_06a5;
				case 188:
					goto IL_06b4;
				case 171:
					goto IL_06d5;
				case 270:
					goto IL_06de;
				case 1:
					goto IL_06ec;
				case 42:
					goto IL_06fe;
				case 316:
					goto IL_0715;
				case 129:
					goto IL_072a;
				case 139:
					goto IL_0739;
				case 224:
					goto IL_074e;
				case 247:
					goto IL_0770;
				case 211:
					goto IL_0788;
				case 305:
					goto IL_079d;
				case 118:
					goto IL_07bc;
				case 334:
					goto IL_07c8;
				case 295:
					goto IL_07ce;
				case 119:
					goto IL_07dc;
				case 279:
					goto IL_07eb;
				case 89:
					goto IL_07f6;
				case 268:
					goto IL_0805;
				case 21:
					goto IL_081c;
				case 148:
					goto IL_0828;
				case 253:
					goto IL_082e;
				case 127:
					goto IL_084f;
				case 153:
					goto IL_086b;
				case 66:
					goto IL_087e;
				case 80:
					goto IL_08a4;
				case 107:
					goto IL_08b3;
				case 320:
					goto IL_08ca;
				case 115:
					goto IL_08d3;
				case 300:
					goto IL_08ea;
				case 147:
					goto IL_08f3;
				case 104:
					goto IL_090a;
				case 48:
					goto IL_091f;
				case 288:
					goto IL_093a;
				case 33:
					goto IL_094c;
				case 244:
					goto IL_0963;
				case 73:
					goto IL_096f;
				case 64:
					goto IL_0987;
				case 219:
					goto IL_0990;
				case 37:
					goto IL_09a7;
				case 94:
					goto IL_09c0;
				case 108:
					goto IL_09c9;
				case 325:
					goto IL_09e0;
				case 110:
					goto IL_09f6;
				case 179:
					goto IL_09ff;
				case 56:
					goto IL_0a0d;
				case 99:
					goto IL_0a2c;
				case 228:
					goto IL_0a49;
				case 149:
					goto IL_0a60;
				case 257:
					goto IL_0a6c;
				case 301:
					goto IL_0a84;
				case 109:
					goto IL_0a8d;
				case 152:
					goto IL_0aa4;
				case 120:
					goto IL_0ab0;
				case 214:
					goto IL_0ac2;
				case 84:
					goto IL_0ad0;
				case 204:
					goto IL_0ae5;
				case 304:
					goto IL_0af7;
				case 258:
					goto IL_0b0e;
				case 343:
					goto IL_0b23;
				case 340:
					num3 = 104;
					num = 162;
					goto case 162;
				case 162:
					array[17] = (byte)num3;
					goto case 261;
				case 261:
					array[17] = 100;
					goto case 234;
				case 234:
					num3 = 85;
					num = 166;
					goto case 166;
				case 166:
					array[18] = (byte)num3;
					num = 199;
					goto case 199;
				case 199:
					array[18] = 109;
					num = 130;
					if (smethod_20())
					{
						continue;
					}
					goto case 339;
				case 339:
					array[31] = (byte)num3;
					goto case 231;
				case 231:
					num3 = 126;
					num = 296;
					goto case 296;
				case 296:
					array[31] = (byte)num3;
					num = 332;
					goto case 332;
				case 332:
					array[31] = 138;
					goto case 95;
				case 95:
					num3 = 101;
					goto case 53;
				case 53:
					array[31] = (byte)num3;
					num = 63;
					goto case 63;
				case 63:
					object_4 = array;
					num = 25;
					goto case 25;
				case 25:
					array2 = new byte[16];
					num = 172;
					goto case 172;
				case 172:
					num2 = 96;
					num = 216;
					goto case 216;
				case 216:
					array2[0] = (byte)num2;
					num = 271;
					goto case 271;
				case 271:
					array2[0] = 158;
					goto case 20;
				case 20:
					num2 = 92;
					num = 281;
					goto case 281;
				case 281:
					array2[0] = (byte)num2;
					num = 72;
					goto case 72;
				case 72:
					array2[0] = 168;
					num = 26;
					goto case 26;
				case 26:
					num2 = 107;
					num = 123;
					goto case 123;
				case 123:
					array2[1] = (byte)num2;
					num = 39;
					if (smethod_21())
					{
						goto IL_06b4;
					}
					goto case 39;
				case 39:
					num2 = 157;
					num = 87;
					goto case 87;
				case 87:
					array2[1] = (byte)num2;
					num = 221;
					if (smethod_20())
					{
						continue;
					}
					goto IL_03ba;
				case 335:
					array[30] = (byte)num3;
					num = 41;
					goto case 41;
				case 41:
					num3 = 162;
					goto case 52;
				case 52:
					array[30] = (byte)num3;
					num = 74;
					goto case 74;
				case 74:
					array[30] = 67;
					num = 100;
					if (smethod_20())
					{
						continue;
					}
					goto IL_025e;
				case 327:
					num3 = 109;
					num = 114;
					if (!smethod_21())
					{
						continue;
					}
					goto IL_02c3;
				case 319:
					array[6] = 130;
					num = 255;
					goto case 255;
				case 255:
					array[6] = 192;
					num = 315;
					goto case 315;
				case 315:
					array[6] = 25;
					num = 18;
					if (smethod_20())
					{
						continue;
					}
					goto case 220;
				case 220:
					object_ = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
					num = 187;
					if (smethod_20())
					{
						continue;
					}
					goto case 53;
				case 318:
					array[25] = 40;
					num = 242;
					goto case 242;
				case 242:
					array[25] = 110;
					num = 265;
					if (!smethod_21())
					{
						continue;
					}
					goto IL_189b;
				case 11:
					array4[13] = array5[6];
					num = 51;
					if (smethod_21())
					{
						goto case 19;
					}
					goto case 51;
				case 19:
					num3 = 119;
					num = 201;
					goto case 201;
				case 201:
					array[29] = (byte)num3;
					num = 194;
					goto case 194;
				case 194:
					array[29] = 156;
					num = 165;
					goto case 165;
				case 165:
					num3 = 122;
					num = 178;
					goto case 178;
				case 178:
					array[29] = (byte)num3;
					goto case 35;
				case 35:
					num3 = 128;
					goto case 185;
				case 185:
					array[29] = (byte)num3;
					num = 298;
					if (!smethod_21())
					{
						continue;
					}
					goto case 198;
				case 198:
					if (array5 != null)
					{
						num = 142;
						goto case 142;
					}
					goto case 272;
				case 142:
					if (array5.Length > 0)
					{
						goto case 156;
					}
					goto case 272;
				case 156:
					array4[1] = array5[0];
					goto case 29;
				case 29:
					array4[3] = array5[1];
					num = 235;
					goto case 235;
				case 235:
					array4[5] = array5[2];
					num = 306;
					goto case 306;
				case 306:
					array4[7] = array5[3];
					goto case 86;
				case 86:
					array4[9] = array5[4];
					num = 314;
					goto case 314;
				case 314:
					array4[11] = array5[5];
					num = 11;
					goto case 11;
				case 51:
					array4[15] = array5[7];
					num = 272;
					if (smethod_21())
					{
						goto case 26;
					}
					goto case 272;
				case 272:
					object_3 = new RijndaelManaged();
					num = 275;
					goto case 275;
				case 275:
					smethod_10(object_3, CipherMode.CBC);
					goto case 238;
				case 238:
					transform = (ICryptoTransform)smethod_11(object_3, object_4, array4);
					num = 150;
					goto case 150;
				case 150:
					memoryStream = new MemoryStream();
					num = 220;
					goto case 220;
				case 312:
					array[26] = 169;
					goto case 13;
				case 13:
					array[27] = 166;
					num = 196;
					if (!smethod_20())
					{
						goto case 130;
					}
					goto case 196;
				case 130:
					array[18] = 127;
					num = 327;
					goto case 327;
				case 196:
					num3 = 106;
					num = 133;
					goto case 133;
				case 133:
					array[27] = (byte)num3;
					num = 127;
					goto IL_084f;
				case 309:
					array[24] = (byte)num3;
					num = 318;
					goto case 318;
				case 302:
					array[8] = 120;
					num = 76;
					if (smethod_20())
					{
						continue;
					}
					goto IL_062e;
				case 299:
					smethod_15(memoryStream);
					num = 269;
					if (smethod_20())
					{
						continue;
					}
					goto case 248;
				case 298:
					num3 = 136;
					goto case 335;
				case 294:
					num3 = 169;
					num = 159;
					if (!smethod_20())
					{
						goto IL_040b;
					}
					goto case 159;
				case 159:
					array[26] = (byte)num3;
					goto case 215;
				case 215:
					num3 = 143;
					num = 140;
					if (!smethod_21())
					{
						continue;
					}
					goto case 146;
				case 290:
					num3 = 162;
					num = 71;
					goto case 71;
				case 71:
					array[5] = (byte)num3;
					num = 319;
					if (!smethod_21())
					{
						continue;
					}
					goto IL_0b23;
				case 289:
					array[31] = 169;
					goto case 4;
				case 4:
					num3 = 87;
					num = 339;
					goto case 339;
				case 285:
					array[8] = 102;
					_ = 0;
					if (smethod_20())
					{
						num = 92;
						goto case 54;
					}
					goto IL_02a0;
				case 54:
				case 92:
					num3 = 159;
					num = 12;
					goto case 12;
				case 12:
					array[8] = (byte)num3;
					num = 240;
					goto case 240;
				case 240:
					num3 = 148;
					goto IL_087e;
				case 282:
					array[24] = (byte)num3;
					num = 167;
					goto case 167;
				case 167:
					array[24] = 148;
					goto case 93;
				case 93:
					num3 = 170;
					num = 309;
					if (!smethod_21())
					{
						continue;
					}
					goto IL_02c3;
				case 276:
					array[18] = 68;
					num = 243;
					if (!smethod_21())
					{
						continue;
					}
					goto IL_09e0;
				case 265:
					array[25] = 217;
					goto case 294;
				case 263:
					array[7] = (byte)num3;
					num = 206;
					goto case 206;
				case 206:
					array[8] = 160;
					goto case 285;
				case 259:
					array2[11] = 97;
					num = 110;
					goto IL_09f6;
				case 250:
					array2[5] = (byte)num2;
					num = 6;
					if (smethod_21())
					{
						goto IL_08b3;
					}
					goto case 6;
				case 6:
					num2 = 34;
					goto case 78;
				case 78:
					array2[5] = (byte)num2;
					goto case 67;
				case 67:
					array2[5] = 89;
					num = 91;
					goto case 91;
				case 91:
					array2[5] = 26;
					num = 132;
					goto IL_054b;
				case 243:
					array[19] = 142;
					num = 284;
					if (!smethod_21())
					{
						continue;
					}
					goto case 184;
				case 239:
					num3 = 112;
					goto case 282;
				case 237:
					array[7] = 49;
					goto case 236;
				case 236:
					num3 = 161;
					num = 263;
					if (!smethod_20())
					{
						goto IL_021d;
					}
					goto case 263;
				case 213:
					array[30] = 215;
					num = 289;
					goto case 289;
				case 210:
					num3 = 104;
					goto case 81;
				case 81:
					array[26] = (byte)num3;
					num = 312;
					goto case 312;
				case 205:
					array[4] = (byte)num3;
					num = 17;
					goto case 17;
				case 17:
					array[5] = 107;
					goto case 23;
				case 23:
					array[5] = 158;
					num = 7;
					goto case 7;
				case 7:
					num3 = 236;
					num = 169;
					if (smethod_20())
					{
						continue;
					}
					goto IL_0373;
				case 202:
					smethod_13(object_);
					num = 57;
					goto case 57;
				case 57:
					byte_3 = (byte[])smethod_14(memoryStream);
					num = 299;
					goto case 299;
				case 200:
					num3 = 158;
					goto case 34;
				case 34:
					array[28] = (byte)num3;
					num = 31;
					goto case 31;
				case 31:
					array[28] = 171;
					num = 19;
					if (!smethod_21())
					{
						continue;
					}
					goto case 159;
				case 189:
					array[24] = 121;
					num = 239;
					goto case 239;
				case 187:
					smethod_12(object_, array3, 0, array3.Length);
					num = 202;
					goto case 202;
				case 169:
					array[5] = (byte)num3;
					num = 290;
					if (smethod_20())
					{
						continue;
					}
					goto IL_0990;
				case 158:
					array2[11] = (byte)num2;
					num = 259;
					goto case 259;
				case 140:
					array[26] = (byte)num3;
					num = 210;
					goto case 210;
				case 116:
					array[28] = (byte)num3;
					num = 200;
					goto case 200;
				case 114:
					array[18] = (byte)num3;
					num = 276;
					goto case 276;
				case 112:
					array[1] = (byte)num3;
					goto IL_0770;
				case 100:
					array[30] = 130;
					num = 213;
					if (!smethod_21())
					{
						goto case 213;
					}
					goto case 186;
				case 76:
					array[9] = 69;
					num = 94;
					goto IL_09c0;
				case 70:
					array2[4] = 123;
					num = 256;
					if (smethod_20())
					{
						continue;
					}
					goto case 341;
				case 69:
					array[17] = (byte)num3;
					num = 340;
					goto case 340;
				case 22:
					num2 = 118;
					num = 158;
					goto case 158;
				case 18:
					array[7] = 118;
					num = 237;
					if (smethod_20())
					{
						continue;
					}
					goto case 265;
				default:
					num = 215;
					goto case 215;
				case 15:
					num2 = 38;
					goto case 251;
				case 251:
					array2[12] = (byte)num2;
					num = 184;
					goto case 184;
				case 184:
					array2[12] = 151;
					num = 82;
					goto case 82;
				case 82:
					array2[12] = 85;
					goto case 197;
				case 197:
					num2 = 146;
					num = 218;
					goto case 218;
				case 218:
					array2[12] = (byte)num2;
					num = 203;
					goto case 203;
				case 203:
					num2 = 164;
					num = 32;
					goto case 32;
				case 32:
					array2[13] = (byte)num2;
					num = 287;
					goto case 287;
				case 287:
					array2[13] = 120;
					num = 225;
					goto case 225;
				case 225:
					num2 = 138;
					num = 49;
					goto case 49;
				case 49:
					array2[13] = (byte)num2;
					num = 105;
					goto case 105;
				case 105:
					array2[13] = 111;
					num = 62;
					goto case 62;
				case 62:
					array2[14] = 160;
					num = 121;
					goto IL_030f;
				case 226:
					num3 = 158;
					num = 16;
					goto case 16;
				case 16:
					array[23] = (byte)num3;
					goto IL_02a0;
				case 135:
					array[20] = 120;
					num = 341;
					goto case 341;
				case 341:
					array[20] = 96;
					num = 336;
					goto case 336;
				case 336:
					num3 = 233;
					num = 170;
					goto case 170;
				case 170:
					array[20] = (byte)num3;
					num = 65;
					goto case 65;
				case 65:
					num3 = 99;
					num = 58;
					goto case 58;
				case 58:
					array[21] = (byte)num3;
					goto case 125;
				case 125:
					array[21] = 155;
					num = 144;
					goto IL_01e5;
				case 256:
					array2[4] = 77;
					num = 246;
					goto IL_01c9;
				case 193:
					goto IL_1789;
				case 154:
					goto IL_17a9;
				case 333:
					goto IL_17c7;
				case 50:
					goto IL_17cd;
				case 191:
					goto IL_17e3;
				case 47:
					goto IL_17fa;
				case 181:
					goto IL_1809;
				case 44:
					goto IL_1820;
				case 101:
					goto IL_1832;
				case 96:
					goto IL_1849;
				case 278:
					goto IL_1858;
				case 180:
					goto IL_186f;
				case 103:
					goto IL_188c;
				case 164:
					goto IL_189b;
				case 59:
					goto IL_18b2;
				case 85:
					goto IL_18c1;
				case 192:
					array[16] = (byte)num3;
					goto IL_004d;
				case 284:
					array[19] = 93;
					num = 217;
					goto case 217;
				case 217:
					num3 = 168;
					goto case 146;
				case 146:
					array[19] = (byte)num3;
					num = 249;
					goto case 249;
				case 249:
					num3 = 130;
					goto case 209;
				case 209:
					array[19] = (byte)num3;
					num = 177;
					goto IL_193a;
				case 177:
					goto IL_193a;
				case 40:
					goto IL_1943;
				case 190:
					goto IL_1ed1;
				case 330:
					goto IL_1ef5;
				case 291:
					goto IL_1f0c;
				case 280:
					goto IL_1f26;
				case 267:
					goto IL_1f36;
				case 245:
					goto IL_1f4a;
				case 77:
					goto IL_1f58;
				case 175:
					goto IL_1f69;
				case 79:
					goto IL_1f79;
				case 141:
					goto IL_1f8d;
				case 221:
					num2 = 135;
					goto case 297;
				case 297:
					array2[1] = (byte)num2;
					num = 124;
					if (smethod_20())
					{
						goto case 124;
					}
					goto IL_20bb;
				case 124:
					array2[1] = 171;
					num = 186;
					goto case 186;
				case 186:
					num2 = 110;
					goto case 160;
				case 160:
					array2[1] = (byte)num2;
					goto case 311;
				case 311:
					num2 = 77;
					num = 163;
					goto case 163;
				case 163:
					array2[1] = (byte)num2;
					goto case 27;
				case 27:
					array2[2] = 10;
					goto case 248;
				case 248:
					array2[2] = 246;
					num = 61;
					goto case 61;
				case 61:
					array2[2] = 126;
					num = 254;
					goto case 254;
				case 254:
					array2[2] = 95;
					goto case 88;
				case 88:
					num2 = 175;
					num = 143;
					goto case 143;
				case 143:
					array2[2] = (byte)num2;
					num = 98;
					goto IL_2087;
				case 98:
					goto IL_2087;
				case 269:
					smethod_15(object_);
					num = 337;
					goto case 337;
				case 337:
					smethod_16(object_2);
					num = 182;
					goto IL_20bb;
				case 182:
					goto IL_20bb;
				case 233:
					goto IL_20eb;
				case 344:
					goto end_IL_20eb;
				}
				break;
			}
			goto IL_000e;
			IL_1789:
			object_2 = new BinaryReader((Stream)smethod_2(smethod_1(typeof(Class34).TypeHandle).Assembly, "8SFLhV3TDVdAPqjLLW.vFCXRvIkorVLyJYGcH"));
			goto IL_17a9;
			IL_17a9:
			smethod_4(smethod_3(object_2), 0L);
			num = 333;
			goto IL_17c7;
			IL_17c7:
			smethod_5(bool_2: true);
			goto IL_17cd;
			IL_17cd:
			array3 = (byte[])smethod_7(object_2, (int)smethod_6(smethod_3(object_2)));
			goto IL_17e3;
			IL_17e3:
			array = new byte[32];
			num = 47;
			goto IL_17fa;
			IL_17fa:
			num3 = 96;
			num = 181;
			goto IL_1809;
			IL_1809:
			array[0] = (byte)num3;
			num = 44;
			goto IL_1820;
			IL_1820:
			num3 = 153;
			num = 101;
			goto IL_1832;
			IL_1832:
			array[0] = (byte)num3;
			num = 96;
			goto IL_1849;
			IL_1849:
			num3 = 105;
			num = 278;
			goto IL_1858;
			IL_1858:
			array[0] = (byte)num3;
			num = 180;
			goto IL_186f;
			IL_186f:
			array[0] = 197;
			num = 8;
			goto IL_0178;
			IL_004d:
			num3 = 156;
			num = 176;
			goto IL_005f;
			IL_005f:
			array[17] = (byte)num3;
			num = 223;
			goto IL_0076;
			IL_0076:
			num3 = 94;
			goto IL_007c;
			IL_007c:
			array[17] = (byte)num3;
			num = 326;
			goto IL_0093;
			IL_0093:
			array[17] = 66;
			goto IL_009f;
			IL_009f:
			num3 = 90;
			num = 69;
			if (smethod_21())
			{
				goto IL_00b8;
			}
			goto IL_195f;
			IL_00b8:
			num3 = 142;
			num = 338;
			goto IL_00ca;
			IL_00ca:
			array[15] = (byte)num3;
			num = 128;
			goto IL_00e1;
			IL_00e1:
			array[15] = 116;
			num = 230;
			goto IL_00f6;
			IL_00f6:
			array[15] = 123;
			goto IL_0102;
			IL_0102:
			array[16] = 105;
			num = 232;
			goto IL_0117;
			IL_0117:
			array[16] = 82;
			num = 266;
			goto IL_012c;
			IL_012c:
			num3 = 169;
			num = 317;
			goto IL_013e;
			IL_013e:
			array[16] = (byte)num3;
			num = 323;
			if (smethod_20())
			{
				goto IL_015f;
			}
			goto IL_045f;
			IL_015f:
			num3 = 15;
			num = 192;
			if (!smethod_20())
			{
				goto IL_0178;
			}
			goto IL_195f;
			IL_0178:
			num3 = 179;
			goto IL_0181;
			IL_0181:
			array[0] = (byte)num3;
			num = 274;
			goto IL_0198;
			IL_0198:
			array[0] = 205;
			num = 212;
			goto IL_01b0;
			IL_01b0:
			num3 = 124;
			num = 112;
			if (smethod_21())
			{
				goto IL_01c9;
			}
			goto IL_195f;
			IL_01c9:
			num2 = 170;
			num = 250;
			if (smethod_21())
			{
				goto IL_01e5;
			}
			goto IL_195f;
			IL_01e5:
			num3 = 148;
			num = 106;
			goto IL_01f7;
			IL_01f7:
			array[21] = (byte)num3;
			num = 331;
			goto IL_020e;
			IL_020e:
			num3 = 93;
			num = 277;
			goto IL_021d;
			IL_021d:
			array[22] = (byte)num3;
			num = 14;
			goto IL_0234;
			IL_0234:
			array[22] = 118;
			num = 183;
			goto IL_0249;
			IL_0249:
			array[22] = 149;
			goto IL_0258;
			IL_0258:
			num3 = 109;
			goto IL_025e;
			IL_025e:
			array[22] = (byte)num3;
			goto IL_026c;
			IL_026c:
			array[22] = 77;
			num = 151;
			goto IL_0281;
			IL_0281:
			array[23] = 120;
			num = 226;
			if (smethod_21())
			{
				goto IL_02a0;
			}
			goto IL_195f;
			IL_02a0:
			num3 = 114;
			goto IL_02a6;
			IL_02a6:
			array[23] = (byte)num3;
			goto IL_02b4;
			IL_02b4:
			num3 = 77;
			num = 161;
			goto IL_02c3;
			IL_02c3:
			array[23] = (byte)num3;
			goto IL_02d1;
			IL_02d1:
			array[23] = 9;
			num = 2;
			if (smethod_21())
			{
				goto IL_025e;
			}
			goto IL_02f0;
			IL_02f0:
			array[24] = 97;
			num = 189;
			if (smethod_21())
			{
				goto IL_030f;
			}
			goto IL_195f;
			IL_030f:
			num2 = 103;
			goto IL_0315;
			IL_0315:
			array2[14] = (byte)num2;
			num = 222;
			goto IL_032c;
			IL_032c:
			array2[14] = 90;
			goto IL_0338;
			IL_0338:
			array2[14] = 199;
			num = 38;
			goto IL_0350;
			IL_0350:
			num2 = 106;
			goto IL_0356;
			IL_0356:
			array2[14] = (byte)num2;
			goto IL_0364;
			IL_0364:
			num2 = 106;
			num = 117;
			goto IL_0373;
			IL_0373:
			array2[15] = (byte)num2;
			num = 173;
			if (!smethod_21())
			{
				goto IL_0394;
			}
			goto IL_1f79;
			IL_0394:
			num2 = 113;
			num = 36;
			goto IL_03a3;
			IL_03a3:
			array2[15] = (byte)num2;
			num = 113;
			goto IL_03ba;
			IL_03ba:
			array2[15] = 151;
			num = 9;
			goto IL_03d2;
			IL_03d2:
			array4 = array2;
			goto IL_03d8;
			IL_03d8:
			array5 = (byte[])smethod_9(smethod_8(smethod_1(typeof(Class34).TypeHandle).Assembly));
			num = 198;
			if (smethod_21())
			{
				goto IL_0281;
			}
			goto IL_195f;
			IL_045f:
			num3 = 95;
			goto IL_0465;
			IL_0465:
			array[12] = (byte)num3;
			num = 5;
			goto IL_047c;
			IL_047c:
			num3 = 120;
			goto IL_0482;
			IL_0482:
			array[12] = (byte)num3;
			goto IL_0490;
			IL_0490:
			array[12] = 156;
			num = 324;
			goto IL_04a8;
			IL_04a8:
			num3 = 110;
			num = 10;
			goto IL_04b7;
			IL_04b7:
			array[12] = (byte)num3;
			num = 3;
			goto IL_04ce;
			IL_04ce:
			array[13] = 87;
			num = 168;
			goto IL_04e3;
			IL_04e3:
			array[13] = 93;
			goto IL_04ef;
			IL_04ef:
			array[13] = 180;
			num = 111;
			goto IL_0507;
			IL_0507:
			array[14] = 150;
			goto IL_0a2c;
			IL_0a2c:
			array[14] = 193;
			num = 292;
			goto IL_051b;
			IL_051b:
			num3 = 72;
			num = 174;
			goto IL_052a;
			IL_052a:
			array[14] = (byte)num3;
			num = 103;
			if (!smethod_20())
			{
				goto IL_054b;
			}
			goto IL_188c;
			IL_054b:
			num2 = 174;
			num = 43;
			goto IL_055d;
			IL_055d:
			array2[6] = (byte)num2;
			goto IL_056b;
			IL_056b:
			num2 = 90;
			num = 83;
			goto IL_057a;
			IL_057a:
			array2[6] = (byte)num2;
			num = 264;
			goto IL_0591;
			IL_0591:
			num2 = 101;
			goto IL_086b;
			IL_086b:
			array2[6] = (byte)num2;
			goto IL_059c;
			IL_059c:
			array2[6] = 143;
			num = 145;
			goto IL_05b4;
			IL_05b4:
			num2 = 192;
			num = 60;
			goto IL_05c6;
			IL_05c6:
			array2[6] = (byte)num2;
			num = 195;
			goto IL_05dd;
			IL_05dd:
			array2[7] = 65;
			num = 97;
			goto IL_05f2;
			IL_05f2:
			array2[7] = 70;
			num = 322;
			goto IL_0607;
			IL_0607:
			array2[7] = 132;
			num = 134;
			goto IL_061f;
			IL_061f:
			array2[7] = 160;
			goto IL_062e;
			IL_062e:
			array2[7] = 225;
			num = 45;
			goto IL_0646;
			IL_0646:
			num2 = 171;
			num = 328;
			goto IL_0658;
			IL_0658:
			array2[8] = (byte)num2;
			num = 126;
			goto IL_066f;
			IL_066f:
			array2[8] = 73;
			num = 273;
			goto IL_0684;
			IL_0684:
			array2[8] = 50;
			goto IL_0690;
			IL_0690:
			array2[9] = 102;
			num = 102;
			goto IL_06a5;
			IL_06a5:
			num2 = 92;
			num = 188;
			goto IL_06b4;
			IL_06b4:
			array2[9] = (byte)num2;
			num = 171;
			if (!smethod_21())
			{
				goto IL_06d5;
			}
			goto IL_193a;
			IL_06d5:
			num2 = 128;
			goto IL_06de;
			IL_06de:
			array2[9] = (byte)num2;
			goto IL_06ec;
			IL_06ec:
			num2 = 128;
			num = 42;
			goto IL_06fe;
			IL_06fe:
			array2[9] = (byte)num2;
			num = 316;
			goto IL_0715;
			IL_0715:
			array2[10] = 119;
			num = 129;
			goto IL_072a;
			IL_072a:
			array2[10] = 144;
			goto IL_0739;
			IL_0739:
			array2[10] = 28;
			num = 224;
			goto IL_074e;
			IL_074e:
			array2[10] = 225;
			num = 22;
			if (!smethod_20())
			{
				goto IL_0770;
			}
			goto IL_195f;
			IL_0770:
			array[1] = 130;
			num = 211;
			goto IL_0788;
			IL_0788:
			array[1] = 126;
			num = 305;
			goto IL_079d;
			IL_079d:
			array[1] = 93;
			num = 118;
			if (!smethod_21())
			{
				goto IL_07bc;
			}
			goto IL_087e;
			IL_07bc:
			array[1] = 33;
			goto IL_07c8;
			IL_07c8:
			num3 = 44;
			goto IL_07ce;
			IL_07ce:
			array[2] = (byte)num3;
			goto IL_07dc;
			IL_07dc:
			array[2] = 136;
			goto IL_07eb;
			IL_07eb:
			array[2] = 6;
			goto IL_07f6;
			IL_07f6:
			num3 = 89;
			num = 268;
			goto IL_0805;
			IL_0805:
			array[3] = (byte)num3;
			num = 21;
			goto IL_081c;
			IL_081c:
			array[3] = 116;
			goto IL_0828;
			IL_0828:
			num3 = 124;
			goto IL_082e;
			IL_082e:
			array[3] = (byte)num3;
			num = 288;
			if (smethod_21())
			{
				goto IL_084f;
			}
			goto IL_093a;
			IL_084f:
			array[27] = 86;
			num = 80;
			if (smethod_21())
			{
				goto IL_086b;
			}
			goto IL_08a4;
			IL_08a4:
			num3 = 98;
			num = 107;
			goto IL_08b3;
			IL_08b3:
			array[27] = (byte)num3;
			num = 320;
			goto IL_08ca;
			IL_08ca:
			num3 = 192;
			goto IL_08d3;
			IL_08d3:
			array[27] = (byte)num3;
			num = 300;
			goto IL_08ea;
			IL_08ea:
			num3 = 129;
			goto IL_08f3;
			IL_08f3:
			array[28] = (byte)num3;
			num = 104;
			goto IL_090a;
			IL_090a:
			array[28] = 83;
			num = 48;
			goto IL_091f;
			IL_091f:
			num3 = 109;
			num = 116;
			if (!smethod_20())
			{
				goto IL_0990;
			}
			goto IL_195f;
			IL_093a:
			num3 = 136;
			num = 33;
			goto IL_094c;
			IL_094c:
			array[3] = (byte)num3;
			num = 244;
			goto IL_0963;
			IL_0963:
			array[3] = 127;
			goto IL_096f;
			IL_096f:
			array[4] = 165;
			num = 64;
			goto IL_0987;
			IL_0987:
			num3 = 149;
			goto IL_0990;
			IL_0990:
			array[4] = (byte)num3;
			num = 37;
			goto IL_09a7;
			IL_09a7:
			num3 = 73;
			num = 205;
			if (smethod_21())
			{
				goto IL_09c0;
			}
			goto IL_195f;
			IL_09c0:
			num3 = 161;
			goto IL_09c9;
			IL_087e:
			array[8] = (byte)num3;
			num = 302;
			if (smethod_21())
			{
				goto IL_09c9;
			}
			goto IL_195f;
			IL_09c9:
			array[9] = (byte)num3;
			num = 325;
			goto IL_09e0;
			IL_09e0:
			num3 = 99;
			num = 228;
			if (!smethod_20())
			{
				goto IL_09f6;
			}
			goto IL_0a49;
			IL_09f6:
			num2 = 217;
			goto IL_09ff;
			IL_09ff:
			array2[11] = (byte)num2;
			goto IL_0a0d;
			IL_0a0d:
			array2[12] = 119;
			num = 15;
			if (smethod_21())
			{
				goto IL_0a2c;
			}
			goto IL_195f;
			IL_0a49:
			array[9] = (byte)num3;
			num = 149;
			goto IL_0a60;
			IL_0a60:
			array[9] = 118;
			goto IL_0a6c;
			IL_0a6c:
			array[9] = 128;
			num = 301;
			goto IL_0a84;
			IL_0a84:
			num3 = 232;
			goto IL_0a8d;
			IL_0a8d:
			array[9] = (byte)num3;
			num = 152;
			goto IL_0aa4;
			IL_0aa4:
			array[10] = 119;
			goto IL_0ab0;
			IL_0ab0:
			num3 = 139;
			num = 214;
			goto IL_0ac2;
			IL_0ac2:
			array[10] = (byte)num3;
			goto IL_0ad0;
			IL_0ad0:
			array[10] = 110;
			num = 204;
			goto IL_0ae5;
			IL_0ae5:
			num3 = 143;
			num = 304;
			goto IL_0af7;
			IL_0af7:
			array[10] = (byte)num3;
			num = 258;
			goto IL_0b0e;
			IL_0b0e:
			array[11] = 87;
			num = 343;
			goto IL_0b23;
			IL_0b23:
			array[11] = 163;
			goto IL_040b;
			IL_040b:
			num3 = 103;
			num = 313;
			goto IL_041a;
			IL_041a:
			array[11] = (byte)num3;
			num = 308;
			goto IL_0431;
			IL_0431:
			array[12] = 229;
			num = 293;
			if (!smethod_21())
			{
				goto IL_0453;
			}
			goto IL_0658;
			IL_0453:
			array[12] = 54;
			goto IL_045f;
			IL_193a:
			num3 = 231;
			goto IL_1943;
			IL_1943:
			array[19] = (byte)num3;
			num = 252;
			goto IL_000e;
			IL_188c:
			num3 = 40;
			num = 164;
			goto IL_189b;
			IL_189b:
			array[15] = (byte)num3;
			num = 59;
			goto IL_18b2;
			IL_18b2:
			array[15] = 136;
			goto IL_18c1;
			continue;
			end_IL_20eb:
			break;
		}
		string result;
		try
		{
			result = (string)smethod_19(smethod_18(), byte_3, int_5 + 4, int_6);
		}
		catch
		{
			goto IL_2111;
		}
		return result;
		IL_2111:
		return "";
	}

	internal static Type smethod_1(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	internal static object smethod_2(object object_1, object object_2)
	{
		return ((Assembly)object_1).GetManifestResourceStream((string)object_2);
	}

	internal static object smethod_3(object object_1)
	{
		return ((BinaryReader)object_1).BaseStream;
	}

	internal static void smethod_4(object object_1, long long_2)
	{
		((Stream)object_1).Position = long_2;
	}

	internal static void smethod_5(bool bool_2)
	{
		RSACryptoServiceProvider.UseMachineKeyStore = bool_2;
	}

	internal static long smethod_6(object object_1)
	{
		return ((Stream)object_1).Length;
	}

	internal static object smethod_7(object object_1, int int_5)
	{
		return ((BinaryReader)object_1).ReadBytes(int_5);
	}

	internal static object smethod_8(object object_1)
	{
		return ((Assembly)object_1).GetName();
	}

	internal static object smethod_9(object object_1)
	{
		return ((AssemblyName)object_1).GetPublicKeyToken();
	}

	internal static void smethod_10(object object_1, CipherMode cipherMode_0)
	{
		((SymmetricAlgorithm)object_1).Mode = cipherMode_0;
	}

	internal static object smethod_11(object object_1, object object_2, object object_3)
	{
		return ((SymmetricAlgorithm)object_1).CreateDecryptor((byte[])object_2, (byte[]?)object_3);
	}

	internal static void smethod_12(object object_1, object object_2, int int_5, int int_6)
	{
		((Stream)object_1).Write((byte[])object_2, int_5, int_6);
	}

	internal static void smethod_13(object object_1)
	{
		((CryptoStream)object_1).FlushFinalBlock();
	}

	internal static object smethod_14(object object_1)
	{
		return ((MemoryStream)object_1).ToArray();
	}

	internal static void smethod_15(object object_1)
	{
		((Stream)object_1).Close();
	}

	internal static void smethod_16(object object_1)
	{
		((BinaryReader)object_1).Close();
	}

	internal static int smethod_17(object object_1, int int_5)
	{
		return BitConverter.ToInt32((byte[])object_1, int_5);
	}

	internal static object smethod_18()
	{
		return Encoding.Unicode;
	}

	internal static object smethod_19(object object_1, object object_2, int int_5, int int_6)
	{
		return ((Encoding)object_1).GetString((byte[])object_2, int_5, int_6);
	}

	internal static bool smethod_20()
	{
		return true;
	}

	internal static bool smethod_21()
	{
		return false;
	}
}
