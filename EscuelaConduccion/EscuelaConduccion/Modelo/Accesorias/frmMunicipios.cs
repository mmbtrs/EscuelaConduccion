using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EscuelaConduccion.wsServiciosDEPARTAMENTO;
using UtilidadesServiciosWeb;
using EscuelaConduccion.wsServiciosVIEW_CIUDAD;

namespace EscuelaConduccion.Modelo.Accesorias
{
    public partial class frmMunicipios : Form
    {
        ServiciosVIEW_CIUDAD serviciosVIEW_CIUDAD;
        public VIEW_CIUDAD MyCiudad { get; set; }
        List<VIEW_CIUDAD> MyCiudades;

        public frmMunicipios()
        {
            InitializeComponent();
            serviciosVIEW_CIUDAD = (ServiciosVIEW_CIUDAD)Configurador.ConfigurarServicio(typeof(ServiciosVIEW_CIUDAD));
            getCiudades();
            txtValor.Focus();
        }

        private void getCiudades()
        {
            try
            {
                VIEW_CIUDAD[] lstCiudades = serviciosVIEW_CIUDAD.listarVIEW_CIUDAD();
                MyCiudades = new List<VIEW_CIUDAD>();

                if (lstCiudades != null && lstCiudades.Length > 0)
                {
                    MyCiudades = lstCiudades.ToList<VIEW_CIUDAD>();
                    grdDatos.DataSource = lstCiudades;
                }
                grdDatos.Columns[0].Visible = false;
                grdDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                grdDatos.Columns[1].HeaderText = "DEPARTAMENTOS";
                grdDatos.Columns[2].HeaderText = "MUNICIPIOS";
                cmbFiltro.SelectedIndex = 1;
            }
            catch (Exception exp)
            {
            }
        }

        private List<VIEW_CIUDAD> buscarCiudad(String valor)
        {
            if (cmbFiltro.SelectedIndex == 0)
            {
                IEnumerable<VIEW_CIUDAD> resultado = from municipio in MyCiudades where municipio.DEPARTAMENTO.ToUpper().Contains(valor.ToUpper()) select municipio;
                List<VIEW_CIUDAD> lista = resultado.ToList();
                return lista;
            }
            else
            {
                IEnumerable<VIEW_CIUDAD> resultado = from municipio in MyCiudades where municipio.CIUDAD.ToUpper().Contains(valor.ToUpper()) select municipio;
                List<VIEW_CIUDAD> lista = resultado.ToList();
                return lista;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel; 
        }

        private void seleccionarObjeto()
        {
            try
            {
                if (grdDatos.DataSource != null && grdDatos.Rows.Count > 0 && grdDatos.SelectedRows.Count > 0)
                {
                    MyCiudad = new VIEW_CIUDAD();
                    MyCiudad.ID = int.Parse(grdDatos.SelectedRows[0].Cells["ID"].Value.ToString());
                    MyCiudad.DEPARTAMENTO = grdDatos.SelectedRows[0].Cells["DEPARTAMENTO"].Value.ToString();
                    MyCiudad.CIUDAD = grdDatos.SelectedRows[0].Cells["CIUDAD"].Value.ToString();
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MyCiudad = null;
                    this.DialogResult = DialogResult.Cancel;
                }
            }
            catch (Exception exp)
            {
                MyCiudad = null;
                this.DialogResult = DialogResult.Cancel;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            seleccionarObjeto();
        }

        private void txtValor_KeyUp(object sender, KeyEventArgs e)
        {
            grdDatos.DataSource = buscarCiudad(txtValor.Text);
        }
    }
}
