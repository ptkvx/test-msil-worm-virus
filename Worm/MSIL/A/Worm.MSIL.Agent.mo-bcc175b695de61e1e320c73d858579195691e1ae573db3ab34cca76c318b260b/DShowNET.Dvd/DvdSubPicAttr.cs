using System.Runtime.InteropServices;

namespace DShowNET.Dvd;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
[ComVisible(false)]
public struct DvdSubPicAttr
{
	public DvdSubPicType type;

	public DvdSubPicCoding coding;

	public int language;

	public DvdSubPicLangExt languageExt;
}
