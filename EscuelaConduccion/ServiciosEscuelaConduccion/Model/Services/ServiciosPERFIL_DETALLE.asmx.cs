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

public class ServiciosPERFIL_DETALLE  : System.Web.Services.WebService {
	
	PERFIL_DETALLEManagement gestionPERFIL_DETALLE;
	
		
	public ServiciosPERFIL_DETALLE() {
		
		crearObjetos();
	}
	
	
    private void crearObjetos(){
		gestionPERFIL_DETALLE = new PERFIL_DETALLEManagement();
	}
	
	[WebMethod]
	[XmlInclude(typeof(PERFIL_DETALLE))]
	public PERFIL_DETALLE crearPERFIL_DETALLE(PERFIL_DETALLE obj) {
				return gestionPERFIL_DETALLE.crearPERFIL_DETALLE(obj); 
	}
	
	[WebMethod]
	public bool editarPERFIL_DETALLE(PERFIL_DETALLE obj) {
				return gestionPERFIL_DETALLE.editarPERFIL_DETALLE(obj);
	}
	
	[WebMethod]
	[XmlInclude(typeof(PERFIL_DETALLE))]
	public PERFIL_DETALLE buscarPrimeroPERFIL_DETALLE(PERFIL_DETALLE obj) {
				return gestionPERFIL_DETALLE.buscarPrimeroPERFIL_DETALLE(obj);
	}
	
	[WebMethod]
	[XmlInclude(typeof(PERFIL_DETALLE))]
	public PERFIL_DETALLE[] buscarPERFIL_DETALLE(PERFIL_DETALLE obj) {
    		return gestionPERFIL_DETALLE.buscarPERFIL_DETALLE(obj);
	}
	
	[WebMethod]
	[XmlInclude(typeof(PERFIL_DETALLE))]
	public PERFIL_DETALLE[] listarPERFIL_DETALLE() {
		      return gestionPERFIL_DETALLE.listarPERFIL_DETALLE();
	}
	
	[WebMethod]
	public bool eliminarPERFIL_DETALLE(PERFIL_DETALLE obj) {
			return gestionPERFIL_DETALLE.eliminarPERFIL_DETALLE(obj);
	}
}

}
