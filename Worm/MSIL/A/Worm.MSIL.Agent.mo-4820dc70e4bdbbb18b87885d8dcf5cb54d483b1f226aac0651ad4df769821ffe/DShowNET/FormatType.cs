using System;
using System.Runtime.InteropServices;

namespace DShowNET;

[ComVisible(false)]
public class FormatType
{
	public static readonly Guid None = new Guid(258217942u, 49944, 4560, 164, 63, 0, 160, 201, 34, 49, 150);

	public static readonly Guid VideoInfo = new Guid(89694080u, 50006, 4558, 191, 1, 0, 170, 0, 85, 89, 90);

	public static readonly Guid VideoInfo2 = new Guid(4146755232u, 60170, 4560, 172, 228, 0, 0, 192, 204, 22, 186);

	public static readonly Guid WaveEx = new Guid(89694081u, 50006, 4558, 191, 1, 0, 170, 0, 85, 89, 90);

	public static readonly Guid MpegVideo = new Guid(89694082u, 50006, 4558, 191, 1, 0, 170, 0, 85, 89, 90);

	public static readonly Guid MpegStreams = new Guid(89694083u, 50006, 4558, 191, 1, 0, 170, 0, 85, 89, 90);

	public static readonly Guid DvInfo = new Guid(89694084u, 50006, 4558, 191, 1, 0, 170, 0, 85, 89, 90);
}
