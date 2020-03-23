using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Xml.Serialization;
using System.Web.Services.Protocols;

using ServiciosEscuelaConduccion.objetos;
using ServiciosEscuelaConduccion.gestion;


namespace ServiciosEscuelaConduccion.Servicios  {

/// <summary>
/// Descripción breve de ServicioClase
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
[System.ComponentModel.ToolboxItem(false)]
// Para permitir que se llame a este servicio Web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
// [System.Web.Script.Services.ScriptService]

public class ServiciosViewrecibo  : System.Web.Services.WebService {
	
	GestionViewrecibo gestionViewrecibo;
	
		
	public ServiciosViewrecibo() {
		
		crearObjetos();
	}
	
	
    private void crearObjetos(){
		gestionViewrecibo = new GestionViewrecibo();
	
	}
	

	[WebMethod]
	[XmlInclude(typeof(Viewrecibo))]
	public Viewrecibo buscarPrimeroViewrecibo(Viewrecibo obj) {
				return gestionViewrecibo.buscarPrimeroViewrecibo(obj);
	}
	
	[WebMethod]
	[XmlInclude(typeof(Viewrecibo))]
	public Viewrecibo[] buscarViewrecibo(Viewrecibo obj) {
    		return gestionViewrecibo.buscarViewrecibo(obj);
	}
	
	[WebMethod]
	[XmlInclude(typeof(Viewrecibo))]
	public Viewrecibo[] buscarPaginacionViewrecibo(Viewrecibo obj,int pag,int numReg) {
				return gestionViewrecibo.buscarViewrecibo(obj, pag, numReg);
	}
	
	[WebMethod]
	[XmlInclude(typeof(Viewrecibo))]
	public Viewrecibo[] listarViewrecibo() {
		      return gestionViewrecibo.listarViewrecibo();
	}
	
	[WebMethod]
	[XmlInclude(typeof(Viewrecibo))]
	public Viewrecibo[] listarPaginacionViewrecibo(int pag,int numReg) {
			return gestionViewrecibo.listarViewrecibo(pag, numReg);
	}
	
	[WebMethod]
	public int contarBusquedaViewrecibo(Viewrecibo obj) {
			return gestionViewrecibo.contarBusquedaViewrecibo(obj);
	}
	
}

}
