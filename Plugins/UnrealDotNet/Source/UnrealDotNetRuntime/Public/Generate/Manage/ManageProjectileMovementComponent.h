#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreShell.h"
#include "Runtime/Engine/Classes/GameFramework/ProjectileMovementComponent.h"
#include "ManageProjectileMovementComponent.generated.h"

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\GameFramework\ProjectileMovementComponent.h:22

UCLASS()
class UNREALDOTNETRUNTIME_API UManageProjectileMovementComponent : public UProjectileMovementComponent
{
	GENERATED_BODY()
	
	bool bIsManageAttach = false;
	
	public:
	UPROPERTY(EditAnywhere, BlueprintReadOnly, Category = "C#")
	FDotnetTypeName ManageClassName;
	
}
;
PRAGMA_ENABLE_DEPRECATION_WARNINGS
