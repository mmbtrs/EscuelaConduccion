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

namespace EscuelaConduccion.wsServiciosVIEW_CLIENTE {
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
    [System.Web.Services.WebServiceBindingAttribute(Name="ServiciosVIEW_CLIENTESoap", Namespace="http://tempuri.org/")]
    public partial class ServiciosVIEW_CLIENTE : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback crearVIEW_CLIENTEOperationCompleted;
        
        private System.Threading.SendOrPostCallback editarVIEW_CLIENTEOperationCompleted;
        
        private System.Threading.SendOrPostCallback buscarPrimeroVIEW_CLIENTEOperationCompleted;
        
        private System.Threading.SendOrPostCallback buscarVIEW_CLIENTEOperationCompleted;
        
        private System.Threading.SendOrPostCallback listarVIEW_CLIENTEOperationCompleted;
        
        private System.Threading.SendOrPostCallback eliminarVIEW_CLIENTEOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public ServiciosVIEW_CLIENTE() {
            this.Url = global::EscuelaConduccion.Properties.Settings.Default.EscuelaConduccion_wsServiciosVIEW_CLIENTE_ServiciosVIEW_CLIENTE;
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
        public event crearVIEW_CLIENTECompletedEventHandler crearVIEW_CLIENTECompleted;
        
        /// <remarks/>
        public event editarVIEW_CLIENTECompletedEventHandler editarVIEW_CLIENTECompleted;
        
        /// <remarks/>
        public event buscarPrimeroVIEW_CLIENTECompletedEventHandler buscarPrimeroVIEW_CLIENTECompleted;
        
        /// <remarks/>
        public event buscarVIEW_CLIENTECompletedEventHandler buscarVIEW_CLIENTECompleted;
        
        /// <remarks/>
        public event listarVIEW_CLIENTECompletedEventHandler listarVIEW_CLIENTECompleted;
        
        /// <remarks/>
        public event eliminarVIEW_CLIENTECompletedEventHandler eliminarVIEW_CLIENTECompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/crearVIEW_CLIENTE", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public VIEW_CLIENTE crearVIEW_CLIENTE(VIEW_CLIENTE obj) {
            object[] results = this.Invoke("crearVIEW_CLIENTE", new object[] {
                        obj});
            return ((VIEW_CLIENTE)(results[0]));
        }
        
        /// <remarks/>
        public void crearVIEW_CLIENTEAsync(VIEW_CLIENTE obj) {
            this.crearVIEW_CLIENTEAsync(obj, null);
        }
        
        /// <remarks/>
        public void crearVIEW_CLIENTEAsync(VIEW_CLIENTE obj, object userState) {
            if ((this.crearVIEW_CLIENTEOperationCompleted == null)) {
                this.crearVIEW_CLIENTEOperationCompleted = new System.Threading.SendOrPostCallback(this.OncrearVIEW_CLIENTEOperationCompleted);
            }
            this.InvokeAsync("crearVIEW_CLIENTE", new object[] {
                        obj}, this.crearVIEW_CLIENTEOperationCompleted, userState);
        }
        
        private void OncrearVIEW_CLIENTEOperationCompleted(object arg) {
            if ((this.crearVIEW_CLIENTECompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.crearVIEW_CLIENTECompleted(this, new crearVIEW_CLIENTECompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/editarVIEW_CLIENTE", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool editarVIEW_CLIENTE(VIEW_CLIENTE obj) {
            object[] results = this.Invoke("editarVIEW_CLIENTE", new object[] {
                        obj});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void editarVIEW_CLIENTEAsync(VIEW_CLIENTE obj) {
            this.editarVIEW_CLIENTEAsync(obj, null);
        }
        
        /// <remarks/>
        public void editarVIEW_CLIENTEAsync(VIEW_CLIENTE obj, object userState) {
            if ((this.editarVIEW_CLIENTEOperationCompleted == null)) {
                this.editarVIEW_CLIENTEOperationCompleted = new System.Threading.SendOrPostCallback(this.OneditarVIEW_CLIENTEOperationCompleted);
            }
            this.InvokeAsync("editarVIEW_CLIENTE", new object[] {
                        obj}, this.editarVIEW_CLIENTEOperationCompleted, userState);
        }
        
        private void OneditarVIEW_CLIENTEOperationCompleted(object arg) {
            if ((this.editarVIEW_CLIENTECompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.editarVIEW_CLIENTECompleted(this, new editarVIEW_CLIENTECompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/buscarPrimeroVIEW_CLIENTE", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public VIEW_CLIENTE buscarPrimeroVIEW_CLIENTE(VIEW_CLIENTE obj) {
            object[] results = this.Invoke("buscarPrimeroVIEW_CLIENTE", new object[] {
                        obj});
            return ((VIEW_CLIENTE)(results[0]));
        }
        
        /// <remarks/>
        public void buscarPrimeroVIEW_CLIENTEAsync(VIEW_CLIENTE obj) {
            this.buscarPrimeroVIEW_CLIENTEAsync(obj, null);
        }
        
        /// <remarks/>
        public void buscarPrimeroVIEW_CLIENTEAsync(VIEW_CLIENTE obj, object userState) {
            if ((this.buscarPrimeroVIEW_CLIENTEOperationCompleted == null)) {
                this.buscarPrimeroVIEW_CLIENTEOperationCompleted = new System.Threading.SendOrPostCallback(this.OnbuscarPrimeroVIEW_CLIENTEOperationCompleted);
            }
            this.InvokeAsync("buscarPrimeroVIEW_CLIENTE", new object[] {
                        obj}, this.buscarPrimeroVIEW_CLIENTEOperationCompleted, userState);
        }
        
        private void OnbuscarPrimeroVIEW_CLIENTEOperationCompleted(object arg) {
            if ((this.buscarPrimeroVIEW_CLIENTECompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.buscarPrimeroVIEW_CLIENTECompleted(this, new buscarPrimeroVIEW_CLIENTECompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/buscarVIEW_CLIENTE", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public VIEW_CLIENTE[] buscarVIEW_CLIENTE(VIEW_CLIENTE obj) {
            object[] results = this.Invoke("buscarVIEW_CLIENTE", new object[] {
                        obj});
            return ((VIEW_CLIENTE[])(results[0]));
        }
        
        /// <remarks/>
        public void buscarVIEW_CLIENTEAsync(VIEW_CLIENTE obj) {
            this.buscarVIEW_CLIENTEAsync(obj, null);
        }
        
        /// <remarks/>
        public void buscarVIEW_CLIENTEAsync(VIEW_CLIENTE obj, object userState) {
            if ((this.buscarVIEW_CLIENTEOperationCompleted == null)) {
                this.buscarVIEW_CLIENTEOperationCompleted = new System.Threading.SendOrPostCallback(this.OnbuscarVIEW_CLIENTEOperationCompleted);
            }
            this.InvokeAsync("buscarVIEW_CLIENTE", new object[] {
                        obj}, this.buscarVIEW_CLIENTEOperationCompleted, userState);
        }
        
        private void OnbuscarVIEW_CLIENTEOperationCompleted(object arg) {
            if ((this.buscarVIEW_CLIENTECompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.buscarVIEW_CLIENTECompleted(this, new buscarVIEW_CLIENTECompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/listarVIEW_CLIENTE", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public VIEW_CLIENTE[] listarVIEW_CLIENTE() {
            object[] results = this.Invoke("listarVIEW_CLIENTE", new object[0]);
            return ((VIEW_CLIENTE[])(results[0]));
        }
        
        /// <remarks/>
        public void listarVIEW_CLIENTEAsync() {
            this.listarVIEW_CLIENTEAsync(null);
        }
        
        /// <remarks/>
        public void listarVIEW_CLIENTEAsync(object userState) {
            if ((this.listarVIEW_CLIENTEOperationCompleted == null)) {
                this.listarVIEW_CLIENTEOperationCompleted = new System.Threading.SendOrPostCallback(this.OnlistarVIEW_CLIENTEOperationCompleted);
            }
            this.InvokeAsync("listarVIEW_CLIENTE", new object[0], this.listarVIEW_CLIENTEOperationCompleted, userState);
        }
        
        private void OnlistarVIEW_CLIENTEOperationCompleted(object arg) {
            if ((this.listarVIEW_CLIENTECompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.listarVIEW_CLIENTECompleted(this, new listarVIEW_CLIENTECompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/eliminarVIEW_CLIENTE", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool eliminarVIEW_CLIENTE(VIEW_CLIENTE obj) {
            object[] results = this.Invoke("eliminarVIEW_CLIENTE", new object[] {
                        obj});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void eliminarVIEW_CLIENTEAsync(VIEW_CLIENTE obj) {
            this.eliminarVIEW_CLIENTEAsync(obj, null);
        }
        
        /// <remarks/>
        public void eliminarVIEW_CLIENTEAsync(VIEW_CLIENTE obj, object userState) {
            if ((this.eliminarVIEW_CLIENTEOperationCompleted == null)) {
                this.eliminarVIEW_CLIENTEOperationCompleted = new System.Threading.SendOrPostCallback(this.OneliminarVIEW_CLIENTEOperationCompleted);
            }
            this.InvokeAsync("eliminarVIEW_CLIENTE", new object[] {
                        obj}, this.eliminarVIEW_CLIENTEOperationCompleted, userState);
        }
        
        private void OneliminarVIEW_CLIENTEOperationCompleted(object arg) {
            if ((this.eliminarVIEW_CLIENTECompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.eliminarVIEW_CLIENTECompleted(this, new eliminarVIEW_CLIENTECompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    public partial class VIEW_CLIENTE {
        
        private int idField;
        
        private string tIPO_DOCUMENTOField;
        
        private string iDENTIFICACIONField;
        
        private string nOMBRESField;
        
        private string aPELLIDOSField;
        
        private string dIRECCIONField;
        
        private string cIUDADField;
        
        private string dEPARTAMENTOField;
        
        private string gENEROField;
        
        private string tELEFONOField;
        
        private string cELULARField;
        
        private string cORREOField;
        
        private string fECHA_NACIMIENTOField;
        
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
        public string TIPO_DOCUMENTO {
            get {
                return this.tIPO_DOCUMENTOField;
            }
            set {
                this.tIPO_DOCUMENTOField = value;
            }
        }
        
        /// <remarks/>
        public string IDENTIFICACION {
            get {
                return this.iDENTIFICACIONField;
            }
            set {
                this.iDENTIFICACIONField = value;
            }
        }
        
        /// <remarks/>
        public string NOMBRES {
            get {
                return this.nOMBRESField;
            }
            set {
                this.nOMBRESField = value;
            }
        }
        
        /// <remarks/>
        public string APELLIDOS {
            get {
                return this.aPELLIDOSField;
            }
            set {
                this.aPELLIDOSField = value;
            }
        }
        
        /// <remarks/>
        public string DIRECCION {
            get {
                return this.dIRECCIONField;
            }
            set {
                this.dIRECCIONField = value;
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
        public string GENERO {
            get {
                return this.gENEROField;
            }
            set {
                this.gENEROField = value;
            }
        }
        
        /// <remarks/>
        public string TELEFONO {
            get {
                return this.tELEFONOField;
            }
            set {
                this.tELEFONOField = value;
            }
        }
        
        /// <remarks/>
        public string CELULAR {
            get {
                return this.cELULARField;
            }
            set {
                this.cELULARField = value;
            }
        }
        
        /// <remarks/>
        public string CORREO {
            get {
                return this.cORREOField;
            }
            set {
                this.cORREOField = value;
            }
        }
        
        /// <remarks/>
        public string FECHA_NACIMIENTO {
            get {
                return this.fECHA_NACIMIENTOField;
            }
            set {
                this.fECHA_NACIMIENTOField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    public delegate void crearVIEW_CLIENTECompletedEventHandler(object sender, crearVIEW_CLIENTECompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class crearVIEW_CLIENTECompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal crearVIEW_CLIENTECompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public VIEW_CLIENTE Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((VIEW_CLIENTE)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    public delegate void editarVIEW_CLIENTECompletedEventHandler(object sender, editarVIEW_CLIENTECompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class editarVIEW_CLIENTECompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal editarVIEW_CLIENTECompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    public delegate void buscarPrimeroVIEW_CLIENTECompletedEventHandler(object sender, buscarPrimeroVIEW_CLIENTECompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class buscarPrimeroVIEW_CLIENTECompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal buscarPrimeroVIEW_CLIENTECompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public VIEW_CLIENTE Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((VIEW_CLIENTE)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    public delegate void buscarVIEW_CLIENTECompletedEventHandler(object sender, buscarVIEW_CLIENTECompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class buscarVIEW_CLIENTECompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal buscarVIEW_CLIENTECompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public VIEW_CLIENTE[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((VIEW_CLIENTE[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    public delegate void listarVIEW_CLIENTECompletedEventHandler(object sender, listarVIEW_CLIENTECompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class listarVIEW_CLIENTECompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal listarVIEW_CLIENTECompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public VIEW_CLIENTE[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((VIEW_CLIENTE[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    public delegate void eliminarVIEW_CLIENTECompletedEventHandler(object sender, eliminarVIEW_CLIENTECompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class eliminarVIEW_CLIENTECompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal eliminarVIEW_CLIENTECompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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