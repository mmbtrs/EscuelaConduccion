using EscuelaConduccion.wsServiciosLIQUIDACION;
using EscuelaConduccion.wsServiciosTARIFA;
using EscuelaConduccion.wsServiciosTARIFA_DETALLE;
using EscuelaConduccion.wsServiciosVIEW_CLIENTE;
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

namespace EscuelaConduccion.Modelo.Liquidacion
{
    public partial class frmLiquidarTarifas : Form
    {
        ServiciosTARIFA serviciosTARIFA;
        ServiciosTARIFA_DETALLE serviciosTARIFA_DETALLE;
        ServiciosVIGENCIA serviciosVIGENCIA;
        VIGENCIA vigencia;
        wsServiciosVIEW_CLIENTE.VIEW_CLIENTE myCliente;
        ServiciosLIQUIDACION serviciosLIQUIDACION;
        public DataTable dtTarifaLiquidada;

        public frmLiquidarTarifas(wsServiciosVIEW_CLIENTE.VIEW_CLIENTE view_cliente)
        {
            InitializeComponent();
            myCliente = view_cliente;
            serviciosTARIFA = (ServiciosTARIFA)Configurador.ConfigurarServicio(typeof(ServiciosTARIFA));
            serviciosTARIFA_DETALLE = (ServiciosTARIFA_DETALLE)Configurador.ConfigurarServicio(typeof(ServiciosTARIFA_DETALLE));
            serviciosVIGENCIA = (ServiciosVIGENCIA)Configurador.ConfigurarServicio(typeof(ServiciosVIGENCIA));
            serviciosLIQUIDACION = (ServiciosLIQUIDACION)Configurador.ConfigurarServicio(typeof(ServiciosLIQUIDACION));
            getVigencia();
            getTarifas();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void cmbTarifas_SelectedIndexChanged(object sender, EventArgs e)
        {
            liquidarTarifa();
        }

        private void getVigencia()
        {
            try
            {
                vigencia = new VIGENCIA();
                vigencia.NOMBRE = DateTime.Now.Year;
                vigencia = serviciosVIGENCIA.buscarPrimeroVIGENCIA(vigencia);
                if (!(vigencia != null && vigencia.ID > 0))
                    vigencia = null;
            }
            catch (Exception exp)
            {
                vigencia = null;
            }
        }

        private void getTarifas()
        {
            try
            {
                if (vigencia != null && vigencia.ID > 0)
                {
                    wsServiciosTARIFA.TARIFA tarifa = new wsServiciosTARIFA.TARIFA();
                    tarifa.ID_VIGENCIA = vigencia.ID;
                    tarifa.ESTADO = "A";
                    wsServiciosTARIFA.TARIFA[] lstTarifas = serviciosTARIFA.buscarTARIFA(tarifa);
                    if (lstTarifas != null && lstTarifas.Length > 0)
                    {
                        cmbTarifas.Items.Clear();
                        foreach (wsServiciosTARIFA.TARIFA item in lstTarifas)
                        {
                            cmbTarifas.Items.Add(item);
                        }
                        cmbTarifas.SelectedIndex = 0;
                    }
                }
            }
            catch (Exception exp)
            {
            }
        }

        private void liquidarTarifa()
        {
            try
            {
                wsServiciosTARIFA.TARIFA tmpTarifa = (wsServiciosTARIFA.TARIFA)cmbTarifas.SelectedItem;
                wsServiciosLIQUIDACION.TARIFA tarifa = new wsServiciosLIQUIDACION.TARIFA();
                tarifa.ID = tmpTarifa.ID;
                tarifa.ID_TARIFA_CATEGORIA = tmpTarifa.ID_TARIFA_CATEGORIA;
                tarifa.ID_VIGENCIA = tmpTarifa.ID_VIGENCIA;
                tarifa.NOMBRE = tmpTarifa.NOMBRE;
                tarifa.ESTADO = tmpTarifa.ESTADO;

                DataSet ds = serviciosLIQUIDACION.crearMultipleLIQUIDACION_1(tarifa, myCliente.ID );
                grdDatos.Rows.Clear();
                if (ds != null && ds.Tables != null && ds.Tables.Count > 0)
                {
                    dtTarifaLiquidada = ds.Tables[0];
                    if (dtTarifaLiquidada != null && dtTarifaLiquidada.Rows.Count > 0)
                    {
                        foreach (DataRow fila in dtTarifaLiquidada.Rows)
                        {
                            grdDatos.Rows.Add(fila["ID_TARIFADETALLE"], fila["CONCEPTO"], fila["VALOR"], fila["DESCONTABLE"]);
                        }
                    }
                    else
                        dtTarifaLiquidada = null;
                }
                else
                    dtTarifaLiquidada = null;
            }
            catch (Exception exp)
            {
                dtTarifaLiquidada = null;
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
