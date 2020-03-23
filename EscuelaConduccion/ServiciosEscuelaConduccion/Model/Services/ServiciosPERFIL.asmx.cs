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

public class ServiciosPERFIL  : System.Web.Services.WebService {
	
	PERFILManagement gestionPERFIL;
	
		
	public ServiciosPERFIL() {
		
		crearObjetos();
	}
	
	
    private void crearObjetos(){
		gestionPERFIL = new PERFILManagement();
	}
	
	[WebMethod]
	[XmlInclude(typeof(PERFIL))]
	public PERFIL crearPERFIL(PERFIL obj) {
				return gestionPERFIL.crearPERFIL(obj); 
	}
	
	[WebMethod]
	public bool editarPERFIL(PERFIL obj) {
				return gestionPERFIL.editarPERFIL(obj);
	}
	
	[WebMethod]
	[XmlInclude(typeof(PERFIL))]
	public PERFIL buscarPrimeroPERFIL(PERFIL obj) {
				return gestionPERFIL.buscarPrimeroPERFIL(obj);
	}
	
	[WebMethod]
	[XmlInclude(typeof(PERFIL))]
	public PERFIL[] buscarPERFIL(PERFIL obj) {
    		return gestionPERFIL.buscarPERFIL(obj);
	}
	
	[WebMethod]
	[XmlInclude(typeof(PERFIL))]
	public PERFIL[] listarPERFIL() {
		      return gestionPERFIL.listarPERFIL();
	}
	
	[WebMethod]
	public bool eliminarPERFIL(PERFIL obj) {
			return gestionPERFIL.eliminarPERFIL(obj);
	}
}

}
