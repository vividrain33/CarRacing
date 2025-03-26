using UnrealBuildTool;

public class CarRacingEditorTarget : TargetRules
{
	public CarRacingEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("CarRacing");
	}
}
