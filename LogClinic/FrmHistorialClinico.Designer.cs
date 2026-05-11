namespace LogClinic
{
    partial class FrmHistorialClinico
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
            this.TxtBuscarPaciente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LblIdPaciente = new System.Windows.Forms.Label();
            this.LblEnfCronicas = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.LblSangre = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.LblAlergias = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LblCurp = new System.Windows.Forms.Label();
            this.LblEdad = new System.Windows.Forms.Label();
            this.LblNombre = new System.Windows.Forms.Label();
            this.DtgDatos = new System.Windows.Forms.DataGridView();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtgDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtBuscarPaciente
            // 
            this.TxtBuscarPaciente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.TxtBuscarPaciente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtBuscarPaciente.Font = new System.Drawing.Font("Lucida Bright", 14F);
            this.TxtBuscarPaciente.Location = new System.Drawing.Point(34, 55);
            this.TxtBuscarPaciente.Multiline = true;
            this.TxtBuscarPaciente.Name = "TxtBuscarPaciente";
            this.TxtBuscarPaciente.Size = new System.Drawing.Size(476, 44);
            this.TxtBuscarPaciente.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Bright", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(402, 28);
            this.label3.TabIndex = 14;
            this.label3.Text = "Buscar Paciente (Ingrese la CURP)";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(217)))), ((int)(((byte)(214)))));
            this.groupBox1.Controls.Add(this.pictureBox5);
            this.groupBox1.Controls.Add(this.pictureBox4);
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.LblIdPaciente);
            this.groupBox1.Controls.Add(this.LblEnfCronicas);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.LblSangre);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.LblAlergias);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.LblCurp);
            this.groupBox1.Controls.Add(this.LblEdad);
            this.groupBox1.Controls.Add(this.LblNombre);
            this.groupBox1.Location = new System.Drawing.Point(12, 119);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1349, 93);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = global::LogClinic.Properties.Resources.EnfCronicas_s;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox5.Location = new System.Drawing.Point(1057, 59);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(25, 22);
            this.pictureBox5.TabIndex = 32;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::LogClinic.Properties.Resources.Alergias_s;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.Location = new System.Drawing.Point(839, 59);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(25, 22);
            this.pictureBox4.TabIndex = 31;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::LogClinic.Properties.Resources.Sangre_s;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(593, 59);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(25, 22);
            this.pictureBox3.TabIndex = 30;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::LogClinic.Properties.Resources.edad_s;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(356, 59);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 22);
            this.pictureBox2.TabIndex = 29;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::LogClinic.Properties.Resources.Identificacion_s;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(37, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 22);
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // LblIdPaciente
            // 
            this.LblIdPaciente.AutoSize = true;
            this.LblIdPaciente.Enabled = false;
            this.LblIdPaciente.Location = new System.Drawing.Point(236, 17);
            this.LblIdPaciente.Name = "LblIdPaciente";
            this.LblIdPaciente.Size = new System.Drawing.Size(25, 20);
            this.LblIdPaciente.TabIndex = 27;
            this.LblIdPaciente.Text = "Id";
            // 
            // LblEnfCronicas
            // 
            this.LblEnfCronicas.AutoSize = true;
            this.LblEnfCronicas.Font = new System.Drawing.Font("Lucida Bright", 14F);
            this.LblEnfCronicas.ForeColor = System.Drawing.Color.DimGray;
            this.LblEnfCronicas.Location = new System.Drawing.Point(1084, 59);
            this.LblEnfCronicas.Name = "LblEnfCronicas";
            this.LblEnfCronicas.Size = new System.Drawing.Size(123, 22);
            this.LblEnfCronicas.TabIndex = 26;
            this.LblEnfCronicas.Text = "enf.cronicas";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lucida Bright", 16F);
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(586, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(169, 24);
            this.label9.TabIndex = 25;
            this.label9.Text = "Tipo de sangre";
            // 
            // LblSangre
            // 
            this.LblSangre.AutoSize = true;
            this.LblSangre.Font = new System.Drawing.Font("Lucida Bright", 14F);
            this.LblSangre.ForeColor = System.Drawing.Color.DimGray;
            this.LblSangre.Location = new System.Drawing.Point(624, 59);
            this.LblSangre.Name = "LblSangre";
            this.LblSangre.Size = new System.Drawing.Size(72, 22);
            this.LblSangre.TabIndex = 24;
            this.LblSangre.Text = "sangre";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Bright", 16F);
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(851, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 24);
            this.label7.TabIndex = 23;
            this.label7.Text = "Alergias";
            // 
            // LblAlergias
            // 
            this.LblAlergias.AutoSize = true;
            this.LblAlergias.Font = new System.Drawing.Font("Lucida Bright", 14F);
            this.LblAlergias.ForeColor = System.Drawing.Color.DimGray;
            this.LblAlergias.Location = new System.Drawing.Point(866, 59);
            this.LblAlergias.Name = "LblAlergias";
            this.LblAlergias.Size = new System.Drawing.Size(74, 22);
            this.LblAlergias.TabIndex = 22;
            this.LblAlergias.Text = "alergia";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Bright", 16F);
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(1062, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(259, 24);
            this.label5.TabIndex = 21;
            this.label5.Text = "Enfermedades Crónicas";
            // 
            // LblCurp
            // 
            this.LblCurp.AutoSize = true;
            this.LblCurp.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCurp.ForeColor = System.Drawing.Color.DimGray;
            this.LblCurp.Location = new System.Drawing.Point(68, 61);
            this.LblCurp.Name = "LblCurp";
            this.LblCurp.Size = new System.Drawing.Size(60, 22);
            this.LblCurp.TabIndex = 20;
            this.LblCurp.Text = "CURP";
            // 
            // LblEdad
            // 
            this.LblEdad.AutoSize = true;
            this.LblEdad.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEdad.ForeColor = System.Drawing.Color.DimGray;
            this.LblEdad.Location = new System.Drawing.Point(387, 59);
            this.LblEdad.Name = "LblEdad";
            this.LblEdad.Size = new System.Drawing.Size(56, 22);
            this.LblEdad.TabIndex = 19;
            this.LblEdad.Text = "Edad";
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Font = new System.Drawing.Font("Lucida Bright", 16F);
            this.LblNombre.ForeColor = System.Drawing.Color.DimGray;
            this.LblNombre.Location = new System.Drawing.Point(18, 13);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(96, 24);
            this.LblNombre.TabIndex = 18;
            this.LblNombre.Text = "Nombre";
            // 
            // DtgDatos
            // 
            this.DtgDatos.AllowUserToAddRows = false;
            this.DtgDatos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(217)))), ((int)(((byte)(214)))));
            this.DtgDatos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(93)))), ((int)(((byte)(126)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DtgDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DtgDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(93)))), ((int)(((byte)(126)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DtgDatos.DefaultCellStyle = dataGridViewCellStyle2;
            this.DtgDatos.Location = new System.Drawing.Point(8, 235);
            this.DtgDatos.Name = "DtgDatos";
            this.DtgDatos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DtgDatos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DtgDatos.RowHeadersVisible = false;
            this.DtgDatos.Size = new System.Drawing.Size(1338, 440);
            this.DtgDatos.TabIndex = 18;
            this.DtgDatos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DtgDatos_CellFormatting);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(236)))), ((int)(((byte)(238)))));
            this.BtnBuscar.BackgroundImage = global::LogClinic.Properties.Resources.Buscar;
            this.BtnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBuscar.FlatAppearance.BorderSize = 0;
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscar.Location = new System.Drawing.Point(516, 48);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(58, 58);
            this.BtnBuscar.TabIndex = 16;
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // FrmHistorialClinico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(236)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(1376, 687);
            this.Controls.Add(this.DtgDatos);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.TxtBuscarPaciente);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmHistorialClinico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmHistorialClinico";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtgDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.TextBox TxtBuscarPaciente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LblEnfCronicas;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label LblSangre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label LblAlergias;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LblCurp;
        private System.Windows.Forms.Label LblEdad;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.DataGridView DtgDatos;
        private System.Windows.Forms.Label LblIdPaciente;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}