using System.ServiceModel;

namespace BLL_DAL
{
    partial interface IRelatorio
    {
        [OperationContract]
        Model.UsuarioModel[] ObterDadosRelatorioA();
    }
}