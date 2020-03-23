using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Data.SqlClient;

using ServiciosEscuelaConduccion.Model.Objects;

namespace ServiciosEscuelaConduccion.Model.DAO {

	public class CONFIGURACIONINICIALDao 
	{
		public CONFIGURACIONINICIAL createValueObject()
		{
			return new CONFIGURACIONINICIAL();
		}

		public List<CONFIGURACIONINICIAL> loadAll(SqlConnection conn) 
		{
			String sql = "SELECT * FROM CONFIGURACIONINICIAL ORDER BY ID ASC ";
			List<CONFIGURACIONINICIAL> searchResults = listQuery(new SqlCommand(sql, conn));
			return searchResults;
		}


		public void create(SqlConnection conn, CONFIGURACIONINICIAL valueObject) 
		{
			String sql = "";
			SqlCommand stmt = null;
			try 
			{
				sql = "INSERT INTO CONFIGURACIONINICIAL ( ID,"+
				" NOMBRE, DESCRIPCION, VALOR,"+
				" ESTADO)"+
				 "VALUES (@ID,@NOMBRE,@DESCRIPCION,@VALOR,@ESTADO)";

				stmt = new SqlCommand(sql, conn);


				if(!String.IsNullOrEmpty(valueObject.NOMBRE) && valueObject.NOMBRE.Length <= 30)
					stmt.Parameters.AddWithValue("@NOMBRE", valueObject.NOMBRE);
				else
					stmt.Parameters.AddWithValue("@NOMBRE", DBNull.Value);

				if(!String.IsNullOrEmpty(valueObject.DESCRIPCION) && valueObject.DESCRIPCION.Length <= 100)
					stmt.Parameters.AddWithValue("@DESCRIPCION", valueObject.DESCRIPCION);
				else
					stmt.Parameters.AddWithValue("@DESCRIPCION", DBNull.Value);

				if(!String.IsNullOrEmpty(valueObject.VALOR) && valueObject.VALOR.Length <= 50)
					stmt.Parameters.AddWithValue("@VALOR", valueObject.VALOR);
				else
					stmt.Parameters.AddWithValue("@VALOR", DBNull.Value);

				if(!String.IsNullOrEmpty(valueObject.ESTADO) && valueObject.ESTADO.Length <= 1)
					stmt.Parameters.AddWithValue("@ESTADO", valueObject.ESTADO);
				else
					stmt.Parameters.AddWithValue("@ESTADO", DBNull.Value);

				databaseUpdate(stmt);

			} finally {
				if (stmt != null)
					stmt.Dispose();
			}
		}


		public void save(SqlConnection conn, CONFIGURACIONINICIAL valueObject) 
		{
			SqlCommand stmt = null;
			String sql = "";
			try 
			{
				sql = "UPDATE CONFIGURACIONINICIAL SET ID = @ID ,"+
				" NOMBRE = @NOMBRE , DESCRIPCION = @DESCRIPCION , VALOR = @VALOR ,"+
				" ESTADO = @ESTADO  WHERE (id = @id)";
				stmt = new SqlCommand(sql, conn);


				if(!String.IsNullOrEmpty(valueObject.NOMBRE) && valueObject.NOMBRE.Length <= 30)
					stmt.Parameters.AddWithValue("@NOMBRE", valueObject.NOMBRE);
				else
					stmt.Parameters.AddWithValue("@NOMBRE", DBNull.Value);

				if(!String.IsNullOrEmpty(valueObject.DESCRIPCION) && valueObject.DESCRIPCION.Length <= 100)
					stmt.Parameters.AddWithValue("@DESCRIPCION", valueObject.DESCRIPCION);
				else
					stmt.Parameters.AddWithValue("@DESCRIPCION", DBNull.Value);

				if(!String.IsNullOrEmpty(valueObject.VALOR) && valueObject.VALOR.Length <= 50)
					stmt.Parameters.AddWithValue("@VALOR", valueObject.VALOR);
				else
					stmt.Parameters.AddWithValue("@VALOR", DBNull.Value);

				if(!String.IsNullOrEmpty(valueObject.ESTADO) && valueObject.ESTADO.Length <= 1)
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


		public void delete(SqlConnection conn, CONFIGURACIONINICIAL valueObject) 
		{
			SqlCommand stmt = null;
			String sql = "";
			try 
			{
				sql = "DELETE FROM CONFIGURACIONINICIAL WHERE ( id = @id )";
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


		public List<CONFIGURACIONINICIAL> search(SqlConnection conn, CONFIGURACIONINICIAL valueObject) 
		{
			List<CONFIGURACIONINICIAL> searchResults = new List<CONFIGURACIONINICIAL>();
			bool first = true;
			String sql = "SELECT * FROM CONFIGURACIONINICIAL WHERE 1=1 ";

			if (!String.IsNullOrEmpty(valueObject.ID.ToString())) {
				if (first) { first = false; }
				sql += "AND ID= '" + valueObject.ID + "' ";
			}

			if (!String.IsNullOrEmpty(valueObject.NOMBRE.ToString())) {
				if (first) { first = false; }
				sql += "AND NOMBRE= '" + valueObject.NOMBRE + "' ";
			}

			if (!String.IsNullOrEmpty(valueObject.DESCRIPCION.ToString())) {
				if (first) { first = false; }
				sql += "AND DESCRIPCION= '" + valueObject.DESCRIPCION + "' ";
			}

			if (!String.IsNullOrEmpty(valueObject.VALOR.ToString())) {
				if (first) { first = false; }
				sql += "AND VALOR= '" + valueObject.VALOR + "' ";
			}

			if (!String.IsNullOrEmpty(valueObject.ESTADO.ToString())) {
				if (first) { first = false; }
				sql += "AND ESTADO= '" + valueObject.ESTADO + "' ";
			}

			sql += "ORDER BY id ASC ";

			if (first)
				searchResults = new List<CONFIGURACIONINICIAL>();
			else
				searchResults = listQuery(new SqlCommand(sql,conn));

			return searchResults;
		}


		private int databaseUpdate(SqlCommand stmt) {
			int result = stmt.ExecuteNonQuery();
			return result;
		}


		private List<CONFIGURACIONINICIAL> listQuery(SqlCommand stmt) 
		{

			List<CONFIGURACIONINICIAL> searchResults = new List<CONFIGURACIONINICIAL>();
			SqlDataReader reader = null;
			try 
			{
				int intt = 0; long longg = 0; double doublee = 0; float floatt = 0; DateTime datee; byte[] bytee;
				reader = stmt.ExecuteReader();
				while (reader.Read()) {
					CONFIGURACIONINICIAL temp = createValueObject();

					temp.ID= reader["ID"] != null && int.TryParse(reader["ID"].ToString(),out intt) ? intt : 0;
					temp.NOMBRE= reader["NOMBRE"] != null ? reader["NOMBRE"].ToString() : null;
					temp.DESCRIPCION= reader["DESCRIPCION"] != null ? reader["DESCRIPCION"].ToString() : null;
					temp.VALOR= reader["VALOR"] != null ? reader["VALOR"].ToString() : null;
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
