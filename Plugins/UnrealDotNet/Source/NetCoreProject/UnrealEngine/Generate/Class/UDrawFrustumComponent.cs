using System;
using System.Runtime.InteropServices;

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\Components\DrawFrustumComponent.h:18

namespace UnrealEngine
{
	public  partial class UDrawFrustumComponent : UPrimitiveComponent
	{
		public UDrawFrustumComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		public UDrawFrustumComponent(UObject Parent = null, string Name = "DrawFrustumComponent")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UDrawFrustumComponent(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UDrawFrustumComponent(IntPtr Parent, string Name);
		
		#endregion
		
		public static implicit operator IntPtr(UDrawFrustumComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator UDrawFrustumComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UDrawFrustumComponent>(PtrDesc);
		}}}
