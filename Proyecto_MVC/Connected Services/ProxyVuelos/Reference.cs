﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Proyecto_MVC.ProxyVuelos {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="VueloBE", Namespace="http://schemas.datacontract.org/2004/07/WCF_Reservas")]
    [System.SerializableAttribute()]
    public partial class VueloBE : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime Fecha_LlegadaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime Fecha_SalidaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FotoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdAerolineaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdDepartField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdPaisField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombreAeropuertoDestinoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombreAeropuertoOrigenField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Nombre_AerolineaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Nombre_DepartamentoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Nombre_PaisDestinoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Nombre_PaisOrigenField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Nombre_departamentoDestinoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double PrecioField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Tipo_VueloField;
        
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
        public System.DateTime Fecha_Llegada {
            get {
                return this.Fecha_LlegadaField;
            }
            set {
                if ((this.Fecha_LlegadaField.Equals(value) != true)) {
                    this.Fecha_LlegadaField = value;
                    this.RaisePropertyChanged("Fecha_Llegada");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Fecha_Salida {
            get {
                return this.Fecha_SalidaField;
            }
            set {
                if ((this.Fecha_SalidaField.Equals(value) != true)) {
                    this.Fecha_SalidaField = value;
                    this.RaisePropertyChanged("Fecha_Salida");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Foto {
            get {
                return this.FotoField;
            }
            set {
                if ((object.ReferenceEquals(this.FotoField, value) != true)) {
                    this.FotoField = value;
                    this.RaisePropertyChanged("Foto");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IdAerolinea {
            get {
                return this.IdAerolineaField;
            }
            set {
                if ((this.IdAerolineaField.Equals(value) != true)) {
                    this.IdAerolineaField = value;
                    this.RaisePropertyChanged("IdAerolinea");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IdDepart {
            get {
                return this.IdDepartField;
            }
            set {
                if ((this.IdDepartField.Equals(value) != true)) {
                    this.IdDepartField = value;
                    this.RaisePropertyChanged("IdDepart");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IdPais {
            get {
                return this.IdPaisField;
            }
            set {
                if ((this.IdPaisField.Equals(value) != true)) {
                    this.IdPaisField = value;
                    this.RaisePropertyChanged("IdPais");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NombreAeropuertoDestino {
            get {
                return this.NombreAeropuertoDestinoField;
            }
            set {
                if ((object.ReferenceEquals(this.NombreAeropuertoDestinoField, value) != true)) {
                    this.NombreAeropuertoDestinoField = value;
                    this.RaisePropertyChanged("NombreAeropuertoDestino");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NombreAeropuertoOrigen {
            get {
                return this.NombreAeropuertoOrigenField;
            }
            set {
                if ((object.ReferenceEquals(this.NombreAeropuertoOrigenField, value) != true)) {
                    this.NombreAeropuertoOrigenField = value;
                    this.RaisePropertyChanged("NombreAeropuertoOrigen");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nombre_Aerolinea {
            get {
                return this.Nombre_AerolineaField;
            }
            set {
                if ((object.ReferenceEquals(this.Nombre_AerolineaField, value) != true)) {
                    this.Nombre_AerolineaField = value;
                    this.RaisePropertyChanged("Nombre_Aerolinea");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nombre_Departamento {
            get {
                return this.Nombre_DepartamentoField;
            }
            set {
                if ((object.ReferenceEquals(this.Nombre_DepartamentoField, value) != true)) {
                    this.Nombre_DepartamentoField = value;
                    this.RaisePropertyChanged("Nombre_Departamento");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nombre_PaisDestino {
            get {
                return this.Nombre_PaisDestinoField;
            }
            set {
                if ((object.ReferenceEquals(this.Nombre_PaisDestinoField, value) != true)) {
                    this.Nombre_PaisDestinoField = value;
                    this.RaisePropertyChanged("Nombre_PaisDestino");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nombre_PaisOrigen {
            get {
                return this.Nombre_PaisOrigenField;
            }
            set {
                if ((object.ReferenceEquals(this.Nombre_PaisOrigenField, value) != true)) {
                    this.Nombre_PaisOrigenField = value;
                    this.RaisePropertyChanged("Nombre_PaisOrigen");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nombre_departamentoDestino {
            get {
                return this.Nombre_departamentoDestinoField;
            }
            set {
                if ((object.ReferenceEquals(this.Nombre_departamentoDestinoField, value) != true)) {
                    this.Nombre_departamentoDestinoField = value;
                    this.RaisePropertyChanged("Nombre_departamentoDestino");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double Precio {
            get {
                return this.PrecioField;
            }
            set {
                if ((this.PrecioField.Equals(value) != true)) {
                    this.PrecioField = value;
                    this.RaisePropertyChanged("Precio");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Tipo_Vuelo {
            get {
                return this.Tipo_VueloField;
            }
            set {
                if ((object.ReferenceEquals(this.Tipo_VueloField, value) != true)) {
                    this.Tipo_VueloField = value;
                    this.RaisePropertyChanged("Tipo_Vuelo");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ProxyVuelos.IServicioVuelo")]
    public interface IServicioVuelo {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioVuelo/GetAllVuelos", ReplyAction="http://tempuri.org/IServicioVuelo/GetAllVuelosResponse")]
        Proyecto_MVC.ProxyVuelos.VueloBE[] GetAllVuelos();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioVuelo/GetAllVuelos", ReplyAction="http://tempuri.org/IServicioVuelo/GetAllVuelosResponse")]
        System.Threading.Tasks.Task<Proyecto_MVC.ProxyVuelos.VueloBE[]> GetAllVuelosAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioVuelo/ListarPorAerolinea", ReplyAction="http://tempuri.org/IServicioVuelo/ListarPorAerolineaResponse")]
        Proyecto_MVC.ProxyVuelos.VueloBE[] ListarPorAerolinea(string aerolinea);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioVuelo/ListarPorAerolinea", ReplyAction="http://tempuri.org/IServicioVuelo/ListarPorAerolineaResponse")]
        System.Threading.Tasks.Task<Proyecto_MVC.ProxyVuelos.VueloBE[]> ListarPorAerolineaAsync(string aerolinea);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioVuelo/ListarPorCiudadOrigen", ReplyAction="http://tempuri.org/IServicioVuelo/ListarPorCiudadOrigenResponse")]
        Proyecto_MVC.ProxyVuelos.VueloBE[] ListarPorCiudadOrigen(string ciudad);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioVuelo/ListarPorCiudadOrigen", ReplyAction="http://tempuri.org/IServicioVuelo/ListarPorCiudadOrigenResponse")]
        System.Threading.Tasks.Task<Proyecto_MVC.ProxyVuelos.VueloBE[]> ListarPorCiudadOrigenAsync(string ciudad);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioVuelo/ListarPorCiudadDestino", ReplyAction="http://tempuri.org/IServicioVuelo/ListarPorCiudadDestinoResponse")]
        Proyecto_MVC.ProxyVuelos.VueloBE[] ListarPorCiudadDestino(string ciudad);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioVuelo/ListarPorCiudadDestino", ReplyAction="http://tempuri.org/IServicioVuelo/ListarPorCiudadDestinoResponse")]
        System.Threading.Tasks.Task<Proyecto_MVC.ProxyVuelos.VueloBE[]> ListarPorCiudadDestinoAsync(string ciudad);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioVuelo/ListarPorFechaSalida", ReplyAction="http://tempuri.org/IServicioVuelo/ListarPorFechaSalidaResponse")]
        Proyecto_MVC.ProxyVuelos.VueloBE[] ListarPorFechaSalida(System.DateTime fecha1, System.DateTime fecha2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioVuelo/ListarPorFechaSalida", ReplyAction="http://tempuri.org/IServicioVuelo/ListarPorFechaSalidaResponse")]
        System.Threading.Tasks.Task<Proyecto_MVC.ProxyVuelos.VueloBE[]> ListarPorFechaSalidaAsync(System.DateTime fecha1, System.DateTime fecha2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioVuelo/ListarPorFechaLlegada", ReplyAction="http://tempuri.org/IServicioVuelo/ListarPorFechaLlegadaResponse")]
        Proyecto_MVC.ProxyVuelos.VueloBE[] ListarPorFechaLlegada(System.DateTime fecha1, System.DateTime fecha2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioVuelo/ListarPorFechaLlegada", ReplyAction="http://tempuri.org/IServicioVuelo/ListarPorFechaLlegadaResponse")]
        System.Threading.Tasks.Task<Proyecto_MVC.ProxyVuelos.VueloBE[]> ListarPorFechaLlegadaAsync(System.DateTime fecha1, System.DateTime fecha2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioVuelo/ListarDepartamentos", ReplyAction="http://tempuri.org/IServicioVuelo/ListarDepartamentosResponse")]
        Proyecto_MVC.ProxyVuelos.VueloBE[] ListarDepartamentos();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioVuelo/ListarDepartamentos", ReplyAction="http://tempuri.org/IServicioVuelo/ListarDepartamentosResponse")]
        System.Threading.Tasks.Task<Proyecto_MVC.ProxyVuelos.VueloBE[]> ListarDepartamentosAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioVuelo/ListarAerolineas", ReplyAction="http://tempuri.org/IServicioVuelo/ListarAerolineasResponse")]
        Proyecto_MVC.ProxyVuelos.VueloBE[] ListarAerolineas();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioVuelo/ListarAerolineas", ReplyAction="http://tempuri.org/IServicioVuelo/ListarAerolineasResponse")]
        System.Threading.Tasks.Task<Proyecto_MVC.ProxyVuelos.VueloBE[]> ListarAerolineasAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServicioVueloChannel : Proyecto_MVC.ProxyVuelos.IServicioVuelo, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServicioVueloClient : System.ServiceModel.ClientBase<Proyecto_MVC.ProxyVuelos.IServicioVuelo>, Proyecto_MVC.ProxyVuelos.IServicioVuelo {
        
        public ServicioVueloClient() {
        }
        
        public ServicioVueloClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServicioVueloClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioVueloClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioVueloClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Proyecto_MVC.ProxyVuelos.VueloBE[] GetAllVuelos() {
            return base.Channel.GetAllVuelos();
        }
        
        public System.Threading.Tasks.Task<Proyecto_MVC.ProxyVuelos.VueloBE[]> GetAllVuelosAsync() {
            return base.Channel.GetAllVuelosAsync();
        }
        
        public Proyecto_MVC.ProxyVuelos.VueloBE[] ListarPorAerolinea(string aerolinea) {
            return base.Channel.ListarPorAerolinea(aerolinea);
        }
        
        public System.Threading.Tasks.Task<Proyecto_MVC.ProxyVuelos.VueloBE[]> ListarPorAerolineaAsync(string aerolinea) {
            return base.Channel.ListarPorAerolineaAsync(aerolinea);
        }
        
        public Proyecto_MVC.ProxyVuelos.VueloBE[] ListarPorCiudadOrigen(string ciudad) {
            return base.Channel.ListarPorCiudadOrigen(ciudad);
        }
        
        public System.Threading.Tasks.Task<Proyecto_MVC.ProxyVuelos.VueloBE[]> ListarPorCiudadOrigenAsync(string ciudad) {
            return base.Channel.ListarPorCiudadOrigenAsync(ciudad);
        }
        
        public Proyecto_MVC.ProxyVuelos.VueloBE[] ListarPorCiudadDestino(string ciudad) {
            return base.Channel.ListarPorCiudadDestino(ciudad);
        }
        
        public System.Threading.Tasks.Task<Proyecto_MVC.ProxyVuelos.VueloBE[]> ListarPorCiudadDestinoAsync(string ciudad) {
            return base.Channel.ListarPorCiudadDestinoAsync(ciudad);
        }
        
        public Proyecto_MVC.ProxyVuelos.VueloBE[] ListarPorFechaSalida(System.DateTime fecha1, System.DateTime fecha2) {
            return base.Channel.ListarPorFechaSalida(fecha1, fecha2);
        }
        
        public System.Threading.Tasks.Task<Proyecto_MVC.ProxyVuelos.VueloBE[]> ListarPorFechaSalidaAsync(System.DateTime fecha1, System.DateTime fecha2) {
            return base.Channel.ListarPorFechaSalidaAsync(fecha1, fecha2);
        }
        
        public Proyecto_MVC.ProxyVuelos.VueloBE[] ListarPorFechaLlegada(System.DateTime fecha1, System.DateTime fecha2) {
            return base.Channel.ListarPorFechaLlegada(fecha1, fecha2);
        }
        
        public System.Threading.Tasks.Task<Proyecto_MVC.ProxyVuelos.VueloBE[]> ListarPorFechaLlegadaAsync(System.DateTime fecha1, System.DateTime fecha2) {
            return base.Channel.ListarPorFechaLlegadaAsync(fecha1, fecha2);
        }
        
        public Proyecto_MVC.ProxyVuelos.VueloBE[] ListarDepartamentos() {
            return base.Channel.ListarDepartamentos();
        }
        
        public System.Threading.Tasks.Task<Proyecto_MVC.ProxyVuelos.VueloBE[]> ListarDepartamentosAsync() {
            return base.Channel.ListarDepartamentosAsync();
        }
        
        public Proyecto_MVC.ProxyVuelos.VueloBE[] ListarAerolineas() {
            return base.Channel.ListarAerolineas();
        }
        
        public System.Threading.Tasks.Task<Proyecto_MVC.ProxyVuelos.VueloBE[]> ListarAerolineasAsync() {
            return base.Channel.ListarAerolineasAsync();
        }
    }
}
