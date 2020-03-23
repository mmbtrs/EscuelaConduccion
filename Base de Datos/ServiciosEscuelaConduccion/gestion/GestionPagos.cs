using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Collections;

using AccesoDatos;

using ServiciosEscuelaConduccion.dao;
using ServiciosEscuelaConduccion.objetos;



namespace ServiciosEscuelaConduccion.gestion {

public partial class GestionPagos {
    
	ConectarBD conexion;
	SqlConnection conn;	
	
    public GestionPagos() {
    
        crearObjetos();
    }
    
    private void crearObjetos(){
       conexion = ConectarBD.obtenerInstancia();
    }
	
	/**
     * Inserta nuevo registro en la tabla
     * @param Pagos obj
     * @return Retorna el mismo objeto pero con la llave primaria configurada
     */
	public Pagos crearPagos(Pagos obj) {
		List<Pagos> lista = null;
        Pagos obj_new = new Pagos();
		try {
            PagosDao dao = new PagosDao();
            conn = conexion.conectar();
            int id = Funciones.obtenerId(conn, "PAGOS");
            obj.ID = id;
            dao.create(conn, obj);
            //verificar existencia
            obj_new.ID = obj.ID;
            lista = dao.searchMatching(conn, obj_new);
            if (lista != null && lista.Count > 0) {
                obj_new = (Pagos)lista[0];
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
     * @param Pagos obj
     * @return boolean indicando si se realizo o no la actualizacion
     */
    public bool editarPagos(Pagos obj) {
        bool resultado;
        resultado = false;
        try {
			PagosDao dao = new PagosDao();
            conn = conexion.conectar();
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
     * @param Pagos obj
     * @return Retorna el mismo objeto pero con los datos consultados
     */
    public Pagos buscarPrimeroPagos(Pagos obj) {
        List<Pagos> lista = null;
        try {
			PagosDao dao = new PagosDao();
            conn = conexion.conectar();
            lista = dao.searchMatching(conn, obj);
            if (lista != null && lista.Count > 0) {
                obj = (Pagos)lista[0];
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
     * @param Pagos obj
     * @return Retorna la lista de los registros que coinciden
     */
    public Pagos[] buscarPagos(Pagos obj) {
        Pagos[] result=null;
		List<Pagos> lista = null;
        try {
			PagosDao dao = new PagosDao();
            conn = conexion.conectar();
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
     * @param Pagos obj
     * @return Retorna la lista de los registros que coinciden
     */
    public Pagos[] buscarPagos(Pagos obj,int pagina, int numRegPagina) {
        Pagos[] result=null;
		List<Pagos> lista = null;
		if(pagina>0 && numRegPagina>0)
		{
			pagina--;
			int limInf =0;
			int limSup =0;
			limInf = pagina*numRegPagina+1;
			limSup = (pagina+1)*numRegPagina;
			try {
				PagosDao dao = new PagosDao();
				conn = conexion.conectar();
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
     * @param Pagos obj
     * @return Retorna la lista de los registros en la tabla
     */
    public Pagos[] listarPagos() {
        Pagos[] result=null;
		List<Pagos> lista = null;
        try {
			PagosDao dao = new PagosDao();
            conn = conexion.conectar();
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
     * @param Pagos obj
     * @return Retorna la lista de los registros en la tabla con paginacion
     */
	
	public Pagos[] listarPagos(int pagina, int numRegPagina) {
        Pagos[] result=null;
		List<Pagos> lista = null;
		if(pagina>0 && numRegPagina>0)
		{
			pagina--;
			int limInf =0;
			int limSup =0;
			limInf = pagina*numRegPagina+1;
			limSup = (pagina+1)*numRegPagina;
			try {
				PagosDao dao = new PagosDao();
				conn = conexion.conectar();
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
	
	public int contarBusquedaPagos(Pagos obj) {
		int cantidad=-1;
        try {
			PagosDao dao = new PagosDao();
            conn = conexion.conectar();
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
     * @param Pagos obj
     * @return Retorna un boolean indicando si se realizo o no la operacion
     */
    public bool eliminarPagos(Pagos obj) {
        bool resultado;
        resultado = false;
        try {
			PagosDao dao = new PagosDao();
            conn = conexion.conectar();
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

