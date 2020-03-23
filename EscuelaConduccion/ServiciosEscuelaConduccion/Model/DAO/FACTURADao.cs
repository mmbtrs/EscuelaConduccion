using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Data.SqlClient;

using ServiciosEscuelaConduccion.Model.Objects;

namespace ServiciosEscuelaConduccion.Model.DAO {

	public class FACTURADao 
	{
		public FACTURA createValueObject()
		{
			return new FACTURA();
		}

		public List<FACTURA> loadAll(SqlConnection conn) 
		{
			String sql = "SELECT * FROM FACTURA ORDER BY ID ASC ";
			List<FACTURA> searchResults = listQuery(new SqlCommand(sql, conn));
			return searchResults;
		}


		public void create(SqlConnection conn, FACTURA valueObject) 
		{
			String sql = "";
			SqlCommand stmt = null;
			try 
			{
				sql = "INSERT INTO FACTURA ("+
				" ID_FACTURA_ESTADO, ID_LIQUIDACION, NUMERO_FACTURA,"+
				" DISPONIBLE, ARCHIVO_FISICO)"+
				 "VALUES (@ID_FACTURA_ESTADO,@ID_LIQUIDACION,@NUMERO_FACTURA,@DISPONIBLE,@ARCHIVO_FISICO)";

				stmt = new SqlCommand(sql, conn);

                if (valueObject.ID_FACTURA_ESTADO > 0)
                    stmt.Parameters.AddWithValue("@ID_FACTURA_ESTADO", valueObject.ID_FACTURA_ESTADO);
                else
                    stmt.Parameters.AddWithValue("@ID_FACTURA_ESTADO", DBNull.Value);
                if (valueObject.ID_LIQUIDACION > 0)
                    stmt.Parameters.AddWithValue("@ID_LIQUIDACION", valueObject.ID_LIQUIDACION);
                else
                    stmt.Parameters.AddWithValue("@ID_LIQUIDACION", DBNull.Value);

                if (!String.IsNullOrEmpty(valueObject.NUMERO_FACTURA) && valueObject.NUMERO_FACTURA.Length <= 20)
					stmt.Parameters.AddWithValue("@NUMERO_FACTURA", valueObject.NUMERO_FACTURA);
				else
					stmt.Parameters.AddWithValue("@NUMERO_FACTURA", DBNull.Value);

				if(!String.IsNullOrEmpty(valueObject.DISPONIBLE) && valueObject.DISPONIBLE.Length <= 2)
					stmt.Parameters.AddWithValue("@DISPONIBLE", valueObject.DISPONIBLE);
				else
					stmt.Parameters.AddWithValue("@DISPONIBLE", DBNull.Value);

				if(valueObject.ARCHIVO_FISICO != null)
					stmt.Parameters.AddWithValue("@ARCHIVO_FISICO", valueObject.ARCHIVO_FISICO);
				else
					stmt.Parameters.AddWithValue("@ARCHIVO_FISICO", new byte[0]);

				databaseUpdate(stmt);

			} finally {
				if (stmt != null)
					stmt.Dispose();
			}
		}


		public void save(SqlConnection conn, FACTURA valueObject) 
		{
			SqlCommand stmt = null;
			String sql = "";
			try 
			{
				sql = "UPDATE FACTURA SET"+
				" ID_FACTURA_ESTADO = @ID_FACTURA_ESTADO , ID_LIQUIDACION = @ID_LIQUIDACION , NUMERO_FACTURA = @NUMERO_FACTURA ,"+
				" DISPONIBLE = @DISPONIBLE , ARCHIVO_FISICO = @ARCHIVO_FISICO  WHERE (id = @id)";
				stmt = new SqlCommand(sql, conn);

                if (valueObject.ID_FACTURA_ESTADO > 0)
                    stmt.Parameters.AddWithValue("@ID_FACTURA_ESTADO", valueObject.ID_FACTURA_ESTADO);
                else
                    stmt.Parameters.AddWithValue("@ID_FACTURA_ESTADO", DBNull.Value);
                if (valueObject.ID_LIQUIDACION > 0)
                    stmt.Parameters.AddWithValue("@ID_LIQUIDACION", valueObject.ID_LIQUIDACION);
                else
                    stmt.Parameters.AddWithValue("@ID_LIQUIDACION", DBNull.Value);


                if (!String.IsNullOrEmpty(valueObject.NUMERO_FACTURA) && valueObject.NUMERO_FACTURA.Length <= 20)
					stmt.Parameters.AddWithValue("@NUMERO_FACTURA", valueObject.NUMERO_FACTURA);
				else
					stmt.Parameters.AddWithValue("@NUMERO_FACTURA", DBNull.Value);

				if(!String.IsNullOrEmpty(valueObject.DISPONIBLE) && valueObject.DISPONIBLE.Length <= 2)
					stmt.Parameters.AddWithValue("@DISPONIBLE", valueObject.DISPONIBLE);
				else
					stmt.Parameters.AddWithValue("@DISPONIBLE", DBNull.Value);

				if(valueObject.ARCHIVO_FISICO != null)
					stmt.Parameters.AddWithValue("@ARCHIVO_FISICO", valueObject.ARCHIVO_FISICO);
				else
					stmt.Parameters.AddWithValue("@ARCHIVO_FISICO", new byte[0]);

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


		public void delete(SqlConnection conn, FACTURA valueObject) 
		{
			SqlCommand stmt = null;
			String sql = "";
			try 
			{
				sql = "DELETE FROM FACTURA WHERE ( id = @id )";
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


		public List<FACTURA> search(SqlConnection conn, FACTURA valueObject) 
		{
			List<FACTURA> searchResults = new List<FACTURA>();
			bool first = true;
			String sql = "SELECT * FROM FACTURA WHERE 1=1 ";

			if (!String.IsNullOrEmpty(valueObject.ID.ToString()) && valueObject.ID > 0) {
				if (first) { first = false; }
				sql += "AND ID= '" + valueObject.ID + "' ";
			}

			if (!String.IsNullOrEmpty(valueObject.ID_FACTURA_ESTADO.ToString()) && valueObject.ID_FACTURA_ESTADO > 0) {
				if (first) { first = false; }
				sql += "AND ID_FACTURA_ESTADO= '" + valueObject.ID_FACTURA_ESTADO + "' ";
			}

			if (!String.IsNullOrEmpty(valueObject.ID_LIQUIDACION.ToString()) && valueObject.ID_LIQUIDACION > 0) {
				if (first) { first = false; }
				sql += "AND ID_LIQUIDACION= '" + valueObject.ID_LIQUIDACION + "' ";
			}

			if (!String.IsNullOrEmpty(valueObject.NUMERO_FACTURA)) {
				if (first) { first = false; }
				sql += "AND NUMERO_FACTURA= '" + valueObject.NUMERO_FACTURA + "' ";
			}

			if (!String.IsNullOrEmpty(valueObject.DISPONIBLE)) {
				if (first) { first = false; }
				sql += "AND DISPONIBLE= '" + valueObject.DISPONIBLE + "' ";
			}

			sql += "ORDER BY id ASC ";

			if (first)
				searchResults = new List<FACTURA>();
			else
				searchResults = listQuery(new SqlCommand(sql,conn));

			return searchResults;
		}


		private int databaseUpdate(SqlCommand stmt) {
			int result = stmt.ExecuteNonQuery();
			return result;
		}


		private List<FACTURA> listQuery(SqlCommand stmt) 
		{

			List<FACTURA> searchResults = new List<FACTURA>();
			SqlDataReader reader = null;
			try 
			{
				int intt = 0; long longg = 0; double doublee = 0; float floatt = 0; DateTime datee; byte[] bytee;
				reader = stmt.ExecuteReader();
				while (reader.Read()) {
					FACTURA temp = createValueObject();

					temp.ID= reader["ID"] != null && int.TryParse(reader["ID"].ToString(),out intt) ? intt : 0;
					temp.ID_FACTURA_ESTADO= reader["ID_FACTURA_ESTADO"] != null && int.TryParse(reader["ID_FACTURA_ESTADO"].ToString(),out intt) ? intt : 0;
					temp.ID_LIQUIDACION= reader["ID_LIQUIDACION"] != null && int.TryParse(reader["ID_LIQUIDACION"].ToString(),out intt) ? intt : 0;
					temp.NUMERO_FACTURA= reader["NUMERO_FACTURA"] != null ? reader["NUMERO_FACTURA"].ToString() : null;
					temp.DISPONIBLE= reader["DISPONIBLE"] != null ? reader["DISPONIBLE"].ToString() : null;
					try
					{
						temp.ARCHIVO_FISICO = reader["ARCHIVO_FISICO"] != null ? (byte[])reader["ARCHIVO_FISICO"] : null;
					}
					catch (Exception)
					{
						temp.ARCHIVO_FISICO = null;
					}

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
