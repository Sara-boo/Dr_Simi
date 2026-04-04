namespace LogClinic
{
    partial class FrmTratamiento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTratamiento));
            this.dtgDatosPaciente = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbMedicamento = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbPresentacion = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dtgMedicamentos = new System.Windows.Forms.DataGridView();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDatosPaciente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMedicamentos)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgDatosPaciente
            // 
            this.dtgDatosPaciente.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgDatosPaciente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDatosPaciente.Location = new System.Drawing.Point(91, 52);
            this.dtgDatosPaciente.Name = "dtgDatosPaciente";
            this.dtgDatosPaciente.RowHeadersWidth = 51;
            this.dtgDatosPaciente.RowTemplate.Height = 24;
            this.dtgDatosPaciente.Size = new System.Drawing.Size(851, 132);
            this.dtgDatosPaciente.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Descripción (Síntomas)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(847, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "_________________________________________________________________________________" +
    "_______________________________________";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(95, 265);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(846, 113);
            this.textBox1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 403);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Receta:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(88, 412);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(847, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "_________________________________________________________________________________" +
    "_______________________________________";
            // 
            // cmbMedicamento
            // 
            this.cmbMedicamento.FormattingEnabled = true;
            this.cmbMedicamento.Location = new System.Drawing.Point(125, 461);
            this.cmbMedicamento.Name = "cmbMedicamento";
            this.cmbMedicamento.Size = new System.Drawing.Size(449, 24);
            this.cmbMedicamento.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(122, 442);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Medicamento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(611, 442);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Presentación";
            // 
            // cmbPresentacion
            // 
            this.cmbPresentacion.FormattingEnabled = true;
            this.cmbPresentacion.Location = new System.Drawing.Point(614, 461);
            this.cmbPresentacion.Name = "cmbPresentacion";
            this.cmbPresentacion.Size = new System.Drawing.Size(204, 24);
            this.cmbPresentacion.TabIndex = 9;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAgregar.BackgroundImage")));
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAgregar.Location = new System.Drawing.Point(856, 442);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(48, 43);
            this.btnAgregar.TabIndex = 10;
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // dtgMedicamentos
            // 
            this.dtgMedicamentos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgMedicamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMedicamentos.Location = new System.Drawing.Point(95, 510);
            this.dtgMedicamentos.Name = "dtgMedicamentos";
            this.dtgMedicamentos.RowHeadersWidth = 51;
            this.dtgMedicamentos.RowTemplate.Height = 24;
            this.dtgMedicamentos.Size = new System.Drawing.Size(846, 104);
            this.dtgMedicamentos.TabIndex = 11;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(242)))), ((int)(((byte)(229)))));
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(93)))), ((int)(((byte)(126)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Javanese Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(590, 643);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(139, 54);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(252)))), ((int)(((byte)(214)))));
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(150)))), ((int)(((byte)(127)))));
            this.btnGuardar.FlatAppearance.BorderSize = 2;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Javanese Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(341, 643);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(139, 54);
            this.btnGuardar.TabIndex = 14;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // FrmTratamiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(236)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(1028, 742);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dtgMedicamentos);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.cmbPresentacion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbMedicamento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtgDatosPaciente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmTratamiento";
            this.Text = "FrmTratamiento";
            ((System.ComponentModel.ISupportInitialize)(this.dtgDatosPaciente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMedicamentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgDatosPaciente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbMedicamento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbPresentacion;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dtgMedicamentos;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
    }
}