#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreShell.h"
#include "Engine/Classes/GameFramework/ForceFeedbackAttenuation.h"
#include "ManageForceFeedbackAttenuation.generated.h"

// Source file D:\ue4\UE_4.17\Engine\Source\Runtime\Engine\Classes\GameFramework\ForceFeedbackAttenuation.h:20

UCLASS()
class UNREALDOTNETRUNTIME_API UManageForceFeedbackAttenuation : public UForceFeedbackAttenuation
{
	GENERATED_BODY()
	
	bool bIsManageAttach = false;
	
	public:
	UPROPERTY(EditAnywhere, BlueprintReadOnly, Category = "C#")
	FDotnetTypeName ManageClassName;
	
}
;
PRAGMA_ENABLE_DEPRECATION_WARNINGS