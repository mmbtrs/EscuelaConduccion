using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Data.SqlClient;

using ServiciosEscuelaConduccion.Model.Objects;

namespace ServiciosEscuelaConduccion.Model.DAO {

	public class FACTURA_ESTADODao 
	{
		public FACTURA_ESTADO createValueObject()
		{
			return new FACTURA_ESTADO();
		}

		public List<FACTURA_ESTADO> loadAll(SqlConnection conn) 
		{
			String sql = "SELECT * FROM FACTURA_ESTADO ORDER BY ID ASC ";
			List<FACTURA_ESTADO> searchResults = listQuery(new SqlCommand(sql, conn));
			return searchResults;
		}


		public void create(SqlConnection conn, FACTURA_ESTADO valueObject) 
		{
			String sql = "";
			SqlCommand stmt = null;
			try 
			{
				sql = "INSERT INTO FACTURA_ESTADO ( ID,"+
				" ESTADO)"+
				 "VALUES (@ID,@ESTADO)";

				stmt = new SqlCommand(sql, conn);


				if(!String.IsNullOrEmpty(valueObject.ESTADO) && valueObject.ESTADO.Length <= 20)
					stmt.Parameters.AddWithValue("@ESTADO", valueObject.ESTADO);
				else
					stmt.Parameters.AddWithValue("@ESTADO", DBNull.Value);

				databaseUpdate(stmt);

			} finally {
				if (stmt != null)
					stmt.Dispose();
			}
		}


		public void save(SqlConnection conn, FACTURA_ESTADO valueObject) 
		{
			SqlCommand stmt = null;
			String sql = "";
			try 
			{
				sql = "UPDATE FACTURA_ESTADO SET ID = @ID ,"+
				" ESTADO = @ESTADO  WHERE (id = @id)";
				stmt = new SqlCommand(sql, conn);


				if(!String.IsNullOrEmpty(valueObject.ESTADO) && valueObject.ESTADO.Length <= 20)
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


		public void delete(SqlConnection conn, FACTURA_ESTADO valueObject) 
		{
			SqlCommand stmt = null;
			String sql = "";
			try 
			{
				sql = "DELETE FROM FACTURA_ESTADO WHERE ( id = @id )";
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


		public List<FACTURA_ESTADO> search(SqlConnection conn, FACTURA_ESTADO valueObject) 
		{
			List<FACTURA_ESTADO> searchResults = new List<FACTURA_ESTADO>();
			bool first = true;
			String sql = "SELECT * FROM FACTURA_ESTADO WHERE 1=1 ";

			if (!String.IsNullOrEmpty(valueObject.ID.ToString()) && valueObject.ID > 0) {
				if (first) { first = false; }
				sql += "AND ID= '" + valueObject.ID + "' ";
			}

			if (!String.IsNullOrEmpty(valueObject.ESTADO)) {
				if (first) { first = false; }
				sql += "AND ESTADO= '" + valueObject.ESTADO + "' ";
			}

			sql += "ORDER BY id ASC ";

			if (first)
				searchResults = new List<FACTURA_ESTADO>();
			else
				searchResults = listQuery(new SqlCommand(sql,conn));

			return searchResults;
		}


		private int databaseUpdate(SqlCommand stmt) {
			int result = stmt.ExecuteNonQuery();
			return result;
		}


		private List<FACTURA_ESTADO> listQuery(SqlCommand stmt) 
		{

			List<FACTURA_ESTADO> searchResults = new List<FACTURA_ESTADO>();
			SqlDataReader reader = null;
			try 
			{
				int intt = 0; long longg = 0; double doublee = 0; float floatt = 0; DateTime datee; byte[] bytee;
				reader = stmt.ExecuteReader();
				while (reader.Read()) {
					FACTURA_ESTADO temp = createValueObject();

					temp.ID= reader["ID"] != null && int.TryParse(reader["ID"].ToString(),out intt) ? intt : 0;
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
