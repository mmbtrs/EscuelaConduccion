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

public class ServiciosDIAFESTIVO  : System.Web.Services.WebService {
	
	DIAFESTIVOManagement gestionDIAFESTIVO;
	
		
	public ServiciosDIAFESTIVO() {
		
		crearObjetos();
	}
	
	
    private void crearObjetos(){
		gestionDIAFESTIVO = new DIAFESTIVOManagement();
	}
	
	[WebMethod]
	[XmlInclude(typeof(DIAFESTIVO))]
	public DIAFESTIVO crearDIAFESTIVO(DIAFESTIVO obj) {
				return gestionDIAFESTIVO.crearDIAFESTIVO(obj); 
	}
	
	[WebMethod]
	public bool editarDIAFESTIVO(DIAFESTIVO obj) {
				return gestionDIAFESTIVO.editarDIAFESTIVO(obj);
	}
	
	[WebMethod]
	[XmlInclude(typeof(DIAFESTIVO))]
	public DIAFESTIVO buscarPrimeroDIAFESTIVO(DIAFESTIVO obj) {
				return gestionDIAFESTIVO.buscarPrimeroDIAFESTIVO(obj);
	}
	
	[WebMethod]
	[XmlInclude(typeof(DIAFESTIVO))]
	public DIAFESTIVO[] buscarDIAFESTIVO(DIAFESTIVO obj) {
    		return gestionDIAFESTIVO.buscarDIAFESTIVO(obj);
	}
	
	[WebMethod]
	[XmlInclude(typeof(DIAFESTIVO))]
	public DIAFESTIVO[] listarDIAFESTIVO() {
		      return gestionDIAFESTIVO.listarDIAFESTIVO();
	}
	
	[WebMethod]
	public bool eliminarDIAFESTIVO(DIAFESTIVO obj) {
			return gestionDIAFESTIVO.eliminarDIAFESTIVO(obj);
	}
}

}
