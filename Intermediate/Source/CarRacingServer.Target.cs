using UnrealBuildTool;

public class CarRacingServerTarget : TargetRules
{
	public CarRacingServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("CarRacing");
	}
}
