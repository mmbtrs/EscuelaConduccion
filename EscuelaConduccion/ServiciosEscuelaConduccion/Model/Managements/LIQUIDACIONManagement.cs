using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Collections;

using ServiciosEscuelaConduccion.Model.DataAccess;
using ServiciosEscuelaConduccion.Model.DAO;
using ServiciosEscuelaConduccion.Model.Objects;
using System.Data;
using ExpressionsEvaluator;

namespace ServiciosEscuelaConduccion.Model.Managements 
{

	public partial class LIQUIDACIONManagement
	{
		AccessDB conexion;
		SqlConnection conn;	
	
		public LIQUIDACIONManagement() 
		{
			crearObjetos();
		}
    
		private void crearObjetos()
		{
			conexion = AccessDB.obtenerInstancia();
		}
	
		/**
		 * Inserta nuevo registro en la tabla
		 * @param LIQUIDACION obj
		 * @return Retorna el mismo objeto pero con la llave primaria configurada
		 */
		public LIQUIDACION crearLIQUIDACION(LIQUIDACION obj) 
		{
			List<LIQUIDACION> lista = null;
			try 
			{
				LIQUIDACIONDao dao = new LIQUIDACIONDao();
				conn = conexion.conection();
				dao.create(conn, obj);
				//verificar existencia
				LIQUIDACION tmpObj = new LIQUIDACION();
				tmpObj.ID_CLIENTE = obj.ID_CLIENTE;
				tmpObj.ID_TIPO_LIQUIDACION = obj.ID_TIPO_LIQUIDACION;
				tmpObj.TOTAL = obj.TOTAL;
				lista = dao.search(conn, tmpObj);
				if (lista != null && lista.Count > 0) 
				{
					obj = (LIQUIDACION)lista[lista.Count - 1];
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

        public DataSet crearMultipleLIQUIDACION_1(TARIFA tarifa, int id_cliente)
        {
            DataTable lista = new DataTable();
            DataSet ds = new DataSet();
            lista.Columns.Add(new DataColumn("ID_TARIFADETALLE"));
            lista.Columns.Add(new DataColumn("CONCEPTO"));
            lista.Columns.Add(new DataColumn("VALOR"));
            lista.Columns.Add(new DataColumn("DESCONTABLE"));
            try
            {
                LIQUIDACION liquidacion = new LIQUIDACION();
                TARIFA_DETALLE tARIFA_DETALLE = new TARIFA_DETALLE();
                tARIFA_DETALLE.ID_TARIFA = tarifa.ID;
                TARIFA_DETALLEManagement tARIFA_DETALLEManagement = new TARIFA_DETALLEManagement();
                TARIFA_DETALLE[] lst_tarifas_detalle = tARIFA_DETALLEManagement.buscarTARIFA_DETALLE_SoloActivos(tARIFA_DETALLE);
                if (lst_tarifas_detalle != null && lst_tarifas_detalle.Length > 0)
                {
                    foreach (TARIFA_DETALLE item in lst_tarifas_detalle)
                    {
                        double valor;
                        valor = evaluarExpresion(tarifa,id_cliente, item.FORMULA);
                        DataRow dr = lista.NewRow();
                        dr["ID_TARIFADETALLE"] = item.ID;
                        dr["CONCEPTO"] = getConcepto(item.ID_TARIFA_CONCEPTO);
                        dr["VALOR"] = valor;
                        dr["DESCONTABLE"] = item.DESCONTABLE;
                        lista.Rows.Add(dr);
                    }
                    ds.Tables.Add(lista);
                }
                else
                    return null;
            }
            catch (Exception e)
            {
                ds = null;
            }
            finally
            {
                if (conn != null && conn.State == System.Data.ConnectionState.Open)
                    conn.Close();
            }
            return ds;
        }

        public LIQUIDACION crearMultipleLIQUIDACION_2(LIQUIDACION liquidacion, LIQUIDACION_DETALLE[] lstDetalles, VIEW_CLIENTE myCliente)
        {
            try
            {
                LIQUIDACION_DETALLEManagement gestionDetalle = new LIQUIDACION_DETALLEManagement();
                liquidacion.FECHA_LIQUIDACION = DateTime.Now.Date;
                liquidacion = crearLIQUIDACION(liquidacion);
                if (liquidacion != null && liquidacion.ID > 0)
                {
                    foreach (LIQUIDACION_DETALLE detalle in lstDetalles)
                    {
                        detalle.ID_LIQUIDACION = liquidacion.ID;
                        gestionDetalle.crearLIQUIDACION_DETALLE(detalle);
                    }
                    return liquidacion;
                }
                else
                    return null;
            }
            catch (Exception e)
            {
                return null;
            }
            finally
            {
                if (conn != null && conn.State == System.Data.ConnectionState.Open)
                    conn.Close();
            }
        }

        private String getConcepto(int iD_TARIFA_CONCEPTO)
        {
            try
            {
                TARIFA_CONCEPTOManagement tARIFA_CONCEPTOManagement = new TARIFA_CONCEPTOManagement();
                TARIFA_CONCEPTO tARIFA_CONCEPTO = new TARIFA_CONCEPTO();
                tARIFA_CONCEPTO.ID = iD_TARIFA_CONCEPTO;
                tARIFA_CONCEPTO = tARIFA_CONCEPTOManagement.buscarPrimeroTARIFA_CONCEPTO(tARIFA_CONCEPTO);
                if (tARIFA_CONCEPTO != null && tARIFA_CONCEPTO.ID > 0)
                    return tARIFA_CONCEPTO.NOMBRE;
                else
                    return "";
            }
            catch (Exception exp)
            {
                return "";
            }
        }

        
        
        //public List<LIQUIDACION_DETALLE> crearMultipleLIQUIDACION(List<TARIFA_DETALLE> lst_tarifas_detalle)
        //{
        //    List<LIQUIDACION_DETALLE> lista = new List<LIQUIDACION_DETALLE>();
        //    try
        //    {
        //        LIQUIDACIONDao dao = new LIQUIDACIONDao();
        //        conn = conexion.conection();
        //        LIQUIDACION liquidacion = new LIQUIDACION();
        //        float total = 0;
        //        foreach (TARIFA_DETALLE item in lst_tarifas_detalle)
        //        {
        //            float valor;
        //            valor = evaluarExpresion(item.FORMULA);
        //            LIQUIDACION_DETALLE ld = new LIQUIDACION_DETALLE();
        //            ld.VALOR_CONCEPTO = valor;
        //            ld.ID_TARIFA_DETALLE = item.ID;
        //            lista.Add(ld);
        //            total += valor;
        //        }
        //        liquidacion.TOTAL = total;
        //        dao.create(conn, liquidacion);
        //        dao.create(conn, obj);
        //        //verificar existencia
        //        lista = dao.search(conn, obj);
        //        if (lista != null && lista.Count > 0)
        //        {
        //            obj = (LIQUIDACION)lista[0];
        //        }
        //        else
        //        {
        //            obj.ID = -1;
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        obj.ID = -1;
        //    }
        //    finally
        //    {
        //        if (conn != null && conn.State == System.Data.ConnectionState.Open)
        //            conn.Close();
        //    }
        //    return obj;
        //}

        private double evaluarExpresion(TARIFA tarifa, int id_cliente, String formula)
        {
            try
            {
                GESTIONVariables gestionVariables = new GESTIONVariables(id_cliente, tarifa);
                String expresion = gestionVariables.reemplazarVariables(formula);
                IEvaluator evaluador = new Evaluator();
                Object result = evaluador.evaluarExpresion(expresion);
                if (result != null)
                {
                    double tmpLong = 0;
                    if (double.TryParse(result.ToString(), out tmpLong))
                        return tmpLong;
                    else
                        return 0;
                }
                return 0;
            }
            catch (Exception exp)
            {
                return 0;
            }
        }

        /**
		 * Edita un registro en la tabla
		 * @param LIQUIDACION obj
		 * @return boolean indicando si se realizo o no la actualizacion
		 */
        public bool editarLIQUIDACION(LIQUIDACION obj) 
		{
			bool resultado;
			resultado = false;
			try 
			{
				LIQUIDACIONDao dao = new LIQUIDACIONDao();
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
		 * @param LIQUIDACION obj
		 * @return Retorna el mismo objeto pero con los datos consultados
		 */
		public LIQUIDACION buscarPrimeroLIQUIDACION(LIQUIDACION obj) 
		{
			List<LIQUIDACION> lista = null;
			try 
			{
				LIQUIDACIONDao dao = new LIQUIDACIONDao();
				conn = conexion.conection();
				lista = dao.search(conn, obj);
				if (lista != null && lista.Count > 0) 
				{
					obj = (LIQUIDACION)lista[0];
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
		 * @param LIQUIDACION obj
		 * @return Retorna la lista de los registros que coinciden
		 */
		public LIQUIDACION[] buscarLIQUIDACION(LIQUIDACION obj) 
		{
			LIQUIDACION[] result=null;
			List<LIQUIDACION> lista = null;
			try 
			{
				LIQUIDACIONDao dao = new LIQUIDACIONDao();
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
		 * @param LIQUIDACION obj
		 * @return Retorna la lista de los registros en la tabla
		 */
		public LIQUIDACION[] listarLIQUIDACION() 
		{
			LIQUIDACION[] result=null;
			List<LIQUIDACION> lista = null;
			try 
			{
				LIQUIDACIONDao dao = new LIQUIDACIONDao();
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
		 * @param LIQUIDACION obj
		 * @return Retorna un boolean indicando si se realizo o no la operacion
		 */
		public bool eliminarLIQUIDACION(LIQUIDACION obj) 
		{
			bool resultado;
			resultado = false;
			try 
			{
				LIQUIDACIONDao dao = new LIQUIDACIONDao();
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

