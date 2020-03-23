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

public class ServiciosFACTURA_ESTADO  : System.Web.Services.WebService {
	
	FACTURA_ESTADOManagement gestionFACTURA_ESTADO;
	
		
	public ServiciosFACTURA_ESTADO() {
		
		crearObjetos();
	}
	
	
    private void crearObjetos(){
		gestionFACTURA_ESTADO = new FACTURA_ESTADOManagement();
	}
	
	[WebMethod]
	[XmlInclude(typeof(FACTURA_ESTADO))]
	public FACTURA_ESTADO crearFACTURA_ESTADO(FACTURA_ESTADO obj) {
				return gestionFACTURA_ESTADO.crearFACTURA_ESTADO(obj); 
	}
	
	[WebMethod]
	public bool editarFACTURA_ESTADO(FACTURA_ESTADO obj) {
				return gestionFACTURA_ESTADO.editarFACTURA_ESTADO(obj);
	}
	
	[WebMethod]
	[XmlInclude(typeof(FACTURA_ESTADO))]
	public FACTURA_ESTADO buscarPrimeroFACTURA_ESTADO(FACTURA_ESTADO obj) {
				return gestionFACTURA_ESTADO.buscarPrimeroFACTURA_ESTADO(obj);
	}
	
	[WebMethod]
	[XmlInclude(typeof(FACTURA_ESTADO))]
	public FACTURA_ESTADO[] buscarFACTURA_ESTADO(FACTURA_ESTADO obj) {
    		return gestionFACTURA_ESTADO.buscarFACTURA_ESTADO(obj);
	}
	
	[WebMethod]
	[XmlInclude(typeof(FACTURA_ESTADO))]
	public FACTURA_ESTADO[] listarFACTURA_ESTADO() {
		      return gestionFACTURA_ESTADO.listarFACTURA_ESTADO();
	}
	
	[WebMethod]
	public bool eliminarFACTURA_ESTADO(FACTURA_ESTADO obj) {
			return gestionFACTURA_ESTADO.eliminarFACTURA_ESTADO(obj);
	}
}

}
