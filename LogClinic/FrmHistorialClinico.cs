using Manejadores;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogClinic
{
    public partial class FrmHistorialClinico : Form
    {
        ManejadorHistorialClinico mhc;
        public FrmHistorialClinico()
        {
            InitializeComponent();
            mhc = new ManejadorHistorialClinico();
            LblIdPaciente.Visible= false;
            mhc.EstilizarDataGrid(DtgDatos);
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow paciente = mhc.BuscarFila($"SELECT * FROM v_perfilPaciente WHERE curp = '{TxtBuscarPaciente.Text}'", "v_perfilPaciente");

                if (paciente != null)
                {
                    LblIdPaciente.Text = paciente["id_paciente"].ToString();
                    LblNombre.Text = paciente["nombre_completo"].ToString();
                    LblCurp.Text = paciente["curp"].ToString();
                    LblEdad.Text = paciente["edad"].ToString();
                    LblSangre.Text = paciente["tipo_sangre"].ToString();
                    LblAlergias.Text = paciente["alergias"].ToString();
                    LblEnfCronicas.Text = paciente["enfermedades_cronicas"].ToString();
                }
                else
                    MessageBox.Show("Paciente no encontrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mhc.Mostrar($"select * from v_historial_paciente where id_paciente = {int.Parse(LblIdPaciente.Text)}", DtgDatos, "v_historial_paciente");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error al conectar con la base de datos.\n{ex.Message}", "Error con la conexión a MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException fex)
            {
                MessageBox.Show($"Error en entrada de datos en la caja de texto.\n{fex.Message}", "Error en el Formato de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void DtgDatos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                string nombreColumna = DtgDatos.Columns[e.ColumnIndex].Name;
                if (nombreColumna == "Fecha_Hora")
                {
                    string estado = DtgDatos.Rows[e.RowIndex].Cells["Estado"].Value?.ToString();

                    if (!string.IsNullOrEmpty(estado))
                    {
                        switch (estado)
                        {
                            case "Programada":
                                e.CellStyle.BackColor = ColorTranslator.FromHtml("#14967F");
                                e.CellStyle.ForeColor = Color.White;
                                break;

                            case "Atendida":
                                e.CellStyle.BackColor = ColorTranslator.FromHtml("#095D7E");
                                e.CellStyle.ForeColor = Color.White;
                                break;

                            case "No_asistio":
                                e.CellStyle.BackColor = ColorTranslator.FromHtml("#E2FCD6");
                                e.CellStyle.ForeColor = ColorTranslator.FromHtml("#538F6A");
                                break;

                            case "Cancelada":
                                e.CellStyle.BackColor = ColorTranslator.FromHtml("#CCECEE");
                                e.CellStyle.ForeColor = ColorTranslator.FromHtml("#678A88");
                                break;
                        }
                    }
                }
            }
        }
    }
}
