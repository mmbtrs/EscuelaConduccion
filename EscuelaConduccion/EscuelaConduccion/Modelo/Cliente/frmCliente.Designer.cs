namespace EscuelaConduccion.Modelo.Cliente
{
    partial class frmCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCliente));
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnBuscarCiudad = new System.Windows.Forms.Button();
            this.datFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDepartamento = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtNumDocumento = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbTipoDocumento = new System.Windows.Forms.ComboBox();
            this.cmbGenero = new System.Windows.Forms.ComboBox();
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
            this.panel2.Size = new System.Drawing.Size(753, 42);
            this.panel2.TabIndex = 15;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Black;
            this.lblTitulo.Location = new System.Drawing.Point(3, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(747, 20);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Cliente";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(212)))), ((int)(((byte)(248)))));
            this.panel3.Controls.Add(this.btnSalir);
            this.panel3.Controls.Add(this.btnGuardar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 252);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(753, 45);
            this.panel3.TabIndex = 16;
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalir.Image = global::EscuelaConduccion.Properties.Resources.exit_22x22;
            this.btnSalir.Location = new System.Drawing.Point(653, 6);
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
            this.btnGuardar.Image = global::EscuelaConduccion.Properties.Resources.save_24x24;
            this.btnGuardar.Location = new System.Drawing.Point(561, 6);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(86, 33);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnBuscarCiudad
            // 
            this.btnBuscarCiudad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(210)))), ((int)(((byte)(138)))));
            this.btnBuscarCiudad.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscarCiudad.Image = global::EscuelaConduccion.Properties.Resources.search_24x24;
            this.btnBuscarCiudad.Location = new System.Drawing.Point(718, 120);
            this.btnBuscarCiudad.Name = "btnBuscarCiudad";
            this.btnBuscarCiudad.Size = new System.Drawing.Size(21, 21);
            this.btnBuscarCiudad.TabIndex = 39;
            this.btnBuscarCiudad.UseVisualStyleBackColor = false;
            this.btnBuscarCiudad.Click += new System.EventHandler(this.btnBuscarCiudad_Click);
            // 
            // datFechaNacimiento
            // 
            this.datFechaNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datFechaNacimiento.Location = new System.Drawing.Point(161, 218);
            this.datFechaNacimiento.Name = "datFechaNacimiento";
            this.datFechaNacimiento.Size = new System.Drawing.Size(100, 21);
            this.datFechaNacimiento.TabIndex = 38;
            this.datFechaNacimiento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.datFechaNacimiento_KeyPress);
            // 
            // txtApellidos
            // 
            this.txtApellidos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidos.Location = new System.Drawing.Point(540, 89);
            this.txtApellidos.MaxLength = 50;
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(200, 21);
            this.txtApellidos.TabIndex = 34;
            this.txtApellidos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellidos_KeyPress);
            // 
            // txtTelefono
            // 
            this.txtTelefono.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(161, 186);
            this.txtTelefono.MaxLength = 50;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(201, 21);
            this.txtTelefono.TabIndex = 32;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(19, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 16);
            this.label1.TabIndex = 28;
            this.label1.Text = "* Tipo de documento:";
            // 
            // txtDepartamento
            // 
            this.txtDepartamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepartamento.Location = new System.Drawing.Point(161, 154);
            this.txtDepartamento.Name = "txtDepartamento";
            this.txtDepartamento.ReadOnly = true;
            this.txtDepartamento.Size = new System.Drawing.Size(201, 21);
            this.txtDepartamento.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(378, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 16);
            this.label2.TabIndex = 27;
            this.label2.Text = "* Número de documento:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(161, 122);
            this.txtDireccion.MaxLength = 100;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(201, 21);
            this.txtDireccion.TabIndex = 29;
            this.txtDireccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDireccion_KeyPress);
            // 
            // txtNumDocumento
            // 
            this.txtNumDocumento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNumDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumDocumento.Location = new System.Drawing.Point(540, 56);
            this.txtNumDocumento.MaxLength = 20;
            this.txtNumDocumento.Name = "txtNumDocumento";
            this.txtNumDocumento.Size = new System.Drawing.Size(200, 21);
            this.txtNumDocumento.TabIndex = 37;
            this.txtNumDocumento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumDocumento_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(470, 221);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 16);
            this.label12.TabIndex = 25;
            this.label12.Text = "* Genero:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(80, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 24;
            this.label3.Text = "* Nombres:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(458, 92);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 16);
            this.label10.TabIndex = 17;
            this.label10.Text = "* Apellidos:";
            // 
            // txtNombres
            // 
            this.txtNombres.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombres.Location = new System.Drawing.Point(161, 90);
            this.txtNombres.MaxLength = 50;
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(201, 21);
            this.txtNombres.TabIndex = 30;
            this.txtNombres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombres_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(90, 189);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 16);
            this.label8.TabIndex = 22;
            this.label8.Text = "Teléfono:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(444, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 16);
            this.label5.TabIndex = 21;
            this.label5.Text = "* Ciudad (Dir):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(30, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 16);
            this.label6.TabIndex = 20;
            this.label6.Text = "Departamento (Dir):";
            // 
            // txtCiudad
            // 
            this.txtCiudad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCiudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCiudad.Location = new System.Drawing.Point(539, 120);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.ReadOnly = true;
            this.txtCiudad.Size = new System.Drawing.Size(180, 21);
            this.txtCiudad.TabIndex = 33;
            this.txtCiudad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCiudad_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(79, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "* Dirección:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(481, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "Celular:";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.Location = new System.Drawing.Point(539, 184);
            this.txtCorreo.MaxLength = 50;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(201, 21);
            this.txtCorreo.TabIndex = 35;
            this.txtCorreo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCorreo_KeyPress);
            // 
            // txtCelular
            // 
            this.txtCelular.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCelular.Location = new System.Drawing.Point(539, 152);
            this.txtCelular.MaxLength = 10;
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(201, 21);
            this.txtCelular.TabIndex = 36;
            this.txtCelular.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCelular_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(11, 223);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(144, 16);
            this.label11.TabIndex = 23;
            this.label11.Text = "* Fecha de nacimiento:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(474, 187);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 16);
            this.label9.TabIndex = 26;
            this.label9.Text = "* Correo:";
            // 
            // cmbTipoDocumento
            // 
            this.cmbTipoDocumento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbTipoDocumento.DisplayMember = "TIPO";
            this.cmbTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoDocumento.FormattingEnabled = true;
            this.cmbTipoDocumento.Location = new System.Drawing.Point(161, 60);
            this.cmbTipoDocumento.Name = "cmbTipoDocumento";
            this.cmbTipoDocumento.Size = new System.Drawing.Size(201, 21);
            this.cmbTipoDocumento.TabIndex = 40;
            this.cmbTipoDocumento.ValueMember = "ID";
            this.cmbTipoDocumento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbTipoDocumento_KeyPress);
            // 
            // cmbGenero
            // 
            this.cmbGenero.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbGenero.DisplayMember = "NOMBRE";
            this.cmbGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGenero.FormattingEnabled = true;
            this.cmbGenero.Location = new System.Drawing.Point(539, 216);
            this.cmbGenero.Name = "cmbGenero";
            this.cmbGenero.Size = new System.Drawing.Size(200, 21);
            this.cmbGenero.TabIndex = 41;
            this.cmbGenero.ValueMember = "ID";
            this.cmbGenero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbGenero_KeyPress);
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(129)))), ((int)(((byte)(193)))));
            this.ClientSize = new System.Drawing.Size(753, 297);
            this.Controls.Add(this.cmbGenero);
            this.Controls.Add(this.cmbTipoDocumento);
            this.Controls.Add(this.btnBuscarCiudad);
            this.Controls.Add(this.datFechaNacimiento);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDepartamento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtNumDocumento);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCiudad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtCelular);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cliente";
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Panel panel2;
        protected System.Windows.Forms.Label lblTitulo;
        protected System.Windows.Forms.Panel panel3;
        protected System.Windows.Forms.Button btnSalir;
        protected System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnBuscarCiudad;
        private System.Windows.Forms.DateTimePicker datFechaNacimiento;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDepartamento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtNumDocumento;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCiudad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbTipoDocumento;
        private System.Windows.Forms.ComboBox cmbGenero;
    }
}