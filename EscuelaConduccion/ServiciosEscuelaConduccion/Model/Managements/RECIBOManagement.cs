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
using System.Drawing;
using ServiciosEscuelaConduccion.Utilidades;
using ServiciosEscuelaConduccion.Model.Reportes;
using CrystalDecisions.CrystalReports.Engine;
using System.IO;

namespace ServiciosEscuelaConduccion.Model.Managements 
{

	public partial class RECIBOManagement
	{
		AccessDB conexion;
		SqlConnection conn;	
	
		public RECIBOManagement() 
		{
			crearObjetos();
		}
    
		private void crearObjetos()
		{
			conexion = AccessDB.obtenerInstancia();
		}
	
		/**
		 * Inserta nuevo registro en la tabla
		 * @param RECIBO obj
		 * @return Retorna el mismo objeto pero con la llave primaria configurada
		 */
		public RECIBO crearRECIBO(RECIBO obj) 
		{
			List<RECIBO> lista = null;
			try 
			{
				RECIBODao dao = new RECIBODao();
				conn = conexion.conection();
				dao.create(conn, obj);
				//verificar existencia
				lista = dao.search(conn, obj);
				if (lista != null && lista.Count > 0) 
				{
					obj = (RECIBO)lista[0];
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

        public RECIBO generarRECIBO(LIQUIDACION liquidacion, LIQUIDACION_DETALLE[] lstDetalles, VIEW_CLIENTE myCliente)
        {
            List<RECIBO> lista = null;
            dsRecibo dsRecibo = new dsRecibo();

            try
            {
                conn = conexion.conection();
                int numRecibo = Funciones.getId(conn, "RECIBOS");

                DataRow drEscuela = dsRecibo.ESCUELA.NewRow();
                Image logo = Resources.ResourceTmp.LogoConducimos;
                drEscuela["E_LOGO"] = Funciones.Convertir_Imagen_Bytes(logo);
                drEscuela["E_NOMBRE"] = "CENTRO DE ENSE�ANZA AUTOMOVIL�STICA CONDUCIMOS S.A.S";
                drEscuela["E_NUM_RECIBO"] = numRecibo.ToString();
                drEscuela["E_FORMA_PAGO"] = "Efectivo";
                drEscuela["E_SITIO_WEB"] = "www.conducimos.com.co";
                drEscuela["E_NIT"] = "900644828-1";
                drEscuela["E_DIRECCION"] = "CRA 81 # 26-40";
                drEscuela["E_CIUDAD"] = "Medell�n";
                drEscuela["E_TELEFONO"] = "2566295";
                drEscuela["E_CODIGO_CIIU"] = "8559";
                dsRecibo.ESCUELA.Rows.Add(drEscuela);

                DataRow drCliente = dsRecibo.CLIENTE.NewRow();
                drCliente["C_TIPO_DOCUMENTO"] = myCliente.TIPO_DOCUMENTO;
                drCliente["C_NOMBRES_APELLIDOS"] = myCliente.NOMBRES + " " + myCliente.APELLIDOS;
                drCliente["C_IDENTIFICACION"] = myCliente.IDENTIFICACION;
                drCliente["C_DIRECCION"] = myCliente.DIRECCION;
                drCliente["C_CIUDAD"] = myCliente.CIUDAD;
                drCliente["C_TELEFONO"] = myCliente.TELEFONO;
                drCliente["C_EMAIL"] = myCliente.CORREO;
                dsRecibo.CLIENTE.Rows.Add(drCliente);

                TARIFA_CONCEPTOManagement tarifa_conceptoManagement = new TARIFA_CONCEPTOManagement();
                TARIFA_DETALLEManagement tarifa_detalleManagement = new TARIFA_DETALLEManagement();

                foreach (LIQUIDACION_DETALLE dETALLE in lstDetalles)
                {
                    TARIFA_DETALLE tarifaDetalle = new TARIFA_DETALLE();
                    tarifaDetalle.ID = dETALLE.ID_TARIFA_DETALLE;
                    tarifaDetalle = tarifa_detalleManagement.buscarPrimeroTARIFA_DETALLE(tarifaDetalle);
                    if (tarifaDetalle != null && tarifaDetalle.ID_TARIFA_CONCEPTO > 0)
                    {
                        TARIFA_CONCEPTO concepto = new TARIFA_CONCEPTO();
                        concepto.ID = tarifaDetalle.ID_TARIFA_CONCEPTO;
                        concepto = tarifa_conceptoManagement.buscarPrimeroTARIFA_CONCEPTO(concepto);
                        if (concepto != null && concepto.ID > 0)
                        {
                            DataRow drLiquidacion = dsRecibo.LIQUIDACION.NewRow();
                            drLiquidacion["L_CODIGO"] = concepto.CODIGO;
                            drLiquidacion["L_CONCEPTO"] = concepto.NOMBRE;
                            drLiquidacion["L_CANTIDAD"] = 1;
                            drLiquidacion["L_UNIDAD"] = 1;
                            drLiquidacion["L_VALOR"] = dETALLE.VALOR_CONCEPTO;
                            drLiquidacion["L_IVA"] = 0;
                            dsRecibo.LIQUIDACION.Rows.Add(drLiquidacion);
                        }
                    }
                }

                String fileName = "Recibo_" + myCliente.IDENTIFICACION.Trim() + "_No." + numRecibo + "_" + DateTime.Now.ToString("dd-MM-yyyy hh-mm-ss.F") + ".pdf";
                fileName = fileName.Replace('/', '-');
                fileName = fileName.Replace(' ', '_');
                String path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Recibos";
                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);
                path += "\\" + fileName;
                crRecibo reciboCrystal = new crRecibo();
                reciboCrystal.SetDataSource(dsRecibo);
                reciboCrystal.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, path);
                RECIBO recibo = new RECIBO();
                recibo.ARCHIVO_FISICO = File.ReadAllBytes(path);
                recibo.FECHA_RECIBO = DateTime.Now.Date;
                recibo.ID_LIQUIDACION = liquidacion.ID;
                recibo.NUMERO_RECIBO = numRecibo.ToString();
                recibo.VALOR = liquidacion.TOTAL;
                recibo.ID_ESTADO = 1;
                recibo = crearRECIBO(recibo);
                return recibo;
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

        /**
		 * Edita un registro en la tabla
		 * @param RECIBO obj
		 * @return boolean indicando si se realizo o no la actualizacion
		 */
        public bool editarRECIBO(RECIBO obj) 
		{
			bool resultado;
			resultado = false;
			try 
			{
				RECIBODao dao = new RECIBODao();
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
		 * @param RECIBO obj
		 * @return Retorna el mismo objeto pero con los datos consultados
		 */
		public RECIBO buscarPrimeroRECIBO(RECIBO obj) 
		{
			List<RECIBO> lista = null;
			try 
			{
				RECIBODao dao = new RECIBODao();
				conn = conexion.conection();
				lista = dao.search(conn, obj);
				if (lista != null && lista.Count > 0) 
				{
					obj = (RECIBO)lista[0];
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
		 * @param RECIBO obj
		 * @return Retorna la lista de los registros que coinciden
		 */
		public RECIBO[] buscarRECIBO(RECIBO obj) 
		{
			RECIBO[] result=null;
			List<RECIBO> lista = null;
			try 
			{
				RECIBODao dao = new RECIBODao();
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
		 * @param RECIBO obj
		 * @return Retorna la lista de los registros en la tabla
		 */
		public RECIBO[] listarRECIBO() 
		{
			RECIBO[] result=null;
			List<RECIBO> lista = null;
			try 
			{
				RECIBODao dao = new RECIBODao();
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
		 * @param RECIBO obj
		 * @return Retorna un boolean indicando si se realizo o no la operacion
		 */
		public bool eliminarRECIBO(RECIBO obj) 
		{
			bool resultado;
			resultado = false;
			try 
			{
				RECIBODao dao = new RECIBODao();
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

