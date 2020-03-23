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

public class ServiciosViewrecibo  : System.Web.Services.WebService {
	
	public Autenticacion autenticacion;	
	GestionViewrecibo gestionViewrecibo;
	
		
	public ServiciosViewrecibo() {
		
		crearObjetos();
	}
	
	
    private void crearObjetos(){
		gestionViewrecibo = new GestionViewrecibo();
	
	}
	

	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Viewrecibo))]
	public Viewrecibo crearViewrecibo(Viewrecibo obj) {
	       if (autenticacion != null && autenticacion.esValido()) 
				return gestionViewrecibo.crearViewrecibo(obj); 
           return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	public bool editarViewrecibo(Viewrecibo obj) {
			if (autenticacion != null && autenticacion.esValido()) 
				return gestionViewrecibo.editarViewrecibo(obj);
            return false; 
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Viewrecibo))]
	public Viewrecibo buscarPrimeroViewrecibo(Viewrecibo obj) {
			if (autenticacion != null && autenticacion.esValido()) 
				return gestionViewrecibo.buscarPrimeroViewrecibo(obj);
            return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Viewrecibo))]
	public Viewrecibo[] buscarViewrecibo(Viewrecibo obj) {
	   if (autenticacion != null && autenticacion.esValido()) 
    		return gestionViewrecibo.buscarViewrecibo(obj);
       return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Viewrecibo))]
	public Viewrecibo[] buscarPaginacionViewrecibo(Viewrecibo obj,int pag,int numReg) {
		if (autenticacion != null && autenticacion.esValido()) 
				return gestionViewrecibo.buscarViewrecibo(obj, pag, numReg);
		return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Viewrecibo))]
	public Viewrecibo[] listarViewrecibo() {
	    if (autenticacion != null && autenticacion.esValido()) 
		      return gestionViewrecibo.listarViewrecibo();
	    return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Viewrecibo))]
	public Viewrecibo[] listarPaginacionViewrecibo(int pag,int numReg) {
		if (autenticacion != null && autenticacion.esValido()) 
			return gestionViewrecibo.listarViewrecibo(pag, numReg);
		return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	public int contarBusquedaViewrecibo(Viewrecibo obj) {
		if (autenticacion != null && autenticacion.esValido()) 
			return gestionViewrecibo.contarBusquedaViewrecibo(obj);
        return -1;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	public bool eliminarViewrecibo(Viewrecibo obj) {
		if (autenticacion != null && autenticacion.esValido()) 
			return gestionViewrecibo.eliminarViewrecibo(obj);
        return false;
	}
}

}
