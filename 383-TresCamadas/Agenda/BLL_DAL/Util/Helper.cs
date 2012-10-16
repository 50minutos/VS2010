using System;
using System.Collections.ObjectModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Collections.Generic;
using System.Collections;

namespace BLL_DAL.Util
{
    public partial class Helper
    {
        #region SQL SERVER
        private static DataContext ObterDataContext()
        {
            return new DataContext(@"Data Source=.\SQLEXPRESS;Initial Catalog=AGENDA;Integrated Security=true;");
        }

        private static Table<T> ObterTabela<T>() where T : class
        {
            return ObterDataContext().GetTable<T>();
        }

        public static T[] ExecutarProcedure<T>(String nomeProcedure, Object[] parametros)
        {
            T[] retorno = null;

            using (DataContext dc = ObterDataContext())
            {
                retorno = dc.ExecuteQuery(typeof(T), nomeProcedure + " {0}, {1}", parametros).Cast<T>().ToArray<T>();
            }

            return retorno;
        }
        #endregion
    }
}