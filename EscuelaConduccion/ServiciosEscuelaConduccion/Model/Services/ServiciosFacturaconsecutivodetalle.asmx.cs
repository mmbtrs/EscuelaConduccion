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

public class ServiciosFacturaconsecutivodetalle  : System.Web.Services.WebService {
	
	GestionFacturaconsecutivodetalle gestionFacturaconsecutivodetalle;
	
		
	public ServiciosFacturaconsecutivodetalle() {
		
		crearObjetos();
	}
	
	
    private void crearObjetos(){
		gestionFacturaconsecutivodetalle = new GestionFacturaconsecutivodetalle();
	
	}
	

	[WebMethod]
	[XmlInclude(typeof(Facturaconsecutivodetalle))]
	public Facturaconsecutivodetalle crearFacturaconsecutivodetalle(Facturaconsecutivodetalle obj) {
				return gestionFacturaconsecutivodetalle.crearFacturaconsecutivodetalle(obj); 
	}
	
	[WebMethod]
	public bool editarFacturaconsecutivodetalle(Facturaconsecutivodetalle obj) {
				return gestionFacturaconsecutivodetalle.editarFacturaconsecutivodetalle(obj);
	}
	
	[WebMethod]
	[XmlInclude(typeof(Facturaconsecutivodetalle))]
	public Facturaconsecutivodetalle buscarPrimeroFacturaconsecutivodetalle(Facturaconsecutivodetalle obj) {
				return gestionFacturaconsecutivodetalle.buscarPrimeroFacturaconsecutivodetalle(obj);
	}

        [WebMethod]
        [XmlInclude(typeof(Facturaconsecutivodetalle))]
        public Facturaconsecutivodetalle obtenerFacturaconsecutivodetalle()
        {
            return gestionFacturaconsecutivodetalle.obtenerFacturaconsecutivodetalle();
        }

        [WebMethod]
	[XmlInclude(typeof(Facturaconsecutivodetalle))]
	public Facturaconsecutivodetalle[] buscarFacturaconsecutivodetalle(Facturaconsecutivodetalle obj) {
    		return gestionFacturaconsecutivodetalle.buscarFacturaconsecutivodetalle(obj);
	}
	
	[WebMethod]
	[XmlInclude(typeof(Facturaconsecutivodetalle))]
	public Facturaconsecutivodetalle[] buscarPaginacionFacturaconsecutivodetalle(Facturaconsecutivodetalle obj,int pag,int numReg) {
				return gestionFacturaconsecutivodetalle.buscarFacturaconsecutivodetalle(obj, pag, numReg);
	}
	
	[WebMethod]
	[XmlInclude(typeof(Facturaconsecutivodetalle))]
	public Facturaconsecutivodetalle[] listarFacturaconsecutivodetalle() {
		      return gestionFacturaconsecutivodetalle.listarFacturaconsecutivodetalle();
	}
	
	[WebMethod]
	[XmlInclude(typeof(Facturaconsecutivodetalle))]
	public Facturaconsecutivodetalle[] listarPaginacionFacturaconsecutivodetalle(int pag,int numReg) {
			return gestionFacturaconsecutivodetalle.listarFacturaconsecutivodetalle(pag, numReg);
	}
	
	[WebMethod]
	public int contarBusquedaFacturaconsecutivodetalle(Facturaconsecutivodetalle obj) {
			return gestionFacturaconsecutivodetalle.contarBusquedaFacturaconsecutivodetalle(obj);
	}
	
	[WebMethod]
	public bool eliminarFacturaconsecutivodetalle(Facturaconsecutivodetalle obj) {
			return gestionFacturaconsecutivodetalle.eliminarFacturaconsecutivodetalle(obj);
	}
}

}
