using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;

namespace ServiciosEscuelaConduccion.Utilidades
{
    static public class Funciones
    {
        public static int getId(SqlConnection conn, String nombretabla)
        {
            int result = 0;

            try
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandText = "proGetID";
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();
                comando.Connection = conn;
                comando.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter parametrotabla = new SqlParameter("@TABLA", System.Data.SqlDbType.NChar);
                parametrotabla.Direction = System.Data.ParameterDirection.Input;
                parametrotabla.Value = nombretabla;

                SqlParameter parametrovalor = new SqlParameter("@VALOR", System.Data.SqlDbType.Int);
                parametrovalor.Direction = System.Data.ParameterDirection.Output;

                comando.Parameters.Add(parametrotabla);
                comando.Parameters.Add(parametrovalor);

                comando.ExecuteNonQuery();

                result = int.Parse(parametrovalor.Value.ToString());
            }
            catch (Exception exp)
            {
                result = 0;
            }

            return result;
        }

        public static byte[] Convertir_Imagen_Bytes(Image img)
        {
            string sTemp = Path.GetTempFileName();
            FileStream fs = new FileStream(sTemp, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            img.Save(fs, System.Drawing.Imaging.ImageFormat.Png);
            fs.Position = 0;

            int imgLength = Convert.ToInt32(fs.Length);
            byte[] bytes = new byte[imgLength];
            fs.Read(bytes, 0, imgLength);
            fs.Close();
            return bytes;
        }
    }
}