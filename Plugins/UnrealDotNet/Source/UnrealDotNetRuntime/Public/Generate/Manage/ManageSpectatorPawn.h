#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreShell.h"
#include "Runtime/Engine/Classes/GameFramework/SpectatorPawn.h"
#include "ManageSpectatorPawn.generated.h"

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\GameFramework\SpectatorPawn.h:16

UCLASS()
class UNREALDOTNETRUNTIME_API AManageSpectatorPawn : public ASpectatorPawn
{
	GENERATED_BODY()
	
	bool bIsManageAttach = false;
	
	public:
	UPROPERTY(EditAnywhere, BlueprintReadOnly, Category = "C#")
	FDotnetTypeName ManageClassName;
	
}
;
PRAGMA_ENABLE_DEPRECATION_WARNINGS
