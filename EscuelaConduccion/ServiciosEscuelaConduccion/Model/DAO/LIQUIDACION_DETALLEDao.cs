using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Data.SqlClient;

using ServiciosEscuelaConduccion.Model.Objects;

namespace ServiciosEscuelaConduccion.Model.DAO {

	public class LIQUIDACION_DETALLEDao 
	{
		public LIQUIDACION_DETALLE createValueObject()
		{
			return new LIQUIDACION_DETALLE();
		}

		public List<LIQUIDACION_DETALLE> loadAll(SqlConnection conn) 
		{
			String sql = "SELECT * FROM LIQUIDACION_DETALLE ORDER BY ID ASC ";
			List<LIQUIDACION_DETALLE> searchResults = listQuery(new SqlCommand(sql, conn));
			return searchResults;
		}


		public void create(SqlConnection conn, LIQUIDACION_DETALLE valueObject) 
		{
			String sql = "";
			SqlCommand stmt = null;
			try 
			{
				sql = "INSERT INTO LIQUIDACION_DETALLE ("+
				" ID_LIQUIDACION, ID_TARIFA_DETALLE, VALOR_CONCEPTO"+
				")"+
				 "VALUES (@ID_LIQUIDACION,@ID_TARIFA_DETALLE,@VALOR_CONCEPTO)";

				stmt = new SqlCommand(sql, conn);
                if (valueObject.ID_LIQUIDACION > 0)
                    stmt.Parameters.AddWithValue("@ID_LIQUIDACION", valueObject.ID_LIQUIDACION);
                else
                    stmt.Parameters.AddWithValue("@ID_LIQUIDACION", DBNull.Value);
                if (valueObject.ID_TARIFA_DETALLE > 0)
                    stmt.Parameters.AddWithValue("@ID_TARIFA_DETALLE", valueObject.ID_TARIFA_DETALLE);
                else
                    stmt.Parameters.AddWithValue("@ID_TARIFA_DETALLE", DBNull.Value);
                if (valueObject.VALOR_CONCEPTO != null)
                    stmt.Parameters.AddWithValue("@VALOR_CONCEPTO", valueObject.VALOR_CONCEPTO);
                else
                    stmt.Parameters.AddWithValue("@VALOR_CONCEPTO", DBNull.Value);

                databaseUpdate(stmt);

			} finally {
				if (stmt != null)
					stmt.Dispose();
			}
		}


		public void save(SqlConnection conn, LIQUIDACION_DETALLE valueObject) 
		{
			SqlCommand stmt = null;
			String sql = "";
			try 
			{
				sql = "UPDATE LIQUIDACION_DETALLE SET ID = @ID ,"+
				" ID_LIQUIDACION = @ID_LIQUIDACION , ID_TARIFA_DETALLE = @ID_TARIFA_DETALLE , VALOR_CONCEPTO = @VALOR_CONCEPTO "+
				" WHERE (id = @id)";
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


		public void delete(SqlConnection conn, LIQUIDACION_DETALLE valueObject) 
		{
			SqlCommand stmt = null;
			String sql = "";
			try 
			{
				sql = "DELETE FROM LIQUIDACION_DETALLE WHERE ( id = @id )";
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


		public List<LIQUIDACION_DETALLE> search(SqlConnection conn, LIQUIDACION_DETALLE valueObject) 
		{
			List<LIQUIDACION_DETALLE> searchResults = new List<LIQUIDACION_DETALLE>();
			bool first = true;
			String sql = "SELECT * FROM LIQUIDACION_DETALLE WHERE 1=1 ";

			if (!String.IsNullOrEmpty(valueObject.ID.ToString()) && valueObject.ID > 0) {
				if (first) { first = false; }
				sql += "AND ID= '" + valueObject.ID + "' ";
			}

			if (!String.IsNullOrEmpty(valueObject.ID_LIQUIDACION.ToString()) && valueObject.ID_LIQUIDACION > 0) {
				if (first) { first = false; }
				sql += "AND ID_LIQUIDACION= '" + valueObject.ID_LIQUIDACION + "' ";
			}

			if (!String.IsNullOrEmpty(valueObject.ID_TARIFA_DETALLE.ToString()) && valueObject.ID_TARIFA_DETALLE > 0) {
				if (first) { first = false; }
				sql += "AND ID_TARIFA_DETALLE= '" + valueObject.ID_TARIFA_DETALLE + "' ";
			}

			if (!String.IsNullOrEmpty(valueObject.VALOR_CONCEPTO.ToString()) && valueObject.VALOR_CONCEPTO > 0) {
				if (first) { first = false; }
				sql += "AND VALOR_CONCEPTO= '" + valueObject.VALOR_CONCEPTO + "' ";
			}

			sql += "ORDER BY id ASC ";

			if (first)
				searchResults = new List<LIQUIDACION_DETALLE>();
			else
				searchResults = listQuery(new SqlCommand(sql,conn));

			return searchResults;
		}


		private int databaseUpdate(SqlCommand stmt) {
			int result = stmt.ExecuteNonQuery();
			return result;
		}


		private List<LIQUIDACION_DETALLE> listQuery(SqlCommand stmt) 
		{

			List<LIQUIDACION_DETALLE> searchResults = new List<LIQUIDACION_DETALLE>();
			SqlDataReader reader = null;
			try 
			{
				int intt = 0; long longg = 0; double doublee = 0; float floatt = 0; DateTime datee; byte[] bytee;
				reader = stmt.ExecuteReader();
				while (reader.Read()) {
					LIQUIDACION_DETALLE temp = createValueObject();

					temp.ID= reader["ID"] != null && int.TryParse(reader["ID"].ToString(),out intt) ? intt : 0;
					temp.ID_LIQUIDACION= reader["ID_LIQUIDACION"] != null && int.TryParse(reader["ID_LIQUIDACION"].ToString(),out intt) ? intt : 0;
					temp.ID_TARIFA_DETALLE= reader["ID_TARIFA_DETALLE"] != null && int.TryParse(reader["ID_TARIFA_DETALLE"].ToString(),out intt) ? intt : 0;
					temp.VALOR_CONCEPTO= reader["VALOR_CONCEPTO"] != null && float.TryParse(reader["VALOR_CONCEPTO"].ToString(),out floatt) ? floatt : 0;
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
