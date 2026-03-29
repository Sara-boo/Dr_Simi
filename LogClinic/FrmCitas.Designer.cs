namespace LogClinic
{
    partial class FrmCitas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BtnNuevaCita = new System.Windows.Forms.Button();
            this.BtnFiltrar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnCsv = new System.Windows.Forms.Button();
            this.TxtPaciente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DtpDesdeFecha = new System.Windows.Forms.DateTimePicker();
            this.DtpHastaFecha = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.CmbEstado = new System.Windows.Forms.ComboBox();
            this.DtgDatos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DtgDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnNuevaCita
            // 
            this.BtnNuevaCita.Location = new System.Drawing.Point(709, 22);
            this.BtnNuevaCita.Margin = new System.Windows.Forms.Padding(4);
            this.BtnNuevaCita.Name = "BtnNuevaCita";
            this.BtnNuevaCita.Size = new System.Drawing.Size(138, 42);
            this.BtnNuevaCita.TabIndex = 0;
            this.BtnNuevaCita.Text = "+ Nueva Cita";
            this.BtnNuevaCita.UseVisualStyleBackColor = true;
            this.BtnNuevaCita.Click += new System.EventHandler(this.BtnNuevaCita_Click);
            // 
            // BtnFiltrar
            // 
            this.BtnFiltrar.Location = new System.Drawing.Point(861, 22);
            this.BtnFiltrar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnFiltrar.Name = "BtnFiltrar";
            this.BtnFiltrar.Size = new System.Drawing.Size(138, 42);
            this.BtnFiltrar.TabIndex = 1;
            this.BtnFiltrar.Text = "Filtrar";
            this.BtnFiltrar.UseVisualStyleBackColor = true;
            this.BtnFiltrar.Click += new System.EventHandler(this.BtnFiltrar_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1760, 41);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 30);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(25, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar Paciente (CURP o Nombre)";
            // 
            // BtnCsv
            // 
            this.BtnCsv.Location = new System.Drawing.Point(1020, 22);
            this.BtnCsv.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCsv.Name = "BtnCsv";
            this.BtnCsv.Size = new System.Drawing.Size(138, 42);
            this.BtnCsv.TabIndex = 4;
            this.BtnCsv.Text = "CSV";
            this.BtnCsv.UseVisualStyleBackColor = true;
            this.BtnCsv.Click += new System.EventHandler(this.BtnCsv_Click);
            // 
            // TxtPaciente
            // 
            this.TxtPaciente.Location = new System.Drawing.Point(29, 98);
            this.TxtPaciente.Name = "TxtPaciente";
            this.TxtPaciente.Size = new System.Drawing.Size(269, 25);
            this.TxtPaciente.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(319, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Desde la Fecha";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(659, 82);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Hasta la Fecha";
            // 
            // DtpDesdeFecha
            // 
            this.DtpDesdeFecha.Location = new System.Drawing.Point(322, 111);
            this.DtpDesdeFecha.Name = "DtpDesdeFecha";
            this.DtpDesdeFecha.Size = new System.Drawing.Size(306, 25);
            this.DtpDesdeFecha.TabIndex = 10;
            // 
            // DtpHastaFecha
            // 
            this.DtpHastaFecha.Location = new System.Drawing.Point(662, 111);
            this.DtpHastaFecha.Name = "DtpHastaFecha";
            this.DtpHastaFecha.Size = new System.Drawing.Size(299, 25);
            this.DtpHastaFecha.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(985, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Estado";
            // 
            // CmbEstado
            // 
            this.CmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbEstado.FormattingEnabled = true;
            this.CmbEstado.Items.AddRange(new object[] {
            "Programada",
            "Atendida",
            "Cancelada",
            "No_asistio"});
            this.CmbEstado.Location = new System.Drawing.Point(988, 110);
            this.CmbEstado.Name = "CmbEstado";
            this.CmbEstado.Size = new System.Drawing.Size(170, 25);
            this.CmbEstado.TabIndex = 13;
            // 
            // DtgDatos
            // 
            this.DtgDatos.AllowUserToAddRows = false;
            this.DtgDatos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(236)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DtgDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DtgDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgDatos.Location = new System.Drawing.Point(11, 160);
            this.DtgDatos.Name = "DtgDatos";
            this.DtgDatos.Size = new System.Drawing.Size(1160, 456);
            this.DtgDatos.TabIndex = 14;
            this.DtgDatos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgDatos_CellClick);
            this.DtgDatos.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgDatos_CellEnter);
            this.DtgDatos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DtgDatos_CellFormatting);
            // 
            // FrmCitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(236)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(1182, 626);
            this.ControlBox = false;
            this.Controls.Add(this.DtgDatos);
            this.Controls.Add(this.CmbEstado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DtpHastaFecha);
            this.Controls.Add(this.DtpDesdeFecha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtPaciente);
            this.Controls.Add(this.BtnCsv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.BtnFiltrar);
            this.Controls.Add(this.BtnNuevaCita);
            this.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmCitas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Citas";
            ((System.ComponentModel.ISupportInitialize)(this.DtgDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnNuevaCita;
        private System.Windows.Forms.Button BtnFiltrar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnCsv;
        private System.Windows.Forms.TextBox TxtPaciente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DtpDesdeFecha;
        private System.Windows.Forms.DateTimePicker DtpHastaFecha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CmbEstado;
        private System.Windows.Forms.DataGridView DtgDatos;
    }
}