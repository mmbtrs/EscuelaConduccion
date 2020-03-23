using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Data.SqlClient;

using ServiciosEscuelaConduccion.Model.Objects;

namespace ServiciosEscuelaConduccion.Model.DAO {

	public class TARIFA_DETALLEDao 
	{
		public TARIFA_DETALLE createValueObject()
		{
			return new TARIFA_DETALLE();
		}

		public List<TARIFA_DETALLE> loadAll(SqlConnection conn) 
		{
			String sql = "SELECT * FROM TARIFA_DETALLE ORDER BY ID ASC ";
			List<TARIFA_DETALLE> searchResults = listQuery(new SqlCommand(sql, conn));
			return searchResults;
		}


		public void create(SqlConnection conn, TARIFA_DETALLE valueObject) 
		{
			String sql = "";
			SqlCommand stmt = null;
			try 
			{
				sql = "INSERT INTO TARIFA_DETALLE ( ID,"+
				" ID_TARIFA, ID_TARIFA_CONCEPTO, TERCERO,"+
				" DESCONTABLE, FORMULA)"+
				 "VALUES (@ID,@ID_TARIFA,@ID_TARIFA_CONCEPTO,@TERCERO,@DESCONTABLE,@FORMULA)";

				stmt = new SqlCommand(sql, conn);




				if(!String.IsNullOrEmpty(valueObject.TERCERO) && valueObject.TERCERO.Length <= 2)
					stmt.Parameters.AddWithValue("@TERCERO", valueObject.TERCERO);
				else
					stmt.Parameters.AddWithValue("@TERCERO", DBNull.Value);

				if(!String.IsNullOrEmpty(valueObject.DESCONTABLE) && valueObject.DESCONTABLE.Length <= 2)
					stmt.Parameters.AddWithValue("@DESCONTABLE", valueObject.DESCONTABLE);
				else
					stmt.Parameters.AddWithValue("@DESCONTABLE", DBNull.Value);

				if(!String.IsNullOrEmpty(valueObject.FORMULA) && valueObject.FORMULA.Length <= 8000)
					stmt.Parameters.AddWithValue("@FORMULA", valueObject.FORMULA);
				else
					stmt.Parameters.AddWithValue("@FORMULA", DBNull.Value);

				databaseUpdate(stmt);

			} finally {
				if (stmt != null)
					stmt.Dispose();
			}
		}


		public void save(SqlConnection conn, TARIFA_DETALLE valueObject) 
		{
			SqlCommand stmt = null;
			String sql = "";
			try 
			{
				sql = "UPDATE TARIFA_DETALLE SET ID = @ID ,"+
				" ID_TARIFA = @ID_TARIFA , ID_TARIFA_CONCEPTO = @ID_TARIFA_CONCEPTO , TERCERO = @TERCERO ,"+
				" DESCONTABLE = @DESCONTABLE , FORMULA = @FORMULA  WHERE (id = @id)";
				stmt = new SqlCommand(sql, conn);




				if(!String.IsNullOrEmpty(valueObject.TERCERO) && valueObject.TERCERO.Length <= 2)
					stmt.Parameters.AddWithValue("@TERCERO", valueObject.TERCERO);
				else
					stmt.Parameters.AddWithValue("@TERCERO", DBNull.Value);

				if(!String.IsNullOrEmpty(valueObject.DESCONTABLE) && valueObject.DESCONTABLE.Length <= 2)
					stmt.Parameters.AddWithValue("@DESCONTABLE", valueObject.DESCONTABLE);
				else
					stmt.Parameters.AddWithValue("@DESCONTABLE", DBNull.Value);

				if(!String.IsNullOrEmpty(valueObject.FORMULA) && valueObject.FORMULA.Length <= 8000)
					stmt.Parameters.AddWithValue("@FORMULA", valueObject.FORMULA);
				else
					stmt.Parameters.AddWithValue("@FORMULA", DBNull.Value);

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


		public void delete(SqlConnection conn, TARIFA_DETALLE valueObject) 
		{
			SqlCommand stmt = null;
			String sql = "";
			try 
			{
				sql = "DELETE FROM TARIFA_DETALLE WHERE ( id = @id )";
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


		public List<TARIFA_DETALLE> search(SqlConnection conn, TARIFA_DETALLE valueObject) 
		{
			List<TARIFA_DETALLE> searchResults = new List<TARIFA_DETALLE>();
			bool first = true;
			String sql = "SELECT * FROM TARIFA_DETALLE WHERE 1=1 ";

			if (!String.IsNullOrEmpty(valueObject.ID.ToString()) && valueObject.ID > 0) {
				if (first) { first = false; }
				sql += "AND ID= '" + valueObject.ID + "' ";
			}

			if (!String.IsNullOrEmpty(valueObject.ID_TARIFA.ToString()) && valueObject.ID_TARIFA > 0) {
				if (first) { first = false; }
				sql += "AND ID_TARIFA= '" + valueObject.ID_TARIFA + "' ";
			}

			if (!String.IsNullOrEmpty(valueObject.ID_TARIFA_CONCEPTO.ToString()) && valueObject.ID_TARIFA_CONCEPTO > 0) {
				if (first) { first = false; }
				sql += "AND ID_TARIFA_CONCEPTO= '" + valueObject.ID_TARIFA_CONCEPTO + "' ";
			}

			if (!String.IsNullOrEmpty(valueObject.TERCERO)) {
				if (first) { first = false; }
				sql += "AND TERCERO= '" + valueObject.TERCERO + "' ";
			}

			if (!String.IsNullOrEmpty(valueObject.DESCONTABLE)) {
				if (first) { first = false; }
				sql += "AND DESCONTABLE= '" + valueObject.DESCONTABLE + "' ";
			}

			if (!String.IsNullOrEmpty(valueObject.FORMULA)) {
				if (first) { first = false; }
				sql += "AND FORMULA= '" + valueObject.FORMULA + "' ";
			}

			sql += "ORDER BY id ASC ";

			if (first)
				searchResults = new List<TARIFA_DETALLE>();
			else
				searchResults = listQuery(new SqlCommand(sql,conn));

			return searchResults;
		}


		private int databaseUpdate(SqlCommand stmt) {
			int result = stmt.ExecuteNonQuery();
			return result;
		}


		private List<TARIFA_DETALLE> listQuery(SqlCommand stmt) 
		{

			List<TARIFA_DETALLE> searchResults = new List<TARIFA_DETALLE>();
			SqlDataReader reader = null;
			try 
			{
				int intt = 0; long longg = 0; double doublee = 0; float floatt = 0; DateTime datee; byte[] bytee;
				reader = stmt.ExecuteReader();
				while (reader.Read()) {
					TARIFA_DETALLE temp = createValueObject();

					temp.ID= reader["ID"] != null && int.TryParse(reader["ID"].ToString(),out intt) ? intt : 0;
					temp.ID_TARIFA= reader["ID_TARIFA"] != null && int.TryParse(reader["ID_TARIFA"].ToString(),out intt) ? intt : 0;
					temp.ID_TARIFA_CONCEPTO= reader["ID_TARIFA_CONCEPTO"] != null && int.TryParse(reader["ID_TARIFA_CONCEPTO"].ToString(),out intt) ? intt : 0;
					temp.TERCERO= reader["TERCERO"] != null ? reader["TERCERO"].ToString() : null;
					temp.DESCONTABLE= reader["DESCONTABLE"] != null ? reader["DESCONTABLE"].ToString() : null;
					temp.FORMULA= reader["FORMULA"] != null ? reader["FORMULA"].ToString() : null;
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
