﻿using System.Collections.Generic;
using System.Linq;

namespace Generator.Metadata
{
    public class Class : Type
    {
        public Class BaseClass { get; set; }
        public List<Method> Methods { get; set; }
        public List<Method> Constructors { get; set; }
        public List<Variable> Property { get; set; }
        public bool IsStructure { get; set; }
        public bool IsReadOnly { get; set; }
        public bool IsFinal { get; set; }

        public IEnumerable<Class> PropertyDependent
        {
            get
            {
                var list = Property.OfType<ClassVariable>().Select(v => v.Class);
                return list.Where(cl => cl != this).Distinct().OrderBy(cl => cl.Name);
            }
        }

        public Class(string Name)
        {
            Methods = new List<Method>();
            Property = new List<Variable>();
            Constructors = new List<Method>();

            IsImplemented = false;
            this.Name = Name;
        }

        public bool IsChild(string ClassName)
        {
            var cl = this;
            while (cl != null)
            {
                if (cl.Name == ClassName)
                    return true;

                cl = cl.BaseClass;
            }

            return false;
        }
    }
}