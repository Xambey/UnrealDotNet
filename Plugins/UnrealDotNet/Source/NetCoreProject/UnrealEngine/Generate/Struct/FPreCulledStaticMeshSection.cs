using System;
using System.Runtime.InteropServices;

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\Components\StaticMeshComponent.h:67

namespace UnrealEngine
{
	public  partial class FPreCulledStaticMeshSection : NativeStructWrapper
	{
		internal FPreCulledStaticMeshSection(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FPreCulledStaticMeshSection() :
			base(E_CreateStruct_FPreCulledStaticMeshSection(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FPreCulledStaticMeshSection();
		
		#endregion
		
		public static implicit operator IntPtr(FPreCulledStaticMeshSection Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FPreCulledStaticMeshSection(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FPreCulledStaticMeshSection(Adress, false);
		}}}
