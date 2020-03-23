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

    public class ServiciosPagos : System.Web.Services.WebService
    {

        GestionPagos gestionPagos;


        public ServiciosPagos()
        {

            crearObjetos();
        }


        private void crearObjetos()
        {
            gestionPagos = new GestionPagos();

        }


        [WebMethod]
        [XmlInclude(typeof(Pagos))]
        public Pagos crearPagos(Pagos obj)
        {
            return gestionPagos.crearPagos(obj);
        }

        [WebMethod]
        public bool editarPagos(Pagos obj)
        {
            return gestionPagos.editarPagos(obj);
        }

        [WebMethod]
        [XmlInclude(typeof(Pagos))]
        public Pagos buscarPrimeroPagos(Pagos obj)
        {
            return gestionPagos.buscarPrimeroPagos(obj);
        }

        [WebMethod]
        [XmlInclude(typeof(Pagos))]
        public Pagos[] buscarPagos(Pagos obj)
        {
            return gestionPagos.buscarPagos(obj);
        }

        [WebMethod]
        [XmlInclude(typeof(Pagos))]
        public Pagos[] buscarPaginacionPagos(Pagos obj, int pag, int numReg)
        {
            return gestionPagos.buscarPagos(obj, pag, numReg);
        }

        [WebMethod]
        [XmlInclude(typeof(Pagos))]
        public Pagos[] listarPagos()
        {
            return gestionPagos.listarPagos();
        }

        [WebMethod]
        [XmlInclude(typeof(Pagos))]
        public Pagos[] listarPaginacionPagos(int pag, int numReg)
        {
            return gestionPagos.listarPagos(pag, numReg);
        }

        [WebMethod]
        public int contarBusquedaPagos(Pagos obj)
        {
            return gestionPagos.contarBusquedaPagos(obj);
        }

        [WebMethod]
        public bool eliminarPagos(Pagos obj)
        {
            return gestionPagos.eliminarPagos(obj);
        }
    }

}
