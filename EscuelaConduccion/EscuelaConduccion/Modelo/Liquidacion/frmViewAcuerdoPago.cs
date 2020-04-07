using EscuelaConduccion.wsServiciosACUERDO_PAGO;
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
    public partial class frmViewAcuerdoPago : Form
    {
        ServiciosTIPO_DOCUMENTO serviciosTIPO_DOCUMENTO;
        ServiciosSQL serviciosSQL;
        ServiciosACUERDO_PAGO serviciosACUERDO_PAGO;
        ServiciosVIEW_CLIENTE serviciosVIEW_CLIENTE;

        public frmViewAcuerdoPago()
        {
            InitializeComponent();
            serviciosTIPO_DOCUMENTO = (ServiciosTIPO_DOCUMENTO)Configurador.ConfigurarServicio(typeof(ServiciosTIPO_DOCUMENTO));
            serviciosSQL = (ServiciosSQL)Configurador.ConfigurarServicio(typeof(ServiciosSQL));
            serviciosACUERDO_PAGO = (ServiciosACUERDO_PAGO)Configurador.ConfigurarServicio(typeof(ServiciosACUERDO_PAGO));
            serviciosVIEW_CLIENTE = (ServiciosVIEW_CLIENTE)Configurador.ConfigurarServicio(typeof(ServiciosVIEW_CLIENTE));
            getTiposDocumento();
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
                MessageBox.Show("Sepresentó el siguiente error: " + exp.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscarAcuerdos();
        }

        private void buscarAcuerdos()
        {
            try
            {
                string sql =
                    @"SELECT 
                    ACUERDO_PAGO.ID,
                    ACUERDO_PAGO.NUMERO_ACUERDO,
                    ACUERDO_PAGO.FECHA_ACUERDO,
                    CLIENTE.IDENTIFICACION,
                    CLIENTE.NOMBRES + ' ' +CLIENTE.APELLIDOS AS CLIENTE,
                    LIQUIDACION.TOTAL AS VALOR,
                    LIQUIDACION.ID AS LIQUIDACION,
                    ACUERDO_ESTADO.NOMBRE AS ESTADO
                    FROM
                    ACUERDO_PAGO
                    LEFT JOIN LIQUIDACION ON (ACUERDO_PAGO.ID_LIQUIDACION = LIQUIDACION.ID)
                    LEFT JOIN CLIENTE ON (LIQUIDACION.ID_CLIENTE = CLIENTE.ID)
                    LEFT JOIN ACUERDO_ESTADO ON (ACUERDO_PAGO.ID_ACUERDO_ESTADO = ACUERDO_ESTADO.ID)
                    WHERE 
                    CLIENTE.ID_TIPO_DOCUMENTO = " + ((TIPO_DOCUMENTO)cmbTipoDocumento.SelectedItem).ID + " AND CLIENTE.IDENTIFICACION = '" + txtIdentificacion.Text.Trim() + "'";
                grdDatos.Rows.Clear();
                DataSet ds = serviciosSQL.consultaSQL(sql,"acuerdos");
                if (ds != null && ds.Tables != null && ds.Tables["acuerdos"] != null && ds.Tables["acuerdos"].Rows.Count > 0)
                {
                    foreach (DataRow fila in ds.Tables["acuerdos"].Rows)
                    {
                        grdDatos.Rows.Add(fila["ID"].ToString(), fila["NUMERO_ACUERDO"].ToString(),
                                        fila["FECHA_ACUERDO"].ToString(), fila["IDENTIFICACION"].ToString(),
                                        fila["CLIENTE"].ToString(), fila["VALOR"].ToString(),
                                        fila["LIQUIDACION"].ToString(), fila["ESTADO"].ToString());
                    }
                }
                else
                    MessageBox.Show("No se encontro información de ningún acuerdo de pago", "Sin acuerdos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exp)
            {
                MessageBox.Show("Sepresentó el siguiente error: " + exp.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            VerDetalleAcuerdo();
        }

        private void VerDetalleAcuerdo()
        {
            if (grdDatos.Rows != null && grdDatos.Rows.Count > 0 && grdDatos.SelectedRows != null && grdDatos.SelectedRows.Count > 0)
            {
                ACUERDO_PAGO acuerdo = new ACUERDO_PAGO();
                acuerdo.ID = int.Parse(grdDatos.SelectedRows[0].Cells["ID"].Value.ToString());
                acuerdo = serviciosACUERDO_PAGO.buscarPrimeroACUERDO_PAGO(acuerdo);
                if (acuerdo != null && acuerdo.ID > 0)
                {
                    frmAcuerdoPago frm = new frmAcuerdoPago(acuerdo);
                    frm.ShowDialog(this);
                }
                else
                    MessageBox.Show("No se encontró el acuerdo de pago", "Sin acuerdo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Debe seleccionar un acuerdo de pago de la lista", "Sin acuerdos", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            crearAcuerdo();
        }

        private void crearAcuerdo()
        {
            VIEW_CLIENTE cliente = new VIEW_CLIENTE();
            cliente.TIPO_DOCUMENTO = ((TIPO_DOCUMENTO)cmbTipoDocumento.SelectedItem).TIPO;
            cliente.IDENTIFICACION = txtIdentificacion.Text.Trim();
            cliente = serviciosVIEW_CLIENTE.buscarPrimeroVIEW_CLIENTE(cliente);
            if (cliente != null && cliente.ID > 0)
            {
                frmBuscarLiquidacion frm = new frmBuscarLiquidacion(cliente);
                frm.ShowDialog(this);
                buscarAcuerdos();
            }
            else
                MessageBox.Show("No se encontró el cliente", "Sin cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminarAcuerdo();
        }

        private void eliminarAcuerdo()
        {
            if (grdDatos.Rows != null && grdDatos.Rows.Count > 0 && grdDatos.SelectedRows != null && grdDatos.SelectedRows.Count > 0)
            {
                ACUERDO_PAGO acuerdo = new ACUERDO_PAGO();
                acuerdo.ID = int.Parse(grdDatos.SelectedRows[0].Cells["ID"].Value.ToString());
                acuerdo = serviciosACUERDO_PAGO.buscarPrimeroACUERDO_PAGO(acuerdo);
                if (acuerdo != null && acuerdo.ID > 0)
                {
                    if (MessageBox.Show("¿Está seguro(a) que desea eliminar el acuerdo de pago No." + acuerdo.NUMERO_ACUERDO + "?", 
                        "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        string sql =
                                        @"SELECT 
                                        ACUERDO_PAGO.ID,
                                        ACUERDO_PAGO_DETALLE.ID_RECIBO,
                                        RECIBO.NUMERO_RECIBO,
                                        RECIBO_ESTADO.ESTADO
                                        FROM 
                                        ACUERDO_PAGO
                                        INNER JOIN ACUERDO_PAGO_DETALLE ON (ACUERDO_PAGO.ID = ACUERDO_PAGO_DETALLE.ID_ACUERDO_PAGO)
                                        INNER JOIN RECIBO ON (ACUERDO_PAGO_DETALLE.ID_RECIBO = RECIBO.ID)
                                        LEFT JOIN RECIBO_ESTADO ON (RECIBO.ID_ESTADO = RECIBO_ESTADO.ID)
                                        WHERE RECIBO_ESTADO.ESTADO  = 'PAGADO' AND ACUERDO_PAGO.ID = " + acuerdo.ID;
                        DataSet ds = serviciosSQL.consultaSQL(sql, "recibos");
                        if (ds != null && 
                            ds.Tables != null && 
                            ds.Tables["recibos"] != null && 
                            ds.Tables["recibos"].Rows != null &&
                            ds.Tables["recibos"].Rows.Count > 0)
                            MessageBox.Show("No es posible eliminar el acuerdo No." + acuerdo.NUMERO_ACUERDO + ", ya que tiene cuotas en estado PAGADO", 
                                "No es posible eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                        {
                            if (serviciosACUERDO_PAGO.eliminarACUERDO_PAGO(acuerdo))
                            {
                                MessageBox.Show("Se eliminó correctamente el acuerdo de pago seleccionado", "Eliminación correcta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                buscarAcuerdos();
                            }
                            else
                                MessageBox.Show("Ocurrio un error y no se eliminó correctamente el acuerdo de pago seleccionado", "Eliminación incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                    MessageBox.Show("No se encontró el acuerdo de pago", "Sin acuerdo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Debe seleccionar un acuerdo de pago de la lista", "Sin acuerdos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }
    }
}
