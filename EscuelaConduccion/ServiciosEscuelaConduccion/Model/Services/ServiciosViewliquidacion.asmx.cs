using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Xml.Serialization;
using System.Web.Services.Protocols;

using ServiciosEscuelaConduccion.objetos;
using ServiciosEscuelaConduccion.gestion;


namespace ServiciosEscuelaConduccion.Servicios
{

    /// <summary>
    /// Descripción breve de ServicioClase
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio Web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]

    public class ServiciosViewliquidacion : System.Web.Services.WebService
    {

        GestionViewliquidacion gestionViewliquidacion;


        public ServiciosViewliquidacion()
        {

            crearObjetos();
        }


        private void crearObjetos()
        {
            gestionViewliquidacion = new GestionViewliquidacion();

        }


        [WebMethod]
        [XmlInclude(typeof(Viewliquidacion))]
        public Viewliquidacion buscarPrimeroViewliquidacion(Viewliquidacion obj)
        {
            return gestionViewliquidacion.buscarPrimeroViewliquidacion(obj);
        }

        [WebMethod]
        [XmlInclude(typeof(Viewliquidacion))]
        public Viewliquidacion[] buscarViewliquidacion(Viewliquidacion obj)
        {
            return gestionViewliquidacion.buscarViewliquidacion(obj);
        }

        [WebMethod]
        [XmlInclude(typeof(Viewliquidacion))]
        public Viewliquidacion[] buscarViewliquidacionBetween(Viewliquidacion obj, DateTime fechaIniLiq, DateTime fechaFinLiq, DateTime fechaIniPag, DateTime fechaFinPag)
        {
            return gestionViewliquidacion.buscarViewliquidacionBetween(obj,fechaIniLiq, fechaFinLiq, fechaIniPag, fechaFinPag);
        }

        [WebMethod]
        [XmlInclude(typeof(Viewliquidacion))]
        public Viewliquidacion[] buscarPaginacionViewliquidacion(Viewliquidacion obj, int pag, int numReg)
        {
            return gestionViewliquidacion.buscarViewliquidacion(obj, pag, numReg);
        }

        [WebMethod]
        [XmlInclude(typeof(Viewliquidacion))]
        public Viewliquidacion[] listarViewliquidacion()
        {
            return gestionViewliquidacion.listarViewliquidacion();
        }

        [WebMethod]
        [XmlInclude(typeof(Viewliquidacion))]
        public Viewliquidacion[] listarPaginacionViewliquidacion(int pag, int numReg)
        {
            return gestionViewliquidacion.listarViewliquidacion(pag, numReg);
        }

        [WebMethod]
        public int contarBusquedaViewliquidacion(Viewliquidacion obj)
        {
            return gestionViewliquidacion.contarBusquedaViewliquidacion(obj);
        }

    }

}
