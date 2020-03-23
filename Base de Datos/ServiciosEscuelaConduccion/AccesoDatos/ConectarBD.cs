using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;


namespace AccesoDatos
{
    class ConectarBD
    {


        static ConectarBD instancia;
        SqlConnection conexion;

        private ConectarBD()
        {

        }


        public static ConectarBD obtenerInstancia()
        {
            if (instancia == null)
                instancia = new ConectarBD();

            return instancia;
        }

        public SqlConnection conectar()
        {
            
            conexion = new SqlConnection(@"");
                        
            conexion.Open();
            return conexion;

        }


    }
}
