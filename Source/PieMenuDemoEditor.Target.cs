// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class PieMenuDemoEditorTarget : TargetRules
{
	public PieMenuDemoEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.Latest;
    ExtraModuleNames.Add("PieMenuDemo");
	}
}
