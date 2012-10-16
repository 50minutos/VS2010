namespace BLL_DAL
{
    public class Usuario : IUsuario
    {
        public void Inserir(Model.UsuarioModel usuario)
        {
            //aqui vão as validações de negócio
            DAL.UsuarioDAL.Inserir(usuario);
        }

        public void Alterar(Model.UsuarioModel usuario)
        {
            //aqui vão as validações de negócio
            DAL.UsuarioDAL.Alterar(usuario);
        }

        public void Excluir(Model.UsuarioModel usuario)
        {
            //aqui vão as validações de negócio
            DAL.UsuarioDAL.Excluir(usuario);
        }

        public Model.UsuarioModel[] Consultar()
        {
            //aqui vão as validações de negócio
            return DAL.UsuarioDAL.Consultar();
        }

        public Model.UsuarioModel Consultar(Model.UsuarioModel usuario)
        {
            //aqui vão as validações de negócio
            return DAL.UsuarioDAL.Consultar(usuario);
        }

        public Model.UsuarioModel Logar(Model.UsuarioModel usuario)
        {
            return DAL.UsuarioDAL.Logar(usuario);
        }
    }
}
