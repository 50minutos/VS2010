.assembly _203_CILDo
{
    .ver 1:0:0:0
    .hash algorithm 0x00008004
}

.assembly extern mscorlib
{
    .ver 4:0:0:0
    .publickeytoken = (B7 7A 5C 56 19 34 E0 89)
}

.module _203_CILDo.exe
.subsystem 0x0003

.namespace _203_CILDo
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
	        L_0001: ldc.i4.0 
	        L_0002: stloc.0 
	        L_0003: nop 
	        L_0004: ldloc.0 
	        L_0005: call void [mscorlib]System.Console::WriteLine(int32)
	        L_000a: nop 
	        L_000b: ldloc.0 
	        L_000c: ldc.i4.1 
	        L_000d: add 
	        L_000e: stloc.0 
	        L_000f: nop 
	        L_0010: ldloc.0 
	        L_0011: ldc.i4.5 
	        L_0012: clt 
	        L_0014: stloc.1 
	        L_0015: ldloc.1 
	        L_0016: brtrue.s L_0003
	        L_0018: call valuetype [mscorlib]System.ConsoleKeyInfo [mscorlib]System.Console::ReadKey()
	        L_001d: pop 
	        L_001e: ret 
	    }
	
	}
}
