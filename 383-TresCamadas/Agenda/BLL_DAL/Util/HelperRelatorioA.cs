using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using BLL_DAL.Model;

namespace BLL_DAL.Util
{
    partial class Helper
    {
        #region RELATORIO - Relatório A
        public static UsuarioModel[] ObterDadosRelatorioA()
        {
            var usuarios = Util
               .Helper
               .ObterTabela<Model.UsuarioModel>();

            var dados = from u in usuarios
                        select u;

            return dados.ToArray<UsuarioModel>();
        }
        #endregion
    }
}