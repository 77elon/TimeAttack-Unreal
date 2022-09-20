using UnrealBuildTool;

public class TimeAttack_SubmissonTarget : TargetRules
{
	public TimeAttack_SubmissonTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("TimeAttack_Submisson");
	}
}
