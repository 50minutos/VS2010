.assembly _202_CILWhile
{
    .ver 1:0:0:0
    .hash algorithm 0x00008004
}

.assembly extern mscorlib
{
    .ver 4:0:0:0
    .publickeytoken = (B7 7A 5C 56 19 34 E0 89)
}

.module _202_CILWhile.exe
.subsystem 0x0003

.namespace _202_CILWhile
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
	        L_0003: br.s L_0012
	        L_0005: nop 
	        L_0006: ldloc.0 
	        L_0007: call void [mscorlib]System.Console::WriteLine(int32)
	        L_000c: nop 
	        L_000d: ldloc.0 
	        L_000e: ldc.i4.1 
	        L_000f: add 
	        L_0010: stloc.0 
	        L_0011: nop 
	        L_0012: ldloc.0 
	        L_0013: ldc.i4.5 
	        L_0014: clt 
	        L_0016: stloc.1 
	        L_0017: ldloc.1 
	        L_0018: brtrue.s L_0005
	        L_001a: call valuetype [mscorlib]System.ConsoleKeyInfo [mscorlib]System.Console::ReadKey()
	        L_001f: pop 
	        L_0020: ret 
	    }
	
	}
}
