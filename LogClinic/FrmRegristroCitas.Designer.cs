namespace LogClinic
{
    partial class FrmRegristroCitas
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtBuscarPaciente = new System.Windows.Forms.TextBox();
            this.CmbMedico = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LblPaciente = new System.Windows.Forms.Label();
            this.TxtEnfCronicas = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtAlergias = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtFechaNac = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtTipoSangre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtPaciente = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.DtpFechaProgramada = new System.Windows.Forms.DateTimePicker();
            this.DtpHoraProgramada = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.TxtMotivo = new System.Windows.Forms.TextBox();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.LblPersonal = new System.Windows.Forms.Label();
            this.CmbEstado = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "1. Datos del Paciente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(589, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(307, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "2. Detalles de la Cita";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(265, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Buscar Paciente (Ingrese la CURP)";
            // 
            // TxtBuscarPaciente
            // 
            this.TxtBuscarPaciente.Location = new System.Drawing.Point(21, 131);
            this.TxtBuscarPaciente.Name = "TxtBuscarPaciente";
            this.TxtBuscarPaciente.Size = new System.Drawing.Size(309, 26);
            this.TxtBuscarPaciente.TabIndex = 3;
            // 
            // CmbMedico
            // 
            this.CmbMedico.FormattingEnabled = true;
            this.CmbMedico.Location = new System.Drawing.Point(589, 125);
            this.CmbMedico.Name = "CmbMedico";
            this.CmbMedico.Size = new System.Drawing.Size(345, 28);
            this.CmbMedico.TabIndex = 4;
            this.CmbMedico.SelectedIndexChanged += new System.EventHandler(this.CmbMedico_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(585, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Medico Asignado";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LblPaciente);
            this.groupBox1.Controls.Add(this.TxtEnfCronicas);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.TxtAlergias);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.TxtFechaNac);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.TxtTipoSangre);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.TxtPaciente);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(21, 183);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(519, 328);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // LblPaciente
            // 
            this.LblPaciente.AutoSize = true;
            this.LblPaciente.Location = new System.Drawing.Point(488, 13);
            this.LblPaciente.Name = "LblPaciente";
            this.LblPaciente.Size = new System.Drawing.Size(25, 20);
            this.LblPaciente.TabIndex = 10;
            this.LblPaciente.Text = "Id";
            // 
            // TxtEnfCronicas
            // 
            this.TxtEnfCronicas.Location = new System.Drawing.Point(277, 230);
            this.TxtEnfCronicas.Multiline = true;
            this.TxtEnfCronicas.Name = "TxtEnfCronicas";
            this.TxtEnfCronicas.Size = new System.Drawing.Size(203, 77);
            this.TxtEnfCronicas.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(273, 197);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(191, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "Enfermedades Crónicas";
            // 
            // TxtAlergias
            // 
            this.TxtAlergias.Location = new System.Drawing.Point(24, 230);
            this.TxtAlergias.Multiline = true;
            this.TxtAlergias.Name = "TxtAlergias";
            this.TxtAlergias.Size = new System.Drawing.Size(203, 77);
            this.TxtAlergias.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 197);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 20);
            this.label8.TabIndex = 6;
            this.label8.Text = "Alergias";
            // 
            // TxtFechaNac
            // 
            this.TxtFechaNac.Location = new System.Drawing.Point(277, 144);
            this.TxtFechaNac.Name = "TxtFechaNac";
            this.TxtFechaNac.Size = new System.Drawing.Size(203, 26);
            this.TxtFechaNac.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(273, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(168, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "Fecha de nacimiento";
            // 
            // TxtTipoSangre
            // 
            this.TxtTipoSangre.Location = new System.Drawing.Point(24, 144);
            this.TxtTipoSangre.Name = "TxtTipoSangre";
            this.TxtTipoSangre.Size = new System.Drawing.Size(203, 26);
            this.TxtTipoSangre.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Tipo de sangre";
            // 
            // TxtPaciente
            // 
            this.TxtPaciente.Location = new System.Drawing.Point(24, 68);
            this.TxtPaciente.Name = "TxtPaciente";
            this.TxtPaciente.Size = new System.Drawing.Size(456, 26);
            this.TxtPaciente.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nombre Completo";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(591, 214);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(150, 20);
            this.label10.TabIndex = 7;
            this.label10.Text = "Fecha Programada";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(972, 214);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(142, 20);
            this.label11.TabIndex = 8;
            this.label11.Text = "Hora Programada";
            // 
            // DtpFechaProgramada
            // 
            this.DtpFechaProgramada.Location = new System.Drawing.Point(595, 250);
            this.DtpFechaProgramada.Name = "DtpFechaProgramada";
            this.DtpFechaProgramada.Size = new System.Drawing.Size(339, 26);
            this.DtpFechaProgramada.TabIndex = 9;
            // 
            // DtpHoraProgramada
            // 
            this.DtpHoraProgramada.Location = new System.Drawing.Point(969, 250);
            this.DtpHoraProgramada.Name = "DtpHoraProgramada";
            this.DtpHoraProgramada.Size = new System.Drawing.Size(279, 26);
            this.DtpHoraProgramada.TabIndex = 10;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(591, 312);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(141, 20);
            this.label12.TabIndex = 11;
            this.label12.Text = "Motivo de la Cita";
            // 
            // TxtMotivo
            // 
            this.TxtMotivo.Location = new System.Drawing.Point(596, 347);
            this.TxtMotivo.Multiline = true;
            this.TxtMotivo.Name = "TxtMotivo";
            this.TxtMotivo.Size = new System.Drawing.Size(626, 143);
            this.TxtMotivo.TabIndex = 12;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(363, 124);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(103, 41);
            this.BtnBuscar.TabIndex = 13;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(776, 535);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(106, 46);
            this.BtnCancelar.TabIndex = 14;
            this.BtnCancelar.Text = "CANCELAR";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Location = new System.Drawing.Point(1032, 535);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(107, 46);
            this.BtnGuardar.TabIndex = 15;
            this.BtnGuardar.Text = "GUARDAR";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // LblPersonal
            // 
            this.LblPersonal.AutoSize = true;
            this.LblPersonal.Location = new System.Drawing.Point(972, 128);
            this.LblPersonal.Name = "LblPersonal";
            this.LblPersonal.Size = new System.Drawing.Size(25, 20);
            this.LblPersonal.TabIndex = 11;
            this.LblPersonal.Text = "Id";
            // 
            // CmbEstado
            // 
            this.CmbEstado.FormattingEnabled = true;
            this.CmbEstado.Items.AddRange(new object[] {
            "Programada",
            "Atendida",
            "Cancelada",
            "No_asistio"});
            this.CmbEstado.Location = new System.Drawing.Point(1018, 124);
            this.CmbEstado.Name = "CmbEstado";
            this.CmbEstado.Size = new System.Drawing.Size(121, 28);
            this.CmbEstado.TabIndex = 16;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1014, 89);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(140, 20);
            this.label13.TabIndex = 17;
            this.label13.Text = "Estado de la cita";
            // 
            // FrmRegristroCitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1260, 620);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.CmbEstado);
            this.Controls.Add(this.LblPersonal);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.TxtMotivo);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.DtpHoraProgramada);
            this.Controls.Add(this.DtpFechaProgramada);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CmbMedico);
            this.Controls.Add(this.TxtBuscarPaciente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmRegristroCitas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmRegristroCitas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtBuscarPaciente;
        private System.Windows.Forms.ComboBox CmbMedico;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtTipoSangre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtPaciente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtEnfCronicas;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtAlergias;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtFechaNac;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker DtpFechaProgramada;
        private System.Windows.Forms.DateTimePicker DtpHoraProgramada;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TxtMotivo;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Label LblPaciente;
        private System.Windows.Forms.Label LblPersonal;
        private System.Windows.Forms.ComboBox CmbEstado;
        private System.Windows.Forms.Label label13;
    }
}