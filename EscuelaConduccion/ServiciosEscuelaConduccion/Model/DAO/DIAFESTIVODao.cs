using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Data.SqlClient;

using ServiciosEscuelaConduccion.Model.Objects;

namespace ServiciosEscuelaConduccion.Model.DAO {

	public class DIAFESTIVODao 
	{
		public DIAFESTIVO createValueObject()
		{
			return new DIAFESTIVO();
		}

		public List<DIAFESTIVO> loadAll(SqlConnection conn) 
		{
			String sql = "SELECT * FROM DIAFESTIVO ORDER BY ID ASC ";
			List<DIAFESTIVO> searchResults = listQuery(new SqlCommand(sql, conn));
			return searchResults;
		}


		public void create(SqlConnection conn, DIAFESTIVO valueObject) 
		{
			String sql = "";
			SqlCommand stmt = null;
			try 
			{
				sql = "INSERT INTO DIAFESTIVO ( ID,"+
				" FECHA, DESCRIPCION)"+
				 "VALUES (@ID,@FECHA,@DESCRIPCION)";

				stmt = new SqlCommand(sql, conn);


				if(valueObject.FECHA > DateTime.MinValue)
					stmt.Parameters.AddWithValue("@FECHA", valueObject.FECHA);
				else
					stmt.Parameters.AddWithValue("@FECHA", DBNull.Value);

				if(!String.IsNullOrEmpty(valueObject.DESCRIPCION) && valueObject.DESCRIPCION.Length <= 20)
					stmt.Parameters.AddWithValue("@DESCRIPCION", valueObject.DESCRIPCION);
				else
					stmt.Parameters.AddWithValue("@DESCRIPCION", DBNull.Value);

				databaseUpdate(stmt);

			} finally {
				if (stmt != null)
					stmt.Dispose();
			}
		}


		public void save(SqlConnection conn, DIAFESTIVO valueObject) 
		{
			SqlCommand stmt = null;
			String sql = "";
			try 
			{
				sql = "UPDATE DIAFESTIVO SET ID = @ID ,"+
				" FECHA = @FECHA , DESCRIPCION = @DESCRIPCION  WHERE (id = @id)";
				stmt = new SqlCommand(sql, conn);


				if(valueObject.FECHA > DateTime.MinValue)
					stmt.Parameters.AddWithValue("@FECHA", valueObject.FECHA);
				else
					stmt.Parameters.AddWithValue("@FECHA", DBNull.Value);

				if(!String.IsNullOrEmpty(valueObject.DESCRIPCION) && valueObject.DESCRIPCION.Length <= 20)
					stmt.Parameters.AddWithValue("@DESCRIPCION", valueObject.DESCRIPCION);
				else
					stmt.Parameters.AddWithValue("@DESCRIPCION", DBNull.Value);

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


		public void delete(SqlConnection conn, DIAFESTIVO valueObject) 
		{
			SqlCommand stmt = null;
			String sql = "";
			try 
			{
				sql = "DELETE FROM DIAFESTIVO WHERE ( id = @id )";
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


		public List<DIAFESTIVO> search(SqlConnection conn, DIAFESTIVO valueObject) 
		{
			List<DIAFESTIVO> searchResults = new List<DIAFESTIVO>();
			bool first = true;
			String sql = "SELECT * FROM DIAFESTIVO WHERE 1=1 ";

			if (!String.IsNullOrEmpty(valueObject.ID.ToString())) {
				if (first) { first = false; }
				sql += "AND ID= '" + valueObject.ID + "' ";
			}

			if (valueObject.FECHA > DateTime.MinValue) {
				if (first) { first = false; }
				sql += "AND FECHA= '" + valueObject.FECHA.ToString("dd/MM/yyyy HH:mm:ss") + "' ";
			}

			if (!String.IsNullOrEmpty(valueObject.DESCRIPCION.ToString())) {
				if (first) { first = false; }
				sql += "AND DESCRIPCION= '" + valueObject.DESCRIPCION + "' ";
			}

			sql += "ORDER BY id ASC ";

			if (first)
				searchResults = new List<DIAFESTIVO>();
			else
				searchResults = listQuery(new SqlCommand(sql,conn));

			return searchResults;
		}


		private int databaseUpdate(SqlCommand stmt) {
			int result = stmt.ExecuteNonQuery();
			return result;
		}


		private List<DIAFESTIVO> listQuery(SqlCommand stmt) 
		{

			List<DIAFESTIVO> searchResults = new List<DIAFESTIVO>();
			SqlDataReader reader = null;
			try 
			{
				int intt = 0; long longg = 0; double doublee = 0; float floatt = 0; DateTime datee; byte[] bytee;
				reader = stmt.ExecuteReader();
				while (reader.Read()) {
					DIAFESTIVO temp = createValueObject();

					temp.ID= reader["ID"] != null && int.TryParse(reader["ID"].ToString(),out intt) ? intt : 0;
					temp.FECHA= reader["FECHA"] != null && !String.IsNullOrEmpty(reader["FECHA"].ToString()) ? (DateTime)reader["FECHA"] : DateTime.MinValue;
					temp.DESCRIPCION= reader["DESCRIPCION"] != null ? reader["DESCRIPCION"].ToString() : null;
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
