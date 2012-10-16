using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Reflection.Emit;
using System.Threading;

namespace _335_Assembly
{
    class Program
    {
        static void Main(string[] args)
        {
            AssemblyName assemblyName = new AssemblyName();

            assemblyName.Name = "Util";
            assemblyName.Version = new Version("1.0.0.0");

            AssemblyBuilder assemblyBuilder =
              Thread.GetDomain().DefineDynamicAssembly(assemblyName,
              AssemblyBuilderAccess.Save);

            ModuleBuilder module =
              assemblyBuilder.DefineDynamicModule("Util", "Util.dll");

            TypeBuilder pessoaClass = module.DefineType("Util.Pessoa",
              TypeAttributes.Public);

            FieldBuilder nomeField =
              pessoaClass.DefineField("nome", Type.GetType("System.String"),
              FieldAttributes.Private);

            Type[] constructorArgs = new Type[1];
            constructorArgs[0] = typeof(string);

            ConstructorBuilder constructorBuilder =
              pessoaClass.DefineConstructor(MethodAttributes.Public,
              CallingConventions.Standard,
              constructorArgs);

            ILGenerator constructorIL = constructorBuilder.GetILGenerator();
            constructorIL.Emit(OpCodes.Ldarg_0);

            Type objectClass = typeof(object);

            ConstructorInfo superConstructor =
              objectClass.GetConstructor(new Type[0]);

            constructorIL.Emit(OpCodes.Call, superConstructor);
            constructorIL.Emit(OpCodes.Ldarg_0);
            constructorIL.Emit(OpCodes.Ldarg_1);
            constructorIL.Emit(OpCodes.Stfld, nomeField);
            constructorIL.Emit(OpCodes.Ret);

            pessoaClass.DefineDefaultConstructor(MethodAttributes.Public);

            MethodBuilder getNome =
              pessoaClass.DefineMethod("GetNome", MethodAttributes.Public,
              typeof(string), null);

            ILGenerator methodIL = getNome.GetILGenerator();
            methodIL.Emit(OpCodes.Ldarg_0);
            methodIL.Emit(OpCodes.Ldfld, nomeField);
            methodIL.Emit(OpCodes.Ret);

            pessoaClass.CreateType();

            assemblyBuilder.Save("Util.dll");

            //
            Assembly assemblyUtil = Assembly.Load("Util");

            Type pessoa = assemblyUtil.GetType("Util.Pessoa");

            object[] argumentos = new object[1];
            argumentos[0] = "Adão";

            object obj = Activator.CreateInstance(pessoa, argumentos);

            MethodInfo mi = pessoa.GetMethod("GetNome");
            Console.WriteLine(mi.Invoke(obj, null));

            Console.ReadKey();
        }
    }
}
