#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreShell.h"
#include "Runtime/Engine/Classes/Components/SphereComponent.h"
#include "ManageSphereComponent.generated.h"

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\Components\SphereComponent.h:17

UCLASS()
class UNREALDOTNETRUNTIME_API UManageSphereComponent : public USphereComponent
{
	GENERATED_BODY()
	
	bool bIsManageAttach = false;
	
	public:
	UPROPERTY(EditAnywhere, BlueprintReadOnly, Category = "C#")
	FDotnetTypeName ManageClassName;
	
}
;
PRAGMA_ENABLE_DEPRECATION_WARNINGS
