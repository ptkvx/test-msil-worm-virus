using System;
using System.Collections;
using System.Runtime.InteropServices;
using DShowNET;

namespace DirectX.Capture;

public class PropertyPageCollection : CollectionBase, IDisposable
{
	public PropertyPage this[int index] => (PropertyPage)base.InnerList[index];

	internal PropertyPageCollection()
	{
		base.InnerList.Capacity = 1;
	}

	internal PropertyPageCollection(ICaptureGraphBuilder2 graphBuilder, IBaseFilter videoDeviceFilter, IBaseFilter audioDeviceFilter, IBaseFilter videoCompressorFilter, IBaseFilter audioCompressorFilter, SourceCollection videoSources, SourceCollection audioSources)
	{
		addFromGraph(graphBuilder, videoDeviceFilter, audioDeviceFilter, videoCompressorFilter, audioCompressorFilter, videoSources, audioSources);
	}

	~PropertyPageCollection()
	{
		Dispose();
	}

	public new void Clear()
	{
		for (int i = 0; i < base.InnerList.Count; i++)
		{
			this[i].Dispose();
		}
		base.InnerList.Clear();
	}

	public void Dispose()
	{
		Clear();
		base.InnerList.Capacity = 1;
	}

	protected void addFromGraph(ICaptureGraphBuilder2 graphBuilder, IBaseFilter videoDeviceFilter, IBaseFilter audioDeviceFilter, IBaseFilter videoCompressorFilter, IBaseFilter audioCompressorFilter, SourceCollection videoSources, SourceCollection audioSources)
	{
		object ppint = null;
		addIfSupported(videoDeviceFilter, "Video Capture Device");
		Guid pCategory = PinCategory.Capture;
		Guid pType = MediaType.Interleaved;
		Guid riid = typeof(IAMStreamConfig).GUID;
		if (graphBuilder.FindInterface(ref pCategory, ref pType, videoDeviceFilter, ref riid, out ppint) != 0)
		{
			pType = MediaType.Video;
			if (graphBuilder.FindInterface(ref pCategory, ref pType, videoDeviceFilter, ref riid, out ppint) != 0)
			{
				ppint = null;
			}
		}
		addIfSupported(ppint, "Video Capture Pin");
		pCategory = PinCategory.Preview;
		pType = MediaType.Interleaved;
		riid = typeof(IAMStreamConfig).GUID;
		if (graphBuilder.FindInterface(ref pCategory, ref pType, videoDeviceFilter, ref riid, out ppint) != 0)
		{
			pType = MediaType.Video;
			if (graphBuilder.FindInterface(ref pCategory, ref pType, videoDeviceFilter, ref riid, out ppint) != 0)
			{
				ppint = null;
			}
		}
		addIfSupported(ppint, "Video Preview Pin");
		ArrayList arrayList = new ArrayList();
		int num = 1;
		for (int i = 0; i < videoSources.Count; i++)
		{
			if (videoSources[i] is CrossbarSource crossbarSource && arrayList.IndexOf(crossbarSource.Crossbar) < 0)
			{
				arrayList.Add(crossbarSource.Crossbar);
				if (addIfSupported(crossbarSource.Crossbar, "Video Crossbar " + ((num == 1) ? "" : num.ToString())))
				{
					num++;
				}
			}
		}
		arrayList.Clear();
		addIfSupported(videoCompressorFilter, "Video Compressor");
		pCategory = PinCategory.Capture;
		pType = MediaType.Interleaved;
		riid = typeof(IAMTVTuner).GUID;
		if (graphBuilder.FindInterface(ref pCategory, ref pType, videoDeviceFilter, ref riid, out ppint) != 0)
		{
			pType = MediaType.Video;
			if (graphBuilder.FindInterface(ref pCategory, ref pType, videoDeviceFilter, ref riid, out ppint) != 0)
			{
				ppint = null;
			}
		}
		addIfSupported(ppint, "TV Tuner");
		if (videoCompressorFilter is IAMVfwCompressDialogs compressDialogs)
		{
			VfwCompressorPropertyPage value = new VfwCompressorPropertyPage("Video Compressor", compressDialogs);
			base.InnerList.Add(value);
		}
		addIfSupported(audioDeviceFilter, "Audio Capture Device");
		pCategory = PinCategory.Capture;
		pType = MediaType.Audio;
		riid = typeof(IAMStreamConfig).GUID;
		if (graphBuilder.FindInterface(ref pCategory, ref pType, audioDeviceFilter, ref riid, out ppint) != 0)
		{
			ppint = null;
		}
		addIfSupported(ppint, "Audio Capture Pin");
		pCategory = PinCategory.Preview;
		pType = MediaType.Audio;
		riid = typeof(IAMStreamConfig).GUID;
		if (graphBuilder.FindInterface(ref pCategory, ref pType, audioDeviceFilter, ref riid, out ppint) != 0)
		{
			ppint = null;
		}
		addIfSupported(ppint, "Audio Preview Pin");
		num = 1;
		for (int i = 0; i < audioSources.Count; i++)
		{
			if (audioSources[i] is CrossbarSource crossbarSource2 && arrayList.IndexOf(crossbarSource2.Crossbar) < 0)
			{
				arrayList.Add(crossbarSource2.Crossbar);
				if (addIfSupported(crossbarSource2.Crossbar, "Audio Crossbar " + ((num == 1) ? "" : num.ToString())))
				{
					num++;
				}
			}
		}
		arrayList.Clear();
		addIfSupported(audioCompressorFilter, "Audio Compressor");
	}

	protected bool addIfSupported(object o, string name)
	{
		ISpecifyPropertyPages specifyPropertyPages = null;
		DsCAUUID pPages = default(DsCAUUID);
		bool result = false;
		try
		{
			specifyPropertyPages = o as ISpecifyPropertyPages;
			if (specifyPropertyPages != null && (specifyPropertyPages.GetPages(out pPages) != 0 || pPages.cElems <= 0))
			{
				specifyPropertyPages = null;
			}
		}
		finally
		{
			if (pPages.pElems != IntPtr.Zero)
			{
				Marshal.FreeCoTaskMem(pPages.pElems);
			}
		}
		if (specifyPropertyPages != null)
		{
			DirectShowPropertyPage value = new DirectShowPropertyPage(name, specifyPropertyPages);
			base.InnerList.Add(value);
			result = true;
		}
		return result;
	}
}
