// Copyright Epic Games, Inc. All Rights Reserved.

#include "BalancingBpCppGameMode.h"
#include "BalancingBpCppPawn.h"

ABalancingBpCppGameMode::ABalancingBpCppGameMode()
{
	// set default pawn class to our character class
	DefaultPawnClass = ABalancingBpCppPawn::StaticClass();

	
}

