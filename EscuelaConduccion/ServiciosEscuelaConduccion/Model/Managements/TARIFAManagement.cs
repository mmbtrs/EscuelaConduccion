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

	public partial class TARIFAManagement
	{
		AccessDB conexion;
		SqlConnection conn;	
	
		public TARIFAManagement() 
		{
			crearObjetos();
		}
    
		private void crearObjetos()
		{
			conexion = AccessDB.obtenerInstancia();
		}
	
		/**
		 * Inserta nuevo registro en la tabla
		 * @param TARIFA obj
		 * @return Retorna el mismo objeto pero con la llave primaria configurada
		 */
		public TARIFA crearTARIFA(TARIFA obj) 
		{
			List<TARIFA> lista = null;
			try 
			{
				TARIFADao dao = new TARIFADao();
				conn = conexion.conection();
				dao.create(conn, obj);
				//verificar existencia
				lista = dao.search(conn, obj);
				if (lista != null && lista.Count > 0) 
				{
					obj = (TARIFA)lista[0];
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
		 * @param TARIFA obj
		 * @return boolean indicando si se realizo o no la actualizacion
		 */
		public bool editarTARIFA(TARIFA obj) 
		{
			bool resultado;
			resultado = false;
			try 
			{
				TARIFADao dao = new TARIFADao();
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
		 * @param TARIFA obj
		 * @return Retorna el mismo objeto pero con los datos consultados
		 */
		public TARIFA buscarPrimeroTARIFA(TARIFA obj) 
		{
			List<TARIFA> lista = null;
			try 
			{
				TARIFADao dao = new TARIFADao();
				conn = conexion.conection();
				lista = dao.search(conn, obj);
				if (lista != null && lista.Count > 0) 
				{
					obj = (TARIFA)lista[0];
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
		 * @param TARIFA obj
		 * @return Retorna la lista de los registros que coinciden
		 */
		public TARIFA[] buscarTARIFA(TARIFA obj) 
		{
			TARIFA[] result=null;
			List<TARIFA> lista = null;
			try 
			{
				TARIFADao dao = new TARIFADao();
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
		 * @param TARIFA obj
		 * @return Retorna la lista de los registros en la tabla
		 */
		public TARIFA[] listarTARIFA() 
		{
			TARIFA[] result=null;
			List<TARIFA> lista = null;
			try 
			{
				TARIFADao dao = new TARIFADao();
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
		 * @param TARIFA obj
		 * @return Retorna un boolean indicando si se realizo o no la operacion
		 */
		public bool eliminarTARIFA(TARIFA obj) 
		{
			bool resultado;
			resultado = false;
			try 
			{
				TARIFA_DETALLEManagement gestionDetalle = new TARIFA_DETALLEManagement();
				TARIFA_DETALLE tARIFA_DETALLE = new TARIFA_DETALLE();
				tARIFA_DETALLE.ID_TARIFA = obj.ID;
				TARIFA_DETALLE[] lstDetalle = gestionDetalle.buscarTARIFA_DETALLE(tARIFA_DETALLE);
				if (lstDetalle != null && lstDetalle.Length > 0)
				{
					foreach (TARIFA_DETALLE detalle in lstDetalle)
					{
						gestionDetalle.eliminarTARIFA_DETALLE(detalle);
					}
				}
				TARIFADao dao = new TARIFADao();
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

