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

    public class ServiciosACUERDO_PAGO_DETALLE : System.Web.Services.WebService
    {

        ACUERDO_PAGO_DETALLEManagement gestionACUERDO_PAGO_DETALLE;


        public ServiciosACUERDO_PAGO_DETALLE()
        {

            crearObjetos();
        }


        private void crearObjetos()
        {
            gestionACUERDO_PAGO_DETALLE = new ACUERDO_PAGO_DETALLEManagement();
        }

        [WebMethod]
        [XmlInclude(typeof(ACUERDO_PAGO_DETALLE))]
        public ACUERDO_PAGO_DETALLE crearACUERDO_PAGO_DETALLE(ACUERDO_PAGO_DETALLE obj)
        {
            return gestionACUERDO_PAGO_DETALLE.crearACUERDO_PAGO_DETALLE(obj);
        }

        [WebMethod]
        [XmlInclude(typeof(ACUERDO_PAGO_DETALLE))]
        public bool crearACUERDO_PAGO_DETALLE_Masivo(ACUERDO_PAGO_DETALLE[] lst)
        {
            return gestionACUERDO_PAGO_DETALLE.crearACUERDO_PAGO_DETALLE_Masivo(lst);
        }

        [WebMethod]
        public bool editarACUERDO_PAGO_DETALLE(ACUERDO_PAGO_DETALLE obj)
        {
            return gestionACUERDO_PAGO_DETALLE.editarACUERDO_PAGO_DETALLE(obj);
        }

        [WebMethod]
        [XmlInclude(typeof(ACUERDO_PAGO_DETALLE))]
        public ACUERDO_PAGO_DETALLE buscarPrimeroACUERDO_PAGO_DETALLE(ACUERDO_PAGO_DETALLE obj)
        {
            return gestionACUERDO_PAGO_DETALLE.buscarPrimeroACUERDO_PAGO_DETALLE(obj);
        }

        [WebMethod]
        [XmlInclude(typeof(ACUERDO_PAGO_DETALLE))]
        public ACUERDO_PAGO_DETALLE[] buscarACUERDO_PAGO_DETALLE(ACUERDO_PAGO_DETALLE obj)
        {
            return gestionACUERDO_PAGO_DETALLE.buscarACUERDO_PAGO_DETALLE(obj);
        }

        [WebMethod]
        [XmlInclude(typeof(ACUERDO_PAGO_DETALLE))]
        public ACUERDO_PAGO_DETALLE[] listarACUERDO_PAGO_DETALLE()
        {
            return gestionACUERDO_PAGO_DETALLE.listarACUERDO_PAGO_DETALLE();
        }

        [WebMethod]
        public bool eliminarACUERDO_PAGO_DETALLE(ACUERDO_PAGO_DETALLE obj)
        {
            return gestionACUERDO_PAGO_DETALLE.eliminarACUERDO_PAGO_DETALLE(obj);
        }
    }

}
