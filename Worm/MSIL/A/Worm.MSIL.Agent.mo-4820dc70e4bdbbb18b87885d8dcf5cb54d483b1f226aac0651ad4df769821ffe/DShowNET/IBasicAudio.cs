using System.Runtime.InteropServices;

namespace DShowNET;

[ComImport]
[Guid("56a868b3-0ad4-11ce-b03a-0020af0ba770")]
[InterfaceType(ComInterfaceType.InterfaceIsDual)]
[ComVisible(true)]
public interface IBasicAudio
{
	int Volume
	{
		[PreserveSig]
		get;
	}

	int Balance
	{
		[PreserveSig]
		get;
	}

	[PreserveSig]
	int put_Volume(int lVolume);

	[PreserveSig]
	int put_Balance(int lBalance);
}
