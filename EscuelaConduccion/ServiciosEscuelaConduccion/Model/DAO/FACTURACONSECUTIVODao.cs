using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Data.SqlClient;

using ServiciosEscuelaConduccion.Model.Objects;

namespace ServiciosEscuelaConduccion.Model.DAO {

	public class FACTURACONSECUTIVODao 
	{
		public FACTURACONSECUTIVO createValueObject()
		{
			return new FACTURACONSECUTIVO();
		}

		public List<FACTURACONSECUTIVO> loadAll(SqlConnection conn) 
		{
			String sql = "SELECT * FROM FACTURACONSECUTIVO ORDER BY ID ASC ";
			List<FACTURACONSECUTIVO> searchResults = listQuery(new SqlCommand(sql, conn));
			return searchResults;
		}


		public void create(SqlConnection conn, FACTURACONSECUTIVO valueObject) 
		{
			String sql = "";
			SqlCommand stmt = null;
			try 
			{
				sql = "INSERT INTO FACTURACONSECUTIVO ("+
				" RANGO_INICIAL, RANGO_FINAL, SUFIJO,"+
				" RESOLUCION, FECHA_RESOLUCION)"+
				 "VALUES (@RANGO_INICIAL,@RANGO_FINAL,@SUFIJO,@RESOLUCION,@FECHA_RESOLUCION)";

				stmt = new SqlCommand(sql, conn);

                if (valueObject.RANGO_INICIAL >= 0)
                    stmt.Parameters.AddWithValue("@RANGO_INICIAL", valueObject.RANGO_INICIAL);
                else
                    stmt.Parameters.AddWithValue("@RANGO_INICIAL", DBNull.Value);
                if (valueObject.RANGO_FINAL > 0)
                    stmt.Parameters.AddWithValue("@RANGO_FINAL", valueObject.RANGO_FINAL);
                else
                    stmt.Parameters.AddWithValue("@RANGO_FINAL", DBNull.Value);
                if (!String.IsNullOrEmpty(valueObject.SUFIJO) && valueObject.SUFIJO.Length <= 3)
					stmt.Parameters.AddWithValue("@SUFIJO", valueObject.SUFIJO);
				else
					stmt.Parameters.AddWithValue("@SUFIJO", DBNull.Value);

				if(!String.IsNullOrEmpty(valueObject.RESOLUCION) && valueObject.RESOLUCION.Length <= 20)
					stmt.Parameters.AddWithValue("@RESOLUCION", valueObject.RESOLUCION);
				else
					stmt.Parameters.AddWithValue("@RESOLUCION", DBNull.Value);

				if(valueObject.FECHA_RESOLUCION > DateTime.MinValue)
					stmt.Parameters.AddWithValue("@FECHA_RESOLUCION", valueObject.FECHA_RESOLUCION);
				else
					stmt.Parameters.AddWithValue("@FECHA_RESOLUCION", DBNull.Value);

				databaseUpdate(stmt);

			} finally {
				if (stmt != null)
					stmt.Dispose();
			}
		}


		public void save(SqlConnection conn, FACTURACONSECUTIVO valueObject) 
		{
			SqlCommand stmt = null;
			String sql = "";
			try 
			{
				sql = "UPDATE FACTURACONSECUTIVO SET"+
				" RANGO_INICIAL = @RANGO_INICIAL , RANGO_FINAL = @RANGO_FINAL , SUFIJO = @SUFIJO ,"+
				" RESOLUCION = @RESOLUCION , FECHA_RESOLUCION = @FECHA_RESOLUCION  WHERE (id = @id)";
				stmt = new SqlCommand(sql, conn);


                if (valueObject.RANGO_INICIAL >= 0)
                    stmt.Parameters.AddWithValue("@RANGO_INICIAL", valueObject.RANGO_INICIAL);
                else
                    stmt.Parameters.AddWithValue("@RANGO_INICIAL", DBNull.Value);
                if (valueObject.RANGO_FINAL > 0)
                    stmt.Parameters.AddWithValue("@RANGO_FINAL", valueObject.RANGO_FINAL);
                else
                    stmt.Parameters.AddWithValue("@RANGO_FINAL", DBNull.Value);

                if (!String.IsNullOrEmpty(valueObject.SUFIJO) && valueObject.SUFIJO.Length <= 3)
					stmt.Parameters.AddWithValue("@SUFIJO", valueObject.SUFIJO);
				else
					stmt.Parameters.AddWithValue("@SUFIJO", DBNull.Value);

				if(!String.IsNullOrEmpty(valueObject.RESOLUCION) && valueObject.RESOLUCION.Length <= 20)
					stmt.Parameters.AddWithValue("@RESOLUCION", valueObject.RESOLUCION);
				else
					stmt.Parameters.AddWithValue("@RESOLUCION", DBNull.Value);

				if(valueObject.FECHA_RESOLUCION > DateTime.MinValue)
					stmt.Parameters.AddWithValue("@FECHA_RESOLUCION", valueObject.FECHA_RESOLUCION);
				else
					stmt.Parameters.AddWithValue("@FECHA_RESOLUCION", DBNull.Value);

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


		public void delete(SqlConnection conn, FACTURACONSECUTIVO valueObject) 
		{
			SqlCommand stmt = null;
			String sql = "";
			try 
			{
				sql = "DELETE FROM FACTURACONSECUTIVO WHERE ( id = @id )";
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


		public List<FACTURACONSECUTIVO> search(SqlConnection conn, FACTURACONSECUTIVO valueObject) 
		{
			List<FACTURACONSECUTIVO> searchResults = new List<FACTURACONSECUTIVO>();
			bool first = true;
			String sql = "SELECT * FROM FACTURACONSECUTIVO WHERE 1=1 ";

			if (!String.IsNullOrEmpty(valueObject.ID.ToString()) && valueObject.ID > 0) {
				if (first) { first = false; }
				sql += "AND ID= '" + valueObject.ID + "' ";
			}

			if (!String.IsNullOrEmpty(valueObject.RANGO_INICIAL.ToString()) && valueObject.RANGO_INICIAL > 0) {
				if (first) { first = false; }
				sql += "AND RANGO_INICIAL= '" + valueObject.RANGO_INICIAL + "' ";
			}

			if (!String.IsNullOrEmpty(valueObject.RANGO_FINAL.ToString()) && valueObject.RANGO_FINAL > 0) {
				if (first) { first = false; }
				sql += "AND RANGO_FINAL= '" + valueObject.RANGO_FINAL + "' ";
			}

			if (!String.IsNullOrEmpty(valueObject.SUFIJO)) {
				if (first) { first = false; }
				sql += "AND SUFIJO= '" + valueObject.SUFIJO + "' ";
			}

			if (!String.IsNullOrEmpty(valueObject.RESOLUCION)) {
				if (first) { first = false; }
				sql += "AND RESOLUCION= '" + valueObject.RESOLUCION + "' ";
			}

			if (valueObject.FECHA_RESOLUCION > DateTime.MinValue) {
				if (first) { first = false; }
				sql += "AND FECHA_RESOLUCION= '" + valueObject.FECHA_RESOLUCION.ToString("dd/MM/yyyy HH:mm:ss") + "' ";
			}

			sql += "ORDER BY id ASC ";

			if (first)
				searchResults = new List<FACTURACONSECUTIVO>();
			else
				searchResults = listQuery(new SqlCommand(sql,conn));

			return searchResults;
		}


		private int databaseUpdate(SqlCommand stmt) {
			int result = stmt.ExecuteNonQuery();
			return result;
		}


		private List<FACTURACONSECUTIVO> listQuery(SqlCommand stmt) 
		{

			List<FACTURACONSECUTIVO> searchResults = new List<FACTURACONSECUTIVO>();
			SqlDataReader reader = null;
			try 
			{
				int intt = 0; long longg = 0; double doublee = 0; float floatt = 0; DateTime datee; byte[] bytee;
				reader = stmt.ExecuteReader();
				while (reader.Read()) {
					FACTURACONSECUTIVO temp = createValueObject();

					temp.ID= reader["ID"] != null && int.TryParse(reader["ID"].ToString(),out intt) ? intt : 0;
					temp.RANGO_INICIAL= reader["RANGO_INICIAL"] != null && float.TryParse(reader["RANGO_INICIAL"].ToString(),out floatt) ? floatt : 0;
					temp.RANGO_FINAL= reader["RANGO_FINAL"] != null && float.TryParse(reader["RANGO_FINAL"].ToString(),out floatt) ? floatt : 0;
					temp.SUFIJO= reader["SUFIJO"] != null ? reader["SUFIJO"].ToString() : null;
					temp.RESOLUCION= reader["RESOLUCION"] != null ? reader["RESOLUCION"].ToString() : null;
					temp.FECHA_RESOLUCION= reader["FECHA_RESOLUCION"] != null && !String.IsNullOrEmpty(reader["FECHA_RESOLUCION"].ToString()) ? (DateTime)reader["FECHA_RESOLUCION"] : DateTime.MinValue;
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
