using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Data.SqlClient;

using ServiciosEscuelaConduccion.Model.Objects;

namespace ServiciosEscuelaConduccion.Model.DAO {

	public class PERFIL_DETALLEDao 
	{
		public PERFIL_DETALLE createValueObject()
		{
			return new PERFIL_DETALLE();
		}

		public List<PERFIL_DETALLE> loadAll(SqlConnection conn) 
		{
			String sql = "SELECT * FROM PERFIL_DETALLE ORDER BY ID ASC ";
			List<PERFIL_DETALLE> searchResults = listQuery(new SqlCommand(sql, conn));
			return searchResults;
		}


		public void create(SqlConnection conn, PERFIL_DETALLE valueObject) 
		{
			String sql = "";
			SqlCommand stmt = null;
			try 
			{
				sql = "INSERT INTO PERFIL_DETALLE ( ID,"+
				" ID_PERFIL, DESCRIPCION, MODULO"+
				")"+
				 "VALUES (@ID,@ID_PERFIL,@DESCRIPCION,@MODULO)";

				stmt = new SqlCommand(sql, conn);



				if(!String.IsNullOrEmpty(valueObject.DESCRIPCION) && valueObject.DESCRIPCION.Length <= 100)
					stmt.Parameters.AddWithValue("@DESCRIPCION", valueObject.DESCRIPCION);
				else
					stmt.Parameters.AddWithValue("@DESCRIPCION", DBNull.Value);

				if(!String.IsNullOrEmpty(valueObject.MODULO) && valueObject.MODULO.Length <= 20)
					stmt.Parameters.AddWithValue("@MODULO", valueObject.MODULO);
				else
					stmt.Parameters.AddWithValue("@MODULO", DBNull.Value);

				databaseUpdate(stmt);

			} finally {
				if (stmt != null)
					stmt.Dispose();
			}
		}


		public void save(SqlConnection conn, PERFIL_DETALLE valueObject) 
		{
			SqlCommand stmt = null;
			String sql = "";
			try 
			{
				sql = "UPDATE PERFIL_DETALLE SET ID = @ID ,"+
				" ID_PERFIL = @ID_PERFIL , DESCRIPCION = @DESCRIPCION , MODULO = @MODULO "+
				" WHERE (id = @id)";
				stmt = new SqlCommand(sql, conn);



				if(!String.IsNullOrEmpty(valueObject.DESCRIPCION) && valueObject.DESCRIPCION.Length <= 100)
					stmt.Parameters.AddWithValue("@DESCRIPCION", valueObject.DESCRIPCION);
				else
					stmt.Parameters.AddWithValue("@DESCRIPCION", DBNull.Value);

				if(!String.IsNullOrEmpty(valueObject.MODULO) && valueObject.MODULO.Length <= 20)
					stmt.Parameters.AddWithValue("@MODULO", valueObject.MODULO);
				else
					stmt.Parameters.AddWithValue("@MODULO", DBNull.Value);

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


		public void delete(SqlConnection conn, PERFIL_DETALLE valueObject) 
		{
			SqlCommand stmt = null;
			String sql = "";
			try 
			{
				sql = "DELETE FROM PERFIL_DETALLE WHERE ( id = @id )";
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


		public List<PERFIL_DETALLE> search(SqlConnection conn, PERFIL_DETALLE valueObject) 
		{
			List<PERFIL_DETALLE> searchResults = new List<PERFIL_DETALLE>();
			bool first = true;
			String sql = "SELECT * FROM PERFIL_DETALLE WHERE 1=1 ";

			if (!String.IsNullOrEmpty(valueObject.ID.ToString())) {
				if (first) { first = false; }
				sql += "AND ID= '" + valueObject.ID + "' ";
			}

			if (!String.IsNullOrEmpty(valueObject.ID_PERFIL.ToString())) {
				if (first) { first = false; }
				sql += "AND ID_PERFIL= '" + valueObject.ID_PERFIL + "' ";
			}

			if (!String.IsNullOrEmpty(valueObject.DESCRIPCION.ToString())) {
				if (first) { first = false; }
				sql += "AND DESCRIPCION= '" + valueObject.DESCRIPCION + "' ";
			}

			if (!String.IsNullOrEmpty(valueObject.MODULO.ToString())) {
				if (first) { first = false; }
				sql += "AND MODULO= '" + valueObject.MODULO + "' ";
			}

			sql += "ORDER BY id ASC ";

			if (first)
				searchResults = new List<PERFIL_DETALLE>();
			else
				searchResults = listQuery(new SqlCommand(sql,conn));

			return searchResults;
		}


		private int databaseUpdate(SqlCommand stmt) {
			int result = stmt.ExecuteNonQuery();
			return result;
		}


		private List<PERFIL_DETALLE> listQuery(SqlCommand stmt) 
		{

			List<PERFIL_DETALLE> searchResults = new List<PERFIL_DETALLE>();
			SqlDataReader reader = null;
			try 
			{
				int intt = 0; long longg = 0; double doublee = 0; float floatt = 0; DateTime datee; byte[] bytee;
				reader = stmt.ExecuteReader();
				while (reader.Read()) {
					PERFIL_DETALLE temp = createValueObject();

					temp.ID= reader["ID"] != null && int.TryParse(reader["ID"].ToString(),out intt) ? intt : 0;
					temp.ID_PERFIL= reader["ID_PERFIL"] != null && int.TryParse(reader["ID_PERFIL"].ToString(),out intt) ? intt : 0;
					temp.DESCRIPCION= reader["DESCRIPCION"] != null ? reader["DESCRIPCION"].ToString() : null;
					temp.MODULO= reader["MODULO"] != null ? reader["MODULO"].ToString() : null;
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
