using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Data.SqlClient;

using ServiciosEscuelaConduccion.Model.Objects;

namespace ServiciosEscuelaConduccion.Model.DAO {

	public class TARIFADao 
	{
		public TARIFA createValueObject()
		{
			return new TARIFA();
		}

		public List<TARIFA> loadAll(SqlConnection conn) 
		{
			String sql = "SELECT * FROM TARIFA ORDER BY ID ASC ";
			List<TARIFA> searchResults = listQuery(new SqlCommand(sql, conn));
			return searchResults;
		}


		public void create(SqlConnection conn, TARIFA valueObject) 
		{
			String sql = "";
			SqlCommand stmt = null;
			try 
			{
				sql = "INSERT INTO TARIFA ("+
                " ID_VIGENCIA, ID_TARIFA_CATEGORIA, NOMBRE, ESTADO" +
				")"+
                 "VALUES (@ID_VIGENCIA,@ID_TARIFA_CATEGORIA,@NOMBRE,@ESTADO)";

				stmt = new SqlCommand(sql, conn);

				if (valueObject.ID_VIGENCIA > 0)
					stmt.Parameters.AddWithValue("@ID_VIGENCIA", valueObject.ID_VIGENCIA);
				else
					stmt.Parameters.AddWithValue("@ID_VIGENCIA", DBNull.Value);

				if (valueObject.ID_TARIFA_CATEGORIA > 0)
					stmt.Parameters.AddWithValue("@ID_TARIFA_CATEGORIA", valueObject.ID_TARIFA_CATEGORIA);
				else
					stmt.Parameters.AddWithValue("@ID_TARIFA_CATEGORIA", DBNull.Value);

				if (!String.IsNullOrEmpty(valueObject.NOMBRE) && valueObject.NOMBRE.Length <= 50)
					stmt.Parameters.AddWithValue("@NOMBRE", valueObject.NOMBRE);
				else
					stmt.Parameters.AddWithValue("@NOMBRE", DBNull.Value);

				if(!String.IsNullOrEmpty(valueObject.ESTADO) && valueObject.ESTADO.Length <= 1)
					stmt.Parameters.AddWithValue("@ESTADO", valueObject.ESTADO);
				else
					stmt.Parameters.AddWithValue("@ESTADO", DBNull.Value);

				databaseUpdate(stmt);

			} finally {
				if (stmt != null)
					stmt.Dispose();
			}
		}


		public void save(SqlConnection conn, TARIFA valueObject) 
		{
			SqlCommand stmt = null;
			String sql = "";
			try 
			{
				sql = "UPDATE TARIFA SET"+
                " ID_VIGENCIA = @ID_VIGENCIA, ID_TARIFA_CATEGORIA = @ID_TARIFA_CATEGORIA , NOMBRE = @NOMBRE , ESTADO = @ESTADO " +
				" WHERE (id = @id)";
				stmt = new SqlCommand(sql, conn);

				if (valueObject.ID_VIGENCIA > 0)
					stmt.Parameters.AddWithValue("@ID_VIGENCIA", valueObject.ID_VIGENCIA);
				else
					stmt.Parameters.AddWithValue("@ID_VIGENCIA", DBNull.Value);

				if (valueObject.ID_TARIFA_CATEGORIA > 0)
					stmt.Parameters.AddWithValue("@ID_TARIFA_CATEGORIA", valueObject.ID_TARIFA_CATEGORIA);
				else
					stmt.Parameters.AddWithValue("@ID_TARIFA_CATEGORIA", DBNull.Value);

				if (!String.IsNullOrEmpty(valueObject.NOMBRE) && valueObject.NOMBRE.Length <= 50)
					stmt.Parameters.AddWithValue("@NOMBRE", valueObject.NOMBRE);
				else
					stmt.Parameters.AddWithValue("@NOMBRE", DBNull.Value);

				if(!String.IsNullOrEmpty(valueObject.ESTADO) && valueObject.ESTADO.Length <= 1)
					stmt.Parameters.AddWithValue("@ESTADO", valueObject.ESTADO);
				else
					stmt.Parameters.AddWithValue("@ESTADO", DBNull.Value);

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


		public void delete(SqlConnection conn, TARIFA valueObject) 
		{
			SqlCommand stmt = null;
			String sql = "";
			try 
			{
				sql = "DELETE FROM TARIFA WHERE ( id = @id )";
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


		public List<TARIFA> search(SqlConnection conn, TARIFA valueObject) 
		{
			List<TARIFA> searchResults = new List<TARIFA>();
			bool first = true;
			String sql = "SELECT * FROM TARIFA WHERE 1=1 ";

			if (valueObject.ID > 0) {
				if (first) { first = false; }
				sql += "AND ID= '" + valueObject.ID + "' ";
			}

			if (!String.IsNullOrEmpty(valueObject.ID_VIGENCIA.ToString()) &&  valueObject.ID_VIGENCIA > 0) {
				if (first) { first = false; }
				sql += "AND ID_VIGENCIA= '" + valueObject.ID_VIGENCIA + "' ";
			}

            if (!String.IsNullOrEmpty(valueObject.ID_TARIFA_CATEGORIA.ToString()) && valueObject.ID_TARIFA_CATEGORIA > 0)
            {
                if (first) { first = false; }
                sql += "AND ID_TARIFA_CATEGORIA= '" + valueObject.ID_TARIFA_CATEGORIA + "' ";
            }

            if (!String.IsNullOrEmpty(valueObject.NOMBRE)) {
				if (first) { first = false; }
				sql += "AND NOMBRE= '" + valueObject.NOMBRE + "' ";
			}

			if (!String.IsNullOrEmpty(valueObject.ESTADO)) {
				if (first) { first = false; }
				sql += "AND ESTADO= '" + valueObject.ESTADO + "' ";
			}

			sql += "ORDER BY id ASC ";

			if (first)
				searchResults = new List<TARIFA>();
			else
				searchResults = listQuery(new SqlCommand(sql,conn));

			return searchResults;
		}


		private int databaseUpdate(SqlCommand stmt) {
			int result = stmt.ExecuteNonQuery();
			return result;
		}


		private List<TARIFA> listQuery(SqlCommand stmt) 
		{

			List<TARIFA> searchResults = new List<TARIFA>();
			SqlDataReader reader = null;
			try 
			{
				int intt = 0; long longg = 0; double doublee = 0; float floatt = 0; DateTime datee; byte[] bytee;
				reader = stmt.ExecuteReader();
				while (reader.Read()) {
					TARIFA temp = createValueObject();

					temp.ID= reader["ID"] != null && int.TryParse(reader["ID"].ToString(),out intt) ? intt : 0;
					temp.ID_VIGENCIA= reader["ID_VIGENCIA"] != null && int.TryParse(reader["ID_VIGENCIA"].ToString(),out intt) ? intt : 0;
                    temp.ID_TARIFA_CATEGORIA = reader["ID_TARIFA_CATEGORIA"] != null && int.TryParse(reader["ID_TARIFA_CATEGORIA"].ToString(), out intt) ? intt : 0;
                    temp.NOMBRE= reader["NOMBRE"] != null ? reader["NOMBRE"].ToString() : null;
					temp.ESTADO= reader["ESTADO"] != null ? reader["ESTADO"].ToString() : null;
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
