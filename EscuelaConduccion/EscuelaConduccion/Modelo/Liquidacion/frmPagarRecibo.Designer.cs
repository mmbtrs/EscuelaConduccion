namespace EscuelaConduccion.Modelo.Liquidacion
{
    partial class frmPagarRecibo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPagarRecibo));
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNumRecibo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.datFechaPago = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblValorRecibo = new System.Windows.Forms.Label();
            this.lblTipoPago = new System.Windows.Forms.Label();
            this.lblFacturaDian = new System.Windows.Forms.Label();
            this.grdFormaPago = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblDiferencia = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnVerRecibo = new System.Windows.Forms.Button();
            this.btnPagar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdFormaPago)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(212)))), ((int)(((byte)(248)))));
            this.panel3.Controls.Add(this.btnSalir);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 494);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(374, 45);
            this.panel3.TabIndex = 21;
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalir.Image = global::EscuelaConduccion.Properties.Resources.exit_22x22;
            this.btnSalir.Location = new System.Drawing.Point(279, 6);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(86, 33);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(212)))), ((int)(((byte)(248)))));
            this.panel2.Controls.Add(this.lblTitulo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(374, 42);
            this.panel2.TabIndex = 20;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Black;
            this.lblTitulo.Location = new System.Drawing.Point(3, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(368, 20);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Pagar Recibo";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(9, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 16);
            this.label7.TabIndex = 23;
            this.label7.Text = "Número de recibo";
            // 
            // txtNumRecibo
            // 
            this.txtNumRecibo.Location = new System.Drawing.Point(131, 63);
            this.txtNumRecibo.MaxLength = 20;
            this.txtNumRecibo.Name = "txtNumRecibo";
            this.txtNumRecibo.Size = new System.Drawing.Size(141, 20);
            this.txtNumRecibo.TabIndex = 22;
            this.txtNumRecibo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumRecibo_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Chartreuse;
            this.label1.Location = new System.Drawing.Point(64, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 18);
            this.label1.TabIndex = 25;
            this.label1.Text = "Cliente: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Chartreuse;
            this.label2.Location = new System.Drawing.Point(30, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 18);
            this.label2.TabIndex = 25;
            this.label2.Text = "Valor recibo: ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(43, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 16);
            this.label3.TabIndex = 23;
            this.label3.Text = "Fecha pago";
            // 
            // datFechaPago
            // 
            this.datFechaPago.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datFechaPago.Location = new System.Drawing.Point(131, 102);
            this.datFechaPago.Name = "datFechaPago";
            this.datFechaPago.Size = new System.Drawing.Size(140, 20);
            this.datFechaPago.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Chartreuse;
            this.label4.Location = new System.Drawing.Point(43, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 18);
            this.label4.TabIndex = 25;
            this.label4.Text = "Tipo pago: ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Chartreuse;
            this.label5.Location = new System.Drawing.Point(21, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 18);
            this.label5.TabIndex = 25;
            this.label5.Text = "Factura DIAN:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.ForeColor = System.Drawing.Color.Chartreuse;
            this.lblCliente.Location = new System.Drawing.Point(121, 143);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(61, 18);
            this.lblCliente.TabIndex = 25;
            this.lblCliente.Text = "Cliente: ";
            // 
            // lblValorRecibo
            // 
            this.lblValorRecibo.AutoSize = true;
            this.lblValorRecibo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorRecibo.ForeColor = System.Drawing.Color.Chartreuse;
            this.lblValorRecibo.Location = new System.Drawing.Point(121, 161);
            this.lblValorRecibo.Name = "lblValorRecibo";
            this.lblValorRecibo.Size = new System.Drawing.Size(61, 18);
            this.lblValorRecibo.TabIndex = 25;
            this.lblValorRecibo.Text = "Cliente: ";
            // 
            // lblTipoPago
            // 
            this.lblTipoPago.AutoSize = true;
            this.lblTipoPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoPago.ForeColor = System.Drawing.Color.Chartreuse;
            this.lblTipoPago.Location = new System.Drawing.Point(121, 179);
            this.lblTipoPago.Name = "lblTipoPago";
            this.lblTipoPago.Size = new System.Drawing.Size(61, 18);
            this.lblTipoPago.TabIndex = 25;
            this.lblTipoPago.Text = "Cliente: ";
            // 
            // lblFacturaDian
            // 
            this.lblFacturaDian.AutoSize = true;
            this.lblFacturaDian.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFacturaDian.ForeColor = System.Drawing.Color.Chartreuse;
            this.lblFacturaDian.Location = new System.Drawing.Point(121, 197);
            this.lblFacturaDian.Name = "lblFacturaDian";
            this.lblFacturaDian.Size = new System.Drawing.Size(61, 18);
            this.lblFacturaDian.TabIndex = 25;
            this.lblFacturaDian.Text = "Cliente: ";
            // 
            // grdFormaPago
            // 
            this.grdFormaPago.AllowUserToAddRows = false;
            this.grdFormaPago.AllowUserToDeleteRows = false;
            this.grdFormaPago.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdFormaPago.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdFormaPago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdFormaPago.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.tipo_pago,
            this.valor});
            this.grdFormaPago.Location = new System.Drawing.Point(12, 250);
            this.grdFormaPago.MultiSelect = false;
            this.grdFormaPago.Name = "grdFormaPago";
            this.grdFormaPago.RowHeadersVisible = false;
            this.grdFormaPago.Size = new System.Drawing.Size(350, 139);
            this.grdFormaPago.TabIndex = 27;
            this.grdFormaPago.CurrentCellDirtyStateChanged += new System.EventHandler(this.grdFormaPago_CurrentCellDirtyStateChanged);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // tipo_pago
            // 
            this.tipo_pago.HeaderText = "TIPO DE PAGO";
            this.tipo_pago.Name = "tipo_pago";
            this.tipo_pago.ReadOnly = true;
            this.tipo_pago.Width = 165;
            // 
            // valor
            // 
            this.valor.HeaderText = "VALOR";
            this.valor.Name = "valor";
            this.valor.Width = 165;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(9, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 16);
            this.label6.TabIndex = 23;
            this.label6.Text = "Forma de pago";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.Chartreuse;
            this.lblTotal.Location = new System.Drawing.Point(161, 395);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(61, 18);
            this.lblTotal.TabIndex = 25;
            this.lblTotal.Text = "Cliente: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Chartreuse;
            this.label9.Location = new System.Drawing.Point(12, 395);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(151, 18);
            this.label9.TabIndex = 25;
            this.label9.Text = "Total suma de pagos:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblDiferencia
            // 
            this.lblDiferencia.AutoSize = true;
            this.lblDiferencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiferencia.ForeColor = System.Drawing.Color.Chartreuse;
            this.lblDiferencia.Location = new System.Drawing.Point(161, 413);
            this.lblDiferencia.Name = "lblDiferencia";
            this.lblDiferencia.Size = new System.Drawing.Size(61, 18);
            this.lblDiferencia.TabIndex = 25;
            this.lblDiferencia.Text = "Cliente: ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Chartreuse;
            this.label11.Location = new System.Drawing.Point(85, 413);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 18);
            this.label11.TabIndex = 25;
            this.label11.Text = "Diferencia:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::EscuelaConduccion.Properties.Resources.minus_32x32;
            this.pictureBox2.Location = new System.Drawing.Point(292, 212);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 29;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EscuelaConduccion.Properties.Resources.more_32x32;
            this.pictureBox1.Location = new System.Drawing.Point(330, 212);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // btnVerRecibo
            // 
            this.btnVerRecibo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(212)))), ((int)(((byte)(248)))));
            this.btnVerRecibo.Enabled = false;
            this.btnVerRecibo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVerRecibo.Image = global::EscuelaConduccion.Properties.Resources.acrobat_32x32;
            this.btnVerRecibo.Location = new System.Drawing.Point(259, 441);
            this.btnVerRecibo.Name = "btnVerRecibo";
            this.btnVerRecibo.Size = new System.Drawing.Size(103, 38);
            this.btnVerRecibo.TabIndex = 28;
            this.btnVerRecibo.Text = "Generar Factura";
            this.btnVerRecibo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVerRecibo.UseVisualStyleBackColor = false;
            this.btnVerRecibo.Click += new System.EventHandler(this.btnVerRecibo_Click);
            // 
            // btnPagar
            // 
            this.btnPagar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPagar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(210)))), ((int)(((byte)(138)))));
            this.btnPagar.Enabled = false;
            this.btnPagar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPagar.Image = global::EscuelaConduccion.Properties.Resources.money_32x32;
            this.btnPagar.Location = new System.Drawing.Point(167, 441);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(86, 38);
            this.btnPagar.TabIndex = 10;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPagar.UseVisualStyleBackColor = false;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(210)))), ((int)(((byte)(138)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscar.Image = global::EscuelaConduccion.Properties.Resources.search_24x24;
            this.btnBuscar.Location = new System.Drawing.Point(276, 50);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(86, 33);
            this.btnBuscar.TabIndex = 24;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // frmPagarRecibo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(129)))), ((int)(((byte)(193)))));
            this.ClientSize = new System.Drawing.Size(374, 539);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnVerRecibo);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.grdFormaPago);
            this.Controls.Add(this.datFechaPago);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblDiferencia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblFacturaDian);
            this.Controls.Add(this.lblTipoPago);
            this.Controls.Add(this.lblValorRecibo);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNumRecibo);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(390, 578);
            this.MinimumSize = new System.Drawing.Size(390, 578);
            this.Name = "frmPagarRecibo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pagar Recibo";
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdFormaPago)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Panel panel3;
        protected System.Windows.Forms.Button btnPagar;
        protected System.Windows.Forms.Button btnSalir;
        protected System.Windows.Forms.Panel panel2;
        protected System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNumRecibo;
        public System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker datFechaPago;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblValorRecibo;
        private System.Windows.Forms.Label lblTipoPago;
        private System.Windows.Forms.Label lblFacturaDian;
        private System.Windows.Forms.DataGridView grdFormaPago;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnVerRecibo;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblDiferencia;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_pago;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor;
    }
}