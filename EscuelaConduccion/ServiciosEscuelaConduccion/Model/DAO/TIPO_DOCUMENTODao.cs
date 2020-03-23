using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Data.SqlClient;

using ServiciosEscuelaConduccion.Model.Objects;

namespace ServiciosEscuelaConduccion.Model.DAO {

	public class TIPO_DOCUMENTODao 
	{
		public TIPO_DOCUMENTO createValueObject()
		{
			return new TIPO_DOCUMENTO();
		}

		public List<TIPO_DOCUMENTO> loadAll(SqlConnection conn) 
		{
			String sql = "SELECT * FROM TIPO_DOCUMENTO ORDER BY ID ASC ";
			List<TIPO_DOCUMENTO> searchResults = listQuery(new SqlCommand(sql, conn));
			return searchResults;
		}


		public void create(SqlConnection conn, TIPO_DOCUMENTO valueObject) 
		{
			String sql = "";
			SqlCommand stmt = null;
			try 
			{
				sql = "INSERT INTO TIPO_DOCUMENTO ( ID,"+
				" TIPO, ABREVIACION)"+
				 "VALUES (@ID,@TIPO,@ABREVIACION)";

				stmt = new SqlCommand(sql, conn);


				if(!String.IsNullOrEmpty(valueObject.TIPO) && valueObject.TIPO.Length <= 20)
					stmt.Parameters.AddWithValue("@TIPO", valueObject.TIPO);
				else
					stmt.Parameters.AddWithValue("@TIPO", DBNull.Value);

				if(!String.IsNullOrEmpty(valueObject.ABREVIACION) && valueObject.ABREVIACION.Length <= 3)
					stmt.Parameters.AddWithValue("@ABREVIACION", valueObject.ABREVIACION);
				else
					stmt.Parameters.AddWithValue("@ABREVIACION", DBNull.Value);

				databaseUpdate(stmt);

			} finally {
				if (stmt != null)
					stmt.Dispose();
			}
		}


		public void save(SqlConnection conn, TIPO_DOCUMENTO valueObject) 
		{
			SqlCommand stmt = null;
			String sql = "";
			try 
			{
				sql = "UPDATE TIPO_DOCUMENTO SET ID = @ID ,"+
				" TIPO = @TIPO , ABREVIACION = @ABREVIACION  WHERE (id = @id)";
				stmt = new SqlCommand(sql, conn);


				if(!String.IsNullOrEmpty(valueObject.TIPO) && valueObject.TIPO.Length <= 20)
					stmt.Parameters.AddWithValue("@TIPO", valueObject.TIPO);
				else
					stmt.Parameters.AddWithValue("@TIPO", DBNull.Value);

				if(!String.IsNullOrEmpty(valueObject.ABREVIACION) && valueObject.ABREVIACION.Length <= 3)
					stmt.Parameters.AddWithValue("@ABREVIACION", valueObject.ABREVIACION);
				else
					stmt.Parameters.AddWithValue("@ABREVIACION", DBNull.Value);

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


		public void delete(SqlConnection conn, TIPO_DOCUMENTO valueObject) 
		{
			SqlCommand stmt = null;
			String sql = "";
			try 
			{
				sql = "DELETE FROM TIPO_DOCUMENTO WHERE ( id = @id )";
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


		public List<TIPO_DOCUMENTO> search(SqlConnection conn, TIPO_DOCUMENTO valueObject) 
		{
			List<TIPO_DOCUMENTO> searchResults = new List<TIPO_DOCUMENTO>();
			bool first = true;
			String sql = "SELECT * FROM TIPO_DOCUMENTO WHERE 1=1 ";

			if (!String.IsNullOrEmpty(valueObject.ID.ToString())) {
				if (first) { first = false; }
				sql += "AND ID= '" + valueObject.ID + "' ";
			}

			if (!String.IsNullOrEmpty(valueObject.TIPO.ToString())) {
				if (first) { first = false; }
				sql += "AND TIPO= '" + valueObject.TIPO + "' ";
			}

			if (!String.IsNullOrEmpty(valueObject.ABREVIACION.ToString())) {
				if (first) { first = false; }
				sql += "AND ABREVIACION= '" + valueObject.ABREVIACION + "' ";
			}

			sql += "ORDER BY id ASC ";

			if (first)
				searchResults = new List<TIPO_DOCUMENTO>();
			else
				searchResults = listQuery(new SqlCommand(sql,conn));

			return searchResults;
		}


		private int databaseUpdate(SqlCommand stmt) {
			int result = stmt.ExecuteNonQuery();
			return result;
		}


		private List<TIPO_DOCUMENTO> listQuery(SqlCommand stmt) 
		{

			List<TIPO_DOCUMENTO> searchResults = new List<TIPO_DOCUMENTO>();
			SqlDataReader reader = null;
			try 
			{
				int intt = 0; long longg = 0; double doublee = 0; float floatt = 0; DateTime datee; byte[] bytee;
				reader = stmt.ExecuteReader();
				while (reader.Read()) {
					TIPO_DOCUMENTO temp = createValueObject();

					temp.ID= reader["ID"] != null && int.TryParse(reader["ID"].ToString(),out intt) ? intt : 0;
					temp.TIPO= reader["TIPO"] != null ? reader["TIPO"].ToString() : null;
					temp.ABREVIACION= reader["ABREVIACION"] != null ? reader["ABREVIACION"].ToString() : null;
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
