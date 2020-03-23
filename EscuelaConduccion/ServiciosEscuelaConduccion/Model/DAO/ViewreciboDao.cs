using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Data.SqlClient;

using ServiciosEscuelaConduccion.objetos;

namespace ServiciosEscuelaConduccion.dao{

partial class ViewreciboDao {


	public Viewrecibo createValueObject() {
		return new Viewrecibo();
	}

	public List<Viewrecibo> loadAll(SqlConnection conn) {
		String sql = "SELECT * FROM VIEW_RECIBO ORDER BY ID ASC ";
		List<Viewrecibo> searchResults = listQuery(new SqlCommand(sql, conn));
		return searchResults;
	}


	public List<Viewrecibo> loadAll(SqlConnection conn, int limiteInf, int limiteSup) {
		String sql = "SELECT * FROM (SELECT *, ROW_NUMBER() OVER (ORDER BY ID) AS RowNumber FROM VIEW_RECIBO) AS CONSULTA WHERE RowNumber >="+ limiteInf +" AND RowNumber <="+ limiteSup;
		List<Viewrecibo> searchResults = listQuery(new SqlCommand(sql, conn));
		return searchResults;
	}


	public void create(SqlConnection conn, Viewrecibo valueObject) {
		String sql = "";
		SqlCommand stmt = null;
		try {
			sql = "INSERT INTO VIEW_RECIBO ( ID,"+
			" NUMERO_RECIBO, VALOR, ID_CLIENTE,"+
			" NOMBRES, APELLIDOS, ID_ESTADO,"+
			" ESTADO, ID_TIPO_LIQUIDACION, TIPO_PAGO"+
			")"+
			 "VALUES ( @ID, @NUMERO_RECIBO, @VALOR, @ID_CLIENTE, @NOMBRES, @APELLIDOS, @ID_ESTADO, @ESTADO, @ID_TIPO_LIQUIDACION, @TIPO_PAGO)";
			stmt = new SqlCommand(sql, conn);
			stmt.Parameters.AddWithValue("@ID", valueObject.ID);
				if(valueObject.NUMERO_RECIBO!=null &&valueObject.NUMERO_RECIBO.Length <= 0)
					stmt.Parameters.AddWithValue("@NUMERO_RECIBO", valueObject.NUMERO_RECIBO);
				else
					stmt.Parameters.AddWithValue("@NUMERO_RECIBO", DBNull.Value);
				if(valueObject.VALOR!=0)
					stmt.Parameters.AddWithValue("@VALOR", valueObject.VALOR);
				else
					stmt.Parameters.AddWithValue("@VALOR", DBNull.Value);
				if(valueObject.ID_CLIENTE!=0)
					stmt.Parameters.AddWithValue("@ID_CLIENTE", valueObject.ID_CLIENTE);
				else
					stmt.Parameters.AddWithValue("@ID_CLIENTE", DBNull.Value);
				if(valueObject.NOMBRES!=null &&valueObject.NOMBRES.Length <= 0)
					stmt.Parameters.AddWithValue("@NOMBRES", valueObject.NOMBRES);
				else
					stmt.Parameters.AddWithValue("@NOMBRES", DBNull.Value);
				if(valueObject.APELLIDOS!=null &&valueObject.APELLIDOS.Length <= 0)
					stmt.Parameters.AddWithValue("@APELLIDOS", valueObject.APELLIDOS);
				else
					stmt.Parameters.AddWithValue("@APELLIDOS", DBNull.Value);
				if(valueObject.ID_ESTADO!=0)
					stmt.Parameters.AddWithValue("@ID_ESTADO", valueObject.ID_ESTADO);
				else
					stmt.Parameters.AddWithValue("@ID_ESTADO", DBNull.Value);
				if(valueObject.ESTADO!=null &&valueObject.ESTADO.Length <= 0)
					stmt.Parameters.AddWithValue("@ESTADO", valueObject.ESTADO);
				else
					stmt.Parameters.AddWithValue("@ESTADO", DBNull.Value);
				if(valueObject.ID_TIPO_LIQUIDACION!=0)
					stmt.Parameters.AddWithValue("@ID_TIPO_LIQUIDACION", valueObject.ID_TIPO_LIQUIDACION);
				else
					stmt.Parameters.AddWithValue("@ID_TIPO_LIQUIDACION", DBNull.Value);
				if(valueObject.TIPO_PAGO!=null &&valueObject.TIPO_PAGO.Length <= 0)
					stmt.Parameters.AddWithValue("@TIPO_PAGO", valueObject.TIPO_PAGO);
				else
					stmt.Parameters.AddWithValue("@TIPO_PAGO", DBNull.Value);



				databaseUpdate(stmt);
			} finally {
				if (stmt != null)
					stmt.Dispose();
			}
	}


	public void save(SqlConnection conn, Viewrecibo valueObject) {
		SqlCommand stmt = null;
		String sql = "";
		try {
			sql = "UPDATE VIEW_RECIBO SET  NUMERO_RECIBO = @NUMERO_RECIBO , VALOR = @VALOR , ID_CLIENTE = @ID_CLIENTE ,"+
			" NOMBRES = @NOMBRES , APELLIDOS = @APELLIDOS , ID_ESTADO = @ID_ESTADO ,"+
			" ESTADO = @ESTADO , ID_TIPO_LIQUIDACION = @ID_TIPO_LIQUIDACION , TIPO_PAGO = @TIPO_PAGO "+
			" WHERE (ID= @ID)";
			stmt = new SqlCommand(sql, conn);
				if(valueObject.NUMERO_RECIBO!=null &&valueObject.NUMERO_RECIBO.Length <= 0)
					stmt.Parameters.AddWithValue("@NUMERO_RECIBO", valueObject.NUMERO_RECIBO);
				else
					stmt.Parameters.AddWithValue("@NUMERO_RECIBO", DBNull.Value);
				if(valueObject.VALOR!=0)
					stmt.Parameters.AddWithValue("@VALOR", valueObject.VALOR);
				else
					stmt.Parameters.AddWithValue("@VALOR", DBNull.Value);
				if(valueObject.ID_CLIENTE!=0)
					stmt.Parameters.AddWithValue("@ID_CLIENTE", valueObject.ID_CLIENTE);
				else
					stmt.Parameters.AddWithValue("@ID_CLIENTE", DBNull.Value);
				if(valueObject.NOMBRES!=null &&valueObject.NOMBRES.Length <= 0)
					stmt.Parameters.AddWithValue("@NOMBRES", valueObject.NOMBRES);
				else
					stmt.Parameters.AddWithValue("@NOMBRES", DBNull.Value);
				if(valueObject.APELLIDOS!=null &&valueObject.APELLIDOS.Length <= 0)
					stmt.Parameters.AddWithValue("@APELLIDOS", valueObject.APELLIDOS);
				else
					stmt.Parameters.AddWithValue("@APELLIDOS", DBNull.Value);
				if(valueObject.ID_ESTADO!=0)
					stmt.Parameters.AddWithValue("@ID_ESTADO", valueObject.ID_ESTADO);
				else
					stmt.Parameters.AddWithValue("@ID_ESTADO", DBNull.Value);
				if(valueObject.ESTADO!=null &&valueObject.ESTADO.Length <= 0)
					stmt.Parameters.AddWithValue("@ESTADO", valueObject.ESTADO);
				else
					stmt.Parameters.AddWithValue("@ESTADO", DBNull.Value);
				if(valueObject.ID_TIPO_LIQUIDACION!=0)
					stmt.Parameters.AddWithValue("@ID_TIPO_LIQUIDACION", valueObject.ID_TIPO_LIQUIDACION);
				else
					stmt.Parameters.AddWithValue("@ID_TIPO_LIQUIDACION", DBNull.Value);
				if(valueObject.TIPO_PAGO!=null &&valueObject.TIPO_PAGO.Length <= 0)
					stmt.Parameters.AddWithValue("@TIPO_PAGO", valueObject.TIPO_PAGO);
				else
					stmt.Parameters.AddWithValue("@TIPO_PAGO", DBNull.Value);
				stmt.Parameters.AddWithValue("@ID", valueObject.ID);

				int rowcount = databaseUpdate(stmt);
				if (rowcount == 0) {
					throw new Exception("Object could not be saved! (PrimaryKey not found)");
				}
			} finally {
				if (stmt != null)
					stmt.Dispose();
		}
	}


	public void delete(SqlConnection conn, Viewrecibo valueObject) {
		SqlCommand stmt = null;
		String sql = "";
		try {
			sql = "DELETE FROM VIEW_RECIBO WHERE (ID = @ID )";
			stmt = new SqlCommand(sql, conn);
			stmt.Parameters.AddWithValue("@ID", valueObject.ID);

			int rowcount = databaseUpdate(stmt);
			if (rowcount == 0) {
				throw new Exception("Object could not be deleted! (PrimaryKey not found)");
			}
			if (rowcount > 1) {
				throw new Exception("PrimaryKey Error when updating DB! (Many objects were deleted!)");
			}
		} finally {
				if (stmt != null)
					stmt.Dispose();
			}
	}


	public int countAll(SqlConnection conn) {
		String sql = "SELECT count(*) FROM VIEW_RECIBO";
		SqlCommand stmt = null;
		SqlDataReader result = null;
		int allRows = 0;
		try {
			stmt = new SqlCommand(sql, conn);
			result = stmt.ExecuteReader();
			if (result.Read())
				allRows = int.Parse(result[0].ToString());
		} finally {
			if(!result.IsClosed)
				result.Close();
			if (stmt != null)
				stmt.Dispose();
		}
		return allRows;
	}
	public List<Viewrecibo> searchMatching(SqlConnection conn, Viewrecibo valueObject) {
		List<Viewrecibo> searchResults = new List<Viewrecibo>();
		bool first = true;
		String sql = "SELECT * FROM VIEW_RECIBO WHERE 1=1 ";
		if (valueObject.ID != null && valueObject.ID != 0) {
			if (first) { first = false; }
			sql += "AND ID= " + valueObject.ID + " ";
		}

		if (!String.IsNullOrEmpty(valueObject.NUMERO_RECIBO)) {
			if (first) { first = false; }
			sql += "AND NUMERO_RECIBO= '" + valueObject.NUMERO_RECIBO + "' ";
		}

		if (valueObject.VALOR != null && valueObject.VALOR != 0) {
			if (first) { first = false; }
			sql += "AND VALOR= " + valueObject.VALOR + " ";
		}

		if (valueObject.ID_CLIENTE != null && valueObject.ID_CLIENTE != 0) {
			if (first) { first = false; }
			sql += "AND ID_CLIENTE= " + valueObject.ID_CLIENTE + " ";
		}

		if (!String.IsNullOrEmpty(valueObject.NOMBRES)) {
			if (first) { first = false; }
			sql += "AND NOMBRES= '" + valueObject.NOMBRES + "' ";
		}

		if (!String.IsNullOrEmpty(valueObject.APELLIDOS)) {
			if (first) { first = false; }
			sql += "AND APELLIDOS= '" + valueObject.APELLIDOS + "' ";
		}

		if (valueObject.ID_ESTADO != null && valueObject.ID_ESTADO != 0) {
			if (first) { first = false; }
			sql += "AND ID_ESTADO= " + valueObject.ID_ESTADO + " ";
		}

		if (!String.IsNullOrEmpty(valueObject.ESTADO)) {
			if (first) { first = false; }
			sql += "AND ESTADO= '" + valueObject.ESTADO + "' ";
		}

		if (valueObject.ID_TIPO_LIQUIDACION != null && valueObject.ID_TIPO_LIQUIDACION != 0) {
			if (first) { first = false; }
			sql += "AND ID_TIPO_LIQUIDACION= " + valueObject.ID_TIPO_LIQUIDACION + " ";
		}

		if (!String.IsNullOrEmpty(valueObject.TIPO_PAGO)) {
			if (first) { first = false; }
			sql += "AND TIPO_PAGO= '" + valueObject.TIPO_PAGO + "' ";
		}

		sql += "ORDER BY ID ASC ";

		if (first)
			searchResults = new List<Viewrecibo>();
		else
			searchResults = listQuery(new SqlCommand(sql,conn));

		return searchResults;
	}


	public List<Viewrecibo> searchMatching(SqlConnection conn, Viewrecibo valueObject, int limiteInf, int limiteSup) {
		List<Viewrecibo> searchResults = new List<Viewrecibo>();
		bool first = true;
		String sql = "SELECT * FROM VIEW_RECIBO WHERE 1=1 ";
		if (valueObject.ID != null && valueObject.ID != 0) {
			if (first) { first = false; }
			sql += "AND ID= " + valueObject.ID + " ";
		}

		if (!String.IsNullOrEmpty(valueObject.NUMERO_RECIBO)) {
			if (first) { first = false; }
			sql += "AND NUMERO_RECIBO= '" + valueObject.NUMERO_RECIBO + "' ";
		}

		if (valueObject.VALOR != null && valueObject.VALOR != 0) {
			if (first) { first = false; }
			sql += "AND VALOR= " + valueObject.VALOR + " ";
		}

		if (valueObject.ID_CLIENTE != null && valueObject.ID_CLIENTE != 0) {
			if (first) { first = false; }
			sql += "AND ID_CLIENTE= " + valueObject.ID_CLIENTE + " ";
		}

		if (!String.IsNullOrEmpty(valueObject.NOMBRES)) {
			if (first) { first = false; }
			sql += "AND NOMBRES= '" + valueObject.NOMBRES + "' ";
		}

		if (!String.IsNullOrEmpty(valueObject.APELLIDOS)) {
			if (first) { first = false; }
			sql += "AND APELLIDOS= '" + valueObject.APELLIDOS + "' ";
		}

		if (valueObject.ID_ESTADO != null && valueObject.ID_ESTADO != 0) {
			if (first) { first = false; }
			sql += "AND ID_ESTADO= " + valueObject.ID_ESTADO + " ";
		}

		if (!String.IsNullOrEmpty(valueObject.ESTADO)) {
			if (first) { first = false; }
			sql += "AND ESTADO= '" + valueObject.ESTADO + "' ";
		}

		if (valueObject.ID_TIPO_LIQUIDACION != null && valueObject.ID_TIPO_LIQUIDACION != 0) {
			if (first) { first = false; }
			sql += "AND ID_TIPO_LIQUIDACION= " + valueObject.ID_TIPO_LIQUIDACION + " ";
		}

		if (!String.IsNullOrEmpty(valueObject.TIPO_PAGO)) {
			if (first) { first = false; }
			sql += "AND TIPO_PAGO= '" + valueObject.TIPO_PAGO + "' ";
		}

		sql += ") AS CONSULTA WHERE RowNumber >="+ limiteInf +" AND RowNumber <="+ limiteSup;

		if (first)
			searchResults = new List<Viewrecibo>();
		else
			searchResults = listQuery(new SqlCommand(sql,conn));

		return searchResults;
	}


	public int countSearchMatching(SqlConnection conn, Viewrecibo valueObject) {
		bool first = true;
		String sql = "SELECT COUNT(*) FROM VIEW_RECIBO WHERE 1=1 ";
		if (valueObject.ID != null && valueObject.ID != 0) {
			if (first) { first = false; }
			sql += "AND ID= " + valueObject.ID + " ";
		}

		if (!String.IsNullOrEmpty(valueObject.NUMERO_RECIBO)) {
			if (first) { first = false; }
			sql += "AND NUMERO_RECIBO= '" + valueObject.NUMERO_RECIBO + "' ";
		}

		if (valueObject.VALOR != null && valueObject.VALOR != 0) {
			if (first) { first = false; }
			sql += "AND VALOR= " + valueObject.VALOR + " ";
		}

		if (valueObject.ID_CLIENTE != null && valueObject.ID_CLIENTE != 0) {
			if (first) { first = false; }
			sql += "AND ID_CLIENTE= " + valueObject.ID_CLIENTE + " ";
		}

		if (!String.IsNullOrEmpty(valueObject.NOMBRES)) {
			if (first) { first = false; }
			sql += "AND NOMBRES= '" + valueObject.NOMBRES + "' ";
		}

		if (!String.IsNullOrEmpty(valueObject.APELLIDOS)) {
			if (first) { first = false; }
			sql += "AND APELLIDOS= '" + valueObject.APELLIDOS + "' ";
		}

		if (valueObject.ID_ESTADO != null && valueObject.ID_ESTADO != 0) {
			if (first) { first = false; }
			sql += "AND ID_ESTADO= " + valueObject.ID_ESTADO + " ";
		}

		if (!String.IsNullOrEmpty(valueObject.ESTADO)) {
			if (first) { first = false; }
			sql += "AND ESTADO= '" + valueObject.ESTADO + "' ";
		}

		if (valueObject.ID_TIPO_LIQUIDACION != null && valueObject.ID_TIPO_LIQUIDACION != 0) {
			if (first) { first = false; }
			sql += "AND ID_TIPO_LIQUIDACION= " + valueObject.ID_TIPO_LIQUIDACION + " ";
		}

		if (!String.IsNullOrEmpty(valueObject.TIPO_PAGO)) {
			if (first) { first = false; }
			sql += "AND TIPO_PAGO= '" + valueObject.TIPO_PAGO + "' ";
		}

		SqlCommand stmt = null;
		SqlDataReader result = null;
		int allRows = 0;
		try {
			stmt = new SqlCommand(sql,conn);
			result = stmt.ExecuteReader();
			if (result.Read())
				allRows = int.Parse(result[0].ToString());
		} finally {
			if (!result.IsClosed)
				result.Close();
			if (stmt != null)
				stmt.Dispose();
		}
		return allRows;
	}


	private int databaseUpdate(SqlCommand stmt) {
		int result = stmt.ExecuteNonQuery();
		return result;
	}


	private List<Viewrecibo> listQuery(SqlCommand stmt) {

		List<Viewrecibo> searchResults = new List<Viewrecibo>();
		SqlDataReader reader = null;
		try {
		int intt = 0; long longg = 0; double doublee = 0;DateTime datee;
			reader = stmt.ExecuteReader();
			while (reader.Read()) {
				Viewrecibo temp = createValueObject();

				temp.ID= reader["ID"] != null && int.TryParse(reader["ID"].ToString(),out intt) ? intt : 0;
				temp.NUMERO_RECIBO= reader["NUMERO_RECIBO"] != null ? reader["NUMERO_RECIBO"].ToString() : null;
				temp.VALOR= reader["VALOR"] != null && double.TryParse(reader["VALOR"].ToString(),out doublee) ? doublee : 0;
				temp.ID_CLIENTE= reader["ID_CLIENTE"] != null && int.TryParse(reader["ID_CLIENTE"].ToString(),out intt) ? intt : 0;
				temp.NOMBRES= reader["NOMBRES"] != null ? reader["NOMBRES"].ToString() : null;
				temp.APELLIDOS= reader["APELLIDOS"] != null ? reader["APELLIDOS"].ToString() : null;
				temp.ID_ESTADO= reader["ID_ESTADO"] != null && int.TryParse(reader["ID_ESTADO"].ToString(),out intt) ? intt : 0;
				temp.ESTADO= reader["ESTADO"] != null ? reader["ESTADO"].ToString() : null;
				temp.ID_TIPO_LIQUIDACION= reader["ID_TIPO_LIQUIDACION"] != null && int.TryParse(reader["ID_TIPO_LIQUIDACION"].ToString(),out intt) ? intt : 0;
				temp.TIPO_PAGO= reader["TIPO_PAGO"] != null ? reader["TIPO_PAGO"].ToString() : null;
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
