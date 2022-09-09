using System.Globalization;
using System.Reflection;

namespace Version;

internal class ProductVersion
{
	private static int _MajorVersion;

	private static int _MinorVersion;

	private static int _ProductBuild;

	private static int _ProductBuildQFE;

	private static string _VersionString;

	public static int MajorVersion => _MajorVersion;

	public static int MinorVersion => _MinorVersion;

	public static int ProductBuild => _ProductBuild;

	public static int ProductBuildQFE => _ProductBuildQFE;

	public static string VersionString()
	{
		return _VersionString;
	}

	static ProductVersion()
	{
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		AssemblyFileVersionAttribute[] array = (AssemblyFileVersionAttribute[])executingAssembly.GetCustomAttributes(typeof(AssemblyFileVersionAttribute), inherit: true);
		if (array != null && array.Length > 0)
		{
			string version = array[0].Version;
			string[] array2 = version.Split(new char[1] { '.' });
			_MajorVersion = int.Parse(array2[0], CultureInfo.InvariantCulture);
			_MinorVersion = int.Parse(array2[1], CultureInfo.InvariantCulture);
			_ProductBuild = int.Parse(array2[2], CultureInfo.InvariantCulture);
			_ProductBuildQFE = int.Parse(array2[3], CultureInfo.InvariantCulture);
		}
		_VersionString = _MajorVersion + "." + _MinorVersion + "." + string.Format(CultureInfo.InvariantCulture, "{0:d4}", new object[1] { _ProductBuild }) + "." + string.Format(CultureInfo.InvariantCulture, "{0:d4}", new object[1] { _ProductBuildQFE });
	}
}
