namespace LogClinic
{
    partial class FrmVacunas
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
            this.CmbVacunas = new System.Windows.Forms.ComboBox();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CmbVacunas
            // 
            this.CmbVacunas.FormattingEnabled = true;
            this.CmbVacunas.Location = new System.Drawing.Point(519, 304);
            this.CmbVacunas.Name = "CmbVacunas";
            this.CmbVacunas.Size = new System.Drawing.Size(437, 53);
            this.CmbVacunas.TabIndex = 1;
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(252)))), ((int)(((byte)(214)))));
            this.BtnAceptar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(150)))), ((int)(((byte)(127)))));
            this.BtnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAceptar.Location = new System.Drawing.Point(681, 406);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(123, 45);
            this.BtnAceptar.TabIndex = 2;
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.UseVisualStyleBackColor = false;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // FrmVacunas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 45F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(236)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(1449, 880);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.CmbVacunas);
            this.Font = new System.Drawing.Font("Javanese Text", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 9, 4, 9);
            this.Name = "FrmVacunas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmVacunas";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox CmbVacunas;
        private System.Windows.Forms.Button BtnAceptar;
    }
}