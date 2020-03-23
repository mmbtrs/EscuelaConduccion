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
            String cadenaConexion = @ConfigurationManager.ConnectionStrings["dbConducimos"].ConnectionString;
            conexion = new SqlConnection(cadenaConexion);//@"Data Source=DESKTOP-N65GSK5\SQLEXPRESS;Initial Catalog=EscuelaConduccion;Persist Security Info=True;User ID=su; Password=123");
            conexion.Open();
            return conexion;
        }
    }
}
