using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace _221_LinqToDataSet
{
    class Program
    {
        static void Main(string[] args)
        {
            DataTable dt = new DataTable("PRODUTOS");

            dt.Columns.Add("CODIGO", typeof(int));
            dt.Columns.Add("DESCRICAO", typeof(String));
            dt.Columns.Add("PRECO", typeof(double));

            dt.Columns[1].MaxLength = 50;

            DataRow dr = dt.NewRow();

            dr[0] = 1;
            dr[1] = "MARTELO";
            dr[2] = 33.10;

            dt.Rows.Add(dr);

            dr = dt.NewRow();

            dr[0] = 2;
            dr[1] = "SERROTE";
            dr[2] = 110.20;

            dt.Rows.Add(dr);

            dr = dt.NewRow();

            dr[0] = 3;
            dr[1] = "CHAVE DE FENDA";
            dr[2] = 13.30;

            dt.Rows.Add(dr);

            var produtos = from p in dt.AsEnumerable()
                           select p;

            foreach (var produto in produtos)
            {
                foreach (var campo in produto.ItemArray)
                {
                    Console.Write("{0} ", campo);
                }

                Console.WriteLine();
            }

            Console.WriteLine();

            DataTable novaTabela = dt
                .AsEnumerable()
                .Where(p => p.Field<double>(2) > 15)
                .CopyToDataTable();

            foreach (DataRow linha in novaTabela.Rows)
            {
                foreach (DataColumn coluna in novaTabela.Columns)
                {
                    Console.Write("{0} ", linha[coluna]);
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
