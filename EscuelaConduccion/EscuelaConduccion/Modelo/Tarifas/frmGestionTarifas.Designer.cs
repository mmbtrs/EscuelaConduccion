namespace EscuelaConduccion.Modelo.Tarifas
{
    partial class frmGestionTarifas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestionTarifas));
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCopiarVigencia = new System.Windows.Forms.Button();
            this.btnGestionVigencia = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbVigencia = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grdTarifas = new System.Windows.Forms.DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TARIFA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CATEGORIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VIGENCIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESTADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnInsertarTarifa = new System.Windows.Forms.Button();
            this.btnEditarTarifa = new System.Windows.Forms.Button();
            this.btnEliminarTarifa = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtValorTarifa = new System.Windows.Forms.TextBox();
            this.cmbFiltroTarifa = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.grdDetalleTarifa = new System.Windows.Forms.DataGridView();
            this.btnInsertarDetalle = new System.Windows.Forms.Button();
            this.btnEditarDetalle = new System.Windows.Forms.Button();
            this.btnEliminarDetalle = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtValorDetalle = new System.Windows.Forms.TextBox();
            this.cmbFiltroDetalle = new System.Windows.Forms.ComboBox();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTarifas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDetalleTarifa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(212)))), ((int)(((byte)(248)))));
            this.panel3.Controls.Add(this.btnSalir);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 575);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1163, 45);
            this.panel3.TabIndex = 17;
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalir.Image = global::EscuelaConduccion.Properties.Resources.exit_22x22;
            this.btnSalir.Location = new System.Drawing.Point(1068, 6);
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
            this.panel2.Size = new System.Drawing.Size(1163, 42);
            this.panel2.TabIndex = 16;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Black;
            this.lblTitulo.Location = new System.Drawing.Point(3, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(1157, 20);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Configurar Tarifas";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(129)))), ((int)(((byte)(193)))));
            this.groupBox1.Controls.Add(this.btnCopiarVigencia);
            this.groupBox1.Controls.Add(this.btnGestionVigencia);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbVigencia);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(102)))));
            this.groupBox1.Location = new System.Drawing.Point(10, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1144, 81);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "   Vigencia   ";
            // 
            // btnCopiarVigencia
            // 
            this.btnCopiarVigencia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopiarVigencia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(210)))), ((int)(((byte)(138)))));
            this.btnCopiarVigencia.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCopiarVigencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopiarVigencia.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCopiarVigencia.Image = global::EscuelaConduccion.Properties.Resources.copy_32x32;
            this.btnCopiarVigencia.Location = new System.Drawing.Point(810, 27);
            this.btnCopiarVigencia.Name = "btnCopiarVigencia";
            this.btnCopiarVigencia.Size = new System.Drawing.Size(153, 41);
            this.btnCopiarVigencia.TabIndex = 34;
            this.btnCopiarVigencia.Text = "Copiar Vigencia";
            this.btnCopiarVigencia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCopiarVigencia.UseVisualStyleBackColor = false;
            this.btnCopiarVigencia.Click += new System.EventHandler(this.btnCopiarVigencia_Click);
            // 
            // btnGestionVigencia
            // 
            this.btnGestionVigencia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGestionVigencia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(212)))), ((int)(((byte)(248)))));
            this.btnGestionVigencia.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGestionVigencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionVigencia.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGestionVigencia.Image = global::EscuelaConduccion.Properties.Resources.calendar2_32x32;
            this.btnGestionVigencia.Location = new System.Drawing.Point(969, 27);
            this.btnGestionVigencia.Name = "btnGestionVigencia";
            this.btnGestionVigencia.Size = new System.Drawing.Size(153, 41);
            this.btnGestionVigencia.TabIndex = 35;
            this.btnGestionVigencia.Text = "Gestión Vigencia";
            this.btnGestionVigencia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGestionVigencia.UseVisualStyleBackColor = false;
            this.btnGestionVigencia.Click += new System.EventHandler(this.btnGestionVigencia_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(21, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 33;
            this.label1.Text = "Vigencia";
            // 
            // cmbVigencia
            // 
            this.cmbVigencia.DisplayMember = "NOMBRE";
            this.cmbVigencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVigencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbVigencia.FormattingEnabled = true;
            this.cmbVigencia.Items.AddRange(new object[] {
            "IDENTIFICACIÓN",
            "NOMBRES",
            "APELLIDOS",
            "DIRECCIÓN",
            "CIUDAD",
            "DEPARTAMENTO",
            "GENERO",
            "CELULAR",
            "CORREO"});
            this.cmbVigencia.Location = new System.Drawing.Point(24, 44);
            this.cmbVigencia.Name = "cmbVigencia";
            this.cmbVigencia.Size = new System.Drawing.Size(169, 24);
            this.cmbVigencia.TabIndex = 30;
            this.cmbVigencia.ValueMember = "ID";
            this.cmbVigencia.SelectedIndexChanged += new System.EventHandler(this.cmbVigencia_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(129)))), ((int)(((byte)(193)))));
            this.groupBox2.Controls.Add(this.grdTarifas);
            this.groupBox2.Controls.Add(this.btnInsertarTarifa);
            this.groupBox2.Controls.Add(this.btnEditarTarifa);
            this.groupBox2.Controls.Add(this.btnEliminarTarifa);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.txtValorTarifa);
            this.groupBox2.Controls.Add(this.cmbFiltroTarifa);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(102)))));
            this.groupBox2.Location = new System.Drawing.Point(10, 135);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(569, 434);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "   Tarifa   ";
            // 
            // grdTarifas
            // 
            this.grdTarifas.AllowUserToAddRows = false;
            this.grdTarifas.AllowUserToDeleteRows = false;
            this.grdTarifas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdTarifas.BackgroundColor = System.Drawing.Color.White;
            this.grdTarifas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(64)))), ((int)(((byte)(132)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(79)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdTarifas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdTarifas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTarifas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.ID,
            this.TARIFA,
            this.CATEGORIA,
            this.VIGENCIA,
            this.ESTADO});
            this.grdTarifas.EnableHeadersVisualStyles = false;
            this.grdTarifas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(208)))), ((int)(((byte)(136)))));
            this.grdTarifas.Location = new System.Drawing.Point(6, 74);
            this.grdTarifas.MultiSelect = false;
            this.grdTarifas.Name = "grdTarifas";
            this.grdTarifas.ReadOnly = true;
            this.grdTarifas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(208)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdTarifas.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grdTarifas.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(239)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(232)))), ((int)(((byte)(101)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.grdTarifas.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.grdTarifas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdTarifas.Size = new System.Drawing.Size(557, 352);
            this.grdTarifas.TabIndex = 31;
            this.grdTarifas.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdTarifas_RowEnter);
            this.grdTarifas.SelectionChanged += new System.EventHandler(this.grdTarifas_SelectionChanged);
            // 
            // No
            // 
            this.No.FillWeight = 2.341017F;
            this.No.HeaderText = "No";
            this.No.Name = "No";
            this.No.ReadOnly = true;
            this.No.Width = 40;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // TARIFA
            // 
            this.TARIFA.FillWeight = 81.70654F;
            this.TARIFA.HeaderText = "TARIFA";
            this.TARIFA.Name = "TARIFA";
            this.TARIFA.ReadOnly = true;
            this.TARIFA.Width = 200;
            // 
            // CATEGORIA
            // 
            this.CATEGORIA.FillWeight = 91.38332F;
            this.CATEGORIA.HeaderText = "CATEGORIA";
            this.CATEGORIA.Name = "CATEGORIA";
            this.CATEGORIA.ReadOnly = true;
            // 
            // VIGENCIA
            // 
            this.VIGENCIA.FillWeight = 121.5234F;
            this.VIGENCIA.HeaderText = "VIGENCIA";
            this.VIGENCIA.Name = "VIGENCIA";
            this.VIGENCIA.ReadOnly = true;
            // 
            // ESTADO
            // 
            this.ESTADO.FillWeight = 203.0457F;
            this.ESTADO.HeaderText = "ESTADO";
            this.ESTADO.Name = "ESTADO";
            this.ESTADO.ReadOnly = true;
            // 
            // btnInsertarTarifa
            // 
            this.btnInsertarTarifa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInsertarTarifa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(210)))), ((int)(((byte)(138)))));
            this.btnInsertarTarifa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInsertarTarifa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertarTarifa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnInsertarTarifa.Image = global::EscuelaConduccion.Properties.Resources.add_insert_new_32x32;
            this.btnInsertarTarifa.Location = new System.Drawing.Point(275, 27);
            this.btnInsertarTarifa.Name = "btnInsertarTarifa";
            this.btnInsertarTarifa.Size = new System.Drawing.Size(92, 41);
            this.btnInsertarTarifa.TabIndex = 35;
            this.btnInsertarTarifa.Text = "Insertar";
            this.btnInsertarTarifa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInsertarTarifa.UseVisualStyleBackColor = false;
            this.btnInsertarTarifa.Click += new System.EventHandler(this.btnInsertarTarifa_Click);
            // 
            // btnEditarTarifa
            // 
            this.btnEditarTarifa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditarTarifa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(102)))));
            this.btnEditarTarifa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditarTarifa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarTarifa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEditarTarifa.Image = global::EscuelaConduccion.Properties.Resources.edit_icon_32x32;
            this.btnEditarTarifa.Location = new System.Drawing.Point(373, 27);
            this.btnEditarTarifa.Name = "btnEditarTarifa";
            this.btnEditarTarifa.Size = new System.Drawing.Size(92, 41);
            this.btnEditarTarifa.TabIndex = 36;
            this.btnEditarTarifa.Text = "Editar";
            this.btnEditarTarifa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditarTarifa.UseVisualStyleBackColor = false;
            this.btnEditarTarifa.Click += new System.EventHandler(this.btnEditarTarifa_Click);
            // 
            // btnEliminarTarifa
            // 
            this.btnEliminarTarifa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarTarifa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(125)))), ((int)(((byte)(104)))));
            this.btnEliminarTarifa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminarTarifa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarTarifa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEliminarTarifa.Image = global::EscuelaConduccion.Properties.Resources.clean_20x20;
            this.btnEliminarTarifa.Location = new System.Drawing.Point(471, 27);
            this.btnEliminarTarifa.Name = "btnEliminarTarifa";
            this.btnEliminarTarifa.Size = new System.Drawing.Size(92, 41);
            this.btnEliminarTarifa.TabIndex = 37;
            this.btnEliminarTarifa.Text = "Eliminar";
            this.btnEliminarTarifa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminarTarifa.UseVisualStyleBackColor = false;
            this.btnEliminarTarifa.Click += new System.EventHandler(this.btnEliminarTarifa_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(151, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 33;
            this.label2.Text = "Valor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(31, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 16);
            this.label3.TabIndex = 34;
            this.label3.Text = "Filtro";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EscuelaConduccion.Properties.Resources.search_24x24;
            this.pictureBox1.Location = new System.Drawing.Point(7, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 21);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // txtValorTarifa
            // 
            this.txtValorTarifa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorTarifa.Location = new System.Drawing.Point(154, 47);
            this.txtValorTarifa.Name = "txtValorTarifa";
            this.txtValorTarifa.Size = new System.Drawing.Size(114, 21);
            this.txtValorTarifa.TabIndex = 31;
            this.txtValorTarifa.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtValorTarifa_KeyUp);
            // 
            // cmbFiltroTarifa
            // 
            this.cmbFiltroTarifa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltroTarifa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFiltroTarifa.FormattingEnabled = true;
            this.cmbFiltroTarifa.Items.AddRange(new object[] {
            "TARIFA",
            "CATEGORIA"});
            this.cmbFiltroTarifa.Location = new System.Drawing.Point(34, 44);
            this.cmbFiltroTarifa.Name = "cmbFiltroTarifa";
            this.cmbFiltroTarifa.Size = new System.Drawing.Size(114, 24);
            this.cmbFiltroTarifa.TabIndex = 30;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(129)))), ((int)(((byte)(193)))));
            this.groupBox3.Controls.Add(this.grdDetalleTarifa);
            this.groupBox3.Controls.Add(this.btnInsertarDetalle);
            this.groupBox3.Controls.Add(this.btnEditarDetalle);
            this.groupBox3.Controls.Add(this.btnEliminarDetalle);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.pictureBox2);
            this.groupBox3.Controls.Add(this.txtValorDetalle);
            this.groupBox3.Controls.Add(this.cmbFiltroDetalle);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(102)))));
            this.groupBox3.Location = new System.Drawing.Point(585, 135);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(569, 434);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "   Detalle Tarifa   ";
            // 
            // grdDetalleTarifa
            // 
            this.grdDetalleTarifa.AllowUserToAddRows = false;
            this.grdDetalleTarifa.AllowUserToDeleteRows = false;
            this.grdDetalleTarifa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdDetalleTarifa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdDetalleTarifa.BackgroundColor = System.Drawing.Color.White;
            this.grdDetalleTarifa.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(64)))), ((int)(((byte)(132)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(79)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdDetalleTarifa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grdDetalleTarifa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDetalleTarifa.EnableHeadersVisualStyles = false;
            this.grdDetalleTarifa.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(208)))), ((int)(((byte)(136)))));
            this.grdDetalleTarifa.Location = new System.Drawing.Point(6, 74);
            this.grdDetalleTarifa.MultiSelect = false;
            this.grdDetalleTarifa.Name = "grdDetalleTarifa";
            this.grdDetalleTarifa.ReadOnly = true;
            this.grdDetalleTarifa.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(208)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdDetalleTarifa.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.grdDetalleTarifa.RowHeadersVisible = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(239)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(232)))), ((int)(((byte)(101)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.grdDetalleTarifa.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.grdDetalleTarifa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdDetalleTarifa.Size = new System.Drawing.Size(557, 352);
            this.grdDetalleTarifa.TabIndex = 31;
            // 
            // btnInsertarDetalle
            // 
            this.btnInsertarDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInsertarDetalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(210)))), ((int)(((byte)(138)))));
            this.btnInsertarDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInsertarDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertarDetalle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnInsertarDetalle.Image = global::EscuelaConduccion.Properties.Resources.add_insert_new_32x32;
            this.btnInsertarDetalle.Location = new System.Drawing.Point(275, 27);
            this.btnInsertarDetalle.Name = "btnInsertarDetalle";
            this.btnInsertarDetalle.Size = new System.Drawing.Size(92, 41);
            this.btnInsertarDetalle.TabIndex = 35;
            this.btnInsertarDetalle.Text = "Insertar";
            this.btnInsertarDetalle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInsertarDetalle.UseVisualStyleBackColor = false;
            this.btnInsertarDetalle.Click += new System.EventHandler(this.btnInsertarDetalle_Click);
            // 
            // btnEditarDetalle
            // 
            this.btnEditarDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditarDetalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(102)))));
            this.btnEditarDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditarDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarDetalle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEditarDetalle.Image = global::EscuelaConduccion.Properties.Resources.edit_icon_32x32;
            this.btnEditarDetalle.Location = new System.Drawing.Point(373, 27);
            this.btnEditarDetalle.Name = "btnEditarDetalle";
            this.btnEditarDetalle.Size = new System.Drawing.Size(92, 41);
            this.btnEditarDetalle.TabIndex = 36;
            this.btnEditarDetalle.Text = "Editar";
            this.btnEditarDetalle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditarDetalle.UseVisualStyleBackColor = false;
            this.btnEditarDetalle.Click += new System.EventHandler(this.btnEditarDetalle_Click);
            // 
            // btnEliminarDetalle
            // 
            this.btnEliminarDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarDetalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(125)))), ((int)(((byte)(104)))));
            this.btnEliminarDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminarDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarDetalle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEliminarDetalle.Image = global::EscuelaConduccion.Properties.Resources.clean_20x20;
            this.btnEliminarDetalle.Location = new System.Drawing.Point(471, 27);
            this.btnEliminarDetalle.Name = "btnEliminarDetalle";
            this.btnEliminarDetalle.Size = new System.Drawing.Size(92, 41);
            this.btnEliminarDetalle.TabIndex = 37;
            this.btnEliminarDetalle.Text = "Eliminar";
            this.btnEliminarDetalle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminarDetalle.UseVisualStyleBackColor = false;
            this.btnEliminarDetalle.Click += new System.EventHandler(this.btnEliminarDetalle_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(151, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 33;
            this.label4.Text = "Valor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(31, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 16);
            this.label5.TabIndex = 34;
            this.label5.Text = "Filtro";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::EscuelaConduccion.Properties.Resources.search_24x24;
            this.pictureBox2.Location = new System.Drawing.Point(7, 47);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 21);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 32;
            this.pictureBox2.TabStop = false;
            // 
            // txtValorDetalle
            // 
            this.txtValorDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorDetalle.Location = new System.Drawing.Point(154, 47);
            this.txtValorDetalle.Name = "txtValorDetalle";
            this.txtValorDetalle.Size = new System.Drawing.Size(114, 21);
            this.txtValorDetalle.TabIndex = 31;
            this.txtValorDetalle.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtValorDetalle_KeyUp);
            // 
            // cmbFiltroDetalle
            // 
            this.cmbFiltroDetalle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltroDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFiltroDetalle.FormattingEnabled = true;
            this.cmbFiltroDetalle.Items.AddRange(new object[] {
            "CONCEPTO",
            "FORMULA"});
            this.cmbFiltroDetalle.Location = new System.Drawing.Point(34, 44);
            this.cmbFiltroDetalle.Name = "cmbFiltroDetalle";
            this.cmbFiltroDetalle.Size = new System.Drawing.Size(114, 24);
            this.cmbFiltroDetalle.TabIndex = 30;
            // 
            // frmGestionTarifas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(129)))), ((int)(((byte)(193)))));
            this.ClientSize = new System.Drawing.Size(1163, 620);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGestionTarifas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión Tarifas";
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTarifas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDetalleTarifa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Panel panel3;
        protected System.Windows.Forms.Button btnSalir;
        protected System.Windows.Forms.Panel panel2;
        protected System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox groupBox1;
        protected System.Windows.Forms.Label label1;
        protected System.Windows.Forms.ComboBox cmbVigencia;
        protected System.Windows.Forms.Button btnCopiarVigencia;
        protected System.Windows.Forms.Button btnGestionVigencia;
        private System.Windows.Forms.GroupBox groupBox2;
        protected System.Windows.Forms.Label label2;
        protected System.Windows.Forms.Label label3;
        protected System.Windows.Forms.PictureBox pictureBox1;
        protected System.Windows.Forms.TextBox txtValorTarifa;
        protected System.Windows.Forms.ComboBox cmbFiltroTarifa;
        protected System.Windows.Forms.Button btnInsertarTarifa;
        protected System.Windows.Forms.Button btnEditarTarifa;
        protected System.Windows.Forms.Button btnEliminarTarifa;
        private System.Windows.Forms.DataGridView grdTarifas;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView grdDetalleTarifa;
        protected System.Windows.Forms.Button btnInsertarDetalle;
        protected System.Windows.Forms.Button btnEditarDetalle;
        protected System.Windows.Forms.Button btnEliminarDetalle;
        protected System.Windows.Forms.Label label4;
        protected System.Windows.Forms.Label label5;
        protected System.Windows.Forms.PictureBox pictureBox2;
        protected System.Windows.Forms.TextBox txtValorDetalle;
        protected System.Windows.Forms.ComboBox cmbFiltroDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TARIFA;
        private System.Windows.Forms.DataGridViewTextBoxColumn CATEGORIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn VIGENCIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESTADO;
    }
}