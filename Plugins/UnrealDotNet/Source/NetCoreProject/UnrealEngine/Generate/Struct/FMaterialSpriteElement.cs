using System;
using System.Runtime.InteropServices;

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\Components\MaterialBillboardComponent.h:16

namespace UnrealEngine
{
	public  partial class FMaterialSpriteElement : NativeStructWrapper
	{
		internal FMaterialSpriteElement(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FMaterialSpriteElement() :
			base(E_CreateStruct_FMaterialSpriteElement(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FMaterialSpriteElement();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FMaterialSpriteElement_BaseSizeX_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FMaterialSpriteElement_BaseSizeX_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FMaterialSpriteElement_BaseSizeY_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FMaterialSpriteElement_BaseSizeY_SET(IntPtr Ptr, float Value);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// <para>The base width of the sprite, multiplied with the DistanceToSizeCurve. </para>
		/// </summary>
		public float BaseSizeX
		{
			get => E_PROP_FMaterialSpriteElement_BaseSizeX_GET(NativePointer);
			set => E_PROP_FMaterialSpriteElement_BaseSizeX_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>The base height of the sprite, multiplied with the DistanceToSizeCurve. </para>
		/// </summary>
		public float BaseSizeY
		{
			get => E_PROP_FMaterialSpriteElement_BaseSizeY_GET(NativePointer);
			set => E_PROP_FMaterialSpriteElement_BaseSizeY_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FMaterialSpriteElement Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FMaterialSpriteElement(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FMaterialSpriteElement(Adress, false);
		}}}
