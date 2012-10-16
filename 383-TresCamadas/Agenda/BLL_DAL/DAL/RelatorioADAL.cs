using System.Linq;
using BLL_DAL.Model;

namespace BLL_DAL.DAL
{
    partial class RelatorioDAL
    {
        public static UsuarioModel[] ObterDadosRelatorioA()
        {
            return Util.Helper.ObterDadosRelatorioA();
        }
    }
}