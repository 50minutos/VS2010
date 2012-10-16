﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

[assembly: EdmSchemaAttribute()]

namespace _239_CreateQuery
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class VS2010Entities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new VS2010Entities object using the connection string found in the 'VS2010Entities' section of the application configuration file.
        /// </summary>
        public VS2010Entities() : base("name=VS2010Entities", "VS2010Entities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new VS2010Entities object.
        /// </summary>
        public VS2010Entities(string connectionString) : base(connectionString, "VS2010Entities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new VS2010Entities object.
        /// </summary>
        public VS2010Entities(EntityConnection connection) : base(connection, "VS2010Entities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<PESSOA> PESSOA
        {
            get
            {
                if ((_PESSOA == null))
                {
                    _PESSOA = base.CreateObjectSet<PESSOA>("PESSOA");
                }
                return _PESSOA;
            }
        }
        private ObjectSet<PESSOA> _PESSOA;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the PESSOA EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToPESSOA(PESSOA pESSOA)
        {
            base.AddObject("PESSOA", pESSOA);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="VS2010Model", Name="PESSOA")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class PESSOA : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new PESSOA object.
        /// </summary>
        /// <param name="cOD_PESSOA">Initial value of the COD_PESSOA property.</param>
        public static PESSOA CreatePESSOA(global::System.Int32 cOD_PESSOA)
        {
            PESSOA pESSOA = new PESSOA();
            pESSOA.COD_PESSOA = cOD_PESSOA;
            return pESSOA;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 COD_PESSOA
        {
            get
            {
                return _COD_PESSOA;
            }
            set
            {
                if (_COD_PESSOA != value)
                {
                    OnCOD_PESSOAChanging(value);
                    ReportPropertyChanging("COD_PESSOA");
                    _COD_PESSOA = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("COD_PESSOA");
                    OnCOD_PESSOAChanged();
                }
            }
        }
        private global::System.Int32 _COD_PESSOA;
        partial void OnCOD_PESSOAChanging(global::System.Int32 value);
        partial void OnCOD_PESSOAChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String NOME_PESSOA
        {
            get
            {
                return _NOME_PESSOA;
            }
            set
            {
                OnNOME_PESSOAChanging(value);
                ReportPropertyChanging("NOME_PESSOA");
                _NOME_PESSOA = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("NOME_PESSOA");
                OnNOME_PESSOAChanged();
            }
        }
        private global::System.String _NOME_PESSOA;
        partial void OnNOME_PESSOAChanging(global::System.String value);
        partial void OnNOME_PESSOAChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String SEXO_PESSOA
        {
            get
            {
                return _SEXO_PESSOA;
            }
            set
            {
                OnSEXO_PESSOAChanging(value);
                ReportPropertyChanging("SEXO_PESSOA");
                _SEXO_PESSOA = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("SEXO_PESSOA");
                OnSEXO_PESSOAChanged();
            }
        }
        private global::System.String _SEXO_PESSOA;
        partial void OnSEXO_PESSOAChanging(global::System.String value);
        partial void OnSEXO_PESSOAChanged();

        #endregion
    
    }

    #endregion
    
}
