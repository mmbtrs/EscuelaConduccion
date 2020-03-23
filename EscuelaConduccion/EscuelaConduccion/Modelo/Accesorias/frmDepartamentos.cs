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

namespace EscuelaConduccion.Modelo.Accesorias
{
    public partial class frmDepartamentos : Form
    {
        ServiciosDEPARTAMENTO serviciosDEPARTAMENTO;
        public DEPARTAMENTO MyDepartamento { get; set; }
        List<DEPARTAMENTO> MyDepartamentos;

        public frmDepartamentos()
        {
            InitializeComponent();
            serviciosDEPARTAMENTO = (ServiciosDEPARTAMENTO)Configurador.ConfigurarServicio(typeof(ServiciosDEPARTAMENTO));
            getDepartamentos();
            txtValor.Focus();
        }

        private void getDepartamentos()
        {
            try
            {
                DEPARTAMENTO[] lstDptos = serviciosDEPARTAMENTO.listarDEPARTAMENTO();
                MyDepartamentos = new List<DEPARTAMENTO>();

                if (lstDptos != null && lstDptos.Length > 0)
                {
                    MyDepartamentos = lstDptos.ToList<DEPARTAMENTO>();
                    grdDatos.DataSource = lstDptos;
                }
                grdDatos.Columns[0].Visible = false;
                grdDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                grdDatos.Columns[1].HeaderText = "DEPARTAMENTOS";
                cmbFiltro.SelectedIndex = 0;
            }
            catch (Exception exp)
            {
            }
        }

        private List<DEPARTAMENTO> buscarDepartamento(String valor)
        {
            IEnumerable<DEPARTAMENTO> resultado = from dpto in MyDepartamentos where dpto.NOMBRE.ToUpper().Contains(valor.ToUpper()) select dpto;

            List<DEPARTAMENTO> lista = resultado.ToList();
            return lista;
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
                    MyDepartamento = new DEPARTAMENTO();
                    MyDepartamento.ID = int.Parse(grdDatos.SelectedRows[0].Cells["ID"].Value.ToString());
                    MyDepartamento.NOMBRE = grdDatos.SelectedRows[0].Cells["NOMBRE"].Value.ToString();
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MyDepartamento = null;
                    this.DialogResult = DialogResult.Cancel;
                }
            }
            catch (Exception exp)
            {
                MyDepartamento = null;
                this.DialogResult = DialogResult.Cancel;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            seleccionarObjeto();
        }

        private void txtValor_KeyUp(object sender, KeyEventArgs e)
        {
            grdDatos.DataSource = buscarDepartamento(txtValor.Text);
        }
    }
}
