using System;
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
        }

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
            paciente.IdPaciente = 0; // Indica que es un registro nuevo
            FrmRegistroPacientes frp = new FrmRegistroPacientes();
            frp.ShowDialog();
            mp.Mostrar(DtgPaciente, TxtBCurp.Text);
        }

        private void DtgPaciente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex;
            columna = e.ColumnIndex;

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
                paciente.FechaNacimiento = Convert.ToDateTime(DtgPaciente.Rows[fila].Cells["fecha_nacimiento"].Value);



                string nombreBoton = DtgPaciente.Columns[columna].Name;

                if (nombreBoton == "Modificar")
                {
                    FrmRegistroPacientes frp = new FrmRegistroPacientes();
                    frp.ShowDialog();
                    mp.Mostrar(DtgPaciente, TxtBCurp.Text);
                }
                else if (nombreBoton == "Borrar")
                {
                   
                    mp.Borrar(paciente.IdPaciente, paciente.NombreCompleto);
                    mp.Mostrar(DtgPaciente, TxtBCurp.Text);
                }
            }
        }

      
        private void DtgPaciente_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void FrmPacientes_Load_1(object sender, EventArgs e) { }

        private void BtnReporte_Click(object sender, EventArgs e) 
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx";
            saveFileDialog.Title = "Guardar Reporte de Pacientes";
            saveFileDialog.FileName = "Reporte_Pacientes.xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
               
                System.Data.DataTable dt = mp.ObtenerDatosReporte(TxtBCurp.Text);

                if (dt.Rows.Count > 0)
                {
                    Excel.Application excelApp = new Excel.Application();
                    excelApp.Workbooks.Add();
                    Excel._Worksheet workSheet = excelApp.ActiveSheet;

                    
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        workSheet.Cells[1, i + 1] = dt.Columns[i].ColumnName;
                        workSheet.Cells[1, i + 1].Font.Bold = true;
                    }

                    
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        for (int j = 0; j < dt.Columns.Count; j++)
                        {
                            workSheet.Cells[i + 2, j + 1] = dt.Rows[i][j].ToString();
                        }
                    }

                    
                    workSheet.SaveAs(saveFileDialog.FileName);
                    excelApp.Quit();

                  
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(workSheet);
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);

                    MessageBox.Show("Reporte generado con éxito", "Excel", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No hay datos para exportar.");
                }
            }

        }
    }
}