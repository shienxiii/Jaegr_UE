// Copyright of ArkSoft Games. All Rights Reserved


#include "Actor/Pawn/JaegrCharacter.h"

// Sets default values
AJaegrCharacter::AJaegrCharacter()
{
 	// Set this character to call Tick() every frame.  You can turn this off to improve performance if you don't need it.
	PrimaryActorTick.bCanEverTick = true;

}

// Called when the game starts or when spawned
void AJaegrCharacter::BeginPlay()
{
	Super::BeginPlay();
	
}

// Called every frame
void AJaegrCharacter::Tick(float DeltaTime)
{
	Super::Tick(DeltaTime);

}

// Called to bind functionality to input
void AJaegrCharacter::SetupPlayerInputComponent(UInputComponent* PlayerInputComponent)
{
	Super::SetupPlayerInputComponent(PlayerInputComponent);

}

