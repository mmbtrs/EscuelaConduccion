using EscuelaConduccion.wsServiciosFACTURACONSECUTIVO;
using EscuelaConduccion.wsServiciosFacturaconsecutivodetalle;
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
    public partial class frmDetalleConsecutivo : Form
    {
        ServiciosFACTURACONSECUTIVO serviciosFACTURACONSECUTIVO;
        ServiciosFacturaconsecutivodetalle serviciosFacturaconsecutivodetalle;

        public frmDetalleConsecutivo(int id)
        {
            InitializeComponent();
            serviciosFACTURACONSECUTIVO = (ServiciosFACTURACONSECUTIVO)Configurador.ConfigurarServicio(typeof(ServiciosFACTURACONSECUTIVO));
            serviciosFacturaconsecutivodetalle = (ServiciosFacturaconsecutivodetalle)Configurador.ConfigurarServicio(typeof(ServiciosFacturaconsecutivodetalle));
            getFacturaConsecutivo(id);
        }

        private void getFacturaConsecutivo(int id)
        {
            FACTURACONSECUTIVO fACTURACONSECUTIVO = new FACTURACONSECUTIVO();
            fACTURACONSECUTIVO.ID = id;
            fACTURACONSECUTIVO = serviciosFACTURACONSECUTIVO.buscarPrimeroFACTURACONSECUTIVO(fACTURACONSECUTIVO);
            if (fACTURACONSECUTIVO != null && fACTURACONSECUTIVO.ID > 0)
            {
                lblRangoIni.Text = fACTURACONSECUTIVO.RANGO_INICIAL.ToString();
                lblRangoFin.Text = fACTURACONSECUTIVO.RANGO_FINAL.ToString();
                lblNumResolucion.Text = fACTURACONSECUTIVO.RESOLUCION;
                lblFechaResolucion.Text = fACTURACONSECUTIVO.FECHA_RESOLUCION.ToString("dd/MM/yyyy");
                getDetalleRangoConsecutivo(id);
            }
            else
                MessageBox.Show("El consecutivo no fue encontrado", "Sin información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void getDetalleRangoConsecutivo(int id)
        {
            grdDatos.Rows.Clear();
            Facturaconsecutivodetalle facturaconsecutivodetalle = new Facturaconsecutivodetalle();
            facturaconsecutivodetalle.ID_FACTURACONSECUTIVO = id;
            Facturaconsecutivodetalle[] lstDetalles = serviciosFacturaconsecutivodetalle.buscarFacturaconsecutivodetalle(facturaconsecutivodetalle);
            if (lstDetalles != null && lstDetalles.Length > 0)
            {
                lblCantidad.Text = lstDetalles.Length.ToString();
                foreach (Facturaconsecutivodetalle detalle in lstDetalles)
                {
                    grdDatos.Rows.Add(detalle.CONSECUTIVO, detalle.DISPONIBLE);
                }
            }
            else
            {
                lblCantidad.Text = "0";
                MessageBox.Show("El detalle del consecutivo no fue encontrado", "Sin información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
