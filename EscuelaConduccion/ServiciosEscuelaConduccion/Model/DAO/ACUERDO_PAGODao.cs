using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Data.SqlClient;

using ServiciosEscuelaConduccion.Model.Objects;

namespace ServiciosEscuelaConduccion.Model.DAO {

	public class ACUERDO_PAGODao 
	{
		public ACUERDO_PAGO createValueObject()
		{
			return new ACUERDO_PAGO();
		}

		public List<ACUERDO_PAGO> loadAll(SqlConnection conn) 
		{
			String sql = "SELECT * FROM ACUERDO_PAGO ORDER BY ID ASC ";
			List<ACUERDO_PAGO> searchResults = listQuery(new SqlCommand(sql, conn));
			return searchResults;
		}


		public void create(SqlConnection conn, ACUERDO_PAGO valueObject) 
		{
			String sql = "";
			SqlCommand stmt = null;
			try 
			{
				sql = "INSERT INTO ACUERDO_PAGO ("+
				" ID_LIQUIDACION, ID_ACUERDO_ESTADO, NUMERO_ACUERDO,"+
				" FECHA_ACUERDO)"+
				 "VALUES (@ID_LIQUIDACION,@ID_ACUERDO_ESTADO,@NUMERO_ACUERDO,@FECHA_ACUERDO)";

				stmt = new SqlCommand(sql, conn);

                if (valueObject.ID_LIQUIDACION > 0)
                    stmt.Parameters.AddWithValue("@ID_LIQUIDACION", valueObject.ID_LIQUIDACION);
                else
                    stmt.Parameters.AddWithValue("@ID_LIQUIDACION", DBNull.Value);
                if (valueObject.ID_ACUERDO_ESTADO > 0)
                    stmt.Parameters.AddWithValue("@ID_ACUERDO_ESTADO", valueObject.ID_ACUERDO_ESTADO);
                else
                    stmt.Parameters.AddWithValue("@ID_ACUERDO_ESTADO", DBNull.Value);

                if (!String.IsNullOrEmpty(valueObject.NUMERO_ACUERDO) && valueObject.NUMERO_ACUERDO.Length <= 10)
					stmt.Parameters.AddWithValue("@NUMERO_ACUERDO", valueObject.NUMERO_ACUERDO);
				else
					stmt.Parameters.AddWithValue("@NUMERO_ACUERDO", DBNull.Value);

				if(valueObject.FECHA_ACUERDO > DateTime.MinValue)
					stmt.Parameters.AddWithValue("@FECHA_ACUERDO", valueObject.FECHA_ACUERDO);
				else
					stmt.Parameters.AddWithValue("@FECHA_ACUERDO", DBNull.Value);

				databaseUpdate(stmt);

			} finally {
				if (stmt != null)
					stmt.Dispose();
			}
		}


		public void save(SqlConnection conn, ACUERDO_PAGO valueObject) 
		{
			SqlCommand stmt = null;
			String sql = "";
			try 
			{
				sql = "UPDATE ACUERDO_PAGO SET"+
				" ID_LIQUIDACION = @ID_LIQUIDACION , ID_ACUERDO_ESTADO = @ID_ACUERDO_ESTADO , NUMERO_ACUERDO = @NUMERO_ACUERDO ,"+
				" FECHA_ACUERDO = @FECHA_ACUERDO  WHERE (id = @id)";
				stmt = new SqlCommand(sql, conn);


                if (valueObject.ID_LIQUIDACION > 0)
                    stmt.Parameters.AddWithValue("@ID_LIQUIDACION", valueObject.ID_LIQUIDACION);
                else
                    stmt.Parameters.AddWithValue("@ID_LIQUIDACION", DBNull.Value);
                if (valueObject.ID_ACUERDO_ESTADO > 0)
                    stmt.Parameters.AddWithValue("@ID_ACUERDO_ESTADO", valueObject.ID_ACUERDO_ESTADO);
                else
                    stmt.Parameters.AddWithValue("@ID_ACUERDO_ESTADO", DBNull.Value);

                if (!String.IsNullOrEmpty(valueObject.NUMERO_ACUERDO) && valueObject.NUMERO_ACUERDO.Length <= 10)
					stmt.Parameters.AddWithValue("@NUMERO_ACUERDO", valueObject.NUMERO_ACUERDO);
				else
					stmt.Parameters.AddWithValue("@NUMERO_ACUERDO", DBNull.Value);

				if(valueObject.FECHA_ACUERDO > DateTime.MinValue)
					stmt.Parameters.AddWithValue("@FECHA_ACUERDO", valueObject.FECHA_ACUERDO);
				else
					stmt.Parameters.AddWithValue("@FECHA_ACUERDO", DBNull.Value);

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


		public void delete(SqlConnection conn, ACUERDO_PAGO valueObject) 
		{
			SqlCommand stmt = null;
			String sql = "";
			try 
			{
				sql = "DELETE FROM ACUERDO_PAGO WHERE ( id = @id )";
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


		public List<ACUERDO_PAGO> search(SqlConnection conn, ACUERDO_PAGO valueObject) 
		{
			List<ACUERDO_PAGO> searchResults = new List<ACUERDO_PAGO>();
			bool first = true;
			String sql = "SELECT * FROM ACUERDO_PAGO WHERE 1=1 ";

			if (!String.IsNullOrEmpty(valueObject.ID.ToString()) && valueObject.ID > 0) {
				if (first) { first = false; }
				sql += "AND ID= '" + valueObject.ID + "' ";
			}

			if (!String.IsNullOrEmpty(valueObject.ID_LIQUIDACION.ToString()) && valueObject.ID_LIQUIDACION > 0) {
				if (first) { first = false; }
				sql += "AND ID_LIQUIDACION= '" + valueObject.ID_LIQUIDACION + "' ";
			}

			if (!String.IsNullOrEmpty(valueObject.ID_ACUERDO_ESTADO.ToString()) && valueObject.ID_ACUERDO_ESTADO > 0) {
				if (first) { first = false; }
				sql += "AND ID_ACUERDO_ESTADO= '" + valueObject.ID_ACUERDO_ESTADO + "' ";
			}

			if (!String.IsNullOrEmpty(valueObject.NUMERO_ACUERDO)) {
				if (first) { first = false; }
				sql += "AND NUMERO_ACUERDO= '" + valueObject.NUMERO_ACUERDO + "' ";
			}

			if (valueObject.FECHA_ACUERDO > DateTime.MinValue) {
				if (first) { first = false; }
				sql += "AND FECHA_ACUERDO= '" + valueObject.FECHA_ACUERDO.ToString("dd/MM/yyyy HH:mm:ss") + "' ";
			}

			sql += "ORDER BY id ASC ";

			if (first)
				searchResults = new List<ACUERDO_PAGO>();
			else
				searchResults = listQuery(new SqlCommand(sql,conn));

			return searchResults;
		}


		private int databaseUpdate(SqlCommand stmt) {
			int result = stmt.ExecuteNonQuery();
			return result;
		}


		private List<ACUERDO_PAGO> listQuery(SqlCommand stmt) 
		{

			List<ACUERDO_PAGO> searchResults = new List<ACUERDO_PAGO>();
			SqlDataReader reader = null;
			try 
			{
				int intt = 0; long longg = 0; double doublee = 0; float floatt = 0; DateTime datee; byte[] bytee;
				reader = stmt.ExecuteReader();
				while (reader.Read()) {
					ACUERDO_PAGO temp = createValueObject();

					temp.ID= reader["ID"] != null && int.TryParse(reader["ID"].ToString(),out intt) ? intt : 0;
					temp.ID_LIQUIDACION= reader["ID_LIQUIDACION"] != null && int.TryParse(reader["ID_LIQUIDACION"].ToString(),out intt) ? intt : 0;
					temp.ID_ACUERDO_ESTADO= reader["ID_ACUERDO_ESTADO"] != null && int.TryParse(reader["ID_ACUERDO_ESTADO"].ToString(),out intt) ? intt : 0;
					temp.NUMERO_ACUERDO= reader["NUMERO_ACUERDO"] != null ? reader["NUMERO_ACUERDO"].ToString() : null;
					temp.FECHA_ACUERDO= reader["FECHA_ACUERDO"] != null && !String.IsNullOrEmpty(reader["FECHA_ACUERDO"].ToString()) ? (DateTime)reader["FECHA_ACUERDO"] : DateTime.MinValue;
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
