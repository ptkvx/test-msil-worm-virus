using System;
using System.Collections;
using System.Runtime.InteropServices;
using DShowNET;

namespace DirectX.Capture;

public class SourceCollection : CollectionBase, IDisposable
{
	public Source this[int index] => (Source)base.InnerList[index];

	internal Source CurrentSource
	{
		get
		{
			foreach (Source inner in base.InnerList)
			{
				if (inner.Enabled)
				{
					return inner;
				}
			}
			return null;
		}
		set
		{
			if (value == null)
			{
				foreach (Source inner in base.InnerList)
				{
					inner.Enabled = false;
				}
				return;
			}
			if (value is CrossbarSource)
			{
				value.Enabled = true;
				return;
			}
			foreach (Source inner2 in base.InnerList)
			{
				inner2.Enabled = false;
			}
			value.Enabled = true;
		}
	}

	internal SourceCollection()
	{
		base.InnerList.Capacity = 1;
	}

	internal SourceCollection(ICaptureGraphBuilder2 graphBuilder, IBaseFilter deviceFilter, bool isVideoDevice)
	{
		addFromGraph(graphBuilder, deviceFilter, isVideoDevice);
	}

	~SourceCollection()
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

	protected void addFromGraph(ICaptureGraphBuilder2 graphBuilder, IBaseFilter deviceFilter, bool isVideoDevice)
	{
		ArrayList arrayList = findCrossbars(graphBuilder, deviceFilter);
		foreach (IAMCrossbar item in arrayList)
		{
			ArrayList c = findCrossbarSources(graphBuilder, item, isVideoDevice);
			base.InnerList.AddRange(c);
		}
		if (!isVideoDevice && base.InnerList.Count == 0)
		{
			ArrayList c = findAudioSources(graphBuilder, deviceFilter);
			base.InnerList.AddRange(c);
		}
	}

	protected ArrayList findCrossbars(ICaptureGraphBuilder2 graphBuilder, IBaseFilter deviceFilter)
	{
		ArrayList arrayList = new ArrayList();
		Guid pCategory = FindDirection.UpstreamOnly;
		Guid pType = default(Guid);
		Guid riid = typeof(IAMCrossbar).GUID;
		object ppint = null;
		object ppint2 = null;
		int num = graphBuilder.FindInterface(ref pCategory, ref pType, deviceFilter, ref riid, out ppint);
		while (num == 0 && ppint != null)
		{
			if (ppint is IAMCrossbar)
			{
				arrayList.Add(ppint as IAMCrossbar);
				num = graphBuilder.FindInterface(ref pCategory, ref pType, ppint as IBaseFilter, ref riid, out ppint2);
				ppint = ppint2;
			}
			else
			{
				ppint = null;
			}
		}
		return arrayList;
	}

	protected ArrayList findCrossbarSources(ICaptureGraphBuilder2 graphBuilder, IAMCrossbar crossbar, bool isVideoDevice)
	{
		ArrayList arrayList = new ArrayList();
		int num = crossbar.get_PinCounts(out int OutputPinCount, out int InputPinCount);
		if (num < 0)
		{
			Marshal.ThrowExceptionForHR(num);
		}
		for (int i = 0; i < OutputPinCount; i++)
		{
			for (int j = 0; j < InputPinCount; j++)
			{
				if (crossbar.CanRoute(i, j) != 0)
				{
					continue;
				}
				num = crossbar.get_CrossbarPinInfo(IsInputPin: true, j, out int _, out PhysicalConnectorType PhysicalType);
				if (num < 0)
				{
					Marshal.ThrowExceptionForHR(num);
				}
				CrossbarSource value = new CrossbarSource(crossbar, i, j, PhysicalType);
				if (PhysicalType < PhysicalConnectorType.Audio_Tuner)
				{
					if (isVideoDevice)
					{
						arrayList.Add(value);
					}
					else if (!isVideoDevice)
					{
						arrayList.Add(value);
					}
				}
			}
		}
		int num2 = 0;
		while (num2 < arrayList.Count)
		{
			bool flag = false;
			CrossbarSource crossbarSource = (CrossbarSource)arrayList[num2];
			for (int k = 0; k < arrayList.Count; k++)
			{
				CrossbarSource crossbarSource2 = (CrossbarSource)arrayList[k];
				if (crossbarSource.OutputPin == crossbarSource2.OutputPin && num2 != k)
				{
					flag = true;
					break;
				}
			}
			if (flag)
			{
				num2++;
			}
			else
			{
				arrayList.RemoveAt(num2);
			}
		}
		return arrayList;
	}

	protected ArrayList findAudioSources(ICaptureGraphBuilder2 graphBuilder, IBaseFilter deviceFilter)
	{
		ArrayList arrayList = new ArrayList();
		if (deviceFilter is IAMAudioInputMixer)
		{
			IEnumPins ppEnum;
			int num = deviceFilter.EnumPins(out ppEnum);
			ppEnum.Reset();
			if (num == 0 && ppEnum != null)
			{
				IPin[] array = new IPin[1];
				do
				{
					num = ppEnum.Next(1, array, out var _);
					if (num == 0 && array[0] != null)
					{
						PinDirection pPinDir = PinDirection.Output;
						num = array[0].QueryDirection(out pPinDir);
						if (num == 0 && pPinDir == PinDirection.Input)
						{
							AudioSource value = new AudioSource(array[0]);
							arrayList.Add(value);
						}
						array[0] = null;
					}
				}
				while (num == 0);
				Marshal.ReleaseComObject(ppEnum);
				ppEnum = null;
			}
		}
		if (arrayList.Count == 1)
		{
			arrayList.Clear();
		}
		return arrayList;
	}
}
