using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Web.Caching;

namespace _379_Session
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            LerXML("usuarios.xml");

            if (ValidarUsuario())
            {
                MultiView1.ActiveViewIndex = 1;
                Session["USUARIO"] = new Usuario(TextBox1.Text, TextBox2.Text);
            }
        }

        private bool ValidarUsuario()
        {
            List<Usuario> lista = (List<Usuario>)Cache["USUARIOS"];
            
            return lista.Contains(new Usuario(TextBox1.Text, TextBox2.Text));
        }

        private void LerXML(string nomeArquivo)
        {
            if (Cache["USUARIOS"] == null)
            {
                String nome = Server.MapPath(nomeArquivo);

                DataSet ds = new DataSet();
                ds.ReadXml(nome);

                List<Usuario> lista = new List<Usuario>();

                foreach (DataRow linha in ds.Tables[0].Rows)
                {
                    lista.Add(new Usuario(linha["id"].ToString(), linha["senha"].ToString()));
                }

                CacheDependency cd = new CacheDependency(nome);

                Cache.Insert("USUARIOS", lista, cd);
            }
        }

    }
}