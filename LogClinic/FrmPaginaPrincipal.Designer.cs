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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPaginaPrincipal));
            this.tsPrincipal = new System.Windows.Forms.ToolStrip();
            this.tsInicio = new System.Windows.Forms.ToolStripButton();
            this.tsbPacientes = new System.Windows.Forms.ToolStripButton();
            this.tsbCitas = new System.Windows.Forms.ToolStripButton();
            this.tsbUsuario = new System.Windows.Forms.ToolStripButton();
            this.tsbPersonal = new System.Windows.Forms.ToolStripButton();
            this.tsbHistorial = new System.Windows.Forms.ToolStripButton();
            this.tsbInventario = new System.Windows.Forms.ToolStripButton();
            this.tsbVacunas = new System.Windows.Forms.ToolStripButton();
            this.tsbSalir = new System.Windows.Forms.ToolStripButton();
            this.pSuperior = new System.Windows.Forms.Panel();
            this.LblModulo = new System.Windows.Forms.Label();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.BtnOcultarVentana = new System.Windows.Forms.Button();
            this.LblUsuarioActivo = new System.Windows.Forms.Label();
            this.pbUsuario = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PanelCitasHoy = new System.Windows.Forms.Panel();
            this.PanelStockC = new System.Windows.Forms.Panel();
            this.PanelPacientesActivos = new System.Windows.Forms.Panel();
            this.PanelVacunas = new System.Windows.Forms.Panel();
            this.PanelProximasCitas = new System.Windows.Forms.Panel();
            this.PanelAccesoDirecto = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LblCitasHoy = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.LblStock = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.tsPrincipal.SuspendLayout();
            this.pSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsuario)).BeginInit();
            this.PanelCitasHoy.SuspendLayout();
            this.PanelStockC.SuspendLayout();
            this.PanelPacientesActivos.SuspendLayout();
            this.PanelProximasCitas.SuspendLayout();
            this.PanelAccesoDirecto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
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
            this.tsPrincipal.Size = new System.Drawing.Size(85, 888);
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
            this.pSuperior.Size = new System.Drawing.Size(1656, 81);
            this.pSuperior.TabIndex = 10;
            // 
            // LblModulo
            // 
            this.LblModulo.AutoSize = true;
            this.LblModulo.Font = new System.Drawing.Font("Lucida Bright", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblModulo.ForeColor = System.Drawing.Color.White;
            this.LblModulo.Location = new System.Drawing.Point(94, 22);
            this.LblModulo.Name = "LblModulo";
            this.LblModulo.Size = new System.Drawing.Size(116, 40);
            this.LblModulo.TabIndex = 8;
            this.LblModulo.Text = "Inicio";
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCerrar.BackgroundImage = global::LogClinic.Properties.Resources.Cerrar1;
            this.BtnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnCerrar.Location = new System.Drawing.Point(1585, 22);
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
            this.BtnOcultarVentana.Location = new System.Drawing.Point(1525, 22);
            this.BtnOcultarVentana.Margin = new System.Windows.Forms.Padding(2);
            this.BtnOcultarVentana.Name = "BtnOcultarVentana";
            this.BtnOcultarVentana.Size = new System.Drawing.Size(35, 37);
            this.BtnOcultarVentana.TabIndex = 6;
            this.BtnOcultarVentana.UseVisualStyleBackColor = true;
            this.BtnOcultarVentana.Click += new System.EventHandler(this.BtnOcultarVentana_Click);
            // 
            // LblUsuarioActivo
            // 
            this.LblUsuarioActivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblUsuarioActivo.AutoSize = true;
            this.LblUsuarioActivo.Font = new System.Drawing.Font("Lucida Bright", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsuarioActivo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.LblUsuarioActivo.Location = new System.Drawing.Point(1239, 28);
            this.LblUsuarioActivo.Name = "LblUsuarioActivo";
            this.LblUsuarioActivo.Size = new System.Drawing.Size(99, 24);
            this.LblUsuarioActivo.TabIndex = 3;
            this.LblUsuarioActivo.Text = "Usuario.";
            // 
            // pbUsuario
            // 
            this.pbUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbUsuario.BackgroundImage = global::LogClinic.Properties.Resources.IconoUsuario;
            this.pbUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbUsuario.Location = new System.Drawing.Point(1469, 22);
            this.pbUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.pbUsuario.Name = "pbUsuario";
            this.pbUsuario.Size = new System.Drawing.Size(35, 37);
            this.pbUsuario.TabIndex = 5;
            this.pbUsuario.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(93)))), ((int)(((byte)(126)))));
            this.label1.Location = new System.Drawing.Point(153, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 42);
            this.label1.TabIndex = 12;
            this.label1.Text = "Resumen del Día";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(186, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(297, 22);
            this.label2.TabIndex = 13;
            this.label2.Text = "Domingo, 10 de mayo de 2026";
            // 
            // PanelCitasHoy
            // 
            this.PanelCitasHoy.BackColor = System.Drawing.Color.White;
            this.PanelCitasHoy.Controls.Add(this.pictureBox2);
            this.PanelCitasHoy.Controls.Add(this.LblCitasHoy);
            this.PanelCitasHoy.Controls.Add(this.label3);
            this.PanelCitasHoy.Font = new System.Drawing.Font("Lucida Bright", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelCitasHoy.ForeColor = System.Drawing.Color.DimGray;
            this.PanelCitasHoy.Location = new System.Drawing.Point(149, 244);
            this.PanelCitasHoy.Name = "PanelCitasHoy";
            this.PanelCitasHoy.Size = new System.Drawing.Size(375, 197);
            this.PanelCitasHoy.TabIndex = 14;
            // 
            // PanelStockC
            // 
            this.PanelStockC.BackColor = System.Drawing.Color.White;
            this.PanelStockC.Controls.Add(this.pictureBox3);
            this.PanelStockC.Controls.Add(this.LblStock);
            this.PanelStockC.Controls.Add(this.label5);
            this.PanelStockC.Font = new System.Drawing.Font("Lucida Bright", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelStockC.ForeColor = System.Drawing.Color.DimGray;
            this.PanelStockC.Location = new System.Drawing.Point(610, 244);
            this.PanelStockC.Name = "PanelStockC";
            this.PanelStockC.Size = new System.Drawing.Size(388, 197);
            this.PanelStockC.TabIndex = 15;
            // 
            // PanelPacientesActivos
            // 
            this.PanelPacientesActivos.BackColor = System.Drawing.Color.White;
            this.PanelPacientesActivos.Controls.Add(this.pictureBox4);
            this.PanelPacientesActivos.Controls.Add(this.label4);
            this.PanelPacientesActivos.Controls.Add(this.label6);
            this.PanelPacientesActivos.Font = new System.Drawing.Font("Lucida Bright", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelPacientesActivos.ForeColor = System.Drawing.Color.DimGray;
            this.PanelPacientesActivos.Location = new System.Drawing.Point(1085, 244);
            this.PanelPacientesActivos.Name = "PanelPacientesActivos";
            this.PanelPacientesActivos.Size = new System.Drawing.Size(387, 197);
            this.PanelPacientesActivos.TabIndex = 16;
            // 
            // PanelVacunas
            // 
            this.PanelVacunas.BackColor = System.Drawing.Color.White;
            this.PanelVacunas.Font = new System.Drawing.Font("Lucida Bright", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelVacunas.ForeColor = System.Drawing.Color.DimGray;
            this.PanelVacunas.Location = new System.Drawing.Point(1544, 244);
            this.PanelVacunas.Name = "PanelVacunas";
            this.PanelVacunas.Size = new System.Drawing.Size(320, 197);
            this.PanelVacunas.TabIndex = 17;
            // 
            // PanelProximasCitas
            // 
            this.PanelProximasCitas.BackColor = System.Drawing.Color.White;
            this.PanelProximasCitas.Controls.Add(this.pictureBox5);
            this.PanelProximasCitas.Controls.Add(this.dataGridView1);
            this.PanelProximasCitas.Controls.Add(this.label8);
            this.PanelProximasCitas.Controls.Add(this.label7);
            this.PanelProximasCitas.Font = new System.Drawing.Font("Lucida Bright", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelProximasCitas.ForeColor = System.Drawing.Color.DimGray;
            this.PanelProximasCitas.Location = new System.Drawing.Point(149, 504);
            this.PanelProximasCitas.Name = "PanelProximasCitas";
            this.PanelProximasCitas.Size = new System.Drawing.Size(958, 480);
            this.PanelProximasCitas.TabIndex = 18;
            // 
            // PanelAccesoDirecto
            // 
            this.PanelAccesoDirecto.BackColor = System.Drawing.Color.White;
            this.PanelAccesoDirecto.Controls.Add(this.pictureBox6);
            this.PanelAccesoDirecto.Controls.Add(this.label9);
            this.PanelAccesoDirecto.Font = new System.Drawing.Font("Lucida Bright", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelAccesoDirecto.ForeColor = System.Drawing.Color.DimGray;
            this.PanelAccesoDirecto.Location = new System.Drawing.Point(1253, 504);
            this.PanelAccesoDirecto.Name = "PanelAccesoDirecto";
            this.PanelAccesoDirecto.Size = new System.Drawing.Size(598, 480);
            this.PanelAccesoDirecto.TabIndex = 19;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(149, 178);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 33);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Bright", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(153, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = "Citas de Hoy";
            // 
            // LblCitasHoy
            // 
            this.LblCitasHoy.AutoSize = true;
            this.LblCitasHoy.Font = new System.Drawing.Font("Lucida Bright", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCitasHoy.ForeColor = System.Drawing.Color.Black;
            this.LblCitasHoy.Location = new System.Drawing.Point(211, 93);
            this.LblCitasHoy.Name = "LblCitasHoy";
            this.LblCitasHoy.Size = new System.Drawing.Size(61, 40);
            this.LblCitasHoy.TabIndex = 1;
            this.LblCitasHoy.Text = "12";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(41, 38);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(104, 106);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(37, 38);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(106, 106);
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // LblStock
            // 
            this.LblStock.AutoSize = true;
            this.LblStock.Font = new System.Drawing.Font("Lucida Bright", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblStock.ForeColor = System.Drawing.Color.Black;
            this.LblStock.Location = new System.Drawing.Point(229, 93);
            this.LblStock.Name = "LblStock";
            this.LblStock.Size = new System.Drawing.Size(61, 40);
            this.LblStock.TabIndex = 4;
            this.LblStock.Text = "12";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Bright", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(170, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(191, 32);
            this.label5.TabIndex = 3;
            this.label5.Text = "Stock Crítico ";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(34, 27);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(106, 106);
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Bright", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(232, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 40);
            this.label4.TabIndex = 4;
            this.label4.Text = "12";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Bright", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(146, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(242, 32);
            this.label6.TabIndex = 3;
            this.label6.Text = "Pacientes Activos";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Bright", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(93)))), ((int)(((byte)(126)))));
            this.label7.Location = new System.Drawing.Point(77, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(191, 27);
            this.label7.TabIndex = 0;
            this.label7.Text = "Próximas Citas";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(93)))), ((int)(((byte)(126)))));
            this.label8.Location = new System.Drawing.Point(615, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(313, 15);
            this.label8.TabIndex = 1;
            this.label8.Text = "Control de navegación de citas programadas";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(955, 402);
            this.dataGridView1.TabIndex = 2;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Location = new System.Drawing.Point(15, 5);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(56, 52);
            this.pictureBox5.TabIndex = 3;
            this.pictureBox5.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lucida Bright", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(93)))), ((int)(((byte)(126)))));
            this.label9.Location = new System.Drawing.Point(80, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(214, 27);
            this.label9.TabIndex = 0;
            this.label9.Text = "Accesos Rápidos";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Location = new System.Drawing.Point(18, 5);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(56, 56);
            this.pictureBox6.TabIndex = 1;
            this.pictureBox6.TabStop = false;
            // 
            // FrmPaginaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(236)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(1656, 969);
            this.Controls.Add(this.PanelCitasHoy);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PanelAccesoDirecto);
            this.Controls.Add(this.PanelProximasCitas);
            this.Controls.Add(this.PanelVacunas);
            this.Controls.Add(this.PanelPacientesActivos);
            this.Controls.Add(this.PanelStockC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
            this.PanelCitasHoy.ResumeLayout(false);
            this.PanelCitasHoy.PerformLayout();
            this.PanelStockC.ResumeLayout(false);
            this.PanelStockC.PerformLayout();
            this.PanelPacientesActivos.ResumeLayout(false);
            this.PanelPacientesActivos.PerformLayout();
            this.PanelProximasCitas.ResumeLayout(false);
            this.PanelProximasCitas.PerformLayout();
            this.PanelAccesoDirecto.ResumeLayout(false);
            this.PanelAccesoDirecto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel PanelCitasHoy;
        private System.Windows.Forms.Panel PanelStockC;
        private System.Windows.Forms.Panel PanelPacientesActivos;
        private System.Windows.Forms.Panel PanelVacunas;
        private System.Windows.Forms.Panel PanelProximasCitas;
        private System.Windows.Forms.Panel PanelAccesoDirecto;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label LblCitasHoy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label LblStock;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label9;
    }
}