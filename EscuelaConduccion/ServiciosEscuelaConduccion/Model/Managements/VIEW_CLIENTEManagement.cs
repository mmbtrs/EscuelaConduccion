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

	public partial class VIEW_CLIENTEManagement
	{
		AccessDB conexion;
		SqlConnection conn;	
	
		public VIEW_CLIENTEManagement() 
		{
			crearObjetos();
		}
    
		private void crearObjetos()
		{
			conexion = AccessDB.obtenerInstancia();
		}
	
		/**
		 * Inserta nuevo registro en la tabla
		 * @param VIEW_CLIENTE obj
		 * @return Retorna el mismo objeto pero con la llave primaria configurada
		 */
		public VIEW_CLIENTE crearVIEW_CLIENTE(VIEW_CLIENTE obj) 
		{
			List<VIEW_CLIENTE> lista = null;
			try 
			{
				VIEW_CLIENTEDao dao = new VIEW_CLIENTEDao();
				conn = conexion.conection();
				dao.create(conn, obj);
				//verificar existencia
				lista = dao.search(conn, obj);
				if (lista != null && lista.Count > 0) 
				{
					obj = (VIEW_CLIENTE)lista[0];
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
		 * @param VIEW_CLIENTE obj
		 * @return boolean indicando si se realizo o no la actualizacion
		 */
		public bool editarVIEW_CLIENTE(VIEW_CLIENTE obj) 
		{
			bool resultado;
			resultado = false;
			try 
			{
				VIEW_CLIENTEDao dao = new VIEW_CLIENTEDao();
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
		 * @param VIEW_CLIENTE obj
		 * @return Retorna el mismo objeto pero con los datos consultados
		 */
		public VIEW_CLIENTE buscarPrimeroVIEW_CLIENTE(VIEW_CLIENTE obj) 
		{
			List<VIEW_CLIENTE> lista = null;
			try 
			{
				VIEW_CLIENTEDao dao = new VIEW_CLIENTEDao();
				conn = conexion.conection();
				lista = dao.search(conn, obj);
				if (lista != null && lista.Count > 0) 
				{
					obj = (VIEW_CLIENTE)lista[0];
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
		 * @param VIEW_CLIENTE obj
		 * @return Retorna la lista de los registros que coinciden
		 */
		public VIEW_CLIENTE[] buscarVIEW_CLIENTE(VIEW_CLIENTE obj) 
		{
			VIEW_CLIENTE[] result=null;
			List<VIEW_CLIENTE> lista = null;
			try 
			{
				VIEW_CLIENTEDao dao = new VIEW_CLIENTEDao();
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
		 * @param VIEW_CLIENTE obj
		 * @return Retorna la lista de los registros en la tabla
		 */
		public VIEW_CLIENTE[] listarVIEW_CLIENTE() 
		{
			VIEW_CLIENTE[] result=null;
			List<VIEW_CLIENTE> lista = null;
			try 
			{
				VIEW_CLIENTEDao dao = new VIEW_CLIENTEDao();
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
		 * @param VIEW_CLIENTE obj
		 * @return Retorna un boolean indicando si se realizo o no la operacion
		 */
		public bool eliminarVIEW_CLIENTE(VIEW_CLIENTE obj) 
		{
			bool resultado;
			resultado = false;
			try 
			{
				VIEW_CLIENTEDao dao = new VIEW_CLIENTEDao();
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

