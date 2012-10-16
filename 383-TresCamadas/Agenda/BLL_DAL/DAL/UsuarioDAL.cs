using System.Linq;
using System.Collections.Generic;

namespace BLL_DAL.DAL
{
    public class UsuarioDAL
    {
        public static void Inserir(Model.UsuarioModel usuario)
        {
            Util
                .Helper
                .Inserir(usuario);
        }

        public static void Alterar(Model.UsuarioModel usuario)
        {
            Util
                .Helper
                .Alterar(usuario);
        }

        public static void Excluir(Model.UsuarioModel usuario)
        {
            Util
                .Helper
                .Excluir(usuario);
        }

        public static Model.UsuarioModel[] Consultar()
        {
            return Util
                .Helper
                .ObterArray<Model.UsuarioModel>();
        }

        public static Model.UsuarioModel Consultar(Model.UsuarioModel usuario)
        {
            return Util
                .Helper
                .ObterObjeto<Model.UsuarioModel>(usuario);
        }

        public static Model.UsuarioModel Logar(Model.UsuarioModel usuario)
        {
            Model.UsuarioModel[] usuarios = Util
                    .Helper
                    .ExecutarProcedure<Model.UsuarioModel>("USP_LOGAR", new object[] { usuario.NomeUsuario, usuario.PwdUsuario });

            return usuarios == null || usuarios.Length == 0 ? null : usuarios[0];
        }
    }
}