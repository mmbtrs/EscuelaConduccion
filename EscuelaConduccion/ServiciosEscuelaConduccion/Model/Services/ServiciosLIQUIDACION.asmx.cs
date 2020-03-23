using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Xml.Serialization;
using System.Web.Services.Protocols;

using ServiciosEscuelaConduccion.Model.Objects;
using ServiciosEscuelaConduccion.Model.Managements;
using System.Data;

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

    public class ServiciosLIQUIDACION : System.Web.Services.WebService
    {

        LIQUIDACIONManagement gestionLIQUIDACION;


        public ServiciosLIQUIDACION()
        {

            crearObjetos();
        }


        private void crearObjetos()
        {
            gestionLIQUIDACION = new LIQUIDACIONManagement();
        }

        [WebMethod]
        [XmlInclude(typeof(LIQUIDACION))]
        public LIQUIDACION crearLIQUIDACION(LIQUIDACION obj)
        {
            return gestionLIQUIDACION.crearLIQUIDACION(obj);
        }

        [WebMethod]
        [XmlInclude(typeof(TARIFA))]
        public DataSet crearMultipleLIQUIDACION_1(TARIFA tarifa, int id_cliente)
        {
            return gestionLIQUIDACION.crearMultipleLIQUIDACION_1(tarifa, id_cliente);
        }

        [WebMethod]
        [XmlInclude(typeof(TARIFA))]
        public LIQUIDACION crearMultipleLIQUIDACION_2(LIQUIDACION liquidacion, LIQUIDACION_DETALLE[] lstDetalles, VIEW_CLIENTE myCliente)
        {
            return gestionLIQUIDACION.crearMultipleLIQUIDACION_2(liquidacion, lstDetalles, myCliente);
        }

        [WebMethod]
        public bool editarLIQUIDACION(LIQUIDACION obj)
        {
            return gestionLIQUIDACION.editarLIQUIDACION(obj);
        }

        [WebMethod]
        [XmlInclude(typeof(LIQUIDACION))]
        public LIQUIDACION buscarPrimeroLIQUIDACION(LIQUIDACION obj)
        {
            return gestionLIQUIDACION.buscarPrimeroLIQUIDACION(obj);
        }

        [WebMethod]
        [XmlInclude(typeof(LIQUIDACION))]
        public LIQUIDACION[] buscarLIQUIDACION(LIQUIDACION obj)
        {
            return gestionLIQUIDACION.buscarLIQUIDACION(obj);
        }

        [WebMethod]
        [XmlInclude(typeof(LIQUIDACION))]
        public LIQUIDACION[] listarLIQUIDACION()
        {
            return gestionLIQUIDACION.listarLIQUIDACION();
        }

        [WebMethod]
        public bool eliminarLIQUIDACION(LIQUIDACION obj)
        {
            return gestionLIQUIDACION.eliminarLIQUIDACION(obj);
        }
    }

}
