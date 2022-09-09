using System;
using System.Runtime.InteropServices;

namespace DShowNET;

[ComVisible(false)]
[Flags]
public enum SeekingFlags
{
	NoPositioning = 0,
	AbsolutePositioning = 1,
	RelativePositioning = 2,
	IncrementalPositioning = 3,
	PositioningBitsMask = 3,
	SeekToKeyFrame = 4,
	ReturnTime = 8,
	Segment = 0x10,
	NoFlush = 0x20
}
