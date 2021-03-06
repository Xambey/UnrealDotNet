#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreShell.h"
#include "Runtime/Engine/Classes/Engine/Light.h"
#include "ManageLight.generated.h"

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\Engine\Light.h:13

UCLASS()
class UNREALDOTNETRUNTIME_API AManageLight : public ALight
{
	GENERATED_BODY()
	
	bool bIsManageAttach = false;
	
	public:
	UPROPERTY(EditAnywhere, BlueprintReadOnly, Category = "C#")
	FDotnetTypeName ManageClassName;
	
	
public:
	
	virtual void OnRep_bEnabled() override;
	
}
;
PRAGMA_ENABLE_DEPRECATION_WARNINGS
