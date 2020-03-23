using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Data.SqlClient;

using ServiciosEscuelaConduccion.Model.Objects;

namespace ServiciosEscuelaConduccion.Model.DAO {

	public class ACUERDO_ESTADODao 
	{
		public ACUERDO_ESTADO createValueObject()
		{
			return new ACUERDO_ESTADO();
		}

		public List<ACUERDO_ESTADO> loadAll(SqlConnection conn) 
		{
			String sql = "SELECT * FROM ACUERDO_ESTADO ORDER BY ID ASC ";
			List<ACUERDO_ESTADO> searchResults = listQuery(new SqlCommand(sql, conn));
			return searchResults;
		}


		public void create(SqlConnection conn, ACUERDO_ESTADO valueObject) 
		{
			String sql = "";
			SqlCommand stmt = null;
			try 
			{
				sql = "INSERT INTO ACUERDO_ESTADO ("+
				" NOMBRE)"+
				 "VALUES (@NOMBRE)";

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


		public void save(SqlConnection conn, ACUERDO_ESTADO valueObject) 
		{
			SqlCommand stmt = null;
			String sql = "";
			try 
			{
				sql = "UPDATE ACUERDO_ESTADO SET"+
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


		public void delete(SqlConnection conn, ACUERDO_ESTADO valueObject) 
		{
			SqlCommand stmt = null;
			String sql = "";
			try 
			{
				sql = "DELETE FROM ACUERDO_ESTADO WHERE ( id = @id )";
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


		public List<ACUERDO_ESTADO> search(SqlConnection conn, ACUERDO_ESTADO valueObject) 
		{
			List<ACUERDO_ESTADO> searchResults = new List<ACUERDO_ESTADO>();
			bool first = true;
			String sql = "SELECT * FROM ACUERDO_ESTADO WHERE 1=1 ";

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
				searchResults = new List<ACUERDO_ESTADO>();
			else
				searchResults = listQuery(new SqlCommand(sql,conn));

			return searchResults;
		}


		private int databaseUpdate(SqlCommand stmt) {
			int result = stmt.ExecuteNonQuery();
			return result;
		}


		private List<ACUERDO_ESTADO> listQuery(SqlCommand stmt) 
		{

			List<ACUERDO_ESTADO> searchResults = new List<ACUERDO_ESTADO>();
			SqlDataReader reader = null;
			try 
			{
				int intt = 0; long longg = 0; double doublee = 0; float floatt = 0; DateTime datee; byte[] bytee;
				reader = stmt.ExecuteReader();
				while (reader.Read()) {
					ACUERDO_ESTADO temp = createValueObject();

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
