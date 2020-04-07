using EscuelaConduccion.Modelo.Vigencia;
using EscuelaConduccion.wsServiciosSQL;
using EscuelaConduccion.wsServiciosTARIFA;
using EscuelaConduccion.wsServiciosTARIFA_DETALLE;
using EscuelaConduccion.wsServiciosVIGENCIA;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using UtilidadesServiciosWeb;
using static EscuelaConduccion.Utilidades.Funciones;

namespace EscuelaConduccion.Modelo.Tarifas
{
    public partial class frmGestionTarifas : Form
    {
        ServiciosVIGENCIA serviciosVIGENCIA;
        ServiciosTARIFA serviciosTARIFA;
        ServiciosTARIFA_DETALLE serviciosTARIFA_DETALLE;
        ServiciosSQL serviciosSQL;

        List<VIEW_TARIFA> myTarifas;
        List<VIEW_DETALLE_TARIFA> myDetalleTarifa;

        public frmGestionTarifas()
        {
            InitializeComponent();
            serviciosVIGENCIA = (ServiciosVIGENCIA)Configurador.ConfigurarServicio(typeof(ServiciosVIGENCIA));
            serviciosTARIFA = (ServiciosTARIFA)Configurador.ConfigurarServicio(typeof(ServiciosTARIFA));
            serviciosTARIFA_DETALLE = (ServiciosTARIFA_DETALLE)Configurador.ConfigurarServicio(typeof(ServiciosTARIFA_DETALLE));
            serviciosSQL = (ServiciosSQL)Configurador.ConfigurarServicio(typeof(ServiciosSQL));
            grdTarifas.AutoGenerateColumns = false;
            getVigencias();
            cmbFiltroDetalle.SelectedIndex = 0;
            cmbFiltroTarifa.SelectedIndex = 0;
            getTarifas();
        }

        private void getTarifas()
        {
            try
            {
                //grdTarifas.DataSource = null;
                grdTarifas.Rows.Clear();
                grdDetalleTarifa.DataSource = null;

                if (cmbVigencia.DataSource != null && cmbVigencia.Items.Count > 0)
                {
                    string sql =
                                @"SELECT
                    ROW_NUMBER() OVER(ORDER BY TARIFA.NOMBRE) AS No,
                    TARIFA.ID,
                    TARIFA.NOMBRE AS TARIFA,
                    TARIFA_CATEGORIA.NOMBRE AS CATEGORIA,
                    VIGENCIA.NOMBRE AS VIGENCIA,
                    CASE TARIFA.ESTADO
	                    WHEN 'A' THEN 'ACTIVA'
	                    ELSE 'INACTIVA'
                    END AS ESTADO
                    FROM 
                    TARIFA
                    LEFT JOIN TARIFA_CATEGORIA ON (TARIFA.ID_TARIFA_CATEGORIA = TARIFA_CATEGORIA.ID)
                    LEFT JOIN VIGENCIA ON (TARIFA.ID_VIGENCIA = VIGENCIA.ID)
                    WHERE TARIFA.ID_VIGENCIA = " + cmbVigencia.SelectedValue.ToString() +
                                " ORDER BY TARIFA.NOMBRE";
                    DataSet ds = serviciosSQL.consultaSQL(sql, "tarifas");
                    if (ds != null && ds.Tables != null &&
                        ds.Tables["tarifas"] != null && ds.Tables["tarifas"].Rows != null &&
                        ds.Tables["tarifas"].Rows.Count > 0)
                    {
                        myTarifas = new List<VIEW_TARIFA>();
                        foreach (DataRow fila in ds.Tables["tarifas"].Rows)
                        {
                            VIEW_TARIFA tarifa = new VIEW_TARIFA();
                            tarifa.No = int.Parse(fila["No"].ToString());
                            tarifa.ID = int.Parse(fila["ID"].ToString());
                            tarifa.TARIFA = fila["TARIFA"].ToString();
                            tarifa.CATEGORIA = fila["CATEGORIA"].ToString();
                            tarifa.VIGENCIA = int.Parse(fila["VIGENCIA"].ToString());
                            tarifa.ESTADO = fila["ESTADO"].ToString();
                            myTarifas.Add(tarifa);
                            grdTarifas.Rows.Add(tarifa.No, tarifa.ID, tarifa.TARIFA, tarifa.CATEGORIA, tarifa.VIGENCIA, tarifa.ESTADO);
                        }
                        

                        //grdTarifas.DataSource = myTarifas;
                        //if (myTarifas != null && myTarifas.Count > 0)
                        //{
                        //    
                        //    grdTarifas.Columns["ID"].Visible = false;
                        //    grdTarifas.Columns["No"].Width = 50;
                        //    grdTarifas.Columns["TARIFA"].Width = 200;
                        //    grdTarifas.Columns["CATEGORIA"].Width = 100;
                        //    grdTarifas.Columns["VIGENCIA"].Width = 100;
                        //    grdTarifas.Columns["ESTADO"].Width = 100; 
                        //}
                    }
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Ocurrio un error: " + exp.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void getTarifasDetalles(string ID)
        {
            try
            {
                string sql =
                    @"SELECT
                    ROW_NUMBER() OVER(ORDER BY TARIFA_CONCEPTO.NOMBRE) AS No,
                    TARIFA_DETALLE.ID,
                    TARIFA_CONCEPTO.NOMBRE AS CONCEPTO,
                    TARIFA_DETALLE.TERCERO,
                    TARIFA_DETALLE.FORMULA,
                    TARIFA_DETALLE.DESCONTABLE
                    FROM
                    TARIFA
                    INNER JOIN TARIFA_DETALLE ON (TARIFA.ID = TARIFA_DETALLE.ID_TARIFA)
                    INNER JOIN TARIFA_CONCEPTO ON (TARIFA_DETALLE.ID_TARIFA_CONCEPTO = TARIFA_CONCEPTO.ID)
                    WHERE 
                    TARIFA.ID = " + ID +
                    " ORDER BY TARIFA_CONCEPTO.NOMBRE";
                DataSet ds = serviciosSQL.consultaSQL(sql, "detalle_tarifas");
                grdDetalleTarifa.DataSource = null;
                if (ds != null && ds.Tables != null &&
                    ds.Tables["detalle_tarifas"] != null && ds.Tables["detalle_tarifas"].Rows != null &&
                    ds.Tables["detalle_tarifas"].Rows.Count > 0)
                {
                    myDetalleTarifa = new List<VIEW_DETALLE_TARIFA>();
                    foreach (DataRow fila in ds.Tables["detalle_tarifas"].Rows)
                    {
                        VIEW_DETALLE_TARIFA detalle = new VIEW_DETALLE_TARIFA();
                        detalle.No = int.Parse(fila["No"].ToString());
                        detalle.ID = int.Parse(fila["ID"].ToString());
                        detalle.CONCEPTO = fila["CONCEPTO"].ToString();
                        detalle.TERCERO = fila["TERCERO"].ToString();
                        detalle.FORMULA = fila["FORMULA"].ToString();
                        detalle.DESCONTABLE = fila["DESCONTABLE"].ToString();
                        myDetalleTarifa.Add(detalle);
                    }
                    grdDetalleTarifa.DataSource = myDetalleTarifa;
                    grdDetalleTarifa.Columns["ID"].Visible = false;
                    grdDetalleTarifa.Columns["No"].Width = 40;
                    grdDetalleTarifa.Columns["CONCEPTO"].Width = 140;
                    grdDetalleTarifa.Columns["TERCERO"].Width = 80;
                    grdDetalleTarifa.Columns["FORMULA"].Width = 150;
                    grdDetalleTarifa.Columns["DESCONTABLE"].Width = 130;
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Ocurrio un error: " + exp.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void cmbVigencia_SelectedIndexChanged(object sender, EventArgs e)
        {
            getTarifas();
        }

        private void grdTarifas_SelectionChanged(object sender, EventArgs e)
        {
        }

        private void grdTarifas_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (grdTarifas.Rows[e.RowIndex].Cells["ID"].Value != null)
                getTarifasDetalles(grdTarifas.Rows[e.RowIndex].Cells["ID"].Value.ToString());
        }

        private void btnGestionVigencia_Click(object sender, EventArgs e)
        {
            frmGestionVigencia frm = new frmGestionVigencia();
            frm.ShowDialog(this);
            getVigencias();
        }

        public List<VIEW_TARIFA> buscarTarifa(string valor)
        {
            if (cmbFiltroTarifa.SelectedIndex == 0)
            {
                IEnumerable<VIEW_TARIFA> resultado = from tarifa in myTarifas where tarifa.TARIFA.ToString().Contains(valor.ToUpper()) select tarifa;
                List<VIEW_TARIFA> lista = resultado.ToList();
                return lista;
            }
            if (cmbFiltroTarifa.SelectedIndex == 1)
            {
                IEnumerable<VIEW_TARIFA> resultado = from tarifa in myTarifas where tarifa.CATEGORIA.ToString().Contains(valor.ToUpper()) select tarifa;
                List<VIEW_TARIFA> lista = resultado.ToList();
                return lista;
            }
            return null;
        }

        public List<VIEW_DETALLE_TARIFA> buscarDetalleTarifa(string valor)
        {
            if (cmbFiltroDetalle.SelectedIndex == 0)
            {
                IEnumerable<VIEW_DETALLE_TARIFA> resultado = from detalle in myDetalleTarifa where detalle.CONCEPTO.ToString().Contains(valor.ToUpper()) select detalle;
                List<VIEW_DETALLE_TARIFA> lista = resultado.ToList();
                return lista;
            }
            if (cmbFiltroDetalle.SelectedIndex == 1)
            {
                IEnumerable<VIEW_DETALLE_TARIFA> resultado = from detalle in myDetalleTarifa where detalle.FORMULA.ToString().Contains(valor.ToUpper()) select detalle;
                List<VIEW_DETALLE_TARIFA> lista = resultado.ToList();
                return lista;
            }
            return null;
        }

        private void txtValorTarifa_KeyUp(object sender, KeyEventArgs e)
        {
            List<VIEW_TARIFA> lst = buscarTarifa(txtValorTarifa.Text);
            grdTarifas.Rows.Clear();
            if (lst != null && lst.Count > 0)
            {
                foreach (VIEW_TARIFA item in lst)
                {
                    grdTarifas.Rows.Add(item.No, item.ID, item.TARIFA, item.CATEGORIA, item.VIGENCIA, item.ESTADO);
                }
            }
        }

        private void txtValorDetalle_KeyUp(object sender, KeyEventArgs e)
        {
            grdDetalleTarifa.DataSource = buscarDetalleTarifa(txtValorDetalle.Text);
        }

        private void btnInsertarTarifa_Click(object sender, EventArgs e)
        {
            VIGENCIA vigencia = new VIGENCIA();
            vigencia.ID = int.Parse(cmbVigencia.SelectedValue.ToString());
            vigencia.NOMBRE = int.Parse(cmbVigencia.Text);
            frmTarifa frm = new frmTarifa(operation.CREAR, 0, vigencia);
            frm.ShowDialog(this);
            getTarifas();
        }

        private void btnEditarTarifa_Click(object sender, EventArgs e)
        {
            VIGENCIA vigencia = new VIGENCIA();
            vigencia.ID = int.Parse(cmbVigencia.SelectedValue.ToString());
            vigencia.NOMBRE = int.Parse(cmbVigencia.Text);
            frmTarifa frm = new frmTarifa(operation.EDITAR, int.Parse(grdTarifas.SelectedRows[0].Cells["ID"].Value.ToString()), vigencia);
            frm.ShowDialog(this);
            getTarifas();
        }

        private void btnInsertarDetalle_Click(object sender, EventArgs e)
        {
            if (grdTarifas.Rows != null && grdTarifas.Rows.Count > 0 && grdTarifas.SelectedRows != null && grdTarifas.SelectedRows.Count > 0)
            {
                frmDetalleTarifa frm = new frmDetalleTarifa(operation.CREAR, int.Parse(grdTarifas.SelectedRows[0].Cells["ID"].Value.ToString()), null);
                frm.ShowDialog(this);
                getTarifasDetalles(grdTarifas.SelectedRows[0].Cells["ID"].Value.ToString());
            }
            else
                MessageBox.Show("Debe seleccionar una tarifa de la lista", "Sin tarifa", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEditarDetalle_Click(object sender, EventArgs e)
        {
            if (grdTarifas.Rows != null && grdTarifas.Rows.Count > 0 && grdTarifas.SelectedRows != null && grdTarifas.SelectedRows.Count > 0)
            {
                if (grdDetalleTarifa.Rows != null && grdDetalleTarifa.Rows.Count > 0 && grdDetalleTarifa.SelectedRows != null && grdDetalleTarifa.SelectedRows.Count > 0)
                {
                    TARIFA_DETALLE detalle = new TARIFA_DETALLE();
                    detalle.ID = int.Parse(grdDetalleTarifa.SelectedRows[0].Cells["ID"].Value.ToString());
                    detalle = serviciosTARIFA_DETALLE.buscarPrimeroTARIFA_DETALLE(detalle);
                    if (detalle != null && detalle.ID > 0)
                    {
                        frmDetalleTarifa frm = new frmDetalleTarifa(operation.EDITAR, int.Parse(grdTarifas.SelectedRows[0].Cells["ID"].Value.ToString()), detalle);
                        frm.ShowDialog(this);
                        getTarifasDetalles(grdTarifas.SelectedRows[0].Cells["ID"].Value.ToString());  
                    }
                    else
                        MessageBox.Show("No se encontró el detalle de la tarifa seleccionado", "Sin detalle tarifa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Debe seleccionar un detalle de tarifa de la lista", "Sin detalle tarifa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Debe seleccionar una tarifa de la lista", "Sin tarifa", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCopiarVigencia_Click(object sender, EventArgs e)
        {
            frmDuplicarVigencia frm = new frmDuplicarVigencia();
            frm.ShowDialog(this);
            getVigencias();
        }

        private void btnEliminarTarifa_Click(object sender, EventArgs e)
        {
            eliminarTarifa();
        }

        private void eliminarTarifa()
        {
            if (grdTarifas.Rows != null && grdTarifas.Rows.Count > 0 &&
                grdTarifas.SelectedRows != null && grdTarifas.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("¿Está seguro(a) que desea eliminar la tarifa " + grdTarifas.SelectedRows[0].Cells["TARIFA"].Value.ToString() +
                    " y todos sus detalles?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    TARIFA tarifa = new TARIFA();
                    tarifa.ID = int.Parse(grdTarifas.SelectedRows[0].Cells["ID"].Value.ToString());
                    if (serviciosTARIFA.eliminarTARIFA(tarifa))
                    {
                        MessageBox.Show("Se eliminó correctamente la tarifa seleccionada", "Eliminación correcta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        getTarifas();
                    }
                    else
                        MessageBox.Show("Ocurrio un error y no se completó la leiminación correctamente", "Eliminación incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("Debe seleccionar una tarifa de la lista", "Sin tarifa", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void eliminarTarifaDetalle()
        {
            if (grdDetalleTarifa.Rows != null && grdDetalleTarifa.Rows.Count > 0 &&
                grdDetalleTarifa.SelectedRows != null && grdDetalleTarifa.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("¿Está seguro(a) que desea eliminar el detalle de tarifa " + grdDetalleTarifa.SelectedRows[0].Cells["CONCEPTO"].Value.ToString() +
                    "?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    TARIFA_DETALLE tarifaDetalle = new TARIFA_DETALLE();
                    tarifaDetalle.ID = int.Parse(grdDetalleTarifa.SelectedRows[0].Cells["ID"].Value.ToString());
                    if (serviciosTARIFA_DETALLE.eliminarTARIFA_DETALLE(tarifaDetalle))
                    {
                        MessageBox.Show("Se eliminó correctamente el detalle de la tarifa seleccionado", "Eliminación correcta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        getTarifasDetalles(grdTarifas.SelectedRows[0].Cells["ID"].Value.ToString());
                    }
                    else
                        MessageBox.Show("Ocurrió un error y no se completó la leiminación correctamente", "Eliminación incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("Debe seleccionar un detalle de tarifa de la lista", "Sin detalle de tarifa", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEliminarDetalle_Click(object sender, EventArgs e)
        {
            eliminarTarifaDetalle();
        }
    }

    public class VIEW_TARIFA
    {
        public int No { get; set; }
        public int ID { get; set; }
        public string TARIFA { get; set; }
        public string CATEGORIA { get; set; }
        public int VIGENCIA { get; set; }
        public string ESTADO { get; set; }
    }

    public class VIEW_DETALLE_TARIFA
    {
        public int ID { get; set; }
        public int No { get; set; }
        public string CONCEPTO { get; set; }
        public string TERCERO { get; set; }
        public string FORMULA { get; set; }
        public string DESCONTABLE { get; set; }
    }
}
