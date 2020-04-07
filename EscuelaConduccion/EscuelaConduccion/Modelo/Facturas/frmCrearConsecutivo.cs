using EscuelaConduccion.Utilidades;
using EscuelaConduccion.wsServiciosFACTURA;
using EscuelaConduccion.wsServiciosFACTURACONSECUTIVO;
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

namespace EscuelaConduccion.Modelo.Facturas
{
    public partial class frmCrearConsecutivo : Form
    {
        ServiciosFACTURACONSECUTIVO serviciosFACTURACONSECUTIVO;

        public frmCrearConsecutivo()
        {
            InitializeComponent();
            serviciosFACTURACONSECUTIVO = (ServiciosFACTURACONSECUTIVO)Configurador.ConfigurarServicio(typeof(ServiciosFACTURACONSECUTIVO));
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtRangoInicial_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funciones.esNumero(e);
        }

        private void txtRangoFinal_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funciones.esNumero(e);
        }

        private void calcularTotalACrear()
        {
            double num1;
            double num2;
            if (!String.IsNullOrEmpty(txtRangoInicial.Text) && !String.IsNullOrWhiteSpace(txtRangoInicial.Text))
                num1 = double.Parse(txtRangoInicial.Text.Trim());
            else
                num1 = 0;
            if (!String.IsNullOrEmpty(txtRangoFinal.Text) && !String.IsNullOrWhiteSpace(txtRangoFinal.Text))
                num2 = double.Parse(txtRangoFinal.Text.Trim());
            else
                num2 = 0;
            double total = 0;
            if (num1 == 0 || num2 == 0)
                total = 0;
            else
                total = num2 - num1 + 1;
            lblTotalCrear.Text = "Total a crear: " + total.ToString();
        }

        private void txtRangoInicial_Leave(object sender, EventArgs e)
        {
            calcularTotalACrear();
        }

        private void txtRangoFinal_Leave(object sender, EventArgs e)
        {
            calcularTotalACrear();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                FACTURACONSECUTIVO facturaConsecutivo = new FACTURACONSECUTIVO();
                facturaConsecutivo.FECHA_RESOLUCION = datFechaResolucion.Value.Date;
                facturaConsecutivo.RANGO_FINAL = float.Parse(txtRangoFinal.Text);
                facturaConsecutivo.RANGO_INICIAL = float.Parse(txtRangoInicial.Text);
                facturaConsecutivo.RESOLUCION = txtNumResolucion.Text.Trim();
                facturaConsecutivo = serviciosFACTURACONSECUTIVO.crearFACTURACONSECUTIVO(facturaConsecutivo);
                if (facturaConsecutivo != null && facturaConsecutivo.ID > 0)
                {
                    MessageBox.Show("Se creo corrcetamente el consecutivo", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    if (facturaConsecutivo != null && facturaConsecutivo.ID == -2)
                        MessageBox.Show("No fue posible crear el consecutivo ya que los números de este consecutivo se intersectan con los números de otro consecutivo ya registrado en el sistema", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Ocurrio un error  y no se creo corrcetamente el consecutivo", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool validar()
        {
            if (!String.IsNullOrEmpty(txtRangoInicial.Text))
            {
                if (!String.IsNullOrEmpty(txtRangoFinal.Text))
                {
                    if (!String.IsNullOrEmpty(txtNumResolucion.Text))
                    {
                        if (double.Parse(txtRangoInicial.Text) > double.Parse(txtRangoFinal.Text))
                        {
                            MessageBox.Show("El rango inicial no puede ser mayor que el rango final", "Campo incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtRangoInicial.Focus();
                            return false;
                        }
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Debe digitar el numero de resolución", "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtNumResolucion.Focus();
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Debe digitar el rango final", "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtRangoFinal.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Debe digitar el rango inicial", "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRangoInicial.Focus();
                return false;
            }
        }
    }
}
