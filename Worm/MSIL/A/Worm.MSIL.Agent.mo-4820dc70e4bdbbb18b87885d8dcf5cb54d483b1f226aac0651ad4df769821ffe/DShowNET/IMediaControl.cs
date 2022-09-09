using System.Runtime.InteropServices;

namespace DShowNET;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsDual)]
[Guid("56a868b1-0ad4-11ce-b03a-0020af0ba770")]
[ComVisible(true)]
public interface IMediaControl
{
	int FilterCollection
	{
		[PreserveSig]
		get;
	}

	int RegFilterCollection
	{
		[PreserveSig]
		get;
	}

	[PreserveSig]
	int Run();

	[PreserveSig]
	int Pause();

	[PreserveSig]
	int Stop();

	[PreserveSig]
	int GetState(int msTimeout, out int pfs);

	[PreserveSig]
	int RenderFile(string strFilename);

	[PreserveSig]
	int AddSourceFilter([In] string strFilename, [MarshalAs(UnmanagedType.IDispatch)] out object ppUnk);

	[PreserveSig]
	int StopWhenReady();
}
