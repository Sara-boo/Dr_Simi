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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DtgDatos)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnNuevaCita
            // 
            this.BtnNuevaCita.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(150)))), ((int)(((byte)(127)))));
            this.BtnNuevaCita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNuevaCita.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNuevaCita.ForeColor = System.Drawing.Color.Honeydew;
            this.BtnNuevaCita.Location = new System.Drawing.Point(642, 21);
            this.BtnNuevaCita.Margin = new System.Windows.Forms.Padding(4);
            this.BtnNuevaCita.Name = "BtnNuevaCita";
            this.BtnNuevaCita.Size = new System.Drawing.Size(161, 50);
            this.BtnNuevaCita.TabIndex = 0;
            this.BtnNuevaCita.Text = "+ Nueva Cita";
            this.BtnNuevaCita.UseVisualStyleBackColor = false;
            this.BtnNuevaCita.Click += new System.EventHandler(this.BtnNuevaCita_Click);
            // 
            // BtnFiltrar
            // 
            this.BtnFiltrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(93)))), ((int)(((byte)(126)))));
            this.BtnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFiltrar.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Bold);
            this.BtnFiltrar.ForeColor = System.Drawing.Color.Honeydew;
            this.BtnFiltrar.Location = new System.Drawing.Point(836, 22);
            this.BtnFiltrar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnFiltrar.Name = "BtnFiltrar";
            this.BtnFiltrar.Size = new System.Drawing.Size(152, 50);
            this.BtnFiltrar.TabIndex = 1;
            this.BtnFiltrar.Text = "Filtrar  ";
            this.BtnFiltrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnFiltrar.UseVisualStyleBackColor = false;
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
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 14F);
            this.label1.Location = new System.Drawing.Point(9, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar Paciente (CURP)";
            // 
            // BtnCsv
            // 
            this.BtnCsv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(166)))), ((int)(((byte)(158)))));
            this.BtnCsv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCsv.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Bold);
            this.BtnCsv.ForeColor = System.Drawing.Color.Honeydew;
            this.BtnCsv.Location = new System.Drawing.Point(1016, 22);
            this.BtnCsv.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCsv.Name = "BtnCsv";
            this.BtnCsv.Size = new System.Drawing.Size(122, 50);
            this.BtnCsv.TabIndex = 4;
            this.BtnCsv.Text = "CSV";
            this.BtnCsv.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCsv.UseVisualStyleBackColor = false;
            this.BtnCsv.Click += new System.EventHandler(this.BtnCsv_Click);
            // 
            // TxtPaciente
            // 
            this.TxtPaciente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtPaciente.Font = new System.Drawing.Font("Lucida Bright", 14F);
            this.TxtPaciente.Location = new System.Drawing.Point(13, 57);
            this.TxtPaciente.Name = "TxtPaciente";
            this.TxtPaciente.Size = new System.Drawing.Size(358, 29);
            this.TxtPaciente.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 14F);
            this.label2.Location = new System.Drawing.Point(427, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 26);
            this.label2.TabIndex = 6;
            this.label2.Text = "Desde la Fecha";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Lucida Bright", 14F);
            this.label3.Location = new System.Drawing.Point(672, 28);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 26);
            this.label3.TabIndex = 8;
            this.label3.Text = "Hasta la Fecha";
            // 
            // DtpDesdeFecha
            // 
            this.DtpDesdeFecha.Font = new System.Drawing.Font("Lucida Bright", 14F);
            this.DtpDesdeFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpDesdeFecha.Location = new System.Drawing.Point(430, 57);
            this.DtpDesdeFecha.Name = "DtpDesdeFecha";
            this.DtpDesdeFecha.Size = new System.Drawing.Size(191, 29);
            this.DtpDesdeFecha.TabIndex = 10;
            // 
            // DtpHastaFecha
            // 
            this.DtpHastaFecha.Font = new System.Drawing.Font("Lucida Bright", 14F);
            this.DtpHastaFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpHastaFecha.Location = new System.Drawing.Point(675, 57);
            this.DtpHastaFecha.Name = "DtpHastaFecha";
            this.DtpHastaFecha.Size = new System.Drawing.Size(183, 29);
            this.DtpHastaFecha.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Bright", 14F);
            this.label4.Location = new System.Drawing.Point(905, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 22);
            this.label4.TabIndex = 12;
            this.label4.Text = "Estado";
            // 
            // CmbEstado
            // 
            this.CmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbEstado.Font = new System.Drawing.Font("Lucida Bright", 14F);
            this.CmbEstado.FormattingEnabled = true;
            this.CmbEstado.Items.AddRange(new object[] {
            "Programada",
            "Atendida",
            "Cancelada",
            "No_asistio"});
            this.CmbEstado.Location = new System.Drawing.Point(909, 56);
            this.CmbEstado.Name = "CmbEstado";
            this.CmbEstado.Size = new System.Drawing.Size(207, 30);
            this.CmbEstado.TabIndex = 13;
            // 
            // DtgDatos
            // 
            this.DtgDatos.AllowUserToAddRows = false;
            this.DtgDatos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(236)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(151)))), ((int)(((byte)(145)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DtgDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DtgDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(161)))), ((int)(((byte)(145)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DtgDatos.DefaultCellStyle = dataGridViewCellStyle2;
            this.DtgDatos.Location = new System.Drawing.Point(11, 200);
            this.DtgDatos.Name = "DtgDatos";
            this.DtgDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DtgDatos.Size = new System.Drawing.Size(1160, 416);
            this.DtgDatos.TabIndex = 14;
            this.DtgDatos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgDatos_CellClick);
            this.DtgDatos.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgDatos_CellEnter);
            this.DtgDatos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DtgDatos_CellFormatting);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(217)))), ((int)(((byte)(214)))));
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.DtpHastaFecha);
            this.groupBox1.Controls.Add(this.CmbEstado);
            this.groupBox1.Controls.Add(this.DtpDesdeFecha);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxtPaciente);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(11, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1159, 106);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(166)))), ((int)(((byte)(158)))));
            this.pictureBox2.BackgroundImage = global::LogClinic.Properties.Resources.DWL_CSV;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(1026, 28);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 43);
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(93)))), ((int)(((byte)(126)))));
            this.pictureBox1.BackgroundImage = global::LogClinic.Properties.Resources.Filtrar;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(850, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 40);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // FrmCitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(236)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(1182, 626);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DtgDatos);
            this.Controls.Add(this.BtnCsv);
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}