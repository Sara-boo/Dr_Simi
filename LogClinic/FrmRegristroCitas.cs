using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Manejadores;
using Entidades;

namespace LogClinic
{
    public partial class FrmRegristroCitas : Form
    {
        ManejadorCitas mc;
        public FrmRegristroCitas()
        {
            InitializeComponent();
            mc = new ManejadorCitas();
            if(FrmCitas.cita.IdCita >0)
            {
                TxtTipoSangre.Text = FrmCitas.cita.IdPaciente.ToString();
                CmbMedico.Text = FrmCitas.cita.IdPersonal.ToString();
                DtpFechaProgramada.Value = FrmCitas.cita.FechaHora;
                DtpHoraProgramada.Value = FrmCitas.cita.FechaHora;
                TxtMotivo.Text = FrmCitas.cita.Motivo.ToString();
                mc.LlenarMedico(CmbMedico);
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            DateTime fechaHoraCombinada = new DateTime(
                DtpFechaProgramada.Value.Year,
                DtpFechaProgramada.Value.Month,
                DtpFechaProgramada.Value.Day,
                DtpHoraProgramada.Value.Hour,
                DtpHoraProgramada.Value.Minute,
                0  // segundos en 0
            );

            if (FrmCitas.cita.IdCita == 0)
            {
                mc.Insertar(new Citas(0, int.Parse(LblPaciente.Text), int.Parse(LblPersonal.Text), fechaHoraCombinada, "", TxtMotivo.Text));
            }
            else
            {
                mc.Editar(new Citas(FrmCitas.cita.IdCita, int.Parse(LblPaciente.Text), int.Parse(LblPersonal.Text), fechaHoraCombinada, "", TxtMotivo.Text));
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            DataRow paciente = mc.BuscarPacientePorCurp(TxtBuscarPaciente.Text);

            if (paciente != null)
            {
                LblPaciente.Text = paciente["id_paciente"].ToString();
                TxtPaciente.Text = paciente["nombre_completo"].ToString();
                TxtTipoSangre.Text = paciente["tipo_sangre"].ToString();
                TxtFechaNac.Text = paciente["fecha_nacimiento"].ToString();
                TxtAlergias.Text = paciente["alergias"].ToString();
                TxtEnfCronicas.Text = paciente["enfermedades_cronicas"].ToString();
            }
            else
            {
                MessageBox.Show("No se encontró ningún paciente con esa CURP.","Paciente no encontrado",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CmbMedico_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
