.assembly _208_CILClassInheritance
{
    .ver 1:0:0:0
    .hash algorithm 0x00008004
}

.assembly extern mscorlib
{
    .ver 4:0:0:0
    .publickeytoken = (B7 7A 5C 56 19 34 E0 89)
}

.module _208_CILClassInheritance.exe
.subsystem 0x0003

.namespace _208_CILClassInheritance
{
	.class private auto ansi beforefieldinit Ponto
	    extends [mscorlib]System.Object
	{
	    .method public hidebysig specialname rtspecialname instance void .ctor() cil managed
	    {
	        .maxstack 8
	        L_0000: ldarg.0 
	        L_0001: call instance void [mscorlib]System.Object::.ctor()
	        L_0006: ret 
	    }
	
	    .method public hidebysig virtual instance string ToString() cil managed
	    {
	        .maxstack 3
	        .locals init (
	            [0] string CS$1$0000)
	        L_0000: nop 
	        L_0001: ldstr "({0}, {1})"
	        L_0006: ldarg.0 
	        L_0007: ldfld int32 _208_CILClassInheritance.Ponto::x
	        L_000c: box int32
	        L_0011: ldarg.0 
	        L_0012: ldfld int32 _208_CILClassInheritance.Ponto::y
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
	
	.class private auto ansi beforefieldinit Ponto3D
	    extends _208_CILClassInheritance.Ponto
	{
	    .method public hidebysig specialname rtspecialname instance void .ctor() cil managed
	    {
	        .maxstack 8
	        L_0000: ldarg.0 
	        L_0001: call instance void _208_CILClassInheritance.Ponto::.ctor()
	        L_0006: ret 
	    }
	
	    .method public hidebysig virtual instance string ToString() cil managed
	    {
	        .maxstack 4
	        .locals init (
	            [0] string CS$1$0000)
	        L_0000: nop 
	        L_0001: ldstr "({0}, {1}, {2})"
	        L_0006: ldarg.0 
	        L_0007: ldfld int32 _208_CILClassInheritance.Ponto::x
	        L_000c: box int32
	        L_0011: ldarg.0 
	        L_0012: ldfld int32 _208_CILClassInheritance.Ponto::y
	        L_0017: box int32
	        L_001c: ldarg.0 
	        L_001d: ldfld int32 _208_CILClassInheritance.Ponto3D::z
	        L_0022: box int32
	        L_0027: call string [mscorlib]System.String::Format(string, object, object, object)
	        L_002c: stloc.0 
	        L_002d: br.s L_002f
	        L_002f: ldloc.0 
	        L_0030: ret 
	    }
	
	
	    .field public int32 z
	
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
	            [0] class _208_CILClassInheritance.Ponto3D p)
	        L_0000: nop 
	        L_0001: newobj instance void _208_CILClassInheritance.Ponto3D::.ctor()
	        L_0006: stloc.0 
	        L_0007: ldloc.0 
	        L_0008: ldc.i4.s 10
	        L_000a: stfld int32 _208_CILClassInheritance.Ponto::x
	        L_000f: ldloc.0 
	        L_0010: ldc.i4.5 
	        L_0011: stfld int32 _208_CILClassInheritance.Ponto::y
	        L_0016: ldloc.0 
	        L_0017: ldc.i4.s 20
	        L_0019: stfld int32 _208_CILClassInheritance.Ponto3D::z
	        L_001e: ldloc.0 
	        L_001f: call void [mscorlib]System.Console::WriteLine(object)
	        L_0024: nop 
	        L_0025: call valuetype [mscorlib]System.ConsoleKeyInfo [mscorlib]System.Console::ReadKey()
	        L_002a: pop 
	        L_002b: ret 
	    }
	
	}
}
