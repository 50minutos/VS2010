namespace BLL_DAL
{
    partial class Relatorio
    {
        public Model.UsuarioModel[] ObterDadosRelatorioA()
        {
            return DAL.RelatorioDAL.ObterDadosRelatorioA();
        }
    }
}