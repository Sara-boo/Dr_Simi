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
            this.BtnNuevaCita.Location = new System.Drawing.Point(788, 26);
            this.BtnNuevaCita.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.BtnNuevaCita.Name = "BtnNuevaCita";
            this.BtnNuevaCita.Size = new System.Drawing.Size(153, 49);
            this.BtnNuevaCita.TabIndex = 0;
            this.BtnNuevaCita.Text = "+ Nueva Cita";
            this.BtnNuevaCita.UseVisualStyleBackColor = true;
            // 
            // BtnFiltrar
            // 
            this.BtnFiltrar.Location = new System.Drawing.Point(957, 26);
            this.BtnFiltrar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.BtnFiltrar.Name = "BtnFiltrar";
            this.BtnFiltrar.Size = new System.Drawing.Size(153, 49);
            this.BtnFiltrar.TabIndex = 1;
            this.BtnFiltrar.Text = "Filtrar";
            this.BtnFiltrar.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1955, 48);
            this.button3.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(125, 35);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(25, 96);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar Paciente (CURP o Nombre)";
            // 
            // BtnCsv
            // 
            this.BtnCsv.Location = new System.Drawing.Point(1133, 26);
            this.BtnCsv.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.BtnCsv.Name = "BtnCsv";
            this.BtnCsv.Size = new System.Drawing.Size(153, 49);
            this.BtnCsv.TabIndex = 4;
            this.BtnCsv.Text = "CSV";
            this.BtnCsv.UseVisualStyleBackColor = true;
            // 
            // TxtPaciente
            // 
            this.TxtPaciente.Location = new System.Drawing.Point(29, 131);
            this.TxtPaciente.Name = "TxtPaciente";
            this.TxtPaciente.Size = new System.Drawing.Size(298, 26);
            this.TxtPaciente.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(354, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Desde la Fecha";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(732, 96);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Hasta la Fecha";
            // 
            // DtpDesdeFecha
            // 
            this.DtpDesdeFecha.Location = new System.Drawing.Point(358, 131);
            this.DtpDesdeFecha.Name = "DtpDesdeFecha";
            this.DtpDesdeFecha.Size = new System.Drawing.Size(339, 26);
            this.DtpDesdeFecha.TabIndex = 10;
            // 
            // DtpHastaFecha
            // 
            this.DtpHastaFecha.Location = new System.Drawing.Point(736, 131);
            this.DtpHastaFecha.Name = "DtpHastaFecha";
            this.DtpHastaFecha.Size = new System.Drawing.Size(332, 26);
            this.DtpHastaFecha.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1094, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Estado";
            // 
            // CmbEstado
            // 
            this.CmbEstado.FormattingEnabled = true;
            this.CmbEstado.Location = new System.Drawing.Point(1098, 129);
            this.CmbEstado.Name = "CmbEstado";
            this.CmbEstado.Size = new System.Drawing.Size(188, 28);
            this.CmbEstado.TabIndex = 13;
            // 
            // DtgDatos
            // 
            this.DtgDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgDatos.Location = new System.Drawing.Point(12, 188);
            this.DtgDatos.Name = "DtgDatos";
            this.DtgDatos.Size = new System.Drawing.Size(1289, 537);
            this.DtgDatos.TabIndex = 14;
            // 
            // Citas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1313, 737);
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
            this.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Citas";
            this.Text = "Citas";
            this.Load += new System.EventHandler(this.Citas_Load);
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