﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WorkSpace_PreAltaClientes.Web.ClienteServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CatalogoReqBase", Namespace="http://schemas.datacontract.org/2004/07/WorkSpace_PreAltaClientes.DataModel")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(WorkSpace_PreAltaClientes.Web.ClienteServiceReference.ClienteDTOReq))]
    public partial class CatalogoReqBase : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ControlField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int OperacionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WorkSpace_PreAltaClientes.Web.ClienteServiceReference.Paginacion PaginacionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SeguridadField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WorkSpace_PreAltaClientes.Web.ClienteServiceReference.Accion TipoOperacionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UsuarioField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Control {
            get {
                return this.ControlField;
            }
            set {
                if ((object.ReferenceEquals(this.ControlField, value) != true)) {
                    this.ControlField = value;
                    this.RaisePropertyChanged("Control");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Operacion {
            get {
                return this.OperacionField;
            }
            set {
                if ((this.OperacionField.Equals(value) != true)) {
                    this.OperacionField = value;
                    this.RaisePropertyChanged("Operacion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WorkSpace_PreAltaClientes.Web.ClienteServiceReference.Paginacion Paginacion {
            get {
                return this.PaginacionField;
            }
            set {
                if ((object.ReferenceEquals(this.PaginacionField, value) != true)) {
                    this.PaginacionField = value;
                    this.RaisePropertyChanged("Paginacion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Seguridad {
            get {
                return this.SeguridadField;
            }
            set {
                if ((object.ReferenceEquals(this.SeguridadField, value) != true)) {
                    this.SeguridadField = value;
                    this.RaisePropertyChanged("Seguridad");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WorkSpace_PreAltaClientes.Web.ClienteServiceReference.Accion TipoOperacion {
            get {
                return this.TipoOperacionField;
            }
            set {
                if ((this.TipoOperacionField.Equals(value) != true)) {
                    this.TipoOperacionField = value;
                    this.RaisePropertyChanged("TipoOperacion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Usuario {
            get {
                return this.UsuarioField;
            }
            set {
                if ((object.ReferenceEquals(this.UsuarioField, value) != true)) {
                    this.UsuarioField = value;
                    this.RaisePropertyChanged("Usuario");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Paginacion", Namespace="http://schemas.datacontract.org/2004/07/WorkSpace_PreAltaClientes.DataModel")]
    [System.SerializableAttribute()]
    public partial class Paginacion : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CantidadRegistrosField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int PaginaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int RegistrosPorPaginaField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CantidadRegistros {
            get {
                return this.CantidadRegistrosField;
            }
            set {
                if ((this.CantidadRegistrosField.Equals(value) != true)) {
                    this.CantidadRegistrosField = value;
                    this.RaisePropertyChanged("CantidadRegistros");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Pagina {
            get {
                return this.PaginaField;
            }
            set {
                if ((this.PaginaField.Equals(value) != true)) {
                    this.PaginaField = value;
                    this.RaisePropertyChanged("Pagina");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int RegistrosPorPagina {
            get {
                return this.RegistrosPorPaginaField;
            }
            set {
                if ((this.RegistrosPorPaginaField.Equals(value) != true)) {
                    this.RegistrosPorPaginaField = value;
                    this.RaisePropertyChanged("RegistrosPorPagina");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ClienteDTOReq", Namespace="http://schemas.datacontract.org/2004/07/WorkSpace_PreAltaClientes.DataModel")]
    [System.SerializableAttribute()]
    public partial class ClienteDTOReq : WorkSpace_PreAltaClientes.Web.ClienteServiceReference.CatalogoReqBase {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WorkSpace_PreAltaClientes.Web.ClienteServiceReference.ListaClientes clientesField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WorkSpace_PreAltaClientes.Web.ClienteServiceReference.ListaClientes clientes {
            get {
                return this.clientesField;
            }
            set {
                if ((object.ReferenceEquals(this.clientesField, value) != true)) {
                    this.clientesField = value;
                    this.RaisePropertyChanged("clientes");
                }
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Accion", Namespace="http://schemas.datacontract.org/2004/07/WorkSpace_PreAltaClientes.DataModel")]
    public enum Accion : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Crear = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Actualizar = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Cancelar = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Eliminar = 3,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Activar = 4,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Desactivar = 5,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Consultar = 6,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Autorizar = 7,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        CrearMasivo = 8,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Anular = 9,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Generar = 10,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Confirmar = 11,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Transferir = 12,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="ListaClientes", Namespace="http://schemas.datacontract.org/2004/07/WorkSpace_PreAltaClientes.DataModel", ItemName="ClienteDTO")]
    [System.SerializableAttribute()]
    public class ListaClientes : System.Collections.Generic.List<WorkSpace_PreAltaClientes.Web.ClienteServiceReference.ClienteDTO> {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ClienteDTO", Namespace="http://schemas.datacontract.org/2004/07/WorkSpace_PreAltaClientes.DataModel")]
    [System.SerializableAttribute()]
    public partial class ClienteDTO : WorkSpace_PreAltaClientes.Web.ClienteServiceReference.CatalogoBase {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CuitField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DateCreatedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WorkSpace_PreAltaClientes.Web.ClienteServiceReference.ProductDTO[] MyProductsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombreClteField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Razon_socialField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Cuit {
            get {
                return this.CuitField;
            }
            set {
                if ((object.ReferenceEquals(this.CuitField, value) != true)) {
                    this.CuitField = value;
                    this.RaisePropertyChanged("Cuit");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime DateCreated {
            get {
                return this.DateCreatedField;
            }
            set {
                if ((this.DateCreatedField.Equals(value) != true)) {
                    this.DateCreatedField = value;
                    this.RaisePropertyChanged("DateCreated");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WorkSpace_PreAltaClientes.Web.ClienteServiceReference.ProductDTO[] MyProducts {
            get {
                return this.MyProductsField;
            }
            set {
                if ((object.ReferenceEquals(this.MyProductsField, value) != true)) {
                    this.MyProductsField = value;
                    this.RaisePropertyChanged("MyProducts");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NombreClte {
            get {
                return this.NombreClteField;
            }
            set {
                if ((object.ReferenceEquals(this.NombreClteField, value) != true)) {
                    this.NombreClteField = value;
                    this.RaisePropertyChanged("NombreClte");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Razon_social {
            get {
                return this.Razon_socialField;
            }
            set {
                if ((object.ReferenceEquals(this.Razon_socialField, value) != true)) {
                    this.Razon_socialField = value;
                    this.RaisePropertyChanged("Razon_social");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CatalogoBase", Namespace="http://schemas.datacontract.org/2004/07/WorkSpace_PreAltaClientes.DataModel")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(WorkSpace_PreAltaClientes.Web.ClienteServiceReference.ProductDTO))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(WorkSpace_PreAltaClientes.Web.ClienteServiceReference.ClienteDTO))]
    public partial class CatalogoBase : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescripcionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int EstadoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Id_UsuarioField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string KeyField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombreField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Descripcion {
            get {
                return this.DescripcionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescripcionField, value) != true)) {
                    this.DescripcionField = value;
                    this.RaisePropertyChanged("Descripcion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Estado {
            get {
                return this.EstadoField;
            }
            set {
                if ((this.EstadoField.Equals(value) != true)) {
                    this.EstadoField = value;
                    this.RaisePropertyChanged("Estado");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ID {
            get {
                return this.IDField;
            }
            set {
                if ((this.IDField.Equals(value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id_Usuario {
            get {
                return this.Id_UsuarioField;
            }
            set {
                if ((this.Id_UsuarioField.Equals(value) != true)) {
                    this.Id_UsuarioField = value;
                    this.RaisePropertyChanged("Id_Usuario");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Key {
            get {
                return this.KeyField;
            }
            set {
                if ((object.ReferenceEquals(this.KeyField, value) != true)) {
                    this.KeyField = value;
                    this.RaisePropertyChanged("Key");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nombre {
            get {
                return this.NombreField;
            }
            set {
                if ((object.ReferenceEquals(this.NombreField, value) != true)) {
                    this.NombreField = value;
                    this.RaisePropertyChanged("Nombre");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ProductDTO", Namespace="http://schemas.datacontract.org/2004/07/WorkSpace_PreAltaClientes.DataModel")]
    [System.SerializableAttribute()]
    public partial class ProductDTO : WorkSpace_PreAltaClientes.Web.ClienteServiceReference.CatalogoBase {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ClienteIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Id1Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ProductCategoryIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ProductNameField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ClienteId {
            get {
                return this.ClienteIdField;
            }
            set {
                if ((this.ClienteIdField.Equals(value) != true)) {
                    this.ClienteIdField = value;
                    this.RaisePropertyChanged("ClienteId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="Id")]
        public int Id1 {
            get {
                return this.Id1Field;
            }
            set {
                if ((this.Id1Field.Equals(value) != true)) {
                    this.Id1Field = value;
                    this.RaisePropertyChanged("Id1");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ProductCategoryId {
            get {
                return this.ProductCategoryIdField;
            }
            set {
                if ((this.ProductCategoryIdField.Equals(value) != true)) {
                    this.ProductCategoryIdField = value;
                    this.RaisePropertyChanged("ProductCategoryId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ProductName {
            get {
                return this.ProductNameField;
            }
            set {
                if ((object.ReferenceEquals(this.ProductNameField, value) != true)) {
                    this.ProductNameField = value;
                    this.RaisePropertyChanged("ProductName");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CatalogoRespBase", Namespace="http://schemas.datacontract.org/2004/07/WorkSpace_PreAltaClientes.DataModel")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(WorkSpace_PreAltaClientes.Web.ClienteServiceReference.ClienteDTOResp))]
    public partial class CatalogoRespBase : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WorkSpace_PreAltaClientes.Web.ClienteServiceReference.ListaErrores ErroresField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool EsExitosaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int TotalRegistrosField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UsuarioField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WorkSpace_PreAltaClientes.Web.ClienteServiceReference.ListaErrores Errores {
            get {
                return this.ErroresField;
            }
            set {
                if ((object.ReferenceEquals(this.ErroresField, value) != true)) {
                    this.ErroresField = value;
                    this.RaisePropertyChanged("Errores");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool EsExitosa {
            get {
                return this.EsExitosaField;
            }
            set {
                if ((this.EsExitosaField.Equals(value) != true)) {
                    this.EsExitosaField = value;
                    this.RaisePropertyChanged("EsExitosa");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int TotalRegistros {
            get {
                return this.TotalRegistrosField;
            }
            set {
                if ((this.TotalRegistrosField.Equals(value) != true)) {
                    this.TotalRegistrosField = value;
                    this.RaisePropertyChanged("TotalRegistros");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Usuario {
            get {
                return this.UsuarioField;
            }
            set {
                if ((object.ReferenceEquals(this.UsuarioField, value) != true)) {
                    this.UsuarioField = value;
                    this.RaisePropertyChanged("Usuario");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ClienteDTOResp", Namespace="http://schemas.datacontract.org/2004/07/WorkSpace_PreAltaClientes.DataModel")]
    [System.SerializableAttribute()]
    public partial class ClienteDTOResp : WorkSpace_PreAltaClientes.Web.ClienteServiceReference.CatalogoRespBase {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WorkSpace_PreAltaClientes.Web.ClienteServiceReference.ListaClientes clientesField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WorkSpace_PreAltaClientes.Web.ClienteServiceReference.ListaClientes clientes {
            get {
                return this.clientesField;
            }
            set {
                if ((object.ReferenceEquals(this.clientesField, value) != true)) {
                    this.clientesField = value;
                    this.RaisePropertyChanged("clientes");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="ListaErrores", Namespace="http://schemas.datacontract.org/2004/07/WorkSpace_PreAltaClientes.DataModel", ItemName="Error")]
    [System.SerializableAttribute()]
    public class ListaErrores : System.Collections.Generic.List<WorkSpace_PreAltaClientes.Web.ClienteServiceReference.Error> {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Error", Namespace="http://schemas.datacontract.org/2004/07/WorkSpace_PreAltaClientes.DataModel")]
    [System.SerializableAttribute()]
    public partial class Error : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CodigoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Exception ExcepcionInternaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int FilaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MensajeField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Codigo {
            get {
                return this.CodigoField;
            }
            set {
                if ((this.CodigoField.Equals(value) != true)) {
                    this.CodigoField = value;
                    this.RaisePropertyChanged("Codigo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Exception ExcepcionInterna {
            get {
                return this.ExcepcionInternaField;
            }
            set {
                if ((object.ReferenceEquals(this.ExcepcionInternaField, value) != true)) {
                    this.ExcepcionInternaField = value;
                    this.RaisePropertyChanged("ExcepcionInterna");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Fila {
            get {
                return this.FilaField;
            }
            set {
                if ((this.FilaField.Equals(value) != true)) {
                    this.FilaField = value;
                    this.RaisePropertyChanged("Fila");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Mensaje {
            get {
                return this.MensajeField;
            }
            set {
                if ((object.ReferenceEquals(this.MensajeField, value) != true)) {
                    this.MensajeField = value;
                    this.RaisePropertyChanged("Mensaje");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ClienteServiceReference.IClienteService")]
    public interface IClienteService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClienteService/Consultar", ReplyAction="http://tempuri.org/IClienteService/ConsultarResponse")]
        WorkSpace_PreAltaClientes.Web.ClienteServiceReference.ClienteDTOResp Consultar(WorkSpace_PreAltaClientes.Web.ClienteServiceReference.ClienteDTOReq req);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClienteService/Consultar", ReplyAction="http://tempuri.org/IClienteService/ConsultarResponse")]
        System.Threading.Tasks.Task<WorkSpace_PreAltaClientes.Web.ClienteServiceReference.ClienteDTOResp> ConsultarAsync(WorkSpace_PreAltaClientes.Web.ClienteServiceReference.ClienteDTOReq req);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClienteService/Grabar", ReplyAction="http://tempuri.org/IClienteService/GrabarResponse")]
        void Grabar();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClienteService/Grabar", ReplyAction="http://tempuri.org/IClienteService/GrabarResponse")]
        System.Threading.Tasks.Task GrabarAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IClienteServiceChannel : WorkSpace_PreAltaClientes.Web.ClienteServiceReference.IClienteService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ClienteServiceClient : System.ServiceModel.ClientBase<WorkSpace_PreAltaClientes.Web.ClienteServiceReference.IClienteService>, WorkSpace_PreAltaClientes.Web.ClienteServiceReference.IClienteService {
        
        public ClienteServiceClient() {
        }
        
        public ClienteServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ClienteServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ClienteServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ClienteServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public WorkSpace_PreAltaClientes.Web.ClienteServiceReference.ClienteDTOResp Consultar(WorkSpace_PreAltaClientes.Web.ClienteServiceReference.ClienteDTOReq req) {
            return base.Channel.Consultar(req);
        }
        
        public System.Threading.Tasks.Task<WorkSpace_PreAltaClientes.Web.ClienteServiceReference.ClienteDTOResp> ConsultarAsync(WorkSpace_PreAltaClientes.Web.ClienteServiceReference.ClienteDTOReq req) {
            return base.Channel.ConsultarAsync(req);
        }
        
        public void Grabar() {
            base.Channel.Grabar();
        }
        
        public System.Threading.Tasks.Task GrabarAsync() {
            return base.Channel.GrabarAsync();
        }
    }
}