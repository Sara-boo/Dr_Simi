namespace LogClinic
{
    partial class FrmPaginaPrincipal
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
            this.tsPrincipal = new System.Windows.Forms.ToolStrip();
            this.pSuperior = new System.Windows.Forms.Panel();
            this.LblUsuarioActivo = new System.Windows.Forms.Label();
            this.tsInicio = new System.Windows.Forms.ToolStripButton();
            this.tsbPacientes = new System.Windows.Forms.ToolStripButton();
            this.tsbCitas = new System.Windows.Forms.ToolStripButton();
            this.tsbUsuario = new System.Windows.Forms.ToolStripButton();
            this.tsbPersonal = new System.Windows.Forms.ToolStripButton();
            this.tsbHistorial = new System.Windows.Forms.ToolStripButton();
            this.tsbInventario = new System.Windows.Forms.ToolStripButton();
            this.tsbVacunas = new System.Windows.Forms.ToolStripButton();
            this.tsbSalir = new System.Windows.Forms.ToolStripButton();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.BtnOcultarVentana = new System.Windows.Forms.Button();
            this.pbUsuario = new System.Windows.Forms.PictureBox();
            this.LblModulo = new System.Windows.Forms.Label();
            this.tsPrincipal.SuspendLayout();
            this.pSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // tsPrincipal
            // 
            this.tsPrincipal.AutoSize = false;
            this.tsPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(93)))), ((int)(((byte)(126)))));
            this.tsPrincipal.Dock = System.Windows.Forms.DockStyle.Left;
            this.tsPrincipal.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsPrincipal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tsPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsInicio,
            this.tsbPacientes,
            this.tsbCitas,
            this.tsbUsuario,
            this.tsbPersonal,
            this.tsbHistorial,
            this.tsbInventario,
            this.tsbVacunas,
            this.tsbSalir});
            this.tsPrincipal.Location = new System.Drawing.Point(0, 81);
            this.tsPrincipal.Name = "tsPrincipal";
            this.tsPrincipal.Padding = new System.Windows.Forms.Padding(0);
            this.tsPrincipal.Size = new System.Drawing.Size(85, 674);
            this.tsPrincipal.TabIndex = 9;
            this.tsPrincipal.Text = "MENU";
            this.tsPrincipal.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.tsPrincipal_ItemClicked);
            // 
            // pSuperior
            // 
            this.pSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(93)))), ((int)(((byte)(126)))));
            this.pSuperior.Controls.Add(this.LblModulo);
            this.pSuperior.Controls.Add(this.BtnCerrar);
            this.pSuperior.Controls.Add(this.BtnOcultarVentana);
            this.pSuperior.Controls.Add(this.LblUsuarioActivo);
            this.pSuperior.Controls.Add(this.pbUsuario);
            this.pSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pSuperior.Location = new System.Drawing.Point(0, 0);
            this.pSuperior.Margin = new System.Windows.Forms.Padding(2);
            this.pSuperior.Name = "pSuperior";
            this.pSuperior.Size = new System.Drawing.Size(1443, 81);
            this.pSuperior.TabIndex = 10;
            // 
            // LblUsuarioActivo
            // 
            this.LblUsuarioActivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblUsuarioActivo.AutoSize = true;
            this.LblUsuarioActivo.Font = new System.Drawing.Font("Lucida Bright", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsuarioActivo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.LblUsuarioActivo.Location = new System.Drawing.Point(1026, 28);
            this.LblUsuarioActivo.Name = "LblUsuarioActivo";
            this.LblUsuarioActivo.Size = new System.Drawing.Size(99, 24);
            this.LblUsuarioActivo.TabIndex = 3;
            this.LblUsuarioActivo.Text = "Usuario.";
            // 
            // tsInicio
            // 
            this.tsInicio.AutoSize = false;
            this.tsInicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tsInicio.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsInicio.Image = global::LogClinic.Properties.Resources.Casa;
            this.tsInicio.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsInicio.Name = "tsInicio";
            this.tsInicio.Size = new System.Drawing.Size(95, 70);
            this.tsInicio.Text = "INICIO";
            this.tsInicio.Click += new System.EventHandler(this.tsInicio_Click);
            // 
            // tsbPacientes
            // 
            this.tsbPacientes.AutoSize = false;
            this.tsbPacientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tsbPacientes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbPacientes.Image = global::LogClinic.Properties.Resources.pacientes_2;
            this.tsbPacientes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPacientes.Name = "tsbPacientes";
            this.tsbPacientes.Size = new System.Drawing.Size(95, 70);
            this.tsbPacientes.Text = "PACIENTES";
            this.tsbPacientes.ToolTipText = "PACIENTES";
            this.tsbPacientes.Click += new System.EventHandler(this.tsbPacientes_Click_1);
            // 
            // tsbCitas
            // 
            this.tsbCitas.AutoSize = false;
            this.tsbCitas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tsbCitas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCitas.Image = global::LogClinic.Properties.Resources.Citas;
            this.tsbCitas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCitas.Name = "tsbCitas";
            this.tsbCitas.Size = new System.Drawing.Size(95, 70);
            this.tsbCitas.Text = "CITAS";
            this.tsbCitas.ToolTipText = "CITAS";
            this.tsbCitas.Click += new System.EventHandler(this.tsbCitas_Click);
            // 
            // tsbUsuario
            // 
            this.tsbUsuario.AutoSize = false;
            this.tsbUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tsbUsuario.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbUsuario.Image = global::LogClinic.Properties.Resources.Usuarios;
            this.tsbUsuario.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbUsuario.Name = "tsbUsuario";
            this.tsbUsuario.Size = new System.Drawing.Size(95, 70);
            this.tsbUsuario.Text = "USUARIOS";
            this.tsbUsuario.Click += new System.EventHandler(this.tsbUsuario_Click);
            // 
            // tsbPersonal
            // 
            this.tsbPersonal.AutoSize = false;
            this.tsbPersonal.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbPersonal.Image = global::LogClinic.Properties.Resources.Personal;
            this.tsbPersonal.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPersonal.Name = "tsbPersonal";
            this.tsbPersonal.Size = new System.Drawing.Size(95, 70);
            this.tsbPersonal.Text = "PERSONAL";
            this.tsbPersonal.Click += new System.EventHandler(this.tsbPersonal_Click);
            // 
            // tsbHistorial
            // 
            this.tsbHistorial.AutoSize = false;
            this.tsbHistorial.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbHistorial.Image = global::LogClinic.Properties.Resources.Historial;
            this.tsbHistorial.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbHistorial.Name = "tsbHistorial";
            this.tsbHistorial.Size = new System.Drawing.Size(95, 70);
            this.tsbHistorial.Text = "HISTORIAL CLINICO";
            this.tsbHistorial.Click += new System.EventHandler(this.tsbHistorial_Click);
            // 
            // tsbInventario
            // 
            this.tsbInventario.AutoSize = false;
            this.tsbInventario.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbInventario.Image = global::LogClinic.Properties.Resources.Inventario;
            this.tsbInventario.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbInventario.Name = "tsbInventario";
            this.tsbInventario.Size = new System.Drawing.Size(85, 60);
            this.tsbInventario.Text = "INVENTARIO";
            this.tsbInventario.Click += new System.EventHandler(this.tsbInventario_Click);
            // 
            // tsbVacunas
            // 
            this.tsbVacunas.AutoSize = false;
            this.tsbVacunas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbVacunas.Image = global::LogClinic.Properties.Resources.Vacunas;
            this.tsbVacunas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbVacunas.Name = "tsbVacunas";
            this.tsbVacunas.Size = new System.Drawing.Size(85, 60);
            this.tsbVacunas.Text = "VACUNAS";
            this.tsbVacunas.Click += new System.EventHandler(this.tsbVacunas_Click);
            // 
            // tsbSalir
            // 
            this.tsbSalir.AutoSize = false;
            this.tsbSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSalir.Image = global::LogClinic.Properties.Resources.Salir;
            this.tsbSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSalir.Name = "tsbSalir";
            this.tsbSalir.Size = new System.Drawing.Size(85, 60);
            this.tsbSalir.Text = "CERRAR SESION";
            this.tsbSalir.Click += new System.EventHandler(this.tsbSalir_Click_1);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCerrar.BackgroundImage = global::LogClinic.Properties.Resources.Cerrar1;
            this.BtnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnCerrar.Location = new System.Drawing.Point(1372, 22);
            this.BtnCerrar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(35, 37);
            this.BtnCerrar.TabIndex = 7;
            this.BtnCerrar.UseVisualStyleBackColor = true;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // BtnOcultarVentana
            // 
            this.BtnOcultarVentana.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnOcultarVentana.BackgroundImage = global::LogClinic.Properties.Resources.MiniminarVentana;
            this.BtnOcultarVentana.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnOcultarVentana.Location = new System.Drawing.Point(1312, 22);
            this.BtnOcultarVentana.Margin = new System.Windows.Forms.Padding(2);
            this.BtnOcultarVentana.Name = "BtnOcultarVentana";
            this.BtnOcultarVentana.Size = new System.Drawing.Size(35, 37);
            this.BtnOcultarVentana.TabIndex = 6;
            this.BtnOcultarVentana.UseVisualStyleBackColor = true;
            this.BtnOcultarVentana.Click += new System.EventHandler(this.BtnOcultarVentana_Click);
            // 
            // pbUsuario
            // 
            this.pbUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbUsuario.BackgroundImage = global::LogClinic.Properties.Resources.IconoUsuario;
            this.pbUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbUsuario.Location = new System.Drawing.Point(1256, 22);
            this.pbUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.pbUsuario.Name = "pbUsuario";
            this.pbUsuario.Size = new System.Drawing.Size(35, 37);
            this.pbUsuario.TabIndex = 5;
            this.pbUsuario.TabStop = false;
            // 
            // LblModulo
            // 
            this.LblModulo.AutoSize = true;
            this.LblModulo.Font = new System.Drawing.Font("Lucida Bright", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblModulo.ForeColor = System.Drawing.Color.White;
            this.LblModulo.Location = new System.Drawing.Point(94, 22);
            this.LblModulo.Name = "LblModulo";
            this.LblModulo.Size = new System.Drawing.Size(151, 40);
            this.LblModulo.TabIndex = 8;
            this.LblModulo.Text = "Modulo";
            // 
            // FrmPaginaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(236)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(1443, 755);
            this.Controls.Add(this.tsPrincipal);
            this.Controls.Add(this.pSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmPaginaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "INICIO DE SESION";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPaginaPrincipal_Load);
            this.tsPrincipal.ResumeLayout(false);
            this.tsPrincipal.PerformLayout();
            this.pSuperior.ResumeLayout(false);
            this.pSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsPrincipal;
        private System.Windows.Forms.ToolStripButton tsInicio;
        private System.Windows.Forms.ToolStripButton tsbCitas;
        private System.Windows.Forms.ToolStripButton tsbUsuario;
        private System.Windows.Forms.ToolStripButton tsbPersonal;
        private System.Windows.Forms.ToolStripButton tsbHistorial;
        private System.Windows.Forms.ToolStripButton tsbInventario;
        private System.Windows.Forms.ToolStripButton tsbVacunas;
        private System.Windows.Forms.ToolStripButton tsbSalir;
        private System.Windows.Forms.Panel pSuperior;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Button BtnOcultarVentana;
        private System.Windows.Forms.Label LblUsuarioActivo;
        private System.Windows.Forms.PictureBox pbUsuario;
        private System.Windows.Forms.ToolStripButton tsbPacientes;
        private System.Windows.Forms.Label LblModulo;
    }
}