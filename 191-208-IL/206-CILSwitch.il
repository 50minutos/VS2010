.assembly _206_CILSwitch
{
    .ver 1:0:0:0
    .hash algorithm 0x00008004
}

.assembly extern mscorlib
{
    .ver 4:0:0:0
    .publickeytoken = (B7 7A 5C 56 19 34 E0 89)
}

.module _206_CILSwitch.exe
.subsystem 0x0003

.namespace _206_CILSwitch
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
	            [0] int32 x,
	            [1] int32 CS$4$0000)
	        L_0000: nop 
	        L_0001: ldc.i4.3 
	        L_0002: stloc.0 
	        L_0003: ldloc.0 
	        L_0004: stloc.1 
	        L_0005: ldloc.1 
	        L_0006: ldc.i4.1 
	        L_0007: sub 
	        L_0008: switch (L_001b, L_0028, L_0028)
	        L_0019: br.s L_0035
	        L_001b: ldstr "x = 1"
	        L_0020: call void [mscorlib]System.Console::WriteLine(string)
	        L_0025: nop 
	        L_0026: br.s L_0042
	        L_0028: ldstr "x = 2 ou x = 3"
	        L_002d: call void [mscorlib]System.Console::WriteLine(string)
	        L_0032: nop 
	        L_0033: br.s L_0042
	        L_0035: ldstr "x não é 1, 2 ou 3"
	        L_003a: call void [mscorlib]System.Console::WriteLine(string)
	        L_003f: nop 
	        L_0040: br.s L_0042
	        L_0042: call valuetype [mscorlib]System.ConsoleKeyInfo [mscorlib]System.Console::ReadKey()
	        L_0047: pop 
	        L_0048: ret 
	    }
	
	}
}
