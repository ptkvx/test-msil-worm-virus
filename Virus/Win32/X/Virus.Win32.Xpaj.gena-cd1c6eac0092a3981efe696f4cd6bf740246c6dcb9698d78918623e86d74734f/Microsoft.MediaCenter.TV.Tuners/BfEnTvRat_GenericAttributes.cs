using System;

namespace Microsoft.MediaCenter.TV.Tuners;

[Flags]
public enum BfEnTvRat_GenericAttributes
{
	BfValidAttrSubmask = 0xFF,
	BfIsAttr_7 = 0x80,
	BfIsAttr_6 = 0x40,
	BfIsAttr_5 = 0x20,
	BfIsAttr_4 = 0x10,
	BfIsAttr_3 = 8,
	BfIsAttr_2 = 4,
	BfIsAttr_1 = 2,
	BfIsBlocked = 1,
	BfAttrNone = 0
}
