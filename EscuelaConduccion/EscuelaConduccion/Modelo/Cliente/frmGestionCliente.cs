using EscuelaConduccion.wsServiciosCLIENTE;
using EscuelaConduccion.wsServiciosVIEW_CLIENTE;
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

namespace EscuelaConduccion.Modelo.Cliente
{
    public partial class frmGestionCliente : Form
    {
        ServiciosVIEW_CLIENTE serviciosVIEW_CLIENTE;
        ServiciosCLIENTE serviciosCLIENTE;
        List<VIEW_CLIENTE> MyClientes;

        public frmGestionCliente()
        {
            InitializeComponent();
            serviciosVIEW_CLIENTE = (ServiciosVIEW_CLIENTE)Configurador.ConfigurarServicio(typeof(ServiciosVIEW_CLIENTE));
            serviciosCLIENTE = (ServiciosCLIENTE)Configurador.ConfigurarServicio(typeof(ServiciosCLIENTE));
            getClientes();
            cmbFiltro.SelectedIndex = 0;
        }

        private List<VIEW_CLIENTE> buscarCliente(String valor)
        {
            if (cmbFiltro.SelectedIndex == 0)
            {
                IEnumerable<VIEW_CLIENTE> resultado = from cliente in MyClientes where cliente.IDENTIFICACION.ToUpper().Contains(valor.ToUpper()) select cliente;
                List<VIEW_CLIENTE> lista = resultado.ToList();
                return lista;
            }
            if (cmbFiltro.SelectedIndex == 1)
            {
                IEnumerable<VIEW_CLIENTE> resultado = from cliente in MyClientes where cliente.NOMBRES.ToUpper().Contains(valor.ToUpper()) select cliente;
                List<VIEW_CLIENTE> lista = resultado.ToList();
                return lista;
            }
            if (cmbFiltro.SelectedIndex == 2)
            {
                IEnumerable<VIEW_CLIENTE> resultado = from cliente in MyClientes where cliente.APELLIDOS.ToUpper().Contains(valor.ToUpper()) select cliente;
                List<VIEW_CLIENTE> lista = resultado.ToList();
                return lista;
            }
            if (cmbFiltro.SelectedIndex == 3)
            {
                IEnumerable<VIEW_CLIENTE> resultado = from cliente in MyClientes where cliente.DIRECCION.ToUpper().Contains(valor.ToUpper()) select cliente;
                List<VIEW_CLIENTE> lista = resultado.ToList();
                return lista;
            }
            if (cmbFiltro.SelectedIndex == 4)
            {
                IEnumerable<VIEW_CLIENTE> resultado = from cliente in MyClientes where cliente.CIUDAD.ToUpper().Contains(valor.ToUpper()) select cliente;
                List<VIEW_CLIENTE> lista = resultado.ToList();
                return lista;
            }
            if (cmbFiltro.SelectedIndex == 5)
            {
                IEnumerable<VIEW_CLIENTE> resultado = from cliente in MyClientes where cliente.DEPARTAMENTO.ToUpper().Contains(valor.ToUpper()) select cliente;
                List<VIEW_CLIENTE> lista = resultado.ToList();
                return lista;
            }
            if (cmbFiltro.SelectedIndex == 6)
            {
                IEnumerable<VIEW_CLIENTE> resultado = from cliente in MyClientes where cliente.GENERO.ToUpper().Contains(valor.ToUpper()) select cliente;
                List<VIEW_CLIENTE> lista = resultado.ToList();
                return lista;
            }
            if (cmbFiltro.SelectedIndex == 7)
            {
                IEnumerable<VIEW_CLIENTE> resultado = from cliente in MyClientes where cliente.CELULAR.ToUpper().Contains(valor.ToUpper()) select cliente;
                List<VIEW_CLIENTE> lista = resultado.ToList();
                return lista;
            }
            if (cmbFiltro.SelectedIndex == 8)
            {
                IEnumerable<VIEW_CLIENTE> resultado = from cliente in MyClientes where cliente.CORREO.ToUpper().Contains(valor.ToUpper()) select cliente;
                List<VIEW_CLIENTE> lista = resultado.ToList();
                return lista;
            }
            return null;
        }

        private void getClientes()
        {
            try
            {
                VIEW_CLIENTE[] lstClientes = serviciosVIEW_CLIENTE.listarVIEW_CLIENTE();
                if (lstClientes != null && lstClientes.Length > 0)
                {
                    grdDatos.DataSource = null;
                    grdDatos.DataSource = lstClientes.ToList<VIEW_CLIENTE>();
                    MyClientes = lstClientes.ToList<VIEW_CLIENTE>();
                    grdDatos.Columns["ID"].Visible = false;
                }
                else
                {
                    grdDatos.DataSource = null;
                }
            }
            catch (Exception exp)
            {
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            frmCliente frm = new frmCliente(null, Utilidades.Funciones.operation.CREAR);
            frm.ShowDialog(this);
            getClientes();
        }

        private void eliminarCliente()
        {
            try
            {
                if (grdDatos.Rows.Count > 0 && grdDatos.SelectedRows.Count > 0)
                {
                    if (MessageBox.Show("¿Está seguro(a) que desea eliminar el cliente seleccionado " +
                                grdDatos.SelectedRows[0].Cells["NOMBRES"].Value.ToString() + " " + grdDatos.SelectedRows[0].Cells["APELLIDOS"].Value.ToString() +
                                "?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        CLIENTE tmpCliente = new CLIENTE();
                        tmpCliente.ID = int.Parse(grdDatos.SelectedRows[0].Cells["ID"].Value.ToString());
                        if (serviciosCLIENTE.eliminarCLIENTE(tmpCliente))
                        {
                            MessageBox.Show("Se eliminó la información del cliente correctamente", "Eliminación correcta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            getClientes();
                        }
                        else
                        {
                            MessageBox.Show("Ocurrio un error inesperado y no se eliminó la información del cliente correctamente", "Eliminación incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            getClientes();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione un cliente de la lista", "Seleccione un cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception exp)
            {
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminarCliente();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            CLIENTE tmpCpliente = new CLIENTE();
            if (grdDatos.Rows.Count > 0 && grdDatos.SelectedRows.Count > 0)
            {
                tmpCpliente.ID = int.Parse(grdDatos.SelectedRows[0].Cells["ID"].Value.ToString());
                frmCliente frm = new frmCliente(tmpCpliente, Utilidades.Funciones.operation.VER);
                frm.ShowDialog(this);
            }
            else
            {
                MessageBox.Show("Seleccione un cliente de la lista", "Seleccione un cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            CLIENTE tmpCpliente = new CLIENTE();
            if (grdDatos.Rows.Count > 0 && grdDatos.SelectedRows.Count > 0)
            {
                tmpCpliente.ID = int.Parse(grdDatos.SelectedRows[0].Cells["ID"].Value.ToString());
                frmCliente frm = new frmCliente(tmpCpliente, Utilidades.Funciones.operation.EDITAR);
                frm.ShowDialog(this);
                getClientes();
            }
            else
            {
                MessageBox.Show("Seleccione un cliente de la lista", "Seleccione un cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtValor_KeyUp(object sender, KeyEventArgs e)
        {
            grdDatos.DataSource = buscarCliente(txtValor.Text);
        }
    }
}
