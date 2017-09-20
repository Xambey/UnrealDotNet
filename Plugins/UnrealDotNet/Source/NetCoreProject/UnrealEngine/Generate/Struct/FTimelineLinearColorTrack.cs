using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class FTimelineLinearColorTrack : NativeStructWrapper
	{
		internal FTimelineLinearColorTrack(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FTimelineLinearColorTrack() :
			base(E_CreateStruct_FTimelineLinearColorTrack(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FTimelineLinearColorTrack();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern string E_PROP_FTimelineLinearColorTrack_LinearColorPropertyName_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FTimelineLinearColorTrack_LinearColorPropertyName_SET(IntPtr Ptr, string Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern string E_PROP_FTimelineLinearColorTrack_TrackName_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FTimelineLinearColorTrack_TrackName_SET(IntPtr Ptr, string Value);
		
		#endregion
		
		#region Property
		public string LinearColorPropertyName
		{
			get => E_PROP_FTimelineLinearColorTrack_LinearColorPropertyName_GET(NativePointer);
			set => E_PROP_FTimelineLinearColorTrack_LinearColorPropertyName_SET(NativePointer, value);
		}

		public string TrackName
		{
			get => E_PROP_FTimelineLinearColorTrack_TrackName_GET(NativePointer);
			set => E_PROP_FTimelineLinearColorTrack_TrackName_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FTimelineLinearColorTrack Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FTimelineLinearColorTrack(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FTimelineLinearColorTrack(Adress, false);
		}
}
}
