using EscuelaConduccion.wsServiciosACUERDO_PAGO;
using EscuelaConduccion.wsServiciosSQL;
using EscuelaConduccion.wsServiciosTIPO_DOCUMENTO;
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

        public frmViewAcuerdoPago()
        {
            InitializeComponent();
            serviciosTIPO_DOCUMENTO = (ServiciosTIPO_DOCUMENTO)Configurador.ConfigurarServicio(typeof(ServiciosTIPO_DOCUMENTO));
            serviciosSQL = (ServiciosSQL)Configurador.ConfigurarServicio(typeof(ServiciosSQL));
            serviciosACUERDO_PAGO = (ServiciosACUERDO_PAGO)Configurador.ConfigurarServicio(typeof(ServiciosACUERDO_PAGO));
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

        }
    }
}
