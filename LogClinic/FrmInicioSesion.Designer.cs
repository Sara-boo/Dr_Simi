namespace LogClinic
{
    partial class FrmInicioSesion
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.PAzul = new System.Windows.Forms.Panel();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.TxtClave = new System.Windows.Forms.TextBox();
            this.BtnIngresar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnNoVer = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnVer = new System.Windows.Forms.Button();
            this.PAzul.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PAzul
            // 
            this.PAzul.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(93)))), ((int)(((byte)(126)))));
            this.PAzul.Controls.Add(this.BtnSalir);
            this.PAzul.Controls.Add(this.label1);
            this.PAzul.Controls.Add(this.panel2);
            this.PAzul.Location = new System.Drawing.Point(-3, -2);
            this.PAzul.Name = "PAzul";
            this.PAzul.Size = new System.Drawing.Size(800, 92);
            this.PAzul.TabIndex = 16;
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackgroundImage = global::LogClinic.Properties.Resources.Cerrar;
            this.BtnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSalir.Location = new System.Drawing.Point(721, 14);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(53, 56);
            this.BtnSalir.TabIndex = 18;
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(237, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "INICIAR SESIÓN";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(0, 96);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(774, 100);
            this.panel2.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Bright", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(204, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(300, 42);
            this.label4.TabIndex = 0;
            this.label4.Text = "INICIAR SESIÓN";
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(236)))), ((int)(((byte)(238)))));
            this.TxtUsuario.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUsuario.Location = new System.Drawing.Point(368, 191);
            this.TxtUsuario.Multiline = true;
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(272, 43);
            this.TxtUsuario.TabIndex = 15;
            // 
            // TxtClave
            // 
            this.TxtClave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(236)))), ((int)(((byte)(238)))));
            this.TxtClave.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtClave.ForeColor = System.Drawing.Color.Black;
            this.TxtClave.Location = new System.Drawing.Point(368, 310);
            this.TxtClave.Multiline = true;
            this.TxtClave.Name = "TxtClave";
            this.TxtClave.PasswordChar = '*';
            this.TxtClave.Size = new System.Drawing.Size(272, 43);
            this.TxtClave.TabIndex = 14;
            // 
            // BtnIngresar
            // 
            this.BtnIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(252)))), ((int)(((byte)(214)))));
            this.BtnIngresar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(196)))), ((int)(((byte)(188)))));
            this.BtnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnIngresar.Font = new System.Drawing.Font("Javanese Text", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIngresar.Location = new System.Drawing.Point(298, 434);
            this.BtnIngresar.Name = "BtnIngresar";
            this.BtnIngresar.Size = new System.Drawing.Size(203, 64);
            this.BtnIngresar.TabIndex = 12;
            this.BtnIngresar.Text = "Ingresar";
            this.BtnIngresar.UseVisualStyleBackColor = false;
            this.BtnIngresar.Click += new System.EventHandler(this.BtnIngresar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Javanese Text", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(180, 312);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 64);
            this.label3.TabIndex = 11;
            this.label3.Text = "Contraseña";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Javanese Text", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(224, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 64);
            this.label2.TabIndex = 10;
            this.label2.Text = "Usuario";
            // 
            // BtnNoVer
            // 
            this.BtnNoVer.BackgroundImage = global::LogClinic.Properties.Resources.Ver;
            this.BtnNoVer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnNoVer.Location = new System.Drawing.Point(707, 310);
            this.BtnNoVer.Name = "BtnNoVer";
            this.BtnNoVer.Size = new System.Drawing.Size(53, 56);
            this.BtnNoVer.TabIndex = 18;
            this.BtnNoVer.UseVisualStyleBackColor = true;
            this.BtnNoVer.Click += new System.EventHandler(this.BtnNoVer_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::LogClinic.Properties.Resources.UsuarioInicioSsesion;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(0, 157);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(185, 254);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // BtnVer
            // 
            this.BtnVer.BackgroundImage = global::LogClinic.Properties.Resources.BotonOcultarClave;
            this.BtnVer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnVer.Location = new System.Drawing.Point(707, 310);
            this.BtnVer.Name = "BtnVer";
            this.BtnVer.Size = new System.Drawing.Size(53, 56);
            this.BtnVer.TabIndex = 13;
            this.BtnVer.UseVisualStyleBackColor = true;
            this.BtnVer.Click += new System.EventHandler(this.BtnVer_Click);
            // 
            // FrmInicioSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(236)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(789, 534);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PAzul);
            this.Controls.Add(this.TxtUsuario);
            this.Controls.Add(this.TxtClave);
            this.Controls.Add(this.BtnVer);
            this.Controls.Add(this.BtnIngresar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnNoVer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmInicioSesion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "INICIAR SESION";
            this.PAzul.ResumeLayout(false);
            this.PAzul.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PAzul;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.TextBox TxtClave;
        private System.Windows.Forms.Button BtnVer;
        private System.Windows.Forms.Button BtnIngresar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnNoVer;
    }
}