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

public class ServiciosGENERO  : System.Web.Services.WebService {
	
	GENEROManagement gestionGENERO;
	
		
	public ServiciosGENERO() {
		
		crearObjetos();
	}
	
	
    private void crearObjetos(){
		gestionGENERO = new GENEROManagement();
	}
	
	[WebMethod]
	[XmlInclude(typeof(GENERO))]
	public GENERO crearGENERO(GENERO obj) {
				return gestionGENERO.crearGENERO(obj); 
	}
	
	[WebMethod]
	public bool editarGENERO(GENERO obj) {
				return gestionGENERO.editarGENERO(obj);
	}
	
	[WebMethod]
	[XmlInclude(typeof(GENERO))]
	public GENERO buscarPrimeroGENERO(GENERO obj) {
				return gestionGENERO.buscarPrimeroGENERO(obj);
	}
	
	[WebMethod]
	[XmlInclude(typeof(GENERO))]
	public GENERO[] buscarGENERO(GENERO obj) {
    		return gestionGENERO.buscarGENERO(obj);
	}
	
	[WebMethod]
	[XmlInclude(typeof(GENERO))]
	public GENERO[] listarGENERO() {
		      return gestionGENERO.listarGENERO();
	}
	
	[WebMethod]
	public bool eliminarGENERO(GENERO obj) {
			return gestionGENERO.eliminarGENERO(obj);
	}
}

}
