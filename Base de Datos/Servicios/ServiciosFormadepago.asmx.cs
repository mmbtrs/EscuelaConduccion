using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Xml.Serialization;
using System.Web.Services.Protocols;

using ServiciosEscuelaConduccion.objetos;
using ServiciosEscuelaConduccion.gestion;


namespace ServiciosEscuelaConduccion.Servicios  {

/// <summary>
/// Descripción breve de ServicioClase
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
[System.ComponentModel.ToolboxItem(false)]
// Para permitir que se llame a este servicio Web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
// [System.Web.Script.Services.ScriptService]

public class ServiciosFormadepago  : System.Web.Services.WebService {
	
	public Autenticacion autenticacion;	
	GestionFormadepago gestionFormadepago;
	
		
	public ServiciosFormadepago() {
		
		crearObjetos();
	}
	
	
    private void crearObjetos(){
		gestionFormadepago = new GestionFormadepago();
	
	}
	

	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Formadepago))]
	public Formadepago crearFormadepago(Formadepago obj) {
	       if (autenticacion != null && autenticacion.esValido()) 
				return gestionFormadepago.crearFormadepago(obj); 
           return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	public bool editarFormadepago(Formadepago obj) {
			if (autenticacion != null && autenticacion.esValido()) 
				return gestionFormadepago.editarFormadepago(obj);
            return false; 
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Formadepago))]
	public Formadepago buscarPrimeroFormadepago(Formadepago obj) {
			if (autenticacion != null && autenticacion.esValido()) 
				return gestionFormadepago.buscarPrimeroFormadepago(obj);
            return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Formadepago))]
	public Formadepago[] buscarFormadepago(Formadepago obj) {
	   if (autenticacion != null && autenticacion.esValido()) 
    		return gestionFormadepago.buscarFormadepago(obj);
       return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Formadepago))]
	public Formadepago[] buscarPaginacionFormadepago(Formadepago obj,int pag,int numReg) {
		if (autenticacion != null && autenticacion.esValido()) 
				return gestionFormadepago.buscarFormadepago(obj, pag, numReg);
		return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Formadepago))]
	public Formadepago[] listarFormadepago() {
	    if (autenticacion != null && autenticacion.esValido()) 
		      return gestionFormadepago.listarFormadepago();
	    return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Formadepago))]
	public Formadepago[] listarPaginacionFormadepago(int pag,int numReg) {
		if (autenticacion != null && autenticacion.esValido()) 
			return gestionFormadepago.listarFormadepago(pag, numReg);
		return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	public int contarBusquedaFormadepago(Formadepago obj) {
		if (autenticacion != null && autenticacion.esValido()) 
			return gestionFormadepago.contarBusquedaFormadepago(obj);
        return -1;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	public bool eliminarFormadepago(Formadepago obj) {
		if (autenticacion != null && autenticacion.esValido()) 
			return gestionFormadepago.eliminarFormadepago(obj);
        return false;
	}
}

}
