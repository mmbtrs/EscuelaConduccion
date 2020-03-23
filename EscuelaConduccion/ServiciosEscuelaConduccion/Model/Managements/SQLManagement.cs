using ServiciosEscuelaConduccion.Model.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ServiciosEscuelaConduccion.Model.Managements
{
    public partial class SQLManagement
    {
        AccessDB conexion;
        SqlConnection conn;

        public SQLManagement()
        {
            crearObjetos();
        }

        private void crearObjetos()
        {
            conexion = AccessDB.obtenerInstancia();
        }

        public DataSet consultaSQL(string sql, string nombre_tabla)
        {
            try
            {
                conn = conexion.conection();
                SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                sda.Fill(ds, nombre_tabla);
                return ds;
            }
            catch (Exception exp)
            {
                return null;
            }
        }
    }
}