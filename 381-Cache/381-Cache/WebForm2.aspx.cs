using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _381_Cache
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Cache["NAO_EXPIRA"] != null)
                Label1.Text = Cache["NAO_EXPIRA"].ToString();

            if (Cache["EXPIRA_10_SEGUNDOS"] != null)
                Label2.Text = Cache["EXPIRA_10_SEGUNDOS"].ToString();

            if (Cache["EXPIRA_FINAL_DO_ANO"] != null)
                Label3.Text = Cache["EXPIRA_FINAL_DO_ANO"].ToString();
        }
    }
}