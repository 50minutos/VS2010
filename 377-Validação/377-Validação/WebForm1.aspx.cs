using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _377_Validação
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //todo: cadastrar no database

            Label1.Text = Nome.Text;
            Label2.Text = Email.Text;
            Label3.Text = "<pre>" + Obs.Text + "</pre>";
            Label4.Text = Senha.Text;

            MultiView1.ActiveViewIndex = 1;
        }
    }
}