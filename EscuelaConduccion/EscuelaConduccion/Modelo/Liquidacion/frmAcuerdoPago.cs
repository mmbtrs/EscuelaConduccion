using EscuelaConduccion.wsServiciosACUERDO_ESTADO;
using EscuelaConduccion.wsServiciosACUERDO_PAGO;
using EscuelaConduccion.wsServiciosACUERDO_PAGO_DETALLE;
using EscuelaConduccion.wsServiciosLIQUIDACION;
using EscuelaConduccion.WSServiciosRECIBO;
using EscuelaConduccion.wsServiciosSQL;
using EscuelaConduccion.wsServiciosTIPO_LIQUIDACION;
using EscuelaConduccion.wsServiciosVIEW_CLIENTE;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UtilidadesServiciosWeb;

namespace EscuelaConduccion.Modelo.Liquidacion
{
    public partial class frmAcuerdoPago : Form
    {
        ServiciosLIQUIDACION serviciosLIQUIDACION;
        ServiciosACUERDO_PAGO serviciosACUERDO_PAGO;
        ServiciosACUERDO_PAGO_DETALLE serviciosACUERDO_PAGO_DETALLE;
        ServiciosACUERDO_ESTADO serviciosACUERDO_ESTADO;
        ServiciosSQL serviciosSQL;
        ServiciosVIEW_CLIENTE serviciosVIEW_CLIENTE;
        ServiciosRECIBO serviciosRECIBO;
        ServiciosTIPO_LIQUIDACION serviciosTIPO_LIQUIDACION;

        ACUERDO_PAGO myAcuerdo;
        RECIBO myRecibo;
        wsServiciosLIQUIDACION.LIQUIDACION myLiquidacion;
        wsServiciosVIEW_CLIENTE.VIEW_CLIENTE view_myCliente;

        public frmAcuerdoPago(ACUERDO_PAGO acuerdo)
        {
            InitializeComponent();
            serviciosLIQUIDACION = (ServiciosLIQUIDACION)Configurador.ConfigurarServicio(typeof(ServiciosLIQUIDACION));
            serviciosACUERDO_PAGO = (ServiciosACUERDO_PAGO)Configurador.ConfigurarServicio(typeof(ServiciosACUERDO_PAGO));
            serviciosACUERDO_PAGO_DETALLE = (ServiciosACUERDO_PAGO_DETALLE)Configurador.ConfigurarServicio(typeof(ServiciosACUERDO_PAGO_DETALLE));
            serviciosACUERDO_ESTADO = (ServiciosACUERDO_ESTADO)Configurador.ConfigurarServicio(typeof(ServiciosACUERDO_ESTADO));
            serviciosSQL = (ServiciosSQL)Configurador.ConfigurarServicio(typeof(ServiciosSQL));
            serviciosVIEW_CLIENTE = (ServiciosVIEW_CLIENTE)Configurador.ConfigurarServicio(typeof(ServiciosVIEW_CLIENTE));
            serviciosRECIBO = (ServiciosRECIBO)Configurador.ConfigurarServicio(typeof(ServiciosRECIBO));
            serviciosTIPO_LIQUIDACION = (ServiciosTIPO_LIQUIDACION)Configurador.ConfigurarServicio(typeof(ServiciosTIPO_LIQUIDACION));
            myAcuerdo = acuerdo;
            myRecibo = null;
            setInfo();
        }
        
        private void setInfo()
        {
            try
            {
                limpiarCampos();
                myLiquidacion = new wsServiciosLIQUIDACION.LIQUIDACION();
                myLiquidacion.ID = myAcuerdo.ID_LIQUIDACION;
                myLiquidacion = serviciosLIQUIDACION.buscarPrimeroLIQUIDACION(myLiquidacion);
                if (myLiquidacion != null && myLiquidacion.ID > 0)
                {
                    view_myCliente = new wsServiciosVIEW_CLIENTE.VIEW_CLIENTE();
                    view_myCliente.ID = myLiquidacion.ID_CLIENTE;
                    view_myCliente = serviciosVIEW_CLIENTE.buscarPrimeroVIEW_CLIENTE(view_myCliente);
                    if (view_myCliente != null && view_myCliente.ID > 0)
                    {
                        ACUERDO_ESTADO estado = new ACUERDO_ESTADO();
                        estado.ID = myAcuerdo.ID_ACUERDO_ESTADO;
                        estado = serviciosACUERDO_ESTADO.buscarPrimeroACUERDO_ESTADO(estado);
                        lblFechaAcuerdo.Text = myAcuerdo.FECHA_ACUERDO.ToString("dd/MM/yyyy");
                        if (estado != null && estado.ID > 0)
                            lblEstadoAcuerdo.Text = estado.NOMBRE;
                        else
                            lblEstadoAcuerdo.Text = "";
                        lblTipoDocumento.Text = view_myCliente.TIPO_DOCUMENTO;
                        lblNumeroDocumento.Text = view_myCliente.IDENTIFICACION;
                        lblNombres.Text = view_myCliente.NOMBRES;
                        lblApellidos.Text = view_myCliente.APELLIDOS;
                        lblNumAcuerdo.Text = myAcuerdo.NUMERO_ACUERDO;
                        lblTotalDeuda.Text = "$" + myLiquidacion.TOTAL;
                        getCuotas();
                    }
                    else
                    {
                        MessageBox.Show("No se encontró el cliente asociado al acuerdo de pago", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        btnGenerarRecibo.Enabled = false;
                    }
                }
                else
                {
                    MessageBox.Show("No se encontró la liquidación asociada al acuerdo de pago", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnGenerarRecibo.Enabled = false;
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Se presentó el siguiente error: " + exp.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnGenerarRecibo.Enabled = false;
            }
        }

        private void getCuotas()
        {
            try
            {
                string sql =
                    @"SELECT 
                    ACUERDO_PAGO_DETALLE.ID,
                    ACUERDO_PAGO_DETALLE.NUMERO_CUOTA AS CUOTA,
                    ACUERDO_PAGO_DETALLE.VALOR,
                    RECIBO_ESTADO.ESTADO,
                    RECIBO.NUMERO_RECIBO,
                    ACUERDO_PAGO_DETALLE.FECHA_LIMITE_PAGO
                    FROM
                    ACUERDO_PAGO_DETALLE
                    LEFT JOIN RECIBO ON (ACUERDO_PAGO_DETALLE.ID_RECIBO = RECIBO.ID)
                    LEFT JOIN RECIBO_ESTADO ON (RECIBO.ID_ESTADO = RECIBO_ESTADO.ID)
                    WHERE 
                    ACUERDO_PAGO_DETALLE.ID_ACUERDO_PAGO = " + myAcuerdo.ID;
                grdCuotas.Rows.Clear();
                DataSet ds = serviciosSQL.consultaSQL(sql, "cuotas");
                if (ds != null && ds.Tables != null && ds.Tables["cuotas"] != null && ds.Tables["cuotas"].Rows.Count > 0)
                {
                    for (int i = 0; i < ds.Tables["cuotas"].Rows.Count; i++)
                    {
                        grdCuotas.Rows.Add(ds.Tables["cuotas"].Rows[i]["ID"].ToString(),
                                            ds.Tables["cuotas"].Rows[i]["CUOTA"].ToString(),
                                            ds.Tables["cuotas"].Rows[i]["VALOR"].ToString(),
                                            ds.Tables["cuotas"].Rows[i]["ESTADO"].ToString(),
                                            ds.Tables["cuotas"].Rows[i]["NUMERO_RECIBO"].ToString(),
                                            ds.Tables["cuotas"].Rows[i]["FECHA_LIMITE_PAGO"].ToString());
                    }
                    btnGenerarRecibo.Enabled = true;
                }
                else
                {
                    MessageBox.Show("No se encontraron las cuotas del acuerdo de pago", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnGenerarRecibo.Enabled = false;
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Se presentó el siguiente error: " + exp.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnGenerarRecibo.Enabled = false;
            }
        }

        private void limpiarCampos()
        {
            lblFechaAcuerdo.Text = "";
            lblEstadoAcuerdo.Text = "";
            lblTipoDocumento.Text = "";
            lblNumeroDocumento.Text = "";
            lblNombres.Text = "";
            lblApellidos.Text = "";
            lblNumAcuerdo.Text = "";
            lblTotalDeuda.Text = "$0";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGenerarRecibo_Click(object sender, EventArgs e)
        {
            generarRecibo();
        }

        private void generarRecibo()
        {
            try
            {
                myRecibo = liquidarCuota();
                if (myRecibo != null && myRecibo.ID > 0 && myRecibo.ARCHIVO_FISICO != null && myRecibo.ARCHIVO_FISICO.Length > 0)
                {
                    String fileName = "CopiaRecibo_No." + myRecibo.NUMERO_RECIBO + "_" + DateTime.Now.ToString("dd-MM-yyyy hh-mm-ss.F") + ".pdf";
                    fileName = fileName.Replace('/', '-');
                    fileName = fileName.Replace(' ', '_');
                    String path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Recibos";
                    if (!Directory.Exists(path))
                        Directory.CreateDirectory(path);
                    path += "\\" + fileName;
                    File.WriteAllBytes(path, myRecibo.ARCHIVO_FISICO);
                    Process.Start(path);
                    int idCuota = int.Parse(grdCuotas.SelectedRows[0].Cells["ID"].Value.ToString());
                    ACUERDO_PAGO_DETALLE detalle = new ACUERDO_PAGO_DETALLE();
                    detalle.ID = idCuota;
                    detalle = serviciosACUERDO_PAGO_DETALLE.buscarPrimeroACUERDO_PAGO_DETALLE(detalle);
                    if (detalle != null && detalle.ID > 0)
                    {
                        detalle.ID_RECIBO = myRecibo.ID;
                        serviciosACUERDO_PAGO_DETALLE.editarACUERDO_PAGO_DETALLE(detalle);
                        getCuotas();
                    }
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Se presentó el siguiente error: " + exp.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private RECIBO liquidarCuota()
        {
            RECIBO recibo;
            wsServiciosLIQUIDACION.LIQUIDACION_DETALLE[] lstDetalles = new wsServiciosLIQUIDACION.LIQUIDACION_DETALLE[1];
            if (grdCuotas.Rows != null && grdCuotas.Rows.Count > 0 && grdCuotas.SelectedRows != null && grdCuotas.SelectedRows.Count > 0 &&
                view_myCliente != null && view_myCliente.ID > 0)
            {
                if (grdCuotas.SelectedRows[0].Cells["NUMERO_RECIBO"].Value != null &&
                    String.IsNullOrEmpty(grdCuotas.SelectedRows[0].Cells["NUMERO_RECIBO"].Value.ToString()) || String.IsNullOrWhiteSpace(grdCuotas.SelectedRows[0].Cells["NUMERO_RECIBO"].Value.ToString()))
                {
                    //***********************************************************************
                    String sql =
                        @"SELECT 
                        TARIFA_DETALLE.ID
                        FROM
                        TARIFA_DETALLE
                        INNER JOIN TARIFA_CONCEPTO ON (TARIFA_DETALLE.ID_TARIFA_CONCEPTO = TARIFA_CONCEPTO.ID)
                        WHERE 
                        TARIFA_CONCEPTO.NOMBRE = 'CUOTA ACUERDO PAGO'";
                    DataSet ds = serviciosSQL.consultaSQL(sql, "id");
                    if (ds != null && ds.Tables != null && ds.Tables["id"] != null && ds.Tables["id"].Rows.Count > 0)
                    {
                        wsServiciosLIQUIDACION.LIQUIDACION_DETALLE detalle = new wsServiciosLIQUIDACION.LIQUIDACION_DETALLE();
                        detalle.ID_TARIFA_DETALLE = int.Parse(ds.Tables["id"].Rows[0][0].ToString());
                        detalle.VALOR_CONCEPTO = float.Parse(grdCuotas.SelectedRows[0].Cells["VALOR"].Value.ToString());
                        lstDetalles[0] = detalle;
                        //************************************************************************
                        wsServiciosLIQUIDACION.LIQUIDACION liquidacion = new wsServiciosLIQUIDACION.LIQUIDACION();
                        liquidacion.ID_CLIENTE = view_myCliente.ID;
                        TIPO_LIQUIDACION tipo = new TIPO_LIQUIDACION();
                        tipo.TIPO = "AP";
                        tipo = serviciosTIPO_LIQUIDACION.buscarPrimeroTIPO_LIQUIDACION(tipo);
                        if (tipo != null && tipo.ID > 0)
                            liquidacion.ID_TIPO_LIQUIDACION = tipo.ID;
                        liquidacion.TOTAL = float.Parse(grdCuotas.SelectedRows[0].Cells["VALOR"].Value.ToString());

                        var clienteSerializado = JsonConvert.SerializeObject(view_myCliente);
                        wsServiciosLIQUIDACION.VIEW_CLIENTE clienteDesserializado = JsonConvert.DeserializeObject<wsServiciosLIQUIDACION.VIEW_CLIENTE>(clienteSerializado);

                        liquidacion = serviciosLIQUIDACION.crearMultipleLIQUIDACION_2(liquidacion, lstDetalles, clienteDesserializado);
                        if (liquidacion != null && liquidacion.ID > 0)
                        {
                            WSServiciosRECIBO.ServiciosRECIBO servicio = new WSServiciosRECIBO.ServiciosRECIBO();

                            var liquidacionSerializado = JsonConvert.SerializeObject(liquidacion);
                            WSServiciosRECIBO.LIQUIDACION liquidacionDesserializado = JsonConvert.DeserializeObject<WSServiciosRECIBO.LIQUIDACION>(liquidacionSerializado);

                            WSServiciosRECIBO.LIQUIDACION_DETALLE[] lstLiquidacionDetalle = new WSServiciosRECIBO.LIQUIDACION_DETALLE[1];
                            var detalleSerializado = JsonConvert.SerializeObject(lstDetalles[0]);
                            WSServiciosRECIBO.LIQUIDACION_DETALLE detalleDesserializado = JsonConvert.DeserializeObject<WSServiciosRECIBO.LIQUIDACION_DETALLE>(detalleSerializado);
                            lstLiquidacionDetalle[0] = detalleDesserializado;

                            clienteSerializado = JsonConvert.SerializeObject(clienteDesserializado);
                            WSServiciosRECIBO.VIEW_CLIENTE clienteTmp = JsonConvert.DeserializeObject<WSServiciosRECIBO.VIEW_CLIENTE>(clienteSerializado);

                            recibo = servicio.generarRECIBO(liquidacionDesserializado, lstLiquidacionDetalle, clienteTmp);
                            if (recibo != null && recibo.ID > 0)
                            {
                                MessageBox.Show("Liquidación realizada correctamente", "Liquidación correcta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return recibo;
                            }
                            else
                            {
                                MessageBox.Show("Ocurrio algún problema y la liquidación fue incorrecta", "Liquidación incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return null;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Ocurrio un error desconocido y la liquidación no se realizó correctamente", "Liquidación incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return null;
                        }
                    }
                    else
                    {
                        MessageBox.Show("La liquidación no puede continuar ya que no se a configurado el concepto y el detalle de la tarifa para CUOTA ACUERDO PAGO", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return null;
                    }
                }
                else
                {
                    if (grdCuotas.SelectedRows[0].Cells["NUMERO_RECIBO"].Value != null &&
                        !String.IsNullOrEmpty(grdCuotas.SelectedRows[0].Cells["NUMERO_RECIBO"].Value.ToString()) &&
                        !String.IsNullOrWhiteSpace(grdCuotas.SelectedRows[0].Cells["NUMERO_RECIBO"].Value.ToString()))
                    {
                        recibo = new RECIBO();
                        recibo.NUMERO_RECIBO = grdCuotas.SelectedRows[0].Cells["NUMERO_RECIBO"].Value.ToString();
                        recibo = serviciosRECIBO.buscarPrimeroRECIBO(recibo);
                        return recibo;
                    }
                    else
                        return null;
                }
            }
            else
            {
                MessageBox.Show("No se seleccionó ningúna cuota de la lista", "Seleccione una cuota", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }
        }
    }
}
