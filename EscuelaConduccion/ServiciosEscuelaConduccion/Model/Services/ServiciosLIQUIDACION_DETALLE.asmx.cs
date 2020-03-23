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

public class ServiciosLIQUIDACION_DETALLE  : System.Web.Services.WebService {
	
	LIQUIDACION_DETALLEManagement gestionLIQUIDACION_DETALLE;
	
		
	public ServiciosLIQUIDACION_DETALLE() {
		
		crearObjetos();
	}
	
	
    private void crearObjetos(){
		gestionLIQUIDACION_DETALLE = new LIQUIDACION_DETALLEManagement();
	}
	
	[WebMethod]
	[XmlInclude(typeof(LIQUIDACION_DETALLE))]
	public LIQUIDACION_DETALLE crearLIQUIDACION_DETALLE(LIQUIDACION_DETALLE obj) {
				return gestionLIQUIDACION_DETALLE.crearLIQUIDACION_DETALLE(obj); 
	}
	
	[WebMethod]
	public bool editarLIQUIDACION_DETALLE(LIQUIDACION_DETALLE obj) {
				return gestionLIQUIDACION_DETALLE.editarLIQUIDACION_DETALLE(obj);
	}
	
	[WebMethod]
	[XmlInclude(typeof(LIQUIDACION_DETALLE))]
	public LIQUIDACION_DETALLE buscarPrimeroLIQUIDACION_DETALLE(LIQUIDACION_DETALLE obj) {
				return gestionLIQUIDACION_DETALLE.buscarPrimeroLIQUIDACION_DETALLE(obj);
	}
	
	[WebMethod]
	[XmlInclude(typeof(LIQUIDACION_DETALLE))]
	public LIQUIDACION_DETALLE[] buscarLIQUIDACION_DETALLE(LIQUIDACION_DETALLE obj) {
    		return gestionLIQUIDACION_DETALLE.buscarLIQUIDACION_DETALLE(obj);
	}
	
	[WebMethod]
	[XmlInclude(typeof(LIQUIDACION_DETALLE))]
	public LIQUIDACION_DETALLE[] listarLIQUIDACION_DETALLE() {
		      return gestionLIQUIDACION_DETALLE.listarLIQUIDACION_DETALLE();
	}
	
	[WebMethod]
	public bool eliminarLIQUIDACION_DETALLE(LIQUIDACION_DETALLE obj) {
			return gestionLIQUIDACION_DETALLE.eliminarLIQUIDACION_DETALLE(obj);
	}
}

}
