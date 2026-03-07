// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class meme_battles : ModuleRules
{
	public meme_battles(ReadOnlyTargetRules Target) : base(Target)
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
			"meme_battles",
			"meme_battles/Variant_Platforming",
			"meme_battles/Variant_Platforming/Animation",
			"meme_battles/Variant_Combat",
			"meme_battles/Variant_Combat/AI",
			"meme_battles/Variant_Combat/Animation",
			"meme_battles/Variant_Combat/Gameplay",
			"meme_battles/Variant_Combat/Interfaces",
			"meme_battles/Variant_Combat/UI",
			"meme_battles/Variant_SideScrolling",
			"meme_battles/Variant_SideScrolling/AI",
			"meme_battles/Variant_SideScrolling/Gameplay",
			"meme_battles/Variant_SideScrolling/Interfaces",
			"meme_battles/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
