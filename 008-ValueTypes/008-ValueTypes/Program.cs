using System;
using System.Numerics;

namespace _008_ValueTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CLR compliant\n");

            #region inteiros

            Console.WriteLine("byte:\n\tmenor: {0}\n\tmaior: {1}\n\ttipo: {2}\n", Byte.MinValue, byte.MaxValue, typeof(Byte));
            Console.WriteLine("short:\n\tmenor: {0}\n\tmaior: {1}\n\ttipo: {2}\n", Int16.MinValue, short.MaxValue, typeof(Int16));
            Console.WriteLine("int:\n\tmenor: {0}\n\tmaior: {1}\n\ttipo: {2}\n", Int32.MinValue, int.MaxValue, typeof(int));
            Console.WriteLine("long:\n\tmenor: {0}\n\tmaior: {1}\n\ttipo: {2}\n", Int64.MinValue, long.MaxValue, typeof(long));

            #endregion

            #region decimais

            Console.WriteLine("float:\n\tmenor: {0}\n\tmaior: {1}\n\ttipo: {2}\n", Single.MinValue, float.MaxValue, typeof(Single));
            Console.WriteLine("double:\n\tmenor: {0}\n\tmaior: {1}\n\ttipo: {2}\n", Double.MinValue, double.MaxValue, typeof(Double));
            Console.WriteLine("decimal:\n\tmenor: {0}\n\tmaior: {1}\n\ttipo: {2}\n", Decimal.MinValue, decimal.MaxValue, typeof(Decimal));

            #endregion

            #region inteiro (.net framework 4.0)

            Console.WriteLine("BigInteger:\n\t-1: {0}\n\t0: {1}\n\t+1: {2}\n\ttipo: {3}\n", BigInteger.MinusOne, BigInteger.Zero, BigInteger.One, typeof(BigInteger));

            #endregion

            #region caracter

            Console.WriteLine("char:\n\tmenor: {0}\n\tmaior: {1}\n\ttipo: {2}\n", (int)Char.MinValue, (int)char.MaxValue, typeof(Char));

            #endregion

            #region lógicos

            Console.WriteLine("bool:\n\tfalso: {0}\n\tverdadeiro: {1}\n\ttipo: {2}\n", Boolean.FalseString, bool.TrueString, typeof(Boolean));

            #endregion

            #region data e hora

            Console.WriteLine("DateTime:\n\tmenor: {0}\n\tmaior: {1}\n\ttipo: {2}\n", DateTime.MinValue, DateTime.MaxValue, typeof(DateTime));

            #endregion

            Console.WriteLine("not CLR compliant\n");

            #region inteiros 

            Console.WriteLine("sbyte:\n\tmenor: {0}\n\tmaior: {1}\n\ttipo: {2}\n", SByte.MinValue, sbyte.MaxValue, typeof(SByte));
            Console.WriteLine("ushort:\n\tmenor: {0}\n\tmaior: {1}\n\ttipo: {2}\n", UInt16.MinValue, ushort.MaxValue, typeof(UInt16));
            Console.WriteLine("uint:\n\tmenor: {0}\n\tmaior: {1}\n\ttipo: {2}\n", UInt32.MinValue, uint.MaxValue, typeof(uint));
            Console.WriteLine("ulong:\n\tmenor: {0}\n\tmaior: {1}\n\ttipo: {2}\n", UInt64.MinValue, ulong.MaxValue, typeof(ulong));

            #endregion

            Console.ReadKey();
        }
    }
}
