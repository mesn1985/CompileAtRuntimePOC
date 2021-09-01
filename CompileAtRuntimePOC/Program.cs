using DynamicCompiler;
using static System.Console;

namespace CompileAtRuntimePOC
{
    class Program
    {
        static void Main(string[] args)
        {
            var dynamicSourceCodeLoader = new CSharpSourceCodeDynamincLoader();

            var types = dynamicSourceCodeLoader.getTypesFrom(@"C:\tmp\person.cs");

            types.ForEach(type => WriteLine(type.Name));


        }

        }
    }

