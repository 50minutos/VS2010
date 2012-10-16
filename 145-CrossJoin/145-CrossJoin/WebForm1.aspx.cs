using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _145_CrossJoin
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Homem[] homens = new Homem[] { 
                new Homem(){Nome = "Huguinho"}, 
                new Homem(){Nome = "Zezinho"}, 
                new Homem(){Nome = "Luizinho"} 
            };

            Mulher[] mulheres = new Mulher[] { 
                new Mulher(){Nome = "Lalá", Namorado = homens[0]}, 
                new Mulher(){Nome = "Lelé", Namorado = homens[2]}, 
                new Mulher(){Nome = "Lili", Namorado = homens[1]} 
            };

            GridView1.DataSource = from h in homens
                                   from m in mulheres
                                   select new
                                   {
                                       NomeHomem = h.Nome,
                                       NomeMulher = m.Nome,
                                       Namora = m.Namorado == h
                                   };
            GridView1.DataBind();
        }
    }
}