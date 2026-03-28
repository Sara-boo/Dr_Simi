using Entidades;
using Google.Protobuf.WellKnownTypes;
using K4os.Compression.LZ4.Internal;
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
    public partial class FrmCitas : Form
    {
        ManejadorCitas mc;
        int fila = 0, columna = 0;
        public static Citas cita = new Citas(0, 0, 0, DateTime.MinValue, "", "");
        public static string curp = "";
        public static string medico = "";
        public FrmCitas()
        {
            InitializeComponent();
            mc = new ManejadorCitas();
            AplicarDiseño();
            DtgDatos.CellFormatting += DtgDatos_CellFormatting;
        }

        private void BtnFiltrar_Click(object sender, EventArgs e)
        {
            try
            {
                string consulta = "SELECT * FROM v_citas WHERE 1=1";
                if (TxtPaciente.Text != "")
                    consulta += $" AND Paciente LIKE '%{TxtPaciente.Text}%'";
                if (DtpDesdeFecha.Value.Date != DtpHastaFecha.Value.Date)
                    consulta += $" AND Fecha_Hora BETWEEN '{DtpDesdeFecha.Value:yyyy-MM-dd} 00:00:00' AND '{DtpHastaFecha.Value:yyyy-MM-dd} 23:59:59'";
                if (CmbEstado.Text != "")
                    consulta += $" AND Estado = '{CmbEstado.Text}'";
                mc.Mostrar(consulta, DtgDatos, "v_citas");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"No se pudo conectar a la base de datos.\n{ex.Message}",
                                "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BtnNuevaCita_Click(object sender, EventArgs e)
        {
            FrmRegristroCitas rc = new FrmRegristroCitas();
            rc.ShowDialog();
        }

        private void BtnCsv_Click(object sender, EventArgs e)
        {
            mc.Exportar(DtgDatos);
        }

        private void DtgDatos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex;
            columna = e.ColumnIndex;
        }

        private void DtgDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            medico = DtgDatos.Rows[fila].Cells["Medico_Asignado"].Value.ToString();
            curp = DtgDatos.Rows[fila].Cells["CURP"].Value.ToString();
            cita.IdCita = int.Parse(DtgDatos.Rows[fila].Cells["Id_Cita"].Value.ToString());
            cita.IdPaciente = int.Parse(DtgDatos.Rows[fila].Cells["Id_Paciente"].Value.ToString());
            cita.IdPersonal = int.Parse(DtgDatos.Rows[fila].Cells["Id_Personal"].Value.ToString());
            cita.FechaHora = DateTime.Parse(DtgDatos.Rows[fila].Cells["Fecha_Hora"].Value.ToString());
            cita.Estado = DtgDatos.Rows[fila].Cells["Estado"].Value.ToString();
            cita.Motivo = DtgDatos.Rows[fila].Cells["Motivo"].Value.ToString();
            switch (columna)
            {
                case 9:
                    {
                        FrmRegristroCitas rc = new FrmRegristroCitas();
                        rc.ShowDialog();
                        DtgDatos.Columns.Clear();

                    }
                    break;

            }
        }

        private void DtgDatos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // 2. Obtenemos el nombre de la columna que se está dibujando
                string nombreColumna = DtgDatos.Columns[e.ColumnIndex].Name;

                // 3. Si la columna es la de "Estado" (Asegúrate de que el nombre coincida con tu BD)
                if (nombreColumna == "Estado" || nombreColumna == "estado")
                {
                    if (e.Value != null)
                    {
                        string estado = e.Value.ToString();

                        // 4. Aplicamos los colores exactos de tu diseño objetivo
                        switch (estado)
                        {
                            case "Programada":
                                e.CellStyle.BackColor = ColorTranslator.FromHtml("#109B84"); // Verde oscuro/Teal
                                e.CellStyle.ForeColor = Color.White;
                                break;

                            case "Atendida":
                                e.CellStyle.BackColor = ColorTranslator.FromHtml("#0F5B78"); // Azul oscuro
                                e.CellStyle.ForeColor = Color.White;
                                break;

                            case "No_asistio":
                            case "No asistió": // Agrego ambas por si acaso viene con guion bajo o espacio
                                e.CellStyle.BackColor = ColorTranslator.FromHtml("#DDF0E6"); // Verde muy clarito
                                e.CellStyle.ForeColor = ColorTranslator.FromHtml("#538F6A"); // Texto verde oscuro
                                break;

                            case "Cancelada":
                                e.CellStyle.BackColor = ColorTranslator.FromHtml("#D0E7E5"); // Celeste/Gris claro
                                e.CellStyle.ForeColor = ColorTranslator.FromHtml("#678A88"); // Texto gris oscuro
                                break;
                        }

                        // Opcional: Ponemos el texto en negritas para que resalte más
                        e.CellStyle.Font = new Font(DtgDatos.Font, FontStyle.Bold);
                    }
                }
            }
        }

        private void AplicarDiseño()
        {
            ManejadorDiseño md = new ManejadorDiseño();
            this.BackColor = ColorTranslator.FromHtml("#CCECEE");

            md.EstilosBoton(BtnNuevaCita, "14967F", "FFFFFF");
            md.EstilosBoton(BtnFiltrar, "095D7E", "FFFFFF");
            md.EstilosBoton(BtnCsv, "83A69F", "FFFFFF");

            md.EstilizarTextBox(TxtPaciente, "FFFFFF", "C4D6D4");
            md.EstilizarDateTimePicker(DtpDesdeFecha, "FFFFFF", "C4D6D4");
            md.EstilizarDateTimePicker(DtpHastaFecha, "FFFFFF", "C4D6D4");

            md.EstilizarComboBox(CmbEstado, "FFFFFF", "C4D6D4");
            mc.EstilizarDataGrid(DtgDatos);
        }
    }
}
