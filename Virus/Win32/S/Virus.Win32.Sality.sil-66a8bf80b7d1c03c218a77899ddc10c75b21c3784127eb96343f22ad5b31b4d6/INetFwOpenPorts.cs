using System.Collections;
using System.Runtime.InteropServices;

[ComImport]
[Guid("C0E9D7FA-E07E-430A-B19A-090CE82D92E2")]
[TypeLibType(4160)]
public interface INetFwOpenPorts : IEnumerable
{
	[DispId(1)]
	int Count
	{
		[DispId(1)]
		get;
	}

	[DispId(2)]
	void Add([In][MarshalAs(UnmanagedType.Interface)] INetFwOpenPort Port);

	[DispId(3)]
	void Remove([In] int portNumber, [In] NET_FW_IP_PROTOCOL_ ipProtocol);

	[DispId(4)]
	[return: MarshalAs(UnmanagedType.Interface)]
	INetFwOpenPort Item([In] int portNumber, [In] NET_FW_IP_PROTOCOL_ ipProtocol);

	[TypeLibFunc(1)]
	[DispId(-4)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "")]
	new IEnumerator GetEnumerator();
}
