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

public partial class GestionViewrecibo {
    
	AccessDB conexion;
	SqlConnection conn;	
	
    public GestionViewrecibo() {
    
        crearObjetos();
    }
    
    private void crearObjetos(){
       conexion = AccessDB.obtenerInstancia();
    }
	
	/**
     * Inserta nuevo registro en la tabla
     * @param Viewrecibo obj
     * @return Retorna el mismo objeto pero con la llave primaria configurada
     */
	public Viewrecibo crearViewrecibo(Viewrecibo obj) {
		List<Viewrecibo> lista = null;
        Viewrecibo obj_new = new Viewrecibo();
		try {
            ViewreciboDao dao = new ViewreciboDao();
            conn = conexion.conection();
            dao.create(conn, obj);
            //verificar existencia
            obj_new.ID = obj.ID;
            lista = dao.searchMatching(conn, obj_new);
            if (lista != null && lista.Count > 0) {
                obj_new = (Viewrecibo)lista[0];
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
     * @param Viewrecibo obj
     * @return boolean indicando si se realizo o no la actualizacion
     */
    public bool editarViewrecibo(Viewrecibo obj) {
        bool resultado;
        resultado = false;
        try {
			ViewreciboDao dao = new ViewreciboDao();
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
     * @param Viewrecibo obj
     * @return Retorna el mismo objeto pero con los datos consultados
     */
    public Viewrecibo buscarPrimeroViewrecibo(Viewrecibo obj) {
        List<Viewrecibo> lista = null;
        try {
			ViewreciboDao dao = new ViewreciboDao();
            conn = conexion.conection();
            lista = dao.searchMatching(conn, obj);
            if (lista != null && lista.Count > 0) {
                obj = (Viewrecibo)lista[0];
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
    
    /**
     * Busca los registros que coincidan con los datos enviados
     * @param Viewrecibo obj
     * @return Retorna la lista de los registros que coinciden
     */
    public Viewrecibo[] buscarViewrecibo(Viewrecibo obj) {
        Viewrecibo[] result=null;
		List<Viewrecibo> lista = null;
        try {
			ViewreciboDao dao = new ViewreciboDao();
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
     * @param Viewrecibo obj
     * @return Retorna la lista de los registros que coinciden
     */
    public Viewrecibo[] buscarViewrecibo(Viewrecibo obj,int pagina, int numRegPagina) {
        Viewrecibo[] result=null;
		List<Viewrecibo> lista = null;
		if(pagina>0 && numRegPagina>0)
		{
			pagina--;
			int limInf =0;
			int limSup =0;
			limInf = pagina*numRegPagina+1;
			limSup = (pagina+1)*numRegPagina;
			try {
				ViewreciboDao dao = new ViewreciboDao();
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
     * @param Viewrecibo obj
     * @return Retorna la lista de los registros en la tabla
     */
    public Viewrecibo[] listarViewrecibo() {
        Viewrecibo[] result=null;
		List<Viewrecibo> lista = null;
        try {
			ViewreciboDao dao = new ViewreciboDao();
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
     * @param Viewrecibo obj
     * @return Retorna la lista de los registros en la tabla con paginacion
     */
	
	public Viewrecibo[] listarViewrecibo(int pagina, int numRegPagina) {
        Viewrecibo[] result=null;
		List<Viewrecibo> lista = null;
		if(pagina>0 && numRegPagina>0)
		{
			pagina--;
			int limInf =0;
			int limSup =0;
			limInf = pagina*numRegPagina+1;
			limSup = (pagina+1)*numRegPagina;
			try {
				ViewreciboDao dao = new ViewreciboDao();
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
	
	public int contarBusquedaViewrecibo(Viewrecibo obj) {
		int cantidad=-1;
        try {
			ViewreciboDao dao = new ViewreciboDao();
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
     * @param Viewrecibo obj
     * @return Retorna un boolean indicando si se realizo o no la operacion
     */
    public bool eliminarViewrecibo(Viewrecibo obj) {
        bool resultado;
        resultado = false;
        try {
			ViewreciboDao dao = new ViewreciboDao();
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
