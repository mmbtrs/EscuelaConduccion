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

public class ServiciosTIPO_DOCUMENTO  : System.Web.Services.WebService {
	
	TIPO_DOCUMENTOManagement gestionTIPO_DOCUMENTO;
	
		
	public ServiciosTIPO_DOCUMENTO() {
		
		crearObjetos();
	}
	
	
    private void crearObjetos(){
		gestionTIPO_DOCUMENTO = new TIPO_DOCUMENTOManagement();
	}
	
	[WebMethod]
	[XmlInclude(typeof(TIPO_DOCUMENTO))]
	public TIPO_DOCUMENTO crearTIPO_DOCUMENTO(TIPO_DOCUMENTO obj) {
				return gestionTIPO_DOCUMENTO.crearTIPO_DOCUMENTO(obj); 
	}
	
	[WebMethod]
	public bool editarTIPO_DOCUMENTO(TIPO_DOCUMENTO obj) {
				return gestionTIPO_DOCUMENTO.editarTIPO_DOCUMENTO(obj);
	}
	
	[WebMethod]
	[XmlInclude(typeof(TIPO_DOCUMENTO))]
	public TIPO_DOCUMENTO buscarPrimeroTIPO_DOCUMENTO(TIPO_DOCUMENTO obj) {
				return gestionTIPO_DOCUMENTO.buscarPrimeroTIPO_DOCUMENTO(obj);
	}
	
	[WebMethod]
	[XmlInclude(typeof(TIPO_DOCUMENTO))]
	public TIPO_DOCUMENTO[] buscarTIPO_DOCUMENTO(TIPO_DOCUMENTO obj) {
    		return gestionTIPO_DOCUMENTO.buscarTIPO_DOCUMENTO(obj);
	}
	
	[WebMethod]
	[XmlInclude(typeof(TIPO_DOCUMENTO))]
	public TIPO_DOCUMENTO[] listarTIPO_DOCUMENTO() {
		      return gestionTIPO_DOCUMENTO.listarTIPO_DOCUMENTO();
	}
	
	[WebMethod]
	public bool eliminarTIPO_DOCUMENTO(TIPO_DOCUMENTO obj) {
			return gestionTIPO_DOCUMENTO.eliminarTIPO_DOCUMENTO(obj);
	}
}

}
