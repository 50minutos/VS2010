using System;

namespace DLL
{
    public class Texto
    {
        public String Gerar()
        {
            String retorno = String.Empty;

            Random r = new Random();

            switch (r.Next(1, 6))
            {
                case 1:
                    retorno = "Ordem e Progresso"; break;
                case 2:
                    retorno = "50minutos"; break;
                case 3:
                    retorno = "São Paulo - o estado"; break;
                case 4:
                    retorno = "São Paulo - a cidade"; break;
                case 5:
                    retorno = "São Paulo - o time"; break;
            }

            return retorno;
        }
    }
}
