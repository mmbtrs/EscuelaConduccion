using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Xml.Serialization;
using System.Web.Services.Protocols;

using ServiciosEscuelaConduccion.Model.Objects;
using ServiciosEscuelaConduccion.Model.Managements;


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

    public class ServiciosRECIBO : System.Web.Services.WebService
    {

        RECIBOManagement gestionRECIBO;


        public ServiciosRECIBO()
        {

            crearObjetos();
        }


        private void crearObjetos()
        {
            gestionRECIBO = new RECIBOManagement();
        }

        [WebMethod]
        [XmlInclude(typeof(RECIBO))]
        public RECIBO crearRECIBO(RECIBO obj)
        {
            return gestionRECIBO.crearRECIBO(obj);
        }

        [WebMethod]
        [XmlInclude(typeof(RECIBO))]
        public RECIBO generarRECIBO(LIQUIDACION liquidacion, LIQUIDACION_DETALLE[] lstDetalles, VIEW_CLIENTE myCliente)
        {
            return gestionRECIBO.generarRECIBO(liquidacion, lstDetalles, myCliente);
        }

        [WebMethod]
        public bool editarRECIBO(RECIBO obj)
        {
            return gestionRECIBO.editarRECIBO(obj);
        }

        [WebMethod]
        [XmlInclude(typeof(RECIBO))]
        public RECIBO buscarPrimeroRECIBO(RECIBO obj)
        {
            return gestionRECIBO.buscarPrimeroRECIBO(obj);
        }

        [WebMethod]
        [XmlInclude(typeof(RECIBO))]
        public RECIBO[] buscarRECIBO(RECIBO obj)
        {
            return gestionRECIBO.buscarRECIBO(obj);
        }

        [WebMethod]
        [XmlInclude(typeof(RECIBO))]
        public RECIBO[] listarRECIBO()
        {
            return gestionRECIBO.listarRECIBO();
        }

        [WebMethod]
        public bool eliminarRECIBO(RECIBO obj)
        {
            return gestionRECIBO.eliminarRECIBO(obj);
        }
    }

}
