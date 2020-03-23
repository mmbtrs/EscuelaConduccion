using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;


namespace ServiciosEscuelaConduccion.Model.DataAccess
{
    class AccessDB
    {
        static AccessDB instancia;
        SqlConnection conexion;

        private AccessDB()
        {
        }

        public static AccessDB obtenerInstancia()
        {
            if (instancia == null)
                instancia = new AccessDB();
            return instancia;
        }

        public SqlConnection conection()
        {
            conexion = new SqlConnection(@"");
            conexion.Open();
            return conexion;
        }
    }
}
