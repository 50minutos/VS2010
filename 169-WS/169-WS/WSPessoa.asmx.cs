using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data.SqlClient;

namespace _169_WS
{
    /// <summary>
    /// Summary description for WSPessoa
    /// </summary>
    [WebService(Namespace = "http://50minutos.com.br/exemplos/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    public class WSPessoa : System.Web.Services.WebService
    {
        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public int Somar(int x, int y) { return x + y; }

        [WebMethod]
        public List<Pessoa> Selecionar()
        {
            List<Pessoa> retorno = new List<Pessoa>();

            String sc = @"Data Source=.\sqlexpress;Initial Catalog=VS2010;Integrated Security=true;";

            using (SqlConnection c = new SqlConnection(sc))
            {
                String cmd = "SELECT * FROM PESSOA";

                using (SqlCommand k = new SqlCommand(cmd, c))
                {
                    c.Open();
                    SqlDataReader dr = k.ExecuteReader(System.Data.CommandBehavior.CloseConnection);

                    while(dr.Read())
                    {
                        retorno.Add(new Pessoa(Convert.ToInt32(dr["COD_PESSOA"]), dr["NOME_PESSOA"].ToString(), dr["SEXO_PESSOA"].ToString()[0]));    
                    }
                }
            }

            return retorno;
        }


    }
}
