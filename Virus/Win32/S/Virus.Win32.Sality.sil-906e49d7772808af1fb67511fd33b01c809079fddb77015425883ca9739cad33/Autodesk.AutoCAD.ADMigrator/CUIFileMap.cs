namespace Autodesk.AutoCAD.ADMigrator;

public class CUIFileMap
{
	private string _sourceFileName;

	private string _sourceMenuGroupName;

	private string _sourceMacroGroupName;

	private string _targetFileName;

	private string _targetMenuGroupName;

	private string _targetMacroGroupName;

	public string SourceFileName => _sourceFileName;

	public string SourceMenuGroupName => _sourceMenuGroupName;

	public string SourceMacroGroupName => _sourceMacroGroupName;

	public string TargetFileName => _targetFileName;

	public string TargetMenuGroupName => _targetMenuGroupName;

	public string TargetMacroGroupName => _targetMacroGroupName;

	public CUIFileMap(string sourceFileName, string sourceMenuGroupName, string sourceMacroGroupName, string targetFileName, string targetMenuGroupName, string targetMacroGroupName)
	{
		_sourceFileName = sourceFileName;
		_sourceMenuGroupName = sourceMenuGroupName;
		_sourceMacroGroupName = sourceMacroGroupName;
		_targetFileName = targetFileName;
		_targetMenuGroupName = targetMenuGroupName;
		_targetMacroGroupName = targetMacroGroupName;
	}
}
