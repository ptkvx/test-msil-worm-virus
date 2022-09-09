using System.Runtime.InteropServices;

namespace DShowNET;

[ComImport]
[ComVisible(true)]
[Guid("56a868b2-0ad4-11ce-b03a-0020af0ba770")]
[InterfaceType(ComInterfaceType.InterfaceIsDual)]
public interface IMediaPosition
{
	int Duration
	{
		[PreserveSig]
		get;
	}

	int CurrentPosition
	{
		[PreserveSig]
		get;
	}

	int StopTime
	{
		[PreserveSig]
		get;
	}

	int PrerollTime
	{
		[PreserveSig]
		get;
	}

	int Rate
	{
		[PreserveSig]
		get;
	}

	[PreserveSig]
	int put_CurrentPosition(double llTime);

	[PreserveSig]
	int put_StopTime(double llTime);

	[PreserveSig]
	int put_PrerollTime(double llTime);

	[PreserveSig]
	int put_Rate(double dRate);

	[PreserveSig]
	int CanSeekForward(out int pCanSeekForward);

	[PreserveSig]
	int CanSeekBackward(out int pCanSeekBackward);
}
