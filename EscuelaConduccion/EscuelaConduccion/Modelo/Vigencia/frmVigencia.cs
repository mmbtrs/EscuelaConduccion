using EscuelaConduccion.Utilidades;
using EscuelaConduccion.wsServiciosVIGENCIA;
using System;
using System.Windows.Forms;
using UtilidadesServiciosWeb;
using static EscuelaConduccion.Utilidades.Funciones;

namespace EscuelaConduccion.Modelo.Vigencia
{
    public partial class frmVigencia : Form
    {
        ServiciosVIGENCIA serviciosVIGENCIA;
        private readonly VIGENCIA vigencia;
        private readonly operation operacion;

        public frmVigencia(VIGENCIA vigencia, operation operacion)
        {
            InitializeComponent();
            serviciosVIGENCIA = (ServiciosVIGENCIA)Configurador.ConfigurarServicio(typeof(ServiciosVIGENCIA));
            this.vigencia = vigencia;
            this.operacion = operacion;
            cargarDatos();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtVigencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funciones.esNumero(e);
        }

        private void cargarDatos()
        {
            try
            {
                switch (operacion)
                {
                    case operation.EDITAR:
                        this.Text = "Editar Vigencia";
                        txtVigencia.Text = vigencia.NOMBRE.ToString();
                        btnGuardar.Visible = true;
                        break;
                    case operation.CREAR:
                        this.Text = "Nueva Vugencia";
                        txtVigencia.Clear();
                        btnGuardar.Visible = true;
                        break;
                }
            }
            catch (Exception exp)
            {
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                if (operacion == operation.CREAR)
                {
                    crearVigencia();
                }
                else
                {
                    if (operacion == operation.EDITAR)
                    {
                        editarCliente();
                    }
                }
            }
        }

        private void editarCliente()
        {
            try
            {
                vigencia.NOMBRE = int.Parse(txtVigencia.Text);
                if (serviciosVIGENCIA.editarVIGENCIA(vigencia))
                {
                    MessageBox.Show("La vigencia " + txtVigencia.Text + " fue editada correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                    MessageBox.Show("Ocurrio un error y la vigencia " + txtVigencia.Text + " no fue editada en el sistema con éxito", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception exp)
            {
                MessageBox.Show("Se presentó el siguiente error: " + exp.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void crearVigencia()
        {
            try
            {
                VIGENCIA tmpVigencia = new VIGENCIA();
                tmpVigencia.NOMBRE = int.Parse(txtVigencia.Text);
                tmpVigencia = serviciosVIGENCIA.buscarPrimeroVIGENCIA(tmpVigencia);
                if (tmpVigencia != null && tmpVigencia.ID > 0)
                    MessageBox.Show("La vigencia " + txtVigencia.Text + " no puede ser creada debido a que ya se encuentra registrada en el sistema", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    tmpVigencia = new VIGENCIA();
                    tmpVigencia.NOMBRE = int.Parse(txtVigencia.Text);
                    tmpVigencia = serviciosVIGENCIA.crearVIGENCIA(tmpVigencia);
                    if (tmpVigencia != null && tmpVigencia.ID > 0)
                    {
                        MessageBox.Show("La vigencia " + txtVigencia.Text + " fue registrada en el sistema con éxito", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                        MessageBox.Show("Ocurrio un error y la vigencia " + txtVigencia.Text + " no fue registrada en el sistema con éxito", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Se presentó el siguiente error: " + exp.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool validarCampos()
        {
            if (!String.IsNullOrEmpty(txtVigencia.Text) && !String.IsNullOrWhiteSpace(txtVigencia.Text))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Debe digitar la nueva vigencia", "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtVigencia.Focus();
                return false;
            }
        }
    }
}
