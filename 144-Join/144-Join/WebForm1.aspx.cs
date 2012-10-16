using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _144_Join
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Pai[] pais = new Pai[]{
                new Pai(){Nome = "Agnaldo Diogo dos Santos"},
                new Pai(){Nome = "Eva"}, 
                new Pai(){Nome = "Juca Nalha"}
            };

            Filho[] filhos = new Filho[]{
                new Filho(){Nome="Bruno Ferreira dos Santos", PaiMae=pais[0]},
                new Filho(){Nome="Antonio Guimarães dos Santos Neto", PaiMae=pais[0]},
                new Filho(){Nome="Pedro Henrique Ferreira dos Santos", PaiMae=pais[0]}, 
                new Filho(){Nome="Caim", PaiMae=pais[1]}, 
                new Filho(){Nome="Abel", PaiMae=pais[1]} 
           };

            GridView1.DataSource = filhos.ToList();
            GridView1.DataBind();

            GridView2.DataSource = from p in pais
                                   join f in filhos
                                        on p equals f.PaiMae into resultado
                                   select new
                                   {
                                       Nome = p.Nome,
                                       Filhos = resultado
                                   };
            GridView2.DataBind();

            GridView3.DataSource = pais
                .Join(filhos, p => p, f => f.PaiMae, (p, f) => new
                    {
                        NomePai = p.Nome,
                        NomeFilho = f.Nome
                    }
                );
            GridView3.DataBind();
        }
    }
}