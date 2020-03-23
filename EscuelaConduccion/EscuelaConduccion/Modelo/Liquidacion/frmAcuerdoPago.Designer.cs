namespace EscuelaConduccion.Modelo.Liquidacion
{
    partial class frmAcuerdoPago
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAcuerdoPago));
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblFechaAcuerdo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblEstadoAcuerdo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTipoDocumento = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblNumeroDocumento = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblNombres = new System.Windows.Forms.Label();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblTotalDeuda = new System.Windows.Forms.Label();
            this.lblNumAcuerdo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNumCuotas = new System.Windows.Forms.Label();
            this.grdCuotas = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUOTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VALOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESTADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NUMERO_RECIBO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA_LIMITE_PAGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGenerarRecibo = new System.Windows.Forms.Button();
            this.btnResumenCuotas = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCuotas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(212)))), ((int)(((byte)(248)))));
            this.panel3.Controls.Add(this.btnSalir);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 405);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(797, 45);
            this.panel3.TabIndex = 22;
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalir.Image = global::EscuelaConduccion.Properties.Resources.exit_22x22;
            this.btnSalir.Location = new System.Drawing.Point(697, 6);
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
            this.panel2.Size = new System.Drawing.Size(797, 42);
            this.panel2.TabIndex = 21;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Black;
            this.lblTitulo.Location = new System.Drawing.Point(3, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(791, 20);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Detalle Acuerdos de Pago";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(49, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 16);
            this.label5.TabIndex = 23;
            this.label5.Text = "Fecha acuerdo de pago:";
            // 
            // lblFechaAcuerdo
            // 
            this.lblFechaAcuerdo.AutoSize = true;
            this.lblFechaAcuerdo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaAcuerdo.ForeColor = System.Drawing.Color.White;
            this.lblFechaAcuerdo.Location = new System.Drawing.Point(211, 64);
            this.lblFechaAcuerdo.Name = "lblFechaAcuerdo";
            this.lblFechaAcuerdo.Size = new System.Drawing.Size(178, 16);
            this.lblFechaAcuerdo.TabIndex = 23;
            this.lblFechaAcuerdo.Text = "Fecha acuerdo de pago:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(391, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 16);
            this.label2.TabIndex = 23;
            this.label2.Text = "Estado acuerdo de pago:";
            // 
            // lblEstadoAcuerdo
            // 
            this.lblEstadoAcuerdo.AutoSize = true;
            this.lblEstadoAcuerdo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoAcuerdo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.lblEstadoAcuerdo.Location = new System.Drawing.Point(557, 64);
            this.lblEstadoAcuerdo.Name = "lblEstadoAcuerdo";
            this.lblEstadoAcuerdo.Size = new System.Drawing.Size(178, 16);
            this.lblEstadoAcuerdo.TabIndex = 23;
            this.lblEstadoAcuerdo.Text = "Fecha acuerdo de pago:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(96, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 16);
            this.label4.TabIndex = 23;
            this.label4.Text = "Tipo documento:";
            // 
            // lblTipoDocumento
            // 
            this.lblTipoDocumento.AutoSize = true;
            this.lblTipoDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoDocumento.ForeColor = System.Drawing.Color.White;
            this.lblTipoDocumento.Location = new System.Drawing.Point(211, 89);
            this.lblTipoDocumento.Name = "lblTipoDocumento";
            this.lblTipoDocumento.Size = new System.Drawing.Size(178, 16);
            this.lblTipoDocumento.TabIndex = 23;
            this.lblTipoDocumento.Text = "Fecha acuerdo de pago:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(422, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 16);
            this.label7.TabIndex = 23;
            this.label7.Text = "Número documento:";
            // 
            // lblNumeroDocumento
            // 
            this.lblNumeroDocumento.AutoSize = true;
            this.lblNumeroDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroDocumento.ForeColor = System.Drawing.Color.White;
            this.lblNumeroDocumento.Location = new System.Drawing.Point(557, 89);
            this.lblNumeroDocumento.Name = "lblNumeroDocumento";
            this.lblNumeroDocumento.Size = new System.Drawing.Size(178, 16);
            this.lblNumeroDocumento.TabIndex = 23;
            this.lblNumeroDocumento.Text = "Fecha acuerdo de pago:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(138, 114);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 16);
            this.label9.TabIndex = 23;
            this.label9.Text = "Nombres:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(483, 114);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 16);
            this.label10.TabIndex = 23;
            this.label10.Text = "Apellidos:";
            // 
            // lblNombres
            // 
            this.lblNombres.AutoSize = true;
            this.lblNombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombres.ForeColor = System.Drawing.Color.White;
            this.lblNombres.Location = new System.Drawing.Point(211, 114);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(178, 16);
            this.lblNombres.TabIndex = 23;
            this.lblNombres.Text = "Fecha acuerdo de pago:";
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidos.ForeColor = System.Drawing.Color.White;
            this.lblApellidos.Location = new System.Drawing.Point(557, 114);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(178, 16);
            this.lblApellidos.TabIndex = 23;
            this.lblApellidos.Text = "Fecha acuerdo de pago:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(89, 139);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(116, 16);
            this.label13.TabIndex = 23;
            this.label13.Text = "Acuerdo de pago:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(467, 139);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(84, 16);
            this.label14.TabIndex = 23;
            this.label14.Text = "Total deuda:";
            // 
            // lblTotalDeuda
            // 
            this.lblTotalDeuda.AutoSize = true;
            this.lblTotalDeuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDeuda.ForeColor = System.Drawing.Color.White;
            this.lblTotalDeuda.Location = new System.Drawing.Point(557, 139);
            this.lblTotalDeuda.Name = "lblTotalDeuda";
            this.lblTotalDeuda.Size = new System.Drawing.Size(178, 16);
            this.lblTotalDeuda.TabIndex = 23;
            this.lblTotalDeuda.Text = "Fecha acuerdo de pago:";
            // 
            // lblNumAcuerdo
            // 
            this.lblNumAcuerdo.AutoSize = true;
            this.lblNumAcuerdo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumAcuerdo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.lblNumAcuerdo.Location = new System.Drawing.Point(211, 139);
            this.lblNumAcuerdo.Name = "lblNumAcuerdo";
            this.lblNumAcuerdo.Size = new System.Drawing.Size(178, 16);
            this.lblNumAcuerdo.TabIndex = 23;
            this.lblNumAcuerdo.Text = "Fecha acuerdo de pago:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 16);
            this.label1.TabIndex = 23;
            this.label1.Text = "Cantidad cuotas:";
            // 
            // lblNumCuotas
            // 
            this.lblNumCuotas.AutoSize = true;
            this.lblNumCuotas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumCuotas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.lblNumCuotas.Location = new System.Drawing.Point(142, 184);
            this.lblNumCuotas.Name = "lblNumCuotas";
            this.lblNumCuotas.Size = new System.Drawing.Size(178, 16);
            this.lblNumCuotas.TabIndex = 23;
            this.lblNumCuotas.Text = "Fecha acuerdo de pago:";
            // 
            // grdCuotas
            // 
            this.grdCuotas.AllowUserToAddRows = false;
            this.grdCuotas.AllowUserToDeleteRows = false;
            this.grdCuotas.BackgroundColor = System.Drawing.Color.White;
            this.grdCuotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCuotas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.CUOTA,
            this.VALOR,
            this.ESTADO,
            this.NUMERO_RECIBO,
            this.FECHA_LIMITE_PAGO});
            this.grdCuotas.Location = new System.Drawing.Point(15, 203);
            this.grdCuotas.Name = "grdCuotas";
            this.grdCuotas.ReadOnly = true;
            this.grdCuotas.RowHeadersVisible = false;
            this.grdCuotas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdCuotas.Size = new System.Drawing.Size(636, 188);
            this.grdCuotas.TabIndex = 24;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // CUOTA
            // 
            this.CUOTA.HeaderText = "CUOTA";
            this.CUOTA.Name = "CUOTA";
            this.CUOTA.ReadOnly = true;
            this.CUOTA.Width = 80;
            // 
            // VALOR
            // 
            this.VALOR.HeaderText = "VALOR";
            this.VALOR.Name = "VALOR";
            this.VALOR.ReadOnly = true;
            // 
            // ESTADO
            // 
            this.ESTADO.HeaderText = "ESTADO";
            this.ESTADO.Name = "ESTADO";
            this.ESTADO.ReadOnly = true;
            this.ESTADO.Width = 150;
            // 
            // NUMERO_RECIBO
            // 
            this.NUMERO_RECIBO.HeaderText = "No. RECIBO";
            this.NUMERO_RECIBO.Name = "NUMERO_RECIBO";
            this.NUMERO_RECIBO.ReadOnly = true;
            // 
            // FECHA_LIMITE_PAGO
            // 
            this.FECHA_LIMITE_PAGO.HeaderText = "FECHA LIMITE PAGO";
            this.FECHA_LIMITE_PAGO.Name = "FECHA_LIMITE_PAGO";
            this.FECHA_LIMITE_PAGO.ReadOnly = true;
            this.FECHA_LIMITE_PAGO.Width = 180;
            // 
            // btnGenerarRecibo
            // 
            this.btnGenerarRecibo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(212)))), ((int)(((byte)(248)))));
            this.btnGenerarRecibo.Enabled = false;
            this.btnGenerarRecibo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGenerarRecibo.Image = global::EscuelaConduccion.Properties.Resources.acrobat_32x32;
            this.btnGenerarRecibo.Location = new System.Drawing.Point(659, 203);
            this.btnGenerarRecibo.Name = "btnGenerarRecibo";
            this.btnGenerarRecibo.Size = new System.Drawing.Size(124, 38);
            this.btnGenerarRecibo.TabIndex = 25;
            this.btnGenerarRecibo.Text = "Generar Recibo";
            this.btnGenerarRecibo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGenerarRecibo.UseVisualStyleBackColor = false;
            this.btnGenerarRecibo.Click += new System.EventHandler(this.btnGenerarRecibo_Click);
            // 
            // btnResumenCuotas
            // 
            this.btnResumenCuotas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(212)))), ((int)(((byte)(248)))));
            this.btnResumenCuotas.Enabled = false;
            this.btnResumenCuotas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnResumenCuotas.Image = global::EscuelaConduccion.Properties.Resources.buscarFactura_32x32;
            this.btnResumenCuotas.Location = new System.Drawing.Point(659, 247);
            this.btnResumenCuotas.Name = "btnResumenCuotas";
            this.btnResumenCuotas.Size = new System.Drawing.Size(126, 38);
            this.btnResumenCuotas.TabIndex = 25;
            this.btnResumenCuotas.Text = "Resumen Cuotas";
            this.btnResumenCuotas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnResumenCuotas.UseVisualStyleBackColor = false;
            this.btnResumenCuotas.Visible = false;
            // 
            // frmAcuerdoPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(129)))), ((int)(((byte)(193)))));
            this.ClientSize = new System.Drawing.Size(797, 450);
            this.Controls.Add(this.btnResumenCuotas);
            this.Controls.Add(this.btnGenerarRecibo);
            this.Controls.Add(this.grdCuotas);
            this.Controls.Add(this.lblNumCuotas);
            this.Controls.Add(this.lblNumAcuerdo);
            this.Controls.Add(this.lblEstadoAcuerdo);
            this.Controls.Add(this.lblTotalDeuda);
            this.Controls.Add(this.lblApellidos);
            this.Controls.Add(this.lblNumeroDocumento);
            this.Controls.Add(this.lblNombres);
            this.Controls.Add(this.lblTipoDocumento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblFechaAcuerdo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAcuerdoPago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalle Acuerdos de Pago";
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdCuotas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Panel panel3;
        protected System.Windows.Forms.Button btnSalir;
        protected System.Windows.Forms.Panel panel2;
        protected System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblFechaAcuerdo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblEstadoAcuerdo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTipoDocumento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblNumeroDocumento;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblTotalDeuda;
        private System.Windows.Forms.Label lblNumAcuerdo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNumCuotas;
        private System.Windows.Forms.DataGridView grdCuotas;
        private System.Windows.Forms.Button btnGenerarRecibo;
        private System.Windows.Forms.Button btnResumenCuotas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUOTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn VALOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESTADO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUMERO_RECIBO;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA_LIMITE_PAGO;
    }
}