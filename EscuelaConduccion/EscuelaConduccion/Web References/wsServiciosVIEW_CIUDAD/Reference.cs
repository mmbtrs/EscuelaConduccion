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

namespace EscuelaConduccion.wsServiciosVIEW_CIUDAD {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="ServiciosVIEW_CIUDADSoap", Namespace="http://tempuri.org/")]
    public partial class ServiciosVIEW_CIUDAD : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback crearVIEW_CIUDADOperationCompleted;
        
        private System.Threading.SendOrPostCallback editarVIEW_CIUDADOperationCompleted;
        
        private System.Threading.SendOrPostCallback buscarPrimeroVIEW_CIUDADOperationCompleted;
        
        private System.Threading.SendOrPostCallback buscarVIEW_CIUDADOperationCompleted;
        
        private System.Threading.SendOrPostCallback listarVIEW_CIUDADOperationCompleted;
        
        private System.Threading.SendOrPostCallback eliminarVIEW_CIUDADOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public ServiciosVIEW_CIUDAD() {
            this.Url = global::EscuelaConduccion.Properties.Settings.Default.EscuelaConduccion_wsServiciosVIEW_CIUDAD_ServiciosVIEW_CIUDAD;
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
        public event crearVIEW_CIUDADCompletedEventHandler crearVIEW_CIUDADCompleted;
        
        /// <remarks/>
        public event editarVIEW_CIUDADCompletedEventHandler editarVIEW_CIUDADCompleted;
        
        /// <remarks/>
        public event buscarPrimeroVIEW_CIUDADCompletedEventHandler buscarPrimeroVIEW_CIUDADCompleted;
        
        /// <remarks/>
        public event buscarVIEW_CIUDADCompletedEventHandler buscarVIEW_CIUDADCompleted;
        
        /// <remarks/>
        public event listarVIEW_CIUDADCompletedEventHandler listarVIEW_CIUDADCompleted;
        
        /// <remarks/>
        public event eliminarVIEW_CIUDADCompletedEventHandler eliminarVIEW_CIUDADCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/crearVIEW_CIUDAD", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public VIEW_CIUDAD crearVIEW_CIUDAD(VIEW_CIUDAD obj) {
            object[] results = this.Invoke("crearVIEW_CIUDAD", new object[] {
                        obj});
            return ((VIEW_CIUDAD)(results[0]));
        }
        
        /// <remarks/>
        public void crearVIEW_CIUDADAsync(VIEW_CIUDAD obj) {
            this.crearVIEW_CIUDADAsync(obj, null);
        }
        
        /// <remarks/>
        public void crearVIEW_CIUDADAsync(VIEW_CIUDAD obj, object userState) {
            if ((this.crearVIEW_CIUDADOperationCompleted == null)) {
                this.crearVIEW_CIUDADOperationCompleted = new System.Threading.SendOrPostCallback(this.OncrearVIEW_CIUDADOperationCompleted);
            }
            this.InvokeAsync("crearVIEW_CIUDAD", new object[] {
                        obj}, this.crearVIEW_CIUDADOperationCompleted, userState);
        }
        
        private void OncrearVIEW_CIUDADOperationCompleted(object arg) {
            if ((this.crearVIEW_CIUDADCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.crearVIEW_CIUDADCompleted(this, new crearVIEW_CIUDADCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/editarVIEW_CIUDAD", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool editarVIEW_CIUDAD(VIEW_CIUDAD obj) {
            object[] results = this.Invoke("editarVIEW_CIUDAD", new object[] {
                        obj});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void editarVIEW_CIUDADAsync(VIEW_CIUDAD obj) {
            this.editarVIEW_CIUDADAsync(obj, null);
        }
        
        /// <remarks/>
        public void editarVIEW_CIUDADAsync(VIEW_CIUDAD obj, object userState) {
            if ((this.editarVIEW_CIUDADOperationCompleted == null)) {
                this.editarVIEW_CIUDADOperationCompleted = new System.Threading.SendOrPostCallback(this.OneditarVIEW_CIUDADOperationCompleted);
            }
            this.InvokeAsync("editarVIEW_CIUDAD", new object[] {
                        obj}, this.editarVIEW_CIUDADOperationCompleted, userState);
        }
        
        private void OneditarVIEW_CIUDADOperationCompleted(object arg) {
            if ((this.editarVIEW_CIUDADCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.editarVIEW_CIUDADCompleted(this, new editarVIEW_CIUDADCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/buscarPrimeroVIEW_CIUDAD", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public VIEW_CIUDAD buscarPrimeroVIEW_CIUDAD(VIEW_CIUDAD obj) {
            object[] results = this.Invoke("buscarPrimeroVIEW_CIUDAD", new object[] {
                        obj});
            return ((VIEW_CIUDAD)(results[0]));
        }
        
        /// <remarks/>
        public void buscarPrimeroVIEW_CIUDADAsync(VIEW_CIUDAD obj) {
            this.buscarPrimeroVIEW_CIUDADAsync(obj, null);
        }
        
        /// <remarks/>
        public void buscarPrimeroVIEW_CIUDADAsync(VIEW_CIUDAD obj, object userState) {
            if ((this.buscarPrimeroVIEW_CIUDADOperationCompleted == null)) {
                this.buscarPrimeroVIEW_CIUDADOperationCompleted = new System.Threading.SendOrPostCallback(this.OnbuscarPrimeroVIEW_CIUDADOperationCompleted);
            }
            this.InvokeAsync("buscarPrimeroVIEW_CIUDAD", new object[] {
                        obj}, this.buscarPrimeroVIEW_CIUDADOperationCompleted, userState);
        }
        
        private void OnbuscarPrimeroVIEW_CIUDADOperationCompleted(object arg) {
            if ((this.buscarPrimeroVIEW_CIUDADCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.buscarPrimeroVIEW_CIUDADCompleted(this, new buscarPrimeroVIEW_CIUDADCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/buscarVIEW_CIUDAD", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public VIEW_CIUDAD[] buscarVIEW_CIUDAD(VIEW_CIUDAD obj) {
            object[] results = this.Invoke("buscarVIEW_CIUDAD", new object[] {
                        obj});
            return ((VIEW_CIUDAD[])(results[0]));
        }
        
        /// <remarks/>
        public void buscarVIEW_CIUDADAsync(VIEW_CIUDAD obj) {
            this.buscarVIEW_CIUDADAsync(obj, null);
        }
        
        /// <remarks/>
        public void buscarVIEW_CIUDADAsync(VIEW_CIUDAD obj, object userState) {
            if ((this.buscarVIEW_CIUDADOperationCompleted == null)) {
                this.buscarVIEW_CIUDADOperationCompleted = new System.Threading.SendOrPostCallback(this.OnbuscarVIEW_CIUDADOperationCompleted);
            }
            this.InvokeAsync("buscarVIEW_CIUDAD", new object[] {
                        obj}, this.buscarVIEW_CIUDADOperationCompleted, userState);
        }
        
        private void OnbuscarVIEW_CIUDADOperationCompleted(object arg) {
            if ((this.buscarVIEW_CIUDADCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.buscarVIEW_CIUDADCompleted(this, new buscarVIEW_CIUDADCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/listarVIEW_CIUDAD", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public VIEW_CIUDAD[] listarVIEW_CIUDAD() {
            object[] results = this.Invoke("listarVIEW_CIUDAD", new object[0]);
            return ((VIEW_CIUDAD[])(results[0]));
        }
        
        /// <remarks/>
        public void listarVIEW_CIUDADAsync() {
            this.listarVIEW_CIUDADAsync(null);
        }
        
        /// <remarks/>
        public void listarVIEW_CIUDADAsync(object userState) {
            if ((this.listarVIEW_CIUDADOperationCompleted == null)) {
                this.listarVIEW_CIUDADOperationCompleted = new System.Threading.SendOrPostCallback(this.OnlistarVIEW_CIUDADOperationCompleted);
            }
            this.InvokeAsync("listarVIEW_CIUDAD", new object[0], this.listarVIEW_CIUDADOperationCompleted, userState);
        }
        
        private void OnlistarVIEW_CIUDADOperationCompleted(object arg) {
            if ((this.listarVIEW_CIUDADCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.listarVIEW_CIUDADCompleted(this, new listarVIEW_CIUDADCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/eliminarVIEW_CIUDAD", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool eliminarVIEW_CIUDAD(VIEW_CIUDAD obj) {
            object[] results = this.Invoke("eliminarVIEW_CIUDAD", new object[] {
                        obj});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void eliminarVIEW_CIUDADAsync(VIEW_CIUDAD obj) {
            this.eliminarVIEW_CIUDADAsync(obj, null);
        }
        
        /// <remarks/>
        public void eliminarVIEW_CIUDADAsync(VIEW_CIUDAD obj, object userState) {
            if ((this.eliminarVIEW_CIUDADOperationCompleted == null)) {
                this.eliminarVIEW_CIUDADOperationCompleted = new System.Threading.SendOrPostCallback(this.OneliminarVIEW_CIUDADOperationCompleted);
            }
            this.InvokeAsync("eliminarVIEW_CIUDAD", new object[] {
                        obj}, this.eliminarVIEW_CIUDADOperationCompleted, userState);
        }
        
        private void OneliminarVIEW_CIUDADOperationCompleted(object arg) {
            if ((this.eliminarVIEW_CIUDADCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.eliminarVIEW_CIUDADCompleted(this, new eliminarVIEW_CIUDADCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class VIEW_CIUDAD {
        
        private int idField;
        
        private string dEPARTAMENTOField;
        
        private string cIUDADField;
        
        /// <remarks/>
        public int ID {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        public string DEPARTAMENTO {
            get {
                return this.dEPARTAMENTOField;
            }
            set {
                this.dEPARTAMENTOField = value;
            }
        }
        
        /// <remarks/>
        public string CIUDAD {
            get {
                return this.cIUDADField;
            }
            set {
                this.cIUDADField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    public delegate void crearVIEW_CIUDADCompletedEventHandler(object sender, crearVIEW_CIUDADCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class crearVIEW_CIUDADCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal crearVIEW_CIUDADCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public VIEW_CIUDAD Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((VIEW_CIUDAD)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    public delegate void editarVIEW_CIUDADCompletedEventHandler(object sender, editarVIEW_CIUDADCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class editarVIEW_CIUDADCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal editarVIEW_CIUDADCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    public delegate void buscarPrimeroVIEW_CIUDADCompletedEventHandler(object sender, buscarPrimeroVIEW_CIUDADCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class buscarPrimeroVIEW_CIUDADCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal buscarPrimeroVIEW_CIUDADCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public VIEW_CIUDAD Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((VIEW_CIUDAD)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    public delegate void buscarVIEW_CIUDADCompletedEventHandler(object sender, buscarVIEW_CIUDADCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class buscarVIEW_CIUDADCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal buscarVIEW_CIUDADCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public VIEW_CIUDAD[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((VIEW_CIUDAD[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    public delegate void listarVIEW_CIUDADCompletedEventHandler(object sender, listarVIEW_CIUDADCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class listarVIEW_CIUDADCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal listarVIEW_CIUDADCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public VIEW_CIUDAD[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((VIEW_CIUDAD[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    public delegate void eliminarVIEW_CIUDADCompletedEventHandler(object sender, eliminarVIEW_CIUDADCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class eliminarVIEW_CIUDADCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal eliminarVIEW_CIUDADCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591