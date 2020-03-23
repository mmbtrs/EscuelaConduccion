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

public class ServiciosACUERDO_ESTADO  : System.Web.Services.WebService {
	
	ACUERDO_ESTADOManagement gestionACUERDO_ESTADO;
	
		
	public ServiciosACUERDO_ESTADO() {
		
		crearObjetos();
	}
	
	
    private void crearObjetos(){
		gestionACUERDO_ESTADO = new ACUERDO_ESTADOManagement();
	}
	
	[WebMethod]
	[XmlInclude(typeof(ACUERDO_ESTADO))]
	public ACUERDO_ESTADO crearACUERDO_ESTADO(ACUERDO_ESTADO obj) {
				return gestionACUERDO_ESTADO.crearACUERDO_ESTADO(obj); 
	}
	
	[WebMethod]
	public bool editarACUERDO_ESTADO(ACUERDO_ESTADO obj) {
				return gestionACUERDO_ESTADO.editarACUERDO_ESTADO(obj);
	}
	
	[WebMethod]
	[XmlInclude(typeof(ACUERDO_ESTADO))]
	public ACUERDO_ESTADO buscarPrimeroACUERDO_ESTADO(ACUERDO_ESTADO obj) {
				return gestionACUERDO_ESTADO.buscarPrimeroACUERDO_ESTADO(obj);
	}
	
	[WebMethod]
	[XmlInclude(typeof(ACUERDO_ESTADO))]
	public ACUERDO_ESTADO[] buscarACUERDO_ESTADO(ACUERDO_ESTADO obj) {
    		return gestionACUERDO_ESTADO.buscarACUERDO_ESTADO(obj);
	}
	
	[WebMethod]
	[XmlInclude(typeof(ACUERDO_ESTADO))]
	public ACUERDO_ESTADO[] listarACUERDO_ESTADO() {
		      return gestionACUERDO_ESTADO.listarACUERDO_ESTADO();
	}
	
	[WebMethod]
	public bool eliminarACUERDO_ESTADO(ACUERDO_ESTADO obj) {
			return gestionACUERDO_ESTADO.eliminarACUERDO_ESTADO(obj);
	}
}

}
