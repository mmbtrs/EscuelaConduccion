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

public class ServiciosCLIENTE  : System.Web.Services.WebService {
	
	CLIENTEManagement gestionCLIENTE;
	
		
	public ServiciosCLIENTE() {
		
		crearObjetos();
	}
	
	
    private void crearObjetos(){
		gestionCLIENTE = new CLIENTEManagement();
	}
	
	[WebMethod]
	[XmlInclude(typeof(CLIENTE))]
	public CLIENTE crearCLIENTE(CLIENTE obj) {
				return gestionCLIENTE.crearCLIENTE(obj); 
	}
	
	[WebMethod]
	public bool editarCLIENTE(CLIENTE obj) {
				return gestionCLIENTE.editarCLIENTE(obj);
	}
	
	[WebMethod]
	[XmlInclude(typeof(CLIENTE))]
	public CLIENTE buscarPrimeroCLIENTE(CLIENTE obj) {
				return gestionCLIENTE.buscarPrimeroCLIENTE(obj);
	}
	
	[WebMethod]
	[XmlInclude(typeof(CLIENTE))]
	public CLIENTE[] buscarCLIENTE(CLIENTE obj) {
    		return gestionCLIENTE.buscarCLIENTE(obj);
	}
	
	[WebMethod]
	[XmlInclude(typeof(CLIENTE))]
	public CLIENTE[] listarCLIENTE() {
		      return gestionCLIENTE.listarCLIENTE();
	}
	
	[WebMethod]
	public bool eliminarCLIENTE(CLIENTE obj) {
			return gestionCLIENTE.eliminarCLIENTE(obj);
	}
}

}
