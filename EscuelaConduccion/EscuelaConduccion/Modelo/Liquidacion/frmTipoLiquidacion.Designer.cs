namespace EscuelaConduccion.Modelo.Liquidacion
{
    partial class frmTipoLiquidacion
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
            this.btnOpcion2 = new System.Windows.Forms.Button();
            this.btnOpcion1 = new System.Windows.Forms.Button();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.picIcono = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picIcono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOpcion2
            // 
            this.btnOpcion2.BackColor = System.Drawing.Color.White;
            this.btnOpcion2.FlatAppearance.BorderSize = 0;
            this.btnOpcion2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpcion2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpcion2.Location = new System.Drawing.Point(183, 146);
            this.btnOpcion2.Name = "btnOpcion2";
            this.btnOpcion2.Size = new System.Drawing.Size(175, 32);
            this.btnOpcion2.TabIndex = 10;
            this.btnOpcion2.Text = "Acuerdo de Pago";
            this.btnOpcion2.UseVisualStyleBackColor = false;
            this.btnOpcion2.Click += new System.EventHandler(this.btnOpcion2_Click);
            // 
            // btnOpcion1
            // 
            this.btnOpcion1.BackColor = System.Drawing.Color.White;
            this.btnOpcion1.FlatAppearance.BorderSize = 0;
            this.btnOpcion1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpcion1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpcion1.Location = new System.Drawing.Point(3, 146);
            this.btnOpcion1.Name = "btnOpcion1";
            this.btnOpcion1.Size = new System.Drawing.Size(177, 32);
            this.btnOpcion1.TabIndex = 11;
            this.btnOpcion1.Text = "Pago Total";
            this.btnOpcion1.UseVisualStyleBackColor = false;
            this.btnOpcion1.Click += new System.EventHandler(this.btnOpcion1_Click);
            // 
            // lblMensaje
            // 
            this.lblMensaje.BackColor = System.Drawing.Color.White;
            this.lblMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.Location = new System.Drawing.Point(12, 93);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(336, 23);
            this.lblMensaje.TabIndex = 13;
            this.lblMensaje.Text = "Que desea realizar?";
            this.lblMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picIcono
            // 
            this.picIcono.BackColor = System.Drawing.Color.White;
            this.picIcono.Image = global::EscuelaConduccion.Properties.Resources.Incognita;
            this.picIcono.Location = new System.Drawing.Point(158, 36);
            this.picIcono.Name = "picIcono";
            this.picIcono.Size = new System.Drawing.Size(50, 50);
            this.picIcono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picIcono.TabIndex = 12;
            this.picIcono.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EscuelaConduccion.Properties.Resources.ventana;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(360, 181);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // frmTipoLiquidacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 181);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.picIcono);
            this.Controls.Add(this.btnOpcion2);
            this.Controls.Add(this.btnOpcion1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTipoLiquidacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTipoLiquidacion";
            ((System.ComponentModel.ISupportInitialize)(this.picIcono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        protected System.Windows.Forms.Button btnOpcion2;
        protected System.Windows.Forms.Button btnOpcion1;
        public System.Windows.Forms.Label lblMensaje;
        protected System.Windows.Forms.PictureBox picIcono;
    }
}