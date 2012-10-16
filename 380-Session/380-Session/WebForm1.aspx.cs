using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _380_Session
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = Session.SessionID;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["NOME"] = TextBox1.Text;
            Response.Redirect(Request.ServerVariables["URL"]);
        }
    }
}