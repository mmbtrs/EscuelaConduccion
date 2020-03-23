using ServiciosEscuelaConduccion.Model.Managements;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace ServiciosEscuelaConduccion.Model.Services
{
    /// <summary>
    /// Descripción breve de ServiciosSQL
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class ServiciosSQL : System.Web.Services.WebService
    {
        SQLManagement gestionSQL;

        public ServiciosSQL()
        {
            crearObjetos();
        }

        private void crearObjetos()
        {
            gestionSQL = new SQLManagement();
        }

        [WebMethod]
        public DataSet consultaSQL(string sql, string nombre_tabla)
        {
            return gestionSQL.consultaSQL(sql, nombre_tabla);
        }
    }
}
