using System;
using System.Runtime.InteropServices;

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\Components\ChildActorComponent.h:44

namespace UnrealEngine
{
	public  partial class UChildActorComponent : USceneComponent
	{
		public UChildActorComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		public UChildActorComponent(UObject Parent = null, string Name = "ChildActorComponent")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UChildActorComponent(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UChildActorComponent(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UChildActorComponent_CreateChildActor(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UChildActorComponent_DestroyChildActor(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_UChildActorComponent_GetChildActor(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_UChildActorComponent_GetChildActorName(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_UChildActorComponent_GetChildActorTemplate(IntPtr Self);
		
		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// <para>Create the child actor </para>
		/// </summary>
		public void CreateChildActor()
			=> E_UChildActorComponent_CreateChildActor(this);
		
		
		/// <summary>
		/// <para>Kill any currently present child actor </para>
		/// </summary>
		public void DestroyChildActor()
			=> E_UChildActorComponent_DestroyChildActor(this);
		
		public AActor GetChildActor()
			=> E_UChildActorComponent_GetChildActor(this);
		
		public string GetChildActorName()
			=> E_UChildActorComponent_GetChildActorName(this);
		
		public AActor GetChildActorTemplate()
			=> E_UChildActorComponent_GetChildActorTemplate(this);
		
		#endregion
		
		public static implicit operator IntPtr(UChildActorComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator UChildActorComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UChildActorComponent>(PtrDesc);
		}}}
