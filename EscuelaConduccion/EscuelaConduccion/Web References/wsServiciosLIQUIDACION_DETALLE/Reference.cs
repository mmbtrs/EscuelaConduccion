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

namespace EscuelaConduccion.wsServiciosLIQUIDACION_DETALLE {
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
    [System.Web.Services.WebServiceBindingAttribute(Name="ServiciosLIQUIDACION_DETALLESoap", Namespace="http://tempuri.org/")]
    public partial class ServiciosLIQUIDACION_DETALLE : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback crearLIQUIDACION_DETALLEOperationCompleted;
        
        private System.Threading.SendOrPostCallback editarLIQUIDACION_DETALLEOperationCompleted;
        
        private System.Threading.SendOrPostCallback buscarPrimeroLIQUIDACION_DETALLEOperationCompleted;
        
        private System.Threading.SendOrPostCallback buscarLIQUIDACION_DETALLEOperationCompleted;
        
        private System.Threading.SendOrPostCallback listarLIQUIDACION_DETALLEOperationCompleted;
        
        private System.Threading.SendOrPostCallback eliminarLIQUIDACION_DETALLEOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public ServiciosLIQUIDACION_DETALLE() {
            this.Url = global::EscuelaConduccion.Properties.Settings.Default.EscuelaConduccion_wsServiciosLIQUIDACION_DETALLE_ServiciosLIQUIDACION_DETALLE;
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
        public event crearLIQUIDACION_DETALLECompletedEventHandler crearLIQUIDACION_DETALLECompleted;
        
        /// <remarks/>
        public event editarLIQUIDACION_DETALLECompletedEventHandler editarLIQUIDACION_DETALLECompleted;
        
        /// <remarks/>
        public event buscarPrimeroLIQUIDACION_DETALLECompletedEventHandler buscarPrimeroLIQUIDACION_DETALLECompleted;
        
        /// <remarks/>
        public event buscarLIQUIDACION_DETALLECompletedEventHandler buscarLIQUIDACION_DETALLECompleted;
        
        /// <remarks/>
        public event listarLIQUIDACION_DETALLECompletedEventHandler listarLIQUIDACION_DETALLECompleted;
        
        /// <remarks/>
        public event eliminarLIQUIDACION_DETALLECompletedEventHandler eliminarLIQUIDACION_DETALLECompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/crearLIQUIDACION_DETALLE", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public LIQUIDACION_DETALLE crearLIQUIDACION_DETALLE(LIQUIDACION_DETALLE obj) {
            object[] results = this.Invoke("crearLIQUIDACION_DETALLE", new object[] {
                        obj});
            return ((LIQUIDACION_DETALLE)(results[0]));
        }
        
        /// <remarks/>
        public void crearLIQUIDACION_DETALLEAsync(LIQUIDACION_DETALLE obj) {
            this.crearLIQUIDACION_DETALLEAsync(obj, null);
        }
        
        /// <remarks/>
        public void crearLIQUIDACION_DETALLEAsync(LIQUIDACION_DETALLE obj, object userState) {
            if ((this.crearLIQUIDACION_DETALLEOperationCompleted == null)) {
                this.crearLIQUIDACION_DETALLEOperationCompleted = new System.Threading.SendOrPostCallback(this.OncrearLIQUIDACION_DETALLEOperationCompleted);
            }
            this.InvokeAsync("crearLIQUIDACION_DETALLE", new object[] {
                        obj}, this.crearLIQUIDACION_DETALLEOperationCompleted, userState);
        }
        
        private void OncrearLIQUIDACION_DETALLEOperationCompleted(object arg) {
            if ((this.crearLIQUIDACION_DETALLECompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.crearLIQUIDACION_DETALLECompleted(this, new crearLIQUIDACION_DETALLECompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/editarLIQUIDACION_DETALLE", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool editarLIQUIDACION_DETALLE(LIQUIDACION_DETALLE obj) {
            object[] results = this.Invoke("editarLIQUIDACION_DETALLE", new object[] {
                        obj});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void editarLIQUIDACION_DETALLEAsync(LIQUIDACION_DETALLE obj) {
            this.editarLIQUIDACION_DETALLEAsync(obj, null);
        }
        
        /// <remarks/>
        public void editarLIQUIDACION_DETALLEAsync(LIQUIDACION_DETALLE obj, object userState) {
            if ((this.editarLIQUIDACION_DETALLEOperationCompleted == null)) {
                this.editarLIQUIDACION_DETALLEOperationCompleted = new System.Threading.SendOrPostCallback(this.OneditarLIQUIDACION_DETALLEOperationCompleted);
            }
            this.InvokeAsync("editarLIQUIDACION_DETALLE", new object[] {
                        obj}, this.editarLIQUIDACION_DETALLEOperationCompleted, userState);
        }
        
        private void OneditarLIQUIDACION_DETALLEOperationCompleted(object arg) {
            if ((this.editarLIQUIDACION_DETALLECompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.editarLIQUIDACION_DETALLECompleted(this, new editarLIQUIDACION_DETALLECompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/buscarPrimeroLIQUIDACION_DETALLE", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public LIQUIDACION_DETALLE buscarPrimeroLIQUIDACION_DETALLE(LIQUIDACION_DETALLE obj) {
            object[] results = this.Invoke("buscarPrimeroLIQUIDACION_DETALLE", new object[] {
                        obj});
            return ((LIQUIDACION_DETALLE)(results[0]));
        }
        
        /// <remarks/>
        public void buscarPrimeroLIQUIDACION_DETALLEAsync(LIQUIDACION_DETALLE obj) {
            this.buscarPrimeroLIQUIDACION_DETALLEAsync(obj, null);
        }
        
        /// <remarks/>
        public void buscarPrimeroLIQUIDACION_DETALLEAsync(LIQUIDACION_DETALLE obj, object userState) {
            if ((this.buscarPrimeroLIQUIDACION_DETALLEOperationCompleted == null)) {
                this.buscarPrimeroLIQUIDACION_DETALLEOperationCompleted = new System.Threading.SendOrPostCallback(this.OnbuscarPrimeroLIQUIDACION_DETALLEOperationCompleted);
            }
            this.InvokeAsync("buscarPrimeroLIQUIDACION_DETALLE", new object[] {
                        obj}, this.buscarPrimeroLIQUIDACION_DETALLEOperationCompleted, userState);
        }
        
        private void OnbuscarPrimeroLIQUIDACION_DETALLEOperationCompleted(object arg) {
            if ((this.buscarPrimeroLIQUIDACION_DETALLECompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.buscarPrimeroLIQUIDACION_DETALLECompleted(this, new buscarPrimeroLIQUIDACION_DETALLECompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/buscarLIQUIDACION_DETALLE", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public LIQUIDACION_DETALLE[] buscarLIQUIDACION_DETALLE(LIQUIDACION_DETALLE obj) {
            object[] results = this.Invoke("buscarLIQUIDACION_DETALLE", new object[] {
                        obj});
            return ((LIQUIDACION_DETALLE[])(results[0]));
        }
        
        /// <remarks/>
        public void buscarLIQUIDACION_DETALLEAsync(LIQUIDACION_DETALLE obj) {
            this.buscarLIQUIDACION_DETALLEAsync(obj, null);
        }
        
        /// <remarks/>
        public void buscarLIQUIDACION_DETALLEAsync(LIQUIDACION_DETALLE obj, object userState) {
            if ((this.buscarLIQUIDACION_DETALLEOperationCompleted == null)) {
                this.buscarLIQUIDACION_DETALLEOperationCompleted = new System.Threading.SendOrPostCallback(this.OnbuscarLIQUIDACION_DETALLEOperationCompleted);
            }
            this.InvokeAsync("buscarLIQUIDACION_DETALLE", new object[] {
                        obj}, this.buscarLIQUIDACION_DETALLEOperationCompleted, userState);
        }
        
        private void OnbuscarLIQUIDACION_DETALLEOperationCompleted(object arg) {
            if ((this.buscarLIQUIDACION_DETALLECompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.buscarLIQUIDACION_DETALLECompleted(this, new buscarLIQUIDACION_DETALLECompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/listarLIQUIDACION_DETALLE", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public LIQUIDACION_DETALLE[] listarLIQUIDACION_DETALLE() {
            object[] results = this.Invoke("listarLIQUIDACION_DETALLE", new object[0]);
            return ((LIQUIDACION_DETALLE[])(results[0]));
        }
        
        /// <remarks/>
        public void listarLIQUIDACION_DETALLEAsync() {
            this.listarLIQUIDACION_DETALLEAsync(null);
        }
        
        /// <remarks/>
        public void listarLIQUIDACION_DETALLEAsync(object userState) {
            if ((this.listarLIQUIDACION_DETALLEOperationCompleted == null)) {
                this.listarLIQUIDACION_DETALLEOperationCompleted = new System.Threading.SendOrPostCallback(this.OnlistarLIQUIDACION_DETALLEOperationCompleted);
            }
            this.InvokeAsync("listarLIQUIDACION_DETALLE", new object[0], this.listarLIQUIDACION_DETALLEOperationCompleted, userState);
        }
        
        private void OnlistarLIQUIDACION_DETALLEOperationCompleted(object arg) {
            if ((this.listarLIQUIDACION_DETALLECompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.listarLIQUIDACION_DETALLECompleted(this, new listarLIQUIDACION_DETALLECompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/eliminarLIQUIDACION_DETALLE", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool eliminarLIQUIDACION_DETALLE(LIQUIDACION_DETALLE obj) {
            object[] results = this.Invoke("eliminarLIQUIDACION_DETALLE", new object[] {
                        obj});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void eliminarLIQUIDACION_DETALLEAsync(LIQUIDACION_DETALLE obj) {
            this.eliminarLIQUIDACION_DETALLEAsync(obj, null);
        }
        
        /// <remarks/>
        public void eliminarLIQUIDACION_DETALLEAsync(LIQUIDACION_DETALLE obj, object userState) {
            if ((this.eliminarLIQUIDACION_DETALLEOperationCompleted == null)) {
                this.eliminarLIQUIDACION_DETALLEOperationCompleted = new System.Threading.SendOrPostCallback(this.OneliminarLIQUIDACION_DETALLEOperationCompleted);
            }
            this.InvokeAsync("eliminarLIQUIDACION_DETALLE", new object[] {
                        obj}, this.eliminarLIQUIDACION_DETALLEOperationCompleted, userState);
        }
        
        private void OneliminarLIQUIDACION_DETALLEOperationCompleted(object arg) {
            if ((this.eliminarLIQUIDACION_DETALLECompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.eliminarLIQUIDACION_DETALLECompleted(this, new eliminarLIQUIDACION_DETALLECompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    public partial class LIQUIDACION_DETALLE {
        
        private int idField;
        
        private int iD_LIQUIDACIONField;
        
        private int iD_TARIFA_DETALLEField;
        
        private float vALOR_CONCEPTOField;
        
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
        public int ID_LIQUIDACION {
            get {
                return this.iD_LIQUIDACIONField;
            }
            set {
                this.iD_LIQUIDACIONField = value;
            }
        }
        
        /// <remarks/>
        public int ID_TARIFA_DETALLE {
            get {
                return this.iD_TARIFA_DETALLEField;
            }
            set {
                this.iD_TARIFA_DETALLEField = value;
            }
        }
        
        /// <remarks/>
        public float VALOR_CONCEPTO {
            get {
                return this.vALOR_CONCEPTOField;
            }
            set {
                this.vALOR_CONCEPTOField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    public delegate void crearLIQUIDACION_DETALLECompletedEventHandler(object sender, crearLIQUIDACION_DETALLECompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class crearLIQUIDACION_DETALLECompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal crearLIQUIDACION_DETALLECompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public LIQUIDACION_DETALLE Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((LIQUIDACION_DETALLE)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    public delegate void editarLIQUIDACION_DETALLECompletedEventHandler(object sender, editarLIQUIDACION_DETALLECompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class editarLIQUIDACION_DETALLECompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal editarLIQUIDACION_DETALLECompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    public delegate void buscarPrimeroLIQUIDACION_DETALLECompletedEventHandler(object sender, buscarPrimeroLIQUIDACION_DETALLECompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class buscarPrimeroLIQUIDACION_DETALLECompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal buscarPrimeroLIQUIDACION_DETALLECompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public LIQUIDACION_DETALLE Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((LIQUIDACION_DETALLE)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    public delegate void buscarLIQUIDACION_DETALLECompletedEventHandler(object sender, buscarLIQUIDACION_DETALLECompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class buscarLIQUIDACION_DETALLECompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal buscarLIQUIDACION_DETALLECompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public LIQUIDACION_DETALLE[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((LIQUIDACION_DETALLE[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    public delegate void listarLIQUIDACION_DETALLECompletedEventHandler(object sender, listarLIQUIDACION_DETALLECompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class listarLIQUIDACION_DETALLECompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal listarLIQUIDACION_DETALLECompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public LIQUIDACION_DETALLE[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((LIQUIDACION_DETALLE[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    public delegate void eliminarLIQUIDACION_DETALLECompletedEventHandler(object sender, eliminarLIQUIDACION_DETALLECompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class eliminarLIQUIDACION_DETALLECompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal eliminarLIQUIDACION_DETALLECompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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