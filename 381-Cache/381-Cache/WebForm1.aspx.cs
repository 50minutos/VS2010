using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _381_Cache
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Cache["NAO_EXPIRA"] == null)
                Cache["NAO_EXPIRA"] = "NUNCA VAI EXPIRAR";

            if (Cache["EXPIRA_10_SEGUNDOS"] == null)
                Cache.Insert("EXPIRA_10_SEGUNDOS", "EXPIRA APÓS 10 SEGUNDOS SEM USO", null, System.Web.Caching.Cache.NoAbsoluteExpiration, new TimeSpan(0, 0, 10));

            if (Cache["EXPIRA_FINAL_DO_ANO"] == null)
                Cache.Insert("EXPIRA_FINAL_DO_ANO", "EXPIRA EM 31/12/2011 23:59:59", null, new DateTime(2011, 12, 31, 23, 59, 59), System.Web.Caching.Cache.NoSlidingExpiration);
       }
    }
}