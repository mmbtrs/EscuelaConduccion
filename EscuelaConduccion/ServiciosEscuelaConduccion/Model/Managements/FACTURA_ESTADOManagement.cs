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

	public partial class FACTURA_ESTADOManagement
	{
		AccessDB conexion;
		SqlConnection conn;	
	
		public FACTURA_ESTADOManagement() 
		{
			crearObjetos();
		}
    
		private void crearObjetos()
		{
			conexion = AccessDB.obtenerInstancia();
		}
	
		/**
		 * Inserta nuevo registro en la tabla
		 * @param FACTURA_ESTADO obj
		 * @return Retorna el mismo objeto pero con la llave primaria configurada
		 */
		public FACTURA_ESTADO crearFACTURA_ESTADO(FACTURA_ESTADO obj) 
		{
			List<FACTURA_ESTADO> lista = null;
			try 
			{
				FACTURA_ESTADODao dao = new FACTURA_ESTADODao();
				conn = conexion.conection();
				dao.create(conn, obj);
				//verificar existencia
				lista = dao.search(conn, obj);
				if (lista != null && lista.Count > 0) 
				{
					obj = (FACTURA_ESTADO)lista[0];
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
		 * @param FACTURA_ESTADO obj
		 * @return boolean indicando si se realizo o no la actualizacion
		 */
		public bool editarFACTURA_ESTADO(FACTURA_ESTADO obj) 
		{
			bool resultado;
			resultado = false;
			try 
			{
				FACTURA_ESTADODao dao = new FACTURA_ESTADODao();
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
		 * @param FACTURA_ESTADO obj
		 * @return Retorna el mismo objeto pero con los datos consultados
		 */
		public FACTURA_ESTADO buscarPrimeroFACTURA_ESTADO(FACTURA_ESTADO obj) 
		{
			List<FACTURA_ESTADO> lista = null;
			try 
			{
				FACTURA_ESTADODao dao = new FACTURA_ESTADODao();
				conn = conexion.conection();
				lista = dao.search(conn, obj);
				if (lista != null && lista.Count > 0) 
				{
					obj = (FACTURA_ESTADO)lista[0];
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
		 * @param FACTURA_ESTADO obj
		 * @return Retorna la lista de los registros que coinciden
		 */
		public FACTURA_ESTADO[] buscarFACTURA_ESTADO(FACTURA_ESTADO obj) 
		{
			FACTURA_ESTADO[] result=null;
			List<FACTURA_ESTADO> lista = null;
			try 
			{
				FACTURA_ESTADODao dao = new FACTURA_ESTADODao();
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
		 * @param FACTURA_ESTADO obj
		 * @return Retorna la lista de los registros en la tabla
		 */
		public FACTURA_ESTADO[] listarFACTURA_ESTADO() 
		{
			FACTURA_ESTADO[] result=null;
			List<FACTURA_ESTADO> lista = null;
			try 
			{
				FACTURA_ESTADODao dao = new FACTURA_ESTADODao();
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
		 * @param FACTURA_ESTADO obj
		 * @return Retorna un boolean indicando si se realizo o no la operacion
		 */
		public bool eliminarFACTURA_ESTADO(FACTURA_ESTADO obj) 
		{
			bool resultado;
			resultado = false;
			try 
			{
				FACTURA_ESTADODao dao = new FACTURA_ESTADODao();
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

