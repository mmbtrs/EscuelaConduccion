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

namespace EscuelaConduccion.wsServiciosCLIENTE {
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
    [System.Web.Services.WebServiceBindingAttribute(Name="ServiciosCLIENTESoap", Namespace="http://tempuri.org/")]
    public partial class ServiciosCLIENTE : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback crearCLIENTEOperationCompleted;
        
        private System.Threading.SendOrPostCallback editarCLIENTEOperationCompleted;
        
        private System.Threading.SendOrPostCallback buscarPrimeroCLIENTEOperationCompleted;
        
        private System.Threading.SendOrPostCallback buscarCLIENTEOperationCompleted;
        
        private System.Threading.SendOrPostCallback listarCLIENTEOperationCompleted;
        
        private System.Threading.SendOrPostCallback eliminarCLIENTEOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public ServiciosCLIENTE() {
            this.Url = global::EscuelaConduccion.Properties.Settings.Default.EscuelaConduccion_wsServiciosCLIENTE_ServiciosCLIENTE;
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
        public event crearCLIENTECompletedEventHandler crearCLIENTECompleted;
        
        /// <remarks/>
        public event editarCLIENTECompletedEventHandler editarCLIENTECompleted;
        
        /// <remarks/>
        public event buscarPrimeroCLIENTECompletedEventHandler buscarPrimeroCLIENTECompleted;
        
        /// <remarks/>
        public event buscarCLIENTECompletedEventHandler buscarCLIENTECompleted;
        
        /// <remarks/>
        public event listarCLIENTECompletedEventHandler listarCLIENTECompleted;
        
        /// <remarks/>
        public event eliminarCLIENTECompletedEventHandler eliminarCLIENTECompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/crearCLIENTE", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public CLIENTE crearCLIENTE(CLIENTE obj) {
            object[] results = this.Invoke("crearCLIENTE", new object[] {
                        obj});
            return ((CLIENTE)(results[0]));
        }
        
        /// <remarks/>
        public void crearCLIENTEAsync(CLIENTE obj) {
            this.crearCLIENTEAsync(obj, null);
        }
        
        /// <remarks/>
        public void crearCLIENTEAsync(CLIENTE obj, object userState) {
            if ((this.crearCLIENTEOperationCompleted == null)) {
                this.crearCLIENTEOperationCompleted = new System.Threading.SendOrPostCallback(this.OncrearCLIENTEOperationCompleted);
            }
            this.InvokeAsync("crearCLIENTE", new object[] {
                        obj}, this.crearCLIENTEOperationCompleted, userState);
        }
        
        private void OncrearCLIENTEOperationCompleted(object arg) {
            if ((this.crearCLIENTECompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.crearCLIENTECompleted(this, new crearCLIENTECompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/editarCLIENTE", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool editarCLIENTE(CLIENTE obj) {
            object[] results = this.Invoke("editarCLIENTE", new object[] {
                        obj});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void editarCLIENTEAsync(CLIENTE obj) {
            this.editarCLIENTEAsync(obj, null);
        }
        
        /// <remarks/>
        public void editarCLIENTEAsync(CLIENTE obj, object userState) {
            if ((this.editarCLIENTEOperationCompleted == null)) {
                this.editarCLIENTEOperationCompleted = new System.Threading.SendOrPostCallback(this.OneditarCLIENTEOperationCompleted);
            }
            this.InvokeAsync("editarCLIENTE", new object[] {
                        obj}, this.editarCLIENTEOperationCompleted, userState);
        }
        
        private void OneditarCLIENTEOperationCompleted(object arg) {
            if ((this.editarCLIENTECompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.editarCLIENTECompleted(this, new editarCLIENTECompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/buscarPrimeroCLIENTE", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public CLIENTE buscarPrimeroCLIENTE(CLIENTE obj) {
            object[] results = this.Invoke("buscarPrimeroCLIENTE", new object[] {
                        obj});
            return ((CLIENTE)(results[0]));
        }
        
        /// <remarks/>
        public void buscarPrimeroCLIENTEAsync(CLIENTE obj) {
            this.buscarPrimeroCLIENTEAsync(obj, null);
        }
        
        /// <remarks/>
        public void buscarPrimeroCLIENTEAsync(CLIENTE obj, object userState) {
            if ((this.buscarPrimeroCLIENTEOperationCompleted == null)) {
                this.buscarPrimeroCLIENTEOperationCompleted = new System.Threading.SendOrPostCallback(this.OnbuscarPrimeroCLIENTEOperationCompleted);
            }
            this.InvokeAsync("buscarPrimeroCLIENTE", new object[] {
                        obj}, this.buscarPrimeroCLIENTEOperationCompleted, userState);
        }
        
        private void OnbuscarPrimeroCLIENTEOperationCompleted(object arg) {
            if ((this.buscarPrimeroCLIENTECompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.buscarPrimeroCLIENTECompleted(this, new buscarPrimeroCLIENTECompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/buscarCLIENTE", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public CLIENTE[] buscarCLIENTE(CLIENTE obj) {
            object[] results = this.Invoke("buscarCLIENTE", new object[] {
                        obj});
            return ((CLIENTE[])(results[0]));
        }
        
        /// <remarks/>
        public void buscarCLIENTEAsync(CLIENTE obj) {
            this.buscarCLIENTEAsync(obj, null);
        }
        
        /// <remarks/>
        public void buscarCLIENTEAsync(CLIENTE obj, object userState) {
            if ((this.buscarCLIENTEOperationCompleted == null)) {
                this.buscarCLIENTEOperationCompleted = new System.Threading.SendOrPostCallback(this.OnbuscarCLIENTEOperationCompleted);
            }
            this.InvokeAsync("buscarCLIENTE", new object[] {
                        obj}, this.buscarCLIENTEOperationCompleted, userState);
        }
        
        private void OnbuscarCLIENTEOperationCompleted(object arg) {
            if ((this.buscarCLIENTECompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.buscarCLIENTECompleted(this, new buscarCLIENTECompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/listarCLIENTE", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public CLIENTE[] listarCLIENTE() {
            object[] results = this.Invoke("listarCLIENTE", new object[0]);
            return ((CLIENTE[])(results[0]));
        }
        
        /// <remarks/>
        public void listarCLIENTEAsync() {
            this.listarCLIENTEAsync(null);
        }
        
        /// <remarks/>
        public void listarCLIENTEAsync(object userState) {
            if ((this.listarCLIENTEOperationCompleted == null)) {
                this.listarCLIENTEOperationCompleted = new System.Threading.SendOrPostCallback(this.OnlistarCLIENTEOperationCompleted);
            }
            this.InvokeAsync("listarCLIENTE", new object[0], this.listarCLIENTEOperationCompleted, userState);
        }
        
        private void OnlistarCLIENTEOperationCompleted(object arg) {
            if ((this.listarCLIENTECompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.listarCLIENTECompleted(this, new listarCLIENTECompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/eliminarCLIENTE", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool eliminarCLIENTE(CLIENTE obj) {
            object[] results = this.Invoke("eliminarCLIENTE", new object[] {
                        obj});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void eliminarCLIENTEAsync(CLIENTE obj) {
            this.eliminarCLIENTEAsync(obj, null);
        }
        
        /// <remarks/>
        public void eliminarCLIENTEAsync(CLIENTE obj, object userState) {
            if ((this.eliminarCLIENTEOperationCompleted == null)) {
                this.eliminarCLIENTEOperationCompleted = new System.Threading.SendOrPostCallback(this.OneliminarCLIENTEOperationCompleted);
            }
            this.InvokeAsync("eliminarCLIENTE", new object[] {
                        obj}, this.eliminarCLIENTEOperationCompleted, userState);
        }
        
        private void OneliminarCLIENTEOperationCompleted(object arg) {
            if ((this.eliminarCLIENTECompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.eliminarCLIENTECompleted(this, new eliminarCLIENTECompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    public partial class CLIENTE {
        
        private int idField;
        
        private int iD_GENEROField;
        
        private int iD_CIUDADField;
        
        private int iD_TIPO_DOCUMENTOField;
        
        private string iDENTIFICACIONField;
        
        private string nOMBRESField;
        
        private string aPELLIDOSField;
        
        private string dIRECCIONField;
        
        private string tELEFONOField;
        
        private string cELULARField;
        
        private string cORREOField;
        
        private System.DateTime fECHA_NACIMIENTOField;
        
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
        public int ID_GENERO {
            get {
                return this.iD_GENEROField;
            }
            set {
                this.iD_GENEROField = value;
            }
        }
        
        /// <remarks/>
        public int ID_CIUDAD {
            get {
                return this.iD_CIUDADField;
            }
            set {
                this.iD_CIUDADField = value;
            }
        }
        
        /// <remarks/>
        public int ID_TIPO_DOCUMENTO {
            get {
                return this.iD_TIPO_DOCUMENTOField;
            }
            set {
                this.iD_TIPO_DOCUMENTOField = value;
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
        public System.DateTime FECHA_NACIMIENTO {
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
    public delegate void crearCLIENTECompletedEventHandler(object sender, crearCLIENTECompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class crearCLIENTECompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal crearCLIENTECompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public CLIENTE Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((CLIENTE)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    public delegate void editarCLIENTECompletedEventHandler(object sender, editarCLIENTECompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class editarCLIENTECompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal editarCLIENTECompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    public delegate void buscarPrimeroCLIENTECompletedEventHandler(object sender, buscarPrimeroCLIENTECompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class buscarPrimeroCLIENTECompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal buscarPrimeroCLIENTECompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public CLIENTE Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((CLIENTE)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    public delegate void buscarCLIENTECompletedEventHandler(object sender, buscarCLIENTECompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class buscarCLIENTECompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal buscarCLIENTECompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public CLIENTE[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((CLIENTE[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    public delegate void listarCLIENTECompletedEventHandler(object sender, listarCLIENTECompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class listarCLIENTECompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal listarCLIENTECompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public CLIENTE[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((CLIENTE[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    public delegate void eliminarCLIENTECompletedEventHandler(object sender, eliminarCLIENTECompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class eliminarCLIENTECompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal eliminarCLIENTECompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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