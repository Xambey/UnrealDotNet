using System;
using System.Runtime.InteropServices;

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\Components\DirectionalLightComponent.h:18

namespace UnrealEngine
{
	public  partial class UDirectionalLightComponent : ULightComponent
	{
		public UDirectionalLightComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		public UDirectionalLightComponent(UObject Parent = null, string Name = "DirectionalLightComponent")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UDirectionalLightComponent(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UDirectionalLightComponent(IntPtr Parent, string Name);
		
		#endregion
		
		public static implicit operator IntPtr(UDirectionalLightComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator UDirectionalLightComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UDirectionalLightComponent>(PtrDesc);
		}}}
