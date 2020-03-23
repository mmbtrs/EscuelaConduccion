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

public class ServiciosCIUDAD  : System.Web.Services.WebService {
	
	CIUDADManagement gestionCIUDAD;
	
		
	public ServiciosCIUDAD() {
		
		crearObjetos();
	}
	
	
    private void crearObjetos(){
		gestionCIUDAD = new CIUDADManagement();
	}
	
	[WebMethod]
	[XmlInclude(typeof(CIUDAD))]
	public CIUDAD crearCIUDAD(CIUDAD obj) {
				return gestionCIUDAD.crearCIUDAD(obj); 
	}
	
	[WebMethod]
	public bool editarCIUDAD(CIUDAD obj) {
				return gestionCIUDAD.editarCIUDAD(obj);
	}
	
	[WebMethod]
	[XmlInclude(typeof(CIUDAD))]
	public CIUDAD buscarPrimeroCIUDAD(CIUDAD obj) {
				return gestionCIUDAD.buscarPrimeroCIUDAD(obj);
	}
	
	[WebMethod]
	[XmlInclude(typeof(CIUDAD))]
	public CIUDAD[] buscarCIUDAD(CIUDAD obj) {
    		return gestionCIUDAD.buscarCIUDAD(obj);
	}
	
	[WebMethod]
	[XmlInclude(typeof(CIUDAD))]
	public CIUDAD[] listarCIUDAD() {
		      return gestionCIUDAD.listarCIUDAD();
	}
	
	[WebMethod]
	public bool eliminarCIUDAD(CIUDAD obj) {
			return gestionCIUDAD.eliminarCIUDAD(obj);
	}
}

}
