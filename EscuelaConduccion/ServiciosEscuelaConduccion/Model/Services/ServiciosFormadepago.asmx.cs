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
	
	GestionFormadepago gestionFormadepago;
	
		
	public ServiciosFormadepago() {
		
		crearObjetos();
	}
	
	
    private void crearObjetos(){
		gestionFormadepago = new GestionFormadepago();
	}
	

	[WebMethod]
	
	[XmlInclude(typeof(Formadepago))]
	public Formadepago crearFormadepago(Formadepago obj) {
				return gestionFormadepago.crearFormadepago(obj); 
	}
	
	[WebMethod]
	public bool editarFormadepago(Formadepago obj) {
				return gestionFormadepago.editarFormadepago(obj);
	}
	
	[WebMethod]
	[XmlInclude(typeof(Formadepago))]
	public Formadepago buscarPrimeroFormadepago(Formadepago obj) {
				return gestionFormadepago.buscarPrimeroFormadepago(obj);
	}
	
	[WebMethod]
	[XmlInclude(typeof(Formadepago))]
	public Formadepago[] buscarFormadepago(Formadepago obj) {
    		return gestionFormadepago.buscarFormadepago(obj);
	}
	
	[WebMethod]
	[XmlInclude(typeof(Formadepago))]
	public Formadepago[] buscarPaginacionFormadepago(Formadepago obj,int pag,int numReg) {
				return gestionFormadepago.buscarFormadepago(obj, pag, numReg);
	}
	
	[WebMethod]
	[XmlInclude(typeof(Formadepago))]
	public Formadepago[] listarFormadepago() {
		      return gestionFormadepago.listarFormadepago();
	}
	
	[WebMethod]
	[XmlInclude(typeof(Formadepago))]
	public Formadepago[] listarPaginacionFormadepago(int pag,int numReg) {
			return gestionFormadepago.listarFormadepago(pag, numReg);
	}
	
	[WebMethod]
	public int contarBusquedaFormadepago(Formadepago obj) {
			return gestionFormadepago.contarBusquedaFormadepago(obj);
	}
	
	[WebMethod]
	public bool eliminarFormadepago(Formadepago obj) {
			return gestionFormadepago.eliminarFormadepago(obj);
	}
}

}
