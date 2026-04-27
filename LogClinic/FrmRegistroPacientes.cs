using System;
using System.Windows.Forms;
using Entidades;
using Manejadores;

namespace LogClinic
{
    public partial class FrmRegistroPacientes : Form
    {
        ManejadorRPaciente mp;

        public FrmRegistroPacientes()
        {
            InitializeComponent();
            mp = new ManejadorRPaciente();

            // Carga de datos si es modificación (siguiendo tu lógica de Agenda)
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
            }
        }

        private void BntGuardar_Click(object sender, EventArgs e)
        {
            if (FrmPacientes.paciente.IdPaciente == 0) 
            {
                mp.Guardar(new Paciente
                {
                    NombreCompleto = TxtNCompleto.Text,
                    Curp = TxtCurp.Text,
                    FechaNacimiento = DtpFNacimiento.Value,
                    Sexo = CmbSexo.Text,
                    TipoSangre = CmbTSangre.Text,
                    EnfermedadesCronicas = TxtECronicas.Text,
                    Alergias = TxtAlergias.Text,
                    Direccion = TxtDirreccion.Text,
                    Telefono = TxtTelefono.Text,
                    Correo = TxtCorreo.Text
                });
            }
            else 
            {
                mp.Modificar(new Paciente
                {
                    IdPaciente = FrmPacientes.paciente.IdPaciente,
                    NombreCompleto = TxtNCompleto.Text,
                    Curp = TxtCurp.Text,
                    Direccion = TxtDirreccion.Text,
                    Telefono = TxtTelefono.Text,
                    Correo = TxtCorreo.Text,
                    Alergias = TxtAlergias.Text,
                    EnfermedadesCronicas = TxtECronicas.Text,
                    TipoSangre = CmbTSangre.Text
                });
            }
            this.Close();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

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
        private void TxtTelefono_TextChanged(object sender, EventArgs e) { }
        private void TxtCorreo_TextChanged(object sender, EventArgs e) { }
    }
}
