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

namespace EscuelaConduccion.wsServiciosFormadepago {
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
    [System.Web.Services.WebServiceBindingAttribute(Name="ServiciosFormadepagoSoap", Namespace="http://tempuri.org/")]
    public partial class ServiciosFormadepago : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback crearFormadepagoOperationCompleted;
        
        private System.Threading.SendOrPostCallback editarFormadepagoOperationCompleted;
        
        private System.Threading.SendOrPostCallback buscarPrimeroFormadepagoOperationCompleted;
        
        private System.Threading.SendOrPostCallback buscarFormadepagoOperationCompleted;
        
        private System.Threading.SendOrPostCallback buscarPaginacionFormadepagoOperationCompleted;
        
        private System.Threading.SendOrPostCallback listarFormadepagoOperationCompleted;
        
        private System.Threading.SendOrPostCallback listarPaginacionFormadepagoOperationCompleted;
        
        private System.Threading.SendOrPostCallback contarBusquedaFormadepagoOperationCompleted;
        
        private System.Threading.SendOrPostCallback eliminarFormadepagoOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public ServiciosFormadepago() {
            this.Url = global::EscuelaConduccion.Properties.Settings.Default.EscuelaConduccion_WSServiciosFormadepago_ServiciosFormadepago;
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
        public event crearFormadepagoCompletedEventHandler crearFormadepagoCompleted;
        
        /// <remarks/>
        public event editarFormadepagoCompletedEventHandler editarFormadepagoCompleted;
        
        /// <remarks/>
        public event buscarPrimeroFormadepagoCompletedEventHandler buscarPrimeroFormadepagoCompleted;
        
        /// <remarks/>
        public event buscarFormadepagoCompletedEventHandler buscarFormadepagoCompleted;
        
        /// <remarks/>
        public event buscarPaginacionFormadepagoCompletedEventHandler buscarPaginacionFormadepagoCompleted;
        
        /// <remarks/>
        public event listarFormadepagoCompletedEventHandler listarFormadepagoCompleted;
        
        /// <remarks/>
        public event listarPaginacionFormadepagoCompletedEventHandler listarPaginacionFormadepagoCompleted;
        
        /// <remarks/>
        public event contarBusquedaFormadepagoCompletedEventHandler contarBusquedaFormadepagoCompleted;
        
        /// <remarks/>
        public event eliminarFormadepagoCompletedEventHandler eliminarFormadepagoCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/crearFormadepago", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Formadepago crearFormadepago(Formadepago obj) {
            object[] results = this.Invoke("crearFormadepago", new object[] {
                        obj});
            return ((Formadepago)(results[0]));
        }
        
        /// <remarks/>
        public void crearFormadepagoAsync(Formadepago obj) {
            this.crearFormadepagoAsync(obj, null);
        }
        
        /// <remarks/>
        public void crearFormadepagoAsync(Formadepago obj, object userState) {
            if ((this.crearFormadepagoOperationCompleted == null)) {
                this.crearFormadepagoOperationCompleted = new System.Threading.SendOrPostCallback(this.OncrearFormadepagoOperationCompleted);
            }
            this.InvokeAsync("crearFormadepago", new object[] {
                        obj}, this.crearFormadepagoOperationCompleted, userState);
        }
        
        private void OncrearFormadepagoOperationCompleted(object arg) {
            if ((this.crearFormadepagoCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.crearFormadepagoCompleted(this, new crearFormadepagoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/editarFormadepago", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool editarFormadepago(Formadepago obj) {
            object[] results = this.Invoke("editarFormadepago", new object[] {
                        obj});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void editarFormadepagoAsync(Formadepago obj) {
            this.editarFormadepagoAsync(obj, null);
        }
        
        /// <remarks/>
        public void editarFormadepagoAsync(Formadepago obj, object userState) {
            if ((this.editarFormadepagoOperationCompleted == null)) {
                this.editarFormadepagoOperationCompleted = new System.Threading.SendOrPostCallback(this.OneditarFormadepagoOperationCompleted);
            }
            this.InvokeAsync("editarFormadepago", new object[] {
                        obj}, this.editarFormadepagoOperationCompleted, userState);
        }
        
        private void OneditarFormadepagoOperationCompleted(object arg) {
            if ((this.editarFormadepagoCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.editarFormadepagoCompleted(this, new editarFormadepagoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/buscarPrimeroFormadepago", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Formadepago buscarPrimeroFormadepago(Formadepago obj) {
            object[] results = this.Invoke("buscarPrimeroFormadepago", new object[] {
                        obj});
            return ((Formadepago)(results[0]));
        }
        
        /// <remarks/>
        public void buscarPrimeroFormadepagoAsync(Formadepago obj) {
            this.buscarPrimeroFormadepagoAsync(obj, null);
        }
        
        /// <remarks/>
        public void buscarPrimeroFormadepagoAsync(Formadepago obj, object userState) {
            if ((this.buscarPrimeroFormadepagoOperationCompleted == null)) {
                this.buscarPrimeroFormadepagoOperationCompleted = new System.Threading.SendOrPostCallback(this.OnbuscarPrimeroFormadepagoOperationCompleted);
            }
            this.InvokeAsync("buscarPrimeroFormadepago", new object[] {
                        obj}, this.buscarPrimeroFormadepagoOperationCompleted, userState);
        }
        
        private void OnbuscarPrimeroFormadepagoOperationCompleted(object arg) {
            if ((this.buscarPrimeroFormadepagoCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.buscarPrimeroFormadepagoCompleted(this, new buscarPrimeroFormadepagoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/buscarFormadepago", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Formadepago[] buscarFormadepago(Formadepago obj) {
            object[] results = this.Invoke("buscarFormadepago", new object[] {
                        obj});
            return ((Formadepago[])(results[0]));
        }
        
        /// <remarks/>
        public void buscarFormadepagoAsync(Formadepago obj) {
            this.buscarFormadepagoAsync(obj, null);
        }
        
        /// <remarks/>
        public void buscarFormadepagoAsync(Formadepago obj, object userState) {
            if ((this.buscarFormadepagoOperationCompleted == null)) {
                this.buscarFormadepagoOperationCompleted = new System.Threading.SendOrPostCallback(this.OnbuscarFormadepagoOperationCompleted);
            }
            this.InvokeAsync("buscarFormadepago", new object[] {
                        obj}, this.buscarFormadepagoOperationCompleted, userState);
        }
        
        private void OnbuscarFormadepagoOperationCompleted(object arg) {
            if ((this.buscarFormadepagoCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.buscarFormadepagoCompleted(this, new buscarFormadepagoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/buscarPaginacionFormadepago", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Formadepago[] buscarPaginacionFormadepago(Formadepago obj, int pag, int numReg) {
            object[] results = this.Invoke("buscarPaginacionFormadepago", new object[] {
                        obj,
                        pag,
                        numReg});
            return ((Formadepago[])(results[0]));
        }
        
        /// <remarks/>
        public void buscarPaginacionFormadepagoAsync(Formadepago obj, int pag, int numReg) {
            this.buscarPaginacionFormadepagoAsync(obj, pag, numReg, null);
        }
        
        /// <remarks/>
        public void buscarPaginacionFormadepagoAsync(Formadepago obj, int pag, int numReg, object userState) {
            if ((this.buscarPaginacionFormadepagoOperationCompleted == null)) {
                this.buscarPaginacionFormadepagoOperationCompleted = new System.Threading.SendOrPostCallback(this.OnbuscarPaginacionFormadepagoOperationCompleted);
            }
            this.InvokeAsync("buscarPaginacionFormadepago", new object[] {
                        obj,
                        pag,
                        numReg}, this.buscarPaginacionFormadepagoOperationCompleted, userState);
        }
        
        private void OnbuscarPaginacionFormadepagoOperationCompleted(object arg) {
            if ((this.buscarPaginacionFormadepagoCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.buscarPaginacionFormadepagoCompleted(this, new buscarPaginacionFormadepagoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/listarFormadepago", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Formadepago[] listarFormadepago() {
            object[] results = this.Invoke("listarFormadepago", new object[0]);
            return ((Formadepago[])(results[0]));
        }
        
        /// <remarks/>
        public void listarFormadepagoAsync() {
            this.listarFormadepagoAsync(null);
        }
        
        /// <remarks/>
        public void listarFormadepagoAsync(object userState) {
            if ((this.listarFormadepagoOperationCompleted == null)) {
                this.listarFormadepagoOperationCompleted = new System.Threading.SendOrPostCallback(this.OnlistarFormadepagoOperationCompleted);
            }
            this.InvokeAsync("listarFormadepago", new object[0], this.listarFormadepagoOperationCompleted, userState);
        }
        
        private void OnlistarFormadepagoOperationCompleted(object arg) {
            if ((this.listarFormadepagoCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.listarFormadepagoCompleted(this, new listarFormadepagoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/listarPaginacionFormadepago", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Formadepago[] listarPaginacionFormadepago(int pag, int numReg) {
            object[] results = this.Invoke("listarPaginacionFormadepago", new object[] {
                        pag,
                        numReg});
            return ((Formadepago[])(results[0]));
        }
        
        /// <remarks/>
        public void listarPaginacionFormadepagoAsync(int pag, int numReg) {
            this.listarPaginacionFormadepagoAsync(pag, numReg, null);
        }
        
        /// <remarks/>
        public void listarPaginacionFormadepagoAsync(int pag, int numReg, object userState) {
            if ((this.listarPaginacionFormadepagoOperationCompleted == null)) {
                this.listarPaginacionFormadepagoOperationCompleted = new System.Threading.SendOrPostCallback(this.OnlistarPaginacionFormadepagoOperationCompleted);
            }
            this.InvokeAsync("listarPaginacionFormadepago", new object[] {
                        pag,
                        numReg}, this.listarPaginacionFormadepagoOperationCompleted, userState);
        }
        
        private void OnlistarPaginacionFormadepagoOperationCompleted(object arg) {
            if ((this.listarPaginacionFormadepagoCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.listarPaginacionFormadepagoCompleted(this, new listarPaginacionFormadepagoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/contarBusquedaFormadepago", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public int contarBusquedaFormadepago(Formadepago obj) {
            object[] results = this.Invoke("contarBusquedaFormadepago", new object[] {
                        obj});
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        public void contarBusquedaFormadepagoAsync(Formadepago obj) {
            this.contarBusquedaFormadepagoAsync(obj, null);
        }
        
        /// <remarks/>
        public void contarBusquedaFormadepagoAsync(Formadepago obj, object userState) {
            if ((this.contarBusquedaFormadepagoOperationCompleted == null)) {
                this.contarBusquedaFormadepagoOperationCompleted = new System.Threading.SendOrPostCallback(this.OncontarBusquedaFormadepagoOperationCompleted);
            }
            this.InvokeAsync("contarBusquedaFormadepago", new object[] {
                        obj}, this.contarBusquedaFormadepagoOperationCompleted, userState);
        }
        
        private void OncontarBusquedaFormadepagoOperationCompleted(object arg) {
            if ((this.contarBusquedaFormadepagoCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.contarBusquedaFormadepagoCompleted(this, new contarBusquedaFormadepagoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/eliminarFormadepago", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool eliminarFormadepago(Formadepago obj) {
            object[] results = this.Invoke("eliminarFormadepago", new object[] {
                        obj});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void eliminarFormadepagoAsync(Formadepago obj) {
            this.eliminarFormadepagoAsync(obj, null);
        }
        
        /// <remarks/>
        public void eliminarFormadepagoAsync(Formadepago obj, object userState) {
            if ((this.eliminarFormadepagoOperationCompleted == null)) {
                this.eliminarFormadepagoOperationCompleted = new System.Threading.SendOrPostCallback(this.OneliminarFormadepagoOperationCompleted);
            }
            this.InvokeAsync("eliminarFormadepago", new object[] {
                        obj}, this.eliminarFormadepagoOperationCompleted, userState);
        }
        
        private void OneliminarFormadepagoOperationCompleted(object arg) {
            if ((this.eliminarFormadepagoCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.eliminarFormadepagoCompleted(this, new eliminarFormadepagoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    public partial class Formadepago {
        
        private int idField;
        
        private string fORMA_PAGOField;
        
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
        public string FORMA_PAGO {
            get {
                return this.fORMA_PAGOField;
            }
            set {
                this.fORMA_PAGOField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    public delegate void crearFormadepagoCompletedEventHandler(object sender, crearFormadepagoCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class crearFormadepagoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal crearFormadepagoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Formadepago Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Formadepago)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    public delegate void editarFormadepagoCompletedEventHandler(object sender, editarFormadepagoCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class editarFormadepagoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal editarFormadepagoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    public delegate void buscarPrimeroFormadepagoCompletedEventHandler(object sender, buscarPrimeroFormadepagoCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class buscarPrimeroFormadepagoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal buscarPrimeroFormadepagoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Formadepago Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Formadepago)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    public delegate void buscarFormadepagoCompletedEventHandler(object sender, buscarFormadepagoCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class buscarFormadepagoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal buscarFormadepagoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Formadepago[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Formadepago[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    public delegate void buscarPaginacionFormadepagoCompletedEventHandler(object sender, buscarPaginacionFormadepagoCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class buscarPaginacionFormadepagoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal buscarPaginacionFormadepagoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Formadepago[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Formadepago[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    public delegate void listarFormadepagoCompletedEventHandler(object sender, listarFormadepagoCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class listarFormadepagoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal listarFormadepagoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Formadepago[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Formadepago[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    public delegate void listarPaginacionFormadepagoCompletedEventHandler(object sender, listarPaginacionFormadepagoCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class listarPaginacionFormadepagoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal listarPaginacionFormadepagoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Formadepago[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Formadepago[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    public delegate void contarBusquedaFormadepagoCompletedEventHandler(object sender, contarBusquedaFormadepagoCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class contarBusquedaFormadepagoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal contarBusquedaFormadepagoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public int Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((int)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    public delegate void eliminarFormadepagoCompletedEventHandler(object sender, eliminarFormadepagoCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class eliminarFormadepagoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal eliminarFormadepagoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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