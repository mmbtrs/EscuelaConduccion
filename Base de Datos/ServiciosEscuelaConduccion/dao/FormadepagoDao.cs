using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Data.SqlClient;

using ServiciosEscuelaConduccion.objetos;

namespace ServiciosEscuelaConduccion.dao{

partial class FormadepagoDao {


	public Formadepago createValueObject() {
		return new Formadepago();
	}

	public List<Formadepago> loadAll(SqlConnection conn) {
		String sql = "SELECT * FROM FORMA_DE_PAGO ORDER BY ID ASC ";
		List<Formadepago> searchResults = listQuery(new SqlCommand(sql, conn));
		return searchResults;
	}


	public List<Formadepago> loadAll(SqlConnection conn, int limiteInf, int limiteSup) {
		String sql = "SELECT * FROM (SELECT *, ROW_NUMBER() OVER (ORDER BY ID) AS RowNumber FROM FORMA_DE_PAGO) AS CONSULTA WHERE RowNumber >="+ limiteInf +" AND RowNumber <="+ limiteSup;
		List<Formadepago> searchResults = listQuery(new SqlCommand(sql, conn));
		return searchResults;
	}


	public void create(SqlConnection conn, Formadepago valueObject) {
		String sql = "";
		SqlCommand stmt = null;
		try {
			sql = "INSERT INTO FORMA_DE_PAGO ( ID,"+
			" FORMA_PAGO)"+
			 "VALUES ( @ID, @FORMA_PAGO)";
			stmt = new SqlCommand(sql, conn);
			stmt.Parameters.AddWithValue("@ID", valueObject.ID);
				if(valueObject.FORMA_PAGO!=null &&valueObject.FORMA_PAGO.Length <= 0)
					stmt.Parameters.AddWithValue("@FORMA_PAGO", valueObject.FORMA_PAGO);
				else
					stmt.Parameters.AddWithValue("@FORMA_PAGO", DBNull.Value);



				databaseUpdate(stmt);
			} finally {
				if (stmt != null)
					stmt.Dispose();
			}
	}


	public void save(SqlConnection conn, Formadepago valueObject) {
		SqlCommand stmt = null;
		String sql = "";
		try {
			sql = "UPDATE FORMA_DE_PAGO SET  FORMA_PAGO = @FORMA_PAGO  WHERE (ID= @ID)";
			stmt = new SqlCommand(sql, conn);
				if(valueObject.FORMA_PAGO!=null &&valueObject.FORMA_PAGO.Length <= 0)
					stmt.Parameters.AddWithValue("@FORMA_PAGO", valueObject.FORMA_PAGO);
				else
					stmt.Parameters.AddWithValue("@FORMA_PAGO", DBNull.Value);
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


	public void delete(SqlConnection conn, Formadepago valueObject) {
		SqlCommand stmt = null;
		String sql = "";
		try {
			sql = "DELETE FROM FORMA_DE_PAGO WHERE (ID = @ID )";
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
		String sql = "SELECT count(*) FROM FORMA_DE_PAGO";
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
	public List<Formadepago> searchMatching(SqlConnection conn, Formadepago valueObject) {
		List<Formadepago> searchResults = new List<Formadepago>();
		bool first = true;
		String sql = "SELECT * FROM FORMA_DE_PAGO WHERE 1=1 ";
		if (valueObject.ID != null && valueObject.ID != 0) {
			if (first) { first = false; }
			sql += "AND ID= " + valueObject.ID + " ";
		}

		if (!String.IsNullOrEmpty(valueObject.FORMA_PAGO)) {
			if (first) { first = false; }
			sql += "AND FORMA_PAGO= '" + valueObject.FORMA_PAGO + "' ";
		}

		sql += "ORDER BY ID ASC ";

		if (first)
			searchResults = new List<Formadepago>();
		else
			searchResults = listQuery(new SqlCommand(sql,conn));

		return searchResults;
	}


	public List<Formadepago> searchMatching(SqlConnection conn, Formadepago valueObject, int limiteInf, int limiteSup) {
		List<Formadepago> searchResults = new List<Formadepago>();
		bool first = true;
		String sql = "SELECT * FROM FORMA_DE_PAGO WHERE 1=1 ";
		if (valueObject.ID != null && valueObject.ID != 0) {
			if (first) { first = false; }
			sql += "AND ID= " + valueObject.ID + " ";
		}

		if (!String.IsNullOrEmpty(valueObject.FORMA_PAGO)) {
			if (first) { first = false; }
			sql += "AND FORMA_PAGO= '" + valueObject.FORMA_PAGO + "' ";
		}

		sql += ") AS CONSULTA WHERE RowNumber >="+ limiteInf +" AND RowNumber <="+ limiteSup;

		if (first)
			searchResults = new List<Formadepago>();
		else
			searchResults = listQuery(new SqlCommand(sql,conn));

		return searchResults;
	}


	public int countSearchMatching(SqlConnection conn, Formadepago valueObject) {
		bool first = true;
		String sql = "SELECT COUNT(*) FROM FORMA_DE_PAGO WHERE 1=1 ";
		if (valueObject.ID != null && valueObject.ID != 0) {
			if (first) { first = false; }
			sql += "AND ID= " + valueObject.ID + " ";
		}

		if (!String.IsNullOrEmpty(valueObject.FORMA_PAGO)) {
			if (first) { first = false; }
			sql += "AND FORMA_PAGO= '" + valueObject.FORMA_PAGO + "' ";
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


	private List<Formadepago> listQuery(SqlCommand stmt) {

		List<Formadepago> searchResults = new List<Formadepago>();
		SqlDataReader reader = null;
		try {
		int intt = 0; long longg = 0; double doublee = 0;DateTime datee;
			reader = stmt.ExecuteReader();
			while (reader.Read()) {
				Formadepago temp = createValueObject();

				temp.ID= reader["ID"] != null && int.TryParse(reader["ID"].ToString(),out intt) ? intt : 0;
				temp.FORMA_PAGO= reader["FORMA_PAGO"] != null ? reader["FORMA_PAGO"].ToString() : null;
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
