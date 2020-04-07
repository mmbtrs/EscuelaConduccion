namespace EscuelaConduccion
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clienteProveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestiónClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestiónProveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.liquidacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.liquidaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acuerdoDePagoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestiónRecibofacturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pagarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.anularReciboToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.anularPagoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestiónVigenciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consecutivosDIANToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tarifasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestiónTarifasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestiónCategoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteProveedorToolStripMenuItem,
            this.liquidacionToolStripMenuItem,
            this.configuraciónToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 40);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // clienteProveedorToolStripMenuItem
            // 
            this.clienteProveedorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestiónClienteToolStripMenuItem,
            this.gestiónProveedorToolStripMenuItem});
            this.clienteProveedorToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clienteProveedorToolStripMenuItem.Image = global::EscuelaConduccion.Properties.Resources.ciente_proveedor_32x32;
            this.clienteProveedorToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.clienteProveedorToolStripMenuItem.Name = "clienteProveedorToolStripMenuItem";
            this.clienteProveedorToolStripMenuItem.Size = new System.Drawing.Size(170, 36);
            this.clienteProveedorToolStripMenuItem.Text = "Cliente/Proveedor";
            // 
            // gestiónClienteToolStripMenuItem
            // 
            this.gestiónClienteToolStripMenuItem.Image = global::EscuelaConduccion.Properties.Resources.person_32x32;
            this.gestiónClienteToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.gestiónClienteToolStripMenuItem.Name = "gestiónClienteToolStripMenuItem";
            this.gestiónClienteToolStripMenuItem.Size = new System.Drawing.Size(217, 38);
            this.gestiónClienteToolStripMenuItem.Text = "Gestión Cliente";
            this.gestiónClienteToolStripMenuItem.Click += new System.EventHandler(this.gestiónClienteToolStripMenuItem_Click);
            // 
            // gestiónProveedorToolStripMenuItem
            // 
            this.gestiónProveedorToolStripMenuItem.Image = global::EscuelaConduccion.Properties.Resources.cliente_proveedor_32x32;
            this.gestiónProveedorToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.gestiónProveedorToolStripMenuItem.Name = "gestiónProveedorToolStripMenuItem";
            this.gestiónProveedorToolStripMenuItem.Size = new System.Drawing.Size(217, 38);
            this.gestiónProveedorToolStripMenuItem.Text = "Gestión Proveedor";
            // 
            // liquidacionToolStripMenuItem
            // 
            this.liquidacionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.liquidaciónToolStripMenuItem,
            this.acuerdoDePagoToolStripMenuItem,
            this.gestiónRecibofacturaToolStripMenuItem});
            this.liquidacionToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.liquidacionToolStripMenuItem.Image = global::EscuelaConduccion.Properties.Resources.caja_32x32;
            this.liquidacionToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.liquidacionToolStripMenuItem.Name = "liquidacionToolStripMenuItem";
            this.liquidacionToolStripMenuItem.Size = new System.Drawing.Size(126, 36);
            this.liquidacionToolStripMenuItem.Text = "Liquidación";
            // 
            // liquidaciónToolStripMenuItem
            // 
            this.liquidaciónToolStripMenuItem.AutoSize = false;
            this.liquidaciónToolStripMenuItem.Image = global::EscuelaConduccion.Properties.Resources.Calculadora_32x32;
            this.liquidaciónToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.liquidaciónToolStripMenuItem.Name = "liquidaciónToolStripMenuItem";
            this.liquidaciónToolStripMenuItem.Size = new System.Drawing.Size(234, 38);
            this.liquidaciónToolStripMenuItem.Text = "Liquidación";
            this.liquidaciónToolStripMenuItem.Click += new System.EventHandler(this.liquidaciónToolStripMenuItem_Click);
            // 
            // acuerdoDePagoToolStripMenuItem
            // 
            this.acuerdoDePagoToolStripMenuItem.Image = global::EscuelaConduccion.Properties.Resources.iconfinder_3_3319636;
            this.acuerdoDePagoToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.acuerdoDePagoToolStripMenuItem.Name = "acuerdoDePagoToolStripMenuItem";
            this.acuerdoDePagoToolStripMenuItem.Size = new System.Drawing.Size(249, 38);
            this.acuerdoDePagoToolStripMenuItem.Text = "Acuerdo de Pago";
            this.acuerdoDePagoToolStripMenuItem.Click += new System.EventHandler(this.acuerdoDePagoToolStripMenuItem_Click);
            // 
            // gestiónRecibofacturaToolStripMenuItem
            // 
            this.gestiónRecibofacturaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buscarToolStripMenuItem,
            this.pagarToolStripMenuItem,
            this.anularReciboToolStripMenuItem,
            this.anularPagoToolStripMenuItem});
            this.gestiónRecibofacturaToolStripMenuItem.Image = global::EscuelaConduccion.Properties.Resources.recibo_32x32;
            this.gestiónRecibofacturaToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.gestiónRecibofacturaToolStripMenuItem.Name = "gestiónRecibofacturaToolStripMenuItem";
            this.gestiónRecibofacturaToolStripMenuItem.Size = new System.Drawing.Size(249, 38);
            this.gestiónRecibofacturaToolStripMenuItem.Text = "Gestión Recibo/Factura";
            // 
            // buscarToolStripMenuItem
            // 
            this.buscarToolStripMenuItem.Image = global::EscuelaConduccion.Properties.Resources.buscarFactura_32x32;
            this.buscarToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.buscarToolStripMenuItem.Name = "buscarToolStripMenuItem";
            this.buscarToolStripMenuItem.Size = new System.Drawing.Size(184, 38);
            this.buscarToolStripMenuItem.Text = "Buscar";
            this.buscarToolStripMenuItem.Click += new System.EventHandler(this.buscarToolStripMenuItem_Click);
            // 
            // pagarToolStripMenuItem
            // 
            this.pagarToolStripMenuItem.Image = global::EscuelaConduccion.Properties.Resources.money_32x32;
            this.pagarToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.pagarToolStripMenuItem.Name = "pagarToolStripMenuItem";
            this.pagarToolStripMenuItem.Size = new System.Drawing.Size(184, 38);
            this.pagarToolStripMenuItem.Text = "Pagar";
            this.pagarToolStripMenuItem.Click += new System.EventHandler(this.pagarToolStripMenuItem_Click);
            // 
            // anularReciboToolStripMenuItem
            // 
            this.anularReciboToolStripMenuItem.Image = global::EscuelaConduccion.Properties.Resources.anularFactura_32x32;
            this.anularReciboToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.anularReciboToolStripMenuItem.Name = "anularReciboToolStripMenuItem";
            this.anularReciboToolStripMenuItem.Size = new System.Drawing.Size(184, 38);
            this.anularReciboToolStripMenuItem.Text = "Anular Recibo";
            this.anularReciboToolStripMenuItem.Click += new System.EventHandler(this.anularReciboToolStripMenuItem_Click);
            // 
            // anularPagoToolStripMenuItem
            // 
            this.anularPagoToolStripMenuItem.Image = global::EscuelaConduccion.Properties.Resources.anularPago_32x32;
            this.anularPagoToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.anularPagoToolStripMenuItem.Name = "anularPagoToolStripMenuItem";
            this.anularPagoToolStripMenuItem.Size = new System.Drawing.Size(184, 38);
            this.anularPagoToolStripMenuItem.Text = "Anular Pago";
            this.anularPagoToolStripMenuItem.Click += new System.EventHandler(this.anularPagoToolStripMenuItem_Click);
            // 
            // configuraciónToolStripMenuItem
            // 
            this.configuraciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestiónVigenciasToolStripMenuItem,
            this.consecutivosDIANToolStripMenuItem,
            this.tarifasToolStripMenuItem});
            this.configuraciónToolStripMenuItem.Image = global::EscuelaConduccion.Properties.Resources.configuracion_32x32;
            this.configuraciónToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.configuraciónToolStripMenuItem.Name = "configuraciónToolStripMenuItem";
            this.configuraciónToolStripMenuItem.Size = new System.Drawing.Size(146, 36);
            this.configuraciónToolStripMenuItem.Text = "Configuración";
            // 
            // gestiónVigenciasToolStripMenuItem
            // 
            this.gestiónVigenciasToolStripMenuItem.Image = global::EscuelaConduccion.Properties.Resources.vigencia_32x32;
            this.gestiónVigenciasToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.gestiónVigenciasToolStripMenuItem.Name = "gestiónVigenciasToolStripMenuItem";
            this.gestiónVigenciasToolStripMenuItem.Size = new System.Drawing.Size(220, 38);
            this.gestiónVigenciasToolStripMenuItem.Text = "Gestión Vigencias";
            this.gestiónVigenciasToolStripMenuItem.Click += new System.EventHandler(this.gestiónVigenciasToolStripMenuItem_Click);
            // 
            // consecutivosDIANToolStripMenuItem
            // 
            this.consecutivosDIANToolStripMenuItem.Image = global::EscuelaConduccion.Properties.Resources.rango_32x32;
            this.consecutivosDIANToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.consecutivosDIANToolStripMenuItem.Name = "consecutivosDIANToolStripMenuItem";
            this.consecutivosDIANToolStripMenuItem.Size = new System.Drawing.Size(220, 38);
            this.consecutivosDIANToolStripMenuItem.Text = "Consecutivos DIAN";
            this.consecutivosDIANToolStripMenuItem.Click += new System.EventHandler(this.consecutivosDIANToolStripMenuItem_Click);
            // 
            // tarifasToolStripMenuItem
            // 
            this.tarifasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestiónTarifasToolStripMenuItem,
            this.gestiónCategoriasToolStripMenuItem});
            this.tarifasToolStripMenuItem.Image = global::EscuelaConduccion.Properties.Resources.tarifaBlue_32x32;
            this.tarifasToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tarifasToolStripMenuItem.Name = "tarifasToolStripMenuItem";
            this.tarifasToolStripMenuItem.Size = new System.Drawing.Size(220, 38);
            this.tarifasToolStripMenuItem.Text = "Tarifas";
            // 
            // gestiónTarifasToolStripMenuItem
            // 
            this.gestiónTarifasToolStripMenuItem.Image = global::EscuelaConduccion.Properties.Resources.tarifaConfigBlue_32x32;
            this.gestiónTarifasToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.gestiónTarifasToolStripMenuItem.Name = "gestiónTarifasToolStripMenuItem";
            this.gestiónTarifasToolStripMenuItem.Size = new System.Drawing.Size(219, 38);
            this.gestiónTarifasToolStripMenuItem.Text = "Gestión Tarifas";
            this.gestiónTarifasToolStripMenuItem.Click += new System.EventHandler(this.gestiónTarifasToolStripMenuItem_Click);
            // 
            // gestiónCategoriasToolStripMenuItem
            // 
            this.gestiónCategoriasToolStripMenuItem.Image = global::EscuelaConduccion.Properties.Resources.categoria_32x32;
            this.gestiónCategoriasToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.gestiónCategoriasToolStripMenuItem.Name = "gestiónCategoriasToolStripMenuItem";
            this.gestiónCategoriasToolStripMenuItem.Size = new System.Drawing.Size(219, 38);
            this.gestiónCategoriasToolStripMenuItem.Text = "Gestión Categorias";
            this.gestiónCategoriasToolStripMenuItem.Click += new System.EventHandler(this.gestiónCategoriasToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EscuelaConduccion.Properties.Resources.fondo_con_logo1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conducimos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clienteProveedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestiónClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestiónProveedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem liquidacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem liquidaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acuerdoDePagoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestiónRecibofacturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pagarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem anularReciboToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem anularPagoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuraciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consecutivosDIANToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestiónVigenciasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tarifasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestiónTarifasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestiónCategoriasToolStripMenuItem;
    }
}

