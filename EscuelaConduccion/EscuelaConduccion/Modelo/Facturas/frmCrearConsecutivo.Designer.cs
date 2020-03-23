namespace EscuelaConduccion.Modelo.Facturas
{
    partial class frmCrearConsecutivo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCrearConsecutivo));
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRangoInicial = new System.Windows.Forms.TextBox();
            this.datFechaResolucion = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRangoFinal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumResolucion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotalCrear = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(212)))), ((int)(((byte)(248)))));
            this.panel2.Controls.Add(this.lblTitulo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(337, 42);
            this.panel2.TabIndex = 18;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Black;
            this.lblTitulo.Location = new System.Drawing.Point(3, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(331, 20);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Crear Consecutivos Facturas DIAN";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(212)))), ((int)(((byte)(248)))));
            this.panel3.Controls.Add(this.btnGuardar);
            this.panel3.Controls.Add(this.btnSalir);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 226);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(337, 45);
            this.panel3.TabIndex = 19;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(210)))), ((int)(((byte)(138)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardar.Image = global::EscuelaConduccion.Properties.Resources.save_24x24;
            this.btnGuardar.Location = new System.Drawing.Point(150, 6);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(86, 33);
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalir.Image = global::EscuelaConduccion.Properties.Resources.exit_22x22;
            this.btnSalir.Location = new System.Drawing.Point(242, 6);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(86, 33);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(70, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 16);
            this.label7.TabIndex = 21;
            this.label7.Text = "Rango inicial";
            // 
            // txtRangoInicial
            // 
            this.txtRangoInicial.Location = new System.Drawing.Point(160, 62);
            this.txtRangoInicial.MaxLength = 20;
            this.txtRangoInicial.Name = "txtRangoInicial";
            this.txtRangoInicial.Size = new System.Drawing.Size(123, 20);
            this.txtRangoInicial.TabIndex = 20;
            this.txtRangoInicial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRangoInicial_KeyPress);
            this.txtRangoInicial.Leave += new System.EventHandler(this.txtRangoInicial_Leave);
            // 
            // datFechaResolucion
            // 
            this.datFechaResolucion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datFechaResolucion.Location = new System.Drawing.Point(160, 140);
            this.datFechaResolucion.Name = "datFechaResolucion";
            this.datFechaResolucion.Size = new System.Drawing.Size(123, 20);
            this.datFechaResolucion.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(45, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "Fecha resolución";
            // 
            // txtRangoFinal
            // 
            this.txtRangoFinal.Location = new System.Drawing.Point(160, 88);
            this.txtRangoFinal.MaxLength = 20;
            this.txtRangoFinal.Name = "txtRangoFinal";
            this.txtRangoFinal.Size = new System.Drawing.Size(123, 20);
            this.txtRangoFinal.TabIndex = 20;
            this.txtRangoFinal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRangoFinal_KeyPress);
            this.txtRangoFinal.Leave += new System.EventHandler(this.txtRangoFinal_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(80, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Rango final";
            // 
            // txtNumResolucion
            // 
            this.txtNumResolucion.Location = new System.Drawing.Point(160, 114);
            this.txtNumResolucion.MaxLength = 20;
            this.txtNumResolucion.Name = "txtNumResolucion";
            this.txtNumResolucion.Size = new System.Drawing.Size(123, 20);
            this.txtNumResolucion.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(43, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "No. de resolución";
            // 
            // lblTotalCrear
            // 
            this.lblTotalCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCrear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(210)))), ((int)(((byte)(138)))));
            this.lblTotalCrear.Location = new System.Drawing.Point(0, 178);
            this.lblTotalCrear.Name = "lblTotalCrear";
            this.lblTotalCrear.Size = new System.Drawing.Size(337, 29);
            this.lblTotalCrear.TabIndex = 22;
            this.lblTotalCrear.Text = "Total a crear:";
            this.lblTotalCrear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmCrearConsecutivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(129)))), ((int)(((byte)(193)))));
            this.ClientSize = new System.Drawing.Size(337, 271);
            this.Controls.Add(this.datFechaResolucion);
            this.Controls.Add(this.lblTotalCrear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNumResolucion);
            this.Controls.Add(this.txtRangoFinal);
            this.Controls.Add(this.txtRangoInicial);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(353, 310);
            this.MinimumSize = new System.Drawing.Size(353, 310);
            this.Name = "frmCrearConsecutivo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear Consecutivo";
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Panel panel2;
        protected System.Windows.Forms.Label lblTitulo;
        protected System.Windows.Forms.Panel panel3;
        protected System.Windows.Forms.Button btnGuardar;
        protected System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtRangoInicial;
        private System.Windows.Forms.DateTimePicker datFechaResolucion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRangoFinal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumResolucion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotalCrear;
    }
}