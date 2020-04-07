using EscuelaConduccion.wsServiciosTARIFACATEGORIA;
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
using static EscuelaConduccion.Utilidades.Funciones;

namespace EscuelaConduccion.Modelo.Accesorias
{
    public partial class frmGestionCategoria : Form
    {
        ServiciosTARIFACATEGORIA serviciosTARIFACATEGORIA;

        public frmGestionCategoria()
        {
            InitializeComponent();
            serviciosTARIFACATEGORIA = (ServiciosTARIFACATEGORIA)Configurador.ConfigurarServicio(typeof(ServiciosTARIFACATEGORIA));
            getCategorias();
        }

        private void getCategorias()
        {
            TARIFACATEGORIA[] lstCategorias = serviciosTARIFACATEGORIA.listarTARIFACATEGORIA();
            grdTarifas.Rows.Clear();
            if (lstCategorias != null && lstCategorias.Length > 0)
            {
                foreach (TARIFACATEGORIA item in lstCategorias)
                {
                    grdTarifas.Rows.Add(item.ID, item.NOMBRE);
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInsertarTarifa_Click(object sender, EventArgs e)
        {
            frmCategoria frm = new frmCategoria(operation.CREAR, null);
            frm.ShowDialog(this);
            getCategorias();
        }

        private void btnEditarTarifa_Click(object sender, EventArgs e)
        {
            if (grdTarifas.Rows != null && grdTarifas.Rows.Count > 0
                && grdTarifas.SelectedRows != null && grdTarifas.SelectedRows.Count > 0)
            {
                TARIFACATEGORIA categoria = new TARIFACATEGORIA();
                categoria.ID = int.Parse(grdTarifas.SelectedRows[0].Cells["ID"].Value.ToString());
                categoria.NOMBRE = grdTarifas.SelectedRows[0].Cells["CATEGORIA"].Value.ToString();
                frmCategoria frm = new frmCategoria(operation.EDITAR, categoria);
                frm.ShowDialog(this);
                getCategorias();
            }
            else
                MessageBox.Show("Debe seleccionar una categoría de la lista", "Sin categoría", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEliminarTarifa_Click(object sender, EventArgs e)
        {
            eliminarCategoria();
        }

        private void eliminarCategoria()
        {
            if (grdTarifas.Rows != null && grdTarifas.Rows.Count > 0
                && grdTarifas.SelectedRows != null && grdTarifas.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("¿Está seguro(a) que desea eliminar la categoria " + grdTarifas.SelectedRows[0].Cells["CATEGORIA"].Value.ToString() + "?", 
                    "Confirmar la eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    TARIFACATEGORIA categoria = new TARIFACATEGORIA();
                    categoria.ID = int.Parse(grdTarifas.SelectedRows[0].Cells["ID"].Value.ToString());
                    if (serviciosTARIFACATEGORIA.eliminarTARIFACATEGORIA(categoria))
                    {
                        MessageBox.Show("Se eliminó correctamente la categoría seleccionada", "Eliminación correcta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        getCategorias();
                    }
                    else
                        MessageBox.Show("Ocurrio un error y no se eliminó la categoría", "Eliminación incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    getCategorias(); 
                }
            }
            else
                MessageBox.Show("Debe seleccionar una categoría de la lista", "Sin categoría", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
