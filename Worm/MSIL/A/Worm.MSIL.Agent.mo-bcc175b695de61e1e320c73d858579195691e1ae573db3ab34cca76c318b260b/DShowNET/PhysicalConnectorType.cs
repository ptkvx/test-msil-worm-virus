using System.Runtime.InteropServices;

namespace DShowNET;

[ComVisible(false)]
public enum PhysicalConnectorType
{
	Video_Tuner = 1,
	Video_Composite = 2,
	Video_SVideo = 3,
	Video_RGB = 4,
	Video_YRYBY = 5,
	Video_SerialDigital = 6,
	Video_ParallelDigital = 7,
	Video_SCSI = 8,
	Video_AUX = 9,
	Video_1394 = 10,
	Video_USB = 11,
	Video_VideoDecoder = 12,
	Video_VideoEncoder = 13,
	Video_SCART = 14,
	Audio_Tuner = 4096,
	Audio_Line = 4097,
	Audio_Mic = 4098,
	Audio_AESDigital = 4099,
	Audio_SPDIFDigital = 4100,
	Audio_SCSI = 4101,
	Audio_AUX = 4102,
	Audio_1394 = 4103,
	Audio_USB = 4104,
	Audio_AudioDecoder = 4105
}
