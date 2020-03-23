using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscuelaConduccion.Modelo.Facturas
{
    public partial class frmGestionConsecutivosFactura : Form
    {
        public frmGestionConsecutivosFactura()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            frmCrearConsecutivo frm = new frmCrearConsecutivo();
            frm.ShowDialog(this);
        }
    }
}
