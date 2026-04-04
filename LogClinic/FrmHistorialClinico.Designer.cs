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
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.TxtBuscarPaciente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(236)))), ((int)(((byte)(238)))));
            this.BtnBuscar.BackgroundImage = global::LogClinic.Properties.Resources.Buscar;
            this.BtnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBuscar.Location = new System.Drawing.Point(35, 55);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(52, 44);
            this.BtnBuscar.TabIndex = 16;
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // TxtBuscarPaciente
            // 
            this.TxtBuscarPaciente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.TxtBuscarPaciente.Font = new System.Drawing.Font("Lucida Bright", 14F);
            this.TxtBuscarPaciente.Location = new System.Drawing.Point(93, 55);
            this.TxtBuscarPaciente.Multiline = true;
            this.TxtBuscarPaciente.Name = "TxtBuscarPaciente";
            this.TxtBuscarPaciente.Size = new System.Drawing.Size(377, 44);
            this.TxtBuscarPaciente.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Bright", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(340, 23);
            this.label3.TabIndex = 14;
            this.label3.Text = "Buscar Paciente (Ingrese la CURP)";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(217)))), ((int)(((byte)(214)))));
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
            this.groupBox1.Size = new System.Drawing.Size(1141, 93);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // LblEnfCronicas
            // 
            this.LblEnfCronicas.AutoSize = true;
            this.LblEnfCronicas.Location = new System.Drawing.Point(963, 61);
            this.LblEnfCronicas.Name = "LblEnfCronicas";
            this.LblEnfCronicas.Size = new System.Drawing.Size(67, 20);
            this.LblEnfCronicas.TabIndex = 26;
            this.LblEnfCronicas.Text = "label10";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(565, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 20);
            this.label9.TabIndex = 25;
            this.label9.Text = "Tipo de sangre";
            // 
            // LblSangre
            // 
            this.LblSangre.AutoSize = true;
            this.LblSangre.Location = new System.Drawing.Point(604, 61);
            this.LblSangre.Name = "LblSangre";
            this.LblSangre.Size = new System.Drawing.Size(57, 20);
            this.LblSangre.TabIndex = 24;
            this.LblSangre.Text = "label8";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(763, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 20);
            this.label7.TabIndex = 23;
            this.label7.Text = "Alergias";
            // 
            // LblAlergias
            // 
            this.LblAlergias.AutoSize = true;
            this.LblAlergias.Location = new System.Drawing.Point(778, 61);
            this.LblAlergias.Name = "LblAlergias";
            this.LblAlergias.Size = new System.Drawing.Size(57, 20);
            this.LblAlergias.TabIndex = 22;
            this.LblAlergias.Text = "label6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(941, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "Enf. Crónicas";
            // 
            // LblCurp
            // 
            this.LblCurp.AutoSize = true;
            this.LblCurp.Location = new System.Drawing.Point(24, 61);
            this.LblCurp.Name = "LblCurp";
            this.LblCurp.Size = new System.Drawing.Size(51, 20);
            this.LblCurp.TabIndex = 20;
            this.LblCurp.Text = "CURP";
            // 
            // LblEdad
            // 
            this.LblEdad.AutoSize = true;
            this.LblEdad.Location = new System.Drawing.Point(186, 61);
            this.LblEdad.Name = "LblEdad";
            this.LblEdad.Size = new System.Drawing.Size(49, 20);
            this.LblEdad.TabIndex = 19;
            this.LblEdad.Text = "Edad";
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Font = new System.Drawing.Font("Lucida Bright", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombre.Location = new System.Drawing.Point(18, 13);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(97, 24);
            this.LblNombre.TabIndex = 18;
            this.LblNombre.Text = "Nombre";
            // 
            // DtgDatos
            // 
            this.DtgDatos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(217)))), ((int)(((byte)(214)))));
            this.DtgDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgDatos.Location = new System.Drawing.Point(8, 235);
            this.DtgDatos.Name = "DtgDatos";
            this.DtgDatos.Size = new System.Drawing.Size(1145, 344);
            this.DtgDatos.TabIndex = 18;
            // 
            // FrmHistorialClinico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(236)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(1166, 587);
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
    }
}