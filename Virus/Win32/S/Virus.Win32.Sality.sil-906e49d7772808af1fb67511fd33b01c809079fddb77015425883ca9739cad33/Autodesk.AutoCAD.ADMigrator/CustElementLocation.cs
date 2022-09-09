using Autodesk.AutoCAD.Customization;

namespace Autodesk.AutoCAD.ADMigrator;

internal class CustElementLocation
{
	public CustomizationElement CustElement;

	public CustomizationElement insertAfter;

	public int offset;

	public CustElementLocation(CustomizationElement CEin)
	{
		CustElement = CEin;
		insertAfter = null;
		offset = 0;
	}
}
