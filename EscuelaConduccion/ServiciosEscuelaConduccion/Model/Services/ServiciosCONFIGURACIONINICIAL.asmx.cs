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

public class ServiciosCONFIGURACIONINICIAL  : System.Web.Services.WebService {
	
	CONFIGURACIONINICIALManagement gestionCONFIGURACIONINICIAL;
	
		
	public ServiciosCONFIGURACIONINICIAL() {
		
		crearObjetos();
	}
	
	
    private void crearObjetos(){
		gestionCONFIGURACIONINICIAL = new CONFIGURACIONINICIALManagement();
	}
	
	[WebMethod]
	[XmlInclude(typeof(CONFIGURACIONINICIAL))]
	public CONFIGURACIONINICIAL crearCONFIGURACIONINICIAL(CONFIGURACIONINICIAL obj) {
				return gestionCONFIGURACIONINICIAL.crearCONFIGURACIONINICIAL(obj); 
	}
	
	[WebMethod]
	public bool editarCONFIGURACIONINICIAL(CONFIGURACIONINICIAL obj) {
				return gestionCONFIGURACIONINICIAL.editarCONFIGURACIONINICIAL(obj);
	}
	
	[WebMethod]
	[XmlInclude(typeof(CONFIGURACIONINICIAL))]
	public CONFIGURACIONINICIAL buscarPrimeroCONFIGURACIONINICIAL(CONFIGURACIONINICIAL obj) {
				return gestionCONFIGURACIONINICIAL.buscarPrimeroCONFIGURACIONINICIAL(obj);
	}
	
	[WebMethod]
	[XmlInclude(typeof(CONFIGURACIONINICIAL))]
	public CONFIGURACIONINICIAL[] buscarCONFIGURACIONINICIAL(CONFIGURACIONINICIAL obj) {
    		return gestionCONFIGURACIONINICIAL.buscarCONFIGURACIONINICIAL(obj);
	}
	
	[WebMethod]
	[XmlInclude(typeof(CONFIGURACIONINICIAL))]
	public CONFIGURACIONINICIAL[] listarCONFIGURACIONINICIAL() {
		      return gestionCONFIGURACIONINICIAL.listarCONFIGURACIONINICIAL();
	}
	
	[WebMethod]
	public bool eliminarCONFIGURACIONINICIAL(CONFIGURACIONINICIAL obj) {
			return gestionCONFIGURACIONINICIAL.eliminarCONFIGURACIONINICIAL(obj);
	}
}

}
