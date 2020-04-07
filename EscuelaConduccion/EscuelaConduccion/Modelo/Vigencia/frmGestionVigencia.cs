using EscuelaConduccion.Utilidades;
using EscuelaConduccion.wsServiciosVIGENCIA;
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

namespace EscuelaConduccion.Modelo.Vigencia
{
    public partial class frmGestionVigencia : Form
    {
        ServiciosVIGENCIA serviciosVIGENCIA;

        public List<VIGENCIA> vigencias { get; private set; }

        public frmGestionVigencia()
        {
            InitializeComponent();
            serviciosVIGENCIA = (ServiciosVIGENCIA)Configurador.ConfigurarServicio(typeof(ServiciosVIGENCIA));
            getVigencias();
        }

        private void getVigencias()
        {
            try
            {
                VIGENCIA[] lstVigencias = serviciosVIGENCIA.listarVIGENCIA();
                grdDatos.DataSource = null;
                if (lstVigencias != null && lstVigencias.Length > 0)
                {
                    grdDatos.DataSource = lstVigencias.ToList<VIGENCIA>();
                    vigencias = lstVigencias.ToList<VIGENCIA>();
                    grdDatos.Columns["ID"].Visible = false;
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Se presentó el siguiente error: " + exp.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private List<VIGENCIA> buscarVigencia(String valor)
        {
                IEnumerable<VIGENCIA> resultado = from vigencia in vigencias where vigencia.NOMBRE.ToString().Contains(valor.ToUpper()) select vigencia;
                List<VIGENCIA> lista = resultado.ToList();
                return lista;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            frmVigencia frm = new frmVigencia(null, operation.CREAR);
            frm.ShowDialog(this);
            getVigencias();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            VIGENCIA vigencia = new VIGENCIA(); 
            if (grdDatos.Rows != null && grdDatos.Rows.Count > 0 && grdDatos.SelectedRows != null && grdDatos.SelectedRows.Count > 0)
            {
                vigencia.ID = int.Parse(grdDatos.SelectedRows[0].Cells["id"].Value.ToString());
                vigencia.NOMBRE = int.Parse(grdDatos.SelectedRows[0].Cells["vigencia"].Value.ToString());
                frmVigencia frm = new frmVigencia(vigencia, operation.EDITAR);
                frm.ShowDialog(this);
                getVigencias();
            }
            else
                MessageBox.Show("Debe seleccionar una vigencia de la lista: ", "Sin vigencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funciones.esNumero(e);
        }

        private void txtValor_KeyUp(object sender, KeyEventArgs e)
        {
            grdDatos.DataSource = buscarVigencia(txtValor.Text);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminarVigencia();
        }

        private void eliminarVigencia()
        {
            if (grdDatos.Rows != null && grdDatos.Rows.Count > 0 && grdDatos.SelectedRows != null && grdDatos.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("¿Está seguro(a) que desea eliminar la vigencia " + grdDatos.SelectedRows[0].Cells["nombre"].Value.ToString() + "?","Confirmar eliminación", MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    VIGENCIA tmpVigencia = new VIGENCIA();
                    tmpVigencia.ID = int.Parse(grdDatos.SelectedRows[0].Cells["id"].Value.ToString());
                    if (serviciosVIGENCIA.eliminarVIGENCIA(tmpVigencia))
                    {
                        MessageBox.Show("Se eliminó correctamente la vigencia " + grdDatos.SelectedRows[0].Cells["nombre"].Value.ToString(), "Eliminación correcta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        getVigencias();
                    }
                    else
                        MessageBox.Show("Ocurrio un error y no se eliminó correctamente la vigencia " + grdDatos.SelectedRows[0].Cells["nombre"].Value.ToString(), "Eliminación incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("Debe seleccionar una vigencia de la lista: ", "Sin vigencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
