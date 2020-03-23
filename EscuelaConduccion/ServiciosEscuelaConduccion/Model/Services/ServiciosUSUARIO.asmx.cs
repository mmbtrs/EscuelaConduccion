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

public class ServiciosUSUARIO  : System.Web.Services.WebService {
	
	USUARIOManagement gestionUSUARIO;
	
		
	public ServiciosUSUARIO() {
		
		crearObjetos();
	}
	
	
    private void crearObjetos(){
		gestionUSUARIO = new USUARIOManagement();
	}
	
	[WebMethod]
	[XmlInclude(typeof(USUARIO))]
	public USUARIO crearUSUARIO(USUARIO obj) {
				return gestionUSUARIO.crearUSUARIO(obj); 
	}
	
	[WebMethod]
	public bool editarUSUARIO(USUARIO obj) {
				return gestionUSUARIO.editarUSUARIO(obj);
	}
	
	[WebMethod]
	[XmlInclude(typeof(USUARIO))]
	public USUARIO buscarPrimeroUSUARIO(USUARIO obj) {
				return gestionUSUARIO.buscarPrimeroUSUARIO(obj);
	}
	
	[WebMethod]
	[XmlInclude(typeof(USUARIO))]
	public USUARIO[] buscarUSUARIO(USUARIO obj) {
    		return gestionUSUARIO.buscarUSUARIO(obj);
	}
	
	[WebMethod]
	[XmlInclude(typeof(USUARIO))]
	public USUARIO[] listarUSUARIO() {
		      return gestionUSUARIO.listarUSUARIO();
	}
	
	[WebMethod]
	public bool eliminarUSUARIO(USUARIO obj) {
			return gestionUSUARIO.eliminarUSUARIO(obj);
	}
}

}
