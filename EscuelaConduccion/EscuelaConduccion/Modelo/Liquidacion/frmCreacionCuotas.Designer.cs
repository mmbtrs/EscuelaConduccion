namespace EscuelaConduccion.Modelo.Liquidacion
{
    partial class frmCreacionCuotas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCreacionCuotas));
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.datFechaCreacion = new System.Windows.Forms.DateTimePicker();
            this.lblDeuda = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.rarPorcentaje = new System.Windows.Forms.RadioButton();
            this.rarEspecificar = new System.Windows.Forms.RadioButton();
            this.txtPorcentaje = new System.Windows.Forms.TextBox();
            this.txtEspecificar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.grdDatos = new System.Windows.Forms.DataGridView();
            this.CUOTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VALOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PORCENTAJE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA_LIMITE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(212)))), ((int)(((byte)(248)))));
            this.panel3.Controls.Add(this.btnSalir);
            this.panel3.Controls.Add(this.btnGuardar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 490);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(501, 45);
            this.panel3.TabIndex = 20;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(212)))), ((int)(((byte)(248)))));
            this.panel2.Controls.Add(this.lblTitulo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(501, 42);
            this.panel2.TabIndex = 19;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Black;
            this.lblTitulo.Location = new System.Drawing.Point(3, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(495, 20);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Creación de Cuotas";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(17, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 16);
            this.label3.TabIndex = 21;
            this.label3.Text = "Fecha acuerdo:";
            // 
            // datFechaCreacion
            // 
            this.datFechaCreacion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datFechaCreacion.Location = new System.Drawing.Point(125, 11);
            this.datFechaCreacion.Name = "datFechaCreacion";
            this.datFechaCreacion.Size = new System.Drawing.Size(113, 20);
            this.datFechaCreacion.TabIndex = 22;
            // 
            // lblDeuda
            // 
            this.lblDeuda.AutoSize = true;
            this.lblDeuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeuda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.lblDeuda.Location = new System.Drawing.Point(319, 7);
            this.lblDeuda.Name = "lblDeuda";
            this.lblDeuda.Size = new System.Drawing.Size(38, 25);
            this.lblDeuda.TabIndex = 28;
            this.lblDeuda.Text = "$0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(254, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 29;
            this.label2.Text = "Deuda:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.datFechaCreacion);
            this.panel1.Controls.Add(this.lblDeuda);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(477, 47);
            this.panel1.TabIndex = 30;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.txtEspecificar);
            this.panel4.Controls.Add(this.txtPorcentaje);
            this.panel4.Controls.Add(this.rarEspecificar);
            this.panel4.Controls.Add(this.rarPorcentaje);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(12, 104);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(239, 114);
            this.panel4.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(17, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Indicar primera cuota";
            // 
            // rarPorcentaje
            // 
            this.rarPorcentaje.AutoSize = true;
            this.rarPorcentaje.Checked = true;
            this.rarPorcentaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rarPorcentaje.ForeColor = System.Drawing.Color.White;
            this.rarPorcentaje.Location = new System.Drawing.Point(41, 48);
            this.rarPorcentaje.Name = "rarPorcentaje";
            this.rarPorcentaje.Size = new System.Drawing.Size(91, 20);
            this.rarPorcentaje.TabIndex = 22;
            this.rarPorcentaje.TabStop = true;
            this.rarPorcentaje.Text = "Porcentaje";
            this.rarPorcentaje.UseVisualStyleBackColor = true;
            // 
            // rarEspecificar
            // 
            this.rarEspecificar.AutoSize = true;
            this.rarEspecificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rarEspecificar.ForeColor = System.Drawing.Color.White;
            this.rarEspecificar.Location = new System.Drawing.Point(41, 75);
            this.rarEspecificar.Name = "rarEspecificar";
            this.rarEspecificar.Size = new System.Drawing.Size(93, 20);
            this.rarEspecificar.TabIndex = 22;
            this.rarEspecificar.Text = "Especificar";
            this.rarEspecificar.UseVisualStyleBackColor = true;
            // 
            // txtPorcentaje
            // 
            this.txtPorcentaje.Location = new System.Drawing.Point(138, 48);
            this.txtPorcentaje.MaxLength = 20;
            this.txtPorcentaje.Name = "txtPorcentaje";
            this.txtPorcentaje.Size = new System.Drawing.Size(55, 20);
            this.txtPorcentaje.TabIndex = 23;
            this.txtPorcentaje.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdentificacion_KeyPress);
            // 
            // txtEspecificar
            // 
            this.txtEspecificar.Location = new System.Drawing.Point(138, 75);
            this.txtEspecificar.MaxLength = 20;
            this.txtEspecificar.Name = "txtEspecificar";
            this.txtEspecificar.Size = new System.Drawing.Size(55, 20);
            this.txtEspecificar.TabIndex = 23;
            this.txtEspecificar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(199, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 16);
            this.label4.TabIndex = 21;
            this.label4.Text = "%";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.txtCantidad);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Location = new System.Drawing.Point(250, 104);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(239, 114);
            this.panel5.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(42, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 16);
            this.label5.TabIndex = 21;
            this.label5.Text = "Cantidad:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(113, 48);
            this.txtCantidad.MaxLength = 20;
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(55, 20);
            this.txtCantidad.TabIndex = 23;
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(17, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(182, 16);
            this.label6.TabIndex = 21;
            this.label6.Text = "Indicar número de cuotas";
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.grdDatos);
            this.panel6.Controls.Add(this.btnCalcular);
            this.panel6.Location = new System.Drawing.Point(12, 217);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(477, 262);
            this.panel6.TabIndex = 30;
            // 
            // grdDatos
            // 
            this.grdDatos.AllowUserToAddRows = false;
            this.grdDatos.AllowUserToDeleteRows = false;
            this.grdDatos.BackgroundColor = System.Drawing.Color.White;
            this.grdDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CUOTA,
            this.VALOR,
            this.PORCENTAJE,
            this.FECHA_LIMITE});
            this.grdDatos.Location = new System.Drawing.Point(15, 58);
            this.grdDatos.Name = "grdDatos";
            this.grdDatos.ReadOnly = true;
            this.grdDatos.RowHeadersVisible = false;
            this.grdDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdDatos.Size = new System.Drawing.Size(446, 187);
            this.grdDatos.TabIndex = 10;
            // 
            // CUOTA
            // 
            this.CUOTA.HeaderText = "CUOTA";
            this.CUOTA.Name = "CUOTA";
            this.CUOTA.ReadOnly = true;
            this.CUOTA.Width = 50;
            // 
            // VALOR
            // 
            this.VALOR.HeaderText = "VALOR";
            this.VALOR.Name = "VALOR";
            this.VALOR.ReadOnly = true;
            // 
            // PORCENTAJE
            // 
            this.PORCENTAJE.HeaderText = "PORCENTAJE";
            this.PORCENTAJE.Name = "PORCENTAJE";
            this.PORCENTAJE.ReadOnly = true;
            // 
            // FECHA_LIMITE
            // 
            this.FECHA_LIMITE.HeaderText = "FECHA LIMITE PAGO";
            this.FECHA_LIMITE.Name = "FECHA_LIMITE";
            this.FECHA_LIMITE.ReadOnly = true;
            this.FECHA_LIMITE.Width = 180;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(212)))), ((int)(((byte)(248)))));
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCalcular.Image = global::EscuelaConduccion.Properties.Resources.calcular2_32x32;
            this.btnCalcular.Location = new System.Drawing.Point(194, 9);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(86, 41);
            this.btnCalcular.TabIndex = 9;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalir.Image = global::EscuelaConduccion.Properties.Resources.exit_22x22;
            this.btnSalir.Location = new System.Drawing.Point(401, 6);
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
            this.btnGuardar.Location = new System.Drawing.Point(309, 6);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(86, 33);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Aceptar";
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // frmCreacionCuotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(129)))), ((int)(((byte)(193)))));
            this.ClientSize = new System.Drawing.Size(501, 535);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCreacionCuotas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Creación de Cuotas";
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Panel panel3;
        protected System.Windows.Forms.Button btnSalir;
        protected System.Windows.Forms.Button btnGuardar;
        protected System.Windows.Forms.Panel panel2;
        protected System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker datFechaCreacion;
        private System.Windows.Forms.Label lblDeuda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RadioButton rarEspecificar;
        private System.Windows.Forms.RadioButton rarPorcentaje;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEspecificar;
        private System.Windows.Forms.TextBox txtPorcentaje;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label6;
        protected System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataGridView grdDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUOTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn VALOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn PORCENTAJE;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA_LIMITE;
    }
}