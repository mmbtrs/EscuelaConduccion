namespace EscuelaConduccion.Modelo.Liquidacion
{
    partial class frmBuscarLiquidacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBuscarLiquidacion));
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIdentificacion = new System.Windows.Forms.TextBox();
            this.cmbTipoDocumento = new System.Windows.Forms.ComboBox();
            this.panCliente = new System.Windows.Forms.Panel();
            this.lblInfoCliente = new System.Windows.Forms.Label();
            this.grdLiquidaciones = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA_LIQUIDACION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TARIFA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdLiquidaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(212)))), ((int)(((byte)(248)))));
            this.panel3.Controls.Add(this.btnSalir);
            this.panel3.Controls.Add(this.btnGuardar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 405);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(594, 45);
            this.panel3.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(212)))), ((int)(((byte)(248)))));
            this.panel2.Controls.Add(this.lblTitulo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(594, 42);
            this.panel2.TabIndex = 17;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Black;
            this.lblTitulo.Location = new System.Drawing.Point(3, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(588, 20);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Buscar Liquidación";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtIdentificacion);
            this.panel1.Controls.Add(this.cmbTipoDocumento);
            this.panel1.Location = new System.Drawing.Point(12, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(543, 57);
            this.panel1.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(227, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Número de documento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(5, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Tipo de documento:";
            // 
            // txtIdentificacion
            // 
            this.txtIdentificacion.Location = new System.Drawing.Point(230, 26);
            this.txtIdentificacion.MaxLength = 20;
            this.txtIdentificacion.Name = "txtIdentificacion";
            this.txtIdentificacion.Size = new System.Drawing.Size(210, 20);
            this.txtIdentificacion.TabIndex = 12;
            // 
            // cmbTipoDocumento
            // 
            this.cmbTipoDocumento.DisplayMember = "TIPO";
            this.cmbTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoDocumento.FormattingEnabled = true;
            this.cmbTipoDocumento.Location = new System.Drawing.Point(8, 25);
            this.cmbTipoDocumento.Name = "cmbTipoDocumento";
            this.cmbTipoDocumento.Size = new System.Drawing.Size(216, 21);
            this.cmbTipoDocumento.TabIndex = 11;
            this.cmbTipoDocumento.ValueMember = "ID";
            // 
            // panCliente
            // 
            this.panCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panCliente.Controls.Add(this.lblInfoCliente);
            this.panCliente.Location = new System.Drawing.Point(12, 120);
            this.panCliente.Name = "panCliente";
            this.panCliente.Size = new System.Drawing.Size(63, 29);
            this.panCliente.TabIndex = 21;
            this.panCliente.Visible = false;
            // 
            // lblInfoCliente
            // 
            this.lblInfoCliente.AutoSize = true;
            this.lblInfoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.lblInfoCliente.Location = new System.Drawing.Point(5, 6);
            this.lblInfoCliente.Name = "lblInfoCliente";
            this.lblInfoCliente.Size = new System.Drawing.Size(51, 16);
            this.lblInfoCliente.TabIndex = 0;
            this.lblInfoCliente.Text = "label1";
            // 
            // grdLiquidaciones
            // 
            this.grdLiquidaciones.AllowUserToAddRows = false;
            this.grdLiquidaciones.AllowUserToDeleteRows = false;
            this.grdLiquidaciones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdLiquidaciones.BackgroundColor = System.Drawing.Color.White;
            this.grdLiquidaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdLiquidaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.TIPO,
            this.FECHA_LIQUIDACION,
            this.TOTAL,
            this.TARIFA});
            this.grdLiquidaciones.Location = new System.Drawing.Point(12, 155);
            this.grdLiquidaciones.MultiSelect = false;
            this.grdLiquidaciones.Name = "grdLiquidaciones";
            this.grdLiquidaciones.ReadOnly = true;
            this.grdLiquidaciones.RowHeadersVisible = false;
            this.grdLiquidaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdLiquidaciones.Size = new System.Drawing.Size(568, 235);
            this.grdLiquidaciones.TabIndex = 22;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // TIPO
            // 
            this.TIPO.HeaderText = "TIPO";
            this.TIPO.Name = "TIPO";
            this.TIPO.ReadOnly = true;
            this.TIPO.Width = 50;
            // 
            // FECHA_LIQUIDACION
            // 
            this.FECHA_LIQUIDACION.HeaderText = "FECHA LIQUIDACIÓN";
            this.FECHA_LIQUIDACION.Name = "FECHA_LIQUIDACION";
            this.FECHA_LIQUIDACION.ReadOnly = true;
            // 
            // TOTAL
            // 
            this.TOTAL.HeaderText = "TOTAL";
            this.TOTAL.Name = "TOTAL";
            this.TOTAL.ReadOnly = true;
            // 
            // TARIFA
            // 
            this.TARIFA.HeaderText = "TARIFA";
            this.TARIFA.Name = "TARIFA";
            this.TARIFA.ReadOnly = true;
            this.TARIFA.Width = 300;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(210)))), ((int)(((byte)(138)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscar.Image = global::EscuelaConduccion.Properties.Resources.search_24x24;
            this.btnBuscar.Location = new System.Drawing.Point(446, 13);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(86, 33);
            this.btnBuscar.TabIndex = 15;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalir.Image = global::EscuelaConduccion.Properties.Resources.exit_22x22;
            this.btnSalir.Location = new System.Drawing.Point(494, 6);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(86, 33);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(210)))), ((int)(((byte)(138)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardar.Image = global::EscuelaConduccion.Properties.Resources.ok_24x24;
            this.btnGuardar.Location = new System.Drawing.Point(402, 6);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(86, 33);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Aceptar";
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // frmBuscarLiquidacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(129)))), ((int)(((byte)(193)))));
            this.ClientSize = new System.Drawing.Size(594, 450);
            this.Controls.Add(this.grdLiquidaciones);
            this.Controls.Add(this.panCliente);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(610, 489);
            this.MinimumSize = new System.Drawing.Size(610, 489);
            this.Name = "frmBuscarLiquidacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Liquidación";
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panCliente.ResumeLayout(false);
            this.panCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdLiquidaciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Panel panel3;
        protected System.Windows.Forms.Button btnSalir;
        protected System.Windows.Forms.Button btnGuardar;
        protected System.Windows.Forms.Panel panel2;
        protected System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIdentificacion;
        private System.Windows.Forms.ComboBox cmbTipoDocumento;
        private System.Windows.Forms.Panel panCliente;
        private System.Windows.Forms.Label lblInfoCliente;
        private System.Windows.Forms.DataGridView grdLiquidaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPO;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA_LIQUIDACION;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn TARIFA;
    }
}