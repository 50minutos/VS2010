using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace _099_MyException
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //throw new MyException();
                //throw new MyException("erro na tela da bagaça");
                //throw new MyException(new Exception("opa... erro").ToString());
                throw new MyException(Guid.NewGuid().ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine("APLICAÇÃO: {0}", ex.Source);
                Console.WriteLine("MÉTODO: {0}", ex.TargetSite);
                Console.WriteLine("CLASSE: {0}", ex.GetType().Name);
                Console.WriteLine("MENSAGEM: {0}", ex.Message);
                Console.WriteLine("CHAMADAS: {0}", ex.StackTrace);
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }

    class MyException : Exception
    {
        public MyException(String msg = "sem mensagem definida")
            : base(msg)
        {
            using(StreamWriter arquivo = new StreamWriter(String.Format("log{0}.txt", DateTime.Now.ToString("yyyyMMdd")), true, Encoding.UTF8))
            {
                arquivo.WriteLine("{0} - {1}", DateTime.Now.ToString("HH:mm:ss.fff"), msg);
                arquivo.Close();
            }
        }
    }
}
