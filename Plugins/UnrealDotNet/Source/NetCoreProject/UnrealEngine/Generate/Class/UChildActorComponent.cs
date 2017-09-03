using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	
	/// <summary>
	/// Класс не может быть наследован в Вашем коде, используйте ManageChildActorComponent
	/// <para>A component that spawns an Actor when registered, and destroys it when unregistered. </para>
	/// </summary>
	public  partial class UChildActorComponent : USceneComponent
	{
		public UChildActorComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UChildActorComponent_CreateChildActor(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UChildActorComponent_DestroyChildActor(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_UChildActorComponent_GetChildActor(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_UChildActorComponent_GetChildActorName(IntPtr Self, out int ResultStringLen);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_UChildActorComponent_GetChildActorTemplate(IntPtr Self);
		
		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// <para>Create the child actor </para>
		/// </summary>
		public void CreateChildActor()
			=> E_UChildActorComponent_CreateChildActor(this);
		
		
		/// <summary>
		/// <para>Kill any currently present child actor </para>
		/// </summary>
		public void DestroyChildActor()
			=> E_UChildActorComponent_DestroyChildActor(this);
		
		public AActor GetChildActor()
			=> E_UChildActorComponent_GetChildActor(this);
		
		public string GetChildActorName()
			=> Marshal.PtrToStringUTF8(E_UChildActorComponent_GetChildActorName(this, out int ResultStringLen), ResultStringLen);
		
		public AActor GetChildActorTemplate()
			=> E_UChildActorComponent_GetChildActorTemplate(this);
		
		#endregion
		
		public static implicit operator IntPtr(UChildActorComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator UChildActorComponent(IntPtr Adress)
		{
			if (Adress == IntPtr.Zero)
				return null;
			return NativeManager.GetWrapper(Adress) as UChildActorComponent ?? new UChildActorComponent(Adress);
		}