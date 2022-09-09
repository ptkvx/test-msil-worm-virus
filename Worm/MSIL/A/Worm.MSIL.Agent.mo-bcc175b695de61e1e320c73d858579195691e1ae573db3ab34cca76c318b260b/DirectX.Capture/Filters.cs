using DShowNET;

namespace DirectX.Capture;

public class Filters
{
	public FilterCollection VideoInputDevices = new FilterCollection(FilterCategory.VideoInputDevice);

	public FilterCollection AudioInputDevices = new FilterCollection(FilterCategory.AudioInputDevice);

	public FilterCollection VideoCompressors = new FilterCollection(FilterCategory.VideoCompressorCategory);

	public FilterCollection AudioCompressors = new FilterCollection(FilterCategory.AudioCompressorCategory);
}
