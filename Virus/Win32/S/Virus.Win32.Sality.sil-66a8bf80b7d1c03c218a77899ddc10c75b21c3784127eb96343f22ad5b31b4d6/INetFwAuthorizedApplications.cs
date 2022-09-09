using System.Collections;
using System.Runtime.InteropServices;

[ComImport]
[Guid("644EFD52-CCF9-486C-97A2-39F352570B30")]
[TypeLibType(4160)]
public interface INetFwAuthorizedApplications : IEnumerable
{
	[DispId(1)]
	int Count
	{
		[DispId(1)]
		get;
	}

	[DispId(2)]
	void Add([In][MarshalAs(UnmanagedType.Interface)] INetFwAuthorizedApplication app);

	[DispId(3)]
	void Remove([In][MarshalAs(UnmanagedType.BStr)] string imageFileName);

	[DispId(4)]
	[return: MarshalAs(UnmanagedType.Interface)]
	INetFwAuthorizedApplication Item([In][MarshalAs(UnmanagedType.BStr)] string imageFileName);

	[DispId(-4)]
	[TypeLibFunc(1)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "")]
	new IEnumerator GetEnumerator();
}
