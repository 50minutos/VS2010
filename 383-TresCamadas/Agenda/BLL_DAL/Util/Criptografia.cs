using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace BLL_DAL.Util
{
    class Criptografia
    {
        private static byte[] key = Encoding.UTF8.GetBytes("Ess@ fraZ3 de^e te7 > B2 < 6yt3S");
        private static byte[] iv = Encoding.UTF8.GetBytes("Ess@ d3v3 T3r lb");

        public static String Encriptar(String mensagem)
        {
            String retorno = String.Empty;

            try
            {
                RijndaelManaged rm = new RijndaelManaged();
                rm.Key = key;
                rm.IV = iv;

                MemoryStream ms = new MemoryStream();

                CryptoStream cs = new CryptoStream(ms, rm.CreateEncryptor(rm.Key, rm.IV), CryptoStreamMode.Write);

                cs.Write(Encoding.Default.GetBytes(mensagem), 0, mensagem.Length);

                cs.FlushFinalBlock();

                retorno = Convert.ToBase64String(ms.ToArray());

                ms.Close();
                cs.Close();
            }
            catch { }

            return retorno;
        }

        public static String Decriptar(String mensagem)
        {
            String retorno = String.Empty;

            try
            {
                RijndaelManaged rm = new RijndaelManaged();
                rm.Key = key;
                rm.IV = iv;

                byte[] cifrada = Convert.FromBase64String(mensagem);

                MemoryStream ms = new MemoryStream(cifrada);

                CryptoStream cs = new CryptoStream(ms, rm.CreateDecryptor(rm.Key, rm.IV), CryptoStreamMode.Read);

                byte[] decriptada = new byte[cifrada.Length];

                int qtd = cs.Read(decriptada, 0, decriptada.Length);

                retorno = Encoding.Default.GetString(decriptada, 0, qtd);

                ms.Close();
                cs.Close();
            }
            catch { }

            return retorno;
        }
    }
}