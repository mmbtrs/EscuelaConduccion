using EscuelaConduccion.wsServiciosFACTURA;
using EscuelaConduccion.wsServiciosFACTURA_ESTADO;
using EscuelaConduccion.WSServiciosRECIBO;
using EscuelaConduccion.wsServiciosRECIBO_ESTADO;
using EscuelaConduccion.wsServiciosTIPO_DOCUMENTO;
using EscuelaConduccion.wsServiciosViewliquidacion;
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
    public partial class frmBuscarReciboFactura : Form
    {
        ServiciosTIPO_DOCUMENTO serviciosTIPO_DOCUMENTO;
        ServiciosRECIBO_ESTADO serviciosRECIBO_ESTADO;
        ServiciosViewliquidacion serviciosViewliquidacion;
        ServiciosRECIBO serviciosRECIBO;
        ServiciosFACTURA serviciosFACTURA;
        ServiciosFACTURA_ESTADO serviciosFACTURA_ESTADO;

        public frmBuscarReciboFactura()
        {
            InitializeComponent();
            serviciosTIPO_DOCUMENTO = (ServiciosTIPO_DOCUMENTO)Configurador.ConfigurarServicio(typeof(ServiciosTIPO_DOCUMENTO));
            serviciosRECIBO_ESTADO = (ServiciosRECIBO_ESTADO)Configurador.ConfigurarServicio(typeof(ServiciosRECIBO_ESTADO));
            serviciosViewliquidacion = (ServiciosViewliquidacion)Configurador.ConfigurarServicio(typeof(ServiciosViewliquidacion));
            serviciosFACTURA = (ServiciosFACTURA)Configurador.ConfigurarServicio(typeof(ServiciosFACTURA));
            serviciosRECIBO = (ServiciosRECIBO)Configurador.ConfigurarServicio(typeof(ServiciosRECIBO));
            serviciosFACTURA_ESTADO = (ServiciosFACTURA_ESTADO)Configurador.ConfigurarServicio(typeof(ServiciosFACTURA_ESTADO));

            getTiposDocumento();
            getRecibosEstado();
        }

        private void chkRecibo_CheckedChanged(object sender, EventArgs e)
        {
            habilitarPanel(sender, panRecibo);
        }

        private void chkFactura_CheckedChanged(object sender, EventArgs e)
        {
            habilitarPanel(sender, panFactura);
        }

        private void habilitarPanel(object sender, Panel panel)
        {
            if (((CheckBox)sender).Checked)
            {
                panel.Enabled = true;
                panel.Focus();
            }
            else
                panel.Enabled = false;
        }

        private void chkCliente_CheckedChanged(object sender, EventArgs e)
        {
            habilitarPanel(sender, panCliente);
        }

        private void chkEstado_CheckedChanged(object sender, EventArgs e)
        {
            habilitarPanel(sender, panEstado);
        }

        private void chkFechaLiquidacion_CheckedChanged(object sender, EventArgs e)
        {
            habilitarPanel(sender, panFechaLiquidacion);
        }

        private void chkFechaPago_CheckedChanged(object sender, EventArgs e)
        {
            habilitarPanel(sender, panFechaPago);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void getTiposDocumento()
        {
            try
            {
                TIPO_DOCUMENTO[] lstTipos = serviciosTIPO_DOCUMENTO.listarTIPO_DOCUMENTO();
                if (lstTipos != null && lstTipos.Length > 0)
                {
                    cmbTipoDocumento.Items.Clear();
                    foreach (TIPO_DOCUMENTO item in lstTipos)
                    {
                        cmbTipoDocumento.Items.Add(item);
                    }
                    cmbTipoDocumento.SelectedIndex = 0;
                }
            }
            catch (Exception exp)
            {
            }
        }

        private void getRecibosEstado()
        {
            try
            {
                RECIBO_ESTADO[] lstEstados = serviciosRECIBO_ESTADO.listarRECIBO_ESTADO();
                if (lstEstados != null && lstEstados.Length > 0)
                {
                    cmbEstado.Items.Clear();
                    foreach (RECIBO_ESTADO item in lstEstados)
                    {
                        cmbEstado.Items.Add(item);
                    }
                    cmbEstado.SelectedIndex = 0;
                }
            }
            catch (Exception exp)
            {
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscar();
        }

        private void buscar()
        {
            try
            {
                Viewliquidacion liquidacion = new Viewliquidacion();
                DateTime fechaIniLiq = DateTime.MinValue;
                DateTime fechaFinLiq = DateTime.MinValue;
                DateTime fechaIniPag = DateTime.MinValue;
                DateTime fechaFinPag = DateTime.MinValue;
                if (chkRecibo.Checked)
                {
                    liquidacion.NUMERO_RECIBO = txtNumRecibo.Text.Trim();
                }
                if (chkFactura.Checked)
                {
                    liquidacion.NUMERO_FACTURA = txtNumFactura.Text.Trim();
                }
                if (chkCliente.Checked)
                {
                    liquidacion.ID_TIPO_DOCUMENTO = ((TIPO_DOCUMENTO)cmbTipoDocumento.SelectedItem).ID;
                    liquidacion.IDENTIFICACION = txtIdentificacion.Text.Trim();
                }
                if (chkEstado.Checked)
                {
                    liquidacion.ID_ESTADO = ((RECIBO_ESTADO)cmbEstado.SelectedItem).ID;
                }
                if (chkFechaLiquidacion.Checked)
                {
                    fechaIniLiq = DateTime.Parse(datFechaInicialLiquidacion.Value.Date.ToString("dd/MM/yyyy 00:00:00"));
                    fechaFinLiq = DateTime.Parse(datFechaFinalLiquidacion.Value.Date.ToString("dd/MM/yyyy 23:59:59"));
                }
                if (chkFechaPago.Checked)
                {
                    fechaIniPag = DateTime.Parse(datFechaInicialPago.Value.Date.ToString("dd/MM/yyyy 00:00:00"));
                    fechaFinPag = DateTime.Parse(datFechaFinalPago.Value.Date.ToString("dd/MM/yyyy 23:59:59"));
                }
                Viewliquidacion[] lstLiquidaciones = serviciosViewliquidacion.buscarViewliquidacionBetween(liquidacion,fechaIniLiq,fechaFinLiq,fechaIniPag,fechaFinPag);
                if (lstLiquidaciones != null && lstLiquidaciones.Length > 0)
                {
                    grdDatos.Rows.Clear();
                    foreach (Viewliquidacion item in lstLiquidaciones)
                    {
                        String fechaLiquidacion = "";
                        String fechaPago = "";
                        if (item.FECHA_LIQUIDACION.CompareTo(DateTime.MinValue) == 0)
                            fechaLiquidacion = "";
                        else
                            fechaLiquidacion = item.FECHA_LIQUIDACION.ToString("dd/MM/yyyy");
                        if (item.FECHA_PAGO.CompareTo(DateTime.MinValue) == 0)
                            fechaPago = "";
                        else
                            fechaPago = item.FECHA_PAGO.ToString("dd/MM/yyyy");
                        grdDatos.Rows.Add(item.NUMERO_RECIBO, item.NUMERO_FACTURA, item.TIPO_DOCUMENTO, item.IDENTIFICACION, item.ESTADO, fechaLiquidacion, fechaPago, item.TIPO, item.TARIFA);
                    }
                }
                else
                    MessageBox.Show("No se encontro ningún recibo ni factura con los criterios seleccionados", "Sin información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exp)
            {
            }
        }

        private void btnReimprimir_Click(object sender, EventArgs e)
        {
            reimprimir();
        }

        private void reimprimir()
        {
            if (grdDatos.SelectedRows != null && grdDatos.SelectedRows.Count > 0)
            {
                String numero;
                if (grdDatos.SelectedRows[0].Cells["num_factura"].Value != null && !String.IsNullOrEmpty(grdDatos.SelectedRows[0].Cells["num_factura"].Value.ToString()))
                {
                    if (MessageBox.Show("¿Desea reimprimir la factura? Si selecciona NO se reimprimira el recibo", "¿Factura o Recibo?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        numero = grdDatos.SelectedRows[0].Cells["num_factura"].Value.ToString();
                        FACTURA factura = getFactura(numero);
                        if (factura != null && factura.ID > 0)
                        {
                            reimprimirFactura(factura);
                        }
                        else
                            MessageBox.Show("La factura no fue encontrada", "Sin factura", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else //Se reimprime el recibo
                    {
                        numero = grdDatos.SelectedRows[0].Cells["num_recibo"].Value.ToString();
                        RECIBO recibo = getRecibo(numero);
                        if (recibo != null && recibo.ID > 0)
                        {
                            reimprimirRecibo(recibo);
                        }
                        else
                            MessageBox.Show("El recibo no fue encontrado", "Sin recibo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    numero = grdDatos.SelectedRows[0].Cells["num_recibo"].Value.ToString();
                    RECIBO recibo = getRecibo(numero);
                    if (recibo != null && recibo.ID > 0)
                    {
                        reimprimirRecibo(recibo);
                    }
                    else
                        MessageBox.Show("El recibo no fue encontrado", "Sin recibo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("Debe seleccionar un registro de la lista", "Son selección", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void reimprimirFactura(FACTURA factura)
        {
            if (factura.ARCHIVO_FISICO != null && factura.ARCHIVO_FISICO.Length > 0)
            {
                String fileName = "CopiaFactura_No." + factura.NUMERO_FACTURA + "_" + DateTime.Now.ToString("dd-MM-yyyy hh-mm-ss.F") + ".pdf";
                fileName = fileName.Replace('/', '-');
                fileName = fileName.Replace(' ', '_');
                String path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Facturas\\Reimpresos";
                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);
                path += "\\" + fileName;
                File.WriteAllBytes(path, factura.ARCHIVO_FISICO);
                Process.Start(path);
            }
            else
                MessageBox.Show("La factura no tiene un archivo fisico para reimprimir", "Sin documento", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private FACTURA getFactura(string numero)
        {
            try
            {
                FACTURA factura = new FACTURA();
                factura.NUMERO_FACTURA = numero;
                factura = serviciosFACTURA.buscarPrimeroFACTURA(factura);
                return factura;
            }
            catch (Exception exp)
            {
                return null;
            }
        }

        private static void reimprimirRecibo(RECIBO recibo)
        {
            if (recibo.ARCHIVO_FISICO != null && recibo.ARCHIVO_FISICO.Length > 0)
            {
                String fileName = "CopiaRecibo_No." + recibo.NUMERO_RECIBO + "_" + DateTime.Now.ToString("dd-MM-yyyy hh-mm-ss.F") + ".pdf";
                fileName = fileName.Replace('/', '-');
                fileName = fileName.Replace(' ', '_');
                String path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Recibos\\Reimpresos";
                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);
                path += "\\" + fileName;
                File.WriteAllBytes(path, recibo.ARCHIVO_FISICO);
                Process.Start(path);
            }
            else
                MessageBox.Show("El recibo no tiene un archivo fisico para reimprimir", "Sin documento", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private RECIBO getRecibo(string numero)
        {
            try
            {
                RECIBO recibo = new RECIBO();
                recibo.NUMERO_RECIBO = numero;
                recibo = serviciosRECIBO.buscarPrimeroRECIBO(recibo);
                return recibo;
            }
            catch (Exception exp)
            {
                return null;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void limpiar()
        {
            grdDatos.Rows.Clear();
            txtNumRecibo.Clear();
            txtNumFactura.Clear();
            txtIdentificacion.Clear();
            cmbTipoDocumento.SelectedIndex = 0;
            cmbEstado.SelectedIndex = 0;
            datFechaInicialLiquidacion.Value = DateTime.Now;
            datFechaInicialPago.Value = DateTime.Now;
            datFechaFinalPago.Value = DateTime.Now;
            datFechaFinalLiquidacion.Value = DateTime.Now;
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            pagarRecibo();
        }

        private void pagarRecibo()
        {
            if (grdDatos.Rows != null && grdDatos.SelectedRows != null && grdDatos.SelectedRows.Count > 0)
            {
                if (grdDatos.SelectedRows[0].Cells["num_recibo"].Value != null && !String.IsNullOrEmpty(grdDatos.SelectedRows[0].Cells["num_recibo"].Value.ToString()))
                {
                    string numRecibo = grdDatos.SelectedRows[0].Cells["num_recibo"].Value.ToString();
                    frmPagarRecibo frm = new frmPagarRecibo(numRecibo);
                    frm.ShowDialog();
                    buscar();
                }
                else
                    MessageBox.Show("El registro que seleccionó no tiene un número de recibo", "Sin recibo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Debe seleccionar un recibo de la lista", "Sin recibo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAnularRecibo_Click(object sender, EventArgs e)
        {
            anularReciboFactura();
        }

        private void anularReciboFactura()
        {
            if (grdDatos.SelectedRows != null && grdDatos.SelectedRows.Count > 0)
            {
                String numero;
                if (grdDatos.SelectedRows[0].Cells["num_factura"].Value != null && !String.IsNullOrEmpty(grdDatos.SelectedRows[0].Cells["num_factura"].Value.ToString()))
                {
                    if (MessageBox.Show("¿Desea anular la factura No." + grdDatos.SelectedRows[0].Cells["num_factura"].Value.ToString() + "?", "¿Está seguro(a)?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        numero = grdDatos.SelectedRows[0].Cells["num_factura"].Value.ToString();
                        FACTURA factura = getFactura(numero);
                        if (factura != null && factura.ID > 0)
                        {
                            anularFactura(factura);
                        }
                        else
                            MessageBox.Show("La factura no fue encontrada", "Sin factura", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else //Se reimprime el recibo
                    {
                        numero = grdDatos.SelectedRows[0].Cells["num_recibo"].Value.ToString();
                        RECIBO recibo = getRecibo(numero);
                        if (recibo != null && recibo.ID > 0)
                        {
                            if (MessageBox.Show("¿Desea anular el recibo No." + recibo.NUMERO_RECIBO + "?", "¿Está seguro(a)?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                anularRecibo(recibo);
                        }
                        else
                            MessageBox.Show("El recibo no fue encontrado", "Sin recibo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    numero = grdDatos.SelectedRows[0].Cells["num_recibo"].Value.ToString();
                    RECIBO recibo = getRecibo(numero);
                    if (recibo != null && recibo.ID > 0)
                    {
                        if (MessageBox.Show("¿Desea anular el recibo No." + recibo.NUMERO_RECIBO + "?","Está seguro(a)?",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                            anularRecibo(recibo);
                    }
                    else
                        MessageBox.Show("El recibo no fue encontrado", "Sin recibo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("Debe seleccionar un registro de la lista", "Son selección", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void anularFactura(FACTURA factura)
        {
            FACTURA_ESTADO estado = new FACTURA_ESTADO();
            estado.ID = factura.ID_FACTURA_ESTADO;
            estado = serviciosFACTURA_ESTADO.buscarPrimeroFACTURA_ESTADO(estado);
            if (estado != null && estado.ID > 0)
            {
                if (estado.ESTADO == "CREADA")
                {
                    estado = new FACTURA_ESTADO();
                    estado.ESTADO = "ANULADA";
                    estado = serviciosFACTURA_ESTADO.buscarPrimeroFACTURA_ESTADO(estado);
                    if (estado != null && estado.ID > 0)
                    {
                        factura.ID_FACTURA_ESTADO = estado.ID;
                        if (serviciosFACTURA.editarFACTURA(factura))
                        {
                            MessageBox.Show("La factura fue anulada correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            buscar();
                        }
                        else
                            MessageBox.Show("Ocurrio un error y la factura no puede ser anulada", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                        MessageBox.Show("La factura no puede ser anulada porque no se ecnontro el estado anulado en el sistema", "Estado incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("La factura no puede ser anulada porque no está en estado creada", "Estado incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void anularRecibo(RECIBO recibo)
        {
            RECIBO_ESTADO estado = new RECIBO_ESTADO();
            estado.ID = recibo.ID_ESTADO;
            estado = serviciosRECIBO_ESTADO.buscarPrimeroRECIBO_ESTADO(estado);
            if (estado != null && estado.ID > 0)
            {
                if (estado.ESTADO == "LIQUIDADO")
                {
                    estado = new RECIBO_ESTADO();
                    estado.ESTADO = "ANULADO";
                    estado = serviciosRECIBO_ESTADO.buscarPrimeroRECIBO_ESTADO(estado);
                    if (estado != null && estado.ID > 0)
                    {
                        recibo.ID_ESTADO = estado.ID;
                        if (serviciosRECIBO.editarRECIBO(recibo))
                        {
                            MessageBox.Show("El recibo fue anulado correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            buscar();
                        }
                        else
                            MessageBox.Show("Ocurrio un error y el recibo no puede ser anulado", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                        MessageBox.Show("El recibo no puede ser anulado porque no se ecnontro el estado anulado en el sistema", "Estado incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("El recibo no puede ser anulado porque no está en estado liquidado", "Estado incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
