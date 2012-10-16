using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _138_DataBindingWeb
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
             String[] palestrantes = { 
                                "Alexandre Lopes", 
                                "Vitor Fava", 
                                "Marcelo Sincic", 
                                "Laerte Jr", 
                                "Roberto Fonseca", 
                                "Thiago Zavaschi", 
                                "Agnaldo Diogo dos Santos"
                                };

            GridView1.DataSource = from palestrante in palestrantes
                                   orderby palestrante
                                   select palestrante;

            GridView1.DataBind();
        }
    }
}