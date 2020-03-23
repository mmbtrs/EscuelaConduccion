using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Data.SqlClient;

using ServiciosEscuelaConduccion.Model.Objects;

namespace ServiciosEscuelaConduccion.Model.DAO {

	public class PERFILDao 
	{
		public PERFIL createValueObject()
		{
			return new PERFIL();
		}

		public List<PERFIL> loadAll(SqlConnection conn) 
		{
			String sql = "SELECT * FROM PERFIL ORDER BY ID ASC ";
			List<PERFIL> searchResults = listQuery(new SqlCommand(sql, conn));
			return searchResults;
		}


		public void create(SqlConnection conn, PERFIL valueObject) 
		{
			String sql = "";
			SqlCommand stmt = null;
			try 
			{
				sql = "INSERT INTO PERFIL ( ID,"+
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


		public void save(SqlConnection conn, PERFIL valueObject) 
		{
			SqlCommand stmt = null;
			String sql = "";
			try 
			{
				sql = "UPDATE PERFIL SET ID = @ID ,"+
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


		public void delete(SqlConnection conn, PERFIL valueObject) 
		{
			SqlCommand stmt = null;
			String sql = "";
			try 
			{
				sql = "DELETE FROM PERFIL WHERE ( id = @id )";
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


		public List<PERFIL> search(SqlConnection conn, PERFIL valueObject) 
		{
			List<PERFIL> searchResults = new List<PERFIL>();
			bool first = true;
			String sql = "SELECT * FROM PERFIL WHERE 1=1 ";

			if (!String.IsNullOrEmpty(valueObject.ID.ToString())) {
				if (first) { first = false; }
				sql += "AND ID= '" + valueObject.ID + "' ";
			}

			if (!String.IsNullOrEmpty(valueObject.NOMBRE.ToString())) {
				if (first) { first = false; }
				sql += "AND NOMBRE= '" + valueObject.NOMBRE + "' ";
			}

			sql += "ORDER BY id ASC ";

			if (first)
				searchResults = new List<PERFIL>();
			else
				searchResults = listQuery(new SqlCommand(sql,conn));

			return searchResults;
		}


		private int databaseUpdate(SqlCommand stmt) {
			int result = stmt.ExecuteNonQuery();
			return result;
		}


		private List<PERFIL> listQuery(SqlCommand stmt) 
		{

			List<PERFIL> searchResults = new List<PERFIL>();
			SqlDataReader reader = null;
			try 
			{
				int intt = 0; long longg = 0; double doublee = 0; float floatt = 0; DateTime datee; byte[] bytee;
				reader = stmt.ExecuteReader();
				while (reader.Read()) {
					PERFIL temp = createValueObject();

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
