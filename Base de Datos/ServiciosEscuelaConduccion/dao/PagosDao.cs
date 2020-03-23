using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Data.SqlClient;

using ServiciosEscuelaConduccion.objetos;

namespace ServiciosEscuelaConduccion.dao{

partial class PagosDao {


	public Pagos createValueObject() {
		return new Pagos();
	}

	public List<Pagos> loadAll(SqlConnection conn) {
		String sql = "SELECT * FROM PAGOS ORDER BY ID ASC ";
		List<Pagos> searchResults = listQuery(new SqlCommand(sql, conn));
		return searchResults;
	}


	public List<Pagos> loadAll(SqlConnection conn, int limiteInf, int limiteSup) {
		String sql = "SELECT * FROM (SELECT *, ROW_NUMBER() OVER (ORDER BY ID) AS RowNumber FROM PAGOS) AS CONSULTA WHERE RowNumber >="+ limiteInf +" AND RowNumber <="+ limiteSup;
		List<Pagos> searchResults = listQuery(new SqlCommand(sql, conn));
		return searchResults;
	}


	public void create(SqlConnection conn, Pagos valueObject) {
		String sql = "";
		SqlCommand stmt = null;
		try {
			sql = "INSERT INTO PAGOS ( ID,"+
			" ID_RECIBO, ID_FORMAPAGO, VALOR,"+
			" FECHA_PAGO)"+
			 "VALUES ( @ID, @ID_RECIBO, @ID_FORMAPAGO, @VALOR, @FECHA_PAGO)";
			stmt = new SqlCommand(sql, conn);
			stmt.Parameters.AddWithValue("@ID", valueObject.ID);
				if(valueObject.ID_RECIBO!=0)
					stmt.Parameters.AddWithValue("@ID_RECIBO", valueObject.ID_RECIBO);
				else
					stmt.Parameters.AddWithValue("@ID_RECIBO", DBNull.Value);
				if(valueObject.ID_FORMAPAGO!=0)
					stmt.Parameters.AddWithValue("@ID_FORMAPAGO", valueObject.ID_FORMAPAGO);
				else
					stmt.Parameters.AddWithValue("@ID_FORMAPAGO", DBNull.Value);
				if(valueObject.VALOR!=0)
					stmt.Parameters.AddWithValue("@VALOR", valueObject.VALOR);
				else
					stmt.Parameters.AddWithValue("@VALOR", DBNull.Value);
				if(valueObject.FECHA_PAGO != DateTime.MinValue)
					stmt.Parameters.AddWithValue("@FECHA_PAGO", valueObject.FECHA_PAGO);
				else
					stmt.Parameters.AddWithValue("@FECHA_PAGO", DBNull.Value);



				databaseUpdate(stmt);
			} finally {
				if (stmt != null)
					stmt.Dispose();
			}
	}


	public void save(SqlConnection conn, Pagos valueObject) {
		SqlCommand stmt = null;
		String sql = "";
		try {
			sql = "UPDATE PAGOS SET  ID_RECIBO = @ID_RECIBO , ID_FORMAPAGO = @ID_FORMAPAGO , VALOR = @VALOR ,"+
			" FECHA_PAGO = @FECHA_PAGO  WHERE (ID= @ID)";
			stmt = new SqlCommand(sql, conn);
				if(valueObject.ID_RECIBO!=0)
					stmt.Parameters.AddWithValue("@ID_RECIBO", valueObject.ID_RECIBO);
				else
					stmt.Parameters.AddWithValue("@ID_RECIBO", DBNull.Value);
				if(valueObject.ID_FORMAPAGO!=0)
					stmt.Parameters.AddWithValue("@ID_FORMAPAGO", valueObject.ID_FORMAPAGO);
				else
					stmt.Parameters.AddWithValue("@ID_FORMAPAGO", DBNull.Value);
				if(valueObject.VALOR!=0)
					stmt.Parameters.AddWithValue("@VALOR", valueObject.VALOR);
				else
					stmt.Parameters.AddWithValue("@VALOR", DBNull.Value);
				if(valueObject.FECHA_PAGO != DateTime.MinValue)
					stmt.Parameters.AddWithValue("@FECHA_PAGO", valueObject.FECHA_PAGO);
				else
					stmt.Parameters.AddWithValue("@FECHA_PAGO", DBNull.Value);
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


	public void delete(SqlConnection conn, Pagos valueObject) {
		SqlCommand stmt = null;
		String sql = "";
		try {
			sql = "DELETE FROM PAGOS WHERE (ID = @ID )";
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
		String sql = "SELECT count(*) FROM PAGOS";
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
	public List<Pagos> searchMatching(SqlConnection conn, Pagos valueObject) {
		List<Pagos> searchResults = new List<Pagos>();
		bool first = true;
		String sql = "SELECT * FROM PAGOS WHERE 1=1 ";
		if (valueObject.ID != null && valueObject.ID != 0) {
			if (first) { first = false; }
			sql += "AND ID= " + valueObject.ID + " ";
		}

		if (valueObject.ID_RECIBO != null && valueObject.ID_RECIBO != 0) {
			if (first) { first = false; }
			sql += "AND ID_RECIBO= " + valueObject.ID_RECIBO + " ";
		}

		if (valueObject.ID_FORMAPAGO != null && valueObject.ID_FORMAPAGO != 0) {
			if (first) { first = false; }
			sql += "AND ID_FORMAPAGO= " + valueObject.ID_FORMAPAGO + " ";
		}

		if (valueObject.VALOR != null && valueObject.VALOR != 0) {
			if (first) { first = false; }
			sql += "AND VALOR= " + valueObject.VALOR + " ";
		}

		if (valueObject.FECHA_PAGO != DateTime.MinValue) {
			if (first) { first = false; }
			sql += "AND FECHA_PAGO= '" + valueObject.FECHA_PAGO.ToString("dd/MM/yyyy HH:mm:ss") + "' ";
		}

		sql += "ORDER BY ID ASC ";

		if (first)
			searchResults = new List<Pagos>();
		else
			searchResults = listQuery(new SqlCommand(sql,conn));

		return searchResults;
	}


	public List<Pagos> searchMatching(SqlConnection conn, Pagos valueObject, int limiteInf, int limiteSup) {
		List<Pagos> searchResults = new List<Pagos>();
		bool first = true;
		String sql = "SELECT * FROM PAGOS WHERE 1=1 ";
		if (valueObject.ID != null && valueObject.ID != 0) {
			if (first) { first = false; }
			sql += "AND ID= " + valueObject.ID + " ";
		}

		if (valueObject.ID_RECIBO != null && valueObject.ID_RECIBO != 0) {
			if (first) { first = false; }
			sql += "AND ID_RECIBO= " + valueObject.ID_RECIBO + " ";
		}

		if (valueObject.ID_FORMAPAGO != null && valueObject.ID_FORMAPAGO != 0) {
			if (first) { first = false; }
			sql += "AND ID_FORMAPAGO= " + valueObject.ID_FORMAPAGO + " ";
		}

		if (valueObject.VALOR != null && valueObject.VALOR != 0) {
			if (first) { first = false; }
			sql += "AND VALOR= " + valueObject.VALOR + " ";
		}

		if (valueObject.FECHA_PAGO != DateTime.MinValue) {
			if (first) { first = false; }
			sql += "AND FECHA_PAGO= '" + valueObject.FECHA_PAGO.ToString("dd/MM/yyyy HH:mm:ss") + "' ";
		}

		sql += ") AS CONSULTA WHERE RowNumber >="+ limiteInf +" AND RowNumber <="+ limiteSup;

		if (first)
			searchResults = new List<Pagos>();
		else
			searchResults = listQuery(new SqlCommand(sql,conn));

		return searchResults;
	}


	public int countSearchMatching(SqlConnection conn, Pagos valueObject) {
		bool first = true;
		String sql = "SELECT COUNT(*) FROM PAGOS WHERE 1=1 ";
		if (valueObject.ID != null && valueObject.ID != 0) {
			if (first) { first = false; }
			sql += "AND ID= " + valueObject.ID + " ";
		}

		if (valueObject.ID_RECIBO != null && valueObject.ID_RECIBO != 0) {
			if (first) { first = false; }
			sql += "AND ID_RECIBO= " + valueObject.ID_RECIBO + " ";
		}

		if (valueObject.ID_FORMAPAGO != null && valueObject.ID_FORMAPAGO != 0) {
			if (first) { first = false; }
			sql += "AND ID_FORMAPAGO= " + valueObject.ID_FORMAPAGO + " ";
		}

		if (valueObject.VALOR != null && valueObject.VALOR != 0) {
			if (first) { first = false; }
			sql += "AND VALOR= " + valueObject.VALOR + " ";
		}

		if (valueObject.FECHA_PAGO != DateTime.MinValue) {
			if (first) { first = false; }
			sql += "AND FECHA_PAGO= '" + valueObject.FECHA_PAGO.ToString("dd/MM/yyyy HH:mm:ss") + "' ";
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


	private List<Pagos> listQuery(SqlCommand stmt) {

		List<Pagos> searchResults = new List<Pagos>();
		SqlDataReader reader = null;
		try {
		int intt = 0; long longg = 0; double doublee = 0;DateTime datee;
			reader = stmt.ExecuteReader();
			while (reader.Read()) {
				Pagos temp = createValueObject();

				temp.ID= reader["ID"] != null && int.TryParse(reader["ID"].ToString(),out intt) ? intt : 0;
				temp.ID_RECIBO= reader["ID_RECIBO"] != null && int.TryParse(reader["ID_RECIBO"].ToString(),out intt) ? intt : 0;
				temp.ID_FORMAPAGO= reader["ID_FORMAPAGO"] != null && int.TryParse(reader["ID_FORMAPAGO"].ToString(),out intt) ? intt : 0;
				temp.VALOR= reader["VALOR"] != null && double.TryParse(reader["VALOR"].ToString(),out doublee) ? doublee : 0;
				temp.FECHA_PAGO=  reader["FECHA_PAGO"] != null && !String.IsNullOrEmpty(reader["FECHA_PAGO"].ToString()) ? (DateTime)reader["FECHA_PAGO"] : DateTime.MinValue;
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
