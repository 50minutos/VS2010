.assembly _207_CILStruct
{
    .ver 1:0:0:0
    .hash algorithm 0x00008004
}

.assembly extern mscorlib
{
    .ver 4:0:0:0
    .publickeytoken = (B7 7A 5C 56 19 34 E0 89)
}

.module _207_CILStruct.exe
.subsystem 0x0003

.namespace _207_CILStruct
{
	.class private sequential ansi sealed beforefieldinit Ponto
	    extends [mscorlib]System.ValueType
	{
	    .method public hidebysig virtual instance string ToString() cil managed
	    {
	        .maxstack 3
	        .locals init (
	            [0] string CS$1$0000)
	        L_0000: nop 
	        L_0001: ldstr "ponto ({0}, {1})"
	        L_0006: ldarg.0 
	        L_0007: ldfld int32 _207_CILStruct.Ponto::x
	        L_000c: box int32
	        L_0011: ldarg.0 
	        L_0012: ldfld int32 _207_CILStruct.Ponto::y
	        L_0017: box int32
	        L_001c: call string [mscorlib]System.String::Format(string, object, object)
	        L_0021: stloc.0 
	        L_0022: br.s L_0024
	        L_0024: ldloc.0 
	        L_0025: ret 
	    }
	
	
	    .field public int32 x
	
	    .field public int32 y
	
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
	        .maxstack 2
	        .locals init (
	            [0] valuetype _207_CILStruct.Ponto p)
	        L_0000: nop 
	        L_0001: ldloca.s p
	        L_0003: ldc.i4.s 10
	        L_0005: stfld int32 _207_CILStruct.Ponto::x
	        L_000a: ldloca.s p
	        L_000c: ldc.i4.5 
	        L_000d: stfld int32 _207_CILStruct.Ponto::y
	        L_0012: ldloc.0 
	        L_0013: box _207_CILStruct.Ponto
	        L_0018: call void [mscorlib]System.Console::WriteLine(object)
	        L_001d: nop 
	        L_001e: call valuetype [mscorlib]System.ConsoleKeyInfo [mscorlib]System.Console::ReadKey()
	        L_0023: pop 
	        L_0024: ret 
	    }
	
	}
}
