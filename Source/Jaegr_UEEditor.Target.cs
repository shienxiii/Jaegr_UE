// Copyright of ArkSoft Games. All Rights Reserved

using UnrealBuildTool;
using System.Collections.Generic;

public class Jaegr_UEEditorTarget : TargetRules
{
	public Jaegr_UEEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V5;

		ExtraModuleNames.AddRange( new string[] { "Jaegr_UE" } );
	}
}
