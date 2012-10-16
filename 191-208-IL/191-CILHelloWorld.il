.assembly extern mscorlib
{
    .ver 4:0:0:0
    .publickeytoken = (B7 7A 5C 56 19 34 E0 89)
}

.assembly _191_HelloWorld
{
    .ver 1:0:0:0
    .hash algorithm 0x00008004
}

.module _191_HelloWorld.exe
.subsystem 0x0003

.namespace _191_HelloWorld
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
            .maxstack 8
            L_0000: nop 
            L_0001: ldstr "Hello World"
            L_0006: call void [mscorlib]System.Console::WriteLine(string)
            L_000b: nop 
            L_000c: call valuetype [mscorlib]System.ConsoleKeyInfo [mscorlib]System.Console::ReadKey()
            L_0011: pop 
            L_0012: ret 
	}
    }
}

