using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Xml.Serialization;
using System.Web.Services.Protocols;

using ServiciosEscuelaConduccion.Model.Objects;
using ServiciosEscuelaConduccion.Model.Managements;


namespace ServiciosEscuelaConduccion.Model.Services {

/// <summary>
/// Descripción breve de ServicioClase
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
[System.ComponentModel.ToolboxItem(false)]
// Para permitir que se llame a este servicio Web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
// [System.Web.Script.Services.ScriptService]

public class ServiciosTARIFA_DETALLE  : System.Web.Services.WebService {
	
	TARIFA_DETALLEManagement gestionTARIFA_DETALLE;
	
		
	public ServiciosTARIFA_DETALLE() {
		
		crearObjetos();
	}
	
	
    private void crearObjetos(){
		gestionTARIFA_DETALLE = new TARIFA_DETALLEManagement();
	}
	
	[WebMethod]
	[XmlInclude(typeof(TARIFA_DETALLE))]
	public TARIFA_DETALLE crearTARIFA_DETALLE(TARIFA_DETALLE obj) {
				return gestionTARIFA_DETALLE.crearTARIFA_DETALLE(obj); 
	}
	
	[WebMethod]
	public bool editarTARIFA_DETALLE(TARIFA_DETALLE obj) {
				return gestionTARIFA_DETALLE.editarTARIFA_DETALLE(obj);
	}
	
	[WebMethod]
	[XmlInclude(typeof(TARIFA_DETALLE))]
	public TARIFA_DETALLE buscarPrimeroTARIFA_DETALLE(TARIFA_DETALLE obj) {
				return gestionTARIFA_DETALLE.buscarPrimeroTARIFA_DETALLE(obj);
	}
	
	[WebMethod]
	[XmlInclude(typeof(TARIFA_DETALLE))]
	public TARIFA_DETALLE[] buscarTARIFA_DETALLE(TARIFA_DETALLE obj) {
    		return gestionTARIFA_DETALLE.buscarTARIFA_DETALLE(obj);
	}
	
	[WebMethod]
	[XmlInclude(typeof(TARIFA_DETALLE))]
	public TARIFA_DETALLE[] listarTARIFA_DETALLE() {
		      return gestionTARIFA_DETALLE.listarTARIFA_DETALLE();
	}
	
	[WebMethod]
	public bool eliminarTARIFA_DETALLE(TARIFA_DETALLE obj) {
			return gestionTARIFA_DETALLE.eliminarTARIFA_DETALLE(obj);
	}
}

}
