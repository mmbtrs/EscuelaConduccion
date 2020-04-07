using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Data.SqlClient;

using ServiciosEscuelaConduccion.Model.Objects;

namespace ServiciosEscuelaConduccion.Model.DAO {

	public class TARIFA_CONCEPTODao 
	{
		public TARIFA_CONCEPTO createValueObject()
		{
			return new TARIFA_CONCEPTO();
		}

		public List<TARIFA_CONCEPTO> loadAll(SqlConnection conn) 
		{
			String sql = "SELECT * FROM TARIFA_CONCEPTO ORDER BY ID ASC ";
			List<TARIFA_CONCEPTO> searchResults = listQuery(new SqlCommand(sql, conn));
			return searchResults;
		}


		public void create(SqlConnection conn, TARIFA_CONCEPTO valueObject) 
		{
			String sql = "";
			SqlCommand stmt = null;
			try 
			{
				sql = "INSERT INTO TARIFA_CONCEPTO ("+
				" CODIGO, NOMBRE, DESCRIPCION, ESTADO"+
				")"+
                 "VALUES (@CODIGO,@NOMBRE,@DESCRIPCION,@ESTADO)";

				stmt = new SqlCommand(sql, conn);

                if (!String.IsNullOrEmpty(valueObject.CODIGO) && valueObject.CODIGO.Length <= 20)
                    stmt.Parameters.AddWithValue("@CODIGO", valueObject.CODIGO);
                else
                    stmt.Parameters.AddWithValue("@CODIGO", DBNull.Value);

                if (!String.IsNullOrEmpty(valueObject.NOMBRE) && valueObject.NOMBRE.Length <= 50)
					stmt.Parameters.AddWithValue("@NOMBRE", valueObject.NOMBRE);
				else
					stmt.Parameters.AddWithValue("@NOMBRE", DBNull.Value);

				if(!String.IsNullOrEmpty(valueObject.DESCRIPCION) && valueObject.DESCRIPCION.Length <= 500)
					stmt.Parameters.AddWithValue("@DESCRIPCION", valueObject.DESCRIPCION);
				else
					stmt.Parameters.AddWithValue("@DESCRIPCION", DBNull.Value);

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


		public void save(SqlConnection conn, TARIFA_CONCEPTO valueObject) 
		{
			SqlCommand stmt = null;
			String sql = "";
			try 
			{
				sql = "UPDATE TARIFA_CONCEPTO SET ID = @ID ,"+
				" CODIGO = @CODIGO, NOMBRE = @NOMBRE , DESCRIPCION = @DESCRIPCION , ESTADO = @ESTADO "+
				" WHERE (id = @id)";
				stmt = new SqlCommand(sql, conn);

                if (!String.IsNullOrEmpty(valueObject.CODIGO) && valueObject.CODIGO.Length <= 20)
                    stmt.Parameters.AddWithValue("@CODIGO", valueObject.CODIGO);
                else
                    stmt.Parameters.AddWithValue("@CODIGO", DBNull.Value);

                if (!String.IsNullOrEmpty(valueObject.NOMBRE) && valueObject.NOMBRE.Length <= 50)
					stmt.Parameters.AddWithValue("@NOMBRE", valueObject.NOMBRE);
				else
					stmt.Parameters.AddWithValue("@NOMBRE", DBNull.Value);

				if(!String.IsNullOrEmpty(valueObject.DESCRIPCION) && valueObject.DESCRIPCION.Length <= 500)
					stmt.Parameters.AddWithValue("@DESCRIPCION", valueObject.DESCRIPCION);
				else
					stmt.Parameters.AddWithValue("@DESCRIPCION", DBNull.Value);

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


		public void delete(SqlConnection conn, TARIFA_CONCEPTO valueObject) 
		{
			SqlCommand stmt = null;
			String sql = "";
			try 
			{
				sql = "DELETE FROM TARIFA_CONCEPTO WHERE ( id = @id )";
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


		public List<TARIFA_CONCEPTO> search(SqlConnection conn, TARIFA_CONCEPTO valueObject) 
		{
			List<TARIFA_CONCEPTO> searchResults = new List<TARIFA_CONCEPTO>();
			bool first = true;
			String sql = "SELECT * FROM TARIFA_CONCEPTO WHERE 1=1 ";

			if (!String.IsNullOrEmpty(valueObject.ID.ToString()) && valueObject.ID > 0) {
				if (first) { first = false; }
				sql += "AND ID= '" + valueObject.ID + "' ";
			}

            if (!String.IsNullOrEmpty(valueObject.CODIGO))
            {
                if (first) { first = false; }
                sql += "AND CODIGO= '" + valueObject.CODIGO + "' ";
            }

            if (!String.IsNullOrEmpty(valueObject.NOMBRE)) {
				if (first) { first = false; }
				sql += "AND NOMBRE= '" + valueObject.NOMBRE + "' ";
			}

			if (!String.IsNullOrEmpty(valueObject.DESCRIPCION)) {
				if (first) { first = false; }
				sql += "AND DESCRIPCION= '" + valueObject.DESCRIPCION + "' ";
			}

			if (!String.IsNullOrEmpty(valueObject.ESTADO)) {
				if (first) { first = false; }
				sql += "AND ESTADO= '" + valueObject.ESTADO + "' ";
			}

			sql += "ORDER BY id ASC ";

			if (first)
				searchResults = new List<TARIFA_CONCEPTO>();
			else
				searchResults = listQuery(new SqlCommand(sql,conn));

			return searchResults;
		}


		private int databaseUpdate(SqlCommand stmt) {
			int result = stmt.ExecuteNonQuery();
			return result;
		}


		private List<TARIFA_CONCEPTO> listQuery(SqlCommand stmt) 
		{

			List<TARIFA_CONCEPTO> searchResults = new List<TARIFA_CONCEPTO>();
			SqlDataReader reader = null;
			try 
			{
				int intt = 0; long longg = 0; double doublee = 0; float floatt = 0; DateTime datee; byte[] bytee;
				reader = stmt.ExecuteReader();
				while (reader.Read()) {
					TARIFA_CONCEPTO temp = createValueObject();

					temp.ID= reader["ID"] != null && int.TryParse(reader["ID"].ToString(),out intt) ? intt : 0;
                    temp.CODIGO = reader["CODIGO"] != null ? reader["CODIGO"].ToString() : null;
                    temp.NOMBRE= reader["NOMBRE"] != null ? reader["NOMBRE"].ToString() : null;
					temp.DESCRIPCION= reader["DESCRIPCION"] != null ? reader["DESCRIPCION"].ToString() : null;
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
