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

public class ServiciosFACTURACONSECUTIVO  : System.Web.Services.WebService {
	
	FACTURACONSECUTIVOManagement gestionFACTURACONSECUTIVO;
	
		
	public ServiciosFACTURACONSECUTIVO() {
		
		crearObjetos();
	}
	
	
    private void crearObjetos(){
		gestionFACTURACONSECUTIVO = new FACTURACONSECUTIVOManagement();
	}
	
	[WebMethod]
	[XmlInclude(typeof(FACTURACONSECUTIVO))]
	public FACTURACONSECUTIVO crearFACTURACONSECUTIVO(FACTURACONSECUTIVO obj) {
				return gestionFACTURACONSECUTIVO.crearFACTURACONSECUTIVO(obj); 
	}
	
	[WebMethod]
	public bool editarFACTURACONSECUTIVO(FACTURACONSECUTIVO obj) {
				return gestionFACTURACONSECUTIVO.editarFACTURACONSECUTIVO(obj);
	}
	
	[WebMethod]
	[XmlInclude(typeof(FACTURACONSECUTIVO))]
	public FACTURACONSECUTIVO buscarPrimeroFACTURACONSECUTIVO(FACTURACONSECUTIVO obj) {
				return gestionFACTURACONSECUTIVO.buscarPrimeroFACTURACONSECUTIVO(obj);
	}
	
	[WebMethod]
	[XmlInclude(typeof(FACTURACONSECUTIVO))]
	public FACTURACONSECUTIVO[] buscarFACTURACONSECUTIVO(FACTURACONSECUTIVO obj) {
    		return gestionFACTURACONSECUTIVO.buscarFACTURACONSECUTIVO(obj);
	}
	
	[WebMethod]
	[XmlInclude(typeof(FACTURACONSECUTIVO))]
	public FACTURACONSECUTIVO[] listarFACTURACONSECUTIVO() {
		      return gestionFACTURACONSECUTIVO.listarFACTURACONSECUTIVO();
	}
	
	[WebMethod]
	public bool eliminarFACTURACONSECUTIVO(FACTURACONSECUTIVO obj) {
			return gestionFACTURACONSECUTIVO.eliminarFACTURACONSECUTIVO(obj);
	}
}

}
