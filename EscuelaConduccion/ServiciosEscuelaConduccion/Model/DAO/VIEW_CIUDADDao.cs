using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Data.SqlClient;

using ServiciosEscuelaConduccion.Model.Objects;

namespace ServiciosEscuelaConduccion.Model.DAO {

	public class VIEW_CIUDADDao 
	{
		public VIEW_CIUDAD createValueObject()
		{
			return new VIEW_CIUDAD();
		}

		public List<VIEW_CIUDAD> loadAll(SqlConnection conn) 
		{
			String sql = "SELECT * FROM VIEW_CIUDAD ORDER BY ID ASC ";
			List<VIEW_CIUDAD> searchResults = listQuery(new SqlCommand(sql, conn));
			return searchResults;
		}


		public void create(SqlConnection conn, VIEW_CIUDAD valueObject) 
		{
			String sql = "";
			SqlCommand stmt = null;
			try 
			{
				sql = "INSERT INTO VIEW_CIUDAD ( ID,"+
				" DEPARTAMENTO, CIUDAD)"+
				 "VALUES (@ID,@DEPARTAMENTO,@CIUDAD)";

				stmt = new SqlCommand(sql, conn);


				if(!String.IsNullOrEmpty(valueObject.DEPARTAMENTO) && valueObject.DEPARTAMENTO.Length <= 30)
					stmt.Parameters.AddWithValue("@DEPARTAMENTO", valueObject.DEPARTAMENTO);
				else
					stmt.Parameters.AddWithValue("@DEPARTAMENTO", DBNull.Value);

				if(!String.IsNullOrEmpty(valueObject.CIUDAD) && valueObject.CIUDAD.Length <= 30)
					stmt.Parameters.AddWithValue("@CIUDAD", valueObject.CIUDAD);
				else
					stmt.Parameters.AddWithValue("@CIUDAD", DBNull.Value);

				databaseUpdate(stmt);

			} finally {
				if (stmt != null)
					stmt.Dispose();
			}
		}


		public void save(SqlConnection conn, VIEW_CIUDAD valueObject) 
		{
			SqlCommand stmt = null;
			String sql = "";
			try 
			{
				sql = "UPDATE VIEW_CIUDAD SET ID = @ID ,"+
				" DEPARTAMENTO = @DEPARTAMENTO , CIUDAD = @CIUDAD  WHERE (id = @id)";
				stmt = new SqlCommand(sql, conn);


				if(!String.IsNullOrEmpty(valueObject.DEPARTAMENTO) && valueObject.DEPARTAMENTO.Length <= 30)
					stmt.Parameters.AddWithValue("@DEPARTAMENTO", valueObject.DEPARTAMENTO);
				else
					stmt.Parameters.AddWithValue("@DEPARTAMENTO", DBNull.Value);

				if(!String.IsNullOrEmpty(valueObject.CIUDAD) && valueObject.CIUDAD.Length <= 30)
					stmt.Parameters.AddWithValue("@CIUDAD", valueObject.CIUDAD);
				else
					stmt.Parameters.AddWithValue("@CIUDAD", DBNull.Value);

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


		public void delete(SqlConnection conn, VIEW_CIUDAD valueObject) 
		{
			SqlCommand stmt = null;
			String sql = "";
			try 
			{
				sql = "DELETE FROM VIEW_CIUDAD WHERE ( id = @id )";
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


		public List<VIEW_CIUDAD> search(SqlConnection conn, VIEW_CIUDAD valueObject) 
		{
			List<VIEW_CIUDAD> searchResults = new List<VIEW_CIUDAD>();
			bool first = true;
			String sql = "SELECT * FROM VIEW_CIUDAD WHERE 1=1 ";

			if (!String.IsNullOrEmpty(valueObject.ID.ToString())) {
				if (first) { first = false; }
				sql += "AND ID= '" + valueObject.ID + "' ";
			}

			if (!String.IsNullOrEmpty(valueObject.DEPARTAMENTO)) {
				if (first) { first = false; }
				sql += "AND DEPARTAMENTO= '" + valueObject.DEPARTAMENTO + "' ";
			}

			if (!String.IsNullOrEmpty(valueObject.CIUDAD)) {
				if (first) { first = false; }
				sql += "AND CIUDAD= '" + valueObject.CIUDAD + "' ";
			}

			sql += "ORDER BY id ASC ";

			if (first)
				searchResults = new List<VIEW_CIUDAD>();
			else
				searchResults = listQuery(new SqlCommand(sql,conn));

			return searchResults;
		}


		private int databaseUpdate(SqlCommand stmt) {
			int result = stmt.ExecuteNonQuery();
			return result;
		}


		private List<VIEW_CIUDAD> listQuery(SqlCommand stmt) 
		{

			List<VIEW_CIUDAD> searchResults = new List<VIEW_CIUDAD>();
			SqlDataReader reader = null;
			try 
			{
				int intt = 0; long longg = 0; double doublee = 0; float floatt = 0; DateTime datee; byte[] bytee;
				reader = stmt.ExecuteReader();
				while (reader.Read()) {
					VIEW_CIUDAD temp = createValueObject();

					temp.ID= reader["ID"] != null && int.TryParse(reader["ID"].ToString(),out intt) ? intt : 0;
					temp.DEPARTAMENTO= reader["DEPARTAMENTO"] != null ? reader["DEPARTAMENTO"].ToString() : null;
					temp.CIUDAD= reader["CIUDAD"] != null ? reader["CIUDAD"].ToString() : null;
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
