// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class AxMSample : ModuleRules
{
	public AxMSample(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"AxMSample",
			"AxMSample/Variant_Platforming",
			"AxMSample/Variant_Platforming/Animation",
			"AxMSample/Variant_Combat",
			"AxMSample/Variant_Combat/AI",
			"AxMSample/Variant_Combat/Animation",
			"AxMSample/Variant_Combat/Gameplay",
			"AxMSample/Variant_Combat/Interfaces",
			"AxMSample/Variant_Combat/UI",
			"AxMSample/Variant_SideScrolling",
			"AxMSample/Variant_SideScrolling/AI",
			"AxMSample/Variant_SideScrolling/Gameplay",
			"AxMSample/Variant_SideScrolling/Interfaces",
			"AxMSample/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
