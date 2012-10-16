.assembly _204_CILIf
{
    .ver 1:0:0:0
    .hash algorithm 0x00008004
}

.assembly extern mscorlib
{
    .ver 4:0:0:0
    .publickeytoken = (B7 7A 5C 56 19 34 E0 89)
}

.module _204_CILIf.exe
.subsystem 0x0003

.namespace _204_CILIf
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
	            [1] bool CS$4$0000)
	        L_0000: nop 
	        L_0001: ldc.i4.s 10
	        L_0003: stloc.0 
	        L_0004: ldloc.0 
	        L_0005: ldc.i4.s 10
	        L_0007: ceq 
	        L_0009: ldc.i4.0 
	        L_000a: ceq 
	        L_000c: stloc.1 
	        L_000d: ldloc.1 
	        L_000e: brtrue.s L_001d
	        L_0010: ldstr "x é 10"
	        L_0015: call void [mscorlib]System.Console::WriteLine(string)
	        L_001a: nop 
	        L_001b: br.s L_0028
	        L_001d: ldstr "x não é 10"
	        L_0022: call void [mscorlib]System.Console::WriteLine(string)
	        L_0027: nop 
	        L_0028: call valuetype [mscorlib]System.ConsoleKeyInfo [mscorlib]System.Console::ReadKey()
	        L_002d: pop 
	        L_002e: ret 
	    }
	
	}
}
