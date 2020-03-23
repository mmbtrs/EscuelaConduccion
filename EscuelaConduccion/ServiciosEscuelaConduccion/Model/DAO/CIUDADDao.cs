using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Data.SqlClient;

using ServiciosEscuelaConduccion.Model.Objects;

namespace ServiciosEscuelaConduccion.Model.DAO {

	public class CIUDADDao 
	{
		public CIUDAD createValueObject()
		{
			return new CIUDAD();
		}

		public List<CIUDAD> loadAll(SqlConnection conn) 
		{
			String sql = "SELECT * FROM CIUDAD ORDER BY ID ASC ";
			List<CIUDAD> searchResults = listQuery(new SqlCommand(sql, conn));
			return searchResults;
		}


		public void create(SqlConnection conn, CIUDAD valueObject) 
		{
			String sql = "";
			SqlCommand stmt = null;
			try 
			{
				sql = "INSERT INTO CIUDAD ( ID,"+
				" ID_DEPARTAMENTO, NOMBRE)"+
				 "VALUES (@ID,@ID_DEPARTAMENTO,@NOMBRE)";

				stmt = new SqlCommand(sql, conn);



				if(!String.IsNullOrEmpty(valueObject.NOMBRE) && valueObject.NOMBRE.Length <= 30)
					stmt.Parameters.AddWithValue("@NOMBRE", valueObject.NOMBRE);
				else
					stmt.Parameters.AddWithValue("@NOMBRE", DBNull.Value);

				databaseUpdate(stmt);

			} finally {
				if (stmt != null)
					stmt.Dispose();
			}
		}


		public void save(SqlConnection conn, CIUDAD valueObject) 
		{
			SqlCommand stmt = null;
			String sql = "";
			try 
			{
				sql = "UPDATE CIUDAD SET ID = @ID ,"+
				" ID_DEPARTAMENTO = @ID_DEPARTAMENTO , NOMBRE = @NOMBRE  WHERE (id = @id)";
				stmt = new SqlCommand(sql, conn);



				if(!String.IsNullOrEmpty(valueObject.NOMBRE) && valueObject.NOMBRE.Length <= 30)
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


		public void delete(SqlConnection conn, CIUDAD valueObject) 
		{
			SqlCommand stmt = null;
			String sql = "";
			try 
			{
				sql = "DELETE FROM CIUDAD WHERE ( id = @id )";
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


		public List<CIUDAD> search(SqlConnection conn, CIUDAD valueObject) 
		{
			List<CIUDAD> searchResults = new List<CIUDAD>();
			bool first = true;
			String sql = "SELECT * FROM CIUDAD WHERE 1=1 ";

			if (!String.IsNullOrEmpty(valueObject.ID.ToString())) {
				if (first) { first = false; }
				sql += "AND ID= '" + valueObject.ID + "' ";
			}

			if (!String.IsNullOrEmpty(valueObject.ID_DEPARTAMENTO.ToString())) {
				if (first) { first = false; }
				sql += "AND ID_DEPARTAMENTO= '" + valueObject.ID_DEPARTAMENTO + "' ";
			}

			if (!String.IsNullOrEmpty(valueObject.NOMBRE.ToString())) {
				if (first) { first = false; }
				sql += "AND NOMBRE= '" + valueObject.NOMBRE + "' ";
			}

			sql += "ORDER BY id ASC ";

			if (first)
				searchResults = new List<CIUDAD>();
			else
				searchResults = listQuery(new SqlCommand(sql,conn));

			return searchResults;
		}


		private int databaseUpdate(SqlCommand stmt) {
			int result = stmt.ExecuteNonQuery();
			return result;
		}


		private List<CIUDAD> listQuery(SqlCommand stmt) 
		{

			List<CIUDAD> searchResults = new List<CIUDAD>();
			SqlDataReader reader = null;
			try 
			{
				int intt = 0; long longg = 0; double doublee = 0; float floatt = 0; DateTime datee; byte[] bytee;
				reader = stmt.ExecuteReader();
				while (reader.Read()) {
					CIUDAD temp = createValueObject();

					temp.ID= reader["ID"] != null && int.TryParse(reader["ID"].ToString(),out intt) ? intt : 0;
					temp.ID_DEPARTAMENTO= reader["ID_DEPARTAMENTO"] != null && int.TryParse(reader["ID_DEPARTAMENTO"].ToString(),out intt) ? intt : 0;
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
