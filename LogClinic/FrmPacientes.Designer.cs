namespace LogClinic
{
    partial class FrmPacientes
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
            this.DtgPaciente = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtBCurp = new System.Windows.Forms.TextBox();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.BtnReporte = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DtgPaciente)).BeginInit();
            this.SuspendLayout();
            // 
            // DtgPaciente
            // 
            this.DtgPaciente.BackgroundColor = System.Drawing.Color.White;
            this.DtgPaciente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgPaciente.GridColor = System.Drawing.Color.White;
            this.DtgPaciente.Location = new System.Drawing.Point(51, 144);
            this.DtgPaciente.Name = "DtgPaciente";
            this.DtgPaciente.ReadOnly = true;
            this.DtgPaciente.RowHeadersWidth = 51;
            this.DtgPaciente.RowTemplate.Height = 24;
            this.DtgPaciente.Size = new System.Drawing.Size(1283, 604);
            this.DtgPaciente.TabIndex = 0;
            this.DtgPaciente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgPaciente_CellClick);
            this.DtgPaciente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgPaciente_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "CURP del Paciente:";
            // 
            // TxtBCurp
            // 
            this.TxtBCurp.Font = new System.Drawing.Font("Javanese Text", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBCurp.Location = new System.Drawing.Point(297, 40);
            this.TxtBCurp.Name = "TxtBCurp";
            this.TxtBCurp.Size = new System.Drawing.Size(782, 30);
            this.TxtBCurp.TabIndex = 5;
            this.TxtBCurp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBCurp_KeyPress);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(93)))), ((int)(((byte)(126)))));
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscar.Font = new System.Drawing.Font("Javanese Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar.ForeColor = System.Drawing.Color.White;
            this.BtnBuscar.Location = new System.Drawing.Point(1101, 35);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(96, 38);
            this.BtnBuscar.TabIndex = 6;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // BtnReporte
            // 
            this.BtnReporte.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnReporte.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnReporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(236)))), ((int)(((byte)(238)))));
            this.BtnReporte.BackgroundImage = global::LogClinic.Properties.Resources.CSV_R;
            this.BtnReporte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnReporte.FlatAppearance.BorderSize = 0;
            this.BtnReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReporte.Font = new System.Drawing.Font("Javanese Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReporte.ForeColor = System.Drawing.Color.White;
            this.BtnReporte.Location = new System.Drawing.Point(1258, 26);
            this.BtnReporte.Margin = new System.Windows.Forms.Padding(0);
            this.BtnReporte.Name = "BtnReporte";
            this.BtnReporte.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnReporte.Size = new System.Drawing.Size(58, 56);
            this.BtnReporte.TabIndex = 4;
            this.BtnReporte.UseMnemonic = false;
            this.BtnReporte.UseVisualStyleBackColor = false;
            this.BtnReporte.Click += new System.EventHandler(this.BtnReporte_Click);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(93)))), ((int)(((byte)(126)))));
            this.BtnAgregar.BackgroundImage = global::LogClinic.Properties.Resources._;
            this.BtnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregar.Font = new System.Drawing.Font("Javanese Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.ForeColor = System.Drawing.Color.White;
            this.BtnAgregar.Location = new System.Drawing.Point(1219, 35);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(36, 38);
            this.BtnAgregar.TabIndex = 7;
            this.BtnAgregar.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // FrmPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(236)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(1363, 774);
            this.Controls.Add(this.BtnReporte);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.TxtBCurp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DtgPaciente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPacientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPacientes";
            this.Load += new System.EventHandler(this.FrmPacientes_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.DtgPaciente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DtgPaciente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtBCurp;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnReporte;
    }
}