using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Data.SqlClient;

using ServiciosEscuelaConduccion.Model.Objects;

namespace ServiciosEscuelaConduccion.Model.DAO {

	public class VIGENCIADao 
	{
		public VIGENCIA createValueObject()
		{
			return new VIGENCIA();
		}

		public List<VIGENCIA> loadAll(SqlConnection conn) 
		{
			String sql = "SELECT * FROM VIGENCIA ORDER BY ID ASC ";
			List<VIGENCIA> searchResults = listQuery(new SqlCommand(sql, conn));
			return searchResults;
		}


		public void create(SqlConnection conn, VIGENCIA valueObject) 
		{
			String sql = "";
			SqlCommand stmt = null;
			try 
			{
				sql = "INSERT INTO VIGENCIA ( ID,"+
				" NOMBRE)"+
				 "VALUES (@ID,@NOMBRE)";

				stmt = new SqlCommand(sql, conn);



				databaseUpdate(stmt);

			} finally {
				if (stmt != null)
					stmt.Dispose();
			}
		}


		public void save(SqlConnection conn, VIGENCIA valueObject) 
		{
			SqlCommand stmt = null;
			String sql = "";
			try 
			{
				sql = "UPDATE VIGENCIA SET ID = @ID ,"+
				" NOMBRE = @NOMBRE  WHERE (id = @id)";
				stmt = new SqlCommand(sql, conn);



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


		public void delete(SqlConnection conn, VIGENCIA valueObject) 
		{
			SqlCommand stmt = null;
			String sql = "";
			try 
			{
				sql = "DELETE FROM VIGENCIA WHERE ( id = @id )";
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


		public List<VIGENCIA> search(SqlConnection conn, VIGENCIA valueObject) 
		{
			List<VIGENCIA> searchResults = new List<VIGENCIA>();
			bool first = true;
			String sql = "SELECT * FROM VIGENCIA WHERE 1=1 ";

			if (valueObject.ID > 0) {
				if (first) { first = false; }
				sql += "AND ID= '" + valueObject.ID + "' ";
			}

			if (!String.IsNullOrEmpty(valueObject.NOMBRE.ToString()) && valueObject.NOMBRE > 0) {
				if (first) { first = false; }
				sql += "AND NOMBRE= '" + valueObject.NOMBRE + "' ";
			}

			sql += "ORDER BY id ASC ";

			if (first)
				searchResults = new List<VIGENCIA>();
			else
				searchResults = listQuery(new SqlCommand(sql,conn));

			return searchResults;
		}


		private int databaseUpdate(SqlCommand stmt) {
			int result = stmt.ExecuteNonQuery();
			return result;
		}


		private List<VIGENCIA> listQuery(SqlCommand stmt) 
		{

			List<VIGENCIA> searchResults = new List<VIGENCIA>();
			SqlDataReader reader = null;
			try 
			{
				int intt = 0; long longg = 0; double doublee = 0; float floatt = 0; DateTime datee; byte[] bytee;
				reader = stmt.ExecuteReader();
				while (reader.Read()) {
					VIGENCIA temp = createValueObject();

					temp.ID= reader["ID"] != null && int.TryParse(reader["ID"].ToString(),out intt) ? intt : 0;
					temp.NOMBRE= reader["NOMBRE"] != null && int.TryParse(reader["NOMBRE"].ToString(),out intt) ? intt : 0;
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
