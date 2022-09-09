using System.Runtime.InteropServices;
using DShowNET;

namespace DirectX.Capture;

public class CrossbarSource : Source
{
	internal IAMCrossbar Crossbar;

	internal int OutputPin;

	internal int InputPin;

	internal PhysicalConnectorType ConnectorType;

	public override bool Enabled
	{
		get
		{
			if (Crossbar.get_IsRoutedTo(OutputPin, out int InputPinIndex) == 0 && InputPin == InputPinIndex)
			{
				return true;
			}
			return false;
		}
		set
		{
			if (value)
			{
				Crossbar.Route(OutputPin, InputPin);
			}
			else
			{
				Crossbar.Route(OutputPin, -1);
			}
		}
	}

	internal CrossbarSource(IAMCrossbar crossbar, int outputPin, int inputPin, PhysicalConnectorType connectorType)
	{
		Crossbar = crossbar;
		OutputPin = outputPin;
		InputPin = inputPin;
		ConnectorType = connectorType;
		name = getName(connectorType);
	}

	private string getName(PhysicalConnectorType connectorType)
	{
		return connectorType switch
		{
			PhysicalConnectorType.Audio_Tuner => "Audio Tuner", 
			PhysicalConnectorType.Audio_Line => "Audio Line In", 
			PhysicalConnectorType.Audio_Mic => "Audio Mic", 
			PhysicalConnectorType.Audio_AESDigital => "Audio AES Digital", 
			PhysicalConnectorType.Audio_SPDIFDigital => "Audio SPDIF Digital", 
			PhysicalConnectorType.Audio_SCSI => "Audio SCSI", 
			PhysicalConnectorType.Audio_AUX => "Audio AUX", 
			PhysicalConnectorType.Audio_1394 => "Audio Firewire", 
			PhysicalConnectorType.Audio_USB => "Audio USB", 
			PhysicalConnectorType.Audio_AudioDecoder => "Audio Decoder", 
			PhysicalConnectorType.Video_Tuner => "Video Tuner", 
			PhysicalConnectorType.Video_Composite => "Video Composite", 
			PhysicalConnectorType.Video_SVideo => "Video S-Video", 
			PhysicalConnectorType.Video_RGB => "Video RGB", 
			PhysicalConnectorType.Video_YRYBY => "Video YRYBY", 
			PhysicalConnectorType.Video_SerialDigital => "Video Serial Digital", 
			PhysicalConnectorType.Video_ParallelDigital => "Video Parallel Digital", 
			PhysicalConnectorType.Video_SCSI => "Video SCSI", 
			PhysicalConnectorType.Video_AUX => "Video AUX", 
			PhysicalConnectorType.Video_1394 => "Video Firewire", 
			PhysicalConnectorType.Video_USB => "Video USB", 
			PhysicalConnectorType.Video_VideoDecoder => "Video Decoder", 
			PhysicalConnectorType.Video_VideoEncoder => "Video Encoder", 
			PhysicalConnectorType.Video_SCART => "Video SCART", 
			_ => "Unknown Connector", 
		};
	}

	public override void Dispose()
	{
		if (Crossbar != null)
		{
			Marshal.ReleaseComObject(Crossbar);
		}
		Crossbar = null;
		base.Dispose();
	}
}
