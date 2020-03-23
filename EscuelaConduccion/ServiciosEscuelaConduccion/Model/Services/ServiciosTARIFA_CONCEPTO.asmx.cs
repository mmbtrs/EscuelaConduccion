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

public class ServiciosTARIFA_CONCEPTO  : System.Web.Services.WebService {
	
	TARIFA_CONCEPTOManagement gestionTARIFA_CONCEPTO;
	
		
	public ServiciosTARIFA_CONCEPTO() {
		
		crearObjetos();
	}
	
	
    private void crearObjetos(){
		gestionTARIFA_CONCEPTO = new TARIFA_CONCEPTOManagement();
	}
	
	[WebMethod]
	[XmlInclude(typeof(TARIFA_CONCEPTO))]
	public TARIFA_CONCEPTO crearTARIFA_CONCEPTO(TARIFA_CONCEPTO obj) {
				return gestionTARIFA_CONCEPTO.crearTARIFA_CONCEPTO(obj); 
	}
	
	[WebMethod]
	public bool editarTARIFA_CONCEPTO(TARIFA_CONCEPTO obj) {
				return gestionTARIFA_CONCEPTO.editarTARIFA_CONCEPTO(obj);
	}
	
	[WebMethod]
	[XmlInclude(typeof(TARIFA_CONCEPTO))]
	public TARIFA_CONCEPTO buscarPrimeroTARIFA_CONCEPTO(TARIFA_CONCEPTO obj) {
				return gestionTARIFA_CONCEPTO.buscarPrimeroTARIFA_CONCEPTO(obj);
	}
	
	[WebMethod]
	[XmlInclude(typeof(TARIFA_CONCEPTO))]
	public TARIFA_CONCEPTO[] buscarTARIFA_CONCEPTO(TARIFA_CONCEPTO obj) {
    		return gestionTARIFA_CONCEPTO.buscarTARIFA_CONCEPTO(obj);
	}
	
	[WebMethod]
	[XmlInclude(typeof(TARIFA_CONCEPTO))]
	public TARIFA_CONCEPTO[] listarTARIFA_CONCEPTO() {
		      return gestionTARIFA_CONCEPTO.listarTARIFA_CONCEPTO();
	}
	
	[WebMethod]
	public bool eliminarTARIFA_CONCEPTO(TARIFA_CONCEPTO obj) {
			return gestionTARIFA_CONCEPTO.eliminarTARIFA_CONCEPTO(obj);
	}
}

}
