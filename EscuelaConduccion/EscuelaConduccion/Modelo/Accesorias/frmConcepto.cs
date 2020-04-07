using EscuelaConduccion.wsServiciosTARIFA_CONCEPTO;
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

namespace EscuelaConduccion.Modelo.Accesorias
{
    public partial class frmConcepto : Form
    {
        ServiciosTARIFA_CONCEPTO serviciosTARIFA_CONCEPTO;

        public frmConcepto()
        {
            InitializeComponent();
            serviciosTARIFA_CONCEPTO = (ServiciosTARIFA_CONCEPTO)Configurador.ConfigurarServicio(typeof(ServiciosTARIFA_CONCEPTO));
            cmbEstado.SelectedIndex = 0;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            crearEstado();
        }

        private void crearEstado()
        {
            if (validarCampos())
            {
                TARIFA_CONCEPTO concepto = new TARIFA_CONCEPTO();
                concepto.NOMBRE = txtConcepto.Text;
                concepto = serviciosTARIFA_CONCEPTO.buscarPrimeroTARIFA_CONCEPTO(concepto);
                if (concepto != null && concepto.ID > 0)
                    MessageBox.Show("Ya existe otro concepto con el mismo nombre", "Concepto duplicado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    concepto = new TARIFA_CONCEPTO();
                    concepto.NOMBRE = txtConcepto.Text;
                    concepto.DESCRIPCION = txtDescripcion.Text;
                    if (cmbEstado.Text.Equals("ACTIVO"))
                        concepto.ESTADO = "A";
                    else
                        concepto.ESTADO = "I";
                    concepto.CODIGO = txtCodigo.Text;
                    concepto = serviciosTARIFA_CONCEPTO.crearTARIFA_CONCEPTO(concepto);
                    if (concepto != null && concepto.ID > 0)
                    {
                        MessageBox.Show("Se creo correctamente el concepto", "Operación correcta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtCodigo.Clear();
                        txtConcepto.Clear();
                        txtDescripcion.Clear();
                    }
                    else
                        MessageBox.Show("Ocurrio un error y no fue posible crear el concepto", "Operación incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private bool validarCampos()
        {
            if (!String.IsNullOrEmpty(txtConcepto.Text) && !String.IsNullOrWhiteSpace(txtConcepto.Text))
            {
                if (!String.IsNullOrEmpty(txtDescripcion.Text) && !String.IsNullOrWhiteSpace(txtDescripcion.Text))
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Debe digitar la descripción del concepto que desea crear", "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtDescripcion.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Debe digitar el nombre del concepto que desea crear", "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtConcepto.Focus();
                return false;
            }
            
        }
    }
}
