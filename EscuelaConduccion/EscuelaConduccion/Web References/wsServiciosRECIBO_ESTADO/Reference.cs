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

namespace EscuelaConduccion.wsServiciosRECIBO_ESTADO {
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
    [System.Web.Services.WebServiceBindingAttribute(Name="ServiciosRECIBO_ESTADOSoap", Namespace="http://tempuri.org/")]
    public partial class ServiciosRECIBO_ESTADO : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback crearRECIBO_ESTADOOperationCompleted;
        
        private System.Threading.SendOrPostCallback editarRECIBO_ESTADOOperationCompleted;
        
        private System.Threading.SendOrPostCallback buscarPrimeroRECIBO_ESTADOOperationCompleted;
        
        private System.Threading.SendOrPostCallback buscarRECIBO_ESTADOOperationCompleted;
        
        private System.Threading.SendOrPostCallback listarRECIBO_ESTADOOperationCompleted;
        
        private System.Threading.SendOrPostCallback eliminarRECIBO_ESTADOOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public ServiciosRECIBO_ESTADO() {
            this.Url = global::EscuelaConduccion.Properties.Settings.Default.EscuelaConduccion_wsServiciosRECIBO_ESTADO_ServiciosRECIBO_ESTADO;
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
        public event crearRECIBO_ESTADOCompletedEventHandler crearRECIBO_ESTADOCompleted;
        
        /// <remarks/>
        public event editarRECIBO_ESTADOCompletedEventHandler editarRECIBO_ESTADOCompleted;
        
        /// <remarks/>
        public event buscarPrimeroRECIBO_ESTADOCompletedEventHandler buscarPrimeroRECIBO_ESTADOCompleted;
        
        /// <remarks/>
        public event buscarRECIBO_ESTADOCompletedEventHandler buscarRECIBO_ESTADOCompleted;
        
        /// <remarks/>
        public event listarRECIBO_ESTADOCompletedEventHandler listarRECIBO_ESTADOCompleted;
        
        /// <remarks/>
        public event eliminarRECIBO_ESTADOCompletedEventHandler eliminarRECIBO_ESTADOCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/crearRECIBO_ESTADO", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public RECIBO_ESTADO crearRECIBO_ESTADO(RECIBO_ESTADO obj) {
            object[] results = this.Invoke("crearRECIBO_ESTADO", new object[] {
                        obj});
            return ((RECIBO_ESTADO)(results[0]));
        }
        
        /// <remarks/>
        public void crearRECIBO_ESTADOAsync(RECIBO_ESTADO obj) {
            this.crearRECIBO_ESTADOAsync(obj, null);
        }
        
        /// <remarks/>
        public void crearRECIBO_ESTADOAsync(RECIBO_ESTADO obj, object userState) {
            if ((this.crearRECIBO_ESTADOOperationCompleted == null)) {
                this.crearRECIBO_ESTADOOperationCompleted = new System.Threading.SendOrPostCallback(this.OncrearRECIBO_ESTADOOperationCompleted);
            }
            this.InvokeAsync("crearRECIBO_ESTADO", new object[] {
                        obj}, this.crearRECIBO_ESTADOOperationCompleted, userState);
        }
        
        private void OncrearRECIBO_ESTADOOperationCompleted(object arg) {
            if ((this.crearRECIBO_ESTADOCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.crearRECIBO_ESTADOCompleted(this, new crearRECIBO_ESTADOCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/editarRECIBO_ESTADO", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool editarRECIBO_ESTADO(RECIBO_ESTADO obj) {
            object[] results = this.Invoke("editarRECIBO_ESTADO", new object[] {
                        obj});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void editarRECIBO_ESTADOAsync(RECIBO_ESTADO obj) {
            this.editarRECIBO_ESTADOAsync(obj, null);
        }
        
        /// <remarks/>
        public void editarRECIBO_ESTADOAsync(RECIBO_ESTADO obj, object userState) {
            if ((this.editarRECIBO_ESTADOOperationCompleted == null)) {
                this.editarRECIBO_ESTADOOperationCompleted = new System.Threading.SendOrPostCallback(this.OneditarRECIBO_ESTADOOperationCompleted);
            }
            this.InvokeAsync("editarRECIBO_ESTADO", new object[] {
                        obj}, this.editarRECIBO_ESTADOOperationCompleted, userState);
        }
        
        private void OneditarRECIBO_ESTADOOperationCompleted(object arg) {
            if ((this.editarRECIBO_ESTADOCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.editarRECIBO_ESTADOCompleted(this, new editarRECIBO_ESTADOCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/buscarPrimeroRECIBO_ESTADO", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public RECIBO_ESTADO buscarPrimeroRECIBO_ESTADO(RECIBO_ESTADO obj) {
            object[] results = this.Invoke("buscarPrimeroRECIBO_ESTADO", new object[] {
                        obj});
            return ((RECIBO_ESTADO)(results[0]));
        }
        
        /// <remarks/>
        public void buscarPrimeroRECIBO_ESTADOAsync(RECIBO_ESTADO obj) {
            this.buscarPrimeroRECIBO_ESTADOAsync(obj, null);
        }
        
        /// <remarks/>
        public void buscarPrimeroRECIBO_ESTADOAsync(RECIBO_ESTADO obj, object userState) {
            if ((this.buscarPrimeroRECIBO_ESTADOOperationCompleted == null)) {
                this.buscarPrimeroRECIBO_ESTADOOperationCompleted = new System.Threading.SendOrPostCallback(this.OnbuscarPrimeroRECIBO_ESTADOOperationCompleted);
            }
            this.InvokeAsync("buscarPrimeroRECIBO_ESTADO", new object[] {
                        obj}, this.buscarPrimeroRECIBO_ESTADOOperationCompleted, userState);
        }
        
        private void OnbuscarPrimeroRECIBO_ESTADOOperationCompleted(object arg) {
            if ((this.buscarPrimeroRECIBO_ESTADOCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.buscarPrimeroRECIBO_ESTADOCompleted(this, new buscarPrimeroRECIBO_ESTADOCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/buscarRECIBO_ESTADO", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public RECIBO_ESTADO[] buscarRECIBO_ESTADO(RECIBO_ESTADO obj) {
            object[] results = this.Invoke("buscarRECIBO_ESTADO", new object[] {
                        obj});
            return ((RECIBO_ESTADO[])(results[0]));
        }
        
        /// <remarks/>
        public void buscarRECIBO_ESTADOAsync(RECIBO_ESTADO obj) {
            this.buscarRECIBO_ESTADOAsync(obj, null);
        }
        
        /// <remarks/>
        public void buscarRECIBO_ESTADOAsync(RECIBO_ESTADO obj, object userState) {
            if ((this.buscarRECIBO_ESTADOOperationCompleted == null)) {
                this.buscarRECIBO_ESTADOOperationCompleted = new System.Threading.SendOrPostCallback(this.OnbuscarRECIBO_ESTADOOperationCompleted);
            }
            this.InvokeAsync("buscarRECIBO_ESTADO", new object[] {
                        obj}, this.buscarRECIBO_ESTADOOperationCompleted, userState);
        }
        
        private void OnbuscarRECIBO_ESTADOOperationCompleted(object arg) {
            if ((this.buscarRECIBO_ESTADOCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.buscarRECIBO_ESTADOCompleted(this, new buscarRECIBO_ESTADOCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/listarRECIBO_ESTADO", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public RECIBO_ESTADO[] listarRECIBO_ESTADO() {
            object[] results = this.Invoke("listarRECIBO_ESTADO", new object[0]);
            return ((RECIBO_ESTADO[])(results[0]));
        }
        
        /// <remarks/>
        public void listarRECIBO_ESTADOAsync() {
            this.listarRECIBO_ESTADOAsync(null);
        }
        
        /// <remarks/>
        public void listarRECIBO_ESTADOAsync(object userState) {
            if ((this.listarRECIBO_ESTADOOperationCompleted == null)) {
                this.listarRECIBO_ESTADOOperationCompleted = new System.Threading.SendOrPostCallback(this.OnlistarRECIBO_ESTADOOperationCompleted);
            }
            this.InvokeAsync("listarRECIBO_ESTADO", new object[0], this.listarRECIBO_ESTADOOperationCompleted, userState);
        }
        
        private void OnlistarRECIBO_ESTADOOperationCompleted(object arg) {
            if ((this.listarRECIBO_ESTADOCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.listarRECIBO_ESTADOCompleted(this, new listarRECIBO_ESTADOCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/eliminarRECIBO_ESTADO", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool eliminarRECIBO_ESTADO(RECIBO_ESTADO obj) {
            object[] results = this.Invoke("eliminarRECIBO_ESTADO", new object[] {
                        obj});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void eliminarRECIBO_ESTADOAsync(RECIBO_ESTADO obj) {
            this.eliminarRECIBO_ESTADOAsync(obj, null);
        }
        
        /// <remarks/>
        public void eliminarRECIBO_ESTADOAsync(RECIBO_ESTADO obj, object userState) {
            if ((this.eliminarRECIBO_ESTADOOperationCompleted == null)) {
                this.eliminarRECIBO_ESTADOOperationCompleted = new System.Threading.SendOrPostCallback(this.OneliminarRECIBO_ESTADOOperationCompleted);
            }
            this.InvokeAsync("eliminarRECIBO_ESTADO", new object[] {
                        obj}, this.eliminarRECIBO_ESTADOOperationCompleted, userState);
        }
        
        private void OneliminarRECIBO_ESTADOOperationCompleted(object arg) {
            if ((this.eliminarRECIBO_ESTADOCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.eliminarRECIBO_ESTADOCompleted(this, new eliminarRECIBO_ESTADOCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    public partial class RECIBO_ESTADO {
        
        private int idField;
        
        private string eSTADOField;
        
        private string dESCRIPCION_ESTADOField;
        
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
        public string ESTADO {
            get {
                return this.eSTADOField;
            }
            set {
                this.eSTADOField = value;
            }
        }
        
        /// <remarks/>
        public string DESCRIPCION_ESTADO {
            get {
                return this.dESCRIPCION_ESTADOField;
            }
            set {
                this.dESCRIPCION_ESTADOField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    public delegate void crearRECIBO_ESTADOCompletedEventHandler(object sender, crearRECIBO_ESTADOCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class crearRECIBO_ESTADOCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal crearRECIBO_ESTADOCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public RECIBO_ESTADO Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((RECIBO_ESTADO)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    public delegate void editarRECIBO_ESTADOCompletedEventHandler(object sender, editarRECIBO_ESTADOCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class editarRECIBO_ESTADOCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal editarRECIBO_ESTADOCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    public delegate void buscarPrimeroRECIBO_ESTADOCompletedEventHandler(object sender, buscarPrimeroRECIBO_ESTADOCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class buscarPrimeroRECIBO_ESTADOCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal buscarPrimeroRECIBO_ESTADOCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public RECIBO_ESTADO Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((RECIBO_ESTADO)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    public delegate void buscarRECIBO_ESTADOCompletedEventHandler(object sender, buscarRECIBO_ESTADOCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class buscarRECIBO_ESTADOCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal buscarRECIBO_ESTADOCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public RECIBO_ESTADO[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((RECIBO_ESTADO[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    public delegate void listarRECIBO_ESTADOCompletedEventHandler(object sender, listarRECIBO_ESTADOCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class listarRECIBO_ESTADOCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal listarRECIBO_ESTADOCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public RECIBO_ESTADO[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((RECIBO_ESTADO[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    public delegate void eliminarRECIBO_ESTADOCompletedEventHandler(object sender, eliminarRECIBO_ESTADOCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class eliminarRECIBO_ESTADOCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal eliminarRECIBO_ESTADOCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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