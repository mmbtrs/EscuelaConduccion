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

public class ServiciosTARIFACATEGORIA  : System.Web.Services.WebService {
	
	TARIFACATEGORIAManagement gestionTARIFACATEGORIA;
	
		
	public ServiciosTARIFACATEGORIA() {
		
		crearObjetos();
	}
	
	
    private void crearObjetos(){
		gestionTARIFACATEGORIA = new TARIFACATEGORIAManagement();
	}
	
	[WebMethod]
	[XmlInclude(typeof(TARIFACATEGORIA))]
	public TARIFACATEGORIA crearTARIFACATEGORIA(TARIFACATEGORIA obj) {
				return gestionTARIFACATEGORIA.crearTARIFACATEGORIA(obj); 
	}
	
	[WebMethod]
	public bool editarTARIFACATEGORIA(TARIFACATEGORIA obj) {
				return gestionTARIFACATEGORIA.editarTARIFACATEGORIA(obj);
	}
	
	[WebMethod]
	[XmlInclude(typeof(TARIFACATEGORIA))]
	public TARIFACATEGORIA buscarPrimeroTARIFACATEGORIA(TARIFACATEGORIA obj) {
				return gestionTARIFACATEGORIA.buscarPrimeroTARIFACATEGORIA(obj);
	}
	
	[WebMethod]
	[XmlInclude(typeof(TARIFACATEGORIA))]
	public TARIFACATEGORIA[] buscarTARIFACATEGORIA(TARIFACATEGORIA obj) {
    		return gestionTARIFACATEGORIA.buscarTARIFACATEGORIA(obj);
	}
	
	[WebMethod]
	[XmlInclude(typeof(TARIFACATEGORIA))]
	public TARIFACATEGORIA[] listarTARIFACATEGORIA() {
		      return gestionTARIFACATEGORIA.listarTARIFACATEGORIA();
	}
	
	[WebMethod]
	public bool eliminarTARIFACATEGORIA(TARIFACATEGORIA obj) {
			return gestionTARIFACATEGORIA.eliminarTARIFACATEGORIA(obj);
	}
}

}
