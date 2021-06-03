// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class BalancingBpCpp : ModuleRules
{
	public BalancingBpCpp(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore" });
	}
}
