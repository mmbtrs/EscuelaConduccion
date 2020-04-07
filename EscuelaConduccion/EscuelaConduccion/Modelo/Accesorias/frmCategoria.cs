using EscuelaConduccion.wsServiciosTARIFACATEGORIA;
using System;
using System.Windows.Forms;
using UtilidadesServiciosWeb;
using static EscuelaConduccion.Utilidades.Funciones;

namespace EscuelaConduccion.Modelo.Accesorias
{
    public partial class frmCategoria : Form
    {
        ServiciosTARIFACATEGORIA serviciosTARIFACATEGORIA;
        private readonly operation operacion;
        private readonly TARIFACATEGORIA categoria;

        public frmCategoria(operation operacion, TARIFACATEGORIA categoria)
        {
            InitializeComponent();
            serviciosTARIFACATEGORIA = (ServiciosTARIFACATEGORIA)Configurador.ConfigurarServicio(typeof(ServiciosTARIFACATEGORIA));
            this.operacion = operacion;
            this.categoria = categoria;
            inicializarValores();
        }

        private void inicializarValores()
        {
            if (operacion == operation.CREAR)
            {
                this.Text = "Crear Categoría";
                lblTitulo.Text = "Crear Categoría";
            }
            if (operacion == operation.EDITAR)
            {
                this.Text = "Editar Categoría";
                lblTitulo.Text = "Editar Categoría";
                txtCategoria.Text = categoria.NOMBRE;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (operacion == operation.CREAR)
                crearCategoria();
            else
                editarCategoria();
        }

        private void editarCategoria()
        {
            if (!String.IsNullOrEmpty(txtCategoria.Text) && !String.IsNullOrWhiteSpace(txtCategoria.Text))
            {
                categoria.NOMBRE = txtCategoria.Text;
                if (serviciosTARIFACATEGORIA.editarTARIFACATEGORIA(categoria))
                {
                    MessageBox.Show("Se editó correctamente la categoría", "Operación correcta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Ocurrio un error y no se editó correctamente la categoría", "Operación incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCategoria.Focus();
                }
            }
            else
            {
                MessageBox.Show("Debe digitar la categoría que desea editar", "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCategoria.Focus();
            }
        }

        private void crearCategoria()
        {
            if (!String.IsNullOrEmpty(txtCategoria.Text) && !String.IsNullOrWhiteSpace(txtCategoria.Text))
            {
                TARIFACATEGORIA categoria = new TARIFACATEGORIA();
                categoria.NOMBRE = txtCategoria.Text;
                categoria = serviciosTARIFACATEGORIA.buscarPrimeroTARIFACATEGORIA(categoria);
                if (categoria != null && categoria.ID > 0)
                {
                    MessageBox.Show("Ya existe otra categoría con el mismo nombre registrada en el sistema", "Categoría duplicada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCategoria.Focus();
                }
                else
                {
                    categoria = new TARIFACATEGORIA();
                    categoria.NOMBRE = txtCategoria.Text;
                    categoria = serviciosTARIFACATEGORIA.crearTARIFACATEGORIA(categoria);
                    if (categoria != null && categoria.ID > 0)
                    {
                        MessageBox.Show("Se creo correctamente la categoría", "Operación correcta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtCategoria.Clear();
                        txtCategoria.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Ocurrio un error y no se creo correctamente la categoría", "Operación incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtCategoria.Focus();
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe digitar la categoría que desea crear", "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCategoria.Focus();
            }
        }
    }
}
