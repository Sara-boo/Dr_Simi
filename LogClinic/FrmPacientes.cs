using System;
using System.Drawing;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
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

           
            DtgPaciente.RowHeadersVisible = false; 
            DtgPaciente.AllowUserToAddRows = false; 
        }

        private void FrmPacientes_Load(object sender, EventArgs e)
        {
            BtnReporte.FlatStyle = FlatStyle.Flat;
            BtnReporte.FlatAppearance.BorderSize = 1;
            BtnReporte.FlatAppearance.BorderColor = Color.White;
            BtnReporte.BackColor = Color.FromArgb(1, 91, 126);

            if (Properties.Resources.DWL_CSV != null)
            {
                BtnReporte.Image = (Image)(new Bitmap(Properties.Resources.DWL_CSV, new Size(16, 16)));
            }
            BtnReporte.ImageAlign = ContentAlignment.MiddleCenter;
            BtnReporte.Text = "";

            mp.Mostrar(DtgPaciente, TxtBCurp.Text, Properties.Resources.Edit, Properties.Resources.Eliminar_R);
        }

        private void TxtBCurp_TextChanged(object sender, EventArgs e)
        {
            int pos = TxtBCurp.SelectionStart;
            TxtBCurp.Text = TxtBCurp.Text.ToUpper();
            TxtBCurp.SelectionStart = pos;

            mp.Mostrar(DtgPaciente, TxtBCurp.Text, Properties.Resources.Edit, Properties.Resources.Eliminar_R);
        }

        private void TxtBCurp_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            mp.Mostrar(DtgPaciente, TxtBCurp.Text, Properties.Resources.Edit, Properties.Resources.Eliminar_R);
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            paciente.IdPaciente = 0;
            FrmRegistroPacientes frp = new FrmRegistroPacientes();
            frp.ShowDialog();
            mp.Mostrar(DtgPaciente, TxtBCurp.Text, Properties.Resources.Edit, Properties.Resources.Eliminar_R);
        }

        private void DtgPaciente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex;
            columna = e.ColumnIndex;

            if (fila >= 0)
            {
                try
                {
                    if (DtgPaciente.Rows[fila].Cells["ID"].Value != null)
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
                        paciente.FechaNacimiento = Convert.ToDateTime(DtgPaciente.Rows[fila].Cells["fecha_nacimiento"].Value);

                        string nombreBoton = DtgPaciente.Columns[columna].Name;

                        if (nombreBoton == "Modificar")
                        {
                            FrmRegistroPacientes frp = new FrmRegistroPacientes();
                            frp.ShowDialog();
                            mp.Mostrar(DtgPaciente, TxtBCurp.Text, Properties.Resources.Edit, Properties.Resources.Eliminar_R);
                        }
                        else if (nombreBoton == "Borrar")
                        {
                            mp.Borrar(paciente.IdPaciente, paciente.NombreCompleto);
                            mp.Mostrar(DtgPaciente, TxtBCurp.Text, Properties.Resources.Edit, Properties.Resources.Eliminar_R);
                        }
                    }
                }
                catch (Exception)
                {
                }
            }
        }

        private void BtnReporte_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Excel files (*.xlsx)|*.xlsx",
                Title = "Guardar Reporte de Pacientes",
                FileName = "Reporte_Pacientes.xlsx"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                System.Data.DataTable dt = mp.ObtenerDatosReporte(TxtBCurp.Text);

                if (dt != null && dt.Rows.Count > 0)
                {
                    try
                    {
                        mp.ExportarReportePacientesExcel(dt, saveFileDialog.FileName);
                        MessageBox.Show("Reporte generado con éxito", "Excel",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al exportar: " + ex.Message, "Error",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("No hay datos para exportar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void DtgPaciente_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void FrmPacientes_Load_1(object sender, EventArgs e) { }
    }
}