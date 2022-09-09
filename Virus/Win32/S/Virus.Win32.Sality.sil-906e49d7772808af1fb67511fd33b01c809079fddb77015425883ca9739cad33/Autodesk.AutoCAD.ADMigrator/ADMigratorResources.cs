using System.Resources;

namespace Autodesk.AutoCAD.ADMigrator;

internal class ADMigratorResources
{
	private ResourceManager m_RM;

	public ADMigratorResources()
	{
		m_RM = new ResourceManager(typeof(ADMigratorResources));
	}

	public string GetString(string sKey)
	{
		return m_RM.GetString(sKey);
	}
}
