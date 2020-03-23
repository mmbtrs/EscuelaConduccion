namespace EscuelaConduccion.Modelo.Liquidacion
{
    partial class frmLiquidar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLiquidar));
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIdentificacion = new System.Windows.Forms.TextBox();
            this.cmbTipoDocumento = new System.Windows.Forms.ComboBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblNumRecibo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grdDatos = new System.Windows.Forms.DataGridView();
            this.ID_TARIFADETALLE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.concepto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descontable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panCliente = new System.Windows.Forms.Panel();
            this.lblInfoCliente = new System.Windows.Forms.Label();
            this.btnLiquidar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnVerRecibo = new System.Windows.Forms.Button();
            this.btnModificarPreliquidacion = new System.Windows.Forms.Button();
            this.btnLiquidarTarifas = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).BeginInit();
            this.panCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(212)))), ((int)(((byte)(248)))));
            this.panel2.Controls.Add(this.lblTitulo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(690, 42);
            this.panel2.TabIndex = 15;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Black;
            this.lblTitulo.Location = new System.Drawing.Point(3, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(684, 20);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Liquidar";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(212)))), ((int)(((byte)(248)))));
            this.panel3.Controls.Add(this.btnSalir);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 461);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(690, 45);
            this.panel3.TabIndex = 16;
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalir.Image = global::EscuelaConduccion.Properties.Resources.exit_22x22;
            this.btnSalir.Location = new System.Drawing.Point(595, 6);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(86, 33);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtIdentificacion);
            this.panel1.Controls.Add(this.cmbTipoDocumento);
            this.panel1.Location = new System.Drawing.Point(12, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(543, 57);
            this.panel1.TabIndex = 17;
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
            this.txtIdentificacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdentificacion_KeyPress);
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
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.lblValor.Location = new System.Drawing.Point(59, 430);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(38, 25);
            this.lblValor.TabIndex = 19;
            this.lblValor.Text = "$0";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.lblNumRecibo);
            this.panel4.Location = new System.Drawing.Point(377, 428);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(192, 23);
            this.panel4.TabIndex = 29;
            // 
            // lblNumRecibo
            // 
            this.lblNumRecibo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumRecibo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(65)))), ((int)(((byte)(54)))));
            this.lblNumRecibo.Location = new System.Drawing.Point(3, 2);
            this.lblNumRecibo.Name = "lblNumRecibo";
            this.lblNumRecibo.Size = new System.Drawing.Size(184, 18);
            this.lblNumRecibo.TabIndex = 17;
            this.lblNumRecibo.Text = "#";
            this.lblNumRecibo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(9, 435);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 27;
            this.label2.Text = "Total:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(374, 409);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 16);
            this.label1.TabIndex = 28;
            this.label1.Text = "Número Recibo:";
            // 
            // grdDatos
            // 
            this.grdDatos.AllowUserToAddRows = false;
            this.grdDatos.AllowUserToDeleteRows = false;
            this.grdDatos.BackgroundColor = System.Drawing.Color.White;
            this.grdDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_TARIFADETALLE,
            this.concepto,
            this.valor,
            this.descontable});
            this.grdDatos.GridColor = System.Drawing.Color.White;
            this.grdDatos.Location = new System.Drawing.Point(12, 199);
            this.grdDatos.MultiSelect = false;
            this.grdDatos.Name = "grdDatos";
            this.grdDatos.ReadOnly = true;
            this.grdDatos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdDatos.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdDatos.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(239)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(210)))), ((int)(((byte)(138)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.grdDatos.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.grdDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdDatos.Size = new System.Drawing.Size(666, 203);
            this.grdDatos.TabIndex = 26;
            // 
            // ID_TARIFADETALLE
            // 
            this.ID_TARIFADETALLE.HeaderText = "ID_TARIFADETALLE";
            this.ID_TARIFADETALLE.Name = "ID_TARIFADETALLE";
            this.ID_TARIFADETALLE.ReadOnly = true;
            this.ID_TARIFADETALLE.Visible = false;
            // 
            // concepto
            // 
            this.concepto.HeaderText = "CONCEPTO";
            this.concepto.Name = "concepto";
            this.concepto.ReadOnly = true;
            this.concepto.Width = 300;
            // 
            // valor
            // 
            this.valor.HeaderText = "VALOR";
            this.valor.Name = "valor";
            this.valor.ReadOnly = true;
            this.valor.Width = 200;
            // 
            // descontable
            // 
            this.descontable.HeaderText = "DESCONTABLE";
            this.descontable.Name = "descontable";
            this.descontable.ReadOnly = true;
            this.descontable.Width = 150;
            // 
            // panCliente
            // 
            this.panCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panCliente.Controls.Add(this.lblInfoCliente);
            this.panCliente.Location = new System.Drawing.Point(12, 122);
            this.panCliente.Name = "panCliente";
            this.panCliente.Size = new System.Drawing.Size(63, 29);
            this.panCliente.TabIndex = 20;
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
            // btnLiquidar
            // 
            this.btnLiquidar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(210)))), ((int)(((byte)(138)))));
            this.btnLiquidar.Enabled = false;
            this.btnLiquidar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLiquidar.Image = global::EscuelaConduccion.Properties.Resources.liquidar_48x48;
            this.btnLiquidar.Location = new System.Drawing.Point(534, 129);
            this.btnLiquidar.Name = "btnLiquidar";
            this.btnLiquidar.Size = new System.Drawing.Size(144, 63);
            this.btnLiquidar.TabIndex = 21;
            this.btnLiquidar.Text = "LIQUIDAR";
            this.btnLiquidar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLiquidar.UseVisualStyleBackColor = false;
            this.btnLiquidar.Click += new System.EventHandler(this.btnLiquidar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimpiar.Image = global::EscuelaConduccion.Properties.Resources.clean_20x20;
            this.btnLimpiar.Location = new System.Drawing.Point(360, 154);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(168, 38);
            this.btnLimpiar.TabIndex = 22;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnVerRecibo
            // 
            this.btnVerRecibo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(212)))), ((int)(((byte)(248)))));
            this.btnVerRecibo.Enabled = false;
            this.btnVerRecibo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVerRecibo.Image = global::EscuelaConduccion.Properties.Resources.acrobat_32x32;
            this.btnVerRecibo.Location = new System.Drawing.Point(575, 413);
            this.btnVerRecibo.Name = "btnVerRecibo";
            this.btnVerRecibo.Size = new System.Drawing.Size(103, 38);
            this.btnVerRecibo.TabIndex = 23;
            this.btnVerRecibo.Text = "Ver Recibo";
            this.btnVerRecibo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVerRecibo.UseVisualStyleBackColor = false;
            this.btnVerRecibo.Click += new System.EventHandler(this.btnVerRecibo_Click);
            // 
            // btnModificarPreliquidacion
            // 
            this.btnModificarPreliquidacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(212)))), ((int)(((byte)(248)))));
            this.btnModificarPreliquidacion.Enabled = false;
            this.btnModificarPreliquidacion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModificarPreliquidacion.Image = global::EscuelaConduccion.Properties.Resources.edit_20x20_negro;
            this.btnModificarPreliquidacion.Location = new System.Drawing.Point(186, 154);
            this.btnModificarPreliquidacion.Name = "btnModificarPreliquidacion";
            this.btnModificarPreliquidacion.Size = new System.Drawing.Size(168, 38);
            this.btnModificarPreliquidacion.TabIndex = 24;
            this.btnModificarPreliquidacion.Text = "Modificar Preliquidación";
            this.btnModificarPreliquidacion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnModificarPreliquidacion.UseVisualStyleBackColor = false;
            this.btnModificarPreliquidacion.Click += new System.EventHandler(this.btnModificarPreliquidacion_Click);
            // 
            // btnLiquidarTarifas
            // 
            this.btnLiquidarTarifas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(210)))), ((int)(((byte)(138)))));
            this.btnLiquidarTarifas.Enabled = false;
            this.btnLiquidarTarifas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLiquidarTarifas.Image = global::EscuelaConduccion.Properties.Resources.items_20x20_negro;
            this.btnLiquidarTarifas.Location = new System.Drawing.Point(12, 154);
            this.btnLiquidarTarifas.Name = "btnLiquidarTarifas";
            this.btnLiquidarTarifas.Size = new System.Drawing.Size(168, 38);
            this.btnLiquidarTarifas.TabIndex = 25;
            this.btnLiquidarTarifas.Text = "Liquidar Tarifas";
            this.btnLiquidarTarifas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLiquidarTarifas.UseVisualStyleBackColor = false;
            this.btnLiquidarTarifas.Click += new System.EventHandler(this.btnLiquidarTarifas_Click);
            // 
            // frmLiquidar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(129)))), ((int)(((byte)(193)))));
            this.ClientSize = new System.Drawing.Size(690, 506);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grdDatos);
            this.Controls.Add(this.btnLiquidar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnVerRecibo);
            this.Controls.Add(this.btnModificarPreliquidacion);
            this.Controls.Add(this.btnLiquidarTarifas);
            this.Controls.Add(this.panCliente);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLiquidar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Liquidar";
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).EndInit();
            this.panCliente.ResumeLayout(false);
            this.panCliente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Panel panel2;
        protected System.Windows.Forms.Label lblTitulo;
        protected System.Windows.Forms.Panel panel3;
        protected System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblNumRecibo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grdDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_TARIFADETALLE;
        private System.Windows.Forms.DataGridViewTextBoxColumn concepto;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn descontable;
        private System.Windows.Forms.Button btnLiquidar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnVerRecibo;
        private System.Windows.Forms.Button btnModificarPreliquidacion;
        private System.Windows.Forms.Button btnLiquidarTarifas;
        private System.Windows.Forms.Panel panCliente;
        private System.Windows.Forms.Label lblInfoCliente;
        public System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIdentificacion;
        private System.Windows.Forms.ComboBox cmbTipoDocumento;
    }
}