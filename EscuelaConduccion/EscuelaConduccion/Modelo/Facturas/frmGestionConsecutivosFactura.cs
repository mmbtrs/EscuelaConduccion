using EscuelaConduccion.wsServiciosFACTURACONSECUTIVO;
using EscuelaConduccion.wsServiciosFacturaconsecutivodetalle;
using EscuelaConduccion.wsServiciosSQL;
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
    public partial class frmGestionConsecutivosFactura : Form
    {
        ServiciosSQL serviciosSQL;
		ServiciosFACTURACONSECUTIVO serviciosFACTURACONSECUTIVO;
		ServiciosFacturaconsecutivodetalle serviciosFacturaconsecutivodetalle;

        public frmGestionConsecutivosFactura()
        {
            InitializeComponent();
            serviciosSQL = (ServiciosSQL)Configurador.ConfigurarServicio(typeof(ServiciosSQL));
			serviciosFACTURACONSECUTIVO = (ServiciosFACTURACONSECUTIVO)Configurador.ConfigurarServicio(typeof(ServiciosFACTURACONSECUTIVO));
			serviciosFacturaconsecutivodetalle = (ServiciosFacturaconsecutivodetalle)Configurador.ConfigurarServicio(typeof(ServiciosFacturaconsecutivodetalle));
			setColumnaDetalle();
            getDetalleRangos();
        }

		private void setColumnaDetalle()
		{
			DataGridViewButtonColumn btnDetalle = new DataGridViewButtonColumn();
			btnDetalle.HeaderText = "DETALLE";
			btnDetalle.Name = "Detalle";
			btnDetalle.Text = "Ver detalle ...";
			btnDetalle.UseColumnTextForButtonValue = true;
			grdDatos.Columns.Add(btnDetalle);
		}

		private void getDetalleRangos()
        {
            try
            {
                string sql =
					@"SELECT DISTINCT
					FACTURACONSECUTIVO.ID,
					FACTURACONSECUTIVO.RANGO_INICIAL,
					FACTURACONSECUTIVO.RANGO_FINAL,
					FACTURACONSECUTIVO.RESOLUCION,
					CONVERT (VARCHAR(10), FACTURACONSECUTIVO.FECHA_RESOLUCION,103) AS FECHA_RESOLUCION,
					( FACTURACONSECUTIVO.RANGO_FINAL - FACTURACONSECUTIVO.RANGO_INICIAL ) + 1 AS CANTIDAD,
					ISNULL((
						SELECT COUNT
							( FACTURA_CONSECUTIVO_DETALLE.ID ) 
						FROM
							FACTURA_CONSECUTIVO_DETALLE 
						WHERE
							FACTURA_CONSECUTIVO_DETALLE.DISPONIBLE = 'SI' 
							AND FACTURACONSECUTIVO.ID = FACTURA_CONSECUTIVO_DETALLE.ID_FACTURACONSECUTIVO 
						GROUP BY
							FACTURA_CONSECUTIVO_DETALLE.ID_FACTURACONSECUTIVO 
							),
						0 
					) AS DISPONIBLES,
					ISNULL((
						SELECT COUNT
							( FACTURA_CONSECUTIVO_DETALLE.ID ) 
						FROM
							FACTURA_CONSECUTIVO_DETALLE 
						WHERE
							FACTURA_CONSECUTIVO_DETALLE.DISPONIBLE = 'NO' 
							AND FACTURACONSECUTIVO.ID = FACTURA_CONSECUTIVO_DETALLE.ID_FACTURACONSECUTIVO 
						GROUP BY
							FACTURA_CONSECUTIVO_DETALLE.ID_FACTURACONSECUTIVO 
							),
						0 
					) AS NO_DISPONIBLES 
				FROM
					FACTURACONSECUTIVO
					LEFT JOIN FACTURA_CONSECUTIVO_DETALLE ON ( FACTURACONSECUTIVO.ID = FACTURA_CONSECUTIVO_DETALLE.ID_FACTURACONSECUTIVO )";
				grdDatos.Rows.Clear();
				DataSet ds = serviciosSQL.consultaSQL(sql, "DetalleConsecutivo");
				if (ds != null && ds.Tables != null && ds.Tables["DetalleConsecutivo"] != null && ds.Tables["DetalleConsecutivo"].Rows.Count > 0)
				{
					foreach (DataRow fila in ds.Tables["DetalleConsecutivo"].Rows)
					{
						
						grdDatos.Rows.Add(fila["ID"],
							fila["RANGO_INICIAL"], 
							fila["RANGO_FINAL"], 
							fila["RESOLUCION"], 
							fila["FECHA_RESOLUCION"], 
							fila["CANTIDAD"], 
							fila["DISPONIBLES"], 
							fila["NO_DISPONIBLES"]
							);
					}
				}
				else
					MessageBox.Show("No hay ningún rango de facturas configurado en el sistema", "Sin datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
            catch (Exception exp)
            {
                MessageBox.Show("Se presento el siguiente error: " + exp.Message, "Error desconocido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            frmCrearConsecutivo frm = new frmCrearConsecutivo();
            frm.ShowDialog(this);
			getDetalleRangos();
        }

		private void grdDatos_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (grdDatos.Columns[e.ColumnIndex].Name.Equals("Detalle"))
			{
				frmDetalleConsecutivo frm = new frmDetalleConsecutivo(int.Parse(grdDatos.Rows[e.RowIndex].Cells["id_rango_facturas"].Value.ToString()));
				frm.ShowDialog(this);
			}
		}

		private void btnEliminar_Click(object sender, EventArgs e)
		{
			eliminarConsecutivo();
		}

		private void eliminarConsecutivo()
		{
			if (grdDatos.Rows != null && grdDatos.Rows.Count > 0 && grdDatos.SelectedRows != null && grdDatos.SelectedRows.Count > 0)
			{
				if (MessageBox.Show("¿Está seguro(a) que desea eliminar el rango de facturas seleccionado?","Confirmar eliminación", MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2) == DialogResult.Yes)
				{
					int id = int.Parse(grdDatos.SelectedRows[0].Cells["id_rango_facturas"].Value.ToString());
					Facturaconsecutivodetalle facturaconsecutivodetalle = new Facturaconsecutivodetalle();
					facturaconsecutivodetalle.ID_FACTURACONSECUTIVO = id;
					facturaconsecutivodetalle.DISPONIBLE = "NO";
					Facturaconsecutivodetalle[] lstDetalles = serviciosFacturaconsecutivodetalle.buscarFacturaconsecutivodetalle(facturaconsecutivodetalle);
					if (lstDetalles != null && lstDetalles.Length > 0)
					{
						MessageBox.Show("No es posible eliminar el rango de facturas seleccionado ya que hay facturas generadas con este rango", "No es posible", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					else
					{
						FACTURACONSECUTIVO fACTURACONSECUTIVO = new FACTURACONSECUTIVO();
						fACTURACONSECUTIVO.ID = id;
						fACTURACONSECUTIVO = serviciosFACTURACONSECUTIVO.buscarPrimeroFACTURACONSECUTIVO(fACTURACONSECUTIVO);
						if (fACTURACONSECUTIVO != null && fACTURACONSECUTIVO.ID > 0)
						{
							if (serviciosFACTURACONSECUTIVO.eliminarFACTURACONSECUTIVO(fACTURACONSECUTIVO))
							{
								MessageBox.Show("Se eliminó correctamente el rango de facturas seleccionado", "Eliminación correcta", MessageBoxButtons.OK, MessageBoxIcon.Information);
								getDetalleRangos();
							}
							else
								MessageBox.Show("Ocurrio un error y no se eliminó correctamente el rango de facturas seleccionado", "Eliminación incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
						else
							MessageBox.Show("No se encontró el consecutivo en el sistema", "Sin información", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
				}
			}
			else
				MessageBox.Show("Debe seleccionar un rango de facturas de la lista", "Sin datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
	}
}
