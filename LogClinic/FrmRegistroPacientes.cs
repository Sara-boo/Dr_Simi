using System;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Entidades;
using Manejadores;

namespace LogClinic
{
    public partial class FrmRegistroPacientes : Form
    {
        ManejadorRPaciente mp;
        ManejadorBitacora mb;

        public FrmRegistroPacientes()
        {
            InitializeComponent();
            mp = new ManejadorRPaciente();
            mb = new ManejadorBitacora();

            CmbSexo.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbTSangre.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbSexo.Items.AddRange(new string[] { "Masculino", "Femenino", "Otro" });
            CmbTSangre.Items.AddRange(new string[] { "A+", "A-", "B+", "B-", "AB+", "AB-", "O+", "O-" });

            if (FrmPacientes.paciente.IdPaciente > 0)
            {
                TxtNCompleto.Text = FrmPacientes.paciente.NombreCompleto;
                TxtCurp.Text = FrmPacientes.paciente.Curp;
                CmbSexo.Text = FrmPacientes.paciente.Sexo;
                CmbTSangre.Text = FrmPacientes.paciente.TipoSangre;
                TxtECronicas.Text = FrmPacientes.paciente.EnfermedadesCronicas;
                TxtAlergias.Text = FrmPacientes.paciente.Alergias;
                TxtDirreccion.Text = FrmPacientes.paciente.Direccion;
                TxtTelefono.Text = FrmPacientes.paciente.Telefono;
                TxtCorreo.Text = FrmPacientes.paciente.Correo;
                DtpFNacimiento.Value = FrmPacientes.paciente.FechaNacimiento;
            }
        }

        private bool ValidarFormulario()
        {
            if (string.IsNullOrWhiteSpace(TxtNCompleto.Text)) { MessageBox.Show("Ingrese nombre completo."); return false; }
            if (TxtCurp.Text.Length != 18) { MessageBox.Show("La CURP debe tener 18 caracteres."); return false; }
            if (CmbSexo.SelectedIndex == -1) { MessageBox.Show("Debe seleccionar un sexo."); return false; }

            string correoPatron = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (!Regex.IsMatch(TxtCorreo.Text, correoPatron)) { MessageBox.Show("El formato de correo no es válido."); return false; }

            return true;
        }

        private void BntGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarFormulario()) return;

            Paciente p = new Paciente
            {
                NombreCompleto = TxtNCompleto.Text,
                Curp = TxtCurp.Text.ToUpper(),
                FechaNacimiento = DtpFNacimiento.Value,
                Sexo = CmbSexo.Text,
                TipoSangre = CmbTSangre.Text,
                EnfermedadesCronicas = TxtECronicas.Text,
                Alergias = TxtAlergias.Text,
                Direccion = TxtDirreccion.Text,
                Telefono = TxtTelefono.Text,
                Correo = TxtCorreo.Text
            };

            if (FrmPacientes.paciente.IdPaciente == 0)
            {
                mp.Guardar(p);

                //Registro para la bitácora
                mb.GuardarBitacora(FrmInicioSesion.IdUsuarioLogueado, $"Registó al paciente: {p.NombreCompleto}");
            }
            else
            {
                p.IdPaciente = FrmPacientes.paciente.IdPaciente;
                mp.Modificar(p);
                mb.GuardarBitacora(FrmInicioSesion.IdUsuarioLogueado, $"Modificó al paciente: {p.NombreCompleto}");
                MessageBox.Show("Paciente modificado con éxito", "Actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.Close();
        }

        private void TxtCurp_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) e.Handled = true;
        }

        private void TxtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '+' && !char.IsControl(e.KeyChar)) e.Handled = true;
            if (e.KeyChar == '+' && TxtTelefono.Text.Contains("+")) e.Handled = true;
        }

        private void TxtTelefono_TextChanged(object sender, EventArgs e)
        {
            string original = TxtTelefono.Text;
            string limpio = "";
            foreach (char c in original)
            {
                if (char.IsDigit(c) || c == '+') limpio += c;
            }
            if (original != limpio)
            {
                TxtTelefono.Text = limpio;
                TxtTelefono.SelectionStart = limpio.Length;
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e) => this.Close();

        private void label1_Click(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
        private void label10_Click(object sender, EventArgs e) { }
        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e) { }
        private void TxtNCompleto_TextChanged(object sender, EventArgs e) { }
        private void TxtCurp_TextChanged(object sender, EventArgs e) { }
        private void DtpFNacimiento_ValueChanged(object sender, EventArgs e) { }
        private void CmbSexo_SelectedIndexChanged(object sender, EventArgs e) { }
        private void CmbTSangre_SelectedIndexChanged(object sender, EventArgs e) { }
        private void TxtECronicas_TextChanged(object sender, EventArgs e) { }
        private void TxtAlergias_TextChanged(object sender, EventArgs e) { }
        private void TxtDirreccion_TextChanged(object sender, EventArgs e) { }
        private void TxtCorreo_TextChanged(object sender, EventArgs e) { }
        private void FrmRegistroPacientes_Load(object sender, EventArgs e) { }
    }
}