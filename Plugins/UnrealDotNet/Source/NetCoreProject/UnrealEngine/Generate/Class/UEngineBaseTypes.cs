using System;
using System.Runtime.InteropServices;

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\Engine\EngineBaseTypes.h:999

namespace UnrealEngine
{
	public  partial class UEngineBaseTypes : UObject
	{
		public UEngineBaseTypes(IntPtr Adress)
			: base(Adress)
		{
		}

		public static implicit operator IntPtr(UEngineBaseTypes Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator UEngineBaseTypes(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UEngineBaseTypes>(PtrDesc);
		}}}
