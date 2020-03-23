using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Collections;

using ServiciosEscuelaConduccion.Model.DataAccess;
using ServiciosEscuelaConduccion.Model.DAO;
using ServiciosEscuelaConduccion.Model.Objects;
using ServiciosEscuelaConduccion.gestion;
using ServiciosEscuelaConduccion.objetos;

namespace ServiciosEscuelaConduccion.Model.Managements 
{

	public partial class FACTURACONSECUTIVOManagement
	{
		AccessDB conexion;
		SqlConnection conn;	
	
		public FACTURACONSECUTIVOManagement() 
		{
			crearObjetos();
		}
    
		private void crearObjetos()
		{
			conexion = AccessDB.obtenerInstancia();
		}
	
		/**
		 * Inserta nuevo registro en la tabla
		 * @param FACTURACONSECUTIVO obj
		 * @return Retorna el mismo objeto pero con la llave primaria configurada
		 */
		public FACTURACONSECUTIVO crearFACTURACONSECUTIVO(FACTURACONSECUTIVO obj) 
		{
			List<FACTURACONSECUTIVO> lista = null;
            GestionFacturaconsecutivodetalle gestionFacturaconsecutivodetalle = new GestionFacturaconsecutivodetalle();
			try 
			{
				FACTURACONSECUTIVODao dao = new FACTURACONSECUTIVODao();
				conn = conexion.conection();
				dao.create(conn, obj);
				//verificar existencia
                
				lista = dao.search(conn, obj);
				if (lista != null && lista.Count > 0) 
				{
					obj = (FACTURACONSECUTIVO)lista[0];
                    for (int i = int.Parse(obj.RANGO_INICIAL.ToString()); i <= obj.RANGO_FINAL; i++)
                    {
                        Facturaconsecutivodetalle facturaconsecutivodetalle = new Facturaconsecutivodetalle();
                        Facturaconsecutivodetalle tmp = new Facturaconsecutivodetalle();
                        tmp.CONSECUTIVO = float.Parse(i.ToString());
                        tmp.ID_FACTURACONSECUTIVO = obj.ID;
                        tmp = gestionFacturaconsecutivodetalle.buscarPrimeroFacturaconsecutivodetalle(tmp);
                        if (!(tmp != null && tmp.ID > 0))
                        {
                            facturaconsecutivodetalle.CONSECUTIVO = float.Parse(i.ToString());
                            facturaconsecutivodetalle.ID_FACTURACONSECUTIVO = obj.ID;
                            facturaconsecutivodetalle.DISPONIBLE = "SI";
                            gestionFacturaconsecutivodetalle.crearFacturaconsecutivodetalle(facturaconsecutivodetalle);
                        }
                    }

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
		 * @param FACTURACONSECUTIVO obj
		 * @return boolean indicando si se realizo o no la actualizacion
		 */
		public bool editarFACTURACONSECUTIVO(FACTURACONSECUTIVO obj) 
		{
			bool resultado;
			resultado = false;
			try 
			{
				FACTURACONSECUTIVODao dao = new FACTURACONSECUTIVODao();
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
		 * @param FACTURACONSECUTIVO obj
		 * @return Retorna el mismo objeto pero con los datos consultados
		 */
		public FACTURACONSECUTIVO buscarPrimeroFACTURACONSECUTIVO(FACTURACONSECUTIVO obj) 
		{
			List<FACTURACONSECUTIVO> lista = null;
			try 
			{
				FACTURACONSECUTIVODao dao = new FACTURACONSECUTIVODao();
				conn = conexion.conection();
				lista = dao.search(conn, obj);
				if (lista != null && lista.Count > 0) 
				{
					obj = (FACTURACONSECUTIVO)lista[0];
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
		 * @param FACTURACONSECUTIVO obj
		 * @return Retorna la lista de los registros que coinciden
		 */
		public FACTURACONSECUTIVO[] buscarFACTURACONSECUTIVO(FACTURACONSECUTIVO obj) 
		{
			FACTURACONSECUTIVO[] result=null;
			List<FACTURACONSECUTIVO> lista = null;
			try 
			{
				FACTURACONSECUTIVODao dao = new FACTURACONSECUTIVODao();
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
		 * @param FACTURACONSECUTIVO obj
		 * @return Retorna la lista de los registros en la tabla
		 */
		public FACTURACONSECUTIVO[] listarFACTURACONSECUTIVO() 
		{
			FACTURACONSECUTIVO[] result=null;
			List<FACTURACONSECUTIVO> lista = null;
			try 
			{
				FACTURACONSECUTIVODao dao = new FACTURACONSECUTIVODao();
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
		 * @param FACTURACONSECUTIVO obj
		 * @return Retorna un boolean indicando si se realizo o no la operacion
		 */
		public bool eliminarFACTURACONSECUTIVO(FACTURACONSECUTIVO obj) 
		{
			bool resultado;
			resultado = false;
			try 
			{
				FACTURACONSECUTIVODao dao = new FACTURACONSECUTIVODao();
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

