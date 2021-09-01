using System;
using System.Collections.Generic;
using System.Linq;

namespace DynamicCompiler
{
    public class CSharpSourceCodeDynamincLoader
    {

        public CSharpSourceCodeDynamincLoader(){}

        public List<Type> getTypesFrom(string sourceFilepath) {
            var compiler = new Compiler();
            var compiledByteArray = compiler.Compile(sourceFilepath);

            var assemblyLoader = new AsssemblyLoader();
            var compiledAssembly = assemblyLoader.LoadAssemblyFromCompiledAssemblyByteArray(compiledByteArray);

            return compiledAssembly.GetTypes().ToList();

            }

    }
}
