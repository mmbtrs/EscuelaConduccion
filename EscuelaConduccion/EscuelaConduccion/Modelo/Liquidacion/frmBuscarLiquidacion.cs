using EscuelaConduccion.wsServiciosSQL;
using EscuelaConduccion.wsServiciosTIPO_DOCUMENTO;
using EscuelaConduccion.wsServiciosVIEW_CLIENTE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UtilidadesServiciosWeb;

namespace EscuelaConduccion.Modelo.Liquidacion
{
    public partial class frmBuscarLiquidacion : Form
    {
        ServiciosTIPO_DOCUMENTO serviciosTIPO_DOCUMENTO;
        ServiciosVIEW_CLIENTE serviciosVIEW_CLIENTE;
        ServiciosSQL serviciosSQL;

        wsServiciosVIEW_CLIENTE.VIEW_CLIENTE myCliente;

        public frmBuscarLiquidacion()
        {
            InitializeComponent();
            serviciosTIPO_DOCUMENTO = (ServiciosTIPO_DOCUMENTO)Configurador.ConfigurarServicio(typeof(ServiciosTIPO_DOCUMENTO));
            serviciosVIEW_CLIENTE = (ServiciosVIEW_CLIENTE)Configurador.ConfigurarServicio(typeof(ServiciosVIEW_CLIENTE));
            serviciosSQL = (ServiciosSQL)Configurador.ConfigurarServicio(typeof(ServiciosSQL));
            getTiposDocumento();
        }
        
        public frmBuscarLiquidacion(wsServiciosVIEW_CLIENTE.VIEW_CLIENTE cliente)
        {
            InitializeComponent();
            serviciosTIPO_DOCUMENTO = (ServiciosTIPO_DOCUMENTO)Configurador.ConfigurarServicio(typeof(ServiciosTIPO_DOCUMENTO));
            serviciosVIEW_CLIENTE = (ServiciosVIEW_CLIENTE)Configurador.ConfigurarServicio(typeof(ServiciosVIEW_CLIENTE));
            serviciosSQL = (ServiciosSQL)Configurador.ConfigurarServicio(typeof(ServiciosSQL));
            getTiposDocumento();
            myCliente = cliente;
            setInfo();
        }

        private void setInfo()
        {
            try
            {
                if (myCliente != null)
                {
                    lblInfoCliente.Text = myCliente.TIPO_DOCUMENTO + " No." + myCliente.IDENTIFICACION + " " + myCliente.NOMBRES + " " + myCliente.APELLIDOS;
                    panCliente.Width = lblInfoCliente.Width + 10;
                    panCliente.Visible = true;
                    txtIdentificacion.Text = myCliente.IDENTIFICACION;
                    foreach (TIPO_DOCUMENTO item in cmbTipoDocumento.Items)
                    {
                        if (item.TIPO == myCliente.TIPO_DOCUMENTO)
                        {
                            cmbTipoDocumento.SelectedItem = item;
                            break;
                        }
                    }
                    getLiquidaciones();
                }
                else
                {
                    panCliente.Visible = false;
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Ocurrio el siguiente error: " + exp.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void getLiquidaciones()
        {
            try
            {
                string sql = @"SELECT DISTINCT
                                LIQUIDACION.ID,
                                TIPO_LIQUIDACION.TIPO,
                                LIQUIDACION.FECHA_LIQUIDACION,
                                LIQUIDACION.TOTAL,
                                TARIFA.NOMBRE AS TARIFA
                                FROM 
                                LIQUIDACION
                                INNER JOIN TIPO_LIQUIDACION ON (LIQUIDACION.ID_TIPO_LIQUIDACION = TIPO_LIQUIDACION.ID)
                                INNER JOIN LIQUIDACION_DETALLE ON (LIQUIDACION.ID = LIQUIDACION_DETALLE.ID_LIQUIDACION)
                                INNER JOIN TARIFA_DETALLE ON (LIQUIDACION_DETALLE.ID_TARIFA_DETALLE = TARIFA_DETALLE.ID)
                                INNER JOIN TARIFA ON (TARIFA_DETALLE.ID_TARIFA = TARIFA.ID)
                                WHERE 
                                LIQUIDACION.ID_CLIENTE = " + myCliente.ID + " AND TIPO_LIQUIDACION.TIPO = 'AP'";
                DataSet ds = serviciosSQL.consultaSQL(sql, "liquidaciones");
                grdLiquidaciones.Rows.Clear();
                if (ds != null && ds.Tables != null && ds.Tables["liquidaciones"].Rows.Count > 0)
                {
                    foreach (DataRow fila in ds.Tables["liquidaciones"].Rows)
                    {
                        grdLiquidaciones.Rows.Add(fila["ID"], fila["TIPO"], fila["FECHA_LIQUIDACION"], fila["TOTAL"], fila["TARIFA"]);
                    }
                }
                else
                    MessageBox.Show("No se encontró ninguna liquidación de tipo Acuerdo de Pago, asociada a este cliente", "Sin datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exp)
            {
                MessageBox.Show("Ocurrio el siguiente error: " + exp.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            myCliente = getCliente();
            if (myCliente != null && myCliente.ID > 0)
            {
                lblInfoCliente.Text = myCliente.TIPO_DOCUMENTO + " No." + myCliente.IDENTIFICACION + " " + myCliente.NOMBRES + " " + myCliente.APELLIDOS;
                panCliente.Width = lblInfoCliente.Width + 10;
                panCliente.Visible = true;
                getLiquidaciones();
            }
            else
            {
                panCliente.Visible = false;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (grdLiquidaciones.Rows != null && grdLiquidaciones.Rows.Count > 0 && grdLiquidaciones.SelectedRows != null && grdLiquidaciones.SelectedRows.Count > 0)
            {
                frmCreacionCuotas crearCuotas = new frmCreacionCuotas(int.Parse(grdLiquidaciones.SelectedRows[0].Cells["ID"].Value.ToString()));
                crearCuotas.ShowDialog(this);
            }
        }
    }
}
