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

namespace EscuelaConduccion.wsServiciosViewliquidacion {
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
    [System.Web.Services.WebServiceBindingAttribute(Name="ServiciosViewliquidacionSoap", Namespace="http://tempuri.org/")]
    public partial class ServiciosViewliquidacion : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback buscarPrimeroViewliquidacionOperationCompleted;
        
        private System.Threading.SendOrPostCallback buscarViewliquidacionOperationCompleted;
        
        private System.Threading.SendOrPostCallback buscarViewliquidacionBetweenOperationCompleted;
        
        private System.Threading.SendOrPostCallback buscarPaginacionViewliquidacionOperationCompleted;
        
        private System.Threading.SendOrPostCallback listarViewliquidacionOperationCompleted;
        
        private System.Threading.SendOrPostCallback listarPaginacionViewliquidacionOperationCompleted;
        
        private System.Threading.SendOrPostCallback contarBusquedaViewliquidacionOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public ServiciosViewliquidacion() {
            this.Url = global::EscuelaConduccion.Properties.Settings.Default.EscuelaConduccion_wsServiciosViewliquidacion_ServiciosViewliquidacion;
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
        public event buscarPrimeroViewliquidacionCompletedEventHandler buscarPrimeroViewliquidacionCompleted;
        
        /// <remarks/>
        public event buscarViewliquidacionCompletedEventHandler buscarViewliquidacionCompleted;
        
        /// <remarks/>
        public event buscarViewliquidacionBetweenCompletedEventHandler buscarViewliquidacionBetweenCompleted;
        
        /// <remarks/>
        public event buscarPaginacionViewliquidacionCompletedEventHandler buscarPaginacionViewliquidacionCompleted;
        
        /// <remarks/>
        public event listarViewliquidacionCompletedEventHandler listarViewliquidacionCompleted;
        
        /// <remarks/>
        public event listarPaginacionViewliquidacionCompletedEventHandler listarPaginacionViewliquidacionCompleted;
        
        /// <remarks/>
        public event contarBusquedaViewliquidacionCompletedEventHandler contarBusquedaViewliquidacionCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/buscarPrimeroViewliquidacion", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Viewliquidacion buscarPrimeroViewliquidacion(Viewliquidacion obj) {
            object[] results = this.Invoke("buscarPrimeroViewliquidacion", new object[] {
                        obj});
            return ((Viewliquidacion)(results[0]));
        }
        
        /// <remarks/>
        public void buscarPrimeroViewliquidacionAsync(Viewliquidacion obj) {
            this.buscarPrimeroViewliquidacionAsync(obj, null);
        }
        
        /// <remarks/>
        public void buscarPrimeroViewliquidacionAsync(Viewliquidacion obj, object userState) {
            if ((this.buscarPrimeroViewliquidacionOperationCompleted == null)) {
                this.buscarPrimeroViewliquidacionOperationCompleted = new System.Threading.SendOrPostCallback(this.OnbuscarPrimeroViewliquidacionOperationCompleted);
            }
            this.InvokeAsync("buscarPrimeroViewliquidacion", new object[] {
                        obj}, this.buscarPrimeroViewliquidacionOperationCompleted, userState);
        }
        
        private void OnbuscarPrimeroViewliquidacionOperationCompleted(object arg) {
            if ((this.buscarPrimeroViewliquidacionCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.buscarPrimeroViewliquidacionCompleted(this, new buscarPrimeroViewliquidacionCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/buscarViewliquidacion", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Viewliquidacion[] buscarViewliquidacion(Viewliquidacion obj) {
            object[] results = this.Invoke("buscarViewliquidacion", new object[] {
                        obj});
            return ((Viewliquidacion[])(results[0]));
        }
        
        /// <remarks/>
        public void buscarViewliquidacionAsync(Viewliquidacion obj) {
            this.buscarViewliquidacionAsync(obj, null);
        }
        
        /// <remarks/>
        public void buscarViewliquidacionAsync(Viewliquidacion obj, object userState) {
            if ((this.buscarViewliquidacionOperationCompleted == null)) {
                this.buscarViewliquidacionOperationCompleted = new System.Threading.SendOrPostCallback(this.OnbuscarViewliquidacionOperationCompleted);
            }
            this.InvokeAsync("buscarViewliquidacion", new object[] {
                        obj}, this.buscarViewliquidacionOperationCompleted, userState);
        }
        
        private void OnbuscarViewliquidacionOperationCompleted(object arg) {
            if ((this.buscarViewliquidacionCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.buscarViewliquidacionCompleted(this, new buscarViewliquidacionCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/buscarViewliquidacionBetween", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Viewliquidacion[] buscarViewliquidacionBetween(Viewliquidacion obj, System.DateTime fechaIniLiq, System.DateTime fechaFinLiq, System.DateTime fechaIniPag, System.DateTime fechaFinPag) {
            object[] results = this.Invoke("buscarViewliquidacionBetween", new object[] {
                        obj,
                        fechaIniLiq,
                        fechaFinLiq,
                        fechaIniPag,
                        fechaFinPag});
            return ((Viewliquidacion[])(results[0]));
        }
        
        /// <remarks/>
        public void buscarViewliquidacionBetweenAsync(Viewliquidacion obj, System.DateTime fechaIniLiq, System.DateTime fechaFinLiq, System.DateTime fechaIniPag, System.DateTime fechaFinPag) {
            this.buscarViewliquidacionBetweenAsync(obj, fechaIniLiq, fechaFinLiq, fechaIniPag, fechaFinPag, null);
        }
        
        /// <remarks/>
        public void buscarViewliquidacionBetweenAsync(Viewliquidacion obj, System.DateTime fechaIniLiq, System.DateTime fechaFinLiq, System.DateTime fechaIniPag, System.DateTime fechaFinPag, object userState) {
            if ((this.buscarViewliquidacionBetweenOperationCompleted == null)) {
                this.buscarViewliquidacionBetweenOperationCompleted = new System.Threading.SendOrPostCallback(this.OnbuscarViewliquidacionBetweenOperationCompleted);
            }
            this.InvokeAsync("buscarViewliquidacionBetween", new object[] {
                        obj,
                        fechaIniLiq,
                        fechaFinLiq,
                        fechaIniPag,
                        fechaFinPag}, this.buscarViewliquidacionBetweenOperationCompleted, userState);
        }
        
        private void OnbuscarViewliquidacionBetweenOperationCompleted(object arg) {
            if ((this.buscarViewliquidacionBetweenCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.buscarViewliquidacionBetweenCompleted(this, new buscarViewliquidacionBetweenCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/buscarPaginacionViewliquidacion", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Viewliquidacion[] buscarPaginacionViewliquidacion(Viewliquidacion obj, int pag, int numReg) {
            object[] results = this.Invoke("buscarPaginacionViewliquidacion", new object[] {
                        obj,
                        pag,
                        numReg});
            return ((Viewliquidacion[])(results[0]));
        }
        
        /// <remarks/>
        public void buscarPaginacionViewliquidacionAsync(Viewliquidacion obj, int pag, int numReg) {
            this.buscarPaginacionViewliquidacionAsync(obj, pag, numReg, null);
        }
        
        /// <remarks/>
        public void buscarPaginacionViewliquidacionAsync(Viewliquidacion obj, int pag, int numReg, object userState) {
            if ((this.buscarPaginacionViewliquidacionOperationCompleted == null)) {
                this.buscarPaginacionViewliquidacionOperationCompleted = new System.Threading.SendOrPostCallback(this.OnbuscarPaginacionViewliquidacionOperationCompleted);
            }
            this.InvokeAsync("buscarPaginacionViewliquidacion", new object[] {
                        obj,
                        pag,
                        numReg}, this.buscarPaginacionViewliquidacionOperationCompleted, userState);
        }
        
        private void OnbuscarPaginacionViewliquidacionOperationCompleted(object arg) {
            if ((this.buscarPaginacionViewliquidacionCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.buscarPaginacionViewliquidacionCompleted(this, new buscarPaginacionViewliquidacionCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/listarViewliquidacion", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Viewliquidacion[] listarViewliquidacion() {
            object[] results = this.Invoke("listarViewliquidacion", new object[0]);
            return ((Viewliquidacion[])(results[0]));
        }
        
        /// <remarks/>
        public void listarViewliquidacionAsync() {
            this.listarViewliquidacionAsync(null);
        }
        
        /// <remarks/>
        public void listarViewliquidacionAsync(object userState) {
            if ((this.listarViewliquidacionOperationCompleted == null)) {
                this.listarViewliquidacionOperationCompleted = new System.Threading.SendOrPostCallback(this.OnlistarViewliquidacionOperationCompleted);
            }
            this.InvokeAsync("listarViewliquidacion", new object[0], this.listarViewliquidacionOperationCompleted, userState);
        }
        
        private void OnlistarViewliquidacionOperationCompleted(object arg) {
            if ((this.listarViewliquidacionCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.listarViewliquidacionCompleted(this, new listarViewliquidacionCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/listarPaginacionViewliquidacion", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Viewliquidacion[] listarPaginacionViewliquidacion(int pag, int numReg) {
            object[] results = this.Invoke("listarPaginacionViewliquidacion", new object[] {
                        pag,
                        numReg});
            return ((Viewliquidacion[])(results[0]));
        }
        
        /// <remarks/>
        public void listarPaginacionViewliquidacionAsync(int pag, int numReg) {
            this.listarPaginacionViewliquidacionAsync(pag, numReg, null);
        }
        
        /// <remarks/>
        public void listarPaginacionViewliquidacionAsync(int pag, int numReg, object userState) {
            if ((this.listarPaginacionViewliquidacionOperationCompleted == null)) {
                this.listarPaginacionViewliquidacionOperationCompleted = new System.Threading.SendOrPostCallback(this.OnlistarPaginacionViewliquidacionOperationCompleted);
            }
            this.InvokeAsync("listarPaginacionViewliquidacion", new object[] {
                        pag,
                        numReg}, this.listarPaginacionViewliquidacionOperationCompleted, userState);
        }
        
        private void OnlistarPaginacionViewliquidacionOperationCompleted(object arg) {
            if ((this.listarPaginacionViewliquidacionCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.listarPaginacionViewliquidacionCompleted(this, new listarPaginacionViewliquidacionCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/contarBusquedaViewliquidacion", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public int contarBusquedaViewliquidacion(Viewliquidacion obj) {
            object[] results = this.Invoke("contarBusquedaViewliquidacion", new object[] {
                        obj});
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        public void contarBusquedaViewliquidacionAsync(Viewliquidacion obj) {
            this.contarBusquedaViewliquidacionAsync(obj, null);
        }
        
        /// <remarks/>
        public void contarBusquedaViewliquidacionAsync(Viewliquidacion obj, object userState) {
            if ((this.contarBusquedaViewliquidacionOperationCompleted == null)) {
                this.contarBusquedaViewliquidacionOperationCompleted = new System.Threading.SendOrPostCallback(this.OncontarBusquedaViewliquidacionOperationCompleted);
            }
            this.InvokeAsync("contarBusquedaViewliquidacion", new object[] {
                        obj}, this.contarBusquedaViewliquidacionOperationCompleted, userState);
        }
        
        private void OncontarBusquedaViewliquidacionOperationCompleted(object arg) {
            if ((this.contarBusquedaViewliquidacionCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.contarBusquedaViewliquidacionCompleted(this, new contarBusquedaViewliquidacionCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    public partial class Viewliquidacion {
        
        private string nUMERO_RECIBOField;
        
        private string nUMERO_FACTURAField;
        
        private long iD_TIPO_DOCUMENTOField;
        
        private string tIPO_DOCUMENTOField;
        
        private string iDENTIFICACIONField;
        
        private long iD_ESTADOField;
        
        private string eSTADOField;
        
        private System.DateTime fECHA_LIQUIDACIONField;
        
        private System.DateTime fECHA_PAGOField;
        
        private long iD_TIPO_LIQUIDACIONField;
        
        private string tIPOField;
        
        private string tARIFAField;
        
        private string eSTADO_FACTURAField;
        
        /// <remarks/>
        public string NUMERO_RECIBO {
            get {
                return this.nUMERO_RECIBOField;
            }
            set {
                this.nUMERO_RECIBOField = value;
            }
        }
        
        /// <remarks/>
        public string NUMERO_FACTURA {
            get {
                return this.nUMERO_FACTURAField;
            }
            set {
                this.nUMERO_FACTURAField = value;
            }
        }
        
        /// <remarks/>
        public long ID_TIPO_DOCUMENTO {
            get {
                return this.iD_TIPO_DOCUMENTOField;
            }
            set {
                this.iD_TIPO_DOCUMENTOField = value;
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
        public long ID_ESTADO {
            get {
                return this.iD_ESTADOField;
            }
            set {
                this.iD_ESTADOField = value;
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
        public System.DateTime FECHA_LIQUIDACION {
            get {
                return this.fECHA_LIQUIDACIONField;
            }
            set {
                this.fECHA_LIQUIDACIONField = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime FECHA_PAGO {
            get {
                return this.fECHA_PAGOField;
            }
            set {
                this.fECHA_PAGOField = value;
            }
        }
        
        /// <remarks/>
        public long ID_TIPO_LIQUIDACION {
            get {
                return this.iD_TIPO_LIQUIDACIONField;
            }
            set {
                this.iD_TIPO_LIQUIDACIONField = value;
            }
        }
        
        /// <remarks/>
        public string TIPO {
            get {
                return this.tIPOField;
            }
            set {
                this.tIPOField = value;
            }
        }
        
        /// <remarks/>
        public string TARIFA {
            get {
                return this.tARIFAField;
            }
            set {
                this.tARIFAField = value;
            }
        }
        
        /// <remarks/>
        public string ESTADO_FACTURA {
            get {
                return this.eSTADO_FACTURAField;
            }
            set {
                this.eSTADO_FACTURAField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    public delegate void buscarPrimeroViewliquidacionCompletedEventHandler(object sender, buscarPrimeroViewliquidacionCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class buscarPrimeroViewliquidacionCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal buscarPrimeroViewliquidacionCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Viewliquidacion Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Viewliquidacion)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    public delegate void buscarViewliquidacionCompletedEventHandler(object sender, buscarViewliquidacionCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class buscarViewliquidacionCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal buscarViewliquidacionCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Viewliquidacion[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Viewliquidacion[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    public delegate void buscarViewliquidacionBetweenCompletedEventHandler(object sender, buscarViewliquidacionBetweenCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class buscarViewliquidacionBetweenCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal buscarViewliquidacionBetweenCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Viewliquidacion[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Viewliquidacion[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    public delegate void buscarPaginacionViewliquidacionCompletedEventHandler(object sender, buscarPaginacionViewliquidacionCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class buscarPaginacionViewliquidacionCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal buscarPaginacionViewliquidacionCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Viewliquidacion[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Viewliquidacion[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    public delegate void listarViewliquidacionCompletedEventHandler(object sender, listarViewliquidacionCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class listarViewliquidacionCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal listarViewliquidacionCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Viewliquidacion[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Viewliquidacion[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    public delegate void listarPaginacionViewliquidacionCompletedEventHandler(object sender, listarPaginacionViewliquidacionCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class listarPaginacionViewliquidacionCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal listarPaginacionViewliquidacionCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Viewliquidacion[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Viewliquidacion[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    public delegate void contarBusquedaViewliquidacionCompletedEventHandler(object sender, contarBusquedaViewliquidacionCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class contarBusquedaViewliquidacionCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal contarBusquedaViewliquidacionCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
}

#pragma warning restore 1591