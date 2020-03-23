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

public class ServiciosVIEW_CIUDAD  : System.Web.Services.WebService {
	
	VIEW_CIUDADManagement gestionVIEW_CIUDAD;
	
		
	public ServiciosVIEW_CIUDAD() {
		
		crearObjetos();
	}
	
	
    private void crearObjetos(){
		gestionVIEW_CIUDAD = new VIEW_CIUDADManagement();
	}
	
	[WebMethod]
	[XmlInclude(typeof(VIEW_CIUDAD))]
	public VIEW_CIUDAD crearVIEW_CIUDAD(VIEW_CIUDAD obj) {
				return gestionVIEW_CIUDAD.crearVIEW_CIUDAD(obj); 
	}
	
	[WebMethod]
	public bool editarVIEW_CIUDAD(VIEW_CIUDAD obj) {
				return gestionVIEW_CIUDAD.editarVIEW_CIUDAD(obj);
	}
	
	[WebMethod]
	[XmlInclude(typeof(VIEW_CIUDAD))]
	public VIEW_CIUDAD buscarPrimeroVIEW_CIUDAD(VIEW_CIUDAD obj) {
				return gestionVIEW_CIUDAD.buscarPrimeroVIEW_CIUDAD(obj);
	}
	
	[WebMethod]
	[XmlInclude(typeof(VIEW_CIUDAD))]
	public VIEW_CIUDAD[] buscarVIEW_CIUDAD(VIEW_CIUDAD obj) {
    		return gestionVIEW_CIUDAD.buscarVIEW_CIUDAD(obj);
	}
	
	[WebMethod]
	[XmlInclude(typeof(VIEW_CIUDAD))]
	public VIEW_CIUDAD[] listarVIEW_CIUDAD() {
		      return gestionVIEW_CIUDAD.listarVIEW_CIUDAD();
	}
	
	[WebMethod]
	public bool eliminarVIEW_CIUDAD(VIEW_CIUDAD obj) {
			return gestionVIEW_CIUDAD.eliminarVIEW_CIUDAD(obj);
	}
}

}
