using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Data.SqlClient;

using ServiciosEscuelaConduccion.Model.Objects;

namespace ServiciosEscuelaConduccion.Model.DAO {

	public class LIQUIDACIONDao 
	{
		public LIQUIDACION createValueObject()
		{
			return new LIQUIDACION();
		}

		public List<LIQUIDACION> loadAll(SqlConnection conn) 
		{
			String sql = "SELECT * FROM LIQUIDACION ORDER BY ID ASC ";
			List<LIQUIDACION> searchResults = listQuery(new SqlCommand(sql, conn));
			return searchResults;
		}


		public void create(SqlConnection conn, LIQUIDACION valueObject) 
		{
			String sql = "";
			SqlCommand stmt = null;
			try 
			{
				sql = "INSERT INTO LIQUIDACION ("+
				" ID_CLIENTE, ID_TIPO_LIQUIDACION, FECHA_LIQUIDACION,"+
				" TOTAL)"+
				 "VALUES (@ID_CLIENTE,@ID_TIPO_LIQUIDACION,@FECHA_LIQUIDACION,@TOTAL)";

				stmt = new SqlCommand(sql, conn);
                if (valueObject.ID_CLIENTE > 0)
                    stmt.Parameters.AddWithValue("@ID_CLIENTE", valueObject.ID_CLIENTE);
                else
                    stmt.Parameters.AddWithValue("@ID_CLIENTE", DBNull.Value);
                if (valueObject.ID_TIPO_LIQUIDACION > 0)
                    stmt.Parameters.AddWithValue("@ID_TIPO_LIQUIDACION", valueObject.ID_TIPO_LIQUIDACION);
                else
                    stmt.Parameters.AddWithValue("@ID_TIPO_LIQUIDACION", DBNull.Value);
                if (valueObject.FECHA_LIQUIDACION > DateTime.MinValue)
					stmt.Parameters.AddWithValue("@FECHA_LIQUIDACION", valueObject.FECHA_LIQUIDACION);
				else
					stmt.Parameters.AddWithValue("@FECHA_LIQUIDACION", DBNull.Value);
                if (valueObject.TOTAL != null)
                    stmt.Parameters.AddWithValue("@TOTAL", valueObject.TOTAL);
                else
                    stmt.Parameters.AddWithValue("@TOTAL", DBNull.Value);

                databaseUpdate(stmt);

			} finally {
				if (stmt != null)
					stmt.Dispose();
			}
		}


		public void save(SqlConnection conn, LIQUIDACION valueObject) 
		{
			SqlCommand stmt = null;
			String sql = "";
			try 
			{
				sql = "UPDATE LIQUIDACION SET ID = @ID ,"+
				" ID_CLIENTE = @ID_CLIENTE , ID_TIPO_LIQUIDACION = @ID_TIPO_LIQUIDACION , FECHA_LIQUIDACION = @FECHA_LIQUIDACION ,"+
				" TOTAL = @TOTAL  WHERE (id = @id)";
				stmt = new SqlCommand(sql, conn);




				if(valueObject.FECHA_LIQUIDACION > DateTime.MinValue)
					stmt.Parameters.AddWithValue("@FECHA_LIQUIDACION", valueObject.FECHA_LIQUIDACION);
				else
					stmt.Parameters.AddWithValue("@FECHA_LIQUIDACION", DBNull.Value);


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


		public void delete(SqlConnection conn, LIQUIDACION valueObject) 
		{
			SqlCommand stmt = null;
			String sql = "";
			try 
			{
				sql = "DELETE FROM LIQUIDACION WHERE ( id = @id )";
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


		public List<LIQUIDACION> search(SqlConnection conn, LIQUIDACION valueObject) 
		{
			List<LIQUIDACION> searchResults = new List<LIQUIDACION>();
			bool first = true;
			String sql = "SELECT * FROM LIQUIDACION WHERE 1=1 ";

			if (!String.IsNullOrEmpty(valueObject.ID.ToString()) && valueObject.ID > 0) {
				if (first) { first = false; }
				sql += "AND ID= " + valueObject.ID + " ";
			}

			if (!String.IsNullOrEmpty(valueObject.ID_CLIENTE.ToString()) && valueObject.ID_CLIENTE > 0) {
				if (first) { first = false; }
				sql += "AND ID_CLIENTE= " + valueObject.ID_CLIENTE + " ";
			}

			if (!String.IsNullOrEmpty(valueObject.ID_TIPO_LIQUIDACION.ToString()) && valueObject.ID_TIPO_LIQUIDACION > 0) {
				if (first) { first = false; }
				sql += "AND ID_TIPO_LIQUIDACION= " + valueObject.ID_TIPO_LIQUIDACION + " ";
			}

			if (valueObject.FECHA_LIQUIDACION > DateTime.MinValue) {
				if (first) { first = false; }
				sql += "AND FECHA_LIQUIDACION= '" + valueObject.FECHA_LIQUIDACION.ToString("dd/MM/yyyy HH:mm:ss") + "' ";
			}

			if (!String.IsNullOrEmpty(valueObject.TOTAL.ToString()) && valueObject.TOTAL > 0) {
				if (first) { first = false; }
				sql += "AND TOTAL= " + valueObject.TOTAL + " ";
			}

			sql += "ORDER BY id ASC ";

			if (first)
				searchResults = new List<LIQUIDACION>();
			else
				searchResults = listQuery(new SqlCommand(sql,conn));

			return searchResults;
		}


		private int databaseUpdate(SqlCommand stmt) {
			int result = stmt.ExecuteNonQuery();
			return result;
		}


		private List<LIQUIDACION> listQuery(SqlCommand stmt) 
		{

			List<LIQUIDACION> searchResults = new List<LIQUIDACION>();
			SqlDataReader reader = null;
			try 
			{
				int intt = 0; long longg = 0; double doublee = 0; float floatt = 0; DateTime datee; byte[] bytee;
				reader = stmt.ExecuteReader();
				while (reader.Read()) {
					LIQUIDACION temp = createValueObject();

					temp.ID= reader["ID"] != null && int.TryParse(reader["ID"].ToString(),out intt) ? intt : 0;
					temp.ID_CLIENTE= reader["ID_CLIENTE"] != null && int.TryParse(reader["ID_CLIENTE"].ToString(),out intt) ? intt : 0;
					temp.ID_TIPO_LIQUIDACION= reader["ID_TIPO_LIQUIDACION"] != null && int.TryParse(reader["ID_TIPO_LIQUIDACION"].ToString(),out intt) ? intt : 0;
					temp.FECHA_LIQUIDACION= reader["FECHA_LIQUIDACION"] != null && !String.IsNullOrEmpty(reader["FECHA_LIQUIDACION"].ToString()) ? (DateTime)reader["FECHA_LIQUIDACION"] : DateTime.MinValue;
					temp.TOTAL= reader["TOTAL"] != null && float.TryParse(reader["TOTAL"].ToString(),out floatt) ? floatt : 0;
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
