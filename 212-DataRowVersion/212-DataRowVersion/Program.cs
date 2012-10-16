using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace _212_DataRowVersion
{
    class Program
    {
        static void Main(string[] args)
        {
            DataTable dt = new DataTable("LIVRO");

            dt.Columns.Add("CODIGO", typeof(int));
            dt.Columns.Add("TITULO", typeof(String));
            dt.Columns.Add("PRECO", typeof(double));

            DataRow dr = dt.NewRow();

            foreach (DataColumn coluna in dt.Columns)
            {
                try { Console.WriteLine("Original: {0}", dr[coluna, DataRowVersion.Original]); }
                catch { }

                try { Console.WriteLine("Current: {0}", dr[coluna, DataRowVersion.Current]); }
                catch { }

                try { Console.WriteLine("Default: {0}", dr[coluna, DataRowVersion.Default]); }
                catch { }

                try { Console.WriteLine("Proposed: {0}", dr[coluna, DataRowVersion.Proposed]); }
                catch { }

                Console.WriteLine();
            }

            Console.WriteLine("---------------------------------------\n");

            dr[0] = 1;
            dr[1] = "ABC DO TRUCO";
            dr[2] = 10.10;

            foreach (DataColumn coluna in dt.Columns)
            {
                try { Console.WriteLine("Original: {0}", dr[coluna, DataRowVersion.Original]); }
                catch { }

                try { Console.WriteLine("Current: {0}", dr[coluna, DataRowVersion.Current]); }
                catch { }

                try { Console.WriteLine("Default: {0}", dr[coluna, DataRowVersion.Default]); }
                catch { }

                try { Console.WriteLine("Proposed: {0}", dr[coluna, DataRowVersion.Proposed]); }
                catch { }

                Console.WriteLine();
            }

            dt.Rows.Add(dr);

            dt.AcceptChanges();

            Console.WriteLine("---------------------------------------\n");

            foreach (DataRow linha in dt.Rows)
            {
                foreach (DataColumn coluna in dt.Columns)
                {
                    try { Console.WriteLine("Original: {0}", linha[coluna, DataRowVersion.Original]); }
                    catch { }

                    try { Console.WriteLine("Current: {0}", linha[coluna, DataRowVersion.Current]); }
                    catch { }

                    try { Console.WriteLine("Default: {0}", linha[coluna, DataRowVersion.Default]); }
                    catch { }

                    try { Console.WriteLine("Proposed: {0}", linha[coluna, DataRowVersion.Proposed]); }
                    catch { }

                    Console.WriteLine();
                }
            }

            dt.Rows[0][1] = "ABC do truco";

            dr.BeginEdit();

            Console.WriteLine("---------------------------------------\n");

            foreach (DataRow linha in dt.Rows)
            {
                foreach (DataColumn coluna in dt.Columns)
                {
                    try { Console.WriteLine("Original: {0}", linha[coluna, DataRowVersion.Original]); }
                    catch { }

                    try { Console.WriteLine("Current: {0}", linha[coluna, DataRowVersion.Current]); }
                    catch { }

                    try { Console.WriteLine("Default: {0}", linha[coluna, DataRowVersion.Default]); }
                    catch { }

                    try { Console.WriteLine("Proposed: {0}", linha[coluna, DataRowVersion.Proposed]); }
                    catch { }

                    Console.WriteLine();
                }
            }

            dr.CancelEdit(); //.EndEdit();

            Console.WriteLine("---------------------------------------\n");

            foreach (DataRow linha in dt.Rows)
            {
                foreach (DataColumn coluna in dt.Columns)
                {
                    try { Console.WriteLine("Original: {0}", linha[coluna, DataRowVersion.Original]); }
                    catch { }

                    try { Console.WriteLine("Current: {0}", linha[coluna, DataRowVersion.Current]); }
                    catch { }

                    try { Console.WriteLine("Default: {0}", linha[coluna, DataRowVersion.Default]); }
                    catch { }

                    try { Console.WriteLine("Proposed: {0}", linha[coluna, DataRowVersion.Proposed]); }
                    catch { }

                    Console.WriteLine();
                }
            }

            dr.RejectChanges(); //.AcceptChanges();

            Console.WriteLine("---------------------------------------\n");

            foreach (DataRow linha in dt.Rows)
            {
                foreach (DataColumn coluna in dt.Columns)
                {
                    try { Console.WriteLine("Original: {0}", linha[coluna, DataRowVersion.Original]); }
                    catch { }

                    try { Console.WriteLine("Current: {0}", linha[coluna, DataRowVersion.Current]); }
                    catch { }

                    try { Console.WriteLine("Default: {0}", linha[coluna, DataRowVersion.Default]); }
                    catch { }

                    try { Console.WriteLine("Proposed: {0}", linha[coluna, DataRowVersion.Proposed]); }
                    catch { }

                    Console.WriteLine();
                }
            }

            Console.ReadKey();
        }
    }
}
