using System.Reflection.Emit;
using   MicroNet.Helpers;

namespace   MicroNet.Emit
{
    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public static class MethodBuilderExtension
    {
        public static EmitGenerator GetEmitGenerator(this MethodBuilder builder)
        {
        	Requires.NotNull(builder, "builder");
            var ilGen = builder.GetILGenerator();
            var emitGen = new EmitGenerator(ilGen);
            return emitGen;
        }
    }
}
