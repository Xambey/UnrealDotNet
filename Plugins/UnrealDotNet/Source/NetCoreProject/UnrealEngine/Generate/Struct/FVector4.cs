using System;
using System.Runtime.InteropServices;

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Core\Public\Math\Vector4.h:17

namespace UnrealEngine
{
	public  partial class FVector4 : NativeStructWrapper
	{
		internal FVector4(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		
		/// <summary>
		/// <para>Constructor. </para>
		/// <param name="InVector">3D Vector to set first three components. </param>
		/// <param name="InW">W Coordinate. </param>
		/// </summary>
		public FVector4(FVector InVector, float InW) :
			base(E_CreateStruct_FVector4_FVector_float(InVector, InW), false)
		{
		}

		
		/// <summary>
		/// <para>Creates and initializes a new vector from the specified components. </para>
		/// <param name="InX">X Coordinate. </param>
		/// <param name="InY">Y Coordinate. </param>
		/// <param name="InZ">Z Coordinate. </param>
		/// <param name="InW">W Coordinate. </param>
		/// </summary>
		public FVector4(float InX, float InY, float InZ, float InW) :
			base(E_CreateStruct_FVector4_float_float_float_float(InX, InY, InZ, InW), false)
		{
		}

		
		/// <summary>
		/// <para>Creates and initializes a new vector from the specified 2D vectors. </para>
		/// <param name="InXY">A 2D vector holding the X- and Y-components. </param>
		/// <param name="InZW">A 2D vector holding the Z- and W-components. </param>
		/// </summary>
		public FVector4(FVector2D InXY, FVector2D InZW) :
			base(E_CreateStruct_FVector4_FVector2D_FVector2D(InXY, InZW), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FVector4_FVector_float(IntPtr InVector, float InW);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FVector4_float_float_float_float(float InX, float InY, float InZ, float InW);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FVector4_FVector2D_FVector2D(IntPtr InXY, IntPtr InZW);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FVector4_W_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FVector4_W_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FVector4_X_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FVector4_X_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FVector4_Y_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FVector4_Y_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FVector4_Z_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FVector4_Z_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FVector4_ContainsNaN(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FVector4_DiagnosticCheckNaN(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FVector4_Equals(IntPtr Self, IntPtr V, float Tolerance);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FVector4_FindBestAxisVectors3(IntPtr Self, IntPtr Axis1, IntPtr Axis2);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FVector4_GetSafeNormal(IntPtr Self, float Tolerance);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FVector4_GetUnsafeNormal3(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FVector4_InitFromString(IntPtr Self, string InSourceString);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FVector4_IsNearlyZero3(IntPtr Self, float Tolerance);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FVector4_IsUnit3(IntPtr Self, float LengthSquaredTolerance);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FVector4_Reflect3(IntPtr Self, IntPtr Normal);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FVector4_Rotation(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FVector4_Set(IntPtr Self, float InX, float InY, float InZ, float InW);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_FVector4_Size(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_FVector4_Size3(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_FVector4_SizeSquared(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_FVector4_SizeSquared3(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FVector4_ToOrientationQuat(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FVector4_ToOrientationRotator(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_FVector4_ToString(IntPtr Self);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// <para>The vector's W-component. </para>
		/// </summary>
		public float W
		{
			get => E_PROP_FVector4_W_GET(NativePointer);
			set => E_PROP_FVector4_W_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>The vector's X-component. </para>
		/// </summary>
		public float X
		{
			get => E_PROP_FVector4_X_GET(NativePointer);
			set => E_PROP_FVector4_X_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>The vector's Y-component. </para>
		/// </summary>
		public float Y
		{
			get => E_PROP_FVector4_Y_GET(NativePointer);
			set => E_PROP_FVector4_Y_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>The vector's Z-component. </para>
		/// </summary>
		public float Z
		{
			get => E_PROP_FVector4_Z_GET(NativePointer);
			set => E_PROP_FVector4_Z_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// <para>Utility to check if there are any non-finite values (NaN or Inf) in this vector. </para>
		/// </summary>
		public bool ContainsNaN()
			=> E_FVector4_ContainsNaN(this);
		
		public void DiagnosticCheckNaN()
			=> E_FVector4_DiagnosticCheckNaN(this);
		
		
		/// <summary>
		/// <para>Error tolerant comparison. </para>
		/// <param name="V">Vector to compare against. </param>
		/// <param name="Tolerance">Error Tolerance. </param>
		/// <return>true if the two vectors are equal within specified tolerance, otherwise false. </return>
		/// </summary>
		public bool Equals(FVector4 V, float Tolerance)
			=> E_FVector4_Equals(this, V, Tolerance);
		
		
		/// <summary>
		/// <para>Find good arbitrary axis vectors to represent U and V axes of a plane, </para>
		/// <para>given just the normal. </para>
		/// </summary>
		public void FindBestAxisVectors3(FVector4 Axis1, FVector4 Axis2)
			=> E_FVector4_FindBestAxisVectors3(this, Axis1, Axis2);
		
		
		/// <summary>
		/// <para>Returns a normalized copy of the vector if safe to normalize. </para>
		/// <param name="Tolerance">Minimum squared length of vector for normalization. </param>
		/// <return>A normalized copy of the vector or a zero vector. </return>
		/// </summary>
		public FVector4 GetSafeNormal(float Tolerance)
			=> E_FVector4_GetSafeNormal(this, Tolerance);
		
		
		/// <summary>
		/// <para>Calculates normalized version of vector without checking if it is non-zero. </para>
		/// <return>Normalized version of vector. </return>
		/// </summary>
		public FVector4 GetUnsafeNormal3()
			=> E_FVector4_GetUnsafeNormal3(this);
		
		
		/// <summary>
		/// <para>Initialize this Vector based on an FString. The String is expected to contain X=, Y=, Z=, W=. </para>
		/// <para>The FVector4 will be bogus when InitFromString returns false. </para>
		/// <param name="InSourceString">FString containing the vector values. </param>
		/// <return>true if the X,Y,Z values were read successfully; false otherwise. </return>
		/// </summary>
		public bool InitFromString(string InSourceString)
			=> E_FVector4_InitFromString(this, InSourceString);
		
		
		/// <summary>
		/// <para>Utility to check if all of the components of this vector are nearly zero given the tolerance. </para>
		/// </summary>
		public bool IsNearlyZero3(float Tolerance)
			=> E_FVector4_IsNearlyZero3(this, Tolerance);
		
		
		/// <summary>
		/// <para>Check if the vector is of unit length, with specified tolerance. </para>
		/// <param name="LengthSquaredTolerance">Tolerance against squared length. </param>
		/// <return>true if the vector is a unit vector within the specified tolerance. </return>
		/// </summary>
		public bool IsUnit3(float LengthSquaredTolerance)
			=> E_FVector4_IsUnit3(this, LengthSquaredTolerance);
		
		
		/// <summary>
		/// <para>Reflect vector. </para>
		/// </summary>
		public FVector4 Reflect3(FVector4 Normal)
			=> E_FVector4_Reflect3(this, Normal);
		
		
		/// <summary>
		/// <para>Return the FRotator orientation corresponding to the direction in which the vector points. </para>
		/// <para>Sets Yaw and Pitch to the proper numbers, and sets roll to zero because the roll can't be determined from a vector. </para>
		/// <para>Identical to 'ToOrientationRotator()'. </para>
		/// <return>FRotator from the Vector's direction. </return>
		/// <para>@see ToOrientationRotator() </para>
		/// </summary>
		public FRotator Rotation()
			=> E_FVector4_Rotation(this);
		
		
		/// <summary>
		/// <para>Set all of the vectors coordinates. </para>
		/// <param name="InX">New X Coordinate. </param>
		/// <param name="InY">New Y Coordinate. </param>
		/// <param name="InZ">New Z Coordinate. </param>
		/// <param name="InW">New W Coordinate. </param>
		/// </summary>
		public void Set(float InX, float InY, float InZ, float InW)
			=> E_FVector4_Set(this, InX, InY, InZ, InW);
		
		
		/// <summary>
		/// <para>Get the length (magnitude) of this vector, taking the W component into account </para>
		/// <return>The length of this vector </return>
		/// </summary>
		public float Size()
			=> E_FVector4_Size(this);
		
		
		/// <summary>
		/// <para>Get the length of this vector not taking W component into account. </para>
		/// <return>The length of this vector. </return>
		/// </summary>
		public float Size3()
			=> E_FVector4_Size3(this);
		
		
		/// <summary>
		/// <para>Get the squared length of this vector, taking the W component into account </para>
		/// <return>The squared length of this vector </return>
		/// </summary>
		public float SizeSquared()
			=> E_FVector4_SizeSquared(this);
		
		
		/// <summary>
		/// <para>Get the squared length of this vector not taking W component into account. </para>
		/// <return>The squared length of this vector. </return>
		/// </summary>
		public float SizeSquared3()
			=> E_FVector4_SizeSquared3(this);
		
		
		/// <summary>
		/// <para>Return the Quaternion orientation corresponding to the direction in which the vector points. </para>
		/// <return>Quaternion from the Vector's direction. </return>
		/// </summary>
		public FQuat ToOrientationQuat()
			=> E_FVector4_ToOrientationQuat(this);
		
		
		/// <summary>
		/// <para>Return the FRotator orientation corresponding to the direction in which the vector points. </para>
		/// <para>Sets Yaw and Pitch to the proper numbers, and sets roll to zero because the roll can't be determined from a vector. </para>
		/// <return>FRotator from the Vector's direction. </return>
		/// </summary>
		public FRotator ToOrientationRotator()
			=> E_FVector4_ToOrientationRotator(this);
		
		
		/// <summary>
		/// <para>Get a textual representation of the vector. </para>
		/// <return>Text describing the vector. </return>
		/// </summary>
		public override string ToString()
			=> E_FVector4_ToString(this);
		
		#endregion
		
		public static implicit operator IntPtr(FVector4 Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FVector4(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FVector4(Adress, false);
		}}}
