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

namespace EscuelaConduccion.wsServiciosFACTURACONSECUTIVO {
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
    [System.Web.Services.WebServiceBindingAttribute(Name="ServiciosFACTURACONSECUTIVOSoap", Namespace="http://tempuri.org/")]
    public partial class ServiciosFACTURACONSECUTIVO : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback crearFACTURACONSECUTIVOOperationCompleted;
        
        private System.Threading.SendOrPostCallback editarFACTURACONSECUTIVOOperationCompleted;
        
        private System.Threading.SendOrPostCallback buscarPrimeroFACTURACONSECUTIVOOperationCompleted;
        
        private System.Threading.SendOrPostCallback buscarFACTURACONSECUTIVOOperationCompleted;
        
        private System.Threading.SendOrPostCallback listarFACTURACONSECUTIVOOperationCompleted;
        
        private System.Threading.SendOrPostCallback eliminarFACTURACONSECUTIVOOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public ServiciosFACTURACONSECUTIVO() {
            this.Url = global::EscuelaConduccion.Properties.Settings.Default.EscuelaConduccion_wsServiciosFACTURACONSECUTIVO_ServiciosFACTURACONSECUTIVO;
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
        public event crearFACTURACONSECUTIVOCompletedEventHandler crearFACTURACONSECUTIVOCompleted;
        
        /// <remarks/>
        public event editarFACTURACONSECUTIVOCompletedEventHandler editarFACTURACONSECUTIVOCompleted;
        
        /// <remarks/>
        public event buscarPrimeroFACTURACONSECUTIVOCompletedEventHandler buscarPrimeroFACTURACONSECUTIVOCompleted;
        
        /// <remarks/>
        public event buscarFACTURACONSECUTIVOCompletedEventHandler buscarFACTURACONSECUTIVOCompleted;
        
        /// <remarks/>
        public event listarFACTURACONSECUTIVOCompletedEventHandler listarFACTURACONSECUTIVOCompleted;
        
        /// <remarks/>
        public event eliminarFACTURACONSECUTIVOCompletedEventHandler eliminarFACTURACONSECUTIVOCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/crearFACTURACONSECUTIVO", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public FACTURACONSECUTIVO crearFACTURACONSECUTIVO(FACTURACONSECUTIVO obj) {
            object[] results = this.Invoke("crearFACTURACONSECUTIVO", new object[] {
                        obj});
            return ((FACTURACONSECUTIVO)(results[0]));
        }
        
        /// <remarks/>
        public void crearFACTURACONSECUTIVOAsync(FACTURACONSECUTIVO obj) {
            this.crearFACTURACONSECUTIVOAsync(obj, null);
        }
        
        /// <remarks/>
        public void crearFACTURACONSECUTIVOAsync(FACTURACONSECUTIVO obj, object userState) {
            if ((this.crearFACTURACONSECUTIVOOperationCompleted == null)) {
                this.crearFACTURACONSECUTIVOOperationCompleted = new System.Threading.SendOrPostCallback(this.OncrearFACTURACONSECUTIVOOperationCompleted);
            }
            this.InvokeAsync("crearFACTURACONSECUTIVO", new object[] {
                        obj}, this.crearFACTURACONSECUTIVOOperationCompleted, userState);
        }
        
        private void OncrearFACTURACONSECUTIVOOperationCompleted(object arg) {
            if ((this.crearFACTURACONSECUTIVOCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.crearFACTURACONSECUTIVOCompleted(this, new crearFACTURACONSECUTIVOCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/editarFACTURACONSECUTIVO", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool editarFACTURACONSECUTIVO(FACTURACONSECUTIVO obj) {
            object[] results = this.Invoke("editarFACTURACONSECUTIVO", new object[] {
                        obj});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void editarFACTURACONSECUTIVOAsync(FACTURACONSECUTIVO obj) {
            this.editarFACTURACONSECUTIVOAsync(obj, null);
        }
        
        /// <remarks/>
        public void editarFACTURACONSECUTIVOAsync(FACTURACONSECUTIVO obj, object userState) {
            if ((this.editarFACTURACONSECUTIVOOperationCompleted == null)) {
                this.editarFACTURACONSECUTIVOOperationCompleted = new System.Threading.SendOrPostCallback(this.OneditarFACTURACONSECUTIVOOperationCompleted);
            }
            this.InvokeAsync("editarFACTURACONSECUTIVO", new object[] {
                        obj}, this.editarFACTURACONSECUTIVOOperationCompleted, userState);
        }
        
        private void OneditarFACTURACONSECUTIVOOperationCompleted(object arg) {
            if ((this.editarFACTURACONSECUTIVOCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.editarFACTURACONSECUTIVOCompleted(this, new editarFACTURACONSECUTIVOCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/buscarPrimeroFACTURACONSECUTIVO", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public FACTURACONSECUTIVO buscarPrimeroFACTURACONSECUTIVO(FACTURACONSECUTIVO obj) {
            object[] results = this.Invoke("buscarPrimeroFACTURACONSECUTIVO", new object[] {
                        obj});
            return ((FACTURACONSECUTIVO)(results[0]));
        }
        
        /// <remarks/>
        public void buscarPrimeroFACTURACONSECUTIVOAsync(FACTURACONSECUTIVO obj) {
            this.buscarPrimeroFACTURACONSECUTIVOAsync(obj, null);
        }
        
        /// <remarks/>
        public void buscarPrimeroFACTURACONSECUTIVOAsync(FACTURACONSECUTIVO obj, object userState) {
            if ((this.buscarPrimeroFACTURACONSECUTIVOOperationCompleted == null)) {
                this.buscarPrimeroFACTURACONSECUTIVOOperationCompleted = new System.Threading.SendOrPostCallback(this.OnbuscarPrimeroFACTURACONSECUTIVOOperationCompleted);
            }
            this.InvokeAsync("buscarPrimeroFACTURACONSECUTIVO", new object[] {
                        obj}, this.buscarPrimeroFACTURACONSECUTIVOOperationCompleted, userState);
        }
        
        private void OnbuscarPrimeroFACTURACONSECUTIVOOperationCompleted(object arg) {
            if ((this.buscarPrimeroFACTURACONSECUTIVOCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.buscarPrimeroFACTURACONSECUTIVOCompleted(this, new buscarPrimeroFACTURACONSECUTIVOCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/buscarFACTURACONSECUTIVO", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public FACTURACONSECUTIVO[] buscarFACTURACONSECUTIVO(FACTURACONSECUTIVO obj) {
            object[] results = this.Invoke("buscarFACTURACONSECUTIVO", new object[] {
                        obj});
            return ((FACTURACONSECUTIVO[])(results[0]));
        }
        
        /// <remarks/>
        public void buscarFACTURACONSECUTIVOAsync(FACTURACONSECUTIVO obj) {
            this.buscarFACTURACONSECUTIVOAsync(obj, null);
        }
        
        /// <remarks/>
        public void buscarFACTURACONSECUTIVOAsync(FACTURACONSECUTIVO obj, object userState) {
            if ((this.buscarFACTURACONSECUTIVOOperationCompleted == null)) {
                this.buscarFACTURACONSECUTIVOOperationCompleted = new System.Threading.SendOrPostCallback(this.OnbuscarFACTURACONSECUTIVOOperationCompleted);
            }
            this.InvokeAsync("buscarFACTURACONSECUTIVO", new object[] {
                        obj}, this.buscarFACTURACONSECUTIVOOperationCompleted, userState);
        }
        
        private void OnbuscarFACTURACONSECUTIVOOperationCompleted(object arg) {
            if ((this.buscarFACTURACONSECUTIVOCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.buscarFACTURACONSECUTIVOCompleted(this, new buscarFACTURACONSECUTIVOCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/listarFACTURACONSECUTIVO", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public FACTURACONSECUTIVO[] listarFACTURACONSECUTIVO() {
            object[] results = this.Invoke("listarFACTURACONSECUTIVO", new object[0]);
            return ((FACTURACONSECUTIVO[])(results[0]));
        }
        
        /// <remarks/>
        public void listarFACTURACONSECUTIVOAsync() {
            this.listarFACTURACONSECUTIVOAsync(null);
        }
        
        /// <remarks/>
        public void listarFACTURACONSECUTIVOAsync(object userState) {
            if ((this.listarFACTURACONSECUTIVOOperationCompleted == null)) {
                this.listarFACTURACONSECUTIVOOperationCompleted = new System.Threading.SendOrPostCallback(this.OnlistarFACTURACONSECUTIVOOperationCompleted);
            }
            this.InvokeAsync("listarFACTURACONSECUTIVO", new object[0], this.listarFACTURACONSECUTIVOOperationCompleted, userState);
        }
        
        private void OnlistarFACTURACONSECUTIVOOperationCompleted(object arg) {
            if ((this.listarFACTURACONSECUTIVOCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.listarFACTURACONSECUTIVOCompleted(this, new listarFACTURACONSECUTIVOCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/eliminarFACTURACONSECUTIVO", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool eliminarFACTURACONSECUTIVO(FACTURACONSECUTIVO obj) {
            object[] results = this.Invoke("eliminarFACTURACONSECUTIVO", new object[] {
                        obj});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void eliminarFACTURACONSECUTIVOAsync(FACTURACONSECUTIVO obj) {
            this.eliminarFACTURACONSECUTIVOAsync(obj, null);
        }
        
        /// <remarks/>
        public void eliminarFACTURACONSECUTIVOAsync(FACTURACONSECUTIVO obj, object userState) {
            if ((this.eliminarFACTURACONSECUTIVOOperationCompleted == null)) {
                this.eliminarFACTURACONSECUTIVOOperationCompleted = new System.Threading.SendOrPostCallback(this.OneliminarFACTURACONSECUTIVOOperationCompleted);
            }
            this.InvokeAsync("eliminarFACTURACONSECUTIVO", new object[] {
                        obj}, this.eliminarFACTURACONSECUTIVOOperationCompleted, userState);
        }
        
        private void OneliminarFACTURACONSECUTIVOOperationCompleted(object arg) {
            if ((this.eliminarFACTURACONSECUTIVOCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.eliminarFACTURACONSECUTIVOCompleted(this, new eliminarFACTURACONSECUTIVOCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    public partial class FACTURACONSECUTIVO {
        
        private int idField;
        
        private float rANGO_INICIALField;
        
        private float rANGO_FINALField;
        
        private string sUFIJOField;
        
        private string rESOLUCIONField;
        
        private System.DateTime fECHA_RESOLUCIONField;
        
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
        public float RANGO_INICIAL {
            get {
                return this.rANGO_INICIALField;
            }
            set {
                this.rANGO_INICIALField = value;
            }
        }
        
        /// <remarks/>
        public float RANGO_FINAL {
            get {
                return this.rANGO_FINALField;
            }
            set {
                this.rANGO_FINALField = value;
            }
        }
        
        /// <remarks/>
        public string SUFIJO {
            get {
                return this.sUFIJOField;
            }
            set {
                this.sUFIJOField = value;
            }
        }
        
        /// <remarks/>
        public string RESOLUCION {
            get {
                return this.rESOLUCIONField;
            }
            set {
                this.rESOLUCIONField = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime FECHA_RESOLUCION {
            get {
                return this.fECHA_RESOLUCIONField;
            }
            set {
                this.fECHA_RESOLUCIONField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    public delegate void crearFACTURACONSECUTIVOCompletedEventHandler(object sender, crearFACTURACONSECUTIVOCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class crearFACTURACONSECUTIVOCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal crearFACTURACONSECUTIVOCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public FACTURACONSECUTIVO Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((FACTURACONSECUTIVO)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    public delegate void editarFACTURACONSECUTIVOCompletedEventHandler(object sender, editarFACTURACONSECUTIVOCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class editarFACTURACONSECUTIVOCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal editarFACTURACONSECUTIVOCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    public delegate void buscarPrimeroFACTURACONSECUTIVOCompletedEventHandler(object sender, buscarPrimeroFACTURACONSECUTIVOCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class buscarPrimeroFACTURACONSECUTIVOCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal buscarPrimeroFACTURACONSECUTIVOCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public FACTURACONSECUTIVO Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((FACTURACONSECUTIVO)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    public delegate void buscarFACTURACONSECUTIVOCompletedEventHandler(object sender, buscarFACTURACONSECUTIVOCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class buscarFACTURACONSECUTIVOCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal buscarFACTURACONSECUTIVOCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public FACTURACONSECUTIVO[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((FACTURACONSECUTIVO[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    public delegate void listarFACTURACONSECUTIVOCompletedEventHandler(object sender, listarFACTURACONSECUTIVOCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class listarFACTURACONSECUTIVOCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal listarFACTURACONSECUTIVOCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public FACTURACONSECUTIVO[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((FACTURACONSECUTIVO[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    public delegate void eliminarFACTURACONSECUTIVOCompletedEventHandler(object sender, eliminarFACTURACONSECUTIVOCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class eliminarFACTURACONSECUTIVOCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal eliminarFACTURACONSECUTIVOCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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