using System;
using System.Runtime.InteropServices;

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\GameFramework\SaveGame.h:19

namespace UnrealEngine
{
	public  partial class USaveGame : UObject
	{
		public USaveGame(IntPtr Adress)
			: base(Adress)
		{
		}

		public USaveGame(UObject Parent = null, string Name = "SaveGame")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_USaveGame(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_USaveGame(IntPtr Parent, string Name);
		
		#endregion
		
		public static implicit operator IntPtr(USaveGame Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator USaveGame(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<USaveGame>(PtrDesc);
		}}}
