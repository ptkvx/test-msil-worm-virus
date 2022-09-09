using System;
using System.Runtime.InteropServices;

namespace DShowNET;

[ComVisible(false)]
public class PinCategory
{
	public static readonly Guid Capture = new Guid(4218176129u, 851, 4561, 144, 95, 0, 0, 192, 204, 22, 186);

	public static readonly Guid Preview = new Guid(4218176130u, 851, 4561, 144, 95, 0, 0, 192, 204, 22, 186);
}
