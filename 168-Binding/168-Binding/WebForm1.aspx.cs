using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace _168_Binding
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {
                    Response.Write("passei aqui dentro");

                    List<Pessoa> lista = new List<Pessoa>();

                    using (SqlConnection c = new SqlConnection())
                    {
                        c.ConnectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=VS2010;Integrated Security=true;";

                        SqlCommand k = new SqlCommand("SELECT * FROM PESSOA", c);

                        c.Open();

                        SqlDataReader dr = k.ExecuteReader();

                        while (dr.Read())
                        {
                            lista.Add(new Pessoa(Convert.ToInt32(dr["COD_PESSOA"]), dr["NOME_PESSOA"].ToString(), dr["SEXO_PESSOA"].ToString()[0]));
                        }

                        c.Close();

                        DropDownList1.DataSource = lista;

                        DropDownList1.DataTextField = "NomePessoa";
                        DropDownList1.DataValueField = "CodPessoa";

                        DropDownList1.DataBind();
                    }
                }
            }
            catch (Exception ex)
            {
                Label1.Text = String.Format("{1} - {0}", ex.Message, ex.GetType().Name);
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Label1.Text = DropDownList1.SelectedValue;
        }
    }
}