using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Data.SqlClient;

using ServiciosEscuelaConduccion.Model.Objects;

namespace ServiciosEscuelaConduccion.Model.DAO {

	public class ACUERDO_PAGO_DETALLEDao 
	{
		public ACUERDO_PAGO_DETALLE createValueObject()
		{
			return new ACUERDO_PAGO_DETALLE();
		}

		public List<ACUERDO_PAGO_DETALLE> loadAll(SqlConnection conn) 
		{
			String sql = "SELECT * FROM ACUERDO_PAGO_DETALLE ORDER BY ID ASC ";
			List<ACUERDO_PAGO_DETALLE> searchResults = listQuery(new SqlCommand(sql, conn));
			return searchResults;
		}


		public void create(SqlConnection conn, ACUERDO_PAGO_DETALLE valueObject) 
		{
			String sql = "";
			SqlCommand stmt = null;
			try 
			{
				sql = "INSERT INTO ACUERDO_PAGO_DETALLE ("+
				" ID_ACUERDO_PAGO, ID_RECIBO, NUMERO_CUOTA,"+
				" VALOR, FECHA_LIMITE_PAGO, PORCENTAJE"+
				")"+
				 "VALUES (@ID_ACUERDO_PAGO,@ID_RECIBO,@NUMERO_CUOTA,@VALOR,@FECHA_LIMITE_PAGO,@PORCENTAJE)";

				stmt = new SqlCommand(sql, conn);

                if (valueObject.ID_ACUERDO_PAGO > 0)
                    stmt.Parameters.AddWithValue("@ID_ACUERDO_PAGO", valueObject.ID_ACUERDO_PAGO);
                else
                    stmt.Parameters.AddWithValue("@ID_ACUERDO_PAGO", DBNull.Value);
                if (valueObject.ID_RECIBO > 0)
                    stmt.Parameters.AddWithValue("@ID_RECIBO", valueObject.ID_RECIBO);
                else
                    stmt.Parameters.AddWithValue("@ID_RECIBO", DBNull.Value);
                if (valueObject.NUMERO_CUOTA > 0)
                    stmt.Parameters.AddWithValue("@NUMERO_CUOTA", valueObject.NUMERO_CUOTA);
                else
                    stmt.Parameters.AddWithValue("@NUMERO_CUOTA", DBNull.Value);
                if (valueObject.VALOR > 0)
                    stmt.Parameters.AddWithValue("@VALOR", valueObject.VALOR);
                else
                    stmt.Parameters.AddWithValue("@VALOR", DBNull.Value);

                if (valueObject.FECHA_LIMITE_PAGO > DateTime.MinValue)
					stmt.Parameters.AddWithValue("@FECHA_LIMITE_PAGO", valueObject.FECHA_LIMITE_PAGO);
				else
					stmt.Parameters.AddWithValue("@FECHA_LIMITE_PAGO", DBNull.Value);
                if (valueObject.PORCENTAJE > 0)
                    stmt.Parameters.AddWithValue("@PORCENTAJE", valueObject.PORCENTAJE);
                else
                    stmt.Parameters.AddWithValue("@PORCENTAJE", DBNull.Value);

                databaseUpdate(stmt);

			} finally {
				if (stmt != null)
					stmt.Dispose();
			}
		}


		public void save(SqlConnection conn, ACUERDO_PAGO_DETALLE valueObject) 
		{
			SqlCommand stmt = null;
			String sql = "";
			try 
			{
				sql = "UPDATE ACUERDO_PAGO_DETALLE SET"+
				" ID_ACUERDO_PAGO = @ID_ACUERDO_PAGO , ID_RECIBO = @ID_RECIBO , NUMERO_CUOTA = @NUMERO_CUOTA ,"+
				" VALOR = @VALOR , FECHA_LIMITE_PAGO = @FECHA_LIMITE_PAGO , PORCENTAJE = @PORCENTAJE "+
				" WHERE (id = @id)";
				stmt = new SqlCommand(sql, conn);

                if (valueObject.ID_ACUERDO_PAGO > 0)
                    stmt.Parameters.AddWithValue("@ID_ACUERDO_PAGO", valueObject.ID_ACUERDO_PAGO);
                else
                    stmt.Parameters.AddWithValue("@ID_ACUERDO_PAGO", DBNull.Value);
                if (valueObject.ID_RECIBO > 0)
                    stmt.Parameters.AddWithValue("@ID_RECIBO", valueObject.ID_RECIBO);
                else
                    stmt.Parameters.AddWithValue("@ID_RECIBO", DBNull.Value);
                if (valueObject.NUMERO_CUOTA > 0)
                    stmt.Parameters.AddWithValue("@NUMERO_CUOTA", valueObject.NUMERO_CUOTA);
                else
                    stmt.Parameters.AddWithValue("@NUMERO_CUOTA", DBNull.Value);
                if (valueObject.VALOR > 0)
                    stmt.Parameters.AddWithValue("@VALOR", valueObject.VALOR);
                else
                    stmt.Parameters.AddWithValue("@VALOR", DBNull.Value);




                if (valueObject.FECHA_LIMITE_PAGO > DateTime.MinValue)
					stmt.Parameters.AddWithValue("@FECHA_LIMITE_PAGO", valueObject.FECHA_LIMITE_PAGO);
				else
					stmt.Parameters.AddWithValue("@FECHA_LIMITE_PAGO", DBNull.Value);
                if (valueObject.PORCENTAJE > 0)
                    stmt.Parameters.AddWithValue("@PORCENTAJE", valueObject.PORCENTAJE);
                else
                    stmt.Parameters.AddWithValue("@PORCENTAJE", DBNull.Value);

                stmt.Parameters.AddWithValue("@id", valueObject.ID);

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


		public void delete(SqlConnection conn, ACUERDO_PAGO_DETALLE valueObject) 
		{
			SqlCommand stmt = null;
			String sql = "";
			try 
			{
				sql = "DELETE FROM ACUERDO_PAGO_DETALLE WHERE ( id = @id )";
				stmt = new SqlCommand(sql, conn);
				stmt.Parameters.AddWithValue("@id", valueObject.ID);
				int rowcount = databaseUpdate(stmt);
				if (rowcount == 0) 
				{
					throw new Exception("Object could not be deleted! (PrimaryKey not found)");
				}
				if (rowcount > 1) 
				{
					throw new Exception("PrimaryKey Error when updating DB! (Many objects were deleted!)");
				}
			} finally {
				if (stmt != null)
					stmt.Dispose();
			}
		}


		public List<ACUERDO_PAGO_DETALLE> search(SqlConnection conn, ACUERDO_PAGO_DETALLE valueObject) 
		{
			List<ACUERDO_PAGO_DETALLE> searchResults = new List<ACUERDO_PAGO_DETALLE>();
			bool first = true;
			String sql = "SELECT * FROM ACUERDO_PAGO_DETALLE WHERE 1=1 ";

			if (!String.IsNullOrEmpty(valueObject.ID.ToString()) && valueObject.ID > 0) {
				if (first) { first = false; }
				sql += "AND ID= '" + valueObject.ID + "' ";
			}

			if (!String.IsNullOrEmpty(valueObject.ID_ACUERDO_PAGO.ToString()) && valueObject.ID_ACUERDO_PAGO > 0) {
				if (first) { first = false; }
				sql += "AND ID_ACUERDO_PAGO= '" + valueObject.ID_ACUERDO_PAGO + "' ";
			}

			if (!String.IsNullOrEmpty(valueObject.ID_RECIBO.ToString()) && valueObject.ID_RECIBO > 0) {
				if (first) { first = false; }
				sql += "AND ID_RECIBO= '" + valueObject.ID_RECIBO + "' ";
			}

			if (!String.IsNullOrEmpty(valueObject.NUMERO_CUOTA.ToString()) && valueObject.NUMERO_CUOTA > 0) {
				if (first) { first = false; }
				sql += "AND NUMERO_CUOTA= '" + valueObject.NUMERO_CUOTA + "' ";
			}

			if (!String.IsNullOrEmpty(valueObject.VALOR.ToString()) && valueObject.VALOR > 0) {
				if (first) { first = false; }
				sql += "AND VALOR= '" + valueObject.VALOR + "' ";
			}

			if (valueObject.FECHA_LIMITE_PAGO > DateTime.MinValue) {
				if (first) { first = false; }
				sql += "AND FECHA_LIMITE_PAGO= '" + valueObject.FECHA_LIMITE_PAGO.ToString("dd/MM/yyyy HH:mm:ss") + "' ";
			}

			if (!String.IsNullOrEmpty(valueObject.PORCENTAJE.ToString()) && valueObject.PORCENTAJE > 0) {
				if (first) { first = false; }
				sql += "AND PORCENTAJE= '" + valueObject.PORCENTAJE + "' ";
			}

			sql += "ORDER BY id ASC ";

			if (first)
				searchResults = new List<ACUERDO_PAGO_DETALLE>();
			else
				searchResults = listQuery(new SqlCommand(sql,conn));

			return searchResults;
		}


		private int databaseUpdate(SqlCommand stmt) {
			int result = stmt.ExecuteNonQuery();
			return result;
		}


		private List<ACUERDO_PAGO_DETALLE> listQuery(SqlCommand stmt) 
		{

			List<ACUERDO_PAGO_DETALLE> searchResults = new List<ACUERDO_PAGO_DETALLE>();
			SqlDataReader reader = null;
			try 
			{
				int intt = 0; long longg = 0; double doublee = 0; float floatt = 0; DateTime datee; byte[] bytee;
				reader = stmt.ExecuteReader();
				while (reader.Read()) {
					ACUERDO_PAGO_DETALLE temp = createValueObject();

					temp.ID= reader["ID"] != null && int.TryParse(reader["ID"].ToString(),out intt) ? intt : 0;
					temp.ID_ACUERDO_PAGO= reader["ID_ACUERDO_PAGO"] != null && int.TryParse(reader["ID_ACUERDO_PAGO"].ToString(),out intt) ? intt : 0;
					temp.ID_RECIBO= reader["ID_RECIBO"] != null && int.TryParse(reader["ID_RECIBO"].ToString(),out intt) ? intt : 0;
					temp.NUMERO_CUOTA= reader["NUMERO_CUOTA"] != null && int.TryParse(reader["NUMERO_CUOTA"].ToString(),out intt) ? intt : 0;
					temp.VALOR= reader["VALOR"] != null && float.TryParse(reader["VALOR"].ToString(),out floatt) ? floatt : 0;
					temp.FECHA_LIMITE_PAGO= reader["FECHA_LIMITE_PAGO"] != null && !String.IsNullOrEmpty(reader["FECHA_LIMITE_PAGO"].ToString()) ? (DateTime)reader["FECHA_LIMITE_PAGO"] : DateTime.MinValue;
					temp.PORCENTAJE= reader["PORCENTAJE"] != null && float.TryParse(reader["PORCENTAJE"].ToString(),out floatt) ? floatt : 0;
					searchResults.Add(temp);
				}
			}
			finally {
				if(!reader.IsClosed)
					reader.Close();
				if (stmt != null)
					stmt.Dispose();
			}
			return searchResults;
		}


	}
}
