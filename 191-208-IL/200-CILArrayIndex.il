.assembly _200_CILArrayIndex
{
    .ver 1:0:0:0
    .hash algorithm 0x00008004
}

.assembly extern mscorlib
{
    .ver 4:0:0:0
    .publickeytoken = (B7 7A 5C 56 19 34 E0 89)
}

.module _200_CILArrayIndex.exe
.subsystem 0x0003

.namespace _200_CILArrayIndex
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
	            [0] int32[] numeros)
	        L_0000: nop 
	        L_0001: ldc.i4.3 
	        L_0002: newarr int32
	        L_0007: stloc.0 
	        L_0008: ldloc.0 
	        L_0009: ldc.i4.0 
	        L_000a: ldc.i4.s 10
	        L_000c: stelem.i4 
	        L_000d: ldloc.0 
	        L_000e: ldc.i4.1 
	        L_000f: ldc.i4.s 100
	        L_0011: stelem.i4 
	        L_0012: ldloc.0 
	        L_0013: ldc.i4.2 
	        L_0014: ldc.i4.s -10
	        L_0016: stelem.i4 
	        L_0017: ldloc.0 
	        L_0018: call void [mscorlib]System.Console::WriteLine(object)
	        L_001d: nop 
	        L_001e: call valuetype [mscorlib]System.ConsoleKeyInfo [mscorlib]System.Console::ReadKey()
	        L_0023: pop 
	        L_0024: ret 
	    }
	
	}
}
