using EscuelaConduccion.wsServiciosLIQUIDACION;
using EscuelaConduccion.wsServiciosLIQUIDACION_DETALLE;
using EscuelaConduccion.WSServiciosRECIBO;
using EscuelaConduccion.wsServiciosTIPO_DOCUMENTO;
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
using EscuelaConduccion.Utilidades;

namespace EscuelaConduccion.Modelo.Liquidacion
{
    public partial class frmLiquidar : Form
    {
        ServiciosTIPO_DOCUMENTO serviciosTIPO_DOCUMENTO;
        ServiciosVIEW_CLIENTE serviciosVIEW_CLIENTE;
        ServiciosTIPO_LIQUIDACION serviciosTIPO_LIQUIDACION;
        ServiciosLIQUIDACION serviciosLIQUIDACION;

        RECIBO recibo;
        private bool pagoTotal;
        float total = 0;
        wsServiciosVIEW_CLIENTE.VIEW_CLIENTE myCliente;

        public frmLiquidar()
        {
            InitializeComponent();
            serviciosTIPO_DOCUMENTO = (ServiciosTIPO_DOCUMENTO)Configurador.ConfigurarServicio(typeof(ServiciosTIPO_DOCUMENTO));
            serviciosVIEW_CLIENTE = (ServiciosVIEW_CLIENTE)Configurador.ConfigurarServicio(typeof(ServiciosVIEW_CLIENTE));
            serviciosTIPO_LIQUIDACION = (ServiciosTIPO_LIQUIDACION)Configurador.ConfigurarServicio(typeof(ServiciosTIPO_LIQUIDACION));
            serviciosLIQUIDACION = (ServiciosLIQUIDACION)Configurador.ConfigurarServicio(typeof(ServiciosLIQUIDACION));
            getTiposDocumento();
            recibo = null;
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

        public wsServiciosVIEW_CLIENTE.VIEW_CLIENTE getCliente()
        {
            try
            {
                wsServiciosVIEW_CLIENTE.VIEW_CLIENTE tmpCliente = new wsServiciosVIEW_CLIENTE.VIEW_CLIENTE();
                tmpCliente.TIPO_DOCUMENTO = ((TIPO_DOCUMENTO)cmbTipoDocumento.SelectedItem).TIPO;
                if (!String.IsNullOrEmpty(txtIdentificacion.Text) && !String.IsNullOrWhiteSpace(txtIdentificacion.Text))
                {
                    tmpCliente.IDENTIFICACION = txtIdentificacion.Text.Trim();
                    tmpCliente = serviciosVIEW_CLIENTE.buscarPrimeroVIEW_CLIENTE(tmpCliente);
                    if (tmpCliente != null && tmpCliente.ID > 0)
                    {
                        return tmpCliente;
                    }
                    else
                    {
                        MessageBox.Show("El cliente identificado con " + cmbTipoDocumento.Text + " número " + txtIdentificacion.Text.Trim() +
                            " no fue encontrado", "Sin registros", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return null;
                    } 
                }
                else
                {
                    MessageBox.Show("Debe digitar el número de identificación del cleiente", "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtIdentificacion.Focus();
                    return null;
                }

            }
            catch (Exception exp)
            {
                return null;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscarCliente();
        }

        private void buscarCliente()
        {
            myCliente = getCliente();
            if (myCliente != null)
            {
                lblInfoCliente.Text = myCliente.TIPO_DOCUMENTO + " No." + myCliente.IDENTIFICACION + " " + myCliente.NOMBRES + " " + myCliente.APELLIDOS;
                panCliente.Width = lblInfoCliente.Width + 10;
                panCliente.Visible = true;
                btnLiquidarTarifas.Enabled = true;
            }
            else
            {
                panCliente.Visible = false;
                btnLiquidarTarifas.Enabled = false;
            }
        }

        private void btnLiquidarTarifas_Click(object sender, EventArgs e)
        {
            liquidarTarifas();
        }

        private void liquidarTarifas()
        {
            frmLiquidarTarifas frm = new frmLiquidarTarifas(myCliente);

            float floatTmp = 0;
            if (frm.ShowDialog(this) == DialogResult.OK)
            {
                if (frm.dtTarifaLiquidada != null && frm.dtTarifaLiquidada.Rows.Count > 0)
                {
                    foreach (DataRow fila in frm.dtTarifaLiquidada.Rows)
                    {
                        if (fila["DESCONTABLE"].ToString().ToUpper().Equals("SI"))
                        {
                            DataGridViewRow dgvr = grdDatos.Rows[0];
                            bool repetida = false;
                            for (int i = 0; i < grdDatos.Rows.Count; i++)
                            {
                                if (grdDatos.Rows[i].Cells["ID_TARIFADETALLE"].Value.ToString().Equals(fila["ID_TARIFADETALLE"]))
                                {
                                    repetida = true;
                                    break;
                                }
                            }
                            if (!repetida)
                            {
                                grdDatos.Rows.Add(fila["ID_TARIFADETALLE"], fila["CONCEPTO"], fila["VALOR"], fila["DESCONTABLE"]);
                                if (fila["VALOR"] != null)
                                {
                                    float.TryParse(fila["VALOR"].ToString(), out floatTmp);
                                    total += floatTmp;
                                }
                            }
                        }
                        else
                        {
                            grdDatos.Rows.Add(fila["ID_TARIFADETALLE"], fila["CONCEPTO"], fila["VALOR"], fila["DESCONTABLE"]);
                            if (fila["VALOR"] != null)
                            {
                                float.TryParse(fila["VALOR"].ToString(), out floatTmp);
                                total += floatTmp;
                            }
                        }
                    }
                    lblValor.Text = total.ToString("C");
                    btnLiquidar.Enabled = true;
                    btnModificarPreliquidacion.Enabled = true;
                }
            }
        }

        private void btnLiquidar_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            this.Cursor = Cursors.WaitCursor;
            liquidar();
            this.Cursor = Cursors.Default;
            this.Enabled = true;
        }

        private void liquidar()
        {
            try
            {
                frmTipoLiquidacion frm = new frmTipoLiquidacion();
                if (frm.ShowDialog(this) == DialogResult.Yes)//Pago total
                {
                    wsServiciosLIQUIDACION.LIQUIDACION_DETALLE[] lstDetalles = new wsServiciosLIQUIDACION.LIQUIDACION_DETALLE[grdDatos.Rows.Count];
                    if (grdDatos.Rows != null && grdDatos.Rows.Count > 0 &&
                        myCliente != null && myCliente.ID > 0)
                    {
                        for (int i = 0; i < grdDatos.Rows.Count; i++)
                        {
                            wsServiciosLIQUIDACION.LIQUIDACION_DETALLE detalle = new wsServiciosLIQUIDACION.LIQUIDACION_DETALLE();
                            detalle.ID_TARIFA_DETALLE = int.Parse(grdDatos.Rows[i].Cells["ID_TARIFADETALLE"].Value.ToString());
                            detalle.VALOR_CONCEPTO = float.Parse(grdDatos.Rows[i].Cells["VALOR"].Value.ToString());
                            lstDetalles[i] = detalle;
                        }
                        wsServiciosLIQUIDACION.LIQUIDACION liquidacion = new wsServiciosLIQUIDACION.LIQUIDACION();
                        liquidacion.ID_CLIENTE = myCliente.ID;
                        TIPO_LIQUIDACION tipo = new TIPO_LIQUIDACION();
                        tipo.TIPO = "PT";
                        tipo = serviciosTIPO_LIQUIDACION.buscarPrimeroTIPO_LIQUIDACION(tipo);
                        if (tipo != null && tipo.ID > 0)
                            liquidacion.ID_TIPO_LIQUIDACION = tipo.ID;
                        liquidacion.TOTAL = total;

                        wsServiciosLIQUIDACION.VIEW_CLIENTE tmpCliente = new wsServiciosLIQUIDACION.VIEW_CLIENTE();
                        tmpCliente.ID = myCliente.ID;
                        tmpCliente.TIPO_DOCUMENTO = myCliente.TIPO_DOCUMENTO;
                        tmpCliente.IDENTIFICACION = myCliente.IDENTIFICACION;
                        tmpCliente.NOMBRES = myCliente.NOMBRES;
                        tmpCliente.APELLIDOS = myCliente.APELLIDOS;
                        tmpCliente.DIRECCION = myCliente.DIRECCION;
                        tmpCliente.CIUDAD = myCliente.CIUDAD;
                        tmpCliente.DEPARTAMENTO = myCliente.DEPARTAMENTO;
                        tmpCliente.GENERO = myCliente.GENERO;
                        tmpCliente.TELEFONO = myCliente.TELEFONO;
                        tmpCliente.CELULAR = myCliente.CELULAR;
                        tmpCliente.CORREO = myCliente.CORREO;
                        tmpCliente.FECHA_NACIMIENTO = myCliente.FECHA_NACIMIENTO;

                        liquidacion = serviciosLIQUIDACION.crearMultipleLIQUIDACION_2(liquidacion, lstDetalles, tmpCliente);
                        if (liquidacion != null && liquidacion.ID > 0)
                        {
                            
                            WSServiciosRECIBO.ServiciosRECIBO servicio = new WSServiciosRECIBO.ServiciosRECIBO();

                            var liquidacionSerializado = JsonConvert.SerializeObject(liquidacion);
                            WSServiciosRECIBO.LIQUIDACION liquidacionDesserializado = JsonConvert.DeserializeObject < WSServiciosRECIBO.LIQUIDACION > (liquidacionSerializado);

                            WSServiciosRECIBO.LIQUIDACION_DETALLE[] lstLiquidacionDetalle = new WSServiciosRECIBO.LIQUIDACION_DETALLE[lstDetalles.Length];
                            int i = 0;
                            foreach (wsServiciosLIQUIDACION.LIQUIDACION_DETALLE item in lstDetalles)
                            {
                                var detalleSerializado = JsonConvert.SerializeObject(item);
                                WSServiciosRECIBO.LIQUIDACION_DETALLE detalleDesserializado = JsonConvert.DeserializeObject<WSServiciosRECIBO.LIQUIDACION_DETALLE>(detalleSerializado);
                                lstLiquidacionDetalle[i] = detalleDesserializado;
                                i++;
                            }

                            var clienteSerializado = JsonConvert.SerializeObject(tmpCliente);
                            WSServiciosRECIBO.VIEW_CLIENTE clienteDesserializado = JsonConvert.DeserializeObject<WSServiciosRECIBO.VIEW_CLIENTE>(clienteSerializado);

                            recibo = servicio.generarRECIBO(liquidacionDesserializado, lstLiquidacionDetalle, clienteDesserializado);
                            if (recibo != null && recibo.ID > 0)
                            {
                                btnLiquidar.Enabled = false;
                                lblNumRecibo.Text = recibo.NUMERO_RECIBO;
                                btnVerRecibo.Enabled = true;
                                MessageBox.Show("Liquidación realizada correctamente", "Liquidación correcta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                btnLiquidar.Enabled = true;
                                lblNumRecibo.Text = "#";
                                btnVerRecibo.Enabled = false;
                                MessageBox.Show("Ocurrio algún problema y la liquidación fue incorrecta", "Liquidación incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                            MessageBox.Show("Ocurrio un error desconocido y la liquidación no se realizó correctamente", "Liquidación incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else//Acuerdo Pago
                {
                    wsServiciosLIQUIDACION.LIQUIDACION_DETALLE[] lstDetalles = new wsServiciosLIQUIDACION.LIQUIDACION_DETALLE[grdDatos.Rows.Count];
                    if (grdDatos.Rows != null && grdDatos.Rows.Count > 0 &&
                        myCliente != null && myCliente.ID > 0)
                    {
                        for (int i = 0; i < grdDatos.Rows.Count; i++)
                        {
                            wsServiciosLIQUIDACION.LIQUIDACION_DETALLE detalle = new wsServiciosLIQUIDACION.LIQUIDACION_DETALLE();
                            detalle.ID_TARIFA_DETALLE = int.Parse(grdDatos.Rows[i].Cells["ID_TARIFADETALLE"].Value.ToString());
                            detalle.VALOR_CONCEPTO = float.Parse(grdDatos.Rows[i].Cells["VALOR"].Value.ToString());
                            lstDetalles[i] = detalle;
                        }
                        wsServiciosLIQUIDACION.LIQUIDACION liquidacion = new wsServiciosLIQUIDACION.LIQUIDACION();
                        liquidacion.ID_CLIENTE = myCliente.ID;
                        TIPO_LIQUIDACION tipo = new TIPO_LIQUIDACION();
                        tipo.TIPO = "AP";
                        tipo = serviciosTIPO_LIQUIDACION.buscarPrimeroTIPO_LIQUIDACION(tipo);
                        if (tipo != null && tipo.ID > 0)
                            liquidacion.ID_TIPO_LIQUIDACION = tipo.ID;
                        liquidacion.TOTAL = total;

                        wsServiciosLIQUIDACION.VIEW_CLIENTE tmpCliente = new wsServiciosLIQUIDACION.VIEW_CLIENTE();
                        tmpCliente.ID = myCliente.ID;
                        tmpCliente.TIPO_DOCUMENTO = myCliente.TIPO_DOCUMENTO;
                        tmpCliente.IDENTIFICACION = myCliente.IDENTIFICACION;
                        tmpCliente.NOMBRES = myCliente.NOMBRES;
                        tmpCliente.APELLIDOS = myCliente.APELLIDOS;
                        tmpCliente.DIRECCION = myCliente.DIRECCION;
                        tmpCliente.CIUDAD = myCliente.CIUDAD;
                        tmpCliente.DEPARTAMENTO = myCliente.DEPARTAMENTO;
                        tmpCliente.GENERO = myCliente.GENERO;
                        tmpCliente.TELEFONO = myCliente.TELEFONO;
                        tmpCliente.CELULAR = myCliente.CELULAR;
                        tmpCliente.CORREO = myCliente.CORREO;
                        tmpCliente.FECHA_NACIMIENTO = myCliente.FECHA_NACIMIENTO;

                        liquidacion = serviciosLIQUIDACION.crearMultipleLIQUIDACION_2(liquidacion, lstDetalles, tmpCliente);
                        if (liquidacion != null && liquidacion.ID > 0)
                        {
                            frmBuscarLiquidacion buscarLiquidacion = new frmBuscarLiquidacion(myCliente);
                            buscarLiquidacion.ShowDialog(this);
                        }
                        else
                            MessageBox.Show("Ocurrio un error desconocido y la liquidación no se realizó correctamente", "Liquidación incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception exp)
            {

            }
        }

        private void btnVerRecibo_Click(object sender, EventArgs e)
        {
            verRecibo();
        }

        private void verRecibo()
        {
            try
            {
                if (recibo != null && recibo.ID > 0 && recibo.ARCHIVO_FISICO != null && recibo.ARCHIVO_FISICO.Length > 0)
                {
                    String fileName = "CopiaRecibo_No." + recibo.NUMERO_RECIBO + "_" + DateTime.Now.ToString("dd-MM-yyyy hh-mm-ss.F") + ".pdf";
                    fileName = fileName.Replace('/', '-');
                    fileName = fileName.Replace(' ', '_');
                    String path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Recibos";
                    if (!Directory.Exists(path))
                        Directory.CreateDirectory(path);
                    path += "\\" + fileName;
                    File.WriteAllBytes(path, recibo.ARCHIVO_FISICO);
                    Process.Start(path);
                    btnVerRecibo.Enabled = false;
                }
            }
            catch (Exception exp)
            {

            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarLiquidacion();
        }

        private void limpiarLiquidacion()
        {
            try
            {
                grdDatos.Rows.Clear();
                btnLiquidar.Enabled = false;
                lblNumRecibo.Text = "#";
                btnVerRecibo.Enabled = false;
                panCliente.Visible = false;
                lblInfoCliente.Text = "";
                recibo = null;
                myCliente = null;
                total = 0;
                lblValor.Text = "$0";
                txtIdentificacion.Text = "";
                btnLiquidarTarifas.Enabled = false;
                btnModificarPreliquidacion.Enabled = false;
            }
            catch (Exception exp)
            {
                MessageBox.Show("Ocurrio el siguiente error: " + exp.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificarPreliquidacion_Click(object sender, EventArgs e)
        {
            if (grdDatos.Rows != null && grdDatos.Rows.Count > 0)
            {
                frmModificarPreLiquidacion frm = new frmModificarPreLiquidacion(grdDatos);
                if (frm.ShowDialog(this) == DialogResult.OK)
                {
                    total = 0;
                    DataGridView grdTmp = frm.getDatos();
                    grdDatos.Rows.Clear();
                    foreach (DataGridViewRow fila in grdTmp.Rows)
                    {
                        total += float.Parse(fila.Cells["valor"].Value.ToString()); 
                        grdDatos.Rows.Add(fila.Cells["ID_TARIFADETALLE"].Value, fila.Cells["concepto"].Value, fila.Cells["valor"].Value, fila.Cells["descontable"].Value);
                    }
                    lblValor.Text = "$" + total;
                }
            }
        }

        private void txtIdentificacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Funciones.isEnter(e))
                buscarCliente();
        }
    }
}
