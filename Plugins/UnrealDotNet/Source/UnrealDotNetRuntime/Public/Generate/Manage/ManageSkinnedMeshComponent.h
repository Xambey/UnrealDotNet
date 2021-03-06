#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreShell.h"
#include "Runtime/Engine/Classes/Components/SkinnedMeshComponent.h"
#include "ManageSkinnedMeshComponent.generated.h"

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\Components\SkinnedMeshComponent.h:182

UCLASS()
class UNREALDOTNETRUNTIME_API UManageSkinnedMeshComponent : public USkinnedMeshComponent
{
	GENERATED_BODY()
	
	bool bIsManageAttach = false;
	
	public:
	UPROPERTY(EditAnywhere, BlueprintReadOnly, Category = "C#")
	FDotnetTypeName ManageClassName;
	
	
public:
	
	virtual void ClearRefPoseOverride() override;
	
}
;
PRAGMA_ENABLE_DEPRECATION_WARNINGS
