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

public class ServiciosVIGENCIA  : System.Web.Services.WebService {
	
	VIGENCIAManagement gestionVIGENCIA;
	
		
	public ServiciosVIGENCIA() {
		
		crearObjetos();
	}
	
	
    private void crearObjetos(){
		gestionVIGENCIA = new VIGENCIAManagement();
	}
	
	[WebMethod]
	[XmlInclude(typeof(VIGENCIA))]
	public VIGENCIA crearVIGENCIA(VIGENCIA obj) {
				return gestionVIGENCIA.crearVIGENCIA(obj); 
	}
	
	[WebMethod]
	public bool editarVIGENCIA(VIGENCIA obj) {
				return gestionVIGENCIA.editarVIGENCIA(obj);
	}
	
	[WebMethod]
	[XmlInclude(typeof(VIGENCIA))]
	public VIGENCIA buscarPrimeroVIGENCIA(VIGENCIA obj) {
				return gestionVIGENCIA.buscarPrimeroVIGENCIA(obj);
	}
	
	[WebMethod]
	[XmlInclude(typeof(VIGENCIA))]
	public VIGENCIA[] buscarVIGENCIA(VIGENCIA obj) {
    		return gestionVIGENCIA.buscarVIGENCIA(obj);
	}
	
	[WebMethod]
	[XmlInclude(typeof(VIGENCIA))]
	public VIGENCIA[] listarVIGENCIA() {
		      return gestionVIGENCIA.listarVIGENCIA();
	}
	
	[WebMethod]
	public bool eliminarVIGENCIA(VIGENCIA obj) {
			return gestionVIGENCIA.eliminarVIGENCIA(obj);
	}
}

}
