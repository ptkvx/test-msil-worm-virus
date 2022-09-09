using System;
using System.Runtime.InteropServices;

namespace DShowNET;

[ComImport]
[ComVisible(true)]
[Guid("56a868b4-0ad4-11ce-b03a-0020af0ba770")]
[InterfaceType(ComInterfaceType.InterfaceIsDual)]
public interface IVideoWindow
{
	int Caption
	{
		[PreserveSig]
		get;
	}

	int WindowStyle
	{
		[PreserveSig]
		get;
	}

	int WindowStyleEx
	{
		[PreserveSig]
		get;
	}

	int AutoShow
	{
		[PreserveSig]
		get;
	}

	int WindowState
	{
		[PreserveSig]
		get;
	}

	int BackgroundPalette
	{
		[PreserveSig]
		get;
	}

	int Visible
	{
		[PreserveSig]
		get;
	}

	int Left
	{
		[PreserveSig]
		get;
	}

	int Width
	{
		[PreserveSig]
		get;
	}

	int Top
	{
		[PreserveSig]
		get;
	}

	int Height
	{
		[PreserveSig]
		get;
	}

	int Owner
	{
		[PreserveSig]
		get;
	}

	int MessageDrain
	{
		[PreserveSig]
		get;
	}

	int BorderColor
	{
		[PreserveSig]
		get;
	}

	int FullScreenMode
	{
		[PreserveSig]
		get;
	}

	[PreserveSig]
	int put_Caption(string caption);

	[PreserveSig]
	int put_WindowStyle(int windowStyle);

	[PreserveSig]
	int put_WindowStyleEx(int windowStyleEx);

	[PreserveSig]
	int put_AutoShow(int autoShow);

	[PreserveSig]
	int put_WindowState(int windowState);

	[PreserveSig]
	int put_BackgroundPalette(int backgroundPalette);

	[PreserveSig]
	int put_Visible(int visible);

	[PreserveSig]
	int put_Left(int left);

	[PreserveSig]
	int put_Width(int width);

	[PreserveSig]
	int put_Top(int top);

	[PreserveSig]
	int put_Height(int height);

	[PreserveSig]
	int put_Owner(IntPtr owner);

	[PreserveSig]
	int put_MessageDrain(IntPtr drain);

	[PreserveSig]
	int put_BorderColor(int color);

	[PreserveSig]
	int put_FullScreenMode(int fullScreenMode);

	[PreserveSig]
	int SetWindowForeground(int focus);

	[PreserveSig]
	int NotifyOwnerMessage(IntPtr hwnd, int msg, IntPtr wParam, IntPtr lParam);

	[PreserveSig]
	int SetWindowPosition(int left, int top, int width, int height);

	[PreserveSig]
	int GetWindowPosition(out int left, out int top, out int width, out int height);

	[PreserveSig]
	int GetMinIdealImageSize(out int width, out int height);

	[PreserveSig]
	int GetMaxIdealImageSize(out int width, out int height);

	[PreserveSig]
	int GetRestorePosition(out int left, out int top, out int width, out int height);

	[PreserveSig]
	int HideCursor(int hideCursor);

	[PreserveSig]
	int IsCursorHidden(out int hideCursor);
}
