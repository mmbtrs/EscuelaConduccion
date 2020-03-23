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

public class ServiciosACUERDO_PAGO  : System.Web.Services.WebService {
	
	ACUERDO_PAGOManagement gestionACUERDO_PAGO;
	
		
	public ServiciosACUERDO_PAGO() {
		
		crearObjetos();
	}
	
	
    private void crearObjetos(){
		gestionACUERDO_PAGO = new ACUERDO_PAGOManagement();
	}
	
	[WebMethod]
	[XmlInclude(typeof(ACUERDO_PAGO))]
	public ACUERDO_PAGO crearACUERDO_PAGO(ACUERDO_PAGO obj) {
				return gestionACUERDO_PAGO.crearACUERDO_PAGO(obj); 
	}
	
	[WebMethod]
	public bool editarACUERDO_PAGO(ACUERDO_PAGO obj) {
				return gestionACUERDO_PAGO.editarACUERDO_PAGO(obj);
	}
	
	[WebMethod]
	[XmlInclude(typeof(ACUERDO_PAGO))]
	public ACUERDO_PAGO buscarPrimeroACUERDO_PAGO(ACUERDO_PAGO obj) {
				return gestionACUERDO_PAGO.buscarPrimeroACUERDO_PAGO(obj);
	}
	
	[WebMethod]
	[XmlInclude(typeof(ACUERDO_PAGO))]
	public ACUERDO_PAGO[] buscarACUERDO_PAGO(ACUERDO_PAGO obj) {
    		return gestionACUERDO_PAGO.buscarACUERDO_PAGO(obj);
	}
	
	[WebMethod]
	[XmlInclude(typeof(ACUERDO_PAGO))]
	public ACUERDO_PAGO[] listarACUERDO_PAGO() {
		      return gestionACUERDO_PAGO.listarACUERDO_PAGO();
	}
	
	[WebMethod]
	public bool eliminarACUERDO_PAGO(ACUERDO_PAGO obj) {
			return gestionACUERDO_PAGO.eliminarACUERDO_PAGO(obj);
	}
}

}
