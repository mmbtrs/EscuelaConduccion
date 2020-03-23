using EscuelaConduccion.Utilidades;
using EscuelaConduccion.wsServiciosCLIENTE;
using EscuelaConduccion.wsServiciosFACTURA;
using EscuelaConduccion.wsServiciosFACTURACONSECUTIVO;
using EscuelaConduccion.wsServiciosFacturaconsecutivodetalle;
using EscuelaConduccion.wsServiciosFormadepago;
using EscuelaConduccion.wsServiciosLIQUIDACION;
using EscuelaConduccion.wsServiciosLIQUIDACION_DETALLE;
using EscuelaConduccion.wsServiciosPagos;
using EscuelaConduccion.WSServiciosRECIBO;
using EscuelaConduccion.wsServiciosRECIBO_ESTADO;
using EscuelaConduccion.wsServiciosVIEW_CLIENTE;
using EscuelaConduccion.wsServiciosViewrecibo;
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
    public partial class frmPagarRecibo : Form
    {
        ServiciosFacturaconsecutivodetalle serviciosFacturaconsecutivodetalle;
        ServiciosPagos serviciosPagos;
        ServiciosFormadepago serviciosFormadepago;
        ServiciosViewrecibo serviciosViewrecibo;
        ServiciosRECIBO serviciosRECIBO;
        ServiciosRECIBO_ESTADO serviciosRECIBO_ESTADO;
        ServiciosCLIENTE serviciosCLIENTE;
        ServiciosFACTURA serviciosFACTURA;
        ServiciosLIQUIDACION serviciosLIQUIDACION;
        ServiciosLIQUIDACION_DETALLE serviciosLIQUIDACION_DETALLE;
        ServiciosVIEW_CLIENTE serviciosVIEW_CLIENTE;
        Viewrecibo recibo;
        RECIBO myRecibo;
        FACTURA factura;

        wsServiciosFacturaconsecutivodetalle.Facturaconsecutivodetalle consecutivo;

        public frmPagarRecibo()
        {
            InitializeComponent();
            serviciosFacturaconsecutivodetalle = (ServiciosFacturaconsecutivodetalle)Configurador.ConfigurarServicio(typeof(ServiciosFacturaconsecutivodetalle));
            serviciosPagos = (ServiciosPagos)Configurador.ConfigurarServicio(typeof(ServiciosPagos));
            serviciosFormadepago = (ServiciosFormadepago)Configurador.ConfigurarServicio(typeof(ServiciosFormadepago));
            serviciosViewrecibo = (ServiciosViewrecibo)Configurador.ConfigurarServicio(typeof(ServiciosViewrecibo));
            serviciosRECIBO = (ServiciosRECIBO)Configurador.ConfigurarServicio(typeof(ServiciosRECIBO));
            serviciosRECIBO_ESTADO = (ServiciosRECIBO_ESTADO)Configurador.ConfigurarServicio(typeof(ServiciosRECIBO_ESTADO));
            serviciosCLIENTE = (ServiciosCLIENTE)Configurador.ConfigurarServicio(typeof(ServiciosCLIENTE));
            serviciosFACTURA = (ServiciosFACTURA)Configurador.ConfigurarServicio(typeof(ServiciosFACTURA));
            serviciosLIQUIDACION = (ServiciosLIQUIDACION)Configurador.ConfigurarServicio(typeof(ServiciosLIQUIDACION));
            serviciosLIQUIDACION_DETALLE = (ServiciosLIQUIDACION_DETALLE)Configurador.ConfigurarServicio(typeof(ServiciosLIQUIDACION_DETALLE));
            serviciosVIEW_CLIENTE = (ServiciosVIEW_CLIENTE)Configurador.ConfigurarServicio(typeof(ServiciosVIEW_CLIENTE));
            iniciarValores();
        }

        public frmPagarRecibo(string numRecibo)
        {
            InitializeComponent();
            serviciosFacturaconsecutivodetalle = (ServiciosFacturaconsecutivodetalle)Configurador.ConfigurarServicio(typeof(ServiciosFacturaconsecutivodetalle));
            serviciosPagos = (ServiciosPagos)Configurador.ConfigurarServicio(typeof(ServiciosPagos));
            serviciosFormadepago = (ServiciosFormadepago)Configurador.ConfigurarServicio(typeof(ServiciosFormadepago));
            serviciosViewrecibo = (ServiciosViewrecibo)Configurador.ConfigurarServicio(typeof(ServiciosViewrecibo));
            serviciosRECIBO = (ServiciosRECIBO)Configurador.ConfigurarServicio(typeof(ServiciosRECIBO));
            serviciosRECIBO_ESTADO = (ServiciosRECIBO_ESTADO)Configurador.ConfigurarServicio(typeof(ServiciosRECIBO_ESTADO));
            serviciosCLIENTE = (ServiciosCLIENTE)Configurador.ConfigurarServicio(typeof(ServiciosCLIENTE));
            serviciosFACTURA = (ServiciosFACTURA)Configurador.ConfigurarServicio(typeof(ServiciosFACTURA));
            serviciosLIQUIDACION = (ServiciosLIQUIDACION)Configurador.ConfigurarServicio(typeof(ServiciosLIQUIDACION));
            serviciosLIQUIDACION_DETALLE = (ServiciosLIQUIDACION_DETALLE)Configurador.ConfigurarServicio(typeof(ServiciosLIQUIDACION_DETALLE));
            serviciosVIEW_CLIENTE = (ServiciosVIEW_CLIENTE)Configurador.ConfigurarServicio(typeof(ServiciosVIEW_CLIENTE));
            iniciarValores();
            txtNumRecibo.Text = numRecibo;
            buscarRecibo();
        }

        private void iniciarValores()
        {
            lblCliente.Text = "";
            lblFacturaDian.Text = "";
            lblTipoPago.Text = "";
            lblValorRecibo.Text = "";
            lblTotal.Text = "$0";
            lblDiferencia.Text = "$0";
            consecutivo = null;
            factura = null;
            initFormaPago();
        }

        private void txtNumRecibo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funciones.esNumero(e);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscarRecibo();
        }

        private void buscarRecibo()
        {
            try
            {
                if (!String.IsNullOrEmpty(txtNumRecibo.Text))
                {
                    iniciarValores();
                    recibo = new Viewrecibo();
                    recibo.NUMERO_RECIBO = txtNumRecibo.Text.Trim();
                    recibo = serviciosViewrecibo.buscarPrimeroViewrecibo(recibo);
                    if (recibo != null && recibo.ID > 0)
                    {
                        if (!String.IsNullOrEmpty(recibo.ESTADO) && recibo.ESTADO == "LIQUIDADO")
                        {
                            lblCliente.Text = recibo.NOMBRES + " " + recibo.APELLIDOS;
                            lblValorRecibo.Text = "$" + recibo.VALOR;
                            lblTipoPago.Text = recibo.TIPO_PAGO;
                            grdFormaPago.Rows[0].Cells["valor"].Value = recibo.VALOR;
                            calcularDiferencia();
                            btnPagar.Enabled = true;
                        }
                        else
                        {
                            btnPagar.Enabled = false;
                            btnVerRecibo.Enabled = false;
                            MessageBox.Show("El recibo No." + recibo.NUMERO_RECIBO + " no se encuentra en estado LIQUIDADO", "Recibo incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        btnPagar.Enabled = false;
                        btnVerRecibo.Enabled = false;
                        MessageBox.Show("El recibo de número " + txtNumRecibo.Text.Trim() + " no fue encontrado", "No encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    txtNumRecibo.Focus();
                    MessageBox.Show("Debe digitar el número de recibo", "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception exp)
            {
            }
        }

        private void calcularDiferencia()
        {
            double valor;
            if (recibo != null && recibo.VALOR > 0)
                valor = recibo.VALOR;
            else
                valor = 0;
            double diferencia;
            double total = 0;
            double tmp = 0;
            for (int i = 0; i < grdFormaPago.Rows.Count; i++)
            {
                double.TryParse(grdFormaPago.Rows[i].Cells["valor"].Value.ToString(), out tmp);
                total += tmp;
            }
            diferencia = total - valor;
            lblTotal.Text = "$" + total;
            lblDiferencia.Text = "$" + diferencia;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void initFormaPago()
        {
            Formadepago[] formadepago = serviciosFormadepago.listarFormadepago();
            grdFormaPago.Rows.Clear();

            if (formadepago != null && formadepago.Length > 0)
            {
                foreach (Formadepago item in formadepago)
                {
                    grdFormaPago.Rows.Add(item.ID, item.FORMA_PAGO, "0");
                }
            }
        }

        private void grdFormaPago_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            calcularDiferencia();
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            validarPago();
        }

        private void validarPago()
        {
            getNumFactura();
            if (consecutivo != null && consecutivo.ID > 0)
                pagarRecibo();
            else
            {
                if (MessageBox.Show("No quedan consecutivos de facturas por lo tanto no se puede generar una factura. ¿Desea continuar con el pago sin generar factura?", "Continuar sin factura", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    pagarRecibo();
            }
        }

        private void pagarRecibo()
        {
            try
            {
                double valorTmp = 0;
                double valor = recibo.VALOR;
                Pagos pago;
                DateTime fechaPago = datFechaPago.Value;
                foreach (DataGridViewRow fila in grdFormaPago.Rows)
                {
                    if (!fila.Cells["valor"].Value.ToString().Equals("0"))
                    {
                        double diferencia;
                        pago = new Pagos();
                        pago.FECHA_PAGO = fechaPago;
                        pago.ID_RECIBO = recibo.ID;
                        pago.ID_FORMAPAGO = int.Parse(fila.Cells["ID"].Value.ToString());
                        pago.VALOR = double.Parse(fila.Cells["valor"].Value.ToString());
                        valorTmp += pago.VALOR;
                        if (valorTmp > valor)
                        {
                            diferencia = valorTmp - valor;
                            pago.VALOR = pago.VALOR - diferencia;
                            serviciosPagos.crearPagos(pago);
                            break;
                        }
                        serviciosPagos.crearPagos(pago);
                    }
                }
                recibo.ID_ESTADO = 2;
                myRecibo = new RECIBO();
                myRecibo.ID = recibo.ID;
                myRecibo = serviciosRECIBO.buscarPrimeroRECIBO(myRecibo);
                if (myRecibo != null && myRecibo.ID > 0)
                {
                    myRecibo.ID_ESTADO = 2;
                    myRecibo.FECHA_PAGO = fechaPago;
                    serviciosRECIBO.editarRECIBO(myRecibo);
                }
                MessageBox.Show("Pago realizado correctamente", "Pago correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnPagar.Enabled = false;
            }
            catch (Exception exp)
            {
                MessageBox.Show("Se presento el siguiente error: " + exp.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void getNumFactura()
        {
            try
            {
                consecutivo = serviciosFacturaconsecutivodetalle.obtenerFacturaconsecutivodetalle();
                if (consecutivo != null && consecutivo.ID > 0)
                {
                    lblFacturaDian.Text = consecutivo.CONSECUTIVO.ToString();
                    btnVerRecibo.Enabled = true;
                }
                else
                {
                    lblFacturaDian.Text = "";
                    btnVerRecibo.Enabled = false;
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Se presento el siguiente error: " + exp.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVerRecibo_Click(object sender, EventArgs e)
        {
            verFactura();
        }

        private void verFactura()
        {
            try
            {
                if (myRecibo != null && myRecibo.ID > 0)
                {
                    wsServiciosLIQUIDACION.LIQUIDACION liquidacion = new wsServiciosLIQUIDACION.LIQUIDACION();
                    liquidacion.ID = myRecibo.ID_LIQUIDACION;
                    liquidacion = serviciosLIQUIDACION.buscarPrimeroLIQUIDACION(liquidacion);

                    if (liquidacion != null && liquidacion.ID > 0)
                    {
                        var liquidacionSerializado = JsonConvert.SerializeObject(liquidacion);
                        wsServiciosFACTURA.LIQUIDACION liquidacionDesserializado = JsonConvert.DeserializeObject<wsServiciosFACTURA.LIQUIDACION>(liquidacionSerializado);

                        wsServiciosLIQUIDACION_DETALLE.LIQUIDACION_DETALLE liqDetalle = new wsServiciosLIQUIDACION_DETALLE.LIQUIDACION_DETALLE();
                        liqDetalle.ID_LIQUIDACION = liquidacion.ID;
                        wsServiciosLIQUIDACION_DETALLE.LIQUIDACION_DETALLE[] lstDetalles = serviciosLIQUIDACION_DETALLE.buscarLIQUIDACION_DETALLE(liqDetalle);

                        if (lstDetalles != null && lstDetalles.Length > 0)
                        {
                            wsServiciosFACTURA.LIQUIDACION_DETALLE[] lstLiquidacionDetalle = new wsServiciosFACTURA.LIQUIDACION_DETALLE[lstDetalles.Length];
                            int i = 0;
                            foreach (wsServiciosLIQUIDACION_DETALLE.LIQUIDACION_DETALLE item in lstDetalles)
                            {
                                var detalleSerializado = JsonConvert.SerializeObject(item);
                                wsServiciosFACTURA.LIQUIDACION_DETALLE detalleDesserializado = JsonConvert.DeserializeObject<wsServiciosFACTURA.LIQUIDACION_DETALLE>(detalleSerializado);
                                lstLiquidacionDetalle[i] = detalleDesserializado;
                                i++;
                            }

                            wsServiciosVIEW_CLIENTE.VIEW_CLIENTE myCliente = new wsServiciosVIEW_CLIENTE.VIEW_CLIENTE();
                            myCliente.ID = liquidacion.ID_CLIENTE;
                            myCliente = serviciosVIEW_CLIENTE.buscarPrimeroVIEW_CLIENTE(myCliente);

                            if (myCliente != null && myCliente.ID > 0)
                            {
                                var clienteSerializado = JsonConvert.SerializeObject(myCliente);
                                wsServiciosFACTURA.VIEW_CLIENTE clienteDesserializado = JsonConvert.DeserializeObject<wsServiciosFACTURA.VIEW_CLIENTE>(clienteSerializado);

                                var consecutivoSerializado = JsonConvert.SerializeObject(consecutivo);
                                wsServiciosFACTURA.Facturaconsecutivodetalle consecutivoDesserializado = JsonConvert.DeserializeObject<wsServiciosFACTURA.Facturaconsecutivodetalle>(consecutivoSerializado);

                                factura = serviciosFACTURA.generarFACTURA(liquidacionDesserializado, lstLiquidacionDetalle, clienteDesserializado, consecutivoDesserializado);
                                if (factura != null && factura.ID > 0 && factura.ARCHIVO_FISICO != null && factura.ARCHIVO_FISICO.Length > 0)
                                {
                                    String fileName = "CopiaFactura_No." + factura.NUMERO_FACTURA + "_" + DateTime.Now.ToString("dd-MM-yyyy hh-mm-ss.F") + ".pdf";
                                    fileName = fileName.Replace('/', '-');
                                    fileName = fileName.Replace(' ', '_');
                                    String path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Facturas"; 
                                    if (!Directory.Exists(path))
                                        Directory.CreateDirectory(path);
                                    path += "\\" + fileName;
                                    File.WriteAllBytes(path, factura.ARCHIVO_FISICO);
                                    Process.Start(path);
                                    btnVerRecibo.Enabled = false;
                                }
                                else
                                    MessageBox.Show("Ocurrio un error y no se genero la factura correctamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                                MessageBox.Show("No se encontró la información del cliente asociado a la liquidación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                            MessageBox.Show("No se encontró una el detalle de la liquidación asociada al proceso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                        MessageBox.Show("No se encontró una liquidación asociada al proceso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("No se encontró el recibo con el que se realizó el pago", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception exp)
            {

            }
        }
    }
}
