using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace _180_GerarChaveAssimetrica
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                DSA algorithm: DSACryptoServiceProvider
                RSA algorithm: RSACryptoServiceProvider
            */

            //geração de chave pública e privada. 
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();

            String infoXml = rsa.ToXmlString(false); //só chave pública

            Console.WriteLine(infoXml.Replace("<", "\n<"));

            infoXml = rsa.ToXmlString(true); //chaves pública e privada

            Console.WriteLine(infoXml.Replace("<", "\n<"));

            Console.WriteLine();

            RSAParameters p = rsa.ExportParameters(false); //só chave pública

            Console.WriteLine(".ToString() -> {0}", p.ToString());
            Console.WriteLine(".Modulus -> {0}", MontarString(p.Modulus));
            Console.WriteLine(".Exponent -> {0}", MontarString(p.Exponent));
            Console.WriteLine(".P -> {0}", MontarString(p.P));
            Console.WriteLine(".Q -> {0}", MontarString(p.Q));
            Console.WriteLine(".DP -> {0}", MontarString(p.DP));
            Console.WriteLine(".DQ -> {0}", MontarString(p.DQ));
            Console.WriteLine(".InverseQ -> {0}", MontarString(p.InverseQ));
            Console.WriteLine(".D -> {0}", MontarString(p.D));
            Console.WriteLine();

            p = rsa.ExportParameters(true); //chaves pública e privada

            Console.WriteLine(".ToString() -> {0}", p.ToString());
            Console.WriteLine(".Modulus -> {0}", MontarString(p.Modulus));
            Console.WriteLine(".Exponent -> {0}", MontarString(p.Exponent));
            Console.WriteLine(".P -> {0}", MontarString(p.P));
            Console.WriteLine(".Q -> {0}", MontarString(p.Q));
            Console.WriteLine(".DP -> {0}", MontarString(p.DP));
            Console.WriteLine(".DQ -> {0}", MontarString(p.DQ));
            Console.WriteLine(".InverseQ -> {0}", MontarString(p.InverseQ));
            Console.WriteLine(".D -> {0}", MontarString(p.D));

            Console.ReadKey();
        }

        private static String MontarString(byte[] array)
        {
            StringBuilder sb = new StringBuilder();

            if (array != null)
                foreach (var item in array)
                {
                    sb.Append(String.Format("{0,4}", item));
                }

            return sb.ToString();
        }
    }
}