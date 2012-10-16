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
#region EDM Relationship Metadata

[assembly: EdmRelationshipAttribute("VS2010Model", "FK__FILHO__COD_PAI__117F9D94", "PESSOA", System.Data.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(_234_EntityFramework.Pessoa), "FILHO", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(_234_EntityFramework.FILHO), true)]

#endregion

namespace _234_EntityFramework
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
        public ObjectSet<FILHO> FILHO
        {
            get
            {
                if ((_FILHO == null))
                {
                    _FILHO = base.CreateObjectSet<FILHO>("FILHO");
                }
                return _FILHO;
            }
        }
        private ObjectSet<FILHO> _FILHO;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Pessoa> PESSOA
        {
            get
            {
                if ((_PESSOA == null))
                {
                    _PESSOA = base.CreateObjectSet<Pessoa>("PESSOA");
                }
                return _PESSOA;
            }
        }
        private ObjectSet<Pessoa> _PESSOA;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<PONTO> PONTO
        {
            get
            {
                if ((_PONTO == null))
                {
                    _PONTO = base.CreateObjectSet<PONTO>("PONTO");
                }
                return _PONTO;
            }
        }
        private ObjectSet<PONTO> _PONTO;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<PONTO2> PONTO2
        {
            get
            {
                if ((_PONTO2 == null))
                {
                    _PONTO2 = base.CreateObjectSet<PONTO2>("PONTO2");
                }
                return _PONTO2;
            }
        }
        private ObjectSet<PONTO2> _PONTO2;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the FILHO EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToFILHO(FILHO fILHO)
        {
            base.AddObject("FILHO", fILHO);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the PESSOA EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToPESSOA(Pessoa pessoa)
        {
            base.AddObject("PESSOA", pessoa);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the PONTO EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToPONTO(PONTO pONTO)
        {
            base.AddObject("PONTO", pONTO);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the PONTO2 EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToPONTO2(PONTO2 pONTO2)
        {
            base.AddObject("PONTO2", pONTO2);
        }

        #endregion
        #region Function Imports
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        /// <param name="cOD_PESSOA">No Metadata Documentation available.</param>
        /// <param name="nOME_PESSOA">No Metadata Documentation available.</param>
        /// <param name="sEXO_PESSOA">No Metadata Documentation available.</param>
        public int PessoaIns(Nullable<global::System.Int32> cOD_PESSOA, global::System.String nOME_PESSOA, global::System.String sEXO_PESSOA)
        {
            ObjectParameter cOD_PESSOAParameter;
            if (cOD_PESSOA.HasValue)
            {
                cOD_PESSOAParameter = new ObjectParameter("COD_PESSOA", cOD_PESSOA);
            }
            else
            {
                cOD_PESSOAParameter = new ObjectParameter("COD_PESSOA", typeof(global::System.Int32));
            }
    
            ObjectParameter nOME_PESSOAParameter;
            if (nOME_PESSOA != null)
            {
                nOME_PESSOAParameter = new ObjectParameter("NOME_PESSOA", nOME_PESSOA);
            }
            else
            {
                nOME_PESSOAParameter = new ObjectParameter("NOME_PESSOA", typeof(global::System.String));
            }
    
            ObjectParameter sEXO_PESSOAParameter;
            if (sEXO_PESSOA != null)
            {
                sEXO_PESSOAParameter = new ObjectParameter("SEXO_PESSOA", sEXO_PESSOA);
            }
            else
            {
                sEXO_PESSOAParameter = new ObjectParameter("SEXO_PESSOA", typeof(global::System.String));
            }
    
            return base.ExecuteFunction("PessoaIns", cOD_PESSOAParameter, nOME_PESSOAParameter, sEXO_PESSOAParameter);
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        /// <param name="x">No Metadata Documentation available.</param>
        /// <param name="y">No Metadata Documentation available.</param>
        public int Swap(ObjectParameter x, ObjectParameter y)
        {
            return base.ExecuteFunction("Swap", x, y);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="VS2010Model", Name="FILHO")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class FILHO : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new FILHO object.
        /// </summary>
        /// <param name="cOD_FILHO">Initial value of the COD_FILHO property.</param>
        public static FILHO CreateFILHO(global::System.Int32 cOD_FILHO)
        {
            FILHO fILHO = new FILHO();
            fILHO.COD_FILHO = cOD_FILHO;
            return fILHO;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 COD_FILHO
        {
            get
            {
                return _COD_FILHO;
            }
            set
            {
                if (_COD_FILHO != value)
                {
                    OnCOD_FILHOChanging(value);
                    ReportPropertyChanging("COD_FILHO");
                    _COD_FILHO = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("COD_FILHO");
                    OnCOD_FILHOChanged();
                }
            }
        }
        private global::System.Int32 _COD_FILHO;
        partial void OnCOD_FILHOChanging(global::System.Int32 value);
        partial void OnCOD_FILHOChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String NOME_FILHO
        {
            get
            {
                return _NOME_FILHO;
            }
            set
            {
                OnNOME_FILHOChanging(value);
                ReportPropertyChanging("NOME_FILHO");
                _NOME_FILHO = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("NOME_FILHO");
                OnNOME_FILHOChanged();
            }
        }
        private global::System.String _NOME_FILHO;
        partial void OnNOME_FILHOChanging(global::System.String value);
        partial void OnNOME_FILHOChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> COD_PAI
        {
            get
            {
                return _COD_PAI;
            }
            set
            {
                OnCOD_PAIChanging(value);
                ReportPropertyChanging("COD_PAI");
                _COD_PAI = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("COD_PAI");
                OnCOD_PAIChanged();
            }
        }
        private Nullable<global::System.Int32> _COD_PAI;
        partial void OnCOD_PAIChanging(Nullable<global::System.Int32> value);
        partial void OnCOD_PAIChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("VS2010Model", "FK__FILHO__COD_PAI__117F9D94", "PESSOA")]
        public Pessoa PESSOA
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Pessoa>("VS2010Model.FK__FILHO__COD_PAI__117F9D94", "PESSOA").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Pessoa>("VS2010Model.FK__FILHO__COD_PAI__117F9D94", "PESSOA").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Pessoa> PESSOAReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Pessoa>("VS2010Model.FK__FILHO__COD_PAI__117F9D94", "PESSOA");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Pessoa>("VS2010Model.FK__FILHO__COD_PAI__117F9D94", "PESSOA", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="VS2010Model", Name="Pessoa")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Pessoa : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Pessoa object.
        /// </summary>
        /// <param name="codPessoa">Initial value of the CodPessoa property.</param>
        public static Pessoa CreatePessoa(global::System.Int32 codPessoa)
        {
            Pessoa pessoa = new Pessoa();
            pessoa.CodPessoa = codPessoa;
            return pessoa;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 CodPessoa
        {
            get
            {
                return _CodPessoa;
            }
            set
            {
                if (_CodPessoa != value)
                {
                    OnCodPessoaChanging(value);
                    ReportPropertyChanging("CodPessoa");
                    _CodPessoa = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("CodPessoa");
                    OnCodPessoaChanged();
                }
            }
        }
        private global::System.Int32 _CodPessoa;
        partial void OnCodPessoaChanging(global::System.Int32 value);
        partial void OnCodPessoaChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String NomePessoa
        {
            get
            {
                return _NomePessoa;
            }
            set
            {
                OnNomePessoaChanging(value);
                ReportPropertyChanging("NomePessoa");
                _NomePessoa = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("NomePessoa");
                OnNomePessoaChanged();
            }
        }
        private global::System.String _NomePessoa;
        partial void OnNomePessoaChanging(global::System.String value);
        partial void OnNomePessoaChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String SexoPessoa
        {
            get
            {
                return _SexoPessoa;
            }
            set
            {
                OnSexoPessoaChanging(value);
                ReportPropertyChanging("SexoPessoa");
                _SexoPessoa = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("SexoPessoa");
                OnSexoPessoaChanged();
            }
        }
        private global::System.String _SexoPessoa;
        partial void OnSexoPessoaChanging(global::System.String value);
        partial void OnSexoPessoaChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("VS2010Model", "FK__FILHO__COD_PAI__117F9D94", "FILHO")]
        public EntityCollection<FILHO> Filho
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<FILHO>("VS2010Model.FK__FILHO__COD_PAI__117F9D94", "FILHO");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<FILHO>("VS2010Model.FK__FILHO__COD_PAI__117F9D94", "FILHO", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="VS2010Model", Name="PONTO")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class PONTO : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new PONTO object.
        /// </summary>
        /// <param name="cOD_PONTO">Initial value of the COD_PONTO property.</param>
        public static PONTO CreatePONTO(global::System.Int32 cOD_PONTO)
        {
            PONTO pONTO = new PONTO();
            pONTO.COD_PONTO = cOD_PONTO;
            return pONTO;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 COD_PONTO
        {
            get
            {
                return _COD_PONTO;
            }
            set
            {
                if (_COD_PONTO != value)
                {
                    OnCOD_PONTOChanging(value);
                    ReportPropertyChanging("COD_PONTO");
                    _COD_PONTO = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("COD_PONTO");
                    OnCOD_PONTOChanged();
                }
            }
        }
        private global::System.Int32 _COD_PONTO;
        partial void OnCOD_PONTOChanging(global::System.Int32 value);
        partial void OnCOD_PONTOChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> COD_FUNCIONARIO
        {
            get
            {
                return _COD_FUNCIONARIO;
            }
            set
            {
                OnCOD_FUNCIONARIOChanging(value);
                ReportPropertyChanging("COD_FUNCIONARIO");
                _COD_FUNCIONARIO = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("COD_FUNCIONARIO");
                OnCOD_FUNCIONARIOChanged();
            }
        }
        private Nullable<global::System.Int32> _COD_FUNCIONARIO;
        partial void OnCOD_FUNCIONARIOChanging(Nullable<global::System.Int32> value);
        partial void OnCOD_FUNCIONARIOChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTime> DATA_ENTRADA
        {
            get
            {
                return _DATA_ENTRADA;
            }
            set
            {
                OnDATA_ENTRADAChanging(value);
                ReportPropertyChanging("DATA_ENTRADA");
                _DATA_ENTRADA = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("DATA_ENTRADA");
                OnDATA_ENTRADAChanged();
            }
        }
        private Nullable<global::System.DateTime> _DATA_ENTRADA;
        partial void OnDATA_ENTRADAChanging(Nullable<global::System.DateTime> value);
        partial void OnDATA_ENTRADAChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTime> DATA_SAIDA
        {
            get
            {
                return _DATA_SAIDA;
            }
            set
            {
                OnDATA_SAIDAChanging(value);
                ReportPropertyChanging("DATA_SAIDA");
                _DATA_SAIDA = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("DATA_SAIDA");
                OnDATA_SAIDAChanged();
            }
        }
        private Nullable<global::System.DateTime> _DATA_SAIDA;
        partial void OnDATA_SAIDAChanging(Nullable<global::System.DateTime> value);
        partial void OnDATA_SAIDAChanged();

        #endregion
    
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="VS2010Model", Name="PONTO2")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class PONTO2 : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new PONTO2 object.
        /// </summary>
        /// <param name="cOD_PONTO">Initial value of the COD_PONTO property.</param>
        public static PONTO2 CreatePONTO2(global::System.Int32 cOD_PONTO)
        {
            PONTO2 pONTO2 = new PONTO2();
            pONTO2.COD_PONTO = cOD_PONTO;
            return pONTO2;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 COD_PONTO
        {
            get
            {
                return _COD_PONTO;
            }
            set
            {
                if (_COD_PONTO != value)
                {
                    OnCOD_PONTOChanging(value);
                    ReportPropertyChanging("COD_PONTO");
                    _COD_PONTO = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("COD_PONTO");
                    OnCOD_PONTOChanged();
                }
            }
        }
        private global::System.Int32 _COD_PONTO;
        partial void OnCOD_PONTOChanging(global::System.Int32 value);
        partial void OnCOD_PONTOChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> COD_FUNCIONARIO
        {
            get
            {
                return _COD_FUNCIONARIO;
            }
            set
            {
                OnCOD_FUNCIONARIOChanging(value);
                ReportPropertyChanging("COD_FUNCIONARIO");
                _COD_FUNCIONARIO = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("COD_FUNCIONARIO");
                OnCOD_FUNCIONARIOChanged();
            }
        }
        private Nullable<global::System.Int32> _COD_FUNCIONARIO;
        partial void OnCOD_FUNCIONARIOChanging(Nullable<global::System.Int32> value);
        partial void OnCOD_FUNCIONARIOChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> COD_TIPO
        {
            get
            {
                return _COD_TIPO;
            }
            set
            {
                OnCOD_TIPOChanging(value);
                ReportPropertyChanging("COD_TIPO");
                _COD_TIPO = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("COD_TIPO");
                OnCOD_TIPOChanged();
            }
        }
        private Nullable<global::System.Int32> _COD_TIPO;
        partial void OnCOD_TIPOChanging(Nullable<global::System.Int32> value);
        partial void OnCOD_TIPOChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTime> DATA
        {
            get
            {
                return _DATA;
            }
            set
            {
                OnDATAChanging(value);
                ReportPropertyChanging("DATA");
                _DATA = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("DATA");
                OnDATAChanged();
            }
        }
        private Nullable<global::System.DateTime> _DATA;
        partial void OnDATAChanging(Nullable<global::System.DateTime> value);
        partial void OnDATAChanged();

        #endregion
    
    }

    #endregion
    
}
