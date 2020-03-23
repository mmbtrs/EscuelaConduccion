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

public class ServiciosTARIFA  : System.Web.Services.WebService {
	
	TARIFAManagement gestionTARIFA;
	
		
	public ServiciosTARIFA() {
		
		crearObjetos();
	}
	
	
    private void crearObjetos(){
		gestionTARIFA = new TARIFAManagement();
	}
	
	[WebMethod]
	[XmlInclude(typeof(TARIFA))]
	public TARIFA crearTARIFA(TARIFA obj) {
				return gestionTARIFA.crearTARIFA(obj); 
	}
	
	[WebMethod]
	public bool editarTARIFA(TARIFA obj) {
				return gestionTARIFA.editarTARIFA(obj);
	}
	
	[WebMethod]
	[XmlInclude(typeof(TARIFA))]
	public TARIFA buscarPrimeroTARIFA(TARIFA obj) {
				return gestionTARIFA.buscarPrimeroTARIFA(obj);
	}
	
	[WebMethod]
	[XmlInclude(typeof(TARIFA))]
	public TARIFA[] buscarTARIFA(TARIFA obj) {
    		return gestionTARIFA.buscarTARIFA(obj);
	}
	
	[WebMethod]
	[XmlInclude(typeof(TARIFA))]
	public TARIFA[] listarTARIFA() {
		      return gestionTARIFA.listarTARIFA();
	}
	
	[WebMethod]
	public bool eliminarTARIFA(TARIFA obj) {
			return gestionTARIFA.eliminarTARIFA(obj);
	}
}

}
