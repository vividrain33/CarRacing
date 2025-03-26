using UnrealBuildTool;

public class CarRacingTarget : TargetRules
{
	public CarRacingTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("CarRacing");
	}
}
