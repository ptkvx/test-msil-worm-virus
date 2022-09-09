using System;

namespace Microsoft.MediaCenter.TV.Tuners;

[Flags]
public enum BfEnTvRat_Attributes_US_TV
{
	US_TV_ValidAttrSubmask = 0x1F,
	US_TV_IsSexuallySuggestiveDialog = 0x10,
	US_TV_IsAdultLanguage = 8,
	US_TV_IsSexualSituation = 4,
	US_TV_IsViolent = 2,
	US_TV_IsBlocked = 1
}
