.assembly _195_CILPessoaProperties
{
    .ver 1:0:0:0
    .hash algorithm 0x00008004
}

.assembly extern mscorlib
{
    .ver 4:0:0:0
    .publickeytoken = (B7 7A 5C 56 19 34 E0 89)
}

.module _195_CILPessoaProperties.exe
.subsystem 0x0003

.namespace _195_CILPessoaProperties
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
		[0] class _195_CILPessoaProperties.Pessoa p)
	    L_0000: nop 
	    L_0001: newobj instance void _195_CILPessoaProperties.Pessoa::.ctor()
	    L_0006: stloc.0 
	    L_0007: ldloc.0 
	    L_0008: ldc.i4.1 
	    L_0009: callvirt instance void _195_CILPessoaProperties.Pessoa::set_Codigo(int32)
	    L_000e: nop 
	    L_000f: ldloc.0 
	    L_0010: ldstr "Adão"
	    L_0015: callvirt instance void _195_CILPessoaProperties.Pessoa::set_Nome(string)
	    L_001a: nop 
	    L_001b: ldloc.0 
	    L_001c: callvirt instance int32 _195_CILPessoaProperties.Pessoa::get_Codigo()
	    L_0021: call void [mscorlib]System.Console::WriteLine(int32)
	    L_0026: nop 
	    L_0027: ldloc.0 
	    L_0028: callvirt instance string _195_CILPessoaProperties.Pessoa::get_Nome()
	    L_002d: call void [mscorlib]System.Console::WriteLine(string)
	    L_0032: nop 
	    L_0033: call valuetype [mscorlib]System.ConsoleKeyInfo [mscorlib]System.Console::ReadKey()
	    L_0038: pop 
	    L_0039: ret 
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

        .field private int32 codigo

       	.method public hidebysig specialname instance int32 get_Codigo() cil managed
	{
	    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor()
	    .maxstack 1
	    .locals init (
		[0] int32 num)
	    L_0000: ldarg.0 
	    L_0001: ldfld int32 _195_CILPessoaProperties.Pessoa::codigo
	    L_0006: stloc.0 
	    L_0007: br.s L_0009
	    L_0009: ldloc.0 
	    L_000a: ret 
	}

	.method public hidebysig specialname instance void set_Codigo(int32 'value') cil managed
	{
	    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor()
	    .maxstack 8
	    L_0000: ldarg.0 
	    L_0001: ldarg.1 
	    L_0002: stfld int32 _195_CILPessoaProperties.Pessoa::codigo
	    L_0007: ret 
	}

	
	.property instance int32 Codigo()
        {
            .get instance int32 _195_CILPessoaProperties.Pessoa::get_Codigo()
            .set instance void _195_CILPessoaProperties.Pessoa::set_Codigo(int32)
        }

        .field private string nome

        .method public hidebysig specialname instance string get_Nome() cil managed
	{
	    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor()
	    .maxstack 1
	    .locals init (
	        [0] string str)
	    L_0000: ldarg.0 
	    L_0001: ldfld string _195_CILPessoaProperties.Pessoa::nome
	    L_0006: stloc.0 
	    L_0007: br.s L_0009
	    L_0009: ldloc.0 
	    L_000a: ret 
	}
	
	.method public hidebysig specialname instance void set_Nome(string 'value') cil managed
	{
	    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor()
	    .maxstack 8
	    L_0000: ldarg.0 
	    L_0001: ldarg.1 
	    L_0002: stfld string _195_CILPessoaProperties.Pessoa::nome
	    L_0007: ret 
	}

	.property instance string Nome()
        {
            .get instance string _195_CILPessoaProperties.Pessoa::get_Nome()
            .set instance void _195_CILPessoaProperties.Pessoa::set_Nome(string)
        }
    }
}
