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

public class ServiciosTIPO_LIQUIDACION  : System.Web.Services.WebService {
	
	TIPO_LIQUIDACIONManagement gestionTIPO_LIQUIDACION;
	
		
	public ServiciosTIPO_LIQUIDACION() {
		
		crearObjetos();
	}
	
	
    private void crearObjetos(){
		gestionTIPO_LIQUIDACION = new TIPO_LIQUIDACIONManagement();
	}
	
	[WebMethod]
	[XmlInclude(typeof(TIPO_LIQUIDACION))]
	public TIPO_LIQUIDACION crearTIPO_LIQUIDACION(TIPO_LIQUIDACION obj) {
				return gestionTIPO_LIQUIDACION.crearTIPO_LIQUIDACION(obj); 
	}
	
	[WebMethod]
	public bool editarTIPO_LIQUIDACION(TIPO_LIQUIDACION obj) {
				return gestionTIPO_LIQUIDACION.editarTIPO_LIQUIDACION(obj);
	}
	
	[WebMethod]
	[XmlInclude(typeof(TIPO_LIQUIDACION))]
	public TIPO_LIQUIDACION buscarPrimeroTIPO_LIQUIDACION(TIPO_LIQUIDACION obj) {
				return gestionTIPO_LIQUIDACION.buscarPrimeroTIPO_LIQUIDACION(obj);
	}
	
	[WebMethod]
	[XmlInclude(typeof(TIPO_LIQUIDACION))]
	public TIPO_LIQUIDACION[] buscarTIPO_LIQUIDACION(TIPO_LIQUIDACION obj) {
    		return gestionTIPO_LIQUIDACION.buscarTIPO_LIQUIDACION(obj);
	}
	
	[WebMethod]
	[XmlInclude(typeof(TIPO_LIQUIDACION))]
	public TIPO_LIQUIDACION[] listarTIPO_LIQUIDACION() {
		      return gestionTIPO_LIQUIDACION.listarTIPO_LIQUIDACION();
	}
	
	[WebMethod]
	public bool eliminarTIPO_LIQUIDACION(TIPO_LIQUIDACION obj) {
			return gestionTIPO_LIQUIDACION.eliminarTIPO_LIQUIDACION(obj);
	}
}

}
