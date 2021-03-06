#include "UnrealDotNetRuntime.h"
#include "DotnetTypeName.h"
#include "Generate/Manage/ManageSpringArmComponent.h"

PRAGMA_DISABLE_DEPRECATION_WARNINGS

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\GameFramework\SpringArmComponent.h:19

void UManageSpringArmComponent::UpdateDesiredArmLocation(bool bDoTrace, bool bDoLocationLag, bool bDoRotationLag, float DeltaTime)
{
	Super::UpdateDesiredArmLocation(bDoTrace, bDoLocationLag, bDoRotationLag, DeltaTime);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "UpdateDesiredArmLocation", bDoTrace, bDoLocationLag, bDoRotationLag, DeltaTime);
}

PRAGMA_ENABLE_DEPRECATION_WARNINGS
