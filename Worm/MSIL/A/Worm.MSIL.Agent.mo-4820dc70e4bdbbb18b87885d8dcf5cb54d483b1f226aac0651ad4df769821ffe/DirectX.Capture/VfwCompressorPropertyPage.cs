using System.Runtime.InteropServices;
using System.Windows.Forms;
using DShowNET;

namespace DirectX.Capture;

public class VfwCompressorPropertyPage : PropertyPage
{
	protected IAMVfwCompressDialogs vfwCompressDialogs = null;

	public override byte[] State
	{
		get
		{
			byte[] array = null;
			int pcbState = 0;
			if (vfwCompressDialogs.GetState(null, ref pcbState) == 0 && pcbState > 0)
			{
				array = new byte[pcbState];
				if (vfwCompressDialogs.GetState(array, ref pcbState) != 0)
				{
					array = null;
				}
			}
			return array;
		}
		set
		{
			int num = vfwCompressDialogs.SetState(value, value.Length);
			if (num != 0)
			{
				Marshal.ThrowExceptionForHR(num);
			}
		}
	}

	public VfwCompressorPropertyPage(string name, IAMVfwCompressDialogs compressDialogs)
	{
		Name = name;
		SupportsPersisting = true;
		vfwCompressDialogs = compressDialogs;
	}

	public override void Show(Control owner)
	{
		vfwCompressDialogs.ShowDialog(VfwCompressDialogs.Config, owner.get_Handle());
	}
}
