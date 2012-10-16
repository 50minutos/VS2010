using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Reflection;

namespace BLL_DAL.Util
{
    public static class Extensao
    {
        public static DataSet ToDataSet(this IQueryable iq)
        {
            DataTable retorno = new DataTable();

            PropertyInfo[] pis = null;

            if (iq != null)
            {
                foreach (var rec in iq)
                {
                    if (pis == null)
                    {
                        pis = ((Type)rec.GetType()).GetProperties();

                        foreach (PropertyInfo item in pis)
                        {
                            Type colType = item.PropertyType;

                            if ((colType.IsGenericType) && (colType.GetGenericTypeDefinition() == typeof(Nullable<>)))
                            {
                                colType = colType.GetGenericArguments()[0];
                            }

                            retorno.Columns.Add(new DataColumn(item.Name, colType));
                        }
                    }

                    DataRow dr = retorno.NewRow();

                    foreach (PropertyInfo item in pis)
                    {
                        dr[item.Name] = item.GetValue(rec, null) == null ? DBNull.Value : item.GetValue
                        (rec, null);
                    }

                    retorno.Rows.Add(dr);
                }
            }

            DataSet ds = new DataSet();
            ds.Tables.Add(retorno);

            return ds;
        }
    }
}