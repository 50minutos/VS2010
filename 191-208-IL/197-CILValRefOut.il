.assembly _197_CILValOutRef
{
    .ver 1:0:0:0
    .hash algorithm 0x00008004
}

.assembly extern mscorlib
{
    .ver 4:0:0:0
    .publickeytoken = (B7 7A 5C 56 19 34 E0 89)
}

.module _197_CILValOutRef.exe
.subsystem 0x0003

.namespace _197_CILValOutRef
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
	            [0] int32 x,
	            [1] int32 y,
	            [2] int32 z)
	        L_0000: nop 
	        L_0001: ldc.i4.s 10
	        L_0003: stloc.0 
	        L_0004: ldc.i4.s 20
	        L_0006: stloc.1 
	        L_0007: ldc.i4.s 30
	        L_0009: stloc.2 
	        L_000a: ldloc.0 
	        L_000b: ldloca.s y
	        L_000d: ldloca.s z
	        L_000f: call void _197_CILValOutRef.Program::Mudar(int32, int32&, int32&)
	        L_0014: nop 
	        L_0015: ldloc.0 
	        L_0016: call void [mscorlib]System.Console::WriteLine(int32)
	        L_001b: nop 
	        L_001c: ldloc.1 
	        L_001d: call void [mscorlib]System.Console::WriteLine(int32)
	        L_0022: nop 
	        L_0023: ldloc.2 
	        L_0024: call void [mscorlib]System.Console::WriteLine(int32)
	        L_0029: nop 
	        L_002a: call valuetype [mscorlib]System.ConsoleKeyInfo [mscorlib]System.Console::ReadKey()
	        L_002f: pop 
	        L_0030: ret 
	    }
	
	    .method private hidebysig static void Mudar(int32 x, [out] int32& y, int32& z) cil managed
	    {
	        .maxstack 8
	        L_0000: nop 
	        L_0001: ldc.i4.s 20
	        L_0003: starg.s x
	        L_0005: ldarg.1 
	        L_0006: ldc.i4.s 100
	        L_0008: stind.i4 
	        L_0009: ldarg.2 
	        L_000a: ldarg.2 
	        L_000b: ldind.i4 
	        L_000c: ldc.i4.1 
	        L_000d: add 
	        L_000e: stind.i4 
	        L_000f: ret 
	    }
	}
}
