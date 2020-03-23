using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Data.SqlClient;

using ServiciosEscuelaConduccion.Model.Objects;

namespace ServiciosEscuelaConduccion.Model.DAO {

	public class USUARIODao 
	{
		public USUARIO createValueObject()
		{
			return new USUARIO();
		}

		public List<USUARIO> loadAll(SqlConnection conn) 
		{
			String sql = "SELECT * FROM USUARIO ORDER BY ID ASC ";
			List<USUARIO> searchResults = listQuery(new SqlCommand(sql, conn));
			return searchResults;
		}


		public void create(SqlConnection conn, USUARIO valueObject) 
		{
			String sql = "";
			SqlCommand stmt = null;
			try 
			{
				sql = "INSERT INTO USUARIO ( ID,"+
				" ID_PERFIL, ID_TIPO_DOCUMENTO, LOGIN,"+
				" PASSWORD, FECHA_INGRESO, FECHA_RETIRO,"+
				" IDENTIFICACION, NOMBRES, APELLIDOS,"+
				" ESTADO, FOTO)"+
				 "VALUES (@ID,@ID_PERFIL,@ID_TIPO_DOCUMENTO,@LOGIN,@PASSWORD,@FECHA_INGRESO,@FECHA_RETIRO,@IDENTIFICACION,@NOMBRES,@APELLIDOS,@ESTADO,@FOTO)";

				stmt = new SqlCommand(sql, conn);




				if(!String.IsNullOrEmpty(valueObject.LOGIN) && valueObject.LOGIN.Length <= 20)
					stmt.Parameters.AddWithValue("@LOGIN", valueObject.LOGIN);
				else
					stmt.Parameters.AddWithValue("@LOGIN", DBNull.Value);

				if(!String.IsNullOrEmpty(valueObject.PASSWORD) && valueObject.PASSWORD.Length <= 1000)
					stmt.Parameters.AddWithValue("@PASSWORD", valueObject.PASSWORD);
				else
					stmt.Parameters.AddWithValue("@PASSWORD", DBNull.Value);

				if(valueObject.FECHA_INGRESO > DateTime.MinValue)
					stmt.Parameters.AddWithValue("@FECHA_INGRESO", valueObject.FECHA_INGRESO);
				else
					stmt.Parameters.AddWithValue("@FECHA_INGRESO", DBNull.Value);

				if(valueObject.FECHA_RETIRO > DateTime.MinValue)
					stmt.Parameters.AddWithValue("@FECHA_RETIRO", valueObject.FECHA_RETIRO);
				else
					stmt.Parameters.AddWithValue("@FECHA_RETIRO", DBNull.Value);

				if(!String.IsNullOrEmpty(valueObject.IDENTIFICACION) && valueObject.IDENTIFICACION.Length <= 20)
					stmt.Parameters.AddWithValue("@IDENTIFICACION", valueObject.IDENTIFICACION);
				else
					stmt.Parameters.AddWithValue("@IDENTIFICACION", DBNull.Value);

				if(!String.IsNullOrEmpty(valueObject.NOMBRES) && valueObject.NOMBRES.Length <= 50)
					stmt.Parameters.AddWithValue("@NOMBRES", valueObject.NOMBRES);
				else
					stmt.Parameters.AddWithValue("@NOMBRES", DBNull.Value);

				if(!String.IsNullOrEmpty(valueObject.APELLIDOS) && valueObject.APELLIDOS.Length <= 50)
					stmt.Parameters.AddWithValue("@APELLIDOS", valueObject.APELLIDOS);
				else
					stmt.Parameters.AddWithValue("@APELLIDOS", DBNull.Value);

				if(!String.IsNullOrEmpty(valueObject.ESTADO) && valueObject.ESTADO.Length <= 1)
					stmt.Parameters.AddWithValue("@ESTADO", valueObject.ESTADO);
				else
					stmt.Parameters.AddWithValue("@ESTADO", DBNull.Value);

				if(valueObject.FOTO != null)
					stmt.Parameters.AddWithValue("@FOTO", valueObject.FOTO);
				else
					stmt.Parameters.AddWithValue("@FOTO", new byte[0]);

				databaseUpdate(stmt);

			} finally {
				if (stmt != null)
					stmt.Dispose();
			}
		}


		public void save(SqlConnection conn, USUARIO valueObject) 
		{
			SqlCommand stmt = null;
			String sql = "";
			try 
			{
				sql = "UPDATE USUARIO SET ID = @ID ,"+
				" ID_PERFIL = @ID_PERFIL , ID_TIPO_DOCUMENTO = @ID_TIPO_DOCUMENTO , LOGIN = @LOGIN ,"+
				" PASSWORD = @PASSWORD , FECHA_INGRESO = @FECHA_INGRESO , FECHA_RETIRO = @FECHA_RETIRO ,"+
				" IDENTIFICACION = @IDENTIFICACION , NOMBRES = @NOMBRES , APELLIDOS = @APELLIDOS ,"+
				" ESTADO = @ESTADO , FOTO = @FOTO  WHERE (id = @id)";
				stmt = new SqlCommand(sql, conn);




				if(!String.IsNullOrEmpty(valueObject.LOGIN) && valueObject.LOGIN.Length <= 20)
					stmt.Parameters.AddWithValue("@LOGIN", valueObject.LOGIN);
				else
					stmt.Parameters.AddWithValue("@LOGIN", DBNull.Value);

				if(!String.IsNullOrEmpty(valueObject.PASSWORD) && valueObject.PASSWORD.Length <= 1000)
					stmt.Parameters.AddWithValue("@PASSWORD", valueObject.PASSWORD);
				else
					stmt.Parameters.AddWithValue("@PASSWORD", DBNull.Value);

				if(valueObject.FECHA_INGRESO > DateTime.MinValue)
					stmt.Parameters.AddWithValue("@FECHA_INGRESO", valueObject.FECHA_INGRESO);
				else
					stmt.Parameters.AddWithValue("@FECHA_INGRESO", DBNull.Value);

				if(valueObject.FECHA_RETIRO > DateTime.MinValue)
					stmt.Parameters.AddWithValue("@FECHA_RETIRO", valueObject.FECHA_RETIRO);
				else
					stmt.Parameters.AddWithValue("@FECHA_RETIRO", DBNull.Value);

				if(!String.IsNullOrEmpty(valueObject.IDENTIFICACION) && valueObject.IDENTIFICACION.Length <= 20)
					stmt.Parameters.AddWithValue("@IDENTIFICACION", valueObject.IDENTIFICACION);
				else
					stmt.Parameters.AddWithValue("@IDENTIFICACION", DBNull.Value);

				if(!String.IsNullOrEmpty(valueObject.NOMBRES) && valueObject.NOMBRES.Length <= 50)
					stmt.Parameters.AddWithValue("@NOMBRES", valueObject.NOMBRES);
				else
					stmt.Parameters.AddWithValue("@NOMBRES", DBNull.Value);

				if(!String.IsNullOrEmpty(valueObject.APELLIDOS) && valueObject.APELLIDOS.Length <= 50)
					stmt.Parameters.AddWithValue("@APELLIDOS", valueObject.APELLIDOS);
				else
					stmt.Parameters.AddWithValue("@APELLIDOS", DBNull.Value);

				if(!String.IsNullOrEmpty(valueObject.ESTADO) && valueObject.ESTADO.Length <= 1)
					stmt.Parameters.AddWithValue("@ESTADO", valueObject.ESTADO);
				else
					stmt.Parameters.AddWithValue("@ESTADO", DBNull.Value);

				if(valueObject.FOTO != null)
					stmt.Parameters.AddWithValue("@FOTO", valueObject.FOTO);
				else
					stmt.Parameters.AddWithValue("@FOTO", new byte[0]);

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


		public void delete(SqlConnection conn, USUARIO valueObject) 
		{
			SqlCommand stmt = null;
			String sql = "";
			try 
			{
				sql = "DELETE FROM USUARIO WHERE ( id = @id )";
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


		public List<USUARIO> search(SqlConnection conn, USUARIO valueObject) 
		{
			List<USUARIO> searchResults = new List<USUARIO>();
			bool first = true;
			String sql = "SELECT * FROM USUARIO WHERE 1=1 ";

			if (!String.IsNullOrEmpty(valueObject.ID.ToString())) {
				if (first) { first = false; }
				sql += "AND ID= '" + valueObject.ID + "' ";
			}

			if (!String.IsNullOrEmpty(valueObject.ID_PERFIL.ToString())) {
				if (first) { first = false; }
				sql += "AND ID_PERFIL= '" + valueObject.ID_PERFIL + "' ";
			}

			if (!String.IsNullOrEmpty(valueObject.ID_TIPO_DOCUMENTO.ToString())) {
				if (first) { first = false; }
				sql += "AND ID_TIPO_DOCUMENTO= '" + valueObject.ID_TIPO_DOCUMENTO + "' ";
			}

			if (!String.IsNullOrEmpty(valueObject.LOGIN.ToString())) {
				if (first) { first = false; }
				sql += "AND LOGIN= '" + valueObject.LOGIN + "' ";
			}

			if (!String.IsNullOrEmpty(valueObject.PASSWORD.ToString())) {
				if (first) { first = false; }
				sql += "AND PASSWORD= '" + valueObject.PASSWORD + "' ";
			}

			if (valueObject.FECHA_INGRESO > DateTime.MinValue) {
				if (first) { first = false; }
				sql += "AND FECHA_INGRESO= '" + valueObject.FECHA_INGRESO.ToString("dd/MM/yyyy HH:mm:ss") + "' ";
			}

			if (valueObject.FECHA_RETIRO > DateTime.MinValue) {
				if (first) { first = false; }
				sql += "AND FECHA_RETIRO= '" + valueObject.FECHA_RETIRO.ToString("dd/MM/yyyy HH:mm:ss") + "' ";
			}

			if (!String.IsNullOrEmpty(valueObject.IDENTIFICACION.ToString())) {
				if (first) { first = false; }
				sql += "AND IDENTIFICACION= '" + valueObject.IDENTIFICACION + "' ";
			}

			if (!String.IsNullOrEmpty(valueObject.NOMBRES.ToString())) {
				if (first) { first = false; }
				sql += "AND NOMBRES= '" + valueObject.NOMBRES + "' ";
			}

			if (!String.IsNullOrEmpty(valueObject.APELLIDOS.ToString())) {
				if (first) { first = false; }
				sql += "AND APELLIDOS= '" + valueObject.APELLIDOS + "' ";
			}

			if (!String.IsNullOrEmpty(valueObject.ESTADO.ToString())) {
				if (first) { first = false; }
				sql += "AND ESTADO= '" + valueObject.ESTADO + "' ";
			}

			sql += "ORDER BY id ASC ";

			if (first)
				searchResults = new List<USUARIO>();
			else
				searchResults = listQuery(new SqlCommand(sql,conn));

			return searchResults;
		}


		private int databaseUpdate(SqlCommand stmt) {
			int result = stmt.ExecuteNonQuery();
			return result;
		}


		private List<USUARIO> listQuery(SqlCommand stmt) 
		{

			List<USUARIO> searchResults = new List<USUARIO>();
			SqlDataReader reader = null;
			try 
			{
				int intt = 0; long longg = 0; double doublee = 0; float floatt = 0; DateTime datee; byte[] bytee;
				reader = stmt.ExecuteReader();
				while (reader.Read()) {
					USUARIO temp = createValueObject();

					temp.ID= reader["ID"] != null && int.TryParse(reader["ID"].ToString(),out intt) ? intt : 0;
					temp.ID_PERFIL= reader["ID_PERFIL"] != null && int.TryParse(reader["ID_PERFIL"].ToString(),out intt) ? intt : 0;
					temp.ID_TIPO_DOCUMENTO= reader["ID_TIPO_DOCUMENTO"] != null && int.TryParse(reader["ID_TIPO_DOCUMENTO"].ToString(),out intt) ? intt : 0;
					temp.LOGIN= reader["LOGIN"] != null ? reader["LOGIN"].ToString() : null;
					temp.PASSWORD= reader["PASSWORD"] != null ? reader["PASSWORD"].ToString() : null;
					temp.FECHA_INGRESO= reader["FECHA_INGRESO"] != null && !String.IsNullOrEmpty(reader["FECHA_INGRESO"].ToString()) ? (DateTime)reader["FECHA_INGRESO"] : DateTime.MinValue;
					temp.FECHA_RETIRO= reader["FECHA_RETIRO"] != null && !String.IsNullOrEmpty(reader["FECHA_RETIRO"].ToString()) ? (DateTime)reader["FECHA_RETIRO"] : DateTime.MinValue;
					temp.IDENTIFICACION= reader["IDENTIFICACION"] != null ? reader["IDENTIFICACION"].ToString() : null;
					temp.NOMBRES= reader["NOMBRES"] != null ? reader["NOMBRES"].ToString() : null;
					temp.APELLIDOS= reader["APELLIDOS"] != null ? reader["APELLIDOS"].ToString() : null;
					temp.ESTADO= reader["ESTADO"] != null ? reader["ESTADO"].ToString() : null;
					try
					{
						temp.FOTO = reader["FOTO"] != null ? (byte[])reader["FOTO"] : null;
					}
					catch (Exception)
					{
						temp.FOTO = null;
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
