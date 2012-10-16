.assembly _198_CILReturn
{
    .ver 1:0:0:0
    .hash algorithm 0x00008004
}

.assembly extern mscorlib
{
    .ver 4:0:0:0
    .publickeytoken = (B7 7A 5C 56 19 34 E0 89)
}

.module _198_CILReturn.exe
.subsystem 0x0003

.namespace _198_CILReturn
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
	            [0] int32 x)
	        L_0000: nop 
	        L_0001: ldc.i4 0x19c
	        L_0006: ldc.i4 0xfe
	        L_000b: call int32 _198_CILReturn.Program::Somar(int32, int32)
	        L_0010: stloc.0 
	        L_0011: ldloc.0 
	        L_0012: call void [mscorlib]System.Console::WriteLine(int32)
	        L_0017: nop 
	        L_0018: call valuetype [mscorlib]System.ConsoleKeyInfo [mscorlib]System.Console::ReadKey()
	        L_001d: pop 
	        L_001e: ret 
	    }
	
	    .method private hidebysig static int32 Somar(int32 x, int32 y) cil managed
	    {
	        .maxstack 2
	        .locals init (
	            [0] int32 CS$1$0000)
	        L_0000: nop 
	        L_0001: ldarg.0 
	        L_0002: ldarg.1 
	        L_0003: add 
	        L_0004: stloc.0 
	        L_0005: br.s L_0007
	        L_0007: ldloc.0 
	        L_0008: ret 
	    }
	
	}
}
