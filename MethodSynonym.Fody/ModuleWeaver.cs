using System.Diagnostics.CodeAnalysis;
using Fody;
using Mono.Cecil;
using Mono.Cecil.Cil;

namespace MethodSynonym.Fody
{
    public class ModuleWeaver : BaseModuleWeaver
    {
        public override void Execute()
        {
        }

        public override IEnumerable<string> GetAssembliesForScanning()
            => Enumerable.Empty<string>();
    }
}