using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Data.SqlClient;

using ServiciosEscuelaConduccion.objetos;

namespace ServiciosEscuelaConduccion.dao{

partial class FacturaconsecutivodetalleDao {


	public Facturaconsecutivodetalle createValueObject() {
		return new Facturaconsecutivodetalle();
	}

	public List<Facturaconsecutivodetalle> loadAll(SqlConnection conn) {
		String sql = "SELECT * FROM FACTURA_CONSECUTIVO_DETALLE ORDER BY ID ASC ";
		List<Facturaconsecutivodetalle> searchResults = listQuery(new SqlCommand(sql, conn));
		return searchResults;
	}


	public List<Facturaconsecutivodetalle> loadAll(SqlConnection conn, int limiteInf, int limiteSup) {
		String sql = "SELECT * FROM (SELECT *, ROW_NUMBER() OVER (ORDER BY ID) AS RowNumber FROM FACTURA_CONSECUTIVO_DETALLE) AS CONSULTA WHERE RowNumber >="+ limiteInf +" AND RowNumber <="+ limiteSup;
		List<Facturaconsecutivodetalle> searchResults = listQuery(new SqlCommand(sql, conn));
		return searchResults;
	}


	public void create(SqlConnection conn, Facturaconsecutivodetalle valueObject) {
		String sql = "";
		SqlCommand stmt = null;
		try {
			sql = "INSERT INTO FACTURA_CONSECUTIVO_DETALLE ("+
			" ID_FACTURACONSECUTIVO, CONSECUTIVO, DISPONIBLE"+
			")"+
			 "VALUES (@ID_FACTURACONSECUTIVO, @CONSECUTIVO, @DISPONIBLE)";
			stmt = new SqlCommand(sql, conn);
				if(valueObject.ID_FACTURACONSECUTIVO!=0)
					stmt.Parameters.AddWithValue("@ID_FACTURACONSECUTIVO", valueObject.ID_FACTURACONSECUTIVO);
				else
					stmt.Parameters.AddWithValue("@ID_FACTURACONSECUTIVO", DBNull.Value);
				if(valueObject.CONSECUTIVO!=0)
					stmt.Parameters.AddWithValue("@CONSECUTIVO", valueObject.CONSECUTIVO);
				else
					stmt.Parameters.AddWithValue("@CONSECUTIVO", DBNull.Value);
				if(!String.IsNullOrEmpty(valueObject.DISPONIBLE) && valueObject.DISPONIBLE.Length <= 2)
					stmt.Parameters.AddWithValue("@DISPONIBLE", valueObject.DISPONIBLE);
				else
					stmt.Parameters.AddWithValue("@DISPONIBLE", DBNull.Value);

				databaseUpdate(stmt);
			} finally {
				if (stmt != null)
					stmt.Dispose();
			}
	}


	public void save(SqlConnection conn, Facturaconsecutivodetalle valueObject) {
		SqlCommand stmt = null;
		String sql = "";
		try {
			sql = "UPDATE FACTURA_CONSECUTIVO_DETALLE SET  ID_FACTURACONSECUTIVO = @ID_FACTURACONSECUTIVO , CONSECUTIVO = @CONSECUTIVO , DISPONIBLE = @DISPONIBLE "+
			" WHERE (ID= @ID)";
			stmt = new SqlCommand(sql, conn);
				if(valueObject.ID_FACTURACONSECUTIVO!=0)
					stmt.Parameters.AddWithValue("@ID_FACTURACONSECUTIVO", valueObject.ID_FACTURACONSECUTIVO);
				else
					stmt.Parameters.AddWithValue("@ID_FACTURACONSECUTIVO", DBNull.Value);
				if(valueObject.CONSECUTIVO!=0)
					stmt.Parameters.AddWithValue("@CONSECUTIVO", valueObject.CONSECUTIVO);
				else
					stmt.Parameters.AddWithValue("@CONSECUTIVO", DBNull.Value);
				if(valueObject.DISPONIBLE!=null &&valueObject.DISPONIBLE.Length <= 2)
					stmt.Parameters.AddWithValue("@DISPONIBLE", valueObject.DISPONIBLE);
				else
					stmt.Parameters.AddWithValue("@DISPONIBLE", DBNull.Value);
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


	public void delete(SqlConnection conn, Facturaconsecutivodetalle valueObject) {
		SqlCommand stmt = null;
		String sql = "";
		try {
			sql = "DELETE FROM FACTURA_CONSECUTIVO_DETALLE WHERE (ID = @ID )";
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
		String sql = "SELECT count(*) FROM FACTURA_CONSECUTIVO_DETALLE";
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
	public List<Facturaconsecutivodetalle> searchMatching(SqlConnection conn, Facturaconsecutivodetalle valueObject) {
		List<Facturaconsecutivodetalle> searchResults = new List<Facturaconsecutivodetalle>();
		bool first = true;
		String sql = "SELECT * FROM FACTURA_CONSECUTIVO_DETALLE WHERE 1=1 ";
		if (valueObject.ID != null && valueObject.ID != 0) {
			if (first) { first = false; }
			sql += "AND ID= " + valueObject.ID + " ";
		}

		if (valueObject.ID_FACTURACONSECUTIVO != null && valueObject.ID_FACTURACONSECUTIVO != 0) {
			if (first) { first = false; }
			sql += "AND ID_FACTURACONSECUTIVO= " + valueObject.ID_FACTURACONSECUTIVO + " ";
		}

		if (valueObject.CONSECUTIVO != null && valueObject.CONSECUTIVO != 0) {
			if (first) { first = false; }
			sql += "AND CONSECUTIVO= " + valueObject.CONSECUTIVO + " ";
		}

		if (!String.IsNullOrEmpty(valueObject.DISPONIBLE)) {
			if (first) { first = false; }
			sql += "AND DISPONIBLE= '" + valueObject.DISPONIBLE + "' ";
		}

		sql += "ORDER BY ID ASC ";

		if (first)
			searchResults = new List<Facturaconsecutivodetalle>();
		else
			searchResults = listQuery(new SqlCommand(sql,conn));

		return searchResults;
	}


	public List<Facturaconsecutivodetalle> searchMatching(SqlConnection conn, Facturaconsecutivodetalle valueObject, int limiteInf, int limiteSup) {
		List<Facturaconsecutivodetalle> searchResults = new List<Facturaconsecutivodetalle>();
		bool first = true;
		String sql = "SELECT * FROM FACTURA_CONSECUTIVO_DETALLE WHERE 1=1 ";
		if (valueObject.ID != null && valueObject.ID != 0) {
			if (first) { first = false; }
			sql += "AND ID= " + valueObject.ID + " ";
		}

		if (valueObject.ID_FACTURACONSECUTIVO != null && valueObject.ID_FACTURACONSECUTIVO != 0) {
			if (first) { first = false; }
			sql += "AND ID_FACTURACONSECUTIVO= " + valueObject.ID_FACTURACONSECUTIVO + " ";
		}

		if (valueObject.CONSECUTIVO != null && valueObject.CONSECUTIVO != 0) {
			if (first) { first = false; }
			sql += "AND CONSECUTIVO= " + valueObject.CONSECUTIVO + " ";
		}

		if (!String.IsNullOrEmpty(valueObject.DISPONIBLE)) {
			if (first) { first = false; }
			sql += "AND DISPONIBLE= '" + valueObject.DISPONIBLE + "' ";
		}

		sql += ") AS CONSULTA WHERE RowNumber >="+ limiteInf +" AND RowNumber <="+ limiteSup;

		if (first)
			searchResults = new List<Facturaconsecutivodetalle>();
		else
			searchResults = listQuery(new SqlCommand(sql,conn));

		return searchResults;
	}


	public int countSearchMatching(SqlConnection conn, Facturaconsecutivodetalle valueObject) {
		bool first = true;
		String sql = "SELECT COUNT(*) FROM FACTURA_CONSECUTIVO_DETALLE WHERE 1=1 ";
		if (valueObject.ID != null && valueObject.ID != 0) {
			if (first) { first = false; }
			sql += "AND ID= " + valueObject.ID + " ";
		}

		if (valueObject.ID_FACTURACONSECUTIVO != null && valueObject.ID_FACTURACONSECUTIVO != 0) {
			if (first) { first = false; }
			sql += "AND ID_FACTURACONSECUTIVO= " + valueObject.ID_FACTURACONSECUTIVO + " ";
		}

		if (valueObject.CONSECUTIVO != null && valueObject.CONSECUTIVO != 0) {
			if (first) { first = false; }
			sql += "AND CONSECUTIVO= " + valueObject.CONSECUTIVO + " ";
		}

		if (!String.IsNullOrEmpty(valueObject.DISPONIBLE)) {
			if (first) { first = false; }
			sql += "AND DISPONIBLE= '" + valueObject.DISPONIBLE + "' ";
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


	private List<Facturaconsecutivodetalle> listQuery(SqlCommand stmt) {

		List<Facturaconsecutivodetalle> searchResults = new List<Facturaconsecutivodetalle>();
		SqlDataReader reader = null;
		try {
		int intt = 0; long longg = 0; double doublee = 0;DateTime datee;
			reader = stmt.ExecuteReader();
			while (reader.Read()) {
				Facturaconsecutivodetalle temp = createValueObject();

				temp.ID= reader["ID"] != null && int.TryParse(reader["ID"].ToString(),out intt) ? intt : 0;
				temp.ID_FACTURACONSECUTIVO= reader["ID_FACTURACONSECUTIVO"] != null && int.TryParse(reader["ID_FACTURACONSECUTIVO"].ToString(),out intt) ? intt : 0;
				temp.CONSECUTIVO= reader["CONSECUTIVO"] != null && double.TryParse(reader["CONSECUTIVO"].ToString(),out doublee) ? doublee : 0;
				temp.DISPONIBLE= reader["DISPONIBLE"] != null ? reader["DISPONIBLE"].ToString() : null;
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
