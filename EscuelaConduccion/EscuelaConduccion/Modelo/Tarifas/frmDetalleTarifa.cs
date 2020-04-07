using EscuelaConduccion.Modelo.Accesorias;
using EscuelaConduccion.wsServiciosTARIFA;
using EscuelaConduccion.wsServiciosTARIFA_CONCEPTO;
using EscuelaConduccion.wsServiciosTARIFA_DETALLE;
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

namespace EscuelaConduccion.Modelo.Tarifas
{
    public partial class frmDetalleTarifa : Form
    {
        private readonly operation operacion;
        private readonly TARIFA_DETALLE myTarifaDetalle;
        ServiciosTARIFA_CONCEPTO serviciosTARIFA_CONCEPTO;
        ServiciosTARIFA serviciosTARIFA;
        ServiciosTARIFA_DETALLE serviciosTARIFA_DETALLE;

        public TARIFA myTarifa { get; private set; }

        public frmDetalleTarifa(operation operacion, int idTarifa, TARIFA_DETALLE myTarifaDetalle)
        {
            InitializeComponent();
            serviciosTARIFA_CONCEPTO = (ServiciosTARIFA_CONCEPTO)Configurador.ConfigurarServicio(typeof(ServiciosTARIFA_CONCEPTO));
            serviciosTARIFA = (ServiciosTARIFA)Configurador.ConfigurarServicio(typeof(ServiciosTARIFA));
            serviciosTARIFA_DETALLE = (ServiciosTARIFA_DETALLE)Configurador.ConfigurarServicio(typeof(ServiciosTARIFA_DETALLE));
            getConceptos();
            this.operacion = operacion;
            this.myTarifaDetalle = myTarifaDetalle;
            inicializarValores(idTarifa);
        }

        private void inicializarValores(int idTarifa)
        {
            myTarifa = new TARIFA();
            myTarifa.ID = idTarifa;
            myTarifa = serviciosTARIFA.buscarPrimeroTARIFA(myTarifa);
            if (myTarifa != null && myTarifa.ID > 0)
            {
                lblTarifa.Text = myTarifa.NOMBRE;
                if (operacion == operation.CREAR)
                {
                    this.Text = "Crear Detalle Tarifa";
                    lblTitulo.Text = "Crear Detalle Tarifa";
                }
                if (operacion == operation.EDITAR)
                {
                    this.Text = "Editar Detalle Tarifa";
                    lblTitulo.Text = "Editar Detalle Tarifa";
                    cmbConcepto.SelectedItem = getItemConcepto(myTarifaDetalle.ID_TARIFA_CONCEPTO);
                    if (myTarifaDetalle.TERCERO.Equals("SI"))
                        chkTercero.Checked = true;
                    else
                        chkTercero.Checked = false;
                    if (myTarifaDetalle.DESCONTABLE.Equals("SI"))
                        chkDescontable.Checked = true;
                    else
                        chkDescontable.Checked = false;
                    txtFormula.Text = myTarifaDetalle.FORMULA;
                }
            }
            else
            {
                MessageBox.Show("La tarifa no fue encontrada", "Sin tarifa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private object getItemConcepto(int iD_TARIFA_CONCEPTO)
        {
            for (int i = 0; i < cmbConcepto.Items.Count; i++)
            {
                if (((TARIFA_CONCEPTO)cmbConcepto.Items[i]).ID == iD_TARIFA_CONCEPTO)
                    return cmbConcepto.Items[i];
            }
            return cmbConcepto.Items[0];
        }

        private void getConceptos()
        {
            //cmbConcepto.ValueMember = "ID";
            //cmbConcepto.DisplayMember = "NOMBRE";
            TARIFA_CONCEPTO[] lstConceptos = serviciosTARIFA_CONCEPTO.listarTARIFA_CONCEPTO();
            cmbConcepto.Items.Clear();
            if (lstConceptos != null && lstConceptos.Length > 0)
            {
                foreach (TARIFA_CONCEPTO concepto in lstConceptos)
                {
                    cmbConcepto.Items.Add(concepto);
                }
                //cmbConcepto.DataSource = lstConceptos.ToList<TARIFA_CONCEPTO>();
                cmbConcepto.SelectedIndex = 0;
            }
        }

        private void lblTarifa_Click(object sender, EventArgs e)
        {
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
            {
                crearDetalleTarifa();
            }
            else
            {
                editarDetalleTarifa();
            }
        }

        private void crearDetalleTarifa()
        {
            if (validarCampos())
            {
                TARIFA_DETALLE tmpDetalle = new TARIFA_DETALLE();
                tmpDetalle.ID_TARIFA = myTarifa.ID;
                tmpDetalle.ID_TARIFA_CONCEPTO = ((TARIFA_CONCEPTO)cmbConcepto.SelectedItem).ID;
                tmpDetalle.FORMULA = txtFormula.Text;
                if (chkDescontable.Checked)
                    tmpDetalle.DESCONTABLE = "SI";
                else
                    tmpDetalle.DESCONTABLE = "NO";
                if (chkTercero.Checked)
                    tmpDetalle.TERCERO = "SI";
                else
                    tmpDetalle.TERCERO = "NO";
                tmpDetalle = serviciosTARIFA_DETALLE.crearTARIFA_DETALLE(tmpDetalle);
                if (tmpDetalle != null && tmpDetalle.ID > 0)
                {
                    MessageBox.Show("Se creo el detalle de la tarífa correctamente", "Operación correcta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtFormula.Clear();
                }
                else
                    MessageBox.Show("Ocurrio un error y no se creo el detalle de la tarífa correctamente", "Operación incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void editarDetalleTarifa()
        {
            if (validarCampos())
            {
                myTarifaDetalle.ID_TARIFA_CONCEPTO = ((TARIFA_CONCEPTO)cmbConcepto.SelectedItem).ID;
                myTarifaDetalle.FORMULA = txtFormula.Text;
                if (chkDescontable.Checked)
                    myTarifaDetalle.DESCONTABLE = "SI";
                else
                    myTarifaDetalle.DESCONTABLE = "NO";
                if (chkTercero.Checked)
                    myTarifaDetalle.TERCERO = "SI";
                else
                    myTarifaDetalle.TERCERO = "NO";
                if (serviciosTARIFA_DETALLE.editarTARIFA_DETALLE(myTarifaDetalle))
                {
                    MessageBox.Show("Se editó el detalle de la tarífa correctamente", "Operación correcta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                    MessageBox.Show("Ocurrio un error y no se editó el detalle de la tarífa correctamente", "Operación incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool validarCampos()
        {
            if (!String.IsNullOrEmpty(txtFormula.Text) && !String.IsNullOrWhiteSpace(txtFormula.Text))
                return true;
            else
            {
                MessageBox.Show("Debe digitar el valor o la formula del detalle de la tarifa", "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtFormula.Focus();
                return false;
            }
        }

        private void picAgregar_Click(object sender, EventArgs e)
        {
            frmConcepto frm = new frmConcepto();
            frm.ShowDialog(this);
            getConceptos();
        }
    }
}
