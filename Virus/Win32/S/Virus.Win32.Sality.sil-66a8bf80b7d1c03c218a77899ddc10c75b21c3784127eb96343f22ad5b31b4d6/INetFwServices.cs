using System.Collections;
using System.Runtime.InteropServices;

[ComImport]
[Guid("79649BB4-903E-421B-94C9-79848E79F6EE")]
[TypeLibType(4160)]
public interface INetFwServices : IEnumerable
{
	[DispId(1)]
	int Count
	{
		[DispId(1)]
		get;
	}

	[DispId(2)]
	[return: MarshalAs(UnmanagedType.Interface)]
	INetFwService Item([In] NET_FW_SERVICE_TYPE_ svcType);

	[DispId(-4)]
	[TypeLibFunc(1)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "")]
	new IEnumerator GetEnumerator();
}
