.assembly _194_CILPessoa
{
    .ver 1:0:0:0
    .hash algorithm 0x00008004
}

.assembly extern mscorlib
{
    .ver 4:0:0:0
    .publickeytoken = (B7 7A 5C 56 19 34 E0 89)
}

.module _194_CILPessoa.exe
.subsystem 0x0003

.namespace _194_CILPessoa
{
    .class private auto ansi beforefieldinit Program
        extends [mscorlib]System.Object
    {
        .method public hidebysig specialname rtspecialname instance void .ctor() cil managed
        {
	    .maxstack 8
	    L_0000: ldarg.0 
	    L_0001: call instance void [mscorlib]System.Object::.ctor()
	    L_0006: ret 

        }

        .method private hidebysig static void Main(string[] args) cil managed
        {
            .entrypoint
            .maxstack 2
            .locals init (
		[0] class _194_CILPessoa.Pessoa p)
            L_0000: nop 
            L_0001: newobj instance void _194_CILPessoa.Pessoa::.ctor()
            L_0006: stloc.0 
            L_0007: ldloc.0 
            L_0008: ldc.i4.1 
            L_0009: stfld int32 _194_CILPessoa.Pessoa::codigo
            L_000e: ldloc.0 
            L_000f: ldstr "Adão"
            L_0014: stfld string _194_CILPessoa.Pessoa::nome
            L_0019: ldloc.0 
            L_001a: ldfld int32 _194_CILPessoa.Pessoa::codigo
            L_001f: call void [mscorlib]System.Console::WriteLine(int32)
            L_0024: nop 
            L_0025: ldloc.0 
            L_0026: ldfld string _194_CILPessoa.Pessoa::nome
            L_002b: call void [mscorlib]System.Console::WriteLine(string)
            L_0030: nop 
            L_0031: call valuetype [mscorlib]System.ConsoleKeyInfo [mscorlib]System.Console::ReadKey()
            L_0036: pop 
            L_0037: ret 
        }
    }
    
    .class private auto ansi beforefieldinit Pessoa
        extends [mscorlib]System.Object
    {
        .method public hidebysig specialname rtspecialname instance void .ctor() cil managed
        {
            .maxstack 8
	    L_0000: ldarg.0 
	    L_0001: call instance void [mscorlib]System.Object::.ctor()
	    L_0006: ret 
        }

	.field public int32 codigo

        .field public string nome
    }
}
