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

public class ServiciosRECIBO_ESTADO  : System.Web.Services.WebService {
	
	RECIBO_ESTADOManagement gestionRECIBO_ESTADO;
	
		
	public ServiciosRECIBO_ESTADO() {
		
		crearObjetos();
	}
	
	
    private void crearObjetos(){
		gestionRECIBO_ESTADO = new RECIBO_ESTADOManagement();
	}
	
	[WebMethod]
	[XmlInclude(typeof(RECIBO_ESTADO))]
	public RECIBO_ESTADO crearRECIBO_ESTADO(RECIBO_ESTADO obj) {
				return gestionRECIBO_ESTADO.crearRECIBO_ESTADO(obj); 
	}
	
	[WebMethod]
	public bool editarRECIBO_ESTADO(RECIBO_ESTADO obj) {
				return gestionRECIBO_ESTADO.editarRECIBO_ESTADO(obj);
	}
	
	[WebMethod]
	[XmlInclude(typeof(RECIBO_ESTADO))]
	public RECIBO_ESTADO buscarPrimeroRECIBO_ESTADO(RECIBO_ESTADO obj) {
				return gestionRECIBO_ESTADO.buscarPrimeroRECIBO_ESTADO(obj);
	}
	
	[WebMethod]
	[XmlInclude(typeof(RECIBO_ESTADO))]
	public RECIBO_ESTADO[] buscarRECIBO_ESTADO(RECIBO_ESTADO obj) {
    		return gestionRECIBO_ESTADO.buscarRECIBO_ESTADO(obj);
	}
	
	[WebMethod]
	[XmlInclude(typeof(RECIBO_ESTADO))]
	public RECIBO_ESTADO[] listarRECIBO_ESTADO() {
		      return gestionRECIBO_ESTADO.listarRECIBO_ESTADO();
	}
	
	[WebMethod]
	public bool eliminarRECIBO_ESTADO(RECIBO_ESTADO obj) {
			return gestionRECIBO_ESTADO.eliminarRECIBO_ESTADO(obj);
	}
}

}
