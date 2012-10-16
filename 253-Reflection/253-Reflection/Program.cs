using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace _253_Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            //MostrarElementosEnum();

            Pessoa p = new Pessoa();

            //MostrarDados(p.GetType());
            //MostrarDados(typeof(Sexo));
            //MostrarDados(typeof(IAnimal));

            //MostrarCampos(p.GetType());
            //MostrarCampos(typeof(Int32));

            //MostrarPropriedades(p.GetType());
            //MostrarPropriedades(typeof(String));

            //MostrarMetodos(p.GetType());
            //MostrarMetodos(typeof(Int32));

            //MostrarConstrutores(p.GetType());
            //MostrarConstrutores(typeof(String));

            MostrarInterfaces(p.GetType());
            MostrarInterfaces(typeof(System.Data.DataSet));

            Console.ReadKey();
        }

        private static void MostrarInterfaces(Type t)
        {
            foreach (Type item in t.GetInterfaces())
            {
                Console.WriteLine("Assinatura........: {0}", item);
                Console.WriteLine("Name..............: {0}", item.Name);

                Console.WriteLine();

            }
        }

        private static void MostrarConstrutores(Type t)
        {
            foreach (ConstructorInfo item in t.GetConstructors())
            {
                Console.WriteLine("Assinatura........: {0}", item);
                Console.WriteLine("Name..............: {0}", item.Name);
                Console.WriteLine("Construtor?.......: {0}", item.IsConstructor);
                Console.WriteLine("Calling convention: {0}", item.CallingConvention);
                Console.WriteLine("Tipo refletido....: {0}", item.ReflectedType.Name);

                Console.WriteLine();
            }
        }

        private static void MostrarMetodos(Type t)
        {
            foreach (MethodInfo item in t.GetMethods())
            {
                Console.WriteLine("Assinatura........: {0}", item);
                Console.WriteLine("Name..............: {0}", item.Name);
                Console.WriteLine("Retorno...........: {0}", item.ReturnParameter);
                Console.WriteLine("Tipo do retorno...: {0}", item.ReturnType);
                Console.WriteLine("Construtor?.......: {0}", item.IsConstructor);
                Console.WriteLine("Calling convention: {0}", item.CallingConvention);
                Console.WriteLine("Tipo refletido....: {0}", item.ReflectedType.Name);

                Console.WriteLine();

            }
        }

        private static void MostrarPropriedades(Type t)
        {
            foreach (PropertyInfo item in t.GetProperties())
            {
                Console.WriteLine("Name..............: {0}", item.Name);
                Console.WriteLine("Type..............: {0}", item.PropertyType);
                Console.WriteLine("Read..............: {0}", item.CanRead);
                Console.WriteLine("Write.............: {0}", item.CanWrite);
                Console.WriteLine("Tipo refletido....: {0}", item.ReflectedType.Name);

                Console.WriteLine();
            }
        }

        private static void MostrarCampos(Type t)
        {
            foreach (FieldInfo item in t.GetFields())
            {

                Console.WriteLine("Name..............: {0}", item.Name);
                Console.WriteLine("Type..............: {0}", item.FieldType);
                Console.WriteLine("Private...........: {0}", item.IsPrivate);
                Console.WriteLine("Internal..........: {0}", item.IsAssembly);
                Console.WriteLine("Protected.........: {0}", item.IsFamily);
                Console.WriteLine("Protected internal: {0}", item.IsFamilyAndAssembly);
                Console.WriteLine("Public............: {0}", item.IsPublic);
                Console.WriteLine("Static............: {0}", item.IsStatic);
                Console.WriteLine("Literal...........: {0}", item.IsLiteral);
                Console.WriteLine("Tipo refletido....: {0}", item.ReflectedType.Name);

                Console.WriteLine();
            }
        }

        private static void MostrarDados(Type t)
        {
            Console.WriteLine(t.AssemblyQualifiedName);
            Console.WriteLine(t.Namespace);
            Console.WriteLine(t.Name);
            Console.WriteLine(t.IsValueType);
            Console.WriteLine(t.IsPublic);
            Console.WriteLine(t.IsClass);
            Console.WriteLine(t.IsInterface);
            Console.WriteLine(t.IsEnum);
        }

        private static void MostrarElementosEnum()
        {
            foreach (var item in Enum.GetValues(typeof(Sexo)))
            {
                Console.WriteLine("{0} - {1}", (int)item, item);
            }
        }
    }

    public enum Sexo
    {
        m, masculino = m, masc = m, f, feminino = f, fem = f
    }

    interface IAnimal
    {
        void Nascer();
        void Morrer();
    }

    public class Pessoa : IAnimal
    {
        public int codigo; //campo

        public const String COR_DO_SANGUE = "vermelho";

        public String Nome { get; set; } //propriedade
        public Sexo Sexo { get; set; }

        public static void Acordar() { Console.WriteLine("A Pessoa acordou"); }
        public static void Dormir() { Console.WriteLine("A Pessoa dormiu"); }
        public void Nascer() { Console.WriteLine("A Pessoa nasceu"); }
        public void Morrer() { Console.WriteLine("A Pessoa morreu"); }

        public Pessoa() //construtor
        {

        }

        public Pessoa(int codigo, String nome, Sexo sexo)
        {
            this.codigo = codigo;
            this.Nome = nome;
            this.Sexo = sexo;
        }
    }
}
