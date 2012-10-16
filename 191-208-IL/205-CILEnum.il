.assembly _205_CILEnum
{
    .ver 1:0:0:0
    .hash algorithm 0x00008004
}

.assembly extern mscorlib
{
    .ver 4:0:0:0
    .publickeytoken = (B7 7A 5C 56 19 34 E0 89)
}

.module _205_CILEnum.exe
.subsystem 0x0003

.namespace _205_CILEnum
{
	.class private auto ansi sealed Cor
	    extends [mscorlib]System.Enum
	{
	    .field public static literal valuetype _205_CILEnum.Cor Azul = int32(2)
	
	    .field public specialname rtspecialname int32 value__
	
	    .field public static literal valuetype _205_CILEnum.Cor Verde = int32(1)
	
	    .field public static literal valuetype _205_CILEnum.Cor Vermelho = int32(0)
	
	}
	
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
	            [0] valuetype _205_CILEnum.Cor cor)
	        L_0000: nop 
	        L_0001: ldc.i4.0 
	        L_0002: stloc.0 
	        L_0003: ldloc.0 
	        L_0004: box _205_CILEnum.Cor
	        L_0009: call void [mscorlib]System.Console::WriteLine(object)
	        L_000e: nop 
	        L_000f: call valuetype [mscorlib]System.ConsoleKeyInfo [mscorlib]System.Console::ReadKey()
	        L_0014: pop 
	        L_0015: ret 
	    }
	
	}
}
