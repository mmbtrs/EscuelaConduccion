using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Collections;

using ServiciosEscuelaConduccion.Model.DataAccess;
using ServiciosEscuelaConduccion.Model.DAO;
using ServiciosEscuelaConduccion.Model.Objects;
using ServiciosEscuelaConduccion.Model.Reportes;
using System.Data;
using System.Drawing;
using ServiciosEscuelaConduccion.Utilidades;
using ServiciosEscuelaConduccion.objetos;
using System.IO;
using System.Globalization;

namespace ServiciosEscuelaConduccion.Model.Managements 
{

	public partial class FACTURAManagement
	{
		AccessDB conexion;
		SqlConnection conn;
        FACTURACONSECUTIVOManagement facturaConsecutivoManagement;
        FACTURAManagement facturaManagement;
	
		public FACTURAManagement() 
		{
			crearObjetos();
		}
    
		private void crearObjetos()
		{
			conexion = AccessDB.obtenerInstancia();
		}
	
		/**
		 * Inserta nuevo registro en la tabla
		 * @param FACTURA obj
		 * @return Retorna el mismo objeto pero con la llave primaria configurada
		 */
		public FACTURA crearFACTURA(FACTURA obj) 
		{
			List<FACTURA> lista = null;
			try 
			{
				FACTURADao dao = new FACTURADao();
				conn = conexion.conection();
				dao.create(conn, obj);
                //verificar existencia
                FACTURA objNew = new FACTURA();
                objNew.DISPONIBLE = obj.DISPONIBLE;
                objNew.ID_FACTURA_ESTADO = obj.ID_FACTURA_ESTADO;
                objNew.ID_LIQUIDACION = obj.ID_LIQUIDACION;
                objNew.NUMERO_FACTURA = obj.NUMERO_FACTURA;
				lista = dao.search(conn, obj);
				if (lista != null && lista.Count > 0) 
				{
					obj = (FACTURA)lista[0];
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

        public FACTURA generarFACTURA(LIQUIDACION liquidacion, LIQUIDACION_DETALLE[] lstDetalles, VIEW_CLIENTE myCliente, Facturaconsecutivodetalle rango)
        {
            List<RECIBO> lista = null;
            dsFactura dsFactura = new dsFactura();
            FACTURACONSECUTIVO facturaConsecutivo = new FACTURACONSECUTIVO();
            facturaConsecutivoManagement = new FACTURACONSECUTIVOManagement();
            facturaManagement = new FACTURAManagement();
            facturaConsecutivo.ID = rango.ID_FACTURACONSECUTIVO;
            facturaConsecutivo = facturaConsecutivoManagement.buscarPrimeroFACTURACONSECUTIVO(facturaConsecutivo);
            try
            {
                conn = conexion.conection();
                //int numRecibo = Funciones.getId(conn, "RECIBOS");

                DataRow drEscuela = dsFactura.ESCUELA.NewRow();
                Image logo = Resources.ResourceTmp.LogoConducimos;
                drEscuela["E_LOGO"] = Funciones.Convertir_Imagen_Bytes(logo);
                drEscuela["E_NOMBRE"] = "CENTRO DE ENSEÑANZA AUTOMOVILÍSTICA CONDUCIMOS S.A.S";
                drEscuela["E_NUM_RECIBO"] = rango.CONSECUTIVO;// myFactura.NUMERO_FACTURA.ToString();
                drEscuela["E_FORMA_PAGO"] = "Efectivo";
                drEscuela["E_SITIO_WEB"] = "www.conducimos.com.co";
                drEscuela["E_NIT"] = "900644828-1";
                drEscuela["E_DIRECCION"] = "CRA 81 # 26-40";
                drEscuela["E_CIUDAD"] = "Medellín";
                drEscuela["E_TELEFONO"] = "2566295";
                drEscuela["E_CODIGO_CIIU"] = "8559";
                if (facturaConsecutivo != null && facturaConsecutivo.ID > 0)
                {
                    drEscuela["E_NUM_RESOLUCION"] = facturaConsecutivo.RESOLUCION;
                    drEscuela["E_FECHA_RESOLUCION"] = facturaConsecutivo.FECHA_RESOLUCION.ToString("dd MMMM yyyy", CultureInfo.CreateSpecificCulture("es-MX"));
                    drEscuela["E_RANGO_INICIAL"] = facturaConsecutivo.RANGO_INICIAL;
                    drEscuela["E_RANGO_FINAL"] = facturaConsecutivo.RANGO_FINAL;
                }
                dsFactura.ESCUELA.Rows.Add(drEscuela);

                DataRow drCliente = dsFactura.CLIENTE.NewRow();
                drCliente["C_TIPO_DOCUMENTO"] = myCliente.TIPO_DOCUMENTO;
                drCliente["C_NOMBRES_APELLIDOS"] = myCliente.NOMBRES + " " + myCliente.APELLIDOS;
                drCliente["C_IDENTIFICACION"] = myCliente.IDENTIFICACION;
                drCliente["C_DIRECCION"] = myCliente.DIRECCION;
                drCliente["C_CIUDAD"] = myCliente.CIUDAD;
                drCliente["C_TELEFONO"] = myCliente.TELEFONO;
                drCliente["C_EMAIL"] = myCliente.CORREO;
                dsFactura.CLIENTE.Rows.Add(drCliente);

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
                            DataRow drLiquidacion = dsFactura.LIQUIDACION.NewRow();
                            drLiquidacion["L_CODIGO"] = concepto.CODIGO;
                            drLiquidacion["L_CONCEPTO"] = concepto.NOMBRE;
                            drLiquidacion["L_CANTIDAD"] = 1;
                            drLiquidacion["L_UNIDAD"] = 1;
                            drLiquidacion["L_VALOR"] = dETALLE.VALOR_CONCEPTO;
                            drLiquidacion["L_IVA"] = 0;
                            dsFactura.LIQUIDACION.Rows.Add(drLiquidacion);
                        }
                    }
                }

                String fileName = "Factura_" + myCliente.IDENTIFICACION.Trim() + "_No." + rango.CONSECUTIVO + "_" + DateTime.Now.ToString("dd-MM-yyyy hh-mm-ss.F") + ".pdf";
                fileName = fileName.Replace('/', '-');
                fileName = fileName.Replace(' ', '_');
                String path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Facturas";
                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);
                path += "\\" + fileName;
                crFactura facturaCrystal = new crFactura();
                facturaCrystal.SetDataSource(dsFactura);
                facturaCrystal.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, path);
                FACTURA factura = new FACTURA();
                factura.ARCHIVO_FISICO = File.ReadAllBytes(path);
                factura.ID_FACTURA_ESTADO = 1;
                factura.ID_LIQUIDACION = liquidacion.ID;
                factura.NUMERO_FACTURA = rango.CONSECUTIVO.ToString();
                factura.DISPONIBLE = "NO";
                factura = facturaManagement.crearFACTURA(factura);
                return factura;
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
		 * @param FACTURA obj
		 * @return boolean indicando si se realizo o no la actualizacion
		 */
        public bool editarFACTURA(FACTURA obj) 
		{
			bool resultado;
			resultado = false;
			try 
			{
				FACTURADao dao = new FACTURADao();
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
		 * @param FACTURA obj
		 * @return Retorna el mismo objeto pero con los datos consultados
		 */
		public FACTURA buscarPrimeroFACTURA(FACTURA obj) 
		{
			List<FACTURA> lista = null;
			try 
			{
				FACTURADao dao = new FACTURADao();
				conn = conexion.conection();
				lista = dao.search(conn, obj);
				if (lista != null && lista.Count > 0) 
				{
					obj = (FACTURA)lista[0];
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
		 * @param FACTURA obj
		 * @return Retorna la lista de los registros que coinciden
		 */
		public FACTURA[] buscarFACTURA(FACTURA obj) 
		{
			FACTURA[] result=null;
			List<FACTURA> lista = null;
			try 
			{
				FACTURADao dao = new FACTURADao();
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
		 * @param FACTURA obj
		 * @return Retorna la lista de los registros en la tabla
		 */
		public FACTURA[] listarFACTURA() 
		{
			FACTURA[] result=null;
			List<FACTURA> lista = null;
			try 
			{
				FACTURADao dao = new FACTURADao();
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
		 * @param FACTURA obj
		 * @return Retorna un boolean indicando si se realizo o no la operacion
		 */
		public bool eliminarFACTURA(FACTURA obj) 
		{
			bool resultado;
			resultado = false;
			try 
			{
				FACTURADao dao = new FACTURADao();
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

