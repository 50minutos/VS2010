using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _147_PaginacaoSkipTake
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GridView1.DataSource = IteratorCidade.ObterCidades()
                    .Select((cidade, indice) => new { Indice = indice, CodigoCidade = cidade.CodigoCidade, NomeCidade = cidade.NomeCidade, SiglaEstado = cidade.SiglaEstado });

                GridView1.DataBind();

                int qtd = GridView1.Rows.Count;

                for (int i = 0; i < qtd; i++)
                {
                    DropDownList1.Items.Add(i.ToString());
                    DropDownList2.Items.Add(i.ToString());
                }

                DropDownList1.SelectedIndex = 0;
                DropDownList2.SelectedIndex = DropDownList2.Items.Count - 1;
            }
            else
                MostrarDados();
        }

        private void MostrarDados()
        {
            int primeiro = Convert.ToInt32(DropDownList1.SelectedValue);
            int ultimo = Convert.ToInt32(DropDownList2.SelectedValue);

            GridView1.DataSource = IteratorCidade.ObterCidades()
                .Select((cidade, indice) => new { Indice = indice, CodigoCidade = cidade.CodigoCidade, NomeCidade = cidade.NomeCidade, SiglaEstado = cidade.SiglaEstado })
                .Skip(primeiro)
                .Take(ultimo - primeiro + 1);

            GridView1.DataBind();
        }
    }
}