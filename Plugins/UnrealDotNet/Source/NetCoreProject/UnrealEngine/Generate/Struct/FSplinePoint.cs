using System;
using System.Runtime.InteropServices;

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\Components\SplineComponent.h:113

namespace UnrealEngine
{
	public  partial class FSplinePoint : NativeStructWrapper
	{
		internal FSplinePoint(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		
		/// <summary>
		/// <para>Default constructor </para>
		/// </summary>
		public FSplinePoint() :
			base(E_CreateStruct_FSplinePoint(), false)
		{
		}

		
		/// <summary>
		/// <para>Constructor taking a point position </para>
		/// </summary>
		public FSplinePoint(float InInputKey, FVector InPosition) :
			base(E_CreateStruct_FSplinePoint_float_FVector(InInputKey, InPosition), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FSplinePoint();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FSplinePoint_float_FVector(float InInputKey, IntPtr InPosition);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FSplinePoint_ArriveTangent_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FSplinePoint_ArriveTangent_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FSplinePoint_InputKey_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FSplinePoint_InputKey_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FSplinePoint_LeaveTangent_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FSplinePoint_LeaveTangent_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FSplinePoint_Position_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FSplinePoint_Position_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FSplinePoint_Rotation_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FSplinePoint_Rotation_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FSplinePoint_Scale_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FSplinePoint_Scale_SET(IntPtr Ptr, IntPtr Value);
		
		#endregion
		
		#region Property
		public FVector ArriveTangent
		{
			get => E_PROP_FSplinePoint_ArriveTangent_GET(NativePointer);
			set => E_PROP_FSplinePoint_ArriveTangent_SET(NativePointer, value);
		}

		public float InputKey
		{
			get => E_PROP_FSplinePoint_InputKey_GET(NativePointer);
			set => E_PROP_FSplinePoint_InputKey_SET(NativePointer, value);
		}

		public FVector LeaveTangent
		{
			get => E_PROP_FSplinePoint_LeaveTangent_GET(NativePointer);
			set => E_PROP_FSplinePoint_LeaveTangent_SET(NativePointer, value);
		}

		public FVector Position
		{
			get => E_PROP_FSplinePoint_Position_GET(NativePointer);
			set => E_PROP_FSplinePoint_Position_SET(NativePointer, value);
		}

		public FRotator Rotation
		{
			get => E_PROP_FSplinePoint_Rotation_GET(NativePointer);
			set => E_PROP_FSplinePoint_Rotation_SET(NativePointer, value);
		}

		public FVector Scale
		{
			get => E_PROP_FSplinePoint_Scale_GET(NativePointer);
			set => E_PROP_FSplinePoint_Scale_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FSplinePoint Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FSplinePoint(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FSplinePoint(Adress, false);
		}}}
