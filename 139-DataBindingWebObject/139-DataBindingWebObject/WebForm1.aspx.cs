using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _139_DataBindingWebObject
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Livro[] livros = { 
                new Livro(){Titulo="Advanced mouse clicator - entenda a diferença entre um duplo clique e dois cliques", Preco=98.22}, 
                new Livro(){Titulo="ABC do mouse", Preco=120.45}, 
                new Livro(){Titulo="Como programar: CTRL+C, CTRL+V sem mistério", Preco=111}, 
                new Livro(){Titulo="Com ser um drag-and-drop developer de sucesso", Preco=132.23}
            };


            GridView1.DataSource = from livro in livros
                                   orderby livro.Preco
                                   select livro;

            GridView1.DataBind();
        }
    }
}