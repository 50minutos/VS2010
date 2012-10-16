.assembly _201_CILArrayForEach
{
    .ver 1:0:0:0
    .hash algorithm 0x00008004
}

.assembly extern mscorlib
{
    .ver 4:0:0:0
    .publickeytoken = (B7 7A 5C 56 19 34 E0 89)
}

.module _201_CILArrayForEach.exe
.subsystem 0x0003

.namespace _201_CILArrayForEach
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
	            [0] int32[] numeros,
	            [1] int32 item,
	            [2] int32[] CS$6$0000,
	            [3] int32 CS$7$0001,
	            [4] bool CS$4$0002)
	        L_0000: nop 
	        L_0001: ldc.i4.3 
	        L_0002: newarr int32
	        L_0007: stloc.0 
	        L_0008: nop 
	        L_0009: ldloc.0 
	        L_000a: stloc.2 
	        L_000b: ldc.i4.0 
	        L_000c: stloc.3 
	        L_000d: br.s L_0020
	        L_000f: ldloc.2 
	        L_0010: ldloc.3 
	        L_0011: ldelem.i4 
	        L_0012: stloc.1 
	        L_0013: nop 
	        L_0014: ldloc.1 
	        L_0015: call void [mscorlib]System.Console::WriteLine(int32)
	        L_001a: nop 
	        L_001b: nop 
	        L_001c: ldloc.3 
	        L_001d: ldc.i4.1 
	        L_001e: add 
	        L_001f: stloc.3 
	        L_0020: ldloc.3 
	        L_0021: ldloc.2 
	        L_0022: ldlen 
	        L_0023: conv.i4 
	        L_0024: clt 
	        L_0026: stloc.s CS$4$0002
	        L_0028: ldloc.s CS$4$0002
	        L_002a: brtrue.s L_000f
	        L_002c: call valuetype [mscorlib]System.ConsoleKeyInfo [mscorlib]System.Console::ReadKey()
	        L_0031: pop 
	        L_0032: ret 
	    }

	}
}
