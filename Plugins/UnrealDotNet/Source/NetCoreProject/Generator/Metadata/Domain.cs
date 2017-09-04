﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Generator.Metadata
{
    public class Domain
    {
        public List<Class> Classes;
        public List<Enum> Enums;

        public Domain(IEnumerable<Type> Types)
        {
            Classes = new List<Class>();
            Enums = new List<Enum>();

            foreach (var type in Types)
            {
                type.Domain = this;

                if (type is Class)
                {
                    Classes.Add(type as Class);
                }
                else if (type is Enum)
                {
                    Enums.Add(type as Enum);
                }
            }

            Classes = Filter.FilterClasses(Classes);
            Enums = Filter.FilterEnum(Enums);
        }

        public void Print(bool Full)
        {
            Console.WriteLine();

            foreach (var cl in Classes.OrderBy(cl => cl.IsImplemented ? 0 : 1))
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write(cl.IsStructure ? "Struct " : "Class ");

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write(cl.Name);

                if (cl.BaseClass != null)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write(" base of ");
                    Console.ForegroundColor = cl.BaseClass.IsImplemented ? ConsoleColor.Cyan : ConsoleColor.Red;
                    Console.Write(cl.BaseClass.Name);
                }

                if (cl.IsTemplate)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write(" (Template)");
                }

                if (!cl.IsImplemented)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(" (Not Implemented)");
                }
                else
                {
                    if (!Full)
                    {
                        Console.ResetColor();
                        Console.WriteLine($"\tProperty: ({cl.Property.Count}) Methods: ({cl.Methods.Count})");
                        continue;
                    }

                    Console.WriteLine();

                    if (cl.Property.Count != 0)
                    {
                        Console.ResetColor();
                        Console.WriteLine($"Property: ({cl.Property.Count})");

                        foreach (var prop in cl.Property)
                        {
                            Console.Write("\t");
                            PrintVariable(prop);
                            Console.WriteLine();
                        }

                        Console.WriteLine();
                    }

                    if (cl.Methods.Count != 0)
                    {
                        Console.ResetColor();
                        Console.WriteLine($"Methods: ({cl.Methods.Count})");

                        foreach (var method in cl.Methods)
                        {
                            PrintMehod(method);
                        }
                    }
                }

                Console.WriteLine();
            }

            Console.ResetColor();
        }

        private static void PrintMehod(Method method)
        {
            var ext = new List<string>();

            if (method.IsConst) ext.Add("const");
            if (method.IsVirtual) ext.Add("virtual");
            if (method.IsTemplate) ext.Add("template");
            if (method.IsStatic) ext.Add("static");

            Console.Write("\t");
            PrintVariable(method.ReturnType);

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write($" {method.Name} ");
            Console.ResetColor();
            Console.Write("(");

            for (var i = 0; i < method.InputTypes.Count; i++)
            {
                if (i != 0)
                    Console.Write(", ");

                PrintVariable(method.InputTypes[i]);
            }

            Console.Write(")");

            if (ext.Any())
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write(" " + string.Join(", ", ext));
            }

            Console.WriteLine();
        }

        private static void PrintVariable(Variable variable)
        {
            var ext = new List<string>();

            if (variable.IsConst) ext.Add("const");
            if (variable.IsReference) ext.Add("ref");
            if (variable.IsPointer) ext.Add("ptr");

            if (ext.Any())
            {
                Console.ResetColor();
                Console.Write(string.Join(" ", ext) + " ");
            }

            var clVar = variable as ClassVariable;
            Console.ForegroundColor = clVar?.Class.IsImplemented == false ? ConsoleColor.Red : ConsoleColor.Cyan;

            Console.Write(variable.Type);

            if (!string.IsNullOrEmpty(variable.Name))
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(" " + variable.Name);
            }

            if (!string.IsNullOrEmpty(variable.Default))
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write(" = " + variable.Default);
            }
        }
    }
}