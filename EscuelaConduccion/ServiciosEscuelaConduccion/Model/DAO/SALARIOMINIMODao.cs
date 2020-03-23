using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Data.SqlClient;

using ServiciosEscuelaConduccion.Model.Objects;

namespace ServiciosEscuelaConduccion.Model.DAO {

	public class SALARIOMINIMODao 
	{
		public SALARIOMINIMO createValueObject()
		{
			return new SALARIOMINIMO();
		}

		public List<SALARIOMINIMO> loadAll(SqlConnection conn) 
		{
			String sql = "SELECT * FROM SALARIOMINIMO ORDER BY ID ASC ";
			List<SALARIOMINIMO> searchResults = listQuery(new SqlCommand(sql, conn));
			return searchResults;
		}


		public void create(SqlConnection conn, SALARIOMINIMO valueObject) 
		{
			String sql = "";
			SqlCommand stmt = null;
			try 
			{
				sql = "INSERT INTO SALARIOMINIMO ( ID,"+
				" VIGENCIA, VALOR)"+
				 "VALUES (@ID,@VIGENCIA,@VALOR)";

				stmt = new SqlCommand(sql, conn);




				databaseUpdate(stmt);

			} finally {
				if (stmt != null)
					stmt.Dispose();
			}
		}


		public void save(SqlConnection conn, SALARIOMINIMO valueObject) 
		{
			SqlCommand stmt = null;
			String sql = "";
			try 
			{
				sql = "UPDATE SALARIOMINIMO SET ID = @ID ,"+
				" VIGENCIA = @VIGENCIA , VALOR = @VALOR  WHERE (id = @id)";
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


		public void delete(SqlConnection conn, SALARIOMINIMO valueObject) 
		{
			SqlCommand stmt = null;
			String sql = "";
			try 
			{
				sql = "DELETE FROM SALARIOMINIMO WHERE ( id = @id )";
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


		public List<SALARIOMINIMO> search(SqlConnection conn, SALARIOMINIMO valueObject) 
		{
			List<SALARIOMINIMO> searchResults = new List<SALARIOMINIMO>();
			bool first = true;
			String sql = "SELECT * FROM SALARIOMINIMO WHERE 1=1 ";

			if (!String.IsNullOrEmpty(valueObject.ID.ToString())) {
				if (first) { first = false; }
				sql += "AND ID= '" + valueObject.ID + "' ";
			}

			if (!String.IsNullOrEmpty(valueObject.VIGENCIA.ToString())) {
				if (first) { first = false; }
				sql += "AND VIGENCIA= '" + valueObject.VIGENCIA + "' ";
			}

			if (!String.IsNullOrEmpty(valueObject.VALOR.ToString())) {
				if (first) { first = false; }
				sql += "AND VALOR= '" + valueObject.VALOR + "' ";
			}

			sql += "ORDER BY id ASC ";

			if (first)
				searchResults = new List<SALARIOMINIMO>();
			else
				searchResults = listQuery(new SqlCommand(sql,conn));

			return searchResults;
		}


		private int databaseUpdate(SqlCommand stmt) {
			int result = stmt.ExecuteNonQuery();
			return result;
		}


		private List<SALARIOMINIMO> listQuery(SqlCommand stmt) 
		{

			List<SALARIOMINIMO> searchResults = new List<SALARIOMINIMO>();
			SqlDataReader reader = null;
			try 
			{
				int intt = 0; long longg = 0; double doublee = 0; float floatt = 0; DateTime datee; byte[] bytee;
				reader = stmt.ExecuteReader();
				while (reader.Read()) {
					SALARIOMINIMO temp = createValueObject();

					temp.ID= reader["ID"] != null && int.TryParse(reader["ID"].ToString(),out intt) ? intt : 0;
					temp.VIGENCIA= reader["VIGENCIA"] != null && int.TryParse(reader["VIGENCIA"].ToString(),out intt) ? intt : 0;
					temp.VALOR= reader["VALOR"] != null && float.TryParse(reader["VALOR"].ToString(),out floatt) ? floatt : 0;
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
