﻿using System.Linq;
using System.Text.RegularExpressions;
using Generator.Metadata;

namespace Generator.Codegenretor
{
    public class CodegenretorBase
    {
        protected static readonly Regex SummaryParamRegex = new Regex(@"@param\W+(\w+)\W+(.*)");
        protected static readonly Regex SummaryReturnRegex = new Regex(@"@return\W+(.*)");

        // ReSharper disable once InconsistentNaming
        protected static Config cfg;
        
        public CodegenretorBase(Config config)
        {
            cfg = config;
        }

        protected static string GetCppMethodName(Method method)
        {
            return cfg.ExportPrefix + method.OwnerClass.Name + "_" + method.Name;
        }

        protected static string GetExportConstructorFullName(Method ctr)
        {
            var signature = string.Join("_", ctr.InputTypes.Select(m => m.Type));
            if (signature.Any())
                signature = "_" + signature;

            return $"{cfg.ExportPrefix}CreateStruct_{ctr.OwnerClass.Name}{signature}";
        }

        protected static void GenerateSourceInfo(CodeWriter cw, Primitive primitive)
        {
            if (cfg.IsWriteSourceFileName)
            {
                cw.WriteLine($"// Source file {primitive.SourceFile}:{primitive.SourceLine}");
                cw.WriteLine();
            }
        }
    }
}