namespace EscuelaConduccion.Modelo.Liquidacion
{
    partial class frmBuscarReciboFactura
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBuscarReciboFactura));
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnAnularRecibo = new System.Windows.Forms.Button();
            this.btnAnularPago = new System.Windows.Forms.Button();
            this.btnPagar = new System.Windows.Forms.Button();
            this.btnReimprimir = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.panFechaLiquidacion = new System.Windows.Forms.Panel();
            this.datFechaFinalLiquidacion = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.datFechaInicialLiquidacion = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkFechaPago = new System.Windows.Forms.CheckBox();
            this.chkFechaLiquidacion = new System.Windows.Forms.CheckBox();
            this.chkEstado = new System.Windows.Forms.CheckBox();
            this.chkCliente = new System.Windows.Forms.CheckBox();
            this.chkFactura = new System.Windows.Forms.CheckBox();
            this.chkRecibo = new System.Windows.Forms.CheckBox();
            this.panFactura = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumFactura = new System.Windows.Forms.TextBox();
            this.panCliente = new System.Windows.Forms.Panel();
            this.cmbTipoDocumento = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdentificacion = new System.Windows.Forms.TextBox();
            this.panEstado = new System.Windows.Forms.Panel();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panRecibo = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNumRecibo = new System.Windows.Forms.TextBox();
            this.panFechaPago = new System.Windows.Forms.Panel();
            this.datFechaFinalPago = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.datFechaInicialPago = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.grdDatos = new System.Windows.Forms.DataGridView();
            this.num_recibo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.num_factura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.identificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_liquidacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarifa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panFechaLiquidacion.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panFactura.SuspendLayout();
            this.panCliente.SuspendLayout();
            this.panEstado.SuspendLayout();
            this.panRecibo.SuspendLayout();
            this.panFechaPago.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(212)))), ((int)(((byte)(248)))));
            this.panel2.Controls.Add(this.lblTitulo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(945, 42);
            this.panel2.TabIndex = 16;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Black;
            this.lblTitulo.Location = new System.Drawing.Point(3, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(939, 20);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Buscar Recibo/Factura";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(212)))), ((int)(((byte)(248)))));
            this.panel3.Controls.Add(this.btnAnularRecibo);
            this.panel3.Controls.Add(this.btnAnularPago);
            this.panel3.Controls.Add(this.btnPagar);
            this.panel3.Controls.Add(this.btnReimprimir);
            this.panel3.Controls.Add(this.btnSalir);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 458);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(945, 49);
            this.panel3.TabIndex = 17;
            // 
            // btnAnularRecibo
            // 
            this.btnAnularRecibo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnularRecibo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.btnAnularRecibo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAnularRecibo.Image = global::EscuelaConduccion.Properties.Resources.anularFactura_32x32;
            this.btnAnularRecibo.Location = new System.Drawing.Point(408, 5);
            this.btnAnularRecibo.Name = "btnAnularRecibo";
            this.btnAnularRecibo.Size = new System.Drawing.Size(116, 39);
            this.btnAnularRecibo.TabIndex = 10;
            this.btnAnularRecibo.Text = "Anular recibo/factura";
            this.btnAnularRecibo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAnularRecibo.UseVisualStyleBackColor = false;
            this.btnAnularRecibo.Click += new System.EventHandler(this.btnAnularRecibo_Click);
            // 
            // btnAnularPago
            // 
            this.btnAnularPago.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnularPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.btnAnularPago.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAnularPago.Image = global::EscuelaConduccion.Properties.Resources.anularPago_32x32;
            this.btnAnularPago.Location = new System.Drawing.Point(530, 5);
            this.btnAnularPago.Name = "btnAnularPago";
            this.btnAnularPago.Size = new System.Drawing.Size(100, 39);
            this.btnAnularPago.TabIndex = 10;
            this.btnAnularPago.Text = "Anular pago";
            this.btnAnularPago.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAnularPago.UseVisualStyleBackColor = false;
            // 
            // btnPagar
            // 
            this.btnPagar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPagar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnPagar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPagar.Image = global::EscuelaConduccion.Properties.Resources.money_32x32;
            this.btnPagar.Location = new System.Drawing.Point(636, 5);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(100, 39);
            this.btnPagar.TabIndex = 10;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPagar.UseVisualStyleBackColor = false;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // btnReimprimir
            // 
            this.btnReimprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReimprimir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(210)))), ((int)(((byte)(138)))));
            this.btnReimprimir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReimprimir.Image = global::EscuelaConduccion.Properties.Resources.print_32x32;
            this.btnReimprimir.Location = new System.Drawing.Point(742, 5);
            this.btnReimprimir.Name = "btnReimprimir";
            this.btnReimprimir.Size = new System.Drawing.Size(100, 39);
            this.btnReimprimir.TabIndex = 10;
            this.btnReimprimir.Text = "Reimprimir";
            this.btnReimprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReimprimir.UseVisualStyleBackColor = false;
            this.btnReimprimir.Click += new System.EventHandler(this.btnReimprimir_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalir.Image = global::EscuelaConduccion.Properties.Resources.exit_22x22;
            this.btnSalir.Location = new System.Drawing.Point(848, 5);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(86, 39);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // panFechaLiquidacion
            // 
            this.panFechaLiquidacion.Controls.Add(this.datFechaFinalLiquidacion);
            this.panFechaLiquidacion.Controls.Add(this.label6);
            this.panFechaLiquidacion.Controls.Add(this.datFechaInicialLiquidacion);
            this.panFechaLiquidacion.Controls.Add(this.label3);
            this.panFechaLiquidacion.Enabled = false;
            this.panFechaLiquidacion.Location = new System.Drawing.Point(152, 124);
            this.panFechaLiquidacion.Name = "panFechaLiquidacion";
            this.panFechaLiquidacion.Size = new System.Drawing.Size(477, 26);
            this.panFechaLiquidacion.TabIndex = 18;
            // 
            // datFechaFinalLiquidacion
            // 
            this.datFechaFinalLiquidacion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datFechaFinalLiquidacion.Location = new System.Drawing.Point(340, 3);
            this.datFechaFinalLiquidacion.Name = "datFechaFinalLiquidacion";
            this.datFechaFinalLiquidacion.Size = new System.Drawing.Size(123, 20);
            this.datFechaFinalLiquidacion.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(263, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Fecha final";
            // 
            // datFechaInicialLiquidacion
            // 
            this.datFechaInicialLiquidacion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datFechaInicialLiquidacion.Location = new System.Drawing.Point(114, 3);
            this.datFechaInicialLiquidacion.Name = "datFechaInicialLiquidacion";
            this.datFechaInicialLiquidacion.Size = new System.Drawing.Size(123, 20);
            this.datFechaInicialLiquidacion.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(29, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Fecha inicial";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chkFechaPago);
            this.panel1.Controls.Add(this.chkFechaLiquidacion);
            this.panel1.Controls.Add(this.chkEstado);
            this.panel1.Controls.Add(this.chkCliente);
            this.panel1.Controls.Add(this.chkFactura);
            this.panel1.Controls.Add(this.chkRecibo);
            this.panel1.Location = new System.Drawing.Point(7, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(139, 171);
            this.panel1.TabIndex = 19;
            // 
            // chkFechaPago
            // 
            this.chkFechaPago.AutoSize = true;
            this.chkFechaPago.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkFechaPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFechaPago.ForeColor = System.Drawing.Color.White;
            this.chkFechaPago.Location = new System.Drawing.Point(38, 148);
            this.chkFechaPago.Name = "chkFechaPago";
            this.chkFechaPago.Size = new System.Drawing.Size(100, 20);
            this.chkFechaPago.TabIndex = 0;
            this.chkFechaPago.Text = "Fecha pago";
            this.chkFechaPago.UseVisualStyleBackColor = true;
            this.chkFechaPago.CheckedChanged += new System.EventHandler(this.chkFechaPago_CheckedChanged);
            // 
            // chkFechaLiquidacion
            // 
            this.chkFechaLiquidacion.AutoSize = true;
            this.chkFechaLiquidacion.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkFechaLiquidacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFechaLiquidacion.ForeColor = System.Drawing.Color.White;
            this.chkFechaLiquidacion.Location = new System.Drawing.Point(5, 119);
            this.chkFechaLiquidacion.Name = "chkFechaLiquidacion";
            this.chkFechaLiquidacion.Size = new System.Drawing.Size(133, 20);
            this.chkFechaLiquidacion.TabIndex = 0;
            this.chkFechaLiquidacion.Text = "Fecha liquidación";
            this.chkFechaLiquidacion.UseVisualStyleBackColor = true;
            this.chkFechaLiquidacion.CheckedChanged += new System.EventHandler(this.chkFechaLiquidacion_CheckedChanged);
            // 
            // chkEstado
            // 
            this.chkEstado.AutoSize = true;
            this.chkEstado.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEstado.ForeColor = System.Drawing.Color.White;
            this.chkEstado.Location = new System.Drawing.Point(68, 89);
            this.chkEstado.Name = "chkEstado";
            this.chkEstado.Size = new System.Drawing.Size(70, 20);
            this.chkEstado.TabIndex = 0;
            this.chkEstado.Text = "Estado";
            this.chkEstado.UseVisualStyleBackColor = true;
            this.chkEstado.CheckedChanged += new System.EventHandler(this.chkEstado_CheckedChanged);
            // 
            // chkCliente
            // 
            this.chkCliente.AutoSize = true;
            this.chkCliente.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCliente.ForeColor = System.Drawing.Color.White;
            this.chkCliente.Location = new System.Drawing.Point(70, 61);
            this.chkCliente.Name = "chkCliente";
            this.chkCliente.Size = new System.Drawing.Size(68, 20);
            this.chkCliente.TabIndex = 0;
            this.chkCliente.Text = "Cliente";
            this.chkCliente.UseVisualStyleBackColor = true;
            this.chkCliente.CheckedChanged += new System.EventHandler(this.chkCliente_CheckedChanged);
            // 
            // chkFactura
            // 
            this.chkFactura.AutoSize = true;
            this.chkFactura.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFactura.ForeColor = System.Drawing.Color.White;
            this.chkFactura.Location = new System.Drawing.Point(66, 32);
            this.chkFactura.Name = "chkFactura";
            this.chkFactura.Size = new System.Drawing.Size(72, 20);
            this.chkFactura.TabIndex = 0;
            this.chkFactura.Text = "Factura";
            this.chkFactura.UseVisualStyleBackColor = true;
            this.chkFactura.CheckedChanged += new System.EventHandler(this.chkFactura_CheckedChanged);
            // 
            // chkRecibo
            // 
            this.chkRecibo.AutoSize = true;
            this.chkRecibo.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkRecibo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkRecibo.ForeColor = System.Drawing.Color.White;
            this.chkRecibo.Location = new System.Drawing.Point(67, 3);
            this.chkRecibo.Name = "chkRecibo";
            this.chkRecibo.Size = new System.Drawing.Size(71, 20);
            this.chkRecibo.TabIndex = 0;
            this.chkRecibo.Text = "Recibo";
            this.chkRecibo.UseVisualStyleBackColor = true;
            this.chkRecibo.CheckedChanged += new System.EventHandler(this.chkRecibo_CheckedChanged);
            // 
            // panFactura
            // 
            this.panFactura.Controls.Add(this.label1);
            this.panFactura.Controls.Add(this.txtNumFactura);
            this.panFactura.Enabled = false;
            this.panFactura.Location = new System.Drawing.Point(152, 37);
            this.panFactura.Name = "panFactura";
            this.panFactura.Size = new System.Drawing.Size(686, 26);
            this.panFactura.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "No. de factura";
            // 
            // txtNumFactura
            // 
            this.txtNumFactura.Location = new System.Drawing.Point(114, 3);
            this.txtNumFactura.MaxLength = 20;
            this.txtNumFactura.Name = "txtNumFactura";
            this.txtNumFactura.Size = new System.Drawing.Size(210, 20);
            this.txtNumFactura.TabIndex = 14;
            // 
            // panCliente
            // 
            this.panCliente.Controls.Add(this.cmbTipoDocumento);
            this.panCliente.Controls.Add(this.label4);
            this.panCliente.Controls.Add(this.label2);
            this.panCliente.Controls.Add(this.txtIdentificacion);
            this.panCliente.Enabled = false;
            this.panCliente.Location = new System.Drawing.Point(152, 66);
            this.panCliente.Name = "panCliente";
            this.panCliente.Size = new System.Drawing.Size(686, 26);
            this.panCliente.TabIndex = 18;
            // 
            // cmbTipoDocumento
            // 
            this.cmbTipoDocumento.DisplayMember = "TIPO";
            this.cmbTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoDocumento.FormattingEnabled = true;
            this.cmbTipoDocumento.Location = new System.Drawing.Point(114, 2);
            this.cmbTipoDocumento.Name = "cmbTipoDocumento";
            this.cmbTipoDocumento.Size = new System.Drawing.Size(210, 21);
            this.cmbTipoDocumento.TabIndex = 16;
            this.cmbTipoDocumento.ValueMember = "ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(5, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Tipo documento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(345, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "No. de documento";
            // 
            // txtIdentificacion
            // 
            this.txtIdentificacion.Location = new System.Drawing.Point(469, 3);
            this.txtIdentificacion.MaxLength = 20;
            this.txtIdentificacion.Name = "txtIdentificacion";
            this.txtIdentificacion.Size = new System.Drawing.Size(210, 20);
            this.txtIdentificacion.TabIndex = 14;
            // 
            // panEstado
            // 
            this.panEstado.Controls.Add(this.cmbEstado);
            this.panEstado.Controls.Add(this.label5);
            this.panEstado.Enabled = false;
            this.panEstado.Location = new System.Drawing.Point(152, 95);
            this.panEstado.Name = "panEstado";
            this.panEstado.Size = new System.Drawing.Size(686, 26);
            this.panEstado.TabIndex = 18;
            // 
            // cmbEstado
            // 
            this.cmbEstado.DisplayMember = "ESTADO";
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(114, 2);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(210, 21);
            this.cmbEstado.TabIndex = 16;
            this.cmbEstado.ValueMember = "ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(19, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Estado recibo";
            // 
            // panRecibo
            // 
            this.panRecibo.Controls.Add(this.label7);
            this.panRecibo.Controls.Add(this.txtNumRecibo);
            this.panRecibo.Enabled = false;
            this.panRecibo.Location = new System.Drawing.Point(152, 5);
            this.panRecibo.Name = "panRecibo";
            this.panRecibo.Size = new System.Drawing.Size(686, 26);
            this.panRecibo.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(20, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "No. de recibo";
            // 
            // txtNumRecibo
            // 
            this.txtNumRecibo.Location = new System.Drawing.Point(114, 3);
            this.txtNumRecibo.MaxLength = 20;
            this.txtNumRecibo.Name = "txtNumRecibo";
            this.txtNumRecibo.Size = new System.Drawing.Size(210, 20);
            this.txtNumRecibo.TabIndex = 14;
            // 
            // panFechaPago
            // 
            this.panFechaPago.Controls.Add(this.datFechaFinalPago);
            this.panFechaPago.Controls.Add(this.label8);
            this.panFechaPago.Controls.Add(this.datFechaInicialPago);
            this.panFechaPago.Controls.Add(this.label9);
            this.panFechaPago.Enabled = false;
            this.panFechaPago.Location = new System.Drawing.Point(152, 153);
            this.panFechaPago.Name = "panFechaPago";
            this.panFechaPago.Size = new System.Drawing.Size(477, 26);
            this.panFechaPago.TabIndex = 18;
            // 
            // datFechaFinalPago
            // 
            this.datFechaFinalPago.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datFechaFinalPago.Location = new System.Drawing.Point(340, 3);
            this.datFechaFinalPago.Name = "datFechaFinalPago";
            this.datFechaFinalPago.Size = new System.Drawing.Size(123, 20);
            this.datFechaFinalPago.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(263, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "Fecha final";
            // 
            // datFechaInicialPago
            // 
            this.datFechaInicialPago.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datFechaInicialPago.Location = new System.Drawing.Point(114, 3);
            this.datFechaInicialPago.Name = "datFechaInicialPago";
            this.datFechaInicialPago.Size = new System.Drawing.Size(123, 20);
            this.datFechaInicialPago.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(29, 5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 16);
            this.label9.TabIndex = 15;
            this.label9.Text = "Fecha inicial";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.btnLimpiar);
            this.panel9.Controls.Add(this.btnBuscar);
            this.panel9.Controls.Add(this.panel1);
            this.panel9.Controls.Add(this.panFechaLiquidacion);
            this.panel9.Controls.Add(this.panEstado);
            this.panel9.Controls.Add(this.panFechaPago);
            this.panel9.Controls.Add(this.panCliente);
            this.panel9.Controls.Add(this.panFactura);
            this.panel9.Controls.Add(this.panRecibo);
            this.panel9.Location = new System.Drawing.Point(12, 54);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(926, 185);
            this.panel9.TabIndex = 20;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimpiar.Image = global::EscuelaConduccion.Properties.Resources.clean_20x20;
            this.btnLimpiar.Location = new System.Drawing.Point(837, 146);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(86, 33);
            this.btnLimpiar.TabIndex = 23;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(210)))), ((int)(((byte)(138)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscar.Image = global::EscuelaConduccion.Properties.Resources.search_24x24;
            this.btnBuscar.Location = new System.Drawing.Point(745, 146);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(86, 33);
            this.btnBuscar.TabIndex = 20;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // grdDatos
            // 
            this.grdDatos.AllowUserToAddRows = false;
            this.grdDatos.AllowUserToDeleteRows = false;
            this.grdDatos.BackgroundColor = System.Drawing.Color.White;
            this.grdDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.num_recibo,
            this.num_factura,
            this.documento,
            this.identificacion,
            this.estado,
            this.fecha_liquidacion,
            this.fecha_pago,
            this.tipo,
            this.tarifa});
            this.grdDatos.GridColor = System.Drawing.Color.White;
            this.grdDatos.Location = new System.Drawing.Point(12, 245);
            this.grdDatos.MultiSelect = false;
            this.grdDatos.Name = "grdDatos";
            this.grdDatos.ReadOnly = true;
            this.grdDatos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdDatos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grdDatos.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(239)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(210)))), ((int)(((byte)(138)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.grdDatos.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.grdDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdDatos.Size = new System.Drawing.Size(922, 203);
            this.grdDatos.TabIndex = 27;
            // 
            // num_recibo
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_recibo.DefaultCellStyle = dataGridViewCellStyle1;
            this.num_recibo.HeaderText = "No. RECIBO";
            this.num_recibo.Name = "num_recibo";
            this.num_recibo.ReadOnly = true;
            // 
            // num_factura
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_factura.DefaultCellStyle = dataGridViewCellStyle2;
            this.num_factura.HeaderText = "No. FACTURA";
            this.num_factura.Name = "num_factura";
            this.num_factura.ReadOnly = true;
            // 
            // documento
            // 
            this.documento.HeaderText = "DOCUMENTO";
            this.documento.Name = "documento";
            this.documento.ReadOnly = true;
            // 
            // identificacion
            // 
            this.identificacion.HeaderText = "IDENTIFICACIÓN";
            this.identificacion.Name = "identificacion";
            this.identificacion.ReadOnly = true;
            this.identificacion.Width = 150;
            // 
            // estado
            // 
            this.estado.HeaderText = "ESTADO";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            // 
            // fecha_liquidacion
            // 
            this.fecha_liquidacion.HeaderText = "FECHA LIQUIDACIÓN";
            this.fecha_liquidacion.Name = "fecha_liquidacion";
            this.fecha_liquidacion.ReadOnly = true;
            this.fecha_liquidacion.Width = 80;
            // 
            // fecha_pago
            // 
            this.fecha_pago.HeaderText = "FECHA PAGO";
            this.fecha_pago.Name = "fecha_pago";
            this.fecha_pago.ReadOnly = true;
            this.fecha_pago.Width = 80;
            // 
            // tipo
            // 
            this.tipo.HeaderText = "TIPO";
            this.tipo.Name = "tipo";
            this.tipo.ReadOnly = true;
            // 
            // tarifa
            // 
            this.tarifa.HeaderText = "TARIFA";
            this.tarifa.Name = "tarifa";
            this.tarifa.ReadOnly = true;
            // 
            // frmBuscarReciboFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(129)))), ((int)(((byte)(193)))));
            this.ClientSize = new System.Drawing.Size(945, 507);
            this.Controls.Add(this.grdDatos);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(961, 546);
            this.MinimumSize = new System.Drawing.Size(961, 546);
            this.Name = "frmBuscarReciboFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Recibo/Factura";
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panFechaLiquidacion.ResumeLayout(false);
            this.panFechaLiquidacion.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panFactura.ResumeLayout(false);
            this.panFactura.PerformLayout();
            this.panCliente.ResumeLayout(false);
            this.panCliente.PerformLayout();
            this.panEstado.ResumeLayout(false);
            this.panEstado.PerformLayout();
            this.panRecibo.ResumeLayout(false);
            this.panRecibo.PerformLayout();
            this.panFechaPago.ResumeLayout(false);
            this.panFechaPago.PerformLayout();
            this.panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Panel panel2;
        protected System.Windows.Forms.Label lblTitulo;
        protected System.Windows.Forms.Panel panel3;
        protected System.Windows.Forms.Button btnReimprimir;
        protected System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Panel panFechaLiquidacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chkFactura;
        private System.Windows.Forms.CheckBox chkRecibo;
        private System.Windows.Forms.Panel panFactura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumFactura;
        private System.Windows.Forms.Panel panCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdentificacion;
        private System.Windows.Forms.ComboBox cmbTipoDocumento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker datFechaFinalLiquidacion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker datFechaInicialLiquidacion;
        private System.Windows.Forms.CheckBox chkEstado;
        private System.Windows.Forms.CheckBox chkCliente;
        private System.Windows.Forms.Panel panEstado;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkFechaPago;
        private System.Windows.Forms.CheckBox chkFechaLiquidacion;
        private System.Windows.Forms.Panel panRecibo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNumRecibo;
        private System.Windows.Forms.Panel panFechaPago;
        private System.Windows.Forms.DateTimePicker datFechaFinalPago;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker datFechaInicialPago;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel9;
        public System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.DataGridView grdDatos;
        protected System.Windows.Forms.Button btnPagar;
        protected System.Windows.Forms.Button btnAnularPago;
        protected System.Windows.Forms.Button btnAnularRecibo;
        private System.Windows.Forms.DataGridViewTextBoxColumn num_recibo;
        private System.Windows.Forms.DataGridViewTextBoxColumn num_factura;
        private System.Windows.Forms.DataGridViewTextBoxColumn documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn identificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_liquidacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_pago;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarifa;
    }
}