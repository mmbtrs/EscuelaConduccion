using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Data.SqlClient;

using ServiciosEscuelaConduccion.Model.Objects;

namespace ServiciosEscuelaConduccion.Model.DAO {

	public class GENERODao 
	{
		public GENERO createValueObject()
		{
			return new GENERO();
		}

		public List<GENERO> loadAll(SqlConnection conn) 
		{
			String sql = "SELECT * FROM GENERO ORDER BY ID ASC ";
			List<GENERO> searchResults = listQuery(new SqlCommand(sql, conn));
			return searchResults;
		}


		public void create(SqlConnection conn, GENERO valueObject) 
		{
			String sql = "";
			SqlCommand stmt = null;
			try 
			{
				sql = "INSERT INTO GENERO ( ID,"+
				" NOMBRE)"+
				 "VALUES (@ID,@NOMBRE)";

				stmt = new SqlCommand(sql, conn);


				if(!String.IsNullOrEmpty(valueObject.NOMBRE) && valueObject.NOMBRE.Length <= 20)
					stmt.Parameters.AddWithValue("@NOMBRE", valueObject.NOMBRE);
				else
					stmt.Parameters.AddWithValue("@NOMBRE", DBNull.Value);

				databaseUpdate(stmt);

			} finally {
				if (stmt != null)
					stmt.Dispose();
			}
		}


		public void save(SqlConnection conn, GENERO valueObject) 
		{
			SqlCommand stmt = null;
			String sql = "";
			try 
			{
				sql = "UPDATE GENERO SET ID = @ID ,"+
				" NOMBRE = @NOMBRE  WHERE (id = @id)";
				stmt = new SqlCommand(sql, conn);


				if(!String.IsNullOrEmpty(valueObject.NOMBRE) && valueObject.NOMBRE.Length <= 20)
					stmt.Parameters.AddWithValue("@NOMBRE", valueObject.NOMBRE);
				else
					stmt.Parameters.AddWithValue("@NOMBRE", DBNull.Value);

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


		public void delete(SqlConnection conn, GENERO valueObject) 
		{
			SqlCommand stmt = null;
			String sql = "";
			try 
			{
				sql = "DELETE FROM GENERO WHERE ( id = @id )";
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


		public List<GENERO> search(SqlConnection conn, GENERO valueObject) 
		{
			List<GENERO> searchResults = new List<GENERO>();
			bool first = true;
			String sql = "SELECT * FROM GENERO WHERE 1=1 ";

			if (!String.IsNullOrEmpty(valueObject.ID.ToString()) && valueObject.ID > 0) {
				if (first) { first = false; }
				sql += "AND ID= '" + valueObject.ID + "' ";
			}

			if (!String.IsNullOrEmpty(valueObject.NOMBRE)) {
				if (first) { first = false; }
				sql += "AND NOMBRE= '" + valueObject.NOMBRE + "' ";
			}

			sql += "ORDER BY id ASC ";

			if (first)
				searchResults = new List<GENERO>();
			else
				searchResults = listQuery(new SqlCommand(sql,conn));

			return searchResults;
		}


		private int databaseUpdate(SqlCommand stmt) {
			int result = stmt.ExecuteNonQuery();
			return result;
		}


		private List<GENERO> listQuery(SqlCommand stmt) 
		{

			List<GENERO> searchResults = new List<GENERO>();
			SqlDataReader reader = null;
			try 
			{
				int intt = 0; long longg = 0; double doublee = 0; float floatt = 0; DateTime datee; byte[] bytee;
				reader = stmt.ExecuteReader();
				while (reader.Read()) {
					GENERO temp = createValueObject();

					temp.ID= reader["ID"] != null && int.TryParse(reader["ID"].ToString(),out intt) ? intt : 0;
					temp.NOMBRE= reader["NOMBRE"] != null ? reader["NOMBRE"].ToString() : null;
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
