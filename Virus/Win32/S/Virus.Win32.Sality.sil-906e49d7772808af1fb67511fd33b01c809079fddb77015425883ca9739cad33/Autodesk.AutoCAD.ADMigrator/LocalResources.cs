using System.Reflection;
using System.Resources;

namespace Autodesk.AutoCAD.ADMigrator;

internal class LocalResources
{
	private static ResourceManager rm_;

	public static string GetString(string name)
	{
		if (rm_ == null)
		{
			Assembly.GetExecutingAssembly();
			rm_ = new ResourceManager(typeof(ADMigratorResources));
		}
		return rm_.GetString(name);
	}
}
