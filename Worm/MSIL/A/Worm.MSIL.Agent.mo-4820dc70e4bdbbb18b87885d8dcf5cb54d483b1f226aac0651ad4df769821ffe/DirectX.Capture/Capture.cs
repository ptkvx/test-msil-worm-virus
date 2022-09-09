using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using DShowNET;

namespace DirectX.Capture;

public class Capture : Form, ISampleGrabberCB
{
	protected enum GraphState
	{
		Null,
		Created,
		Rendered,
		Capturing
	}

	public delegate void FrameCapHandler(PictureBox Frame);

	private delegate void CaptureDone();

	private const int WM_GRAPHNOTIFY = 32769;

	protected GraphState graphState = GraphState.Null;

	protected bool isPreviewRendered = false;

	protected bool isCaptureRendered = false;

	protected bool wantPreviewRendered = false;

	protected bool wantCaptureRendered = false;

	protected bool wantCaptureFrame = false;

	protected int rotCookie = 0;

	protected Filter videoDevice = null;

	protected Filter audioDevice = null;

	protected Filter videoCompressor = null;

	protected Filter audioCompressor = null;

	protected string filename = "";

	protected Control previewWindow = null;

	protected VideoCapabilities videoCaps = null;

	protected AudioCapabilities audioCaps = null;

	protected SourceCollection videoSources = null;

	protected SourceCollection audioSources = null;

	protected PropertyPageCollection propertyPages = null;

	protected Tuner tuner = null;

	protected IGraphBuilder graphBuilder;

	protected IMediaControl mediaControl;

	protected IVideoWindow videoWindow;

	protected ICaptureGraphBuilder2 captureGraphBuilder = null;

	protected ISampleGrabber sampGrabber = null;

	protected IAMStreamConfig videoStreamConfig = null;

	protected IAMStreamConfig audioStreamConfig = null;

	protected IBaseFilter videoDeviceFilter = null;

	protected IBaseFilter videoCompressorFilter = null;

	protected IBaseFilter audioDeviceFilter = null;

	protected IBaseFilter audioCompressorFilter = null;

	protected IBaseFilter muxFilter = null;

	protected IBaseFilter baseGrabFlt = null;

	protected IFileSinkFilter fileWriterFilter = null;

	protected VideoInfoHeader videoInfoHeader;

	protected byte[] savedArray;

	protected bool capturedFrame = false;

	protected int bufferedSize;

	protected bool captured = true;

	protected bool firstFrame = true;

	protected bool renderStream = false;

	private IMediaEventEx mediaEvt;

	public PictureBox ImageCaptured;

	public bool Capturing => graphState == GraphState.Capturing;

	public bool Cued => isCaptureRendered && graphState == GraphState.Rendered;

	public bool Stopped => graphState != GraphState.Capturing;

	public string Filename
	{
		get
		{
			return filename;
		}
		set
		{
			assertStopped();
			filename = value;
			if (fileWriterFilter != null)
			{
				AMMediaType aMMediaType = new AMMediaType();
				int curFile = fileWriterFilter.GetCurFile(out var _, aMMediaType);
				if (curFile < 0)
				{
					Marshal.ThrowExceptionForHR(curFile);
				}
				if (aMMediaType.formatSize > 0)
				{
					Marshal.FreeCoTaskMem(aMMediaType.formatPtr);
				}
				curFile = fileWriterFilter.SetFileName(filename, aMMediaType);
				if (curFile < 0)
				{
					Marshal.ThrowExceptionForHR(curFile);
				}
			}
		}
	}

	public Control PreviewWindow
	{
		get
		{
			return previewWindow;
		}
		set
		{
			assertStopped();
			derenderGraph();
			previewWindow = value;
			wantPreviewRendered = previewWindow != null && videoDevice != null;
			renderStream = false;
			renderGraph();
			startPreviewIfNeeded();
		}
	}

	public VideoCapabilities VideoCaps
	{
		get
		{
			if (videoCaps == null && videoStreamConfig != null)
			{
				try
				{
					videoCaps = new VideoCapabilities(videoStreamConfig);
				}
				catch (Exception)
				{
				}
			}
			return videoCaps;
		}
	}

	public AudioCapabilities AudioCaps
	{
		get
		{
			if (audioCaps == null && audioStreamConfig != null)
			{
				try
				{
					audioCaps = new AudioCapabilities(audioStreamConfig);
				}
				catch (Exception)
				{
				}
			}
			return audioCaps;
		}
	}

	public Filter VideoDevice => videoDevice;

	public Filter AudioDevice => audioDevice;

	public Filter VideoCompressor
	{
		get
		{
			return videoCompressor;
		}
		set
		{
			assertStopped();
			destroyGraph();
			videoCompressor = value;
			renderGraph();
			startPreviewIfNeeded();
		}
	}

	public Filter AudioCompressor
	{
		get
		{
			return audioCompressor;
		}
		set
		{
			assertStopped();
			destroyGraph();
			audioCompressor = value;
			renderGraph();
			startPreviewIfNeeded();
		}
	}

	public Source VideoSource
	{
		get
		{
			return VideoSources.CurrentSource;
		}
		set
		{
			VideoSources.CurrentSource = value;
		}
	}

	public Source AudioSource
	{
		get
		{
			return AudioSources.CurrentSource;
		}
		set
		{
			AudioSources.CurrentSource = value;
		}
	}

	public SourceCollection VideoSources
	{
		get
		{
			if (videoSources == null)
			{
				try
				{
					if (videoDevice != null)
					{
						videoSources = new SourceCollection(captureGraphBuilder, videoDeviceFilter, isVideoDevice: true);
					}
					else
					{
						videoSources = new SourceCollection();
					}
				}
				catch (Exception)
				{
				}
			}
			return videoSources;
		}
	}

	public SourceCollection AudioSources
	{
		get
		{
			if (audioSources == null)
			{
				try
				{
					if (audioDevice != null)
					{
						audioSources = new SourceCollection(captureGraphBuilder, audioDeviceFilter, isVideoDevice: false);
					}
					else
					{
						audioSources = new SourceCollection();
					}
				}
				catch (Exception)
				{
				}
			}
			return audioSources;
		}
	}

	public PropertyPageCollection PropertyPages
	{
		get
		{
			if (propertyPages == null)
			{
				try
				{
					propertyPages = new PropertyPageCollection(captureGraphBuilder, videoDeviceFilter, audioDeviceFilter, videoCompressorFilter, audioCompressorFilter, VideoSources, AudioSources);
				}
				catch (Exception)
				{
				}
			}
			return propertyPages;
		}
	}

	public Tuner Tuner => tuner;

	public double FrameRate
	{
		get
		{
			long num = (long)getStreamConfigSetting(videoStreamConfig, "AvgTimePerFrame");
			return 10000000.0 / (double)num;
		}
		set
		{
			long num = (long)(10000000.0 / value);
			setStreamConfigSetting(videoStreamConfig, "AvgTimePerFrame", num);
		}
	}

	public Size FrameSize
	{
		get
		{
			BitmapInfoHeader bitmapInfoHeader = (BitmapInfoHeader)getStreamConfigSetting(videoStreamConfig, "BmiHeader");
			return new Size(bitmapInfoHeader.Width, bitmapInfoHeader.Height);
		}
		set
		{
			BitmapInfoHeader bitmapInfoHeader = (BitmapInfoHeader)getStreamConfigSetting(videoStreamConfig, "BmiHeader");
			bitmapInfoHeader.Width = value.Width;
			bitmapInfoHeader.Height = value.Height;
			setStreamConfigSetting(videoStreamConfig, "BmiHeader", bitmapInfoHeader);
		}
	}

	public short AudioChannels
	{
		get
		{
			return (short)getStreamConfigSetting(audioStreamConfig, "nChannels");
		}
		set
		{
			setStreamConfigSetting(audioStreamConfig, "nChannels", value);
		}
	}

	public int AudioSamplingRate
	{
		get
		{
			return (int)getStreamConfigSetting(audioStreamConfig, "nSamplesPerSec");
		}
		set
		{
			setStreamConfigSetting(audioStreamConfig, "nSamplesPerSec", value);
		}
	}

	public short AudioSampleSize
	{
		get
		{
			return (short)getStreamConfigSetting(audioStreamConfig, "wBitsPerSample");
		}
		set
		{
			setStreamConfigSetting(audioStreamConfig, "wBitsPerSample", value);
		}
	}

	public event EventHandler CaptureComplete;

	public event FrameCapHandler FrameCaptureComplete;

	public Capture(Filter videoDevice, Filter audioDevice)
	{
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Expected O, but got Unknown
		this.videoDevice = videoDevice;
		this.audioDevice = audioDevice;
		Filename = getTempFilename();
		ImageCaptured = new PictureBox();
		createGraph();
	}

	~Capture()
	{
		try
		{
			((Component)this).Dispose();
		}
		finally
		{
			((Component)this).Finalize();
		}
	}

	public void Cue()
	{
		assertStopped();
		wantCaptureRendered = true;
		renderGraph();
		int num = mediaControl.Pause();
		if (num != 0)
		{
			Marshal.ThrowExceptionForHR(num);
		}
	}

	public void Start()
	{
		Stop();
		firstFrame = false;
		assertStopped();
		wantCaptureRendered = true;
		renderStream = true;
		renderGraph();
		int num = mediaControl.Run();
		if (num != 0)
		{
			Marshal.ThrowExceptionForHR(num);
		}
		graphState = GraphState.Capturing;
	}

	public void Stop()
	{
		if (mediaControl != null)
		{
			mediaControl.Stop();
		}
		wantCaptureRendered = false;
		wantPreviewRendered = true;
		if (graphState == GraphState.Capturing)
		{
			graphState = GraphState.Rendered;
			if (this.CaptureComplete != null)
			{
				this.CaptureComplete(this, null);
			}
		}
		firstFrame = true;
		renderStream = false;
		try
		{
			renderGraph();
		}
		catch
		{
		}
		try
		{
			startPreviewIfNeeded();
		}
		catch
		{
		}
	}

	public void DisposeCapture()
	{
		wantPreviewRendered = false;
		wantCaptureRendered = false;
		this.CaptureComplete = null;
		try
		{
			destroyGraph();
		}
		catch
		{
		}
		if (videoSources != null)
		{
			videoSources.Dispose();
		}
		videoSources = null;
		if (audioSources != null)
		{
			audioSources.Dispose();
		}
		audioSources = null;
	}

	[STAThread]
	public void CaptureFrame()
	{
		if (firstFrame)
		{
			assertStopped();
			renderStream = true;
			renderGraph();
			mediaControl.Run();
			firstFrame = false;
		}
		captured = false;
		if (savedArray == null)
		{
			int imageSize = videoInfoHeader.BmiHeader.ImageSize;
			if (imageSize < 1000 || imageSize > 16000000)
			{
				return;
			}
			savedArray = new byte[imageSize + 64000];
		}
		sampGrabber.SetCallback(this, 1);
	}

	public void RenderPreview()
	{
		assertStopped();
		renderStream = true;
		renderGraph();
		mediaControl.Run();
	}

	protected void createGraph()
	{
		Type type = null;
		object obj = null;
		if (graphState >= GraphState.Created)
		{
			return;
		}
		GC.Collect();
		graphBuilder = (IGraphBuilder)Activator.CreateInstance(Type.GetTypeFromCLSID(Clsid.FilterGraph, throwOnError: true));
		Guid clsid = Clsid.CaptureGraphBuilder2;
		Guid riid = typeof(ICaptureGraphBuilder2).GUID;
		captureGraphBuilder = (ICaptureGraphBuilder2)DsBugWO.CreateDsInstance(ref clsid, ref riid);
		type = Type.GetTypeFromCLSID(Clsid.SampleGrabber, throwOnError: true);
		obj = Activator.CreateInstance(type);
		sampGrabber = (ISampleGrabber)obj;
		obj = null;
		int num = captureGraphBuilder.SetFiltergraph(graphBuilder);
		if (num < 0)
		{
			Marshal.ThrowExceptionForHR(num);
		}
		AMMediaType aMMediaType = new AMMediaType();
		aMMediaType.majorType = MediaType.Video;
		aMMediaType.subType = MediaSubType.RGB24;
		aMMediaType.formatType = FormatType.VideoInfo;
		num = sampGrabber.SetMediaType(aMMediaType);
		if (num < 0)
		{
			Marshal.ThrowExceptionForHR(num);
		}
		if (VideoDevice != null)
		{
			videoDeviceFilter = (IBaseFilter)Marshal.BindToMoniker(VideoDevice.MonikerString);
			num = graphBuilder.AddFilter(videoDeviceFilter, "Video Capture Device");
			if (num < 0)
			{
				Marshal.ThrowExceptionForHR(num);
			}
			mediaEvt = (IMediaEventEx)graphBuilder;
			baseGrabFlt = (IBaseFilter)sampGrabber;
			num = graphBuilder.AddFilter(baseGrabFlt, "DS.NET Grabber");
			if (num < 0)
			{
				Marshal.ThrowExceptionForHR(num);
			}
		}
		if (AudioDevice != null)
		{
			audioDeviceFilter = (IBaseFilter)Marshal.BindToMoniker(AudioDevice.MonikerString);
			num = graphBuilder.AddFilter(audioDeviceFilter, "Audio Capture Device");
			if (num < 0)
			{
				Marshal.ThrowExceptionForHR(num);
			}
		}
		if (VideoCompressor != null)
		{
			videoCompressorFilter = (IBaseFilter)Marshal.BindToMoniker(VideoCompressor.MonikerString);
			num = graphBuilder.AddFilter(videoCompressorFilter, "Video Compressor");
			if (num < 0)
			{
				Marshal.ThrowExceptionForHR(num);
			}
		}
		if (AudioCompressor != null)
		{
			audioCompressorFilter = (IBaseFilter)Marshal.BindToMoniker(AudioCompressor.MonikerString);
			num = graphBuilder.AddFilter(audioCompressorFilter, "Audio Compressor");
			if (num < 0)
			{
				Marshal.ThrowExceptionForHR(num);
			}
		}
		Guid pCategory = PinCategory.Capture;
		Guid pType = MediaType.Interleaved;
		Guid riid2 = typeof(IAMStreamConfig).GUID;
		if (captureGraphBuilder.FindInterface(ref pCategory, ref pType, videoDeviceFilter, ref riid2, out var ppint) != 0)
		{
			pType = MediaType.Video;
			if (captureGraphBuilder.FindInterface(ref pCategory, ref pType, videoDeviceFilter, ref riid2, out ppint) != 0)
			{
				ppint = null;
			}
		}
		videoStreamConfig = ppint as IAMStreamConfig;
		ppint = null;
		pCategory = PinCategory.Capture;
		pType = MediaType.Audio;
		riid2 = typeof(IAMStreamConfig).GUID;
		if (captureGraphBuilder.FindInterface(ref pCategory, ref pType, audioDeviceFilter, ref riid2, out ppint) != 0)
		{
			ppint = null;
		}
		audioStreamConfig = ppint as IAMStreamConfig;
		mediaControl = (IMediaControl)graphBuilder;
		if (videoSources != null)
		{
			videoSources.Dispose();
		}
		videoSources = null;
		if (audioSources != null)
		{
			audioSources.Dispose();
		}
		audioSources = null;
		if (propertyPages != null)
		{
			propertyPages.Dispose();
		}
		propertyPages = null;
		videoCaps = null;
		audioCaps = null;
		ppint = null;
		pCategory = PinCategory.Capture;
		pType = MediaType.Interleaved;
		riid2 = typeof(IAMTVTuner).GUID;
		if (captureGraphBuilder.FindInterface(ref pCategory, ref pType, videoDeviceFilter, ref riid2, out ppint) != 0)
		{
			pType = MediaType.Video;
			if (captureGraphBuilder.FindInterface(ref pCategory, ref pType, videoDeviceFilter, ref riid2, out ppint) != 0)
			{
				ppint = null;
			}
		}
		if (ppint is IAMTVTuner iAMTVTuner)
		{
			tuner = new Tuner(iAMTVTuner);
		}
		graphState = GraphState.Created;
	}

	protected void renderGraph()
	{
		bool flag = false;
		assertStopped();
		if (mediaControl != null)
		{
			mediaControl.Stop();
		}
		createGraph();
		if (!wantPreviewRendered && isPreviewRendered)
		{
			derenderGraph();
		}
		if (!wantCaptureRendered && isCaptureRendered && wantPreviewRendered)
		{
			derenderGraph();
			graphState = GraphState.Null;
			createGraph();
		}
		if (wantCaptureRendered && !isCaptureRendered)
		{
			Guid pType = MediaSubType.Avi;
			int num = captureGraphBuilder.SetOutputFileName(ref pType, Filename, out muxFilter, out fileWriterFilter);
			if (VideoDevice != null)
			{
				Guid pCategory = PinCategory.Capture;
				Guid pType2 = MediaType.Interleaved;
				num = captureGraphBuilder.RenderStream(ref pCategory, ref pType2, videoDeviceFilter, videoCompressorFilter, muxFilter);
				if (num < 0)
				{
					pType2 = MediaType.Video;
					num = captureGraphBuilder.RenderStream(ref pCategory, ref pType2, videoDeviceFilter, videoCompressorFilter, muxFilter);
				}
			}
			if (AudioDevice != null)
			{
				Guid pCategory = PinCategory.Capture;
				Guid pType2 = MediaType.Audio;
				num = captureGraphBuilder.RenderStream(ref pCategory, ref pType2, audioDeviceFilter, audioCompressorFilter, muxFilter);
			}
			isCaptureRendered = true;
			flag = true;
		}
		if (wantPreviewRendered && renderStream && !isPreviewRendered)
		{
			Guid pCategory = PinCategory.Preview;
			Guid pType2 = MediaType.Video;
			int num = captureGraphBuilder.RenderStream(ref pCategory, ref pType2, videoDeviceFilter, baseGrabFlt, null);
			videoWindow = (IVideoWindow)graphBuilder;
			num = videoWindow.put_Owner(previewWindow.get_Handle());
			num = videoWindow.put_WindowStyle(1174405120);
			previewWindow.add_Resize((EventHandler)onPreviewWindowResize);
			onPreviewWindowResize(this, null);
			num = videoWindow.put_Visible(-1);
			num = mediaEvt.SetNotifyWindow(((Control)this).get_Handle(), 32769, IntPtr.Zero);
			isPreviewRendered = true;
			flag = true;
			AMMediaType aMMediaType = new AMMediaType();
			num = sampGrabber.GetConnectedMediaType(aMMediaType);
			videoInfoHeader = (VideoInfoHeader)Marshal.PtrToStructure(aMMediaType.formatPtr, typeof(VideoInfoHeader));
			Marshal.FreeCoTaskMem(aMMediaType.formatPtr);
			aMMediaType.formatPtr = IntPtr.Zero;
			num = sampGrabber.SetBufferSamples(BufferThem: false);
			if (num == 0)
			{
				num = sampGrabber.SetOneShot(OneShot: false);
			}
			if (num == 0)
			{
				num = sampGrabber.SetCallback(null, 0);
			}
			if (num < 0)
			{
				num = 0;
			}
		}
		if (flag)
		{
			graphState = GraphState.Rendered;
		}
	}

	protected void startPreviewIfNeeded()
	{
		if (wantPreviewRendered && isPreviewRendered && !isCaptureRendered)
		{
			mediaControl.Run();
		}
	}

	protected void derenderGraph()
	{
		if (mediaControl != null)
		{
			mediaControl.Stop();
		}
		if (videoWindow != null)
		{
			videoWindow.put_Visible(0);
			videoWindow.put_Owner(IntPtr.Zero);
			videoWindow = null;
		}
		if (PreviewWindow != null)
		{
			previewWindow.remove_Resize((EventHandler)onPreviewWindowResize);
		}
		if (graphState >= GraphState.Rendered)
		{
			graphState = GraphState.Created;
			isCaptureRendered = false;
			isPreviewRendered = false;
			if (videoDeviceFilter != null)
			{
				removeDownstream(videoDeviceFilter, videoCompressor == null);
			}
			if (audioDeviceFilter != null)
			{
				removeDownstream(audioDeviceFilter, audioCompressor == null);
			}
			muxFilter = null;
			fileWriterFilter = null;
			baseGrabFlt = null;
		}
	}

	protected void removeDownstream(IBaseFilter filter, bool removeFirstFilter)
	{
		IEnumPins ppEnum;
		int num = filter.EnumPins(out ppEnum);
		ppEnum.Reset();
		if (num != 0 || ppEnum == null)
		{
			return;
		}
		IPin[] array = new IPin[1];
		do
		{
			num = ppEnum.Next(1, array, out var _);
			if (num != 0 || array[0] == null)
			{
				continue;
			}
			IPin ppPin = null;
			array[0].ConnectedTo(out ppPin);
			if (ppPin != null)
			{
				PinInfo pInfo = default(PinInfo);
				num = ppPin.QueryPinInfo(out pInfo);
				if (num == 0 && pInfo.dir == PinDirection.Input)
				{
					removeDownstream(pInfo.filter, removeFirstFilter: true);
					graphBuilder.Disconnect(ppPin);
					graphBuilder.Disconnect(array[0]);
					if (pInfo.filter != videoCompressorFilter && pInfo.filter != audioCompressorFilter)
					{
						graphBuilder.RemoveFilter(pInfo.filter);
					}
				}
				Marshal.ReleaseComObject(pInfo.filter);
				Marshal.ReleaseComObject(ppPin);
			}
			Marshal.ReleaseComObject(array[0]);
		}
		while (num == 0);
		Marshal.ReleaseComObject(ppEnum);
		ppEnum = null;
	}

	protected void destroyGraph()
	{
		try
		{
			derenderGraph();
		}
		catch
		{
		}
		graphState = GraphState.Null;
		isCaptureRendered = false;
		isPreviewRendered = false;
		if (rotCookie != 0)
		{
			DsROT.RemoveGraphFromRot(ref rotCookie);
			rotCookie = 0;
		}
		if (muxFilter != null)
		{
			graphBuilder.RemoveFilter(muxFilter);
		}
		if (baseGrabFlt != null)
		{
			graphBuilder.RemoveFilter(baseGrabFlt);
		}
		if (videoCompressorFilter != null)
		{
			graphBuilder.RemoveFilter(videoCompressorFilter);
		}
		if (audioCompressorFilter != null)
		{
			graphBuilder.RemoveFilter(audioCompressorFilter);
		}
		if (videoDeviceFilter != null)
		{
			graphBuilder.RemoveFilter(videoDeviceFilter);
		}
		if (audioDeviceFilter != null)
		{
			graphBuilder.RemoveFilter(audioDeviceFilter);
		}
		if (videoSources != null)
		{
			videoSources.Dispose();
		}
		videoSources = null;
		if (audioSources != null)
		{
			audioSources.Dispose();
		}
		audioSources = null;
		if (propertyPages != null)
		{
			propertyPages.Dispose();
		}
		propertyPages = null;
		if (tuner != null)
		{
			tuner.Dispose();
		}
		tuner = null;
		if (graphBuilder != null)
		{
			Marshal.ReleaseComObject(graphBuilder);
		}
		graphBuilder = null;
		if (captureGraphBuilder != null)
		{
			Marshal.ReleaseComObject(captureGraphBuilder);
		}
		captureGraphBuilder = null;
		if (muxFilter != null)
		{
			Marshal.ReleaseComObject(muxFilter);
		}
		muxFilter = null;
		if (baseGrabFlt != null)
		{
			Marshal.ReleaseComObject(baseGrabFlt);
		}
		baseGrabFlt = null;
		if (fileWriterFilter != null)
		{
			Marshal.ReleaseComObject(fileWriterFilter);
		}
		fileWriterFilter = null;
		if (videoDeviceFilter != null)
		{
			Marshal.ReleaseComObject(videoDeviceFilter);
		}
		videoDeviceFilter = null;
		if (audioDeviceFilter != null)
		{
			Marshal.ReleaseComObject(audioDeviceFilter);
		}
		audioDeviceFilter = null;
		if (videoCompressorFilter != null)
		{
			Marshal.ReleaseComObject(videoCompressorFilter);
		}
		videoCompressorFilter = null;
		if (audioCompressorFilter != null)
		{
			Marshal.ReleaseComObject(audioCompressorFilter);
		}
		audioCompressorFilter = null;
		mediaControl = null;
		videoWindow = null;
		GC.Collect();
	}

	protected void onPreviewWindowResize(object sender, EventArgs e)
	{
		if (videoWindow != null)
		{
			Rectangle clientRectangle = previewWindow.get_ClientRectangle();
			videoWindow.SetWindowPosition(0, 0, clientRectangle.Right, clientRectangle.Bottom);
		}
	}

	protected string getTempFilename()
	{
		string text;
		try
		{
			int num = 0;
			Random random = new Random();
			string tempPath = Path.GetTempPath();
			do
			{
				text = Path.Combine(tempPath, random.Next().ToString("X") + ".avi");
				num++;
				if (num > 100)
				{
					return text;
				}
			}
			while (File.Exists(text));
		}
		catch
		{
			text = "c:\temp.avi";
		}
		return text;
	}

	protected object getStreamConfigSetting(IAMStreamConfig streamConfig, string fieldName)
	{
		if (streamConfig == null)
		{
			throw new NotSupportedException();
		}
		assertStopped();
		derenderGraph();
		object result = null;
		IntPtr pmt = IntPtr.Zero;
		AMMediaType aMMediaType = new AMMediaType();
		try
		{
			streamConfig.GetFormat(out pmt);
			Marshal.PtrToStructure(pmt, (object)aMMediaType);
			object obj = null;
			if (aMMediaType.formatType == FormatType.WaveEx)
			{
				obj = new WaveFormatEx();
			}
			else if (aMMediaType.formatType == FormatType.VideoInfo)
			{
				obj = new VideoInfoHeader();
			}
			else if (aMMediaType.formatType == FormatType.VideoInfo2)
			{
				obj = new VideoInfoHeader2();
			}
			Marshal.PtrToStructure(aMMediaType.formatPtr, obj);
			Type type = obj.GetType();
			FieldInfo field = type.GetField(fieldName);
			result = field.GetValue(obj);
		}
		finally
		{
			DsUtils.FreeAMMediaType(aMMediaType);
			Marshal.FreeCoTaskMem(pmt);
		}
		renderStream = false;
		renderGraph();
		startPreviewIfNeeded();
		return result;
	}

	protected object setStreamConfigSetting(IAMStreamConfig streamConfig, string fieldName, object newValue)
	{
		if (streamConfig == null)
		{
			throw new NotSupportedException();
		}
		assertStopped();
		derenderGraph();
		object result = null;
		IntPtr pmt = IntPtr.Zero;
		AMMediaType aMMediaType = new AMMediaType();
		try
		{
			streamConfig.GetFormat(out pmt);
			Marshal.PtrToStructure(pmt, (object)aMMediaType);
			object obj = null;
			if (aMMediaType.formatType == FormatType.WaveEx)
			{
				obj = new WaveFormatEx();
			}
			else if (aMMediaType.formatType == FormatType.VideoInfo)
			{
				obj = new VideoInfoHeader();
			}
			else if (aMMediaType.formatType == FormatType.VideoInfo2)
			{
				obj = new VideoInfoHeader2();
			}
			Marshal.PtrToStructure(aMMediaType.formatPtr, obj);
			Type type = obj.GetType();
			FieldInfo field = type.GetField(fieldName);
			if ((object)field == null)
			{
				field.SetValue(obj, newValue);
			}
			Marshal.StructureToPtr(obj, aMMediaType.formatPtr, fDeleteOld: false);
			streamConfig.SetFormat(aMMediaType);
		}
		finally
		{
			DsUtils.FreeAMMediaType(aMMediaType);
			Marshal.FreeCoTaskMem(pmt);
		}
		renderStream = false;
		renderGraph();
		startPreviewIfNeeded();
		return result;
	}

	protected void assertStopped()
	{
		if (!Stopped)
		{
		}
	}

	private void OnCaptureDone()
	{
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected O, but got Unknown
		if (sampGrabber != null)
		{
			sampGrabber.SetCallback(null, 0);
			int width = videoInfoHeader.BmiHeader.Width;
			int height = videoInfoHeader.BmiHeader.Height;
			if ((width & 3) == 0 && width >= 32 && width <= 4096 && height >= 32 && height <= 4096)
			{
				int num = width * 3;
				GCHandle gCHandle = GCHandle.Alloc(savedArray, GCHandleType.Pinned);
				int num2 = (int)gCHandle.AddrOfPinnedObject();
				num2 += (height - 1) * num;
				Bitmap image = new Bitmap(width, height, -num, (PixelFormat)137224, (IntPtr)num2);
				gCHandle.Free();
				savedArray = null;
				ImageCaptured.set_Image((Image)(object)image);
				this.FrameCaptureComplete(ImageCaptured);
			}
		}
	}

	protected override void WndProc(ref Message m)
	{
		if (((Message)(ref m)).get_Msg() == 32769)
		{
			if (mediaEvt != null)
			{
				OnGraphNotify();
			}
		}
		else
		{
			((Form)this).WndProc(ref m);
		}
	}

	private void OnGraphNotify()
	{
		int num = 0;
		DsEvCode lEventCode;
		int lParam;
		int lParam2;
		do
		{
			num = mediaEvt.GetEvent(out lEventCode, out lParam, out lParam2, 0);
		}
		while (num >= 0 && mediaEvt.FreeEventParams(lEventCode, lParam, lParam2) == 0);
	}

	int ISampleGrabberCB.SampleCB(double SampleTime, IMediaSample pSample)
	{
		return 0;
	}

	int ISampleGrabberCB.BufferCB(double SampleTime, IntPtr pBuffer, int BufferLen)
	{
		if (captured || savedArray == null)
		{
			return 0;
		}
		captured = true;
		bufferedSize = BufferLen;
		if (pBuffer != IntPtr.Zero && BufferLen > 1000 && BufferLen <= savedArray.Length)
		{
			Marshal.Copy(pBuffer, savedArray, 0, BufferLen);
		}
		try
		{
			((Control)this).BeginInvoke((Delegate)new CaptureDone(OnCaptureDone));
		}
		catch (ThreadInterruptedException)
		{
		}
		catch (Exception)
		{
		}
		return 0;
	}

	private void InitializeComponent()
	{
		((Control)this).SuspendLayout();
		((Form)this).set_ClientSize(new Size(284, 264));
		((Control)this).set_Name("Capture");
		((Form)this).add_Load((EventHandler)Capture_Load);
		((Control)this).ResumeLayout(false);
	}

	private void Capture_Load(object sender, EventArgs e)
	{
	}
}
