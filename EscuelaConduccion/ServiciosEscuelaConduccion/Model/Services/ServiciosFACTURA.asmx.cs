using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Xml.Serialization;
using System.Web.Services.Protocols;

using ServiciosEscuelaConduccion.Model.Objects;
using ServiciosEscuelaConduccion.Model.Managements;
using ServiciosEscuelaConduccion.objetos;

namespace ServiciosEscuelaConduccion.Model.Services
{

    /// <summary>
    /// Descripción breve de ServicioClase
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio Web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]

    public class ServiciosFACTURA : System.Web.Services.WebService
    {

        FACTURAManagement gestionFACTURA;


        public ServiciosFACTURA()
        {

            crearObjetos();
        }


        private void crearObjetos()
        {
            gestionFACTURA = new FACTURAManagement();
        }

        [WebMethod]
        [XmlInclude(typeof(FACTURA))]
        public FACTURA crearFACTURA(FACTURA obj)
        {
            return gestionFACTURA.crearFACTURA(obj);
        }

        [WebMethod]
        [XmlInclude(typeof(RECIBO))]
        public FACTURA generarFACTURA(LIQUIDACION liquidacion, LIQUIDACION_DETALLE[] lstDetalles, VIEW_CLIENTE myCliente, Facturaconsecutivodetalle rango)
        {
            return gestionFACTURA.generarFACTURA(liquidacion, lstDetalles, myCliente, rango);
        }

        [WebMethod]
        public bool editarFACTURA(FACTURA obj)
        {
            return gestionFACTURA.editarFACTURA(obj);
        }

        [WebMethod]
        [XmlInclude(typeof(FACTURA))]
        public FACTURA buscarPrimeroFACTURA(FACTURA obj)
        {
            return gestionFACTURA.buscarPrimeroFACTURA(obj);
        }

        [WebMethod]
        [XmlInclude(typeof(FACTURA))]
        public FACTURA[] buscarFACTURA(FACTURA obj)
        {
            return gestionFACTURA.buscarFACTURA(obj);
        }

        [WebMethod]
        [XmlInclude(typeof(FACTURA))]
        public FACTURA[] listarFACTURA()
        {
            return gestionFACTURA.listarFACTURA();
        }

        [WebMethod]
        public bool eliminarFACTURA(FACTURA obj)
        {
            return gestionFACTURA.eliminarFACTURA(obj);
        }
    }

}
