using System;
using System.Runtime.InteropServices;

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\Engine\Engine.h:515

namespace UnrealEngine
{
	public  partial class FGameNameRedirect : NativeStructWrapper
	{
		internal FGameNameRedirect(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FGameNameRedirect() :
			base(E_CreateStruct_FGameNameRedirect(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FGameNameRedirect();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_FGameNameRedirect_NewGameName_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FGameNameRedirect_NewGameName_SET(IntPtr Ptr, string Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_FGameNameRedirect_OldGameName_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FGameNameRedirect_OldGameName_SET(IntPtr Ptr, string Value);
		
		#endregion
		
		#region Property
		public string NewGameName
		{
			get => E_PROP_FGameNameRedirect_NewGameName_GET(NativePointer);
			set => E_PROP_FGameNameRedirect_NewGameName_SET(NativePointer, value);
		}

		public string OldGameName
		{
			get => E_PROP_FGameNameRedirect_OldGameName_GET(NativePointer);
			set => E_PROP_FGameNameRedirect_OldGameName_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FGameNameRedirect Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FGameNameRedirect(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FGameNameRedirect(Adress, false);
		}}}
