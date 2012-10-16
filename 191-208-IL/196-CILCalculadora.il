.assembly _196_CILCalculadora
{
    .ver 1:0:0:0
    .hash algorithm 0x00008004
}

.assembly extern mscorlib
{
    .ver 4:0:0:0
    .publickeytoken = (B7 7A 5C 56 19 34 E0 89)
}

.module _196_CILCalculadora.exe
.subsystem 0x0003

.namespace _196_CILCalculadora
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
            .maxstack 3
	    .locals init (
		[0] class _196_CILCalculadora.Calculadora c,
		[1] int32 x,
		[2] int32 y)
	    L_0000: nop 
	    L_0001: newobj instance void _196_CILCalculadora.Calculadora::.ctor()
	    L_0006: stloc.0 
	    L_0007: ldc.i4.s 10
	    L_0009: stloc.1 
	    L_000a: ldc.i4.3 
	    L_000b: stloc.2 
	    L_000c: ldloc.0 
	    L_000d: ldloc.1 
	    L_000e: ldloc.2 
	    L_000f: callvirt instance int32 _196_CILCalculadora.Calculadora::Somar(int32, int32)
	    L_0014: call void [mscorlib]System.Console::WriteLine(int32)
	    L_0019: nop 
	    L_001a: ldloc.0 
	    L_001b: ldloc.1 
	    L_001c: ldloc.2 
	    L_001d: callvirt instance int32 _196_CILCalculadora.Calculadora::Subtrair(int32, int32)
	    L_0022: call void [mscorlib]System.Console::WriteLine(int32)
	    L_0027: nop 
	    L_0028: ldloc.1 
	    L_0029: ldloc.2 
	    L_002a: call int32 _196_CILCalculadora.Calculadora::Multiplicar(int32, int32)
	    L_002f: call void [mscorlib]System.Console::WriteLine(int32)
	    L_0034: nop 
	    L_0035: ldloc.1 
	    L_0036: ldloc.2 
	    L_0037: call int32 _196_CILCalculadora.Calculadora::Dividir(int32, int32)
	    L_003c: call void [mscorlib]System.Console::WriteLine(int32)
	    L_0041: nop 
	    L_0042: call valuetype [mscorlib]System.ConsoleKeyInfo [mscorlib]System.Console::ReadKey()
	    L_0047: pop 
	    L_0048: ret 
        }
    }

    .class private auto ansi beforefieldinit Calculadora
        extends [mscorlib]System.Object
    {
        .method public hidebysig specialname rtspecialname instance void .ctor() cil managed
        {
	   .maxstack 8
	    L_0000: ldarg.0 
	    L_0001: call instance void [mscorlib]System.Object::.ctor()
	    L_0006: ret 
        }

        .method public hidebysig instance int32 Somar(int32 a, int32 b) cil managed
        {
  	    .maxstack 2
	    .locals init (
		[0] int32 CS$1$0000)
	    L_0000: nop 
	    L_0001: ldarg.1 
	    L_0002: ldarg.2 
	    L_0003: add 
	    L_0004: stloc.0 
	    L_0005: br.s L_0007
	    L_0007: ldloc.0 
	    L_0008: ret 
	}

        .method public hidebysig instance int32 Subtrair(int32 a, int32 b) cil managed
        {
  	    .maxstack 2
	    .locals init (
		[0] int32 CS$1$0000)
	    L_0000: nop 
	    L_0001: ldarg.1 
	    L_0002: ldarg.2 
	    L_0003: sub 
	    L_0004: stloc.0 
	    L_0005: br.s L_0007
	    L_0007: ldloc.0 
	    L_0008: ret 
        }

        .method public hidebysig static int32 Multiplicar(int32 a, int32 b) cil managed
        {
  	    .maxstack 2
	    .locals init (
		[0] int32 CS$1$0000)
	    L_0000: nop 
	    L_0001: ldarg.0 
	    L_0002: ldarg.1 
	    L_0003: mul 
	    L_0004: stloc.0 
	    L_0005: br.s L_0007
	    L_0007: ldloc.0 
	    L_0008: ret 
        }

        .method public hidebysig static int32 Dividir(int32 a, int32 b) cil managed
        {
  	    .maxstack 2
	    .locals init (
		[0] int32 CS$1$0000)
	    L_0000: nop 
	    L_0001: ldarg.0
	    L_0002: ldarg.1
	    L_0003: div
	    L_0004: stloc.0 
	    L_0005: br.s L_0007
	    L_0007: ldloc.0 
	    L_0008: ret 
        }
    }
}
