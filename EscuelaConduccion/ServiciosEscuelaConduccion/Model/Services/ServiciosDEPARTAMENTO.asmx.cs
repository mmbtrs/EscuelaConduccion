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

public class ServiciosDEPARTAMENTO  : System.Web.Services.WebService {
	
	DEPARTAMENTOManagement gestionDEPARTAMENTO;
	
		
	public ServiciosDEPARTAMENTO() {
		
		crearObjetos();
	}
	
	
    private void crearObjetos(){
		gestionDEPARTAMENTO = new DEPARTAMENTOManagement();
	}
	
	[WebMethod]
	[XmlInclude(typeof(DEPARTAMENTO))]
	public DEPARTAMENTO crearDEPARTAMENTO(DEPARTAMENTO obj) {
				return gestionDEPARTAMENTO.crearDEPARTAMENTO(obj); 
	}
	
	[WebMethod]
	public bool editarDEPARTAMENTO(DEPARTAMENTO obj) {
				return gestionDEPARTAMENTO.editarDEPARTAMENTO(obj);
	}
	
	[WebMethod]
	[XmlInclude(typeof(DEPARTAMENTO))]
	public DEPARTAMENTO buscarPrimeroDEPARTAMENTO(DEPARTAMENTO obj) {
				return gestionDEPARTAMENTO.buscarPrimeroDEPARTAMENTO(obj);
	}
	
	[WebMethod]
	[XmlInclude(typeof(DEPARTAMENTO))]
	public DEPARTAMENTO[] buscarDEPARTAMENTO(DEPARTAMENTO obj) {
    		return gestionDEPARTAMENTO.buscarDEPARTAMENTO(obj);
	}
	
	[WebMethod]
	[XmlInclude(typeof(DEPARTAMENTO))]
	public DEPARTAMENTO[] listarDEPARTAMENTO() {
		      return gestionDEPARTAMENTO.listarDEPARTAMENTO();
	}
	
	[WebMethod]
	public bool eliminarDEPARTAMENTO(DEPARTAMENTO obj) {
			return gestionDEPARTAMENTO.eliminarDEPARTAMENTO(obj);
	}
}

}
