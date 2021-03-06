﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// Microsoft.VSDesigner generó automáticamente este código fuente, versión=4.0.30319.42000.
// 
#pragma warning disable 1591

namespace CapaNegocio.wsAmericaVirtual {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3761.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="wsAmeVSoap", Namespace="http://tempuri.org/")]
    public partial class wsAmeV : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback ObtenerPaisesOperationCompleted;
        
        private System.Threading.SendOrPostCallback ExisteUSuarioOperationCompleted;
        
        private System.Threading.SendOrPostCallback ObtenerCiudadOperationCompleted;
        
        private System.Threading.SendOrPostCallback ObtenerTemperaturaOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public wsAmeV() {
            this.Url = global::CapaNegocio.Properties.Settings.Default.CapaDatos_wsAmericaVirtual_wsAmeV;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event ObtenerPaisesCompletedEventHandler ObtenerPaisesCompleted;
        
        /// <remarks/>
        public event ExisteUSuarioCompletedEventHandler ExisteUSuarioCompleted;
        
        /// <remarks/>
        public event ObtenerCiudadCompletedEventHandler ObtenerCiudadCompleted;
        
        /// <remarks/>
        public event ObtenerTemperaturaCompletedEventHandler ObtenerTemperaturaCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/ObtenerPaises", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Paises[] ObtenerPaises(string codigo) {
            object[] results = this.Invoke("ObtenerPaises", new object[] {
                        codigo});
            return ((Paises[])(results[0]));
        }
        
        /// <remarks/>
        public void ObtenerPaisesAsync(string codigo) {
            this.ObtenerPaisesAsync(codigo, null);
        }
        
        /// <remarks/>
        public void ObtenerPaisesAsync(string codigo, object userState) {
            if ((this.ObtenerPaisesOperationCompleted == null)) {
                this.ObtenerPaisesOperationCompleted = new System.Threading.SendOrPostCallback(this.OnObtenerPaisesOperationCompleted);
            }
            this.InvokeAsync("ObtenerPaises", new object[] {
                        codigo}, this.ObtenerPaisesOperationCompleted, userState);
        }
        
        private void OnObtenerPaisesOperationCompleted(object arg) {
            if ((this.ObtenerPaisesCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ObtenerPaisesCompleted(this, new ObtenerPaisesCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/ExisteUSuario", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string ExisteUSuario(string mail, string pass) {
            object[] results = this.Invoke("ExisteUSuario", new object[] {
                        mail,
                        pass});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void ExisteUSuarioAsync(string mail, string pass) {
            this.ExisteUSuarioAsync(mail, pass, null);
        }
        
        /// <remarks/>
        public void ExisteUSuarioAsync(string mail, string pass, object userState) {
            if ((this.ExisteUSuarioOperationCompleted == null)) {
                this.ExisteUSuarioOperationCompleted = new System.Threading.SendOrPostCallback(this.OnExisteUSuarioOperationCompleted);
            }
            this.InvokeAsync("ExisteUSuario", new object[] {
                        mail,
                        pass}, this.ExisteUSuarioOperationCompleted, userState);
        }
        
        private void OnExisteUSuarioOperationCompleted(object arg) {
            if ((this.ExisteUSuarioCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ExisteUSuarioCompleted(this, new ExisteUSuarioCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/ObtenerCiudad", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Ciudad[] ObtenerCiudad(string codigo, string codPais) {
            object[] results = this.Invoke("ObtenerCiudad", new object[] {
                        codigo,
                        codPais});
            return ((Ciudad[])(results[0]));
        }
        
        /// <remarks/>
        public void ObtenerCiudadAsync(string codigo, string codPais) {
            this.ObtenerCiudadAsync(codigo, codPais, null);
        }
        
        /// <remarks/>
        public void ObtenerCiudadAsync(string codigo, string codPais, object userState) {
            if ((this.ObtenerCiudadOperationCompleted == null)) {
                this.ObtenerCiudadOperationCompleted = new System.Threading.SendOrPostCallback(this.OnObtenerCiudadOperationCompleted);
            }
            this.InvokeAsync("ObtenerCiudad", new object[] {
                        codigo,
                        codPais}, this.ObtenerCiudadOperationCompleted, userState);
        }
        
        private void OnObtenerCiudadOperationCompleted(object arg) {
            if ((this.ObtenerCiudadCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ObtenerCiudadCompleted(this, new ObtenerCiudadCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/ObtenerTemperatura", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Temperatura[] ObtenerTemperatura(string codCiudad, string codPais) {
            object[] results = this.Invoke("ObtenerTemperatura", new object[] {
                        codCiudad,
                        codPais});
            return ((Temperatura[])(results[0]));
        }
        
        /// <remarks/>
        public void ObtenerTemperaturaAsync(string codCiudad, string codPais) {
            this.ObtenerTemperaturaAsync(codCiudad, codPais, null);
        }
        
        /// <remarks/>
        public void ObtenerTemperaturaAsync(string codCiudad, string codPais, object userState) {
            if ((this.ObtenerTemperaturaOperationCompleted == null)) {
                this.ObtenerTemperaturaOperationCompleted = new System.Threading.SendOrPostCallback(this.OnObtenerTemperaturaOperationCompleted);
            }
            this.InvokeAsync("ObtenerTemperatura", new object[] {
                        codCiudad,
                        codPais}, this.ObtenerTemperaturaOperationCompleted, userState);
        }
        
        private void OnObtenerTemperaturaOperationCompleted(object arg) {
            if ((this.ObtenerTemperaturaCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ObtenerTemperaturaCompleted(this, new ObtenerTemperaturaCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3761.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class Paises {
        
        private string codigoField;
        
        private string descripField;
        
        /// <remarks/>
        public string Codigo {
            get {
                return this.codigoField;
            }
            set {
                this.codigoField = value;
            }
        }
        
        /// <remarks/>
        public string Descrip {
            get {
                return this.descripField;
            }
            set {
                this.descripField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3761.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class Temperatura {
        
        private string codigoCiudadField;
        
        private string descripField;
        
        private string errorField;
        
        private string codigoPaisField;
        
        private string diaField;
        
        private string gcField;
        
        private string gfField;
        
        /// <remarks/>
        public string CodigoCiudad {
            get {
                return this.codigoCiudadField;
            }
            set {
                this.codigoCiudadField = value;
            }
        }
        
        /// <remarks/>
        public string Descrip {
            get {
                return this.descripField;
            }
            set {
                this.descripField = value;
            }
        }
        
        /// <remarks/>
        public string Error {
            get {
                return this.errorField;
            }
            set {
                this.errorField = value;
            }
        }
        
        /// <remarks/>
        public string CodigoPais {
            get {
                return this.codigoPaisField;
            }
            set {
                this.codigoPaisField = value;
            }
        }
        
        /// <remarks/>
        public string Dia {
            get {
                return this.diaField;
            }
            set {
                this.diaField = value;
            }
        }
        
        /// <remarks/>
        public string GC {
            get {
                return this.gcField;
            }
            set {
                this.gcField = value;
            }
        }
        
        /// <remarks/>
        public string GF {
            get {
                return this.gfField;
            }
            set {
                this.gfField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3761.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class Ciudad {
        
        private string codigoField;
        
        private string descripField;
        
        /// <remarks/>
        public string Codigo {
            get {
                return this.codigoField;
            }
            set {
                this.codigoField = value;
            }
        }
        
        /// <remarks/>
        public string Descrip {
            get {
                return this.descripField;
            }
            set {
                this.descripField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3761.0")]
    public delegate void ObtenerPaisesCompletedEventHandler(object sender, ObtenerPaisesCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3761.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ObtenerPaisesCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ObtenerPaisesCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Paises[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Paises[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3761.0")]
    public delegate void ExisteUSuarioCompletedEventHandler(object sender, ExisteUSuarioCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3761.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ExisteUSuarioCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ExisteUSuarioCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3761.0")]
    public delegate void ObtenerCiudadCompletedEventHandler(object sender, ObtenerCiudadCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3761.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ObtenerCiudadCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ObtenerCiudadCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Ciudad[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Ciudad[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3761.0")]
    public delegate void ObtenerTemperaturaCompletedEventHandler(object sender, ObtenerTemperaturaCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3761.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ObtenerTemperaturaCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ObtenerTemperaturaCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Temperatura[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Temperatura[])(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591