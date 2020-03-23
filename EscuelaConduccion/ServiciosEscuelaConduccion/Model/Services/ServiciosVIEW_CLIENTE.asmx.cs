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

public class ServiciosVIEW_CLIENTE  : System.Web.Services.WebService {
	
	VIEW_CLIENTEManagement gestionVIEW_CLIENTE;
	
		
	public ServiciosVIEW_CLIENTE() {
		
		crearObjetos();
	}
	
	
    private void crearObjetos(){
		gestionVIEW_CLIENTE = new VIEW_CLIENTEManagement();
	}
	
	[WebMethod]
	[XmlInclude(typeof(VIEW_CLIENTE))]
	public VIEW_CLIENTE crearVIEW_CLIENTE(VIEW_CLIENTE obj) {
				return gestionVIEW_CLIENTE.crearVIEW_CLIENTE(obj); 
	}
	
	[WebMethod]
	public bool editarVIEW_CLIENTE(VIEW_CLIENTE obj) {
				return gestionVIEW_CLIENTE.editarVIEW_CLIENTE(obj);
	}
	
	[WebMethod]
	[XmlInclude(typeof(VIEW_CLIENTE))]
	public VIEW_CLIENTE buscarPrimeroVIEW_CLIENTE(VIEW_CLIENTE obj) {
				return gestionVIEW_CLIENTE.buscarPrimeroVIEW_CLIENTE(obj);
	}
	
	[WebMethod]
	[XmlInclude(typeof(VIEW_CLIENTE))]
	public VIEW_CLIENTE[] buscarVIEW_CLIENTE(VIEW_CLIENTE obj) {
    		return gestionVIEW_CLIENTE.buscarVIEW_CLIENTE(obj);
	}
	
	[WebMethod]
	[XmlInclude(typeof(VIEW_CLIENTE))]
	public VIEW_CLIENTE[] listarVIEW_CLIENTE() {
		      return gestionVIEW_CLIENTE.listarVIEW_CLIENTE();
	}
	
	[WebMethod]
	public bool eliminarVIEW_CLIENTE(VIEW_CLIENTE obj) {
			return gestionVIEW_CLIENTE.eliminarVIEW_CLIENTE(obj);
	}
}

}
