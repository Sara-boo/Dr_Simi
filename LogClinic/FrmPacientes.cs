using System;
using System.Windows.Forms;
using Entidades;
using Manejadores;

namespace LogClinic
{
    public partial class FrmPacientes : Form
    {
        ManejadorRPaciente mp;
        int fila = 0, columna = 0;
        public static Paciente paciente = new Paciente();

        public FrmPacientes()
        {
            InitializeComponent();
            mp = new ManejadorRPaciente();
        }

        // Asegúrate de asignar este evento en el Rayito (Eventos) del Form o dando doble clic al fondo del form
        private void FrmPacientes_Load(object sender, EventArgs e)
        {
            mp.Mostrar(DtgPaciente, TxtBCurp.Text);
        }

        private void TxtBCurp_TextChanged(object sender, EventArgs e)
        {
            mp.Mostrar(DtgPaciente, TxtBCurp.Text);
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            mp.Mostrar(DtgPaciente, TxtBCurp.Text);
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            paciente.IdPaciente = 0;
            FrmRegistroPacientes frp = new FrmRegistroPacientes();
            frp.ShowDialog();
            mp.Mostrar(DtgPaciente, TxtBCurp.Text);
        }

        private void DtgPaciente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex; columna = e.ColumnIndex;
            if (fila >= 0)
            {
                paciente.IdPaciente = int.Parse(DtgPaciente.Rows[fila].Cells["ID"].Value.ToString());
                paciente.NombreCompleto = DtgPaciente.Rows[fila].Cells["Nombre"].Value.ToString();
                paciente.Curp = DtgPaciente.Rows[fila].Cells["CURP"].Value.ToString();
                paciente.Sexo = DtgPaciente.Rows[fila].Cells["Sexo"].Value.ToString();
                paciente.TipoSangre = DtgPaciente.Rows[fila].Cells["Sangre"].Value.ToString();
                paciente.EnfermedadesCronicas = DtgPaciente.Rows[fila].Cells["Enf. Crónicas"].Value.ToString();
                paciente.Alergias = DtgPaciente.Rows[fila].Cells["Alergias"].Value.ToString();
                paciente.Direccion = DtgPaciente.Rows[fila].Cells["Dirección"].Value.ToString();
                paciente.Correo = DtgPaciente.Rows[fila].Cells["Correo"].Value.ToString();
                paciente.Telefono = DtgPaciente.Rows[fila].Cells["Teléfono"].Value.ToString();

                if (DtgPaciente.Columns[columna].Name == "Modificar")
                {
                    FrmRegistroPacientes frp = new FrmRegistroPacientes();
                    frp.ShowDialog();
                    mp.Mostrar(DtgPaciente, TxtBCurp.Text);
                }
                else if (DtgPaciente.Columns[columna].Name == "Borrar")
                {
                    mp.Borrar(paciente.IdPaciente, paciente.NombreCompleto);
                    mp.Mostrar(DtgPaciente, TxtBCurp.Text);
                }
            }
        }

        private void DtgPaciente_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void FrmPacientes_Load_1(object sender, EventArgs e)
        {

        }

        private void BtnReporte_Click(object sender, EventArgs e) { }
    }
}
