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

namespace EscuelaConduccion.wsServiciosTARIFACATEGORIA {
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
    [System.Web.Services.WebServiceBindingAttribute(Name="ServiciosTARIFACATEGORIASoap", Namespace="http://tempuri.org/")]
    public partial class ServiciosTARIFACATEGORIA : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback crearTARIFACATEGORIAOperationCompleted;
        
        private System.Threading.SendOrPostCallback editarTARIFACATEGORIAOperationCompleted;
        
        private System.Threading.SendOrPostCallback buscarPrimeroTARIFACATEGORIAOperationCompleted;
        
        private System.Threading.SendOrPostCallback buscarTARIFACATEGORIAOperationCompleted;
        
        private System.Threading.SendOrPostCallback listarTARIFACATEGORIAOperationCompleted;
        
        private System.Threading.SendOrPostCallback eliminarTARIFACATEGORIAOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public ServiciosTARIFACATEGORIA() {
            this.Url = global::EscuelaConduccion.Properties.Settings.Default.EscuelaConduccion_wsServiciosTARIFACATEGORIA_ServiciosTARIFACATEGORIA;
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
        public event crearTARIFACATEGORIACompletedEventHandler crearTARIFACATEGORIACompleted;
        
        /// <remarks/>
        public event editarTARIFACATEGORIACompletedEventHandler editarTARIFACATEGORIACompleted;
        
        /// <remarks/>
        public event buscarPrimeroTARIFACATEGORIACompletedEventHandler buscarPrimeroTARIFACATEGORIACompleted;
        
        /// <remarks/>
        public event buscarTARIFACATEGORIACompletedEventHandler buscarTARIFACATEGORIACompleted;
        
        /// <remarks/>
        public event listarTARIFACATEGORIACompletedEventHandler listarTARIFACATEGORIACompleted;
        
        /// <remarks/>
        public event eliminarTARIFACATEGORIACompletedEventHandler eliminarTARIFACATEGORIACompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/crearTARIFACATEGORIA", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public TARIFACATEGORIA crearTARIFACATEGORIA(TARIFACATEGORIA obj) {
            object[] results = this.Invoke("crearTARIFACATEGORIA", new object[] {
                        obj});
            return ((TARIFACATEGORIA)(results[0]));
        }
        
        /// <remarks/>
        public void crearTARIFACATEGORIAAsync(TARIFACATEGORIA obj) {
            this.crearTARIFACATEGORIAAsync(obj, null);
        }
        
        /// <remarks/>
        public void crearTARIFACATEGORIAAsync(TARIFACATEGORIA obj, object userState) {
            if ((this.crearTARIFACATEGORIAOperationCompleted == null)) {
                this.crearTARIFACATEGORIAOperationCompleted = new System.Threading.SendOrPostCallback(this.OncrearTARIFACATEGORIAOperationCompleted);
            }
            this.InvokeAsync("crearTARIFACATEGORIA", new object[] {
                        obj}, this.crearTARIFACATEGORIAOperationCompleted, userState);
        }
        
        private void OncrearTARIFACATEGORIAOperationCompleted(object arg) {
            if ((this.crearTARIFACATEGORIACompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.crearTARIFACATEGORIACompleted(this, new crearTARIFACATEGORIACompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/editarTARIFACATEGORIA", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool editarTARIFACATEGORIA(TARIFACATEGORIA obj) {
            object[] results = this.Invoke("editarTARIFACATEGORIA", new object[] {
                        obj});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void editarTARIFACATEGORIAAsync(TARIFACATEGORIA obj) {
            this.editarTARIFACATEGORIAAsync(obj, null);
        }
        
        /// <remarks/>
        public void editarTARIFACATEGORIAAsync(TARIFACATEGORIA obj, object userState) {
            if ((this.editarTARIFACATEGORIAOperationCompleted == null)) {
                this.editarTARIFACATEGORIAOperationCompleted = new System.Threading.SendOrPostCallback(this.OneditarTARIFACATEGORIAOperationCompleted);
            }
            this.InvokeAsync("editarTARIFACATEGORIA", new object[] {
                        obj}, this.editarTARIFACATEGORIAOperationCompleted, userState);
        }
        
        private void OneditarTARIFACATEGORIAOperationCompleted(object arg) {
            if ((this.editarTARIFACATEGORIACompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.editarTARIFACATEGORIACompleted(this, new editarTARIFACATEGORIACompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/buscarPrimeroTARIFACATEGORIA", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public TARIFACATEGORIA buscarPrimeroTARIFACATEGORIA(TARIFACATEGORIA obj) {
            object[] results = this.Invoke("buscarPrimeroTARIFACATEGORIA", new object[] {
                        obj});
            return ((TARIFACATEGORIA)(results[0]));
        }
        
        /// <remarks/>
        public void buscarPrimeroTARIFACATEGORIAAsync(TARIFACATEGORIA obj) {
            this.buscarPrimeroTARIFACATEGORIAAsync(obj, null);
        }
        
        /// <remarks/>
        public void buscarPrimeroTARIFACATEGORIAAsync(TARIFACATEGORIA obj, object userState) {
            if ((this.buscarPrimeroTARIFACATEGORIAOperationCompleted == null)) {
                this.buscarPrimeroTARIFACATEGORIAOperationCompleted = new System.Threading.SendOrPostCallback(this.OnbuscarPrimeroTARIFACATEGORIAOperationCompleted);
            }
            this.InvokeAsync("buscarPrimeroTARIFACATEGORIA", new object[] {
                        obj}, this.buscarPrimeroTARIFACATEGORIAOperationCompleted, userState);
        }
        
        private void OnbuscarPrimeroTARIFACATEGORIAOperationCompleted(object arg) {
            if ((this.buscarPrimeroTARIFACATEGORIACompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.buscarPrimeroTARIFACATEGORIACompleted(this, new buscarPrimeroTARIFACATEGORIACompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/buscarTARIFACATEGORIA", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public TARIFACATEGORIA[] buscarTARIFACATEGORIA(TARIFACATEGORIA obj) {
            object[] results = this.Invoke("buscarTARIFACATEGORIA", new object[] {
                        obj});
            return ((TARIFACATEGORIA[])(results[0]));
        }
        
        /// <remarks/>
        public void buscarTARIFACATEGORIAAsync(TARIFACATEGORIA obj) {
            this.buscarTARIFACATEGORIAAsync(obj, null);
        }
        
        /// <remarks/>
        public void buscarTARIFACATEGORIAAsync(TARIFACATEGORIA obj, object userState) {
            if ((this.buscarTARIFACATEGORIAOperationCompleted == null)) {
                this.buscarTARIFACATEGORIAOperationCompleted = new System.Threading.SendOrPostCallback(this.OnbuscarTARIFACATEGORIAOperationCompleted);
            }
            this.InvokeAsync("buscarTARIFACATEGORIA", new object[] {
                        obj}, this.buscarTARIFACATEGORIAOperationCompleted, userState);
        }
        
        private void OnbuscarTARIFACATEGORIAOperationCompleted(object arg) {
            if ((this.buscarTARIFACATEGORIACompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.buscarTARIFACATEGORIACompleted(this, new buscarTARIFACATEGORIACompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/listarTARIFACATEGORIA", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public TARIFACATEGORIA[] listarTARIFACATEGORIA() {
            object[] results = this.Invoke("listarTARIFACATEGORIA", new object[0]);
            return ((TARIFACATEGORIA[])(results[0]));
        }
        
        /// <remarks/>
        public void listarTARIFACATEGORIAAsync() {
            this.listarTARIFACATEGORIAAsync(null);
        }
        
        /// <remarks/>
        public void listarTARIFACATEGORIAAsync(object userState) {
            if ((this.listarTARIFACATEGORIAOperationCompleted == null)) {
                this.listarTARIFACATEGORIAOperationCompleted = new System.Threading.SendOrPostCallback(this.OnlistarTARIFACATEGORIAOperationCompleted);
            }
            this.InvokeAsync("listarTARIFACATEGORIA", new object[0], this.listarTARIFACATEGORIAOperationCompleted, userState);
        }
        
        private void OnlistarTARIFACATEGORIAOperationCompleted(object arg) {
            if ((this.listarTARIFACATEGORIACompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.listarTARIFACATEGORIACompleted(this, new listarTARIFACATEGORIACompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/eliminarTARIFACATEGORIA", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool eliminarTARIFACATEGORIA(TARIFACATEGORIA obj) {
            object[] results = this.Invoke("eliminarTARIFACATEGORIA", new object[] {
                        obj});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void eliminarTARIFACATEGORIAAsync(TARIFACATEGORIA obj) {
            this.eliminarTARIFACATEGORIAAsync(obj, null);
        }
        
        /// <remarks/>
        public void eliminarTARIFACATEGORIAAsync(TARIFACATEGORIA obj, object userState) {
            if ((this.eliminarTARIFACATEGORIAOperationCompleted == null)) {
                this.eliminarTARIFACATEGORIAOperationCompleted = new System.Threading.SendOrPostCallback(this.OneliminarTARIFACATEGORIAOperationCompleted);
            }
            this.InvokeAsync("eliminarTARIFACATEGORIA", new object[] {
                        obj}, this.eliminarTARIFACATEGORIAOperationCompleted, userState);
        }
        
        private void OneliminarTARIFACATEGORIAOperationCompleted(object arg) {
            if ((this.eliminarTARIFACATEGORIACompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.eliminarTARIFACATEGORIACompleted(this, new eliminarTARIFACATEGORIACompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    public partial class TARIFACATEGORIA {
        
        private int idField;
        
        private string nOMBREField;
        
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
        public string NOMBRE {
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
    public delegate void crearTARIFACATEGORIACompletedEventHandler(object sender, crearTARIFACATEGORIACompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class crearTARIFACATEGORIACompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal crearTARIFACATEGORIACompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public TARIFACATEGORIA Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((TARIFACATEGORIA)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    public delegate void editarTARIFACATEGORIACompletedEventHandler(object sender, editarTARIFACATEGORIACompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class editarTARIFACATEGORIACompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal editarTARIFACATEGORIACompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    public delegate void buscarPrimeroTARIFACATEGORIACompletedEventHandler(object sender, buscarPrimeroTARIFACATEGORIACompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class buscarPrimeroTARIFACATEGORIACompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal buscarPrimeroTARIFACATEGORIACompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public TARIFACATEGORIA Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((TARIFACATEGORIA)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    public delegate void buscarTARIFACATEGORIACompletedEventHandler(object sender, buscarTARIFACATEGORIACompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class buscarTARIFACATEGORIACompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal buscarTARIFACATEGORIACompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public TARIFACATEGORIA[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((TARIFACATEGORIA[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    public delegate void listarTARIFACATEGORIACompletedEventHandler(object sender, listarTARIFACATEGORIACompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class listarTARIFACATEGORIACompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal listarTARIFACATEGORIACompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public TARIFACATEGORIA[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((TARIFACATEGORIA[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    public delegate void eliminarTARIFACATEGORIACompletedEventHandler(object sender, eliminarTARIFACATEGORIACompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class eliminarTARIFACATEGORIACompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal eliminarTARIFACATEGORIACompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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