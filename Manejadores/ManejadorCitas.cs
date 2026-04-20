using AccesoDatos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Manejadores
{
    public class ManejadorCitas
    {
        Base b = new Base();
        public void Insertar(Citas cita)
        {

            b.Comando($"CALL p_insertar_cita({cita.IdPaciente}, {cita.IdPersonal}, '{cita.FechaHora:yyyy-MM-dd HH:mm:ss}');");
        }

        public void Editar(Citas cita)
        {
            b.Comando($"CALL p_editar_cita({cita.IdCita},{cita.IdPaciente},{cita.IdPersonal},'{cita.FechaHora:yyyy-MM-dd HH:mm:ss}','{cita.Estado}');");
        }
        public void Mostrar(string consulta, DataGridView tabla, string datos)
        {
            tabla.Columns.Clear();
            tabla.DataSource = b.Consultar(consulta, datos).Tables[0];
            tabla.Columns["Id_Cita"].Visible = false;
            tabla.Columns["Id_Paciente"].Visible = false;
            tabla.Columns["Id_Personal"].Visible = false;
            //tabla.Columns["created_at"].Visible = false;
            //tabla.Columns["updated_at"].Visible = false;
            tabla.Columns.Insert(8, Boton("Editar",Color.LightSteelBlue));
            tabla.Columns.Insert(9, Boton("Atender", Color.LightGray));
            tabla.AutoResizeColumns();
            tabla.AutoResizeRows();

        }
       
        public DataRow BuscarCurp(string curp)
        {
            DataTable dt = b.Consultar($"SELECT id_paciente, nombre_completo, fecha_nacimiento, tipo_sangre, alergias, enfermedades_cronicas FROM tbl_pacientes WHERE curp = '{curp}'", "tbl_pacientes").Tables[0];

            if (dt.Rows.Count > 0)
                return dt.Rows[0];
            else
                return null;
        }
        public void LlenarMedico(ComboBox caja)
        {
            caja.DataSource = b.Consultar($"select id_personal, Medico from v_CmbMedico", "v_CmbMedico").Tables[0];
            caja.DisplayMember = "Medico" ;
            caja.ValueMember = "id_personal";
        }
        public static DataGridViewButtonColumn Boton(string titulo ,Color fondo)
        {
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.Text = titulo;
            btn.UseColumnTextForButtonValue = true;
            btn.FlatStyle = FlatStyle.Flat;
            btn.DefaultCellStyle.BackColor = fondo;
            btn.DefaultCellStyle.ForeColor = ColorTranslator.FromHtml("#095D7E");
            btn.DefaultCellStyle.Font = new Font("Lucida Bright", 12F, FontStyle.Bold);
            return btn;
        }
        public void EstilizarDataGrid(DataGridView dgv)
        {
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AllowUserToResizeRows = false;
            dgv.AllowUserToResizeColumns = false;
            dgv.ReadOnly = true;
            dgv.RowHeadersVisible = false; // Oculta la columna vacía de la izquierda
            dgv.AutoResizeColumns();
            dgv.AutoResizeRows();
            dgv.MultiSelect = false;

            //Colores y bordes generales
            dgv.BorderStyle = BorderStyle.FixedSingle;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal; // Solo líneas horizontales
            dgv.GridColor = ColorTranslator.FromHtml("#B4B2B2"); // Color de las líneas divisorias 

            //Estilo del encabezado
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Lucida Bright", 14F, FontStyle.Bold);
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.ColumnHeadersHeight = 45;

            //Estilo de las filas
            dgv.DefaultCellStyle.BackColor = Color.White;
            dgv.DefaultCellStyle.ForeColor = Color.Black;
            dgv.DefaultCellStyle.Font = new Font("Lucida Bright", 12F, FontStyle.Regular);
            dgv.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            //Altura de las filas
            dgv.RowTemplate.Height = 50; // Filas más altas para que no se vea tan feo
            dgv.DefaultCellStyle.Padding = new Padding(5); // Margen interno
        }
        public void Exportar(DataGridView tabla, string filePath)
        {
            Excel.Application excelApp = null;
            Excel.Workbook excelWorkbook = null;
            Excel.Worksheet excelWorkSheet = null;

            try
            {
                excelApp = new Excel.Application();
                excelWorkbook = excelApp.Workbooks.Add();
                excelWorkSheet = (Excel.Worksheet)excelWorkbook.Sheets[1];
                excelApp.Visible = false;

                int columnaExcel = 1; //contador independiente para las columnas de Excel

                // 1. Exportar ENCABEZADOS (Omitiendo IDs y Botones)
                for (int i = 0; i < tabla.Columns.Count; i++)
                {
                    // Solo exportamos si la columna es visible Y NO es un botón
                    if (tabla.Columns[i].Visible && !(tabla.Columns[i] is DataGridViewButtonColumn))
                    {
                        excelWorkSheet.Cells[1, columnaExcel] = tabla.Columns[i].HeaderText;

                        // --- FORMATO DEL ENCABEZADO ---
                        Excel.Range celda = (Excel.Range)excelWorkSheet.Cells[1, columnaExcel];
                        celda.Font.Bold = true;
                        celda.Font.Color = System.Drawing.ColorTranslator.ToOle(Color.White); // Letra blanca
                        celda.Interior.Color = System.Drawing.ColorTranslator.ToOle(Color.FromArgb(15, 91, 120)); // Azul oscuro (estilo tu sistema)
                        Marshal.ReleaseComObject(celda);

                        columnaExcel++; //solo avanza si escribimos algo
                    }
                }

                // 2. Exportar los datos de las filas
                for (int i = 0; i < tabla.Rows.Count; i++)
                {
                    columnaExcel = 1; //reinicia la columna de excel para cada nueva fila

                    for (int j = 0; j < tabla.Columns.Count; j++)
                    {
                        // Aplicamos la misma regla: solo si es visible y no es botón
                        if (tabla.Columns[j].Visible && !(tabla.Columns[j] is DataGridViewButtonColumn))
                        {
                            if (tabla.Rows[i].Cells[j].Value != null)
                            {
                                excelWorkSheet.Cells[i + 2, columnaExcel] = tabla.Rows[i].Cells[j].Value.ToString();
                            }
                            columnaExcel++;
                        }
                    }
                }

                // 3. --- FORMATO FINAL DEL DOCUMENTO ---
                // Ajustamos el ancho de todas las columnas automáticamente para que no se corte el texto
                excelWorkSheet.Columns.AutoFit();

                // Guardar usando la ruta dinámica
                excelWorkbook.SaveAs(filePath);
                MessageBox.Show("Reporte generado con éxito.", "Exportación a Excel", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al exportar a Excel: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // 4. Limpieza robusta de memoria
                if (excelWorkSheet != null) Marshal.ReleaseComObject(excelWorkSheet);
                if (excelWorkbook != null)
                {
                    excelWorkbook.Close(false);
                    Marshal.ReleaseComObject(excelWorkbook);
                }
                if (excelApp != null)
                {
                    excelApp.Quit();
                    Marshal.ReleaseComObject(excelApp);
                }

                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
        }
    }
}
