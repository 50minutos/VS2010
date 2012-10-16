using System.ServiceModel;

namespace BLL_DAL
{
    [ServiceContract]
    public interface IUsuario
    {
        [OperationContract]
        void Inserir(Model.UsuarioModel usuario);

        [OperationContract]
        void Alterar(Model.UsuarioModel usuario);

        [OperationContract]
        void Excluir(Model.UsuarioModel usuario);

        [OperationContract]
        Model.UsuarioModel[] Consultar();

        [OperationContract(Name="ConsultarCodUsuario")]
        Model.UsuarioModel Consultar(Model.UsuarioModel usuario);

        [OperationContract]
        Model.UsuarioModel Logar(Model.UsuarioModel usuario);
    }
}
