using EscuelaConduccion.Modelo.Accesorias;
using EscuelaConduccion.Modelo.Cliente;
using EscuelaConduccion.Modelo.Facturas;
using EscuelaConduccion.Modelo.Liquidacion;
using EscuelaConduccion.Modelo.Tarifas;
using EscuelaConduccion.Modelo.Vigencia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscuelaConduccion
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void gestiónClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGestionCliente frm = new frmGestionCliente();
            frm.ShowDialog(this);
        }

        private void liquidaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLiquidar frm = new frmLiquidar();
            frm.ShowDialog(this);
        }

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBuscarReciboFactura frm = new frmBuscarReciboFactura();
            frm.Show();
        }

        private void gestiónConsecutivosFacturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void pagarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPagarRecibo frm = new frmPagarRecibo();
            frm.Show();
        }

        private void acuerdoDePagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmViewAcuerdoPago frm = new frmViewAcuerdoPago();
            frm.ShowDialog(this);
        }

        private void anularReciboToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBuscarReciboFactura frm = new frmBuscarReciboFactura();
            frm.Show();
        }

        private void anularPagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBuscarReciboFactura frm = new frmBuscarReciboFactura();
            frm.Show();
        }

        private void gestiónVigenciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGestionVigencia frm = new frmGestionVigencia();
            frm.Show();
        }

        private void gestiónTarifasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGestionTarifas frm = new frmGestionTarifas();
            frm.Show();
        }

        private void consecutivosDIANToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGestionConsecutivosFactura frm = new frmGestionConsecutivosFactura();
            frm.ShowDialog(this);
        }

        private void gestiónCategoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGestionCategoria frm = new frmGestionCategoria();
            frm.Show();
        }
    }
}
