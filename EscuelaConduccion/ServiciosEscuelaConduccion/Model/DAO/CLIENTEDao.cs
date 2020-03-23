using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Data.SqlClient;

using ServiciosEscuelaConduccion.Model.Objects;

namespace ServiciosEscuelaConduccion.Model.DAO {

	public class CLIENTEDao 
	{
		public CLIENTE createValueObject()
		{
			return new CLIENTE();
		}

		public List<CLIENTE> loadAll(SqlConnection conn) 
		{
			String sql = "SELECT * FROM CLIENTE ORDER BY ID ASC ";
			List<CLIENTE> searchResults = listQuery(new SqlCommand(sql, conn));
			return searchResults;
		}


		public void create(SqlConnection conn, CLIENTE valueObject) 
		{
			String sql = "";
			SqlCommand stmt = null;
            try
            {
                sql = "INSERT INTO CLIENTE ( " +
                " ID_GENERO, ID_CIUDAD, ID_TIPO_DOCUMENTO," +
                " IDENTIFICACION, NOMBRES, APELLIDOS," +
                " DIRECCION, TELEFONO, CELULAR," +
                " CORREO, FECHA_NACIMIENTO)" +
                 "VALUES (@ID_GENERO,@ID_CIUDAD,@ID_TIPO_DOCUMENTO,@IDENTIFICACION,@NOMBRES,@APELLIDOS,@DIRECCION,@TELEFONO,@CELULAR,@CORREO,@FECHA_NACIMIENTO)";

                stmt = new SqlCommand(sql, conn);



                if (valueObject.ID_GENERO > 0)
                    stmt.Parameters.AddWithValue("@ID_GENERO", valueObject.ID_GENERO);
                else
                    stmt.Parameters.AddWithValue("@ID_GENERO", DBNull.Value);

                if (valueObject.ID_CIUDAD > 0)
                    stmt.Parameters.AddWithValue("@ID_CIUDAD", valueObject.ID_CIUDAD);
                else
                    stmt.Parameters.AddWithValue("@ID_CIUDAD", DBNull.Value);

                if (valueObject.ID_TIPO_DOCUMENTO > 0)
                    stmt.Parameters.AddWithValue("@ID_TIPO_DOCUMENTO", valueObject.ID_TIPO_DOCUMENTO);
                else
                    stmt.Parameters.AddWithValue("@ID_TIPO_DOCUMENTO", DBNull.Value);

                if (!String.IsNullOrEmpty(valueObject.IDENTIFICACION) && valueObject.IDENTIFICACION.Length <= 20)
                    stmt.Parameters.AddWithValue("@IDENTIFICACION", valueObject.IDENTIFICACION);
                else
                    stmt.Parameters.AddWithValue("@IDENTIFICACION", DBNull.Value);

                if (!String.IsNullOrEmpty(valueObject.NOMBRES) && valueObject.NOMBRES.Length <= 50)
                    stmt.Parameters.AddWithValue("@NOMBRES", valueObject.NOMBRES);
                else
                    stmt.Parameters.AddWithValue("@NOMBRES", DBNull.Value);

                if (!String.IsNullOrEmpty(valueObject.APELLIDOS) && valueObject.APELLIDOS.Length <= 50)
                    stmt.Parameters.AddWithValue("@APELLIDOS", valueObject.APELLIDOS);
                else
                    stmt.Parameters.AddWithValue("@APELLIDOS", DBNull.Value);

                if (!String.IsNullOrEmpty(valueObject.DIRECCION) && valueObject.DIRECCION.Length <= 100)
                    stmt.Parameters.AddWithValue("@DIRECCION", valueObject.DIRECCION);
                else
                    stmt.Parameters.AddWithValue("@DIRECCION", DBNull.Value);

                if (!String.IsNullOrEmpty(valueObject.TELEFONO) && valueObject.TELEFONO.Length <= 50)
                    stmt.Parameters.AddWithValue("@TELEFONO", valueObject.TELEFONO);
                else
                    stmt.Parameters.AddWithValue("@TELEFONO", DBNull.Value);

                if (!String.IsNullOrEmpty(valueObject.CELULAR) && valueObject.CELULAR.Length <= 10)
                    stmt.Parameters.AddWithValue("@CELULAR", valueObject.CELULAR);
                else
                    stmt.Parameters.AddWithValue("@CELULAR", DBNull.Value);

                if (!String.IsNullOrEmpty(valueObject.CORREO) && valueObject.CORREO.Length <= 50)
                    stmt.Parameters.AddWithValue("@CORREO", valueObject.CORREO);
                else
                    stmt.Parameters.AddWithValue("@CORREO", DBNull.Value);

                if (valueObject.FECHA_NACIMIENTO > DateTime.MinValue)
                    stmt.Parameters.AddWithValue("@FECHA_NACIMIENTO", valueObject.FECHA_NACIMIENTO);
                else
                    stmt.Parameters.AddWithValue("@FECHA_NACIMIENTO", DBNull.Value);

                databaseUpdate(stmt);
            } catch(Exception e)
            {
                System.IO.File.WriteAllText(@"D:\LogEscuelaConduccion2.txt", e.Message);
            }

			 finally {
				if (stmt != null)
					stmt.Dispose();
			}
            
		}


		public void save(SqlConnection conn, CLIENTE valueObject) 
		{
			SqlCommand stmt = null;
			String sql = "";
			try 
			{
				sql = "UPDATE CLIENTE SET "+
				" ID_GENERO = @ID_GENERO , ID_CIUDAD = @ID_CIUDAD , ID_TIPO_DOCUMENTO = @ID_TIPO_DOCUMENTO ,"+
				" IDENTIFICACION = @IDENTIFICACION , NOMBRES = @NOMBRES , APELLIDOS = @APELLIDOS ,"+
				" DIRECCION = @DIRECCION , TELEFONO = @TELEFONO , CELULAR = @CELULAR ,"+
				" CORREO = @CORREO , FECHA_NACIMIENTO = @FECHA_NACIMIENTO  WHERE (id = @id)";
				stmt = new SqlCommand(sql, conn);



                if (valueObject.ID_GENERO > 0)
                    stmt.Parameters.AddWithValue("@ID_GENERO", valueObject.ID_GENERO);
                else
                    stmt.Parameters.AddWithValue("@ID_GENERO", DBNull.Value);

                if (valueObject.ID_CIUDAD > 0)
                    stmt.Parameters.AddWithValue("@ID_CIUDAD", valueObject.ID_CIUDAD);
                else
                    stmt.Parameters.AddWithValue("@ID_CIUDAD", DBNull.Value);

                if (valueObject.ID_TIPO_DOCUMENTO > 0)
                    stmt.Parameters.AddWithValue("@ID_TIPO_DOCUMENTO", valueObject.ID_TIPO_DOCUMENTO);
                else
                    stmt.Parameters.AddWithValue("@ID_TIPO_DOCUMENTO", DBNull.Value);

                if (!String.IsNullOrEmpty(valueObject.IDENTIFICACION) && valueObject.IDENTIFICACION.Length <= 20)
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

				if(valueObject.FECHA_NACIMIENTO > DateTime.MinValue)
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


		public void delete(SqlConnection conn, CLIENTE valueObject) 
		{
			SqlCommand stmt = null;
			String sql = "";
			try 
			{
				sql = "DELETE FROM CLIENTE WHERE ( id = @id )";
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


		public List<CLIENTE> search(SqlConnection conn, CLIENTE valueObject) 
		{
			List<CLIENTE> searchResults = new List<CLIENTE>();
			bool first = true;
			String sql = "SELECT * FROM CLIENTE WHERE 1=1 ";

			if (valueObject.ID > 0) {
				if (first) { first = false; }
				sql += "AND ID= '" + valueObject.ID + "' ";
			}

			if (valueObject.ID_GENERO > 0) {
				if (first) { first = false; }
				sql += "AND ID_GENERO= '" + valueObject.ID_GENERO + "' ";
			}

			if (valueObject.ID_CIUDAD > 0) {
				if (first) { first = false; }
				sql += "AND ID_CIUDAD= '" + valueObject.ID_CIUDAD + "' ";
			}

			if (valueObject.ID_TIPO_DOCUMENTO > 0) {
				if (first) { first = false; }
				sql += "AND ID_TIPO_DOCUMENTO= '" + valueObject.ID_TIPO_DOCUMENTO + "' ";
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

			if (valueObject.FECHA_NACIMIENTO > DateTime.MinValue) {
				if (first) { first = false; }
				sql += "AND FECHA_NACIMIENTO= '" + valueObject.FECHA_NACIMIENTO.ToString("dd/MM/yyyy HH:mm:ss") + "' ";
			}

			sql += "ORDER BY id ASC ";

			if (first)
				searchResults = new List<CLIENTE>();
			else
				searchResults = listQuery(new SqlCommand(sql,conn));

			return searchResults;
		}


		private int databaseUpdate(SqlCommand stmt) {
			int result = stmt.ExecuteNonQuery();
			return result;
		}


		private List<CLIENTE> listQuery(SqlCommand stmt) 
		{

			List<CLIENTE> searchResults = new List<CLIENTE>();
			SqlDataReader reader = null;
			try 
			{
				int intt = 0; long longg = 0; double doublee = 0; float floatt = 0; DateTime datee; byte[] bytee;
				reader = stmt.ExecuteReader();
				while (reader.Read()) {
					CLIENTE temp = createValueObject();

					temp.ID= reader["ID"] != null && int.TryParse(reader["ID"].ToString(),out intt) ? intt : 0;
					temp.ID_GENERO= reader["ID_GENERO"] != null && int.TryParse(reader["ID_GENERO"].ToString(),out intt) ? intt : 0;
					temp.ID_CIUDAD= reader["ID_CIUDAD"] != null && int.TryParse(reader["ID_CIUDAD"].ToString(),out intt) ? intt : 0;
					temp.ID_TIPO_DOCUMENTO= reader["ID_TIPO_DOCUMENTO"] != null && int.TryParse(reader["ID_TIPO_DOCUMENTO"].ToString(),out intt) ? intt : 0;
					temp.IDENTIFICACION= reader["IDENTIFICACION"] != null ? reader["IDENTIFICACION"].ToString() : null;
					temp.NOMBRES= reader["NOMBRES"] != null ? reader["NOMBRES"].ToString() : null;
					temp.APELLIDOS= reader["APELLIDOS"] != null ? reader["APELLIDOS"].ToString() : null;
					temp.DIRECCION= reader["DIRECCION"] != null ? reader["DIRECCION"].ToString() : null;
					temp.TELEFONO= reader["TELEFONO"] != null ? reader["TELEFONO"].ToString() : null;
					temp.CELULAR= reader["CELULAR"] != null ? reader["CELULAR"].ToString() : null;
					temp.CORREO= reader["CORREO"] != null ? reader["CORREO"].ToString() : null;
					temp.FECHA_NACIMIENTO= reader["FECHA_NACIMIENTO"] != null && !String.IsNullOrEmpty(reader["FECHA_NACIMIENTO"].ToString()) ? (DateTime)reader["FECHA_NACIMIENTO"] : DateTime.MinValue;
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
