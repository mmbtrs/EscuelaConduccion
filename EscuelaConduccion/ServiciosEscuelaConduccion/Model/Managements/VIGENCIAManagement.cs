using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Collections;

using ServiciosEscuelaConduccion.Model.DataAccess;
using ServiciosEscuelaConduccion.Model.DAO;
using ServiciosEscuelaConduccion.Model.Objects;



namespace ServiciosEscuelaConduccion.Model.Managements 
{

	public partial class VIGENCIAManagement
	{
		AccessDB conexion;
		SqlConnection conn;	
	
		public VIGENCIAManagement() 
		{
			crearObjetos();
		}
    
		private void crearObjetos()
		{
			conexion = AccessDB.obtenerInstancia();
		}
	
		/**
		 * Inserta nuevo registro en la tabla
		 * @param VIGENCIA obj
		 * @return Retorna el mismo objeto pero con la llave primaria configurada
		 */
		public VIGENCIA crearVIGENCIA(VIGENCIA obj) 
		{
			List<VIGENCIA> lista = null;
			try 
			{
				VIGENCIADao dao = new VIGENCIADao();
				conn = conexion.conection();
				dao.create(conn, obj);
				//verificar existencia
				lista = dao.search(conn, obj);
				if (lista != null && lista.Count > 0) 
				{
					obj = (VIGENCIA)lista[0];
				}
				else 
				{
					obj.ID = -1;
				}
			} 
			catch (Exception e) 
			{
				obj.ID = -1;
			} finally {
				if(conn!=null && conn.State == System.Data.ConnectionState.Open)
					conn.Close();
			}
			return obj;
		}
	
		/**
		 * Edita un registro en la tabla
		 * @param VIGENCIA obj
		 * @return boolean indicando si se realizo o no la actualizacion
		 */
		public bool editarVIGENCIA(VIGENCIA obj) 
		{
			bool resultado;
			resultado = false;
			try 
			{
				VIGENCIADao dao = new VIGENCIADao();
				conn = conexion.conection();
				dao.save(conn, obj);
				resultado = true;
			} 
			catch (Exception e) 
			{
				resultado = false;
			} finally {
				if(conn!=null && conn.State == System.Data.ConnectionState.Open)
					conn.Close();
			}
			return resultado;
		}
    
		/**
		 * Busca el primer registro que coincida con los datos enviados
		 * @param VIGENCIA obj
		 * @return Retorna el mismo objeto pero con los datos consultados
		 */
		public VIGENCIA buscarPrimeroVIGENCIA(VIGENCIA obj) 
		{
			List<VIGENCIA> lista = null;
			try 
			{
				VIGENCIADao dao = new VIGENCIADao();
				conn = conexion.conection();
				lista = dao.search(conn, obj);
				if (lista != null && lista.Count > 0) 
				{
					obj = (VIGENCIA)lista[0];
				}
				else 
				{
					obj.ID = -1;
				}
			} 
			catch (Exception e) 
			{
				obj.ID = -1;
			} finally {
				if(conn!=null && conn.State == System.Data.ConnectionState.Open)
					conn.Close();
			}
			return obj;
		}
    
		/**
		 * Busca los registros que coincidan con los datos enviados
		 * @param VIGENCIA obj
		 * @return Retorna la lista de los registros que coinciden
		 */
		public VIGENCIA[] buscarVIGENCIA(VIGENCIA obj) 
		{
			VIGENCIA[] result=null;
			List<VIGENCIA> lista = null;
			try 
			{
				VIGENCIADao dao = new VIGENCIADao();
				conn = conexion.conection();
				lista = dao.search(conn, obj);
				if(lista != null && lista.Count > 0)
					result = lista.ToArray();
			}
			catch (Exception e) 
			{
				result=null;
			} finally {
				if(conn!=null && conn.State == System.Data.ConnectionState.Open)
					conn.Close();
			}
			return result;
		}
	
		/**
		 * Consulta todos los registros de la tabla
		 * @param VIGENCIA obj
		 * @return Retorna la lista de los registros en la tabla
		 */
		public VIGENCIA[] listarVIGENCIA() 
		{
			VIGENCIA[] result=null;
			List<VIGENCIA> lista = null;
			try 
			{
				VIGENCIADao dao = new VIGENCIADao();
				conn = conexion.conection();
				lista = dao.loadAll(conn);
				if(lista != null && lista.Count > 0)
					result = lista.ToArray();
			} 
			catch (Exception e) 
			{
				result=null;
			} finally {
				if(conn!=null && conn.State == System.Data.ConnectionState.Open)
					conn.Close();
			}
			return result;
		}
		
		/**
		 * Elimina un registro de la tabla
		 * @param VIGENCIA obj
		 * @return Retorna un boolean indicando si se realizo o no la operacion
		 */
		public bool eliminarVIGENCIA(VIGENCIA obj) 
		{
			bool resultado;
			resultado = false;
			try 
			{
				VIGENCIADao dao = new VIGENCIADao();
				conn = conexion.conection();
				dao.delete(conn, obj);
				resultado = true;
			} 
			catch (Exception e) 
			{
				resultado = false;
			} finally {
				if(conn!=null && conn.State == System.Data.ConnectionState.Open)
					conn.Close();
			}
			return resultado;
		}
	}	

}

