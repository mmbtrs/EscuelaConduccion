using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Collections;

using ServiciosEscuelaConduccion.Model.DataAccess;
using ServiciosEscuelaConduccion.Model.DAO;
using ServiciosEscuelaConduccion.Model.Objects;
using ServiciosEscuelaConduccion.Utilidades;

namespace ServiciosEscuelaConduccion.Model.Managements 
{

	public partial class ACUERDO_PAGOManagement
	{
		AccessDB conexion;
		SqlConnection conn;	
	
		public ACUERDO_PAGOManagement() 
		{
			crearObjetos();
		}
    
		private void crearObjetos()
		{
			conexion = AccessDB.obtenerInstancia();
		}
	
		/**
		 * Inserta nuevo registro en la tabla
		 * @param ACUERDO_PAGO obj
		 * @return Retorna el mismo objeto pero con la llave primaria configurada
		 */
		public ACUERDO_PAGO crearACUERDO_PAGO(ACUERDO_PAGO obj) 
		{
			List<ACUERDO_PAGO> lista = null;
			try 
			{
				ACUERDO_PAGODao dao = new ACUERDO_PAGODao();
				conn = conexion.conection();
                int numAcuerdo = Funciones.getId(conn, "ACUERDOS_PAGO");
                obj.NUMERO_ACUERDO = numAcuerdo.ToString();
                dao.create(conn, obj);
                //verificar existencia
                ACUERDO_PAGO objNew = new ACUERDO_PAGO();
                objNew.NUMERO_ACUERDO = obj.NUMERO_ACUERDO;
                objNew.ID_LIQUIDACION = obj.ID_LIQUIDACION;
                lista = dao.search(conn, objNew);
				if (lista != null && lista.Count > 0) 
				{
					obj = (ACUERDO_PAGO)lista[0];
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
		 * @param ACUERDO_PAGO obj
		 * @return boolean indicando si se realizo o no la actualizacion
		 */
		public bool editarACUERDO_PAGO(ACUERDO_PAGO obj) 
		{
			bool resultado;
			resultado = false;
			try 
			{
				ACUERDO_PAGODao dao = new ACUERDO_PAGODao();
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
		 * @param ACUERDO_PAGO obj
		 * @return Retorna el mismo objeto pero con los datos consultados
		 */
		public ACUERDO_PAGO buscarPrimeroACUERDO_PAGO(ACUERDO_PAGO obj) 
		{
			List<ACUERDO_PAGO> lista = null;
			try 
			{
				ACUERDO_PAGODao dao = new ACUERDO_PAGODao();
				conn = conexion.conection();
				lista = dao.search(conn, obj);
				if (lista != null && lista.Count > 0) 
				{
					obj = (ACUERDO_PAGO)lista[0];
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
		 * @param ACUERDO_PAGO obj
		 * @return Retorna la lista de los registros que coinciden
		 */
		public ACUERDO_PAGO[] buscarACUERDO_PAGO(ACUERDO_PAGO obj) 
		{
			ACUERDO_PAGO[] result=null;
			List<ACUERDO_PAGO> lista = null;
			try 
			{
				ACUERDO_PAGODao dao = new ACUERDO_PAGODao();
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
		 * @param ACUERDO_PAGO obj
		 * @return Retorna la lista de los registros en la tabla
		 */
		public ACUERDO_PAGO[] listarACUERDO_PAGO() 
		{
			ACUERDO_PAGO[] result=null;
			List<ACUERDO_PAGO> lista = null;
			try 
			{
				ACUERDO_PAGODao dao = new ACUERDO_PAGODao();
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
		 * @param ACUERDO_PAGO obj
		 * @return Retorna un boolean indicando si se realizo o no la operacion
		 */
		public bool eliminarACUERDO_PAGO(ACUERDO_PAGO obj) 
		{
			bool resultado;
			resultado = false;
			try 
			{
				ACUERDO_PAGO_DETALLEManagement gestionDetalle = new ACUERDO_PAGO_DETALLEManagement();
				ACUERDO_PAGO_DETALLE detalle = new ACUERDO_PAGO_DETALLE();
				detalle.ID_ACUERDO_PAGO = obj.ID;
				ACUERDO_PAGO_DETALLE[] lstDetalles = gestionDetalle.buscarACUERDO_PAGO_DETALLE(detalle);
				if (lstDetalles != null && lstDetalles.Length > 0)
				{
					RECIBOManagement gestionRecibo = new RECIBOManagement();
					
					foreach (ACUERDO_PAGO_DETALLE item in lstDetalles)
					{
						RECIBO recibo = new RECIBO();
						if (item.ID_RECIBO != null && item.ID_RECIBO > 0)
						{
							recibo.ID = item.ID_RECIBO;
							gestionRecibo.eliminarRECIBO(recibo); 
						}
						gestionDetalle.eliminarACUERDO_PAGO_DETALLE(item);
					}
				}
				ACUERDO_PAGODao dao = new ACUERDO_PAGODao();
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

