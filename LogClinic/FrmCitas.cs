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
        public static Citas cita = new Citas(0, 0, 0, DateTime.MinValue, "");
        public static string curp = "";
        public static string medico = "";
        public FrmCitas()
        {
            InitializeComponent();
            mc = new ManejadorCitas();
            mc.EstilizarDataGrid(DtgDatos);
            DtgDatos.CellFormatting += DtgDatos_CellFormatting;
        }

        private void BtnFiltrar_Click(object sender, EventArgs e)
        {
            try
            {
                int estadoFiltro = 0;
                if (!string.IsNullOrWhiteSpace(TxtPaciente.Text))
                    estadoFiltro += 1;
                if (DtpDesdeFecha.Value.Date != DtpHastaFecha.Value.Date)
                    estadoFiltro += 2;
                if (!string.IsNullOrWhiteSpace(CmbEstado.Text))
                    estadoFiltro += 4;
                string consulta = "SELECT * FROM v_citas";
                string filtroTexto = $"(Paciente LIKE '%{TxtPaciente.Text}%' OR CURP LIKE '%{TxtPaciente.Text}%')";
                string filtroFecha = $"Fecha_Hora BETWEEN '{DtpDesdeFecha.Value:yyyy-MM-dd} 00:00:00' AND '{DtpHastaFecha.Value:yyyy-MM-dd} 23:59:59'";
                string filtroEstado = $"Estado = '{CmbEstado.Text}'";
                switch (estadoFiltro)
                {
                    case 0: 
                        break;

                    case 1: 
                        consulta += $" WHERE {filtroTexto}";
                        break;

                    case 2:
                        consulta += $" WHERE {filtroFecha}";
                        break;

                    case 3:
                        consulta += $" WHERE {filtroTexto} AND {filtroFecha}";
                        break;

                    case 4:
                        consulta += $" WHERE {filtroEstado}";
                        break;

                    case 5: 
                        consulta += $" WHERE {filtroTexto} AND {filtroEstado}";
                        break;

                    case 6: 
                        consulta += $" WHERE {filtroFecha} AND {filtroEstado}";
                        break;

                    case 7:
                        consulta += $" WHERE {filtroTexto} AND {filtroFecha} AND {filtroEstado}";
                        break;
                }

                mc.Mostrar(consulta, DtgDatos, "v_citas");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"No se pudo conectar a la base de datos.\n{ex.Message}", "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BtnNuevaCita_Click(object sender, EventArgs e)
        {
            FrmRegristroCitas rc = new FrmRegristroCitas();
            rc.ShowDialog();
        }

        private void BtnCsv_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Excel files (*.xlsx)|*.xlsx",
                Title = "Guardar Reporte de Citas",
                FileName = "Reporte Citas.xlsx" // Nombre por defecto 
            };
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Llamar al método del manejador, pasándole la tabla y la ruta elegida
                mc.Exportar(DtgDatos, saveFileDialog.FileName);
            }
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
            switch (columna)
            {
                case 8:
                    {
                        FrmRegristroCitas rc = new FrmRegristroCitas();
                        rc.ShowDialog();
                        DtgDatos.Columns.Clear();

                    }
                    break;
                case 9: 
                    {
                        if (cita.Estado == "Programada")
                        {
                            DialogResult result = MessageBox.Show("¿Desea agregar el tratamiento para esta cita?", "Atender Cita", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                            if (result == DialogResult.Yes)
                            {
                                string nombrePaciente= DtgDatos.Rows[fila].Cells["Paciente"].Value.ToString();
                                FrmTratamiento ft = new FrmTratamiento(cita.IdPaciente,cita.IdCita,nombrePaciente);
                                ft.ShowDialog();
                                BtnFiltrar.PerformClick();
                            }
                        }
                        else
                        {
                            MessageBox.Show($"No se puede agregar un tratamiento a esta cita porque su estado es: {cita.Estado}.", "Acción no permitida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    break;

            }
        }

        private void DtgDatos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                string nombreColumna = DtgDatos.Columns[e.ColumnIndex].Name;

                if (nombreColumna == "Estado" )
                {
                    if (e.Value != null)
                    {
                        string estado = e.Value.ToString();

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
                        e.CellStyle.Font = new Font(DtgDatos.Font, FontStyle.Bold);
                    }
                }
                if (e.ColumnIndex == 9)
                {
                    string estado = DtgDatos.Rows[e.RowIndex].Cells["Estado"].Value?.ToString();

                    if (estado != "Programada")
                    {
                        e.CellStyle.BackColor = Color.FromArgb(224, 224, 224); 
                        e.CellStyle.ForeColor = Color.Gray; 
                        e.CellStyle.SelectionBackColor = Color.FromArgb(224, 224, 224);
                        e.CellStyle.SelectionForeColor = Color.Gray;
                    }
                }
            }
        }
    }
}
