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

namespace EscuelaConduccion.wsServiciosVIGENCIA {
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
    [System.Web.Services.WebServiceBindingAttribute(Name="ServiciosVIGENCIASoap", Namespace="http://tempuri.org/")]
    public partial class ServiciosVIGENCIA : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback crearVIGENCIAOperationCompleted;
        
        private System.Threading.SendOrPostCallback editarVIGENCIAOperationCompleted;
        
        private System.Threading.SendOrPostCallback buscarPrimeroVIGENCIAOperationCompleted;
        
        private System.Threading.SendOrPostCallback buscarVIGENCIAOperationCompleted;
        
        private System.Threading.SendOrPostCallback listarVIGENCIAOperationCompleted;
        
        private System.Threading.SendOrPostCallback eliminarVIGENCIAOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public ServiciosVIGENCIA() {
            this.Url = global::EscuelaConduccion.Properties.Settings.Default.EscuelaConduccion_wsServiciosVIGENCIA_ServiciosVIGENCIA;
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
        public event crearVIGENCIACompletedEventHandler crearVIGENCIACompleted;
        
        /// <remarks/>
        public event editarVIGENCIACompletedEventHandler editarVIGENCIACompleted;
        
        /// <remarks/>
        public event buscarPrimeroVIGENCIACompletedEventHandler buscarPrimeroVIGENCIACompleted;
        
        /// <remarks/>
        public event buscarVIGENCIACompletedEventHandler buscarVIGENCIACompleted;
        
        /// <remarks/>
        public event listarVIGENCIACompletedEventHandler listarVIGENCIACompleted;
        
        /// <remarks/>
        public event eliminarVIGENCIACompletedEventHandler eliminarVIGENCIACompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/crearVIGENCIA", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public VIGENCIA crearVIGENCIA(VIGENCIA obj) {
            object[] results = this.Invoke("crearVIGENCIA", new object[] {
                        obj});
            return ((VIGENCIA)(results[0]));
        }
        
        /// <remarks/>
        public void crearVIGENCIAAsync(VIGENCIA obj) {
            this.crearVIGENCIAAsync(obj, null);
        }
        
        /// <remarks/>
        public void crearVIGENCIAAsync(VIGENCIA obj, object userState) {
            if ((this.crearVIGENCIAOperationCompleted == null)) {
                this.crearVIGENCIAOperationCompleted = new System.Threading.SendOrPostCallback(this.OncrearVIGENCIAOperationCompleted);
            }
            this.InvokeAsync("crearVIGENCIA", new object[] {
                        obj}, this.crearVIGENCIAOperationCompleted, userState);
        }
        
        private void OncrearVIGENCIAOperationCompleted(object arg) {
            if ((this.crearVIGENCIACompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.crearVIGENCIACompleted(this, new crearVIGENCIACompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/editarVIGENCIA", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool editarVIGENCIA(VIGENCIA obj) {
            object[] results = this.Invoke("editarVIGENCIA", new object[] {
                        obj});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void editarVIGENCIAAsync(VIGENCIA obj) {
            this.editarVIGENCIAAsync(obj, null);
        }
        
        /// <remarks/>
        public void editarVIGENCIAAsync(VIGENCIA obj, object userState) {
            if ((this.editarVIGENCIAOperationCompleted == null)) {
                this.editarVIGENCIAOperationCompleted = new System.Threading.SendOrPostCallback(this.OneditarVIGENCIAOperationCompleted);
            }
            this.InvokeAsync("editarVIGENCIA", new object[] {
                        obj}, this.editarVIGENCIAOperationCompleted, userState);
        }
        
        private void OneditarVIGENCIAOperationCompleted(object arg) {
            if ((this.editarVIGENCIACompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.editarVIGENCIACompleted(this, new editarVIGENCIACompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/buscarPrimeroVIGENCIA", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public VIGENCIA buscarPrimeroVIGENCIA(VIGENCIA obj) {
            object[] results = this.Invoke("buscarPrimeroVIGENCIA", new object[] {
                        obj});
            return ((VIGENCIA)(results[0]));
        }
        
        /// <remarks/>
        public void buscarPrimeroVIGENCIAAsync(VIGENCIA obj) {
            this.buscarPrimeroVIGENCIAAsync(obj, null);
        }
        
        /// <remarks/>
        public void buscarPrimeroVIGENCIAAsync(VIGENCIA obj, object userState) {
            if ((this.buscarPrimeroVIGENCIAOperationCompleted == null)) {
                this.buscarPrimeroVIGENCIAOperationCompleted = new System.Threading.SendOrPostCallback(this.OnbuscarPrimeroVIGENCIAOperationCompleted);
            }
            this.InvokeAsync("buscarPrimeroVIGENCIA", new object[] {
                        obj}, this.buscarPrimeroVIGENCIAOperationCompleted, userState);
        }
        
        private void OnbuscarPrimeroVIGENCIAOperationCompleted(object arg) {
            if ((this.buscarPrimeroVIGENCIACompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.buscarPrimeroVIGENCIACompleted(this, new buscarPrimeroVIGENCIACompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/buscarVIGENCIA", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public VIGENCIA[] buscarVIGENCIA(VIGENCIA obj) {
            object[] results = this.Invoke("buscarVIGENCIA", new object[] {
                        obj});
            return ((VIGENCIA[])(results[0]));
        }
        
        /// <remarks/>
        public void buscarVIGENCIAAsync(VIGENCIA obj) {
            this.buscarVIGENCIAAsync(obj, null);
        }
        
        /// <remarks/>
        public void buscarVIGENCIAAsync(VIGENCIA obj, object userState) {
            if ((this.buscarVIGENCIAOperationCompleted == null)) {
                this.buscarVIGENCIAOperationCompleted = new System.Threading.SendOrPostCallback(this.OnbuscarVIGENCIAOperationCompleted);
            }
            this.InvokeAsync("buscarVIGENCIA", new object[] {
                        obj}, this.buscarVIGENCIAOperationCompleted, userState);
        }
        
        private void OnbuscarVIGENCIAOperationCompleted(object arg) {
            if ((this.buscarVIGENCIACompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.buscarVIGENCIACompleted(this, new buscarVIGENCIACompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/listarVIGENCIA", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public VIGENCIA[] listarVIGENCIA() {
            object[] results = this.Invoke("listarVIGENCIA", new object[0]);
            return ((VIGENCIA[])(results[0]));
        }
        
        /// <remarks/>
        public void listarVIGENCIAAsync() {
            this.listarVIGENCIAAsync(null);
        }
        
        /// <remarks/>
        public void listarVIGENCIAAsync(object userState) {
            if ((this.listarVIGENCIAOperationCompleted == null)) {
                this.listarVIGENCIAOperationCompleted = new System.Threading.SendOrPostCallback(this.OnlistarVIGENCIAOperationCompleted);
            }
            this.InvokeAsync("listarVIGENCIA", new object[0], this.listarVIGENCIAOperationCompleted, userState);
        }
        
        private void OnlistarVIGENCIAOperationCompleted(object arg) {
            if ((this.listarVIGENCIACompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.listarVIGENCIACompleted(this, new listarVIGENCIACompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/eliminarVIGENCIA", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool eliminarVIGENCIA(VIGENCIA obj) {
            object[] results = this.Invoke("eliminarVIGENCIA", new object[] {
                        obj});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void eliminarVIGENCIAAsync(VIGENCIA obj) {
            this.eliminarVIGENCIAAsync(obj, null);
        }
        
        /// <remarks/>
        public void eliminarVIGENCIAAsync(VIGENCIA obj, object userState) {
            if ((this.eliminarVIGENCIAOperationCompleted == null)) {
                this.eliminarVIGENCIAOperationCompleted = new System.Threading.SendOrPostCallback(this.OneliminarVIGENCIAOperationCompleted);
            }
            this.InvokeAsync("eliminarVIGENCIA", new object[] {
                        obj}, this.eliminarVIGENCIAOperationCompleted, userState);
        }
        
        private void OneliminarVIGENCIAOperationCompleted(object arg) {
            if ((this.eliminarVIGENCIACompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.eliminarVIGENCIACompleted(this, new eliminarVIGENCIACompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    public partial class VIGENCIA {
        
        private int idField;
        
        private int nOMBREField;
        
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
        public int NOMBRE {
            get {
                return this.nOMBREField;
            }
            set {
                this.nOMBREField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    public delegate void crearVIGENCIACompletedEventHandler(object sender, crearVIGENCIACompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class crearVIGENCIACompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal crearVIGENCIACompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public VIGENCIA Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((VIGENCIA)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    public delegate void editarVIGENCIACompletedEventHandler(object sender, editarVIGENCIACompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class editarVIGENCIACompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal editarVIGENCIACompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    public delegate void buscarPrimeroVIGENCIACompletedEventHandler(object sender, buscarPrimeroVIGENCIACompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class buscarPrimeroVIGENCIACompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal buscarPrimeroVIGENCIACompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public VIGENCIA Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((VIGENCIA)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    public delegate void buscarVIGENCIACompletedEventHandler(object sender, buscarVIGENCIACompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class buscarVIGENCIACompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal buscarVIGENCIACompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public VIGENCIA[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((VIGENCIA[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    public delegate void listarVIGENCIACompletedEventHandler(object sender, listarVIGENCIACompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class listarVIGENCIACompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal listarVIGENCIACompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public VIGENCIA[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((VIGENCIA[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    public delegate void eliminarVIGENCIACompletedEventHandler(object sender, eliminarVIGENCIACompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class eliminarVIGENCIACompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal eliminarVIGENCIACompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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