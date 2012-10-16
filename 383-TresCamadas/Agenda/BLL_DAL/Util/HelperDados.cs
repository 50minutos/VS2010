using System;
using System.Collections.ObjectModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;

namespace BLL_DAL.Util
{
    partial class Helper
    {
        #region CRUD
        public static T[] ObterArray<T>() where T : class
        {
            return ObterTabela<T>().ToArray<T>();
        }

        public static T ObterObjeto<T>(T t) where T : class
        {
            Table<T> tabela = ObterTabela<T>();

            Type tipo = typeof(T);

            ReadOnlyCollection<MetaDataMember> dm = tabela.Context.Mapping.GetMetaType(typeof(T)).DataMembers;

            var pks = dm.Where<MetaDataMember>(m => m.IsPrimaryKey);

            return tabela.SingleOrDefault<T>(delegate(T tmp)
            {
                bool retorno = true;

                foreach (var item in pks)
                {
                    retorno = tipo.GetProperty(item.Name).GetValue(tmp, null).ToString()
                        .Equals
                        (
                            tipo.GetProperty(item.Name).GetValue(t, null).ToString()
                        );

                    if (!retorno) break;
                }

                return retorno;
            });
        }

        public static void Inserir<T>(T t) where T : class
        {
            using (DataContext dc = ObterDataContext())
            {
                dc.GetTable<T>().InsertOnSubmit(t);
                dc.SubmitChanges();
            }
        }

        public static void Alterar<T>(T t) where T : class
        {
            using (DataContext dc = ObterDataContext())
            {
                dc.GetTable<T>().Attach(t, true);
                dc.SubmitChanges();
            }
        }

        public static void Excluir<T>(T t) where T : class
        {
            using (DataContext dc = ObterDataContext())
            {
                dc.GetTable<T>().Attach(t, true);
                dc.GetTable<T>().DeleteOnSubmit(t);
                dc.SubmitChanges();
            }
        }
        #endregion
    }
}