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
            this.tsInicio = new System.Windows.Forms.ToolStripButton();
            this.tsbCitas = new System.Windows.Forms.ToolStripButton();
            this.tsbUsuario = new System.Windows.Forms.ToolStripButton();
            this.tsbPersonal = new System.Windows.Forms.ToolStripButton();
            this.tsbPacientes = new System.Windows.Forms.ToolStripButton();
            this.tsbHistorial = new System.Windows.Forms.ToolStripButton();
            this.tsbSalir = new System.Windows.Forms.ToolStripButton();
            this.tsbReportes = new System.Windows.Forms.ToolStripButton();
            this.tsbRolesPermisos = new System.Windows.Forms.ToolStripButton();
            this.tsbUsuarios = new System.Windows.Forms.ToolStripButton();
            this.tsbCerrarSesion = new System.Windows.Forms.ToolStripButton();
            this.pSuperior = new System.Windows.Forms.Panel();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.BtnOcultarVentana = new System.Windows.Forms.Button();
            this.LblUsuarioActivo = new System.Windows.Forms.Label();
            this.pbUsuario = new System.Windows.Forms.PictureBox();
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
            this.tsbCitas,
            this.tsbUsuario,
            this.tsbPersonal,
            this.tsbPacientes,
            this.tsbHistorial,
            this.tsbSalir,
            this.tsbReportes,
            this.tsbRolesPermisos,
            this.tsbUsuarios,
            this.tsbCerrarSesion});
            this.tsPrincipal.Location = new System.Drawing.Point(0, 100);
            this.tsPrincipal.Name = "tsPrincipal";
            this.tsPrincipal.Padding = new System.Windows.Forms.Padding(0);
            this.tsPrincipal.Size = new System.Drawing.Size(113, 829);
            this.tsPrincipal.TabIndex = 9;
            this.tsPrincipal.Text = "MENU";
            this.tsPrincipal.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.tsPrincipal_ItemClicked);
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
            this.tsbUsuario.Text = "CATEGORÍAS";
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
            this.tsbPersonal.Text = "ALERTAS";
            this.tsbPersonal.Click += new System.EventHandler(this.tsbPersonal_Click);
            // 
            // tsbPacientes
            // 
            this.tsbPacientes.AutoSize = false;
            this.tsbPacientes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbPacientes.Image = global::LogClinic.Properties.Resources.Pacientes;
            this.tsbPacientes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPacientes.Name = "tsbPacientes";
            this.tsbPacientes.Size = new System.Drawing.Size(95, 70);
            this.tsbPacientes.Text = "PRODUCTOS";
            this.tsbPacientes.Click += new System.EventHandler(this.tsbPacientes_Click);
            // 
            // tsbHistorial
            // 
            this.tsbHistorial.AutoSize = false;
            this.tsbHistorial.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbHistorial.Image = global::LogClinic.Properties.Resources.Historial;
            this.tsbHistorial.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbHistorial.Name = "tsbHistorial";
            this.tsbHistorial.Size = new System.Drawing.Size(95, 70);
            this.tsbHistorial.Text = "ENTRADAS";
            this.tsbHistorial.Click += new System.EventHandler(this.tsbHistorial_Click);
            // 
            // tsbSalir
            // 
            this.tsbSalir.AutoSize = false;
            this.tsbSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSalir.Image = global::LogClinic.Properties.Resources.Salir;
            this.tsbSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSalir.Name = "tsbSalir";
            this.tsbSalir.Size = new System.Drawing.Size(85, 60);
            this.tsbSalir.Text = "SALIDAS";
            // 
            // tsbReportes
            // 
            this.tsbReportes.AutoSize = false;
            this.tsbReportes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbReportes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbReportes.Name = "tsbReportes";
            this.tsbReportes.Size = new System.Drawing.Size(85, 60);
            this.tsbReportes.Text = "REPORTES";
            // 
            // tsbRolesPermisos
            // 
            this.tsbRolesPermisos.AutoSize = false;
            this.tsbRolesPermisos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbRolesPermisos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRolesPermisos.Name = "tsbRolesPermisos";
            this.tsbRolesPermisos.Size = new System.Drawing.Size(85, 60);
            this.tsbRolesPermisos.Text = "ROLES Y PERMISOS";
            // 
            // tsbUsuarios
            // 
            this.tsbUsuarios.AutoSize = false;
            this.tsbUsuarios.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbUsuarios.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbUsuarios.Name = "tsbUsuarios";
            this.tsbUsuarios.Size = new System.Drawing.Size(85, 60);
            this.tsbUsuarios.Text = "USUARIOS";
            // 
            // tsbCerrarSesion
            // 
            this.tsbCerrarSesion.AutoSize = false;
            this.tsbCerrarSesion.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCerrarSesion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCerrarSesion.Name = "tsbCerrarSesion";
            this.tsbCerrarSesion.Size = new System.Drawing.Size(85, 60);
            this.tsbCerrarSesion.Text = "CERRAR SESION";
            // 
            // pSuperior
            // 
            this.pSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(93)))), ((int)(((byte)(126)))));
            this.pSuperior.Controls.Add(this.BtnCerrar);
            this.pSuperior.Controls.Add(this.BtnOcultarVentana);
            this.pSuperior.Controls.Add(this.LblUsuarioActivo);
            this.pSuperior.Controls.Add(this.pbUsuario);
            this.pSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pSuperior.Location = new System.Drawing.Point(0, 0);
            this.pSuperior.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pSuperior.Name = "pSuperior";
            this.pSuperior.Size = new System.Drawing.Size(1924, 100);
            this.pSuperior.TabIndex = 10;
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCerrar.BackgroundImage = global::LogClinic.Properties.Resources.Cerrar1;
            this.BtnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnCerrar.Location = new System.Drawing.Point(1829, 27);
            this.BtnCerrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(47, 46);
            this.BtnCerrar.TabIndex = 7;
            this.BtnCerrar.UseVisualStyleBackColor = true;
            // 
            // BtnOcultarVentana
            // 
            this.BtnOcultarVentana.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnOcultarVentana.BackgroundImage = global::LogClinic.Properties.Resources.MiniminarVentana;
            this.BtnOcultarVentana.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnOcultarVentana.Location = new System.Drawing.Point(1749, 27);
            this.BtnOcultarVentana.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnOcultarVentana.Name = "BtnOcultarVentana";
            this.BtnOcultarVentana.Size = new System.Drawing.Size(47, 46);
            this.BtnOcultarVentana.TabIndex = 6;
            this.BtnOcultarVentana.UseVisualStyleBackColor = true;
            // 
            // LblUsuarioActivo
            // 
            this.LblUsuarioActivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblUsuarioActivo.AutoSize = true;
            this.LblUsuarioActivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsuarioActivo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.LblUsuarioActivo.Location = new System.Drawing.Point(1368, 34);
            this.LblUsuarioActivo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblUsuarioActivo.Name = "LblUsuarioActivo";
            this.LblUsuarioActivo.Size = new System.Drawing.Size(84, 25);
            this.LblUsuarioActivo.TabIndex = 3;
            this.LblUsuarioActivo.Text = "Usuario.";
            // 
            // pbUsuario
            // 
            this.pbUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbUsuario.BackgroundImage = global::LogClinic.Properties.Resources.IconoUsuario;
            this.pbUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbUsuario.Location = new System.Drawing.Point(1675, 27);
            this.pbUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbUsuario.Name = "pbUsuario";
            this.pbUsuario.Size = new System.Drawing.Size(47, 46);
            this.pbUsuario.TabIndex = 5;
            this.pbUsuario.TabStop = false;
            // 
            // FrmPaginaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(236)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(1924, 929);
            this.Controls.Add(this.tsPrincipal);
            this.Controls.Add(this.pSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmPaginaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "INICIO DE SESION";
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
        private System.Windows.Forms.ToolStripButton tsbPacientes;
        private System.Windows.Forms.ToolStripButton tsbHistorial;
        private System.Windows.Forms.ToolStripButton tsbSalir;
        private System.Windows.Forms.ToolStripButton tsbReportes;
        private System.Windows.Forms.ToolStripButton tsbRolesPermisos;
        private System.Windows.Forms.ToolStripButton tsbUsuarios;
        private System.Windows.Forms.ToolStripButton tsbCerrarSesion;
        private System.Windows.Forms.Panel pSuperior;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Button BtnOcultarVentana;
        private System.Windows.Forms.Label LblUsuarioActivo;
        private System.Windows.Forms.PictureBox pbUsuario;
    }
}