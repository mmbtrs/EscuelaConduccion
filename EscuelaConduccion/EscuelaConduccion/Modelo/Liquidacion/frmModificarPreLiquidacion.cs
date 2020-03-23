using EscuelaConduccion.Utilidades;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscuelaConduccion.Modelo.Liquidacion
{
    public partial class frmModificarPreLiquidacion : Form
    {
        public ArrayList lstEliminados { get; set; }
        //DataGridView grdOriginal;

        public DataGridView getDatos()
        {
            return grdDatos;
        }

        public frmModificarPreLiquidacion(DataGridView grdInfo)
        {
            InitializeComponent();
            getLiquidacion(grdInfo);
            lstEliminados = new ArrayList();
        }

        private void getLiquidacion(DataGridView grdInfo)
        {
            try
            {
                grdDatos.Rows.Clear();
                if (grdInfo.Rows != null && grdInfo.Rows.Count > 0)
                {

                    foreach (DataGridViewRow fila in grdInfo.Rows)
                    {
                        grdDatos.Rows.Add(fila.Cells["ID_TARIFADETALLE"].Value, fila.Cells["concepto"].Value, fila.Cells["valor"].Value, fila.Cells["descontable"].Value);
                    }
                }
            }
            catch (Exception exp)
            {

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminarConcepto();
        }

        private void eliminarConcepto()
        {
            if (grdDatos.Rows != null && grdDatos.Rows.Count > 0)
            {
                if (grdDatos.Rows.Count > 1)
                {
                    if (MessageBox.Show("¿Está seguro(a) que desea eliminar el concepto " + grdDatos.SelectedRows[0].Cells["concepto"].Value + "?", "Eliminar concepto", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        lstEliminados.Add(grdDatos.SelectedRows[0]);
                        grdDatos.Rows.Remove(grdDatos.SelectedRows[0]);
                    }
                }
                else
                {
                    MessageBox.Show("No se pueden eliminar todos los registros", "Sin información", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No hay información para eliminar", "Sin información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void grdDatos_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void grdDatos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            guardarCambios();
        }

        private void guardarCambios()
        {
            try
            {
                bool bandera = true;
                foreach (DataGridViewRow fila in grdDatos.Rows)
                {
                    double valor = 0;
                    try
                    {
                        valor = double.Parse(fila.Cells["valor"].Value.ToString());
                    }
                    catch (Exception exp)
                    {
                        MessageBox.Show("El valor del concepto " + fila.Cells["concepto"].Value.ToString() + " no es un valor correcto", "Valor incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        bandera = false;
                        break;
                    }
                }
                if (bandera)
                {
                    this.DialogResult = DialogResult.OK;
                }
            }
            catch (Exception exp)
            {
                this.DialogResult = DialogResult.Cancel;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
