using EscuelaConduccion.Modelo.Accesorias;
using System;
using System.Linq;
using System.Windows.Forms;
using UtilidadesServiciosWeb;
using static EscuelaConduccion.Utilidades.Funciones;

namespace EscuelaConduccion.Modelo.Tarifas
{
    public partial class frmTarifa : Form
    {
        wsServiciosTARIFA.ServiciosTARIFA serviciosTARIFA;
        wsServiciosTARIFACATEGORIA.ServiciosTARIFACATEGORIA serviciosTARIFACATEGORIA;
        private readonly operation operacion;
        private readonly wsServiciosVIGENCIA.VIGENCIA vigencia;
        wsServiciosTARIFA.TARIFA myTarifa;

        public frmTarifa(operation operacion, int idTarifa, wsServiciosVIGENCIA.VIGENCIA vigencia)
        {
            InitializeComponent();
            serviciosTARIFA = (wsServiciosTARIFA.ServiciosTARIFA)Configurador.ConfigurarServicio(typeof(wsServiciosTARIFA.ServiciosTARIFA));
            serviciosTARIFACATEGORIA = (wsServiciosTARIFACATEGORIA.ServiciosTARIFACATEGORIA)Configurador.ConfigurarServicio(typeof(wsServiciosTARIFACATEGORIA.ServiciosTARIFACATEGORIA));
            this.operacion = operacion;
            this.vigencia = vigencia;
            getCategorias();
            inicializarValores(idTarifa);
        }

        private void getCategorias()
        {
            wsServiciosTARIFACATEGORIA.TARIFACATEGORIA[] lstCategorias = serviciosTARIFACATEGORIA.listarTARIFACATEGORIA();
            cmbCategoria.Items.Clear();
            if (lstCategorias != null && lstCategorias.Length > 0)
            {
                foreach (wsServiciosTARIFACATEGORIA.TARIFACATEGORIA categoria in lstCategorias)
                {
                    cmbCategoria.Items.Add(categoria);
                }
                cmbCategoria.SelectedIndex = 0;
                //cmbCategoria.DataSource = lstCategorias.ToList<wsServiciosTARIFACATEGORIA.TARIFACATEGORIA>();
            }
        }

        private void inicializarValores(int idTarifa)
        {
            cmbEstado.SelectedIndex = 0;
            lblVigencia.Text = vigencia.NOMBRE.ToString();
            if (operacion == operation.CREAR)
            {
                this.Text = "Crear Tarifa";
                lblTitulo.Text = "Nueva Tarifa";
            }
            if (operacion == operation.EDITAR)
            {
                this.Text = "Editar Tarifa";
                lblTitulo.Text = "Editar Tarifa";
                myTarifa = new wsServiciosTARIFA.TARIFA();
                myTarifa.ID = idTarifa;
                myTarifa = serviciosTARIFA.buscarPrimeroTARIFA(myTarifa);
                if (myTarifa != null && myTarifa.ID > 0)
                {
                    txtTarifa.Text = myTarifa.NOMBRE;
                    if (myTarifa.ESTADO == "A")
                        cmbEstado.SelectedIndex = 0;
                    else
                        cmbEstado.SelectedIndex = 1;
                    cmbCategoria.SelectedItem = getItemComboCategoria(myTarifa.ID_TARIFA_CATEGORIA);
                }
            }
        }

        private object getItemComboCategoria(int iD_TARIFA_CATEGORIA)
        {
            for (int i = 0; i < cmbCategoria.Items.Count; i++)
            {
                if (((wsServiciosTARIFACATEGORIA.TARIFACATEGORIA)cmbCategoria.Items[i]).ID == iD_TARIFA_CATEGORIA)
                    return cmbCategoria.Items[i];
            }
            return cmbCategoria.Items[0];
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            guardar();
        }

        private void guardar()
        {
            if (operacion == operation.CREAR)
                crearTarifa();
            else
                editarTarifa();
        }

        private void crearTarifa()
        {
            if (!String.IsNullOrEmpty(txtTarifa.Text) && !String.IsNullOrWhiteSpace(txtTarifa.Text))
            {
                wsServiciosTARIFA.TARIFA tmpTarifa = new wsServiciosTARIFA.TARIFA();
                tmpTarifa.NOMBRE = txtTarifa.Text;
                tmpTarifa.ID_TARIFA_CATEGORIA = ((wsServiciosTARIFACATEGORIA.TARIFACATEGORIA)cmbCategoria.SelectedItem).ID;
                tmpTarifa.ID_VIGENCIA = vigencia.ID;
                tmpTarifa = serviciosTARIFA.buscarPrimeroTARIFA(tmpTarifa);
                if (tmpTarifa != null && tmpTarifa.ID > 0)
                {
                    MessageBox.Show("Ya existe otra tarifa con el mismo nombre, en la misma vigencia y en la misma categoria", "Tarifa duplicada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTarifa.Focus();
                }
                else
                {
                    tmpTarifa = new wsServiciosTARIFA.TARIFA();
                    tmpTarifa.NOMBRE = txtTarifa.Text;
                    tmpTarifa.ID_TARIFA_CATEGORIA = ((wsServiciosTARIFACATEGORIA.TARIFACATEGORIA)cmbCategoria.SelectedItem).ID;
                    tmpTarifa.ID_VIGENCIA = vigencia.ID;
                    if (cmbEstado.Text.Equals("ACTIVA"))
                        tmpTarifa.ESTADO = "A";
                    else
                        tmpTarifa.ESTADO = "I";
                    tmpTarifa = serviciosTARIFA.crearTARIFA(tmpTarifa);
                    if (tmpTarifa != null && tmpTarifa.ID > 0)
                    {
                        MessageBox.Show("La tarifa fue creada correctamente", "Operación correcta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtTarifa.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Ocurrio un error y la tarifa no fue creada correctamente", "Operación incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe digitar el nombre de la tarifa que desea crear", "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTarifa.Focus();
            }
        }

        private void editarTarifa()
        {
            if (!String.IsNullOrEmpty(txtTarifa.Text) && !String.IsNullOrWhiteSpace(txtTarifa.Text))
            {
                myTarifa.NOMBRE = txtTarifa.Text;
                myTarifa.ID_TARIFA_CATEGORIA = ((wsServiciosTARIFACATEGORIA.TARIFACATEGORIA)cmbCategoria.SelectedItem).ID;
                myTarifa.ID_VIGENCIA = vigencia.ID;
                if (cmbEstado.Text.Equals("ACTIVA"))
                    myTarifa.ESTADO = "A";
                else
                    myTarifa.ESTADO = "I";
                if (serviciosTARIFA.editarTARIFA(myTarifa))
                {
                    MessageBox.Show("La tarifa fue editada correctamente", "Operación correcta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Ocurrio un error y la tarifa no fue editada correctamente", "Operación incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Debe digitar el nombre de la tarifa que desea editar", "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTarifa.Focus();
            }
        }

        private void picAgregar_Click(object sender, EventArgs e)
        {
            frmCategoria frm = new frmCategoria(operation.CREAR, null);
            frm.ShowDialog(this);
            getCategorias();
        }
    }
}
