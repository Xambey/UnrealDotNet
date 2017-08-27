using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	
	/// <summary>
	/// Actor is the base class for an Object that can be placed or spawned in a level.
	/// Actors may contain a collection of ActorComponents, which can be used to control how actors move, how they are rendered, etc.
	/// The other main function of an Actor is the replication of properties and function calls across the network during play.
	/// @see https://docs.unrealengine.com/latest/INT/Programming/UnrealArchitecture/Actors
	/// @see UActorComponent
	/// </summary>
	public partial class AActor : UObject
	{
		public AActor(IntPtr Adress)
			: base(Adress)
		{
		}

		
		#region DLLInmport
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_AActor_OnRep_ReplicateMovement(IntPtr Self);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_AActor_SetReplicates(IntPtr Self, bool bInReplicates);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_AActor_SetAutonomousProxy(IntPtr Self, bool bInAutonomousProxy, bool bAllowForcePropertyCompare);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_AActor_CopyRemoteRoleFrom(IntPtr Self, AActor CopyFromActor);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_AActor_OnSubobjectCreatedFromReplication(IntPtr Self, UObject NewSubobject);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern bool E_AActor_AllowReceiveTickEventOnDedicatedServer(IntPtr Self);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern FTransform E_AActor_GetTransform(IntPtr Self);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern FVector E_AActor_K2_GetActorLocation(IntPtr Self);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern FRotator E_AActor_K2_GetActorRotation(IntPtr Self);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_AActor_GetActorBounds(IntPtr Self, bool bOnlyCollidingComponents, FVector Origin, FVector BoxExtent);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern bool E_AActor_K2_SetActorRotation(IntPtr Self, FRotator NewRotation, bool bTeleportPhysics);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_AActor_SetActorScale3D(IntPtr Self, FVector NewScale3D);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern float E_AActor_GetDistanceTo(IntPtr Self, AActor OtherActor);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern float E_AActor_GetActorTimeDilation(IntPtr Self);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_AActor_SetTickPrerequisite(IntPtr Self, AActor PrerequisiteActor);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern bool E_AActor_GetTickableWhenPaused(IntPtr Self);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern float E_AActor_GetGameTimeSinceCreation(IntPtr Self);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_AActor_ReceiveTick(IntPtr Self, float DeltaSeconds);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern bool E_AActor_Destroy(IntPtr Self, bool bNetForce, bool bShouldModifyLevel);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern bool E_AActor_IsOwnedBy(IntPtr Self, AActor TestOwner);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern FQuat E_AActor_GetActorQuat(IntPtr Self);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_AActor_ApplyWorldOffset(IntPtr Self, FVector InOffset, bool bWorldShift);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_AActor_RegisterAllActorTickFunctions(IntPtr Self, bool bRegister, bool bDoComponents);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_AActor_PostNetReceiveVelocity(IntPtr Self, FVector NewVelocity);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern AActor E_AActor_GetOwner(IntPtr Self);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern bool E_AActor_IsReplayRelevantFor(IntPtr Self, AActor RealViewer, AActor ViewTarget, FVector SrcLocation, float CullDistanceSquared);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern bool E_AActor_IsRelevancyOwnerFor(IntPtr Self, AActor ReplicatedActor, AActor ActorOwner, AActor ConnectionActor);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern bool E_AActor_IncrementalRegisterComponents(IntPtr Self, int NumComponentsToRegister);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern bool E_AActor_TeleportTo(IntPtr Self, FVector DestLocation, FRotator DestRotation, bool bIsATest, bool bNoCheck);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern bool E_AActor_K2_TeleportTo(IntPtr Self, FVector DestLocation, FRotator DestRotation);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_AActor_DebugShowComponentHierarchy(IntPtr Self, string Info, bool bShowPosition);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_AActor_OnConstruction(IntPtr Self, FTransform Transform);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// Allow each actor to run at a different time speed. The DeltaTime for a frame is multiplied by the global TimeDilation (in WorldSettings) and this CustomTimeDilation for this actor's tick.
		/// </summary>
		public float CustomTimeDilation { get; set; } 
		
		/// <summary>
		/// Allows us to only see this Actor in the Editor, and not in the actual game.
		/// @see SetActorHiddenInGame()
		/// </summary>
		public byte ActorHiddenInGame { get; set; } 
		public byte bNetTemporary { get; set; } 
		public byte bNetStartup { get; set; } 
		
		/// <summary>
		/// If true, this actor is only relevant to its owner. If this flag is changed during play, all non-owner channels would need to be explicitly closed.
		/// </summary>
		public byte bOnlyRelevantToOwner { get; set; } 
		
		/// <summary>
		/// Always relevant for network (overrides bOnlyRelevantToOwner).
		/// </summary>
		public byte bAlwaysRelevant { get; set; } 
		
		/// <summary>
		/// If true, replicate movement/location related properties.
		/// Actor must also be set to replicate.
		/// @see SetReplicates()
		/// @see https://docs.unrealengine.com/latest/INT/Gameplay/Networking/Replication
		/// </summary>
		public byte bReplicateMovement { get; set; } 
		public byte bTearOff { get; set; } 
		public byte bExchangedRoles { get; set; } 
		
		/// <summary>
		/// Is this actor still pending a full net update due to clients that weren't able to replicate the actor at the time of LastNetUpdateTime
		/// </summary>
		public byte bPendingNetUpdate { get; set; } 
		
		/// <summary>
		/// This actor will be loaded on network clients during map load
		/// </summary>
		public byte bNetLoadOnClient { get; set; } 
		
		/// <summary>
		/// If actor has valid Owner, call Owner's IsNetRelevantFor and GetNetPriority
		/// </summary>
		public byte bNetUseOwnerRelevancy { get; set; } 
		
		/// <summary>
		/// If true, all input on the stack below this actor will not be considered
		/// </summary>
		public byte bBlockInput { get; set; } 
		
		/// <summary>
		/// True if this actor is currently running user construction script (used to defer component registration)
		/// </summary>
		public byte bRunningUserConstructionScript { get; set; } 
		
		/// <summary>
		/// Whether we allow this Actor to tick before it receives the BeginPlay event.
		/// Normally we don't tick actors until after BeginPlay; this setting allows this behavior to be overridden.
		/// This Actor must be able to tick for this setting to be relevant.
		/// </summary>
		public byte bAllowTickBeforeBeginPlay { get; set; } 
		
		/// <summary>
		/// The priority of this input component when pushed in to the stack.
		/// </summary>
		public int InputPriority { get; set; } 
		
		/// <summary>
		/// Square of the max distance from the client's viewpoint that this actor is relevant and will be replicated.
		/// </summary>
		public float NetCullDistanceSquared { get; set; } 
		public int NetTag { get; set; } 
		
		/// <summary>
		/// Next time this actor will be considered for replication, set by SetNetUpdateTime()
		/// </summary>
		public float NetUpdateTime { get; set; } 
		
		/// <summary>
		/// How often (per second) this actor will be considered for replication, used to determine NetUpdateTime
		/// </summary>
		public float NetUpdateFrequency { get; set; } 
		
		/// <summary>
		/// Used to determine what rate to throttle down to when replicated properties are changing infrequently
		/// </summary>
		public float MinNetUpdateFrequency { get; set; } 
		
		/// <summary>
		/// Priority for this actor when checking for replication in a low bandwidth or saturated situation, higher priority means it is more likely to replicate
		/// </summary>
		public float NetPriority { get; set; } 
		
		/// <summary>
		/// Last time this actor was updated for replication via NetUpdateTime
		/// @warning: internal net driver time, not related to WorldSettings.TimeSeconds
		/// </summary>
		public float LastNetUpdateTime { get; set; } 
		
		/// <summary>
		/// If true then destroy self when "finished", meaning all relevant components report that they are done and no timelines or timers are in flight.
		/// </summary>
		public byte bAutoDestroyWhenFinished { get; set; } 
		
		/// <summary>
		/// Whether this actor can take damage. Must be true for damage events (e.g. ReceiveDamage()) to be called.
		/// @see https://www.unrealengine.com/blog/damage-in-ue4
		/// @see TakeDamage(), ReceiveDamage()
		/// </summary>
		public byte bCanBeDamaged { get; set; } 
		public byte bCollideWhenPlacing { get; set; } 
		
		/// <summary>
		/// If true, this actor should search for an owned camera component to view through when used as a view target.
		/// </summary>
		public byte bFindCameraComponentWhenViewTarget { get; set; } 
		public byte bRelevantForNetworkReplays { get; set; } 
		
		/// <summary>
		/// If true, this actor will generate overlap events when spawned as part of level streaming. You might enable this is in the case where a streaming level loads around an actor and you want overlaps to trigger.
		/// </summary>
		public byte bGenerateOverlapEventsDuringLevelStreaming { get; set; } 
		
		/// <summary>
		/// The time this actor was created, relative to World->GetTimeSeconds().
		/// @see UWorld::GetTimeSeconds()
		/// </summary>
		public float CreationTime { get; set; } 
		public byte bActorSeamlessTraveled { get; set; } 
		
		/// <summary>
		/// Whether this actor should not be affected by world origin shifting.
		/// </summary>
		public byte bIgnoresOriginShifting { get; set; } 
		
		/// <summary>
		/// If true, and if World setting has bEnableHierarchicalLOD equal to true, then it will generate LODActor from groups of clustered Actor
		/// </summary>
		public byte bEnableAutoLODGeneration { get; set; } 
		#endregion
		
		#region ExternMethods
		public void OnRep_ReplicateMovement()
			=> E_AActor_OnRep_ReplicateMovement(NativePointer);
		
		
		/// <summary>
		/// Set whether this actor replicates to network clients. When this actor is spawned on the server it will be sent to clients as well.
		/// Properties flagged for replication will update on clients if they change on the server.
		/// Internally changes the RemoteRole property and handles the cases where the actor needs to be added to the network actor list.
		/// @param bInReplicates Whether this Actor replicates to network clients.
		/// @see https://docs.unrealengine.com/latest/INT/Gameplay/Networking/Replication
		/// </summary>
		public void SetReplicates(bool bInReplicates)
			=> E_AActor_SetReplicates(NativePointer, bInReplicates);
		
		
		/// <summary>
		/// Sets whether or not this Actor is an autonomous proxy, which is an actor on a network client that is controlled by a user on that client.
		/// </summary>
		public void SetAutonomousProxy(bool bInAutonomousProxy, bool bAllowForcePropertyCompare = true)
			=> E_AActor_SetAutonomousProxy(NativePointer, bInAutonomousProxy, bAllowForcePropertyCompare);
		
		
		/// <summary>
		/// Copies RemoteRole from another Actor and adds this actor to the list of network actors if necessary.
		/// </summary>
		public void CopyRemoteRoleFrom(AActor CopyFromActor)
			=> E_AActor_CopyRemoteRoleFrom(NativePointer, CopyFromActor);
		
		
		/// <summary>
		/// Called on the actor when a new subobject is dynamically created via replication
		/// </summary>
		public void OnSubobjectCreatedFromReplication(UObject NewSubobject)
			=> E_AActor_OnSubobjectCreatedFromReplication(NativePointer, NewSubobject);
		
		
		/// <summary>
		/// Return the value of bAllowReceiveTickEventOnDedicatedServer, indicating whether the Blueprint ReceiveTick() event will occur on dedicated servers.
		/// </summary>
		public bool AllowReceiveTickEventOnDedicatedServer()
			=> E_AActor_AllowReceiveTickEventOnDedicatedServer(NativePointer);
		
		
		/// <summary>
		/// Get the actor-to-world transform.
		/// @return The transform that transforms from actor space to world space.
		/// </summary>
		public FTransform GetActorTransform()
			=> E_AActor_GetTransform(NativePointer);
		
		
		/// <summary>
		/// Returns the location of the RootComponent of this Actor
		/// </summary>
		public FVector GetActorLocation()
			=> E_AActor_K2_GetActorLocation(NativePointer);
		
		
		/// <summary>
		/// Returns rotation of the RootComponent of this Actor.
		/// </summary>
		public FRotator GetActorRotation()
			=> E_AActor_K2_GetActorRotation(NativePointer);
		
		
		/// <summary>
		/// Returns the bounding box of all components that make up this Actor (excluding ChildActorComponents).
		/// @param	bOnlyCollidingComponents	If true, will only return the bounding box for components with collision enabled.
		/// </summary>
		public void GetActorBounds(bool bOnlyCollidingComponents, FVector Origin, FVector BoxExtent)
			=> E_AActor_GetActorBounds(NativePointer, bOnlyCollidingComponents, Origin, BoxExtent);
		
		
		/// <summary>
		/// Set the Actor's rotation instantly to the specified rotation.
		/// @param	NewRotation	The new rotation for the Actor.
		/// @param	bTeleportPhysics Whether we teleport the physics state (if physics collision is enabled for this object).
		/// If true, physics velocity for this object is unchanged (so ragdoll parts are not affected by change in location).
		/// If false, physics velocity is updated based on the change in position (affecting ragdoll parts).
		/// @return	Whether the rotation was successfully set.
		/// </summary>
		public bool SetActorRotation(FRotator NewRotation, bool bTeleportPhysics)
			=> E_AActor_K2_SetActorRotation(NativePointer, NewRotation, bTeleportPhysics);
		
		
		/// <summary>
		/// Set the Actor's world-space scale.
		/// </summary>
		public void SetActorScale3D(FVector NewScale3D)
			=> E_AActor_SetActorScale3D(NativePointer, NewScale3D);
		
		
		/// <summary>
		/// Returns the distance from this Actor to OtherActor.
		/// </summary>
		public float GetDistanceTo(AActor OtherActor)
			=> E_AActor_GetDistanceTo(NativePointer, OtherActor);
		
		
		/// <summary>
		/// Get CustomTimeDilation - this can be used for input control or speed control for slomo.
		/// We don't want to scale input globally because input can be used for UI, which do not care for TimeDilation.
		/// </summary>
		public float GetActorTimeDilation()
			=> E_AActor_GetActorTimeDilation(NativePointer);
		
		public void SetTickPrerequisite(AActor PrerequisiteActor)
			=> E_AActor_SetTickPrerequisite(NativePointer, PrerequisiteActor);
		
		
		/// <summary>
		/// Gets whether this actor can tick when paused.
		/// </summary>
		public bool GetTickableWhenPaused()
			=> E_AActor_GetTickableWhenPaused(NativePointer);
		
		
		/// <summary>
		/// The number of seconds (in game time) since this Actor was created, relative to Get Game Time In Seconds.
		/// </summary>
		public float GetGameTimeSinceCreation()
			=> E_AActor_GetGameTimeSinceCreation(NativePointer);
		
		
		/// <summary>
		/// Event called every frame
		/// </summary>
		public void Tick(float DeltaSeconds)
			=> E_AActor_ReceiveTick(NativePointer, DeltaSeconds);
		
		
		/// <summary>
		/// Destroy this actor. Returns true the actor is destroyed or already marked for destruction, false if indestructible.
		/// Destruction is latent. It occurs at the end of the tick.
		/// @param	bNetForce				[opt] Ignored unless called during play.  Default is false.
		/// @param	bShouldModifyLevel		[opt] If true, Modify() the level before removing the actor.  Default is true.
		/// returns	true if destroyed or already marked for destruction, false if indestructible.
		/// </summary>
		public bool Destroy(bool bNetForce = false, bool bShouldModifyLevel = true)
			=> E_AActor_Destroy(NativePointer, bNetForce, bShouldModifyLevel);
		
		
		/// <summary>
		/// See if this actor is owned by TestOwner.
		/// </summary>
		public bool IsOwnedBy(AActor TestOwner)
			=> E_AActor_IsOwnedBy(NativePointer, TestOwner);
		
		
		/// <summary>
		/// Returns the quaternion of the RootComponent of this Actor
		/// </summary>
		public FQuat GetActorQuat()
			=> E_AActor_GetActorQuat(NativePointer);
		
		
		/// <summary>
		/// Called by owning level to shift an actor location and all relevant data structures by specified delta
		/// @param InWorldOffset	 Offset vector to shift actor location
		/// @param bWorldShift	 Whether this call is part of whole world shifting
		/// </summary>
		public void ApplyWorldOffset(FVector InOffset, bool bWorldShift)
			=> E_AActor_ApplyWorldOffset(NativePointer, InOffset, bWorldShift);
		
		
		/// <summary>
		/// When called, will call the virtual call chain to register all of the tick functions for both the actor and optionally all components
		/// Do not override this function or make it virtual
		/// @param bRegister - true to register, false, to unregister
		/// @param bDoComponents - true to also apply the change to all components
		/// </summary>
		public void RegisterAllActorTickFunctions(bool bRegister, bool bDoComponents)
			=> E_AActor_RegisterAllActorTickFunctions(NativePointer, bRegister, bDoComponents);
		
		
		/// <summary>
		/// Update velocity - typically from ReplicatedMovement, not called for simulated physics!
		/// </summary>
		public void PostNetReceiveVelocity(FVector NewVelocity)
			=> E_AActor_PostNetReceiveVelocity(NativePointer, NewVelocity);
		
		
		/// <summary>
		/// Get the owner of this Actor, used primarily for network replication.
		/// @return Actor that owns this Actor
		/// </summary>
		public AActor GetOwner()
			=> E_AActor_GetOwner(NativePointer);
		
		
		/// <summary>
		/// @param RealViewer - is the "controlling net object" associated with the client for which network relevancy is being checked (typically player controller)
		/// @param ViewTarget - is the Actor being used as the point of view for the RealViewer
		/// @param SrcLocation - is the viewing location
		/// @return bool - true if this actor is replay relevant to the client associated with RealViewer
		/// </summary>
		public bool IsReplayRelevantFor(AActor RealViewer, AActor ViewTarget, FVector SrcLocation, float CullDistanceSquared)
			=> E_AActor_IsReplayRelevantFor(NativePointer, RealViewer, ViewTarget, SrcLocation, CullDistanceSquared);
		
		
		/// <summary>
		/// Check if this actor is the owner when doing relevancy checks for actors marked bOnlyRelevantToOwner
		/// @param ReplicatedActor - the actor we're doing a relevancy test on
		/// @param ActorOwner - the owner of ReplicatedActor
		/// @param ConnectionActor - the controller of the connection that we're doing relevancy checks for
		/// @return bool - true if this actor should be considered the owner
		/// </summary>
		public bool IsRelevancyOwnerFor(AActor ReplicatedActor, AActor ActorOwner, AActor ConnectionActor)
			=> E_AActor_IsRelevancyOwnerFor(NativePointer, ReplicatedActor, ActorOwner, ConnectionActor);
		
		
		/// <summary>
		/// Incrementally registers components associated with this actor
		/// @param NumComponentsToRegister  Number of components to register in this run, 0 for all
		/// @return true when all components were registered for this actor
		/// </summary>
		public bool IncrementalRegisterComponents(int NumComponentsToRegister)
			=> E_AActor_IncrementalRegisterComponents(NativePointer, NumComponentsToRegister);
		
		
		/// <summary>
		/// Used for adding actors to levels or teleporting them to a new location.
		/// The result of this function is independent of the actor's current location and rotation.
		/// If the actor doesn't fit exactly at the location specified, tries to slightly move it out of walls and such if bNoCheck is false.
		/// @param DestLocation The target destination point
		/// @param DestRotation The target rotation at the destination
		/// @param bIsATest is true if this is a test movement, which shouldn't cause any notifications (used by AI pathfinding, for example)
		/// @param bNoCheck is true if we should skip checking for encroachment in the world or other actors
		/// @return true if the actor has been successfully moved, or false if it couldn't fit.
		/// </summary>
		public bool TeleportTo(FVector DestLocation, FRotator DestRotation, bool bIsATest = false, bool bNoCheck = false)
			=> E_AActor_TeleportTo(NativePointer, DestLocation, DestRotation, bIsATest, bNoCheck);
		
		
		/// <summary>
		/// Teleport this actor to a new location. If the actor doesn't fit exactly at the location specified, tries to slightly move it out of walls and such.
		/// @param DestLocation The target destination point
		/// @param DestRotation The target rotation at the destination
		/// @return true if the actor has been successfully moved, or false if it couldn't fit.
		/// </summary>
		public bool Teleport(FVector DestLocation, FRotator DestRotation)
			=> E_AActor_K2_TeleportTo(NativePointer, DestLocation, DestRotation);
		
		
		/// <summary>
		/// Debug helper to show the component hierarchy of this actor.
		/// @param Info	Optional String to display at top of info
		/// </summary>
		public void DebugShowComponentHierarchy(string Info, bool bShowPosition = true)
			=> E_AActor_DebugShowComponentHierarchy(NativePointer, Info, bShowPosition);
		
		
		/// <summary>
		/// Called when an instance of this class is placed (in editor) or spawned.
		/// @param	Transform			The transform the actor was constructed at.
		/// </summary>
		public void OnConstruction(FTransform Transform)
			=> E_AActor_OnConstruction(NativePointer, Transform);
		
		#endregion
		
		public static explicit operator IntPtr(AActor Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator AActor(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new AActor(Adress);
		}}}
