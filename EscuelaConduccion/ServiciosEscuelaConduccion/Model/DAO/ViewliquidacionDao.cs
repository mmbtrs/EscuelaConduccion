using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Data.SqlClient;

using ServiciosEscuelaConduccion.objetos;

namespace ServiciosEscuelaConduccion.dao
{

    partial class ViewliquidacionDao
    {


        public Viewliquidacion createValueObject()
        {
            return new Viewliquidacion();
        }

        public List<Viewliquidacion> loadAll(SqlConnection conn)
        {
            String sql = "SELECT * FROM VIEW_LIQUIDACION WHERE VIEW_LIQUIDACION.NUMERO_RECIBO IS NOT NULL ORDER BY NUMERO_RECIBO ASC ";
            List<Viewliquidacion> searchResults = listQuery(new SqlCommand(sql, conn));
            return searchResults;
        }


        public List<Viewliquidacion> loadAll(SqlConnection conn, int limiteInf, int limiteSup)
        {
            String sql = "SELECT * FROM (SELECT *, ROW_NUMBER() OVER (ORDER BY NUMERO_RECIBO) AS RowNumber FROM VIEW_LIQUIDACION) AS CONSULTA WHERE RowNumber >=" + limiteInf + " AND RowNumber <=" + limiteSup;
            List<Viewliquidacion> searchResults = listQuery(new SqlCommand(sql, conn));
            return searchResults;
        }


        public void create(SqlConnection conn, Viewliquidacion valueObject)
        {
            String sql = "";
            SqlCommand stmt = null;
            try
            {
                sql = "INSERT INTO VIEW_LIQUIDACION ( NUMERO_RECIBO," +
                " NUMERO_FACTURA, ID_TIPO_DOCUMENTO, TIPO_DOCUMENTO," +
                " IDENTIFICACION, ID_ESTADO, ESTADO," +
                " FECHA_LIQUIDACION, FECHA_PAGO, ID_TIPO_LIQUIDACION," +
                " TIPO, TARIFA)" +
                 "VALUES ( @NUMERO_RECIBO, @NUMERO_FACTURA, @ID_TIPO_DOCUMENTO, @TIPO_DOCUMENTO, @IDENTIFICACION, @ID_ESTADO, @ESTADO, @FECHA_LIQUIDACION, @FECHA_PAGO, @ID_TIPO_LIQUIDACION, @TIPO, @TARIFA)";
                stmt = new SqlCommand(sql, conn);
                stmt.Parameters.AddWithValue("@NUMERO_RECIBO", valueObject.NUMERO_RECIBO);
                if (valueObject.NUMERO_FACTURA != null && valueObject.NUMERO_FACTURA.Length <= 0)
                    stmt.Parameters.AddWithValue("@NUMERO_FACTURA", valueObject.NUMERO_FACTURA);
                else
                    stmt.Parameters.AddWithValue("@NUMERO_FACTURA", DBNull.Value);
                if (valueObject.ID_TIPO_DOCUMENTO != 0)
                    stmt.Parameters.AddWithValue("@ID_TIPO_DOCUMENTO", valueObject.ID_TIPO_DOCUMENTO);
                else
                    stmt.Parameters.AddWithValue("@ID_TIPO_DOCUMENTO", DBNull.Value);
                if (valueObject.TIPO_DOCUMENTO != null && valueObject.TIPO_DOCUMENTO.Length <= 0)
                    stmt.Parameters.AddWithValue("@TIPO_DOCUMENTO", valueObject.TIPO_DOCUMENTO);
                else
                    stmt.Parameters.AddWithValue("@TIPO_DOCUMENTO", DBNull.Value);
                if (valueObject.IDENTIFICACION != null && valueObject.IDENTIFICACION.Length <= 0)
                    stmt.Parameters.AddWithValue("@IDENTIFICACION", valueObject.IDENTIFICACION);
                else
                    stmt.Parameters.AddWithValue("@IDENTIFICACION", DBNull.Value);
                if (valueObject.ID_ESTADO != 0)
                    stmt.Parameters.AddWithValue("@ID_ESTADO", valueObject.ID_ESTADO);
                else
                    stmt.Parameters.AddWithValue("@ID_ESTADO", DBNull.Value);
                if (valueObject.ESTADO != null && valueObject.ESTADO.Length <= 0)
                    stmt.Parameters.AddWithValue("@ESTADO", valueObject.ESTADO);
                else
                    stmt.Parameters.AddWithValue("@ESTADO", DBNull.Value);
                if (valueObject.FECHA_LIQUIDACION != DateTime.MinValue)
                    stmt.Parameters.AddWithValue("@FECHA_LIQUIDACION", valueObject.FECHA_LIQUIDACION);
                else
                    stmt.Parameters.AddWithValue("@FECHA_LIQUIDACION", DBNull.Value);
                if (valueObject.FECHA_PAGO != DateTime.MinValue)
                    stmt.Parameters.AddWithValue("@FECHA_PAGO", valueObject.FECHA_PAGO);
                else
                    stmt.Parameters.AddWithValue("@FECHA_PAGO", DBNull.Value);
                if (valueObject.ID_TIPO_LIQUIDACION != 0)
                    stmt.Parameters.AddWithValue("@ID_TIPO_LIQUIDACION", valueObject.ID_TIPO_LIQUIDACION);
                else
                    stmt.Parameters.AddWithValue("@ID_TIPO_LIQUIDACION", DBNull.Value);
                if (valueObject.TIPO != null && valueObject.TIPO.Length <= 0)
                    stmt.Parameters.AddWithValue("@TIPO", valueObject.TIPO);
                else
                    stmt.Parameters.AddWithValue("@TIPO", DBNull.Value);
                if (valueObject.TARIFA != null && valueObject.TARIFA.Length <= 0)
                    stmt.Parameters.AddWithValue("@TARIFA", valueObject.TARIFA);
                else
                    stmt.Parameters.AddWithValue("@TARIFA", DBNull.Value);



                databaseUpdate(stmt);
            }
            finally
            {
                if (stmt != null)
                    stmt.Dispose();
            }
        }


        public void save(SqlConnection conn, Viewliquidacion valueObject)
        {
            SqlCommand stmt = null;
            String sql = "";
            try
            {
                sql = "UPDATE VIEW_LIQUIDACION SET  NUMERO_FACTURA = @NUMERO_FACTURA , ID_TIPO_DOCUMENTO = @ID_TIPO_DOCUMENTO , TIPO_DOCUMENTO = @TIPO_DOCUMENTO ," +
                " IDENTIFICACION = @IDENTIFICACION , ID_ESTADO = @ID_ESTADO , ESTADO = @ESTADO ," +
                " FECHA_LIQUIDACION = @FECHA_LIQUIDACION , FECHA_PAGO = @FECHA_PAGO , ID_TIPO_LIQUIDACION = @ID_TIPO_LIQUIDACION ," +
                " TIPO = @TIPO , TARIFA = @TARIFA  WHERE (NUMERO_RECIBO= @NUMERO_RECIBO)";
                stmt = new SqlCommand(sql, conn);
                if (valueObject.NUMERO_FACTURA != null && valueObject.NUMERO_FACTURA.Length <= 0)
                    stmt.Parameters.AddWithValue("@NUMERO_FACTURA", valueObject.NUMERO_FACTURA);
                else
                    stmt.Parameters.AddWithValue("@NUMERO_FACTURA", DBNull.Value);
                if (valueObject.ID_TIPO_DOCUMENTO != 0)
                    stmt.Parameters.AddWithValue("@ID_TIPO_DOCUMENTO", valueObject.ID_TIPO_DOCUMENTO);
                else
                    stmt.Parameters.AddWithValue("@ID_TIPO_DOCUMENTO", DBNull.Value);
                if (valueObject.TIPO_DOCUMENTO != null && valueObject.TIPO_DOCUMENTO.Length <= 0)
                    stmt.Parameters.AddWithValue("@TIPO_DOCUMENTO", valueObject.TIPO_DOCUMENTO);
                else
                    stmt.Parameters.AddWithValue("@TIPO_DOCUMENTO", DBNull.Value);
                if (valueObject.IDENTIFICACION != null && valueObject.IDENTIFICACION.Length <= 0)
                    stmt.Parameters.AddWithValue("@IDENTIFICACION", valueObject.IDENTIFICACION);
                else
                    stmt.Parameters.AddWithValue("@IDENTIFICACION", DBNull.Value);
                if (valueObject.ID_ESTADO != 0)
                    stmt.Parameters.AddWithValue("@ID_ESTADO", valueObject.ID_ESTADO);
                else
                    stmt.Parameters.AddWithValue("@ID_ESTADO", DBNull.Value);
                if (valueObject.ESTADO != null && valueObject.ESTADO.Length <= 0)
                    stmt.Parameters.AddWithValue("@ESTADO", valueObject.ESTADO);
                else
                    stmt.Parameters.AddWithValue("@ESTADO", DBNull.Value);
                if (valueObject.FECHA_LIQUIDACION != DateTime.MinValue)
                    stmt.Parameters.AddWithValue("@FECHA_LIQUIDACION", valueObject.FECHA_LIQUIDACION);
                else
                    stmt.Parameters.AddWithValue("@FECHA_LIQUIDACION", DBNull.Value);
                if (valueObject.FECHA_PAGO != DateTime.MinValue)
                    stmt.Parameters.AddWithValue("@FECHA_PAGO", valueObject.FECHA_PAGO);
                else
                    stmt.Parameters.AddWithValue("@FECHA_PAGO", DBNull.Value);
                if (valueObject.ID_TIPO_LIQUIDACION != 0)
                    stmt.Parameters.AddWithValue("@ID_TIPO_LIQUIDACION", valueObject.ID_TIPO_LIQUIDACION);
                else
                    stmt.Parameters.AddWithValue("@ID_TIPO_LIQUIDACION", DBNull.Value);
                if (valueObject.TIPO != null && valueObject.TIPO.Length <= 0)
                    stmt.Parameters.AddWithValue("@TIPO", valueObject.TIPO);
                else
                    stmt.Parameters.AddWithValue("@TIPO", DBNull.Value);
                if (valueObject.TARIFA != null && valueObject.TARIFA.Length <= 0)
                    stmt.Parameters.AddWithValue("@TARIFA", valueObject.TARIFA);
                else
                    stmt.Parameters.AddWithValue("@TARIFA", DBNull.Value);
                stmt.Parameters.AddWithValue("@NUMERO_RECIBO", valueObject.NUMERO_RECIBO);

                int rowcount = databaseUpdate(stmt);
                if (rowcount == 0)
                {
                    throw new Exception("Object could not be saved! (PrimaryKey not found)");
                }
            }
            finally
            {
                if (stmt != null)
                    stmt.Dispose();
            }
        }


        public void delete(SqlConnection conn, Viewliquidacion valueObject)
        {
            SqlCommand stmt = null;
            String sql = "";
            try
            {
                sql = "DELETE FROM VIEW_LIQUIDACION WHERE (NUMERO_RECIBO = @NUMERO_RECIBO )";
                stmt = new SqlCommand(sql, conn);
                stmt.Parameters.AddWithValue("@NUMERO_RECIBO", valueObject.NUMERO_RECIBO);

                int rowcount = databaseUpdate(stmt);
                if (rowcount == 0)
                {
                    throw new Exception("Object could not be deleted! (PrimaryKey not found)");
                }
                if (rowcount > 1)
                {
                    throw new Exception("PrimaryKey Error when updating DB! (Many objects were deleted!)");
                }
            }
            finally
            {
                if (stmt != null)
                    stmt.Dispose();
            }
        }


        public int countAll(SqlConnection conn)
        {
            String sql = "SELECT count(*) FROM VIEW_LIQUIDACION";
            SqlCommand stmt = null;
            SqlDataReader result = null;
            int allRows = 0;
            try
            {
                stmt = new SqlCommand(sql, conn);
                result = stmt.ExecuteReader();
                if (result.Read())
                    allRows = int.Parse(result[0].ToString());
            }
            finally
            {
                if (!result.IsClosed)
                    result.Close();
                if (stmt != null)
                    stmt.Dispose();
            }
            return allRows;
        }
        public List<Viewliquidacion> searchMatching(SqlConnection conn, Viewliquidacion valueObject)
        {
            List<Viewliquidacion> searchResults = new List<Viewliquidacion>();
            bool first = true;
            String sql = "SELECT * FROM VIEW_LIQUIDACION WHERE 1=1 ";
            if (!String.IsNullOrEmpty(valueObject.NUMERO_RECIBO))
            {
                if (first) { first = false; }
                sql += "AND NUMERO_RECIBO= '" + valueObject.NUMERO_RECIBO + "' ";
            }

            if (!String.IsNullOrEmpty(valueObject.NUMERO_FACTURA))
            {
                if (first) { first = false; }
                sql += "AND NUMERO_FACTURA= '" + valueObject.NUMERO_FACTURA + "' ";
            }

            if (valueObject.ID_TIPO_DOCUMENTO != null && valueObject.ID_TIPO_DOCUMENTO != 0)
            {
                if (first) { first = false; }
                sql += "AND ID_TIPO_DOCUMENTO= " + valueObject.ID_TIPO_DOCUMENTO + " ";
            }

            if (!String.IsNullOrEmpty(valueObject.TIPO_DOCUMENTO))
            {
                if (first) { first = false; }
                sql += "AND TIPO_DOCUMENTO= '" + valueObject.TIPO_DOCUMENTO + "' ";
            }

            if (!String.IsNullOrEmpty(valueObject.IDENTIFICACION))
            {
                if (first) { first = false; }
                sql += "AND IDENTIFICACION= '" + valueObject.IDENTIFICACION + "' ";
            }

            if (valueObject.ID_ESTADO != null && valueObject.ID_ESTADO != 0)
            {
                if (first) { first = false; }
                sql += "AND ID_ESTADO= " + valueObject.ID_ESTADO + " ";
            }

            if (!String.IsNullOrEmpty(valueObject.ESTADO))
            {
                if (first) { first = false; }
                sql += "AND ESTADO= '" + valueObject.ESTADO + "' ";
            }

            if (valueObject.FECHA_LIQUIDACION != DateTime.MinValue)
            {
                if (first) { first = false; }
                sql += "AND FECHA_LIQUIDACION= '" + valueObject.FECHA_LIQUIDACION.ToString("dd/MM/yyyy HH:mm:ss") + "' ";
            }

            if (valueObject.FECHA_PAGO != DateTime.MinValue)
            {
                if (first) { first = false; }
                sql += "AND FECHA_PAGO= '" + valueObject.FECHA_PAGO.ToString("dd/MM/yyyy HH:mm:ss") + "' ";
            }

            if (valueObject.ID_TIPO_LIQUIDACION != null && valueObject.ID_TIPO_LIQUIDACION != 0)
            {
                if (first) { first = false; }
                sql += "AND ID_TIPO_LIQUIDACION= " + valueObject.ID_TIPO_LIQUIDACION + " ";
            }

            if (!String.IsNullOrEmpty(valueObject.TIPO))
            {
                if (first) { first = false; }
                sql += "AND TIPO= '" + valueObject.TIPO + "' ";
            }

            if (!String.IsNullOrEmpty(valueObject.TARIFA))
            {
                if (first) { first = false; }
                sql += "AND TARIFA= '" + valueObject.TARIFA + "' ";
            }

            sql += "ORDER BY NUMERO_RECIBO ASC ";

            if (first)
                searchResults = new List<Viewliquidacion>();
            else
                searchResults = listQuery(new SqlCommand(sql, conn));

            return searchResults;
        }

        public List<Viewliquidacion> searchMatchingBetween(SqlConnection conn, Viewliquidacion valueObject, DateTime fechaIniLiq, DateTime fechaFinLiq, DateTime fechaIniPag, DateTime fechaFinPag)
        {
            List<Viewliquidacion> searchResults = new List<Viewliquidacion>();
            bool first = true;
            String sql = "SELECT * FROM VIEW_LIQUIDACION WHERE 1=1 AND NUMERO_RECIBO IS NOT NULL ";
            if (!String.IsNullOrEmpty(valueObject.NUMERO_RECIBO))
            {
                if (first) { first = false; }
                sql += "AND NUMERO_RECIBO= '" + valueObject.NUMERO_RECIBO + "' ";
            }

            if (!String.IsNullOrEmpty(valueObject.NUMERO_FACTURA))
            {
                if (first) { first = false; }
                sql += "AND NUMERO_FACTURA= '" + valueObject.NUMERO_FACTURA + "' ";
            }

            if (valueObject.ID_TIPO_DOCUMENTO != null && valueObject.ID_TIPO_DOCUMENTO != 0)
            {
                if (first) { first = false; }
                sql += "AND ID_TIPO_DOCUMENTO= " + valueObject.ID_TIPO_DOCUMENTO + " ";
            }

            if (!String.IsNullOrEmpty(valueObject.TIPO_DOCUMENTO))
            {
                if (first) { first = false; }
                sql += "AND TIPO_DOCUMENTO= '" + valueObject.TIPO_DOCUMENTO + "' ";
            }

            if (!String.IsNullOrEmpty(valueObject.IDENTIFICACION))
            {
                if (first) { first = false; }
                sql += "AND IDENTIFICACION= '" + valueObject.IDENTIFICACION + "' ";
            }

            if (valueObject.ID_ESTADO != null && valueObject.ID_ESTADO != 0)
            {
                if (first) { first = false; }
                sql += "AND ID_ESTADO= " + valueObject.ID_ESTADO + " ";
            }

            if (!String.IsNullOrEmpty(valueObject.ESTADO))
            {
                if (first) { first = false; }
                sql += "AND ESTADO= '" + valueObject.ESTADO + "' ";
            }

            if (valueObject.FECHA_LIQUIDACION != DateTime.MinValue)
            {
                if (first) { first = false; }
                sql += "AND FECHA_LIQUIDACION= '" + valueObject.FECHA_LIQUIDACION.ToString("dd/MM/yyyy HH:mm:ss") + "' ";
            }

            if (fechaIniLiq != DateTime.MinValue && fechaFinLiq != DateTime.MinValue)
            {
                if (first) { first = false; }
                sql += "AND FECHA_LIQUIDACION between '" + fechaIniLiq.ToString("dd/MM/yyyy HH:mm:ss") + "' AND '" + fechaFinLiq.ToString("dd/MM/yyyy HH:mm:ss") + "' ";
            }

            if (valueObject.FECHA_PAGO != DateTime.MinValue)
            {
                if (first) { first = false; }
                sql += "AND FECHA_PAGO= '" + valueObject.FECHA_PAGO.ToString("dd/MM/yyyy HH:mm:ss") + "' ";
            }

            if (fechaIniPag != DateTime.MinValue && fechaFinPag != DateTime.MinValue)
            {
                if (first) { first = false; }
                sql += "AND FECHA_PAGO between '" + fechaIniPag.ToString("dd/MM/yyyy HH:mm:ss") + "' AND '" + fechaFinPag.ToString("dd/MM/yyyy HH:mm:ss") + "' ";
            }

            if (valueObject.ID_TIPO_LIQUIDACION != null && valueObject.ID_TIPO_LIQUIDACION != 0)
            {
                if (first) { first = false; }
                sql += "AND ID_TIPO_LIQUIDACION= " + valueObject.ID_TIPO_LIQUIDACION + " ";
            }

            if (!String.IsNullOrEmpty(valueObject.TIPO))
            {
                if (first) { first = false; }
                sql += "AND TIPO= '" + valueObject.TIPO + "' ";
            }

            if (!String.IsNullOrEmpty(valueObject.TARIFA))
            {
                if (first) { first = false; }
                sql += "AND TARIFA= '" + valueObject.TARIFA + "' ";
            }

            sql += "ORDER BY NUMERO_RECIBO ASC ";

            if (first)
                searchResults = new List<Viewliquidacion>();
            else
                searchResults = listQuery(new SqlCommand(sql, conn));

            return searchResults;
        }

        public List<Viewliquidacion> searchMatching(SqlConnection conn, Viewliquidacion valueObject, int limiteInf, int limiteSup)
        {
            List<Viewliquidacion> searchResults = new List<Viewliquidacion>();
            bool first = true;
            String sql = "SELECT * FROM VIEW_LIQUIDACION WHERE 1=1 ";
            if (!String.IsNullOrEmpty(valueObject.NUMERO_RECIBO))
            {
                if (first) { first = false; }
                sql += "AND NUMERO_RECIBO= '" + valueObject.NUMERO_RECIBO + "' ";
            }

            if (!String.IsNullOrEmpty(valueObject.NUMERO_FACTURA))
            {
                if (first) { first = false; }
                sql += "AND NUMERO_FACTURA= '" + valueObject.NUMERO_FACTURA + "' ";
            }

            if (valueObject.ID_TIPO_DOCUMENTO != null && valueObject.ID_TIPO_DOCUMENTO != 0)
            {
                if (first) { first = false; }
                sql += "AND ID_TIPO_DOCUMENTO= " + valueObject.ID_TIPO_DOCUMENTO + " ";
            }

            if (!String.IsNullOrEmpty(valueObject.TIPO_DOCUMENTO))
            {
                if (first) { first = false; }
                sql += "AND TIPO_DOCUMENTO= '" + valueObject.TIPO_DOCUMENTO + "' ";
            }

            if (!String.IsNullOrEmpty(valueObject.IDENTIFICACION))
            {
                if (first) { first = false; }
                sql += "AND IDENTIFICACION= '" + valueObject.IDENTIFICACION + "' ";
            }

            if (valueObject.ID_ESTADO != null && valueObject.ID_ESTADO != 0)
            {
                if (first) { first = false; }
                sql += "AND ID_ESTADO= " + valueObject.ID_ESTADO + " ";
            }

            if (!String.IsNullOrEmpty(valueObject.ESTADO))
            {
                if (first) { first = false; }
                sql += "AND ESTADO= '" + valueObject.ESTADO + "' ";
            }

            if (valueObject.FECHA_LIQUIDACION != DateTime.MinValue)
            {
                if (first) { first = false; }
                sql += "AND FECHA_LIQUIDACION= '" + valueObject.FECHA_LIQUIDACION.ToString("dd/MM/yyyy HH:mm:ss") + "' ";
            }

            if (valueObject.FECHA_PAGO != DateTime.MinValue)
            {
                if (first) { first = false; }
                sql += "AND FECHA_PAGO= '" + valueObject.FECHA_PAGO.ToString("dd/MM/yyyy HH:mm:ss") + "' ";
            }

            if (valueObject.ID_TIPO_LIQUIDACION != null && valueObject.ID_TIPO_LIQUIDACION != 0)
            {
                if (first) { first = false; }
                sql += "AND ID_TIPO_LIQUIDACION= " + valueObject.ID_TIPO_LIQUIDACION + " ";
            }

            if (!String.IsNullOrEmpty(valueObject.TIPO))
            {
                if (first) { first = false; }
                sql += "AND TIPO= '" + valueObject.TIPO + "' ";
            }

            if (!String.IsNullOrEmpty(valueObject.TARIFA))
            {
                if (first) { first = false; }
                sql += "AND TARIFA= '" + valueObject.TARIFA + "' ";
            }

            sql += ") AS CONSULTA WHERE RowNumber >=" + limiteInf + " AND RowNumber <=" + limiteSup;

            if (first)
                searchResults = new List<Viewliquidacion>();
            else
                searchResults = listQuery(new SqlCommand(sql, conn));

            return searchResults;
        }


        public int countSearchMatching(SqlConnection conn, Viewliquidacion valueObject)
        {
            bool first = true;
            String sql = "SELECT COUNT(*) FROM VIEW_LIQUIDACION WHERE 1=1 ";
            if (!String.IsNullOrEmpty(valueObject.NUMERO_RECIBO))
            {
                if (first) { first = false; }
                sql += "AND NUMERO_RECIBO= '" + valueObject.NUMERO_RECIBO + "' ";
            }

            if (!String.IsNullOrEmpty(valueObject.NUMERO_FACTURA))
            {
                if (first) { first = false; }
                sql += "AND NUMERO_FACTURA= '" + valueObject.NUMERO_FACTURA + "' ";
            }

            if (valueObject.ID_TIPO_DOCUMENTO != null && valueObject.ID_TIPO_DOCUMENTO != 0)
            {
                if (first) { first = false; }
                sql += "AND ID_TIPO_DOCUMENTO= " + valueObject.ID_TIPO_DOCUMENTO + " ";
            }

            if (!String.IsNullOrEmpty(valueObject.TIPO_DOCUMENTO))
            {
                if (first) { first = false; }
                sql += "AND TIPO_DOCUMENTO= '" + valueObject.TIPO_DOCUMENTO + "' ";
            }

            if (!String.IsNullOrEmpty(valueObject.IDENTIFICACION))
            {
                if (first) { first = false; }
                sql += "AND IDENTIFICACION= '" + valueObject.IDENTIFICACION + "' ";
            }

            if (valueObject.ID_ESTADO != null && valueObject.ID_ESTADO != 0)
            {
                if (first) { first = false; }
                sql += "AND ID_ESTADO= " + valueObject.ID_ESTADO + " ";
            }

            if (!String.IsNullOrEmpty(valueObject.ESTADO))
            {
                if (first) { first = false; }
                sql += "AND ESTADO= '" + valueObject.ESTADO + "' ";
            }

            if (valueObject.FECHA_LIQUIDACION != DateTime.MinValue)
            {
                if (first) { first = false; }
                sql += "AND FECHA_LIQUIDACION= '" + valueObject.FECHA_LIQUIDACION.ToString("dd/MM/yyyy HH:mm:ss") + "' ";
            }

            if (valueObject.FECHA_PAGO != DateTime.MinValue)
            {
                if (first) { first = false; }
                sql += "AND FECHA_PAGO= '" + valueObject.FECHA_PAGO.ToString("dd/MM/yyyy HH:mm:ss") + "' ";
            }

            if (valueObject.ID_TIPO_LIQUIDACION != null && valueObject.ID_TIPO_LIQUIDACION != 0)
            {
                if (first) { first = false; }
                sql += "AND ID_TIPO_LIQUIDACION= " + valueObject.ID_TIPO_LIQUIDACION + " ";
            }

            if (!String.IsNullOrEmpty(valueObject.TIPO))
            {
                if (first) { first = false; }
                sql += "AND TIPO= '" + valueObject.TIPO + "' ";
            }

            if (!String.IsNullOrEmpty(valueObject.TARIFA))
            {
                if (first) { first = false; }
                sql += "AND TARIFA= '" + valueObject.TARIFA + "' ";
            }

            SqlCommand stmt = null;
            SqlDataReader result = null;
            int allRows = 0;
            try
            {
                stmt = new SqlCommand(sql, conn);
                result = stmt.ExecuteReader();
                if (result.Read())
                    allRows = int.Parse(result[0].ToString());
            }
            finally
            {
                if (!result.IsClosed)
                    result.Close();
                if (stmt != null)
                    stmt.Dispose();
            }
            return allRows;
        }


        private int databaseUpdate(SqlCommand stmt)
        {
            int result = stmt.ExecuteNonQuery();
            return result;
        }


        private List<Viewliquidacion> listQuery(SqlCommand stmt)
        {

            List<Viewliquidacion> searchResults = new List<Viewliquidacion>();
            SqlDataReader reader = null;
            try
            {
                int intt = 0; long longg = 0; double doublee = 0; DateTime datee;
                reader = stmt.ExecuteReader();
                while (reader.Read())
                {
                    Viewliquidacion temp = createValueObject();

                    temp.NUMERO_RECIBO = reader["NUMERO_RECIBO"] != null ? reader["NUMERO_RECIBO"].ToString() : null;
                    temp.NUMERO_FACTURA = reader["NUMERO_FACTURA"] != null ? reader["NUMERO_FACTURA"].ToString() : null;
                    temp.ID_TIPO_DOCUMENTO = reader["ID_TIPO_DOCUMENTO"] != null && long.TryParse(reader["ID_TIPO_DOCUMENTO"].ToString(), out longg) ? longg : 0;
                    temp.TIPO_DOCUMENTO = reader["TIPO_DOCUMENTO"] != null ? reader["TIPO_DOCUMENTO"].ToString() : null;
                    temp.IDENTIFICACION = reader["IDENTIFICACION"] != null ? reader["IDENTIFICACION"].ToString() : null;
                    temp.ID_ESTADO = reader["ID_ESTADO"] != null && long.TryParse(reader["ID_ESTADO"].ToString(), out longg) ? longg : 0;
                    temp.ESTADO = reader["ESTADO"] != null ? reader["ESTADO"].ToString() : null;
                    temp.FECHA_LIQUIDACION = reader["FECHA_LIQUIDACION"] != null && !String.IsNullOrEmpty(reader["FECHA_LIQUIDACION"].ToString()) ? (DateTime)reader["FECHA_LIQUIDACION"] : DateTime.MinValue;
                    temp.FECHA_PAGO = reader["FECHA_PAGO"] != null && !String.IsNullOrEmpty(reader["FECHA_PAGO"].ToString()) ? (DateTime)reader["FECHA_PAGO"] : DateTime.MinValue;
                    temp.ID_TIPO_LIQUIDACION = reader["ID_TIPO_LIQUIDACION"] != null && long.TryParse(reader["ID_TIPO_LIQUIDACION"].ToString(), out longg) ? longg : 0;
                    temp.TIPO = reader["TIPO"] != null ? reader["TIPO"].ToString() : null;
                    temp.TARIFA = reader["TARIFA"] != null ? reader["TARIFA"].ToString() : null;
                    searchResults.Add(temp);
                }
            }
            finally
            {
                if (!reader.IsClosed)
                    reader.Close();
                if (stmt != null)
                    stmt.Dispose();
            }
            return searchResults;
        }


    }

}
