using EscuelaConduccion.Utilidades;
using EscuelaConduccion.wsServiciosTARIFA;
using EscuelaConduccion.wsServiciosTARIFA_DETALLE;
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

namespace EscuelaConduccion.Modelo.Vigencia
{
    public partial class frmDuplicarVigencia : Form
    {
        public ServiciosVIGENCIA serviciosVIGENCIA { get; private set; }
        public ServiciosTARIFA serviciosTARIFA { get; private set; }
        public ServiciosTARIFA_DETALLE serviciosTARIFA_DETALLE { get; private set; }

        public frmDuplicarVigencia()
        {
            InitializeComponent();
            serviciosVIGENCIA = (ServiciosVIGENCIA)Configurador.ConfigurarServicio(typeof(ServiciosVIGENCIA));
            serviciosTARIFA = (ServiciosTARIFA)Configurador.ConfigurarServicio(typeof(ServiciosTARIFA));
            serviciosTARIFA_DETALLE = (ServiciosTARIFA_DETALLE)Configurador.ConfigurarServicio(typeof(ServiciosTARIFA_DETALLE));
            getVigencias();
        }

        private void getVigencias()
        {
            cmbVigencia.DataSource = null;
            cmbVigencia.ValueMember = "ID";
            cmbVigencia.DisplayMember = "NOMBRE";
            VIGENCIA[] lstVigencias = serviciosVIGENCIA.listarVIGENCIA();
            if (lstVigencias != null && lstVigencias.Length > 0)
            {
                List<VIGENCIA> lst = lstVigencias.ToList<VIGENCIA>();
                lst = lst.OrderByDescending(x => x.NOMBRE).ToList();
                cmbVigencia.DataSource = lst;
                cmbVigencia.SelectedIndex = 0;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtValorTarifa_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funciones.esNumero(e);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            duplicarVigencia();
        }

        private void duplicarVigencia()
        {
            if (validarDatos())
            {
                VIGENCIA vigencia = new VIGENCIA();
                vigencia.NOMBRE = int.Parse(txtNuevaVigencia.Text);
                vigencia = serviciosVIGENCIA.crearVIGENCIA(vigencia);
                if (vigencia != null && vigencia.ID > 0)
                {
                    int idVigenciaOrigen = int.Parse(cmbVigencia.SelectedValue.ToString());
                    TARIFA tmpTarifa = new TARIFA();
                    tmpTarifa.ID_VIGENCIA = idVigenciaOrigen;
                    TARIFA[] lstTarifas = serviciosTARIFA.buscarTARIFA(tmpTarifa);
                    if (lstTarifas != null && lstTarifas.Length > 0)
                    {
                        foreach (TARIFA tarifa in lstTarifas)
                        {
                            TARIFA_DETALLE detalle = new TARIFA_DETALLE();
                            detalle.ID_TARIFA = tarifa.ID;
                            TARIFA_DETALLE[] lstDetalles = serviciosTARIFA_DETALLE.buscarTARIFA_DETALLE(detalle);
                            tarifa.ID = 0;
                            tarifa.ID_VIGENCIA = vigencia.ID;
                            TARIFA newTarifa = serviciosTARIFA.crearTARIFA(tarifa);
                            if (newTarifa != null && newTarifa.ID > 0)
                            {
                                if (lstDetalles != null && lstDetalles.Length > 0)
                                {
                                    foreach (TARIFA_DETALLE tarifa_detalle in lstDetalles)
                                    {
                                        tarifa_detalle.ID = 0;
                                        tarifa_detalle.ID_TARIFA = newTarifa.ID;
                                        serviciosTARIFA_DETALLE.crearTARIFA_DETALLE(tarifa_detalle);
                                    }
                                }
                            }
                            else
                                MessageBox.Show("ocurrio un error y la tarifa " + tarifa.NOMBRE + " no pudo ser creada", "Operación incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    MessageBox.Show("Proceso de duplicado de vigencia terminado", "Operación terminada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Ocurrio un error y la vigencia no pudo ser creada", "Operación incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool validarDatos()
        {
            if (!String.IsNullOrEmpty(txtNuevaVigencia.Text) && !String.IsNullOrWhiteSpace(txtNuevaVigencia.Text))
            {
                VIGENCIA vigencia = new VIGENCIA();
                vigencia.NOMBRE = int.Parse(txtNuevaVigencia.Text);
                vigencia = serviciosVIGENCIA.buscarPrimeroVIGENCIA(vigencia);
                if (vigencia != null && vigencia.ID > 0)
                {
                    MessageBox.Show("La vigencia que desea crear ya se encuentra registrada", "Vigencia duplicada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else
                    return true;
            }
            else
            {
                MessageBox.Show("Debe digitar la nueva vigencia", "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNuevaVigencia.Focus();
                return false;
            }
        }
    }
}
