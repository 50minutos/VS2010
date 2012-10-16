using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _379_Session
{
    public class PaginaModelo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
             if (Session["USUARIO"] == null)
              Response.Redirect("~/Login.aspx");
            }
    }
}