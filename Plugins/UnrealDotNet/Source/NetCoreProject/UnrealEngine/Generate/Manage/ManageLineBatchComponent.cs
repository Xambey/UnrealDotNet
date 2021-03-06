using System;
using System.Runtime.InteropServices;

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\Components\LineBatchComponent.h:120

namespace UnrealEngine
{
	public partial class ManageLineBatchComponent : ULineBatchComponent
	{
		public ManageLineBatchComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		public static implicit operator IntPtr(ManageLineBatchComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator ManageLineBatchComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManageLineBatchComponent>(PtrDesc);
		}}}
