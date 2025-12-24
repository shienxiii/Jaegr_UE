// Copyright of ArkSoft Games. All Rights Reserved

using UnrealBuildTool;
using System.Collections.Generic;

public class Jaegr_UETarget : TargetRules
{
	public Jaegr_UETarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V5;

		ExtraModuleNames.AddRange( new string[] { "Jaegr_UE" } );
	}
}
