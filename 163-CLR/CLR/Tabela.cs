using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using Microsoft.SqlServer.Server;
using System.IO;
using System.Text;

public partial class Tabela
{
    [Microsoft.SqlServer.Server.SqlProcedure]
    public static void Exportar(String nome)
    {
        String sc = "context connection=true";

        using (SqlConnection c = new SqlConnection(sc))
        {
            String cmd = "SELECT * FROM " + nome;

            using (SqlCommand k = new SqlCommand(cmd, c))
            {
                c.Open();

                using (SqlDataReader dr = k.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        StringBuilder sb = new StringBuilder();

                        for (int i = 0; i < dr.FieldCount; i++)
                        {
                            sb.Append(dr[i]);

                            if (i < dr.FieldCount - 1)
                                sb.Append("|");
                        }

                        Escrever(sb.ToString(), nome);
                    }
                }

                c.Close();
            }

            SqlContext.Pipe.Send(@"o arquivo está em C:\dados");
        }
    }

    private static void Escrever(String linha, String nome)
    {
        using (StreamWriter arquivo = new StreamWriter(String.Format(@"C:\dados\{0}.txt", nome), true, Encoding.UTF8))
        {
            arquivo.WriteLine(linha);
            arquivo.Close();
        }
    }
};

//o usuário do serviço SQL TEM QUE TER ACESSO à pasta

/*
--ou faço o deploy pelo VS2010 ou sigo os dois passos abaixo

ALTER DATABASE VS2010
SET TRUSTWORTHY ON

--REGISTRAR O ASSEMBLY
CREATE ASSEMBLY CLR
AUTHORIZATION dbo
FROM 'C:\Users\Usuario\Desktop\VS2010\162-CLR\CLR\bin\Debug\CLR.dll'
WITH PERMISSION_SET = EXTERNAL_ACCESS

GO

--CRIAR A PROCEDURE
CREATE PROCEDURE dbo.Exportar
	@nome SYSNAME
	WITH EXECUTE AS CALLER
AS
EXTERNAL NAME CLR.Tabela.Exportar
GO

EXEC EXPORTAR 'PESSOA'
*/
