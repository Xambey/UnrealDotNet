#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreShell.h"
#include "Runtime/Engine/Classes/Components/MeshComponent.h"
#include "ManageMeshComponent.generated.h"

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\Components\MeshComponent.h:21

UCLASS()
class UNREALDOTNETRUNTIME_API UManageMeshComponent : public UMeshComponent
{
	GENERATED_BODY()
	
	bool bIsManageAttach = false;
	
	public:
	UPROPERTY(EditAnywhere, BlueprintReadOnly, Category = "C#")
	FDotnetTypeName ManageClassName;
	
}
;
PRAGMA_ENABLE_DEPRECATION_WARNINGS
