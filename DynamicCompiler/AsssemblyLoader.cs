using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.Loader;
using System.Text;

namespace DynamicCompiler
{
    internal class AsssemblyLoader
    {
        public AsssemblyLoader(){}

        public Assembly LoadAssemblyFromCompiledAssemblyByteArray(byte[] compiledAssembly) {

            Assembly assembly;

            using (var memoryStream = new MemoryStream(compiledAssembly)) {

                assembly = new AssemblyLoadContext("compiledAssembly",true)
                            .LoadFromStream(memoryStream);
            }

            return assembly;
        }


    }
}
