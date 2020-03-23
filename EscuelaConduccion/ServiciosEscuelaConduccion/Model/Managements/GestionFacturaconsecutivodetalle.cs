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

public partial class GestionFacturaconsecutivodetalle {
    
	AccessDB conexion;
	SqlConnection conn;	
	
    public GestionFacturaconsecutivodetalle() {
    
        crearObjetos();
    }
    
    private void crearObjetos(){
       conexion = AccessDB.obtenerInstancia();
    }
	
	/**
     * Inserta nuevo registro en la tabla
     * @param Facturaconsecutivodetalle obj
     * @return Retorna el mismo objeto pero con la llave primaria configurada
     */
	public Facturaconsecutivodetalle crearFacturaconsecutivodetalle(Facturaconsecutivodetalle obj) {
		List<Facturaconsecutivodetalle> lista = null;
        Facturaconsecutivodetalle obj_new = new Facturaconsecutivodetalle();
		try {
            FacturaconsecutivodetalleDao dao = new FacturaconsecutivodetalleDao();
            conn = conexion.conection();
            dao.create(conn, obj);
            //verificar existencia
            obj_new.CONSECUTIVO = obj.CONSECUTIVO;
            obj_new.ID_FACTURACONSECUTIVO = obj.ID_FACTURACONSECUTIVO;
            lista = dao.searchMatching(conn, obj_new);
            if (lista != null && lista.Count > 0) {
                obj_new = (Facturaconsecutivodetalle)lista[0];
            }
            else {
                obj_new.ID = -1;
            }
        } catch (Exception e) {
            
            obj_new.ID = -1;
        } finally {
            if(conn!=null && conn.State == System.Data.ConnectionState.Open)
			conn.Close();
        }
        return obj_new;
    }
	
	/**
     * Edita un registro en la tabla
     * @param Facturaconsecutivodetalle obj
     * @return boolean indicando si se realizo o no la actualizacion
     */
    public bool editarFacturaconsecutivodetalle(Facturaconsecutivodetalle obj) {
        bool resultado;
        resultado = false;
        try {
			FacturaconsecutivodetalleDao dao = new FacturaconsecutivodetalleDao();
            conn = conexion.conection();
            dao.save(conn, obj);
            resultado = true;
        } catch (Exception e) {
            
            resultado = false;
        } finally {
            if(conn!=null && conn.State == System.Data.ConnectionState.Open)
			conn.Close();
        }
        return resultado;
    }
    
    /**
     * Busca el primer registro que coincida con los datos enviados
     * @param Facturaconsecutivodetalle obj
     * @return Retorna el mismo objeto pero con los datos consultados
     */
    public Facturaconsecutivodetalle buscarPrimeroFacturaconsecutivodetalle(Facturaconsecutivodetalle obj) {
        List<Facturaconsecutivodetalle> lista = null;
        try {
			FacturaconsecutivodetalleDao dao = new FacturaconsecutivodetalleDao();
            conn = conexion.conection();
            lista = dao.searchMatching(conn, obj);
            if (lista != null && lista.Count > 0) {
                obj = (Facturaconsecutivodetalle)lista[0];
            }
            else {
				obj.ID = -1;
            }
        } catch (Exception e) {
            
            obj.ID = -1;
        } finally {
            if(conn!=null && conn.State == System.Data.ConnectionState.Open)
			conn.Close();
        }
        return obj;
    }

        public Facturaconsecutivodetalle obtenerFacturaconsecutivodetalle()
        {
            List<Facturaconsecutivodetalle> lista = null;
            Facturaconsecutivodetalle obj = new Facturaconsecutivodetalle();
            obj.DISPONIBLE = "SI";
            try
            {
                FacturaconsecutivodetalleDao dao = new FacturaconsecutivodetalleDao();
                conn = conexion.conection();
                lista = dao.searchMatching(conn, obj);
                if (lista != null && lista.Count > 0)
                {
                    obj = (Facturaconsecutivodetalle)lista[0];
                    Facturaconsecutivodetalle objTmp = obj;
                    objTmp.DISPONIBLE = "NO";
                    editarFacturaconsecutivodetalle(objTmp);
                }
                else
                {
                    obj.ID = -1;
                }
            }
            catch (Exception e)
            {

                obj.ID = -1;
            }
            finally
            {
                if (conn != null && conn.State == System.Data.ConnectionState.Open)
                    conn.Close();
            }
            return obj;
        }

        /**
         * Busca los registros que coincidan con los datos enviados
         * @param Facturaconsecutivodetalle obj
         * @return Retorna la lista de los registros que coinciden
         */
        public Facturaconsecutivodetalle[] buscarFacturaconsecutivodetalle(Facturaconsecutivodetalle obj) {
        Facturaconsecutivodetalle[] result=null;
		List<Facturaconsecutivodetalle> lista = null;
        try {
			FacturaconsecutivodetalleDao dao = new FacturaconsecutivodetalleDao();
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
	
	/**
     * Busca los registros que coincidan con los datos enviados
     * @param Facturaconsecutivodetalle obj
     * @return Retorna la lista de los registros que coinciden
     */
    public Facturaconsecutivodetalle[] buscarFacturaconsecutivodetalle(Facturaconsecutivodetalle obj,int pagina, int numRegPagina) {
        Facturaconsecutivodetalle[] result=null;
		List<Facturaconsecutivodetalle> lista = null;
		if(pagina>0 && numRegPagina>0)
		{
			pagina--;
			int limInf =0;
			int limSup =0;
			limInf = pagina*numRegPagina+1;
			limSup = (pagina+1)*numRegPagina;
			try {
				FacturaconsecutivodetalleDao dao = new FacturaconsecutivodetalleDao();
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
     * @param Facturaconsecutivodetalle obj
     * @return Retorna la lista de los registros en la tabla
     */
    public Facturaconsecutivodetalle[] listarFacturaconsecutivodetalle() {
        Facturaconsecutivodetalle[] result=null;
		List<Facturaconsecutivodetalle> lista = null;
        try {
			FacturaconsecutivodetalleDao dao = new FacturaconsecutivodetalleDao();
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
     * @param Facturaconsecutivodetalle obj
     * @return Retorna la lista de los registros en la tabla con paginacion
     */
	
	public Facturaconsecutivodetalle[] listarFacturaconsecutivodetalle(int pagina, int numRegPagina) {
        Facturaconsecutivodetalle[] result=null;
		List<Facturaconsecutivodetalle> lista = null;
		if(pagina>0 && numRegPagina>0)
		{
			pagina--;
			int limInf =0;
			int limSup =0;
			limInf = pagina*numRegPagina+1;
			limSup = (pagina+1)*numRegPagina;
			try {
				FacturaconsecutivodetalleDao dao = new FacturaconsecutivodetalleDao();
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
	
	public int contarBusquedaFacturaconsecutivodetalle(Facturaconsecutivodetalle obj) {
		int cantidad=-1;
        try {
			FacturaconsecutivodetalleDao dao = new FacturaconsecutivodetalleDao();
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
	
    /**
     * Elimina un registro de la tabla
     * @param Facturaconsecutivodetalle obj
     * @return Retorna un boolean indicando si se realizo o no la operacion
     */
    public bool eliminarFacturaconsecutivodetalle(Facturaconsecutivodetalle obj) {
        bool resultado;
        resultado = false;
        try {
			FacturaconsecutivodetalleDao dao = new FacturaconsecutivodetalleDao();
            conn = conexion.conection();
            dao.delete(conn, obj);
            resultado = true;
        } catch (Exception e) {
            
            resultado = false;
        } finally {
            if(conn!=null && conn.State == System.Data.ConnectionState.Open)
			conn.Close();
        }
        return resultado;
    }

}

}

