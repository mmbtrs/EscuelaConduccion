using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Collections;

using ServiciosEscuelaConduccion.dao;
using ServiciosEscuelaConduccion.objetos;
using ServiciosEscuelaConduccion.Model.DataAccess;

namespace ServiciosEscuelaConduccion.gestion {

public partial class GestionViewliquidacion {
    
    AccessDB conexion;
	SqlConnection conn;	
	
    public GestionViewliquidacion() {
    
        crearObjetos();
    }
    
    private void crearObjetos(){
       conexion = AccessDB.obtenerInstancia();
    }
	
    /**
     * Busca el primer registro que coincida con los datos enviados
     * @param Viewliquidacion obj
     * @return Retorna el mismo objeto pero con los datos consultados
     */
    public Viewliquidacion buscarPrimeroViewliquidacion(Viewliquidacion obj) {
        List<Viewliquidacion> lista = null;
        try {
			ViewliquidacionDao dao = new ViewliquidacionDao();
            conn = conexion.conection();
            lista = dao.searchMatching(conn, obj);
            if (lista != null && lista.Count > 0) {
                obj = (Viewliquidacion)lista[0];
            }
            else {
				obj.NUMERO_RECIBO = "-1";
            }
        } catch (Exception e) {
            
            obj.NUMERO_RECIBO = "-1";
        } finally {
            if(conn!=null && conn.State == System.Data.ConnectionState.Open)
			conn.Close();
        }
        return obj;
    }
    
    /**
     * Busca los registros que coincidan con los datos enviados
     * @param Viewliquidacion obj
     * @return Retorna la lista de los registros que coinciden
     */
    public Viewliquidacion[] buscarViewliquidacion(Viewliquidacion obj) {
        Viewliquidacion[] result=null;
		List<Viewliquidacion> lista = null;
        try {
			ViewliquidacionDao dao = new ViewliquidacionDao();
            conn = conexion.conection();
            lista = dao.searchMatching(conn, obj);
			if(lista != null && lista.Count > 0)
			   result = lista.ToArray();
        } catch (Exception e) {
            result=null;
        } finally {
            if(conn!=null && conn.State == System.Data.ConnectionState.Open)
			conn.Close();
        }
        return result;
    }

        public Viewliquidacion[] buscarViewliquidacionBetween(Viewliquidacion obj, DateTime fechaIniLiq, DateTime fechaFinLiq, DateTime fechaIniPag, DateTime fechaFinPag)
        {
            Viewliquidacion[] result = null;
            List<Viewliquidacion> lista = null;
            try
            {
                ViewliquidacionDao dao = new ViewliquidacionDao();
                conn = conexion.conection();
                lista = dao.searchMatchingBetween(conn, obj, fechaIniLiq, fechaFinLiq, fechaIniPag, fechaFinPag);
                if (lista != null && lista.Count > 0)
                    result = lista.ToArray();
            }
            catch (Exception e)
            {
                result = null;
            }
            finally
            {
                if (conn != null && conn.State == System.Data.ConnectionState.Open)
                    conn.Close();
            }
            return result;
        }

        /**
         * Busca los registros que coincidan con los datos enviados
         * @param Viewliquidacion obj
         * @return Retorna la lista de los registros que coinciden
         */
        public Viewliquidacion[] buscarViewliquidacion(Viewliquidacion obj,int pagina, int numRegPagina) {
        Viewliquidacion[] result=null;
		List<Viewliquidacion> lista = null;
		if(pagina>0 && numRegPagina>0)
		{
			pagina--;
			int limInf =0;
			int limSup =0;
			limInf = pagina*numRegPagina+1;
			limSup = (pagina+1)*numRegPagina;
			try {
				ViewliquidacionDao dao = new ViewliquidacionDao();
				conn = conexion.conection();
				lista = dao.searchMatching(conn, obj,limInf,limSup);
				if(lista != null && lista.Count > 0)
					result = lista.ToArray();
			} catch (Exception e) {
				result=null;
			} finally {
			 if(conn!=null && conn.State == System.Data.ConnectionState.Open)
			    conn.Close();
			}
		}
        return result;
    }
    
    /**
     * Consulta todos los registros de la tabla
     * @param Viewliquidacion obj
     * @return Retorna la lista de los registros en la tabla
     */
    public Viewliquidacion[] listarViewliquidacion() {
        Viewliquidacion[] result=null;
		List<Viewliquidacion> lista = null;
        try {
			ViewliquidacionDao dao = new ViewliquidacionDao();
            conn = conexion.conection();
            lista = dao.loadAll(conn);
			if(lista != null && lista.Count > 0)
			    result = lista.ToArray();
        } catch (Exception e) {
            result=null;
        } finally {
            if(conn!=null && conn.State == System.Data.ConnectionState.Open)
			conn.Close();
        }
        return result;
    }
    
	/**
     * Consulta todos los registros de la tabla pero con Paginacion
     * @param Viewliquidacion obj
     * @return Retorna la lista de los registros en la tabla con paginacion
     */
	
	public Viewliquidacion[] listarViewliquidacion(int pagina, int numRegPagina) {
        Viewliquidacion[] result=null;
		List<Viewliquidacion> lista = null;
		if(pagina>0 && numRegPagina>0)
		{
			pagina--;
			int limInf =0;
			int limSup =0;
			limInf = pagina*numRegPagina+1;
			limSup = (pagina+1)*numRegPagina;
			try {
				ViewliquidacionDao dao = new ViewliquidacionDao();
				conn = conexion.conection();
				if(limInf<=dao.countAll(conn))
					{
					lista = dao.loadAll(conn,limInf,limSup);
					if(lista != null && lista.Count > 0)
					    result = lista.ToArray();
					}
			} catch (Exception e) {
				result=null;
			} finally {
				if(conn!=null && conn.State == System.Data.ConnectionState.Open)
				conn.Close();
			}
		}
        return result;
    }
	
	public int contarBusquedaViewliquidacion(Viewliquidacion obj) {
		int cantidad=-1;
        try {
			ViewliquidacionDao dao = new ViewliquidacionDao();
            conn = conexion.conection();
            cantidad = dao.countSearchMatching(conn, obj);
        } catch (Exception e) {
            cantidad=-1;
        } finally {
            if(conn!=null && conn.State == System.Data.ConnectionState.Open)
			conn.Close();
        }
        return cantidad;
    }

}

}

