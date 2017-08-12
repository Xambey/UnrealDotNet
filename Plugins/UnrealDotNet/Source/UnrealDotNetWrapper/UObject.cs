﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
    public partial class UObject
    {
        #region DllImport

        [DllImport("UE4Editor-UnrealDotNetRuntime")]
        private static extern void Call_ULOG_E(string Message);

        [DllImport("UE4Editor-UnrealDotNetRuntime")]
        private static extern void Call_ULOG_W(string Message);

        [DllImport("UE4Editor-UnrealDotNetRuntime")]
        private static extern void Call_ULOG_L(string Message);

        #endregion DllImport

        private static readonly Assembly GameLogicAssembly = Assembly.Load(new AssemblyName("GameLogic, Version=1.0.0.0, Culture=neutral"));

        public static Dictionary<IntPtr, object> Wrappers = new Dictionary<IntPtr, object>();

        public static bool AddWrapper(IntPtr Adress, string ClassName)
        {
            if (Wrappers.ContainsKey(Adress))
            {
                ULog_Warning($"Object is already registered. Type:{ClassName}, Adress:{Adress}");
                return false;
            }

            var type = GameLogicAssembly.GetType(ClassName);
            if (type == null)
            {
                ULog_Error($"Failed create object, type {ClassName} not found");
                return false;
            }

            var constructor = type.GetConstructor(new[] { typeof(IntPtr) });
            if (constructor == null)
            {
                ULog_Error($"Failed create object, type {ClassName} not have IntPtr constructor");
                return false;
            }

            try
            {
                var obj = constructor.Invoke(new object[] { Adress });
                Wrappers.Add(Adress, obj);
            }
            catch (Exception e)
            {
                ULog_Error($"Failed create object, exception:{e}\n{e.StackTrace}");
                return false;
            }

            ULog_Debug($"Create object, Type:{ClassName}, Adress:{Adress}");
            return true;
        }

        public static void Invoke(IntPtr Adress, string MethodName, IntPtr Arguments, int Size)
        {
            if (!Wrappers.TryGetValue(Adress, out var obj))
            {
                ULog_Error($"Failed call method {MethodName}, {Adress} not found");
                return;
            }

            var method = obj.GetType().GetMethod(MethodName);
            if (method == null)
            {
                ULog_Error($"Failed call method {MethodName} in {Adress}, method not found in {obj.GetType()}");
                return;
            }

            var Params = ParceParams(method, Arguments, Size, out var IsSuccess);
            if (!IsSuccess)
            {
                ULog_Error($"Failed call method {method.Name}, method have {method.GetParameters().Length} arguments, size not match");
                return;
            }

            try
            {
                //ULog_Debug($"Call method {MethodName} in {Adress}"); // disable spam
                method.Invoke(obj, Params);
            }
            catch (Exception e)
            {
                ULog_Error($"Exception:{e}\n{e.StackTrace}");
            }
        }

        private static object[] ParceParams(MethodBase Method, IntPtr Arguments, int Size, out bool IsSuccess)
        {
            var spec = Method.GetParameters();
            var Params = spec.Length == 0 ? null : new object[spec.Length];

            if ((spec.Length == 0 && Size != 0) || (spec.Length != 0 && Size == 0))
            {
                IsSuccess = false;
                return null;
            }

            if (Params != null)
            {
                var buff = new byte[Size];
                Marshal.Copy(Arguments, buff, 0, Size);

                using (var br = new BinaryReader(new MemoryStream(buff)))
                {
                    try
                    {
                        for (var i = 0; i < spec.Length; i++)
                        {
                            if (spec[i].ParameterType == typeof(IntPtr))
                            {
                                Params[i] = Marshal.SizeOf<IntPtr>() == Marshal.SizeOf<Int32>() ? (IntPtr)br.ReadInt32() : (IntPtr)br.ReadInt64();
                            }
                            else
                            {
                                switch (Type.GetTypeCode(spec[i].ParameterType))
                                {
                                    case TypeCode.String: Params[i] = br.ReadString(); break;
                                    case TypeCode.Boolean: Params[i] = br.ReadBoolean(); break;
                                    case TypeCode.Single: Params[i] = br.ReadSingle(); break;
                                    case TypeCode.Byte: Params[i] = br.ReadByte(); break;
                                    case TypeCode.Char: Params[i] = br.ReadChar(); break;
                                    case TypeCode.Int16: Params[i] = br.ReadInt16(); break;
                                    case TypeCode.Int32: Params[i] = br.ReadInt32(); break;
                                    case TypeCode.Int64: Params[i] = br.ReadInt64(); break;
                                    case TypeCode.Double: Params[i] = br.ReadDouble(); break;
                                }
                            }
                        }
                    }
                    catch (EndOfStreamException)
                    {
                        IsSuccess = false;
                        return null;
                    }
                }
            }

            IsSuccess = true;
            return Params;
        }

        public static void RemoveWrapper(IntPtr Adress)
        {
            if (Wrappers.Remove(Adress))
            {
                ULog_Debug($"Free object {Adress}");
            }
            else
            {
                ULog_Warning($"Failed free object, {Adress} not found");
            }
        }

        public static void ULog_Debug(string Message)
        {
#if DEBUG
            Call_ULOG_L(Message);
#endif
        }

        public static void ULog(string Message) => Call_ULOG_L(Message);

        public static void ULog_Warning(string Message) => Call_ULOG_W(Message);

        public static void ULog_Error(string Message) => Call_ULOG_E(Message);
    }
}