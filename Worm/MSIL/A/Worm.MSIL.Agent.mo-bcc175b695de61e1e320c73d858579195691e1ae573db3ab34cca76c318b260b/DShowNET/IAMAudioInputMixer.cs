using System.Runtime.InteropServices;

namespace DShowNET;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[ComVisible(true)]
[Guid("54C39221-8380-11d0-B3F0-00AA003761C5")]
public interface IAMAudioInputMixer
{
	int Enable { get; }

	int Mono { get; }

	int MixLevel { get; }

	int Pan { get; }

	int Loudness { get; }

	int Treble { get; }

	int TrebleRange { get; }

	int Bass { get; }

	int BassRange { get; }

	int put_Enable([In] bool fEnable);

	int put_Mono([In] bool fMono);

	int put_MixLevel([In] double Level);

	int put_Pan([In] double Pan);

	int put_Loudness([In] bool fLoudness);

	int put_Treble([In] double Treble);

	int put_Bass([In] double Bass);
}
