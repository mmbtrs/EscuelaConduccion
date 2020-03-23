using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscuelaConduccion.Modelo.Liquidacion
{
    public partial class frmTipoLiquidacion : Form
    {
        public frmTipoLiquidacion()
        {
            InitializeComponent();
        }

        private void btnOpcion1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
        }

        private void btnOpcion2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
        }
    }
}
