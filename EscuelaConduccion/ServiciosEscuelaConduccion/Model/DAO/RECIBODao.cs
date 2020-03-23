using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Data.SqlClient;

using ServiciosEscuelaConduccion.Model.Objects;

namespace ServiciosEscuelaConduccion.Model.DAO {

	public class RECIBODao 
	{
		public RECIBO createValueObject()
		{
			return new RECIBO();
		}

		public List<RECIBO> loadAll(SqlConnection conn) 
		{
			String sql = "SELECT * FROM RECIBO ORDER BY ID ASC ";
			List<RECIBO> searchResults = listQuery(new SqlCommand(sql, conn));
			return searchResults;
		}


		public void create(SqlConnection conn, RECIBO valueObject) 
		{
			String sql = "";
			SqlCommand stmt = null;
			try 
			{
				sql = "INSERT INTO RECIBO ("+
				" ID_LIQUIDACION, ID_ESTADO, NUMERO_RECIBO,"+
				" FECHA_RECIBO, FECHA_REGISTRO_PAGO, FECHA_PAGO,"+
				" VALOR, FECHA_VENCIMIENTO, FECHA_ENTRAMITE,"+
				" FECHA_ANULADO, FECHA_PAGOANULADO, FECHA_PROCESADO,"+
				" ARCHIVO_FISICO)"+
				 "VALUES (@ID_LIQUIDACION,@ID_ESTADO,@NUMERO_RECIBO,@FECHA_RECIBO,@FECHA_REGISTRO_PAGO,@FECHA_PAGO,@VALOR,@FECHA_VENCIMIENTO,@FECHA_ENTRAMITE,@FECHA_ANULADO,@FECHA_PAGOANULADO,@FECHA_PROCESADO,@ARCHIVO_FISICO)";

				stmt = new SqlCommand(sql, conn);


                //stmt.Parameters.AddWithValue("@ID", valueObject.ID);

                if (!String.IsNullOrEmpty(valueObject.ID_LIQUIDACION.ToString()) && valueObject.ID_LIQUIDACION > 0)
                    stmt.Parameters.AddWithValue("@ID_LIQUIDACION", valueObject.ID_LIQUIDACION);
                else
                    stmt.Parameters.AddWithValue("@ID_LIQUIDACION", DBNull.Value);
                if (!String.IsNullOrEmpty(valueObject.ID_ESTADO.ToString()) && valueObject.ID_ESTADO > 0)
                    stmt.Parameters.AddWithValue("@ID_ESTADO", valueObject.ID_ESTADO);
                else
                    stmt.Parameters.AddWithValue("@ID_ESTADO", DBNull.Value);
                if (!String.IsNullOrEmpty(valueObject.NUMERO_RECIBO) && valueObject.NUMERO_RECIBO.Length <= 10)
					stmt.Parameters.AddWithValue("@NUMERO_RECIBO", valueObject.NUMERO_RECIBO);
				else
					stmt.Parameters.AddWithValue("@NUMERO_RECIBO", DBNull.Value);

				if(valueObject.FECHA_RECIBO > DateTime.MinValue)
					stmt.Parameters.AddWithValue("@FECHA_RECIBO", valueObject.FECHA_RECIBO);
				else
					stmt.Parameters.AddWithValue("@FECHA_RECIBO", DBNull.Value);

				if(valueObject.FECHA_REGISTRO_PAGO > DateTime.MinValue)
					stmt.Parameters.AddWithValue("@FECHA_REGISTRO_PAGO", valueObject.FECHA_REGISTRO_PAGO);
				else
					stmt.Parameters.AddWithValue("@FECHA_REGISTRO_PAGO", DBNull.Value);

				if(valueObject.FECHA_PAGO > DateTime.MinValue)
					stmt.Parameters.AddWithValue("@FECHA_PAGO", valueObject.FECHA_PAGO);
				else
					stmt.Parameters.AddWithValue("@FECHA_PAGO", DBNull.Value);
                if (!String.IsNullOrEmpty(valueObject.VALOR.ToString()) && valueObject.VALOR > 0)
                    stmt.Parameters.AddWithValue("@VALOR", valueObject.VALOR);
                else
                    stmt.Parameters.AddWithValue("@VALOR", DBNull.Value);
                if (valueObject.FECHA_VENCIMIENTO > DateTime.MinValue)
					stmt.Parameters.AddWithValue("@FECHA_VENCIMIENTO", valueObject.FECHA_VENCIMIENTO);
				else
					stmt.Parameters.AddWithValue("@FECHA_VENCIMIENTO", DBNull.Value);

				if(valueObject.FECHA_ENTRAMITE > DateTime.MinValue)
					stmt.Parameters.AddWithValue("@FECHA_ENTRAMITE", valueObject.FECHA_ENTRAMITE);
				else
					stmt.Parameters.AddWithValue("@FECHA_ENTRAMITE", DBNull.Value);

				if(valueObject.FECHA_ANULADO > DateTime.MinValue)
					stmt.Parameters.AddWithValue("@FECHA_ANULADO", valueObject.FECHA_ANULADO);
				else
					stmt.Parameters.AddWithValue("@FECHA_ANULADO", DBNull.Value);

				if(valueObject.FECHA_PAGOANULADO > DateTime.MinValue)
					stmt.Parameters.AddWithValue("@FECHA_PAGOANULADO", valueObject.FECHA_PAGOANULADO);
				else
					stmt.Parameters.AddWithValue("@FECHA_PAGOANULADO", DBNull.Value);

				if(valueObject.FECHA_PROCESADO > DateTime.MinValue)
					stmt.Parameters.AddWithValue("@FECHA_PROCESADO", valueObject.FECHA_PROCESADO);
				else
					stmt.Parameters.AddWithValue("@FECHA_PROCESADO", DBNull.Value);

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


		public void save(SqlConnection conn, RECIBO valueObject) 
		{
			SqlCommand stmt = null;
			String sql = "";
			try 
			{
				sql = "UPDATE RECIBO SET "+
				" ID_LIQUIDACION = @ID_LIQUIDACION , ID_ESTADO = @ID_ESTADO , NUMERO_RECIBO = @NUMERO_RECIBO ,"+
				" FECHA_RECIBO = @FECHA_RECIBO , FECHA_REGISTRO_PAGO = @FECHA_REGISTRO_PAGO , FECHA_PAGO = @FECHA_PAGO ,"+
				" VALOR = @VALOR , FECHA_VENCIMIENTO = @FECHA_VENCIMIENTO , FECHA_ENTRAMITE = @FECHA_ENTRAMITE ,"+
				" FECHA_ANULADO = @FECHA_ANULADO , FECHA_PAGOANULADO = @FECHA_PAGOANULADO , FECHA_PROCESADO = @FECHA_PROCESADO ,"+
				" ARCHIVO_FISICO = @ARCHIVO_FISICO  WHERE (id = @id)";
				stmt = new SqlCommand(sql, conn);


                if (valueObject.ID_LIQUIDACION > 0)
                    stmt.Parameters.AddWithValue("@ID_LIQUIDACION", valueObject.ID_LIQUIDACION);
                else
                    stmt.Parameters.AddWithValue("@ID_LIQUIDACION", DBNull.Value);
                if (valueObject.ID_ESTADO > 0)
                    stmt.Parameters.AddWithValue("@ID_ESTADO", valueObject.ID_ESTADO);
                else
                    stmt.Parameters.AddWithValue("@ID_ESTADO", DBNull.Value);

                if (!String.IsNullOrEmpty(valueObject.NUMERO_RECIBO) && valueObject.NUMERO_RECIBO.Length <= 10)
					stmt.Parameters.AddWithValue("@NUMERO_RECIBO", valueObject.NUMERO_RECIBO);
				else
					stmt.Parameters.AddWithValue("@NUMERO_RECIBO", DBNull.Value);

				if(valueObject.FECHA_RECIBO > DateTime.MinValue)
					stmt.Parameters.AddWithValue("@FECHA_RECIBO", valueObject.FECHA_RECIBO);
				else
					stmt.Parameters.AddWithValue("@FECHA_RECIBO", DBNull.Value);

				if(valueObject.FECHA_REGISTRO_PAGO > DateTime.MinValue)
					stmt.Parameters.AddWithValue("@FECHA_REGISTRO_PAGO", valueObject.FECHA_REGISTRO_PAGO);
				else
					stmt.Parameters.AddWithValue("@FECHA_REGISTRO_PAGO", DBNull.Value);

				if(valueObject.FECHA_PAGO > DateTime.MinValue)
					stmt.Parameters.AddWithValue("@FECHA_PAGO", valueObject.FECHA_PAGO);
				else
					stmt.Parameters.AddWithValue("@FECHA_PAGO", DBNull.Value);
                if (valueObject.VALOR > 0)
                    stmt.Parameters.AddWithValue("@VALOR", valueObject.VALOR);
                else
                    stmt.Parameters.AddWithValue("@VALOR", DBNull.Value);

                if (valueObject.FECHA_VENCIMIENTO > DateTime.MinValue)
					stmt.Parameters.AddWithValue("@FECHA_VENCIMIENTO", valueObject.FECHA_VENCIMIENTO);
				else
					stmt.Parameters.AddWithValue("@FECHA_VENCIMIENTO", DBNull.Value);

				if(valueObject.FECHA_ENTRAMITE > DateTime.MinValue)
					stmt.Parameters.AddWithValue("@FECHA_ENTRAMITE", valueObject.FECHA_ENTRAMITE);
				else
					stmt.Parameters.AddWithValue("@FECHA_ENTRAMITE", DBNull.Value);

				if(valueObject.FECHA_ANULADO > DateTime.MinValue)
					stmt.Parameters.AddWithValue("@FECHA_ANULADO", valueObject.FECHA_ANULADO);
				else
					stmt.Parameters.AddWithValue("@FECHA_ANULADO", DBNull.Value);

				if(valueObject.FECHA_PAGOANULADO > DateTime.MinValue)
					stmt.Parameters.AddWithValue("@FECHA_PAGOANULADO", valueObject.FECHA_PAGOANULADO);
				else
					stmt.Parameters.AddWithValue("@FECHA_PAGOANULADO", DBNull.Value);

				if(valueObject.FECHA_PROCESADO > DateTime.MinValue)
					stmt.Parameters.AddWithValue("@FECHA_PROCESADO", valueObject.FECHA_PROCESADO);
				else
					stmt.Parameters.AddWithValue("@FECHA_PROCESADO", DBNull.Value);

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


		public void delete(SqlConnection conn, RECIBO valueObject) 
		{
			SqlCommand stmt = null;
			String sql = "";
			try 
			{
				sql = "DELETE FROM RECIBO WHERE ( id = @id )";
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


		public List<RECIBO> search(SqlConnection conn, RECIBO valueObject) 
		{
			List<RECIBO> searchResults = new List<RECIBO>();
			bool first = true;
			String sql = "SELECT * FROM RECIBO WHERE 1=1 ";

			if (!String.IsNullOrEmpty(valueObject.ID.ToString()) && valueObject.ID > 0) {
				if (first) { first = false; }
				sql += "AND ID= '" + valueObject.ID + "' ";
			}

			if (!String.IsNullOrEmpty(valueObject.ID_LIQUIDACION.ToString()) && valueObject.ID_LIQUIDACION > 0) {
				if (first) { first = false; }
				sql += "AND ID_LIQUIDACION= '" + valueObject.ID_LIQUIDACION + "' ";
			}

			if (!String.IsNullOrEmpty(valueObject.ID_ESTADO.ToString()) && valueObject.ID_ESTADO > 0) {
				if (first) { first = false; }
				sql += "AND ID_ESTADO= '" + valueObject.ID_ESTADO + "' ";
			}

			if (!String.IsNullOrEmpty(valueObject.NUMERO_RECIBO)) {
				if (first) { first = false; }
				sql += "AND NUMERO_RECIBO= '" + valueObject.NUMERO_RECIBO + "' ";
			}

			if (valueObject.FECHA_RECIBO > DateTime.MinValue) {
				if (first) { first = false; }
				sql += "AND FECHA_RECIBO= '" + valueObject.FECHA_RECIBO.ToString("dd/MM/yyyy HH:mm:ss") + "' ";
			}

			if (valueObject.FECHA_REGISTRO_PAGO > DateTime.MinValue) {
				if (first) { first = false; }
				sql += "AND FECHA_REGISTRO_PAGO= '" + valueObject.FECHA_REGISTRO_PAGO.ToString("dd/MM/yyyy HH:mm:ss") + "' ";
			}

			if (valueObject.FECHA_PAGO > DateTime.MinValue) {
				if (first) { first = false; }
				sql += "AND FECHA_PAGO= '" + valueObject.FECHA_PAGO.ToString("dd/MM/yyyy HH:mm:ss") + "' ";
			}

			if (!String.IsNullOrEmpty(valueObject.VALOR.ToString()) && valueObject.VALOR > 0) {
				if (first) { first = false; }
				sql += "AND VALOR= '" + valueObject.VALOR + "' ";
			}

			if (valueObject.FECHA_VENCIMIENTO > DateTime.MinValue) {
				if (first) { first = false; }
				sql += "AND FECHA_VENCIMIENTO= '" + valueObject.FECHA_VENCIMIENTO.ToString("dd/MM/yyyy HH:mm:ss") + "' ";
			}

			if (valueObject.FECHA_ENTRAMITE > DateTime.MinValue) {
				if (first) { first = false; }
				sql += "AND FECHA_ENTRAMITE= '" + valueObject.FECHA_ENTRAMITE.ToString("dd/MM/yyyy HH:mm:ss") + "' ";
			}

			if (valueObject.FECHA_ANULADO > DateTime.MinValue) {
				if (first) { first = false; }
				sql += "AND FECHA_ANULADO= '" + valueObject.FECHA_ANULADO.ToString("dd/MM/yyyy HH:mm:ss") + "' ";
			}

			if (valueObject.FECHA_PAGOANULADO > DateTime.MinValue) {
				if (first) { first = false; }
				sql += "AND FECHA_PAGOANULADO= '" + valueObject.FECHA_PAGOANULADO.ToString("dd/MM/yyyy HH:mm:ss") + "' ";
			}

			if (valueObject.FECHA_PROCESADO > DateTime.MinValue) {
				if (first) { first = false; }
				sql += "AND FECHA_PROCESADO= '" + valueObject.FECHA_PROCESADO.ToString("dd/MM/yyyy HH:mm:ss") + "' ";
			}

			sql += "ORDER BY id ASC ";

			if (first)
				searchResults = new List<RECIBO>();
			else
				searchResults = listQuery(new SqlCommand(sql,conn));

			return searchResults;
		}


		private int databaseUpdate(SqlCommand stmt) {
			int result = stmt.ExecuteNonQuery();
			return result;
		}


		private List<RECIBO> listQuery(SqlCommand stmt) 
		{

			List<RECIBO> searchResults = new List<RECIBO>();
			SqlDataReader reader = null;
			try 
			{
				int intt = 0; long longg = 0; double doublee = 0; float floatt = 0; DateTime datee; byte[] bytee;
				reader = stmt.ExecuteReader();
				while (reader.Read()) {
					RECIBO temp = createValueObject();

					temp.ID= reader["ID"] != null && int.TryParse(reader["ID"].ToString(),out intt) ? intt : 0;
					temp.ID_LIQUIDACION= reader["ID_LIQUIDACION"] != null && int.TryParse(reader["ID_LIQUIDACION"].ToString(),out intt) ? intt : 0;
					temp.ID_ESTADO= reader["ID_ESTADO"] != null && int.TryParse(reader["ID_ESTADO"].ToString(),out intt) ? intt : 0;
					temp.NUMERO_RECIBO= reader["NUMERO_RECIBO"] != null ? reader["NUMERO_RECIBO"].ToString() : null;
					temp.FECHA_RECIBO= reader["FECHA_RECIBO"] != null && !String.IsNullOrEmpty(reader["FECHA_RECIBO"].ToString()) ? (DateTime)reader["FECHA_RECIBO"] : DateTime.MinValue;
					temp.FECHA_REGISTRO_PAGO= reader["FECHA_REGISTRO_PAGO"] != null && !String.IsNullOrEmpty(reader["FECHA_REGISTRO_PAGO"].ToString()) ? (DateTime)reader["FECHA_REGISTRO_PAGO"] : DateTime.MinValue;
					temp.FECHA_PAGO= reader["FECHA_PAGO"] != null && !String.IsNullOrEmpty(reader["FECHA_PAGO"].ToString()) ? (DateTime)reader["FECHA_PAGO"] : DateTime.MinValue;
					temp.VALOR= reader["VALOR"] != null && float.TryParse(reader["VALOR"].ToString(),out floatt) ? floatt : 0;
					temp.FECHA_VENCIMIENTO= reader["FECHA_VENCIMIENTO"] != null && !String.IsNullOrEmpty(reader["FECHA_VENCIMIENTO"].ToString()) ? (DateTime)reader["FECHA_VENCIMIENTO"] : DateTime.MinValue;
					temp.FECHA_ENTRAMITE= reader["FECHA_ENTRAMITE"] != null && !String.IsNullOrEmpty(reader["FECHA_ENTRAMITE"].ToString()) ? (DateTime)reader["FECHA_ENTRAMITE"] : DateTime.MinValue;
					temp.FECHA_ANULADO= reader["FECHA_ANULADO"] != null && !String.IsNullOrEmpty(reader["FECHA_ANULADO"].ToString()) ? (DateTime)reader["FECHA_ANULADO"] : DateTime.MinValue;
					temp.FECHA_PAGOANULADO= reader["FECHA_PAGOANULADO"] != null && !String.IsNullOrEmpty(reader["FECHA_PAGOANULADO"].ToString()) ? (DateTime)reader["FECHA_PAGOANULADO"] : DateTime.MinValue;
					temp.FECHA_PROCESADO= reader["FECHA_PROCESADO"] != null && !String.IsNullOrEmpty(reader["FECHA_PROCESADO"].ToString()) ? (DateTime)reader["FECHA_PROCESADO"] : DateTime.MinValue;
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
