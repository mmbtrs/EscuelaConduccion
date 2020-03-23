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

public class ServiciosSALARIOMINIMO  : System.Web.Services.WebService {
	
	SALARIOMINIMOManagement gestionSALARIOMINIMO;
	
		
	public ServiciosSALARIOMINIMO() {
		
		crearObjetos();
	}
	
	
    private void crearObjetos(){
		gestionSALARIOMINIMO = new SALARIOMINIMOManagement();
	}
	
	[WebMethod]
	[XmlInclude(typeof(SALARIOMINIMO))]
	public SALARIOMINIMO crearSALARIOMINIMO(SALARIOMINIMO obj) {
				return gestionSALARIOMINIMO.crearSALARIOMINIMO(obj); 
	}
	
	[WebMethod]
	public bool editarSALARIOMINIMO(SALARIOMINIMO obj) {
				return gestionSALARIOMINIMO.editarSALARIOMINIMO(obj);
	}
	
	[WebMethod]
	[XmlInclude(typeof(SALARIOMINIMO))]
	public SALARIOMINIMO buscarPrimeroSALARIOMINIMO(SALARIOMINIMO obj) {
				return gestionSALARIOMINIMO.buscarPrimeroSALARIOMINIMO(obj);
	}
	
	[WebMethod]
	[XmlInclude(typeof(SALARIOMINIMO))]
	public SALARIOMINIMO[] buscarSALARIOMINIMO(SALARIOMINIMO obj) {
    		return gestionSALARIOMINIMO.buscarSALARIOMINIMO(obj);
	}
	
	[WebMethod]
	[XmlInclude(typeof(SALARIOMINIMO))]
	public SALARIOMINIMO[] listarSALARIOMINIMO() {
		      return gestionSALARIOMINIMO.listarSALARIOMINIMO();
	}
	
	[WebMethod]
	public bool eliminarSALARIOMINIMO(SALARIOMINIMO obj) {
			return gestionSALARIOMINIMO.eliminarSALARIOMINIMO(obj);
	}
}

}
