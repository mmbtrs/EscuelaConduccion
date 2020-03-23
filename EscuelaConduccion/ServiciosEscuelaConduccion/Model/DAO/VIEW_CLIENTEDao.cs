using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Data.SqlClient;

using ServiciosEscuelaConduccion.Model.Objects;

namespace ServiciosEscuelaConduccion.Model.DAO {

	public class VIEW_CLIENTEDao 
	{
		public VIEW_CLIENTE createValueObject()
		{
			return new VIEW_CLIENTE();
		}

		public List<VIEW_CLIENTE> loadAll(SqlConnection conn) 
		{
			String sql = "SELECT * FROM VIEW_CLIENTE ORDER BY ID ASC ";
			List<VIEW_CLIENTE> searchResults = listQuery(new SqlCommand(sql, conn));
			return searchResults;
		}


		public void create(SqlConnection conn, VIEW_CLIENTE valueObject) 
		{
			String sql = "";
			SqlCommand stmt = null;
			try 
			{
				sql = "INSERT INTO VIEW_CLIENTE ( ID,"+
				" TIPO_DOCUMENTO, IDENTIFICACION, NOMBRES,"+
				" APELLIDOS, DIRECCION, CIUDAD,"+
				" DEPARTAMENTO, GENERO, TELEFONO,"+
				" CELULAR, CORREO, FECHA_NACIMIENTO"+
				")"+
				 "VALUES (@ID,@TIPO_DOCUMENTO,@IDENTIFICACION,@NOMBRES,@APELLIDOS,@DIRECCION,@CIUDAD,@DEPARTAMENTO,@GENERO,@TELEFONO,@CELULAR,@CORREO,@FECHA_NACIMIENTO)";

				stmt = new SqlCommand(sql, conn);


				if(!String.IsNullOrEmpty(valueObject.TIPO_DOCUMENTO) && valueObject.TIPO_DOCUMENTO.Length <= 20)
					stmt.Parameters.AddWithValue("@TIPO_DOCUMENTO", valueObject.TIPO_DOCUMENTO);
				else
					stmt.Parameters.AddWithValue("@TIPO_DOCUMENTO", DBNull.Value);

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

				if(!String.IsNullOrEmpty(valueObject.DIRECCION) && valueObject.DIRECCION.Length <= 100)
					stmt.Parameters.AddWithValue("@DIRECCION", valueObject.DIRECCION);
				else
					stmt.Parameters.AddWithValue("@DIRECCION", DBNull.Value);

				if(!String.IsNullOrEmpty(valueObject.CIUDAD) && valueObject.CIUDAD.Length <= 30)
					stmt.Parameters.AddWithValue("@CIUDAD", valueObject.CIUDAD);
				else
					stmt.Parameters.AddWithValue("@CIUDAD", DBNull.Value);

				if(!String.IsNullOrEmpty(valueObject.DEPARTAMENTO) && valueObject.DEPARTAMENTO.Length <= 30)
					stmt.Parameters.AddWithValue("@DEPARTAMENTO", valueObject.DEPARTAMENTO);
				else
					stmt.Parameters.AddWithValue("@DEPARTAMENTO", DBNull.Value);

				if(!String.IsNullOrEmpty(valueObject.GENERO) && valueObject.GENERO.Length <= 20)
					stmt.Parameters.AddWithValue("@GENERO", valueObject.GENERO);
				else
					stmt.Parameters.AddWithValue("@GENERO", DBNull.Value);

				if(!String.IsNullOrEmpty(valueObject.TELEFONO) && valueObject.TELEFONO.Length <= 50)
					stmt.Parameters.AddWithValue("@TELEFONO", valueObject.TELEFONO);
				else
					stmt.Parameters.AddWithValue("@TELEFONO", DBNull.Value);

				if(!String.IsNullOrEmpty(valueObject.CELULAR) && valueObject.CELULAR.Length <= 10)
					stmt.Parameters.AddWithValue("@CELULAR", valueObject.CELULAR);
				else
					stmt.Parameters.AddWithValue("@CELULAR", DBNull.Value);

				if(!String.IsNullOrEmpty(valueObject.CORREO) && valueObject.CORREO.Length <= 50)
					stmt.Parameters.AddWithValue("@CORREO", valueObject.CORREO);
				else
					stmt.Parameters.AddWithValue("@CORREO", DBNull.Value);

				if(!String.IsNullOrEmpty(valueObject.FECHA_NACIMIENTO) && valueObject.FECHA_NACIMIENTO.Length <= 11)
					stmt.Parameters.AddWithValue("@FECHA_NACIMIENTO", valueObject.FECHA_NACIMIENTO);
				else
					stmt.Parameters.AddWithValue("@FECHA_NACIMIENTO", DBNull.Value);

				databaseUpdate(stmt);

			} finally {
				if (stmt != null)
					stmt.Dispose();
			}
		}


		public void save(SqlConnection conn, VIEW_CLIENTE valueObject) 
		{
			SqlCommand stmt = null;
			String sql = "";
			try 
			{
				sql = "UPDATE VIEW_CLIENTE SET ID = @ID ,"+
				" TIPO_DOCUMENTO = @TIPO_DOCUMENTO , IDENTIFICACION = @IDENTIFICACION , NOMBRES = @NOMBRES ,"+
				" APELLIDOS = @APELLIDOS , DIRECCION = @DIRECCION , CIUDAD = @CIUDAD ,"+
				" DEPARTAMENTO = @DEPARTAMENTO , GENERO = @GENERO , TELEFONO = @TELEFONO ,"+
				" CELULAR = @CELULAR , CORREO = @CORREO , FECHA_NACIMIENTO = @FECHA_NACIMIENTO "+
				" WHERE (id = @id)";
				stmt = new SqlCommand(sql, conn);


				if(!String.IsNullOrEmpty(valueObject.TIPO_DOCUMENTO) && valueObject.TIPO_DOCUMENTO.Length <= 20)
					stmt.Parameters.AddWithValue("@TIPO_DOCUMENTO", valueObject.TIPO_DOCUMENTO);
				else
					stmt.Parameters.AddWithValue("@TIPO_DOCUMENTO", DBNull.Value);

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

				if(!String.IsNullOrEmpty(valueObject.DIRECCION) && valueObject.DIRECCION.Length <= 100)
					stmt.Parameters.AddWithValue("@DIRECCION", valueObject.DIRECCION);
				else
					stmt.Parameters.AddWithValue("@DIRECCION", DBNull.Value);

				if(!String.IsNullOrEmpty(valueObject.CIUDAD) && valueObject.CIUDAD.Length <= 30)
					stmt.Parameters.AddWithValue("@CIUDAD", valueObject.CIUDAD);
				else
					stmt.Parameters.AddWithValue("@CIUDAD", DBNull.Value);

				if(!String.IsNullOrEmpty(valueObject.DEPARTAMENTO) && valueObject.DEPARTAMENTO.Length <= 30)
					stmt.Parameters.AddWithValue("@DEPARTAMENTO", valueObject.DEPARTAMENTO);
				else
					stmt.Parameters.AddWithValue("@DEPARTAMENTO", DBNull.Value);

				if(!String.IsNullOrEmpty(valueObject.GENERO) && valueObject.GENERO.Length <= 20)
					stmt.Parameters.AddWithValue("@GENERO", valueObject.GENERO);
				else
					stmt.Parameters.AddWithValue("@GENERO", DBNull.Value);

				if(!String.IsNullOrEmpty(valueObject.TELEFONO) && valueObject.TELEFONO.Length <= 50)
					stmt.Parameters.AddWithValue("@TELEFONO", valueObject.TELEFONO);
				else
					stmt.Parameters.AddWithValue("@TELEFONO", DBNull.Value);

				if(!String.IsNullOrEmpty(valueObject.CELULAR) && valueObject.CELULAR.Length <= 10)
					stmt.Parameters.AddWithValue("@CELULAR", valueObject.CELULAR);
				else
					stmt.Parameters.AddWithValue("@CELULAR", DBNull.Value);

				if(!String.IsNullOrEmpty(valueObject.CORREO) && valueObject.CORREO.Length <= 50)
					stmt.Parameters.AddWithValue("@CORREO", valueObject.CORREO);
				else
					stmt.Parameters.AddWithValue("@CORREO", DBNull.Value);

				if(!String.IsNullOrEmpty(valueObject.FECHA_NACIMIENTO) && valueObject.FECHA_NACIMIENTO.Length <= 11)
					stmt.Parameters.AddWithValue("@FECHA_NACIMIENTO", valueObject.FECHA_NACIMIENTO);
				else
					stmt.Parameters.AddWithValue("@FECHA_NACIMIENTO", DBNull.Value);

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


		public void delete(SqlConnection conn, VIEW_CLIENTE valueObject) 
		{
			SqlCommand stmt = null;
			String sql = "";
			try 
			{
				sql = "DELETE FROM VIEW_CLIENTE WHERE ( id = @id )";
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


		public List<VIEW_CLIENTE> search(SqlConnection conn, VIEW_CLIENTE valueObject) 
		{
			List<VIEW_CLIENTE> searchResults = new List<VIEW_CLIENTE>();
			bool first = true;
			String sql = "SELECT * FROM VIEW_CLIENTE WHERE 1=1 ";

			if (valueObject.ID > 0) {
				if (first) { first = false; }
				sql += "AND ID= " + valueObject.ID + " ";
			}

			if (!String.IsNullOrEmpty(valueObject.TIPO_DOCUMENTO)) {
				if (first) { first = false; }
				sql += "AND TIPO_DOCUMENTO= '" + valueObject.TIPO_DOCUMENTO + "' ";
			}

			if (!String.IsNullOrEmpty(valueObject.IDENTIFICACION)) {
				if (first) { first = false; }
				sql += "AND IDENTIFICACION= '" + valueObject.IDENTIFICACION + "' ";
			}

			if (!String.IsNullOrEmpty(valueObject.NOMBRES)) {
				if (first) { first = false; }
				sql += "AND NOMBRES= '" + valueObject.NOMBRES + "' ";
			}

			if (!String.IsNullOrEmpty(valueObject.APELLIDOS)) {
				if (first) { first = false; }
				sql += "AND APELLIDOS= '" + valueObject.APELLIDOS + "' ";
			}

			if (!String.IsNullOrEmpty(valueObject.DIRECCION)) {
				if (first) { first = false; }
				sql += "AND DIRECCION= '" + valueObject.DIRECCION + "' ";
			}

			if (!String.IsNullOrEmpty(valueObject.CIUDAD)) {
				if (first) { first = false; }
				sql += "AND CIUDAD= '" + valueObject.CIUDAD + "' ";
			}

			if (!String.IsNullOrEmpty(valueObject.DEPARTAMENTO)) {
				if (first) { first = false; }
				sql += "AND DEPARTAMENTO= '" + valueObject.DEPARTAMENTO + "' ";
			}

			if (!String.IsNullOrEmpty(valueObject.GENERO)) {
				if (first) { first = false; }
				sql += "AND GENERO= '" + valueObject.GENERO + "' ";
			}

			if (!String.IsNullOrEmpty(valueObject.TELEFONO)) {
				if (first) { first = false; }
				sql += "AND TELEFONO= '" + valueObject.TELEFONO + "' ";
			}

			if (!String.IsNullOrEmpty(valueObject.CELULAR)) {
				if (first) { first = false; }
				sql += "AND CELULAR= '" + valueObject.CELULAR + "' ";
			}

			if (!String.IsNullOrEmpty(valueObject.CORREO)) {
				if (first) { first = false; }
				sql += "AND CORREO= '" + valueObject.CORREO + "' ";
			}

			if (!String.IsNullOrEmpty(valueObject.FECHA_NACIMIENTO)) {
				if (first) { first = false; }
				sql += "AND FECHA_NACIMIENTO= '" + valueObject.FECHA_NACIMIENTO + "' ";
			}

			sql += "ORDER BY id ASC ";

			if (first)
				searchResults = new List<VIEW_CLIENTE>();
			else
				searchResults = listQuery(new SqlCommand(sql,conn));

			return searchResults;
		}


		private int databaseUpdate(SqlCommand stmt) {
			int result = stmt.ExecuteNonQuery();
			return result;
		}


		private List<VIEW_CLIENTE> listQuery(SqlCommand stmt) 
		{

			List<VIEW_CLIENTE> searchResults = new List<VIEW_CLIENTE>();
			SqlDataReader reader = null;
			try 
			{
				int intt = 0; long longg = 0; double doublee = 0; float floatt = 0; DateTime datee; byte[] bytee;
				reader = stmt.ExecuteReader();
				while (reader.Read()) {
					VIEW_CLIENTE temp = createValueObject();

					temp.ID= reader["ID"] != null && int.TryParse(reader["ID"].ToString(),out intt) ? intt : 0;
					temp.TIPO_DOCUMENTO= reader["TIPO_DOCUMENTO"] != null ? reader["TIPO_DOCUMENTO"].ToString() : null;
					temp.IDENTIFICACION= reader["IDENTIFICACION"] != null ? reader["IDENTIFICACION"].ToString() : null;
					temp.NOMBRES= reader["NOMBRES"] != null ? reader["NOMBRES"].ToString() : null;
					temp.APELLIDOS= reader["APELLIDOS"] != null ? reader["APELLIDOS"].ToString() : null;
					temp.DIRECCION= reader["DIRECCION"] != null ? reader["DIRECCION"].ToString() : null;
					temp.CIUDAD= reader["CIUDAD"] != null ? reader["CIUDAD"].ToString() : null;
					temp.DEPARTAMENTO= reader["DEPARTAMENTO"] != null ? reader["DEPARTAMENTO"].ToString() : null;
					temp.GENERO= reader["GENERO"] != null ? reader["GENERO"].ToString() : null;
					temp.TELEFONO= reader["TELEFONO"] != null ? reader["TELEFONO"].ToString() : null;
					temp.CELULAR= reader["CELULAR"] != null ? reader["CELULAR"].ToString() : null;
					temp.CORREO= reader["CORREO"] != null ? reader["CORREO"].ToString() : null;
					temp.FECHA_NACIMIENTO= reader["FECHA_NACIMIENTO"] != null ? reader["FECHA_NACIMIENTO"].ToString() : null;
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
