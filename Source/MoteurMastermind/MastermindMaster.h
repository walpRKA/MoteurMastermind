// Fill out your copyright notice in the Description page of Project Settings.

#pragma once

#include "CoreMinimal.h"
#include "GameFramework/Actor.h"
#include "MastermindMaster.generated.h"

UCLASS()
class MOTEURMASTERMIND_API AMastermindMaster : public AActor
{
int Emplacement1;
int Emplacement2;
int Emplacement3;
int Emplacement4;
int Bonemplacement1;
int Bonemplacement2;
int Bonemplacement3;
int Bonemplacement4;

	GENERATED_BODY()
	
public:	
	// Sets default values for this actor's properties
	AMastermindMaster();

protected:
	// Called when the game starts or when spawned
	virtual void BeginPlay() override;

public:	
	// Called every frame
	virtual void Tick(float DeltaTime) override;

};
