using System;
using System.Runtime.InteropServices;

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\Engine\Engine.h:189

namespace UnrealEngine
{
	public  partial class FNetDriverDefinition : NativeStructWrapper
	{
		internal FNetDriverDefinition(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FNetDriverDefinition() :
			base(E_CreateStruct_FNetDriverDefinition(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FNetDriverDefinition();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_FNetDriverDefinition_DefName_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FNetDriverDefinition_DefName_SET(IntPtr Ptr, string Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_FNetDriverDefinition_DriverClassName_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FNetDriverDefinition_DriverClassName_SET(IntPtr Ptr, string Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_FNetDriverDefinition_DriverClassNameFallback_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FNetDriverDefinition_DriverClassNameFallback_SET(IntPtr Ptr, string Value);
		
		#endregion
		
		#region Property
		public string DefName
		{
			get => E_PROP_FNetDriverDefinition_DefName_GET(NativePointer);
			set => E_PROP_FNetDriverDefinition_DefName_SET(NativePointer, value);
		}

		public string DriverClassName
		{
			get => E_PROP_FNetDriverDefinition_DriverClassName_GET(NativePointer);
			set => E_PROP_FNetDriverDefinition_DriverClassName_SET(NativePointer, value);
		}

		public string DriverClassNameFallback
		{
			get => E_PROP_FNetDriverDefinition_DriverClassNameFallback_GET(NativePointer);
			set => E_PROP_FNetDriverDefinition_DriverClassNameFallback_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FNetDriverDefinition Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FNetDriverDefinition(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FNetDriverDefinition(Adress, false);
		}}}
