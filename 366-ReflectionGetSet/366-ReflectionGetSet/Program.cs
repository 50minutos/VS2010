using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace _366_ReflectionGetSet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Você quer criar um [Livro] ou uma [Pessoa]? ");
            String opcao = Console.ReadLine();
            Type t = Type.GetType(String.Format("{0}.{1}", typeof(Program).Namespace, opcao));
            Object o = Activator.CreateInstance(t);

            Encher(o);
            Imprimir(o);

            Console.ReadKey();
        }

        private static void Imprimir(object o)
        {
            Type t = o.GetType();

            PropertyInfo[] pi = t.GetProperties();

            foreach (var item in pi)
            {
                if (item.CanRead)
                {
                    Console.WriteLine("{0} - {1}", item.Name, item.GetValue(o, null));
                }
            }
        }

        private static void Encher(object o)
        {
            Type t = o.GetType();

            PropertyInfo[] pi = t.GetProperties();

            foreach (var item in pi)
            {
                if (item.CanWrite)
                {
                    if (item.Name.Equals("Id"))
                        item.SetValue(o, Guid.NewGuid(), null);
                    else
                    {
                        Console.Write("Digite {0}: ", item.Name);
                        String valor = Console.ReadLine();

                        if (!item.PropertyType.IsEnum)
                            item.SetValue(o, Convert.ChangeType(valor, item.PropertyType), null);
                        else
                            item.SetValue(o, Enum.Parse(typeof(Sexo), valor), null);
                    }
                }
            }
        }
    }

    enum Sexo
    {
        m, f, masculino = m, feminino = f
    }

    class Pessoa
    {
        public int Codigo { get; set; }
        public String Nome { get; set; }
        public Sexo Sexo { get; set; }
    }

    class Livro
    {
        public Guid Id { get; set; }
        public String Titulo { get; set; }
        public int QtdPaginas { get; set; }
        public double Preco { get; set; }
    }
}
