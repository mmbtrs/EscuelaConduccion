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

public class ServiciosPagos  : System.Web.Services.WebService {
	
	public Autenticacion autenticacion;	
	GestionPagos gestionPagos;
	
		
	public ServiciosPagos() {
		
		crearObjetos();
	}
	
	
    private void crearObjetos(){
		gestionPagos = new GestionPagos();
	
	}
	

	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Pagos))]
	public Pagos crearPagos(Pagos obj) {
	       if (autenticacion != null && autenticacion.esValido()) 
				return gestionPagos.crearPagos(obj); 
           return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	public bool editarPagos(Pagos obj) {
			if (autenticacion != null && autenticacion.esValido()) 
				return gestionPagos.editarPagos(obj);
            return false; 
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Pagos))]
	public Pagos buscarPrimeroPagos(Pagos obj) {
			if (autenticacion != null && autenticacion.esValido()) 
				return gestionPagos.buscarPrimeroPagos(obj);
            return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Pagos))]
	public Pagos[] buscarPagos(Pagos obj) {
	   if (autenticacion != null && autenticacion.esValido()) 
    		return gestionPagos.buscarPagos(obj);
       return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Pagos))]
	public Pagos[] buscarPaginacionPagos(Pagos obj,int pag,int numReg) {
		if (autenticacion != null && autenticacion.esValido()) 
				return gestionPagos.buscarPagos(obj, pag, numReg);
		return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Pagos))]
	public Pagos[] listarPagos() {
	    if (autenticacion != null && autenticacion.esValido()) 
		      return gestionPagos.listarPagos();
	    return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Pagos))]
	public Pagos[] listarPaginacionPagos(int pag,int numReg) {
		if (autenticacion != null && autenticacion.esValido()) 
			return gestionPagos.listarPagos(pag, numReg);
		return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	public int contarBusquedaPagos(Pagos obj) {
		if (autenticacion != null && autenticacion.esValido()) 
			return gestionPagos.contarBusquedaPagos(obj);
        return -1;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	public bool eliminarPagos(Pagos obj) {
		if (autenticacion != null && autenticacion.esValido()) 
			return gestionPagos.eliminarPagos(obj);
        return false;
	}
}

}
