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

	public partial class CIUDADManagement
	{
		AccessDB conexion;
		SqlConnection conn;	
	
		public CIUDADManagement() 
		{
			crearObjetos();
		}
    
		private void crearObjetos()
		{
			conexion = AccessDB.obtenerInstancia();
		}
	
		/**
		 * Inserta nuevo registro en la tabla
		 * @param CIUDAD obj
		 * @return Retorna el mismo objeto pero con la llave primaria configurada
		 */
		public CIUDAD crearCIUDAD(CIUDAD obj) 
		{
			List<CIUDAD> lista = null;
			try 
			{
				CIUDADDao dao = new CIUDADDao();
				conn = conexion.conection();
				dao.create(conn, obj);
				//verificar existencia
				lista = dao.search(conn, obj);
				if (lista != null && lista.Count > 0) 
				{
					obj = (CIUDAD)lista[0];
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
		 * @param CIUDAD obj
		 * @return boolean indicando si se realizo o no la actualizacion
		 */
		public bool editarCIUDAD(CIUDAD obj) 
		{
			bool resultado;
			resultado = false;
			try 
			{
				CIUDADDao dao = new CIUDADDao();
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
		 * @param CIUDAD obj
		 * @return Retorna el mismo objeto pero con los datos consultados
		 */
		public CIUDAD buscarPrimeroCIUDAD(CIUDAD obj) 
		{
			List<CIUDAD> lista = null;
			try 
			{
				CIUDADDao dao = new CIUDADDao();
				conn = conexion.conection();
				lista = dao.search(conn, obj);
				if (lista != null && lista.Count > 0) 
				{
					obj = (CIUDAD)lista[0];
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
		 * @param CIUDAD obj
		 * @return Retorna la lista de los registros que coinciden
		 */
		public CIUDAD[] buscarCIUDAD(CIUDAD obj) 
		{
			CIUDAD[] result=null;
			List<CIUDAD> lista = null;
			try 
			{
				CIUDADDao dao = new CIUDADDao();
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
		 * @param CIUDAD obj
		 * @return Retorna la lista de los registros en la tabla
		 */
		public CIUDAD[] listarCIUDAD() 
		{
			CIUDAD[] result=null;
			List<CIUDAD> lista = null;
			try 
			{
				CIUDADDao dao = new CIUDADDao();
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
		 * @param CIUDAD obj
		 * @return Retorna un boolean indicando si se realizo o no la operacion
		 */
		public bool eliminarCIUDAD(CIUDAD obj) 
		{
			bool resultado;
			resultado = false;
			try 
			{
				CIUDADDao dao = new CIUDADDao();
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

