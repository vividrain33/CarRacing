using UnrealBuildTool;

public class CarRacingClientTarget : TargetRules
{
	public CarRacingClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("CarRacing");
	}
}
