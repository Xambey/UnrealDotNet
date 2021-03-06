#include "UnrealDotNetRuntime.h"
#include "DotnetTypeName.h"
#include "Generate/Manage/ManageCharacterMovementComponent.h"

PRAGMA_DISABLE_DEPRECATION_WARNINGS

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\GameFramework\CharacterMovementComponent.h:156

void UManageCharacterMovementComponent::AddForce(FVector Force)
{
	Super::AddForce(Force);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "AddForce", Force);
}

void UManageCharacterMovementComponent::AddImpulse(FVector Impulse, bool bVelocityChange)
{
	Super::AddImpulse(Impulse, bVelocityChange);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "AddImpulse", Impulse, bVelocityChange);
}

void UManageCharacterMovementComponent::AdjustFloorHeight()
{
	Super::AdjustFloorHeight();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "AdjustFloorHeight");
}

void UManageCharacterMovementComponent::AdjustProxyCapsuleSize()
{
	Super::AdjustProxyCapsuleSize();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "AdjustProxyCapsuleSize");
}

void UManageCharacterMovementComponent::ApplyAccumulatedForces(float DeltaSeconds)
{
	Super::ApplyAccumulatedForces(DeltaSeconds);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "ApplyAccumulatedForces", DeltaSeconds);
}

void UManageCharacterMovementComponent::ApplyDownwardForce(float DeltaSeconds)
{
	Super::ApplyDownwardForce(DeltaSeconds);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "ApplyDownwardForce", DeltaSeconds);
}

void UManageCharacterMovementComponent::ApplyImpactPhysicsForces(const FHitResult& Impact, const FVector& ImpactAcceleration, const FVector& ImpactVelocity)
{
	Super::ApplyImpactPhysicsForces(Impact, ImpactAcceleration, ImpactVelocity);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "ApplyImpactPhysicsForces", Impact, ImpactAcceleration, ImpactVelocity);
}

void UManageCharacterMovementComponent::ApplyNetworkMovementMode(const uint8 ReceivedMode)
{
	Super::ApplyNetworkMovementMode(ReceivedMode);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "ApplyNetworkMovementMode", ReceivedMode);
}

void UManageCharacterMovementComponent::ApplyRepulsionForce(float DeltaSeconds)
{
	Super::ApplyRepulsionForce(DeltaSeconds);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "ApplyRepulsionForce", DeltaSeconds);
}

void UManageCharacterMovementComponent::ApplyVelocityBraking(float DeltaTime, float Friction, float BrakingDeceleration)
{
	Super::ApplyVelocityBraking(DeltaTime, Friction, BrakingDeceleration);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "ApplyVelocityBraking", DeltaTime, Friction, BrakingDeceleration);
}

void UManageCharacterMovementComponent::CalcVelocity(float DeltaTime, float Friction, bool bFluid, float BrakingDeceleration)
{
	Super::CalcVelocity(DeltaTime, Friction, bFluid, BrakingDeceleration);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "CalcVelocity", DeltaTime, Friction, bFluid, BrakingDeceleration);
}

void UManageCharacterMovementComponent::CallMovementUpdateDelegate(float DeltaSeconds, const FVector& OldLocation, const FVector& OldVelocity)
{
	Super::CallMovementUpdateDelegate(DeltaSeconds, OldLocation, OldVelocity);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "CallMovementUpdateDelegate", DeltaSeconds, OldLocation, OldVelocity);
}

void UManageCharacterMovementComponent::CapsuleTouched(UPrimitiveComponent* OverlappedComp, AActor* Other, UPrimitiveComponent* OtherComp, int32 OtherBodyIndex, bool bFromSweep, const FHitResult& SweepResult)
{
	Super::CapsuleTouched(OverlappedComp, Other, OtherComp, OtherBodyIndex, bFromSweep, SweepResult);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "CapsuleTouched", OverlappedComp, Other, OtherComp, OtherBodyIndex, bFromSweep, SweepResult);
}

void UManageCharacterMovementComponent::ClearAccumulatedForces()
{
	Super::ClearAccumulatedForces();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "ClearAccumulatedForces");
}

void UManageCharacterMovementComponent::ClientAckGoodMove(float TimeStamp)
{
	Super::ClientAckGoodMove(TimeStamp);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "ClientAckGoodMove", TimeStamp);
}

void UManageCharacterMovementComponent::ClientAckGoodMove_Implementation(float TimeStamp)
{
	Super::ClientAckGoodMove_Implementation(TimeStamp);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "ClientAckGoodMove_Implementation", TimeStamp);
}

void UManageCharacterMovementComponent::ClientAdjustPosition(float TimeStamp, FVector NewLoc, FVector NewVel, UPrimitiveComponent* NewBase, FName NewBaseBoneName, bool bHasBase, bool bBaseRelativePosition, uint8 ServerMovementMode)
{
	Super::ClientAdjustPosition(TimeStamp, NewLoc, NewVel, NewBase, NewBaseBoneName, bHasBase, bBaseRelativePosition, ServerMovementMode);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "ClientAdjustPosition", TimeStamp, NewLoc, NewVel, NewBase, NewBaseBoneName, bHasBase, bBaseRelativePosition, ServerMovementMode);
}

void UManageCharacterMovementComponent::ClientAdjustPosition_Implementation(float TimeStamp, FVector NewLoc, FVector NewVel, UPrimitiveComponent* NewBase, FName NewBaseBoneName, bool bHasBase, bool bBaseRelativePosition, uint8 ServerMovementMode)
{
	Super::ClientAdjustPosition_Implementation(TimeStamp, NewLoc, NewVel, NewBase, NewBaseBoneName, bHasBase, bBaseRelativePosition, ServerMovementMode);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "ClientAdjustPosition_Implementation", TimeStamp, NewLoc, NewVel, NewBase, NewBaseBoneName, bHasBase, bBaseRelativePosition, ServerMovementMode);
}

void UManageCharacterMovementComponent::ClientVeryShortAdjustPosition(float TimeStamp, FVector NewLoc, UPrimitiveComponent* NewBase, FName NewBaseBoneName, bool bHasBase, bool bBaseRelativePosition, uint8 ServerMovementMode)
{
	Super::ClientVeryShortAdjustPosition(TimeStamp, NewLoc, NewBase, NewBaseBoneName, bHasBase, bBaseRelativePosition, ServerMovementMode);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "ClientVeryShortAdjustPosition", TimeStamp, NewLoc, NewBase, NewBaseBoneName, bHasBase, bBaseRelativePosition, ServerMovementMode);
}

void UManageCharacterMovementComponent::ClientVeryShortAdjustPosition_Implementation(float TimeStamp, FVector NewLoc, UPrimitiveComponent* NewBase, FName NewBaseBoneName, bool bHasBase, bool bBaseRelativePosition, uint8 ServerMovementMode)
{
	Super::ClientVeryShortAdjustPosition_Implementation(TimeStamp, NewLoc, NewBase, NewBaseBoneName, bHasBase, bBaseRelativePosition, ServerMovementMode);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "ClientVeryShortAdjustPosition_Implementation", TimeStamp, NewLoc, NewBase, NewBaseBoneName, bHasBase, bBaseRelativePosition, ServerMovementMode);
}

void UManageCharacterMovementComponent::Crouch(bool bClientSimulation)
{
	Super::Crouch(bClientSimulation);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "Crouch", bClientSimulation);
}

void UManageCharacterMovementComponent::DisableMovement()
{
	Super::DisableMovement();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "DisableMovement");
}

void UManageCharacterMovementComponent::ForceReplicationUpdate()
{
	Super::ForceReplicationUpdate();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "ForceReplicationUpdate");
}

void UManageCharacterMovementComponent::HandleSwimmingWallHit(const FHitResult& Hit, float DeltaTime)
{
	Super::HandleSwimmingWallHit(Hit, DeltaTime);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "HandleSwimmingWallHit", Hit, DeltaTime);
}

void UManageCharacterMovementComponent::JumpOff(AActor* MovementBaseActor)
{
	Super::JumpOff(MovementBaseActor);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "JumpOff", MovementBaseActor);
}

void UManageCharacterMovementComponent::JumpOutOfWater(FVector WallNormal)
{
	Super::JumpOutOfWater(WallNormal);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "JumpOutOfWater", WallNormal);
}

void UManageCharacterMovementComponent::Launch(const FVector& LaunchVel)
{
	Super::Launch(LaunchVel);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "Launch", LaunchVel);
}

void UManageCharacterMovementComponent::MaintainHorizontalGroundVelocity()
{
	Super::MaintainHorizontalGroundVelocity();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "MaintainHorizontalGroundVelocity");
}

void UManageCharacterMovementComponent::MaybeSaveBaseLocation()
{
	Super::MaybeSaveBaseLocation();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "MaybeSaveBaseLocation");
}

void UManageCharacterMovementComponent::MaybeUpdateBasedMovement(float DeltaSeconds)
{
	Super::MaybeUpdateBasedMovement(DeltaSeconds);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "MaybeUpdateBasedMovement", DeltaSeconds);
}

void UManageCharacterMovementComponent::MoveAutonomous(float ClientTimeStamp, float DeltaTime, uint8 CompressedFlags, const FVector& NewAccel)
{
	Super::MoveAutonomous(ClientTimeStamp, DeltaTime, CompressedFlags, NewAccel);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "MoveAutonomous", ClientTimeStamp, DeltaTime, CompressedFlags, NewAccel);
}

void UManageCharacterMovementComponent::NotifyJumpApex()
{
	Super::NotifyJumpApex();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "NotifyJumpApex");
}

void UManageCharacterMovementComponent::OnCharacterStuckInGeometry(const FHitResult* Hit)
{
	Super::OnCharacterStuckInGeometry(Hit);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnCharacterStuckInGeometry", Hit);
}

void UManageCharacterMovementComponent::OnClientTimeStampResetDetected()
{
	Super::OnClientTimeStampResetDetected();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnClientTimeStampResetDetected");
}

void UManageCharacterMovementComponent::OnMovementModeChanged(EMovementMode PreviousMovementMode, uint8 PreviousCustomMode)
{
	Super::OnMovementModeChanged(PreviousMovementMode, PreviousCustomMode);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnMovementModeChanged", PreviousMovementMode, PreviousCustomMode);
}

void UManageCharacterMovementComponent::OnMovementUpdated(float DeltaSeconds, const FVector& OldLocation, const FVector& OldVelocity)
{
	Super::OnMovementUpdated(DeltaSeconds, OldLocation, OldVelocity);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnMovementUpdated", DeltaSeconds, OldLocation, OldVelocity);
}

void UManageCharacterMovementComponent::OnTimeDiscrepancyDetected(float CurrentTimeDiscrepancy, float LifetimeRawTimeDiscrepancy, float Lifetime, float CurrentMoveError)
{
	Super::OnTimeDiscrepancyDetected(CurrentTimeDiscrepancy, LifetimeRawTimeDiscrepancy, Lifetime, CurrentMoveError);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnTimeDiscrepancyDetected", CurrentTimeDiscrepancy, LifetimeRawTimeDiscrepancy, Lifetime, CurrentMoveError);
}

void UManageCharacterMovementComponent::OnUnableToFollowBaseMove(const FVector& DeltaPosition, const FVector& OldLocation, const FHitResult& MoveOnBaseHit)
{
	Super::OnUnableToFollowBaseMove(DeltaPosition, OldLocation, MoveOnBaseHit);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnUnableToFollowBaseMove", DeltaPosition, OldLocation, MoveOnBaseHit);
}

void UManageCharacterMovementComponent::PerformAirControlForPathFollowing(FVector Direction, float ZDiff)
{
	Super::PerformAirControlForPathFollowing(Direction, ZDiff);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PerformAirControlForPathFollowing", Direction, ZDiff);
}

void UManageCharacterMovementComponent::PerformMovement(float DeltaTime)
{
	Super::PerformMovement(DeltaTime);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PerformMovement", DeltaTime);
}

void UManageCharacterMovementComponent::PhysCustom(float deltaTime, int32 Iterations)
{
	Super::PhysCustom(deltaTime, Iterations);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PhysCustom", deltaTime, Iterations);
}

void UManageCharacterMovementComponent::PhysFalling(float deltaTime, int32 Iterations)
{
	Super::PhysFalling(deltaTime, Iterations);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PhysFalling", deltaTime, Iterations);
}

void UManageCharacterMovementComponent::PhysFlying(float deltaTime, int32 Iterations)
{
	Super::PhysFlying(deltaTime, Iterations);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PhysFlying", deltaTime, Iterations);
}

void UManageCharacterMovementComponent::PhysicsRotation(float DeltaTime)
{
	Super::PhysicsRotation(DeltaTime);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PhysicsRotation", DeltaTime);
}

void UManageCharacterMovementComponent::PhysNavWalking(float deltaTime, int32 Iterations)
{
	Super::PhysNavWalking(deltaTime, Iterations);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PhysNavWalking", deltaTime, Iterations);
}

void UManageCharacterMovementComponent::PhysSwimming(float deltaTime, int32 Iterations)
{
	Super::PhysSwimming(deltaTime, Iterations);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PhysSwimming", deltaTime, Iterations);
}

void UManageCharacterMovementComponent::PhysWalking(float deltaTime, int32 Iterations)
{
	Super::PhysWalking(deltaTime, Iterations);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PhysWalking", deltaTime, Iterations);
}

void UManageCharacterMovementComponent::ProcessLanded(const FHitResult& Hit, float remainingTime, int32 Iterations)
{
	Super::ProcessLanded(Hit, remainingTime, Iterations);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "ProcessLanded", Hit, remainingTime, Iterations);
}

void UManageCharacterMovementComponent::ReplicateMoveToServer(float DeltaTime, const FVector& NewAcceleration)
{
	Super::ReplicateMoveToServer(DeltaTime, NewAcceleration);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "ReplicateMoveToServer", DeltaTime, NewAcceleration);
}

void UManageCharacterMovementComponent::SaveBaseLocation()
{
	Super::SaveBaseLocation();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "SaveBaseLocation");
}

void UManageCharacterMovementComponent::ServerMoveHandleClientError(float ClientTimeStamp, float DeltaTime, const FVector& Accel, const FVector& RelativeClientLocation, UPrimitiveComponent* ClientMovementBase, FName ClientBaseBoneName, uint8 ClientMovementMode)
{
	Super::ServerMoveHandleClientError(ClientTimeStamp, DeltaTime, Accel, RelativeClientLocation, ClientMovementBase, ClientBaseBoneName, ClientMovementMode);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "ServerMoveHandleClientError", ClientTimeStamp, DeltaTime, Accel, RelativeClientLocation, ClientMovementBase, ClientBaseBoneName, ClientMovementMode);
}

void UManageCharacterMovementComponent::SetBase(UPrimitiveComponent* NewBase, const FName BoneName, bool bNotifyActor)
{
	Super::SetBase(NewBase, BoneName, bNotifyActor);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "SetBase", NewBase, BoneName, bNotifyActor);
}

void UManageCharacterMovementComponent::SetDefaultMovementMode()
{
	Super::SetDefaultMovementMode();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "SetDefaultMovementMode");
}

void UManageCharacterMovementComponent::SetMovementMode(EMovementMode NewMovementMode, uint8 NewCustomMode)
{
	Super::SetMovementMode(NewMovementMode, NewCustomMode);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "SetMovementMode", NewMovementMode, NewCustomMode);
}

void UManageCharacterMovementComponent::SetNavWalkingPhysics(bool bEnable)
{
	Super::SetNavWalkingPhysics(bEnable);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "SetNavWalkingPhysics", bEnable);
}

void UManageCharacterMovementComponent::SetPostLandedPhysics(const FHitResult& Hit)
{
	Super::SetPostLandedPhysics(Hit);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "SetPostLandedPhysics", Hit);
}

void UManageCharacterMovementComponent::SimulateMovement(float DeltaTime)
{
	Super::SimulateMovement(DeltaTime);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "SimulateMovement", DeltaTime);
}

void UManageCharacterMovementComponent::SmoothClientPosition(float DeltaSeconds)
{
	Super::SmoothClientPosition(DeltaSeconds);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "SmoothClientPosition", DeltaSeconds);
}

void UManageCharacterMovementComponent::StartFalling(int32 Iterations, float remainingTime, float timeTick, const FVector& Delta, const FVector& subLoc)
{
	Super::StartFalling(Iterations, remainingTime, timeTick, Delta, subLoc);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "StartFalling", Iterations, remainingTime, timeTick, Delta, subLoc);
}

void UManageCharacterMovementComponent::StartNewPhysics(float deltaTime, int32 Iterations)
{
	Super::StartNewPhysics(deltaTime, Iterations);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "StartNewPhysics", deltaTime, Iterations);
}

void UManageCharacterMovementComponent::UnCrouch(bool bClientSimulation)
{
	Super::UnCrouch(bClientSimulation);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "UnCrouch", bClientSimulation);
}

void UManageCharacterMovementComponent::UpdateBasedMovement(float DeltaSeconds)
{
	Super::UpdateBasedMovement(DeltaSeconds);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "UpdateBasedMovement", DeltaSeconds);
}

void UManageCharacterMovementComponent::UpdateBasedRotation(FRotator& FinalRotation, const FRotator& ReducedRotation)
{
	Super::UpdateBasedRotation(FinalRotation, ReducedRotation);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "UpdateBasedRotation", FinalRotation, ReducedRotation);
}

void UManageCharacterMovementComponent::UpdateCharacterStateAfterMovement()
{
	Super::UpdateCharacterStateAfterMovement();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "UpdateCharacterStateAfterMovement");
}

void UManageCharacterMovementComponent::UpdateCharacterStateBeforeMovement()
{
	Super::UpdateCharacterStateBeforeMovement();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "UpdateCharacterStateBeforeMovement");
}

void UManageCharacterMovementComponent::UpdateFloorFromAdjustment()
{
	Super::UpdateFloorFromAdjustment();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "UpdateFloorFromAdjustment");
}

void UManageCharacterMovementComponent::UpdateFromCompressedFlags(uint8 Flags)
{
	Super::UpdateFromCompressedFlags(Flags);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "UpdateFromCompressedFlags", Flags);
}

PRAGMA_ENABLE_DEPRECATION_WARNINGS
