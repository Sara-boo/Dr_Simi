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
using Mysqlx;
using MySql.Data.MySqlClient;

namespace LogClinic
{
    public partial class FrmRegristroCitas : Form
    {
        ManejadorCitas mc;
        public FrmRegristroCitas()
        {
            InitializeComponent();
            mc = new ManejadorCitas();
            mc.LlenarMedico(CmbMedico);
            DtpHoraProgramada.Format = DateTimePickerFormat.Time;
            DtpHoraProgramada.ShowUpDown = true;
            LblPaciente.Visible = false;
            LblPersonal.Visible = false;
            CmbEstado.Text = "Programada";
           
            if (FrmCitas.cita.IdCita > 0)
            {
                CmbEstado.Enabled = true; 
                LblPaciente.Text = FrmCitas.cita.IdPaciente.ToString();
                LblPersonal.Text = FrmCitas.cita.IdPersonal.ToString();
                TxtBuscarPaciente.Text = FrmCitas.curp;
                BuscarDatosPaciente(FrmCitas.curp);
                CmbMedico.SelectedValue = FrmCitas.cita.IdPersonal;
                CmbEstado.Text = FrmCitas.cita.Estado;
                DtpFechaProgramada.Value = FrmCitas.cita.FechaHora;
                DtpHoraProgramada.Value = FrmCitas.cita.FechaHora;
                CmbEstado.Enabled = true; // Deshabilitar el ComboBox de estado para nuevas citas
                CmbEstado.Cursor = Cursors.Hand; // Cambiar el cursor para indicar que no se puede interactuar
            }
        }
        private void BuscarDatosPaciente(string curpBuscada)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(curpBuscada))
                {
                    MessageBox.Show("Ingrese una CURP para buscar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DataRow paciente = mc.BuscarCurp(curpBuscada);
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
                    MessageBox.Show("No se encontró ningún paciente con esa CURP.", "Paciente no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error al conectar con la base de datos.\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            DateTime fechaHoraCombinada = new DateTime(DtpFechaProgramada.Value.Year,DtpFechaProgramada.Value.Month,DtpFechaProgramada.Value.Day,DtpHoraProgramada.Value.Hour,DtpHoraProgramada.Value.Minute,0);// segundos en 0
            try
            {
                if (FrmCitas.cita.IdCita == 0)
                {
                    
                    mc.Insertar(new Citas(0, int.Parse(LblPaciente.Text), int.Parse(LblPersonal.Text), fechaHoraCombinada, ""));
                    MessageBox.Show("La cita ah sido programda con éxito", "Operación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    mc.Editar(new Citas(FrmCitas.cita.IdCita, int.Parse(LblPaciente.Text), int.Parse(LblPersonal.Text), fechaHoraCombinada, CmbEstado.Text));
                    MessageBox.Show("La cita ha sido editada con éxito.","Operación Exitosa",MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();

                }
            }
            catch(MySqlException ex) 
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch(FormatException exf)
            {
                MessageBox.Show($"{exf.Message}\nAsegurese de ingresar todos los campos necesarios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            BuscarDatosPaciente(TxtBuscarPaciente.Text);
        }

        private void CmbMedico_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbMedico.SelectedValue != null && CmbMedico.SelectedValue is int)
            {
                LblPersonal.Text = CmbMedico.SelectedValue.ToString();
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
