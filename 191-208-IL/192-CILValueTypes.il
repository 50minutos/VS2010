.assembly _192_CILValueTypes
{
    .ver 1:0:0:0
    .hash algorithm 0x00008004
}

.assembly extern mscorlib
{
    .ver 4:0:0:0
    .publickeytoken = (B7 7A 5C 56 19 34 E0 89)
}

.module _192_CILValueTypes.exe
.subsystem 0x0003

.namespace _192_CILValueTypes
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
            .maxstack 1
	    .locals init (
	        [0] int32 a,
	        [1] float64 b,
	        [2] char c,
	        [3] bool d)
	    L_0000: nop 
	    L_0001: ldc.i4.s 10
	    L_0003: stloc.0 
	    L_0004: ldc.r8 19.09
	    L_000d: stloc.1 
	    L_000e: ldc.i4.s 0x41
	    L_0010: stloc.2 
	    L_0011: ldc.i4.1 
	    L_0012: stloc.3 
	    L_0013: ldloc.0 
	    L_0014: call void [mscorlib]System.Console::WriteLine(int32)
	    L_0019: nop 
	    L_001a: ldloc.1 
	    L_001b: call void [mscorlib]System.Console::WriteLine(float64)
	    L_0020: nop 
	    L_0021: ldloc.2 
	    L_0022: call void [mscorlib]System.Console::WriteLine(char)
	    L_0027: nop 
	    L_0028: ldloc.3 
	    L_0029: call void [mscorlib]System.Console::WriteLine(bool)
	    L_002e: nop 
	    L_002f: call valuetype [mscorlib]System.ConsoleKeyInfo [mscorlib]System.Console::ReadKey()
	    L_0034: pop 
	    L_0035: ret 
        }
    }
}
