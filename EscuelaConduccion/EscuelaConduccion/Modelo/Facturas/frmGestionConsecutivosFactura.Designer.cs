namespace EscuelaConduccion.Modelo.Facturas
{
    partial class frmGestionConsecutivosFactura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestionConsecutivosFactura));
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.grdDatos = new System.Windows.Forms.DataGridView();
            this.id_rango_facturas = new System.Windows.Forms.DataGridViewButtonColumn();
            this.rango_inicial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rango_final = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.num_resolucion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_resolucion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.disponibles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.no_disponibles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detalle = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(212)))), ((int)(((byte)(248)))));
            this.panel3.Controls.Add(this.btnSalir);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 405);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(854, 45);
            this.panel3.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(212)))), ((int)(((byte)(248)))));
            this.panel2.Controls.Add(this.lblTitulo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(854, 42);
            this.panel2.TabIndex = 17;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Black;
            this.lblTitulo.Location = new System.Drawing.Point(3, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(848, 20);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Consecutivos Factura DIAN";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grdDatos
            // 
            this.grdDatos.AllowUserToAddRows = false;
            this.grdDatos.AllowUserToDeleteRows = false;
            this.grdDatos.BackgroundColor = System.Drawing.Color.White;
            this.grdDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_rango_facturas,
            this.rango_inicial,
            this.rango_final,
            this.num_resolucion,
            this.fecha_resolucion,
            this.cantidad,
            this.disponibles,
            this.no_disponibles,
            this.detalle});
            this.grdDatos.Location = new System.Drawing.Point(12, 110);
            this.grdDatos.Name = "grdDatos";
            this.grdDatos.ReadOnly = true;
            this.grdDatos.RowHeadersVisible = false;
            this.grdDatos.Size = new System.Drawing.Size(831, 282);
            this.grdDatos.TabIndex = 19;
            // 
            // id_rango_facturas
            // 
            this.id_rango_facturas.HeaderText = "ID RANGO FACTURAS";
            this.id_rango_facturas.Name = "id_rango_facturas";
            this.id_rango_facturas.ReadOnly = true;
            this.id_rango_facturas.Visible = false;
            // 
            // rango_inicial
            // 
            this.rango_inicial.HeaderText = "RANGO INICIAL";
            this.rango_inicial.Name = "rango_inicial";
            this.rango_inicial.ReadOnly = true;
            // 
            // rango_final
            // 
            this.rango_final.HeaderText = "RANGO FINAL";
            this.rango_final.Name = "rango_final";
            this.rango_final.ReadOnly = true;
            // 
            // num_resolucion
            // 
            this.num_resolucion.HeaderText = "No. RESOLUCIÓN";
            this.num_resolucion.Name = "num_resolucion";
            this.num_resolucion.ReadOnly = true;
            // 
            // fecha_resolucion
            // 
            this.fecha_resolucion.HeaderText = "FECHA RESOLUCIÓN";
            this.fecha_resolucion.Name = "fecha_resolucion";
            this.fecha_resolucion.ReadOnly = true;
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "CANTIDAD";
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            // 
            // disponibles
            // 
            this.disponibles.HeaderText = "DISPONIBLES";
            this.disponibles.Name = "disponibles";
            this.disponibles.ReadOnly = true;
            // 
            // no_disponibles
            // 
            this.no_disponibles.HeaderText = "NO DISPONIBLES";
            this.no_disponibles.Name = "no_disponibles";
            this.no_disponibles.ReadOnly = true;
            // 
            // detalle
            // 
            this.detalle.HeaderText = "DETALLE";
            this.detalle.Name = "detalle";
            this.detalle.ReadOnly = true;
            // 
            // btnInsertar
            // 
            this.btnInsertar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInsertar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(210)))), ((int)(((byte)(138)))));
            this.btnInsertar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInsertar.Image = global::EscuelaConduccion.Properties.Resources.add_insert_new_32x32;
            this.btnInsertar.Location = new System.Drawing.Point(665, 63);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(86, 41);
            this.btnInsertar.TabIndex = 25;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInsertar.UseVisualStyleBackColor = false;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(125)))), ((int)(((byte)(104)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminar.Image = global::EscuelaConduccion.Properties.Resources.clean_20x20;
            this.btnEliminar.Location = new System.Drawing.Point(757, 63);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(86, 41);
            this.btnEliminar.TabIndex = 26;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalir.Image = global::EscuelaConduccion.Properties.Resources.exit_22x22;
            this.btnSalir.Location = new System.Drawing.Point(757, 6);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(86, 33);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmGestionConsecutivosFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(129)))), ((int)(((byte)(193)))));
            this.ClientSize = new System.Drawing.Size(854, 450);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.grdDatos);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGestionConsecutivosFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consecutivos Facturas";
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Panel panel3;
        protected System.Windows.Forms.Button btnSalir;
        protected System.Windows.Forms.Panel panel2;
        protected System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView grdDatos;
        private System.Windows.Forms.DataGridViewButtonColumn id_rango_facturas;
        private System.Windows.Forms.DataGridViewTextBoxColumn rango_inicial;
        private System.Windows.Forms.DataGridViewTextBoxColumn rango_final;
        private System.Windows.Forms.DataGridViewTextBoxColumn num_resolucion;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_resolucion;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn disponibles;
        private System.Windows.Forms.DataGridViewTextBoxColumn no_disponibles;
        private System.Windows.Forms.DataGridViewButtonColumn detalle;
        protected System.Windows.Forms.Button btnInsertar;
        protected System.Windows.Forms.Button btnEliminar;
    }
}