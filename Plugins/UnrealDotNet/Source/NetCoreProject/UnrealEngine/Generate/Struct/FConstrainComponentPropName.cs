using System;
using System.Runtime.InteropServices;

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\Engine\EngineTypes.h:3290

namespace UnrealEngine
{
	public  partial class FConstrainComponentPropName : NativeStructWrapper
	{
		internal FConstrainComponentPropName(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FConstrainComponentPropName() :
			base(E_CreateStruct_FConstrainComponentPropName(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FConstrainComponentPropName();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_FConstrainComponentPropName_ComponentName_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FConstrainComponentPropName_ComponentName_SET(IntPtr Ptr, string Value);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// <para>Name of property </para>
		/// </summary>
		public string ComponentName
		{
			get => E_PROP_FConstrainComponentPropName_ComponentName_GET(NativePointer);
			set => E_PROP_FConstrainComponentPropName_ComponentName_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FConstrainComponentPropName Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FConstrainComponentPropName(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FConstrainComponentPropName(Adress, false);
		}}}
