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

            b.Comando($"CALL p_insertar_cita({cita.IdPaciente}, {cita.IdPersonal}, '{cita.FechaHora:yyyy-MM-dd HH:mm:ss}', '{cita.Motivo}');");
        }

        public void Editar(Citas cita)
        {
            b.Comando($"CALL p_editar_cita({cita.IdCita},{cita.IdPaciente},{cita.IdPersonal},'{cita.FechaHora:yyyy-MM-dd HH:mm:ss}','{cita.Estado}','{cita.Motivo}');");
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
            tabla.Columns.Insert(9, Boton("Modificar", ColorTranslator.FromHtml("#83A69F")));
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
            btn.FlatStyle = FlatStyle.Popup;
            btn.DefaultCellStyle.BackColor = fondo;
            btn.DefaultCellStyle.ForeColor = Color.White;
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
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Lucida Bright", 11F, FontStyle.Bold);
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.ColumnHeadersHeight = 45;

            //Estilo de las filas
            dgv.DefaultCellStyle.BackColor = Color.White;
            dgv.DefaultCellStyle.ForeColor = Color.Black;
            dgv.DefaultCellStyle.Font = new Font("Lucida Bright", 10F, FontStyle.Regular);
            dgv.DefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#CCECEE"); // Un verde/gris muy sutil al seleccionar
            dgv.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgv.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            //Altura de las filas
            dgv.RowTemplate.Height = 50; // Filas más altas para que no se vea tan feo
            dgv.DefaultCellStyle.Padding = new Padding(5); // Margen interno
        }
        public void Exportar(DataGridView tabla)
        {
            Excel.Application excelApp = new Excel.Application();
            Excel.Workbook excelWorkbook = null;
            Excel.Worksheet excelWorkSheet = null;
            try
            {
                //crear una nueva instancia de Excel
                excelApp = new Excel.Application();
                excelWorkbook = excelApp.Workbooks.Add();
                excelWorkSheet = (Excel.Worksheet)excelWorkbook.Sheets[1];
                excelApp.Visible = false; //no mostrar excel durante la exportacion

                //exportar encabezados de la columna
                for (int i = 0; i < tabla.Rows.Count; i++)
                {
                    for (int j = 0; j < tabla.Columns.Count; j++)
                    {
                        excelWorkSheet.Cells[i + 2, j + 1] = tabla.Rows[i].Cells[j].Value.ToString();
                    }
                }
                // configurar el nombre y la ubicación del archivo excel
                string filePath = @"C:\Users\Sara Avila\OneDrive - tecmm.edu.mx\Escritorio\LogClinic\citas.xlsx";//cambia la ruta donde se va guardar
                excelWorkbook.SaveAs(filePath);

                //MENSAJE DE CONFIRMACIÓN
                MessageBox.Show("El archivo se guardo en :" + filePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al exportar a Excel" + ex.Message);
            }
            finally
            {
                //liberar los recuersos de excel
                if (excelWorkbook != null) excelWorkbook.Close(false);
                if (excelApp != null) excelApp.Quit();

                //liberrar los objetos COM
                Marshal.ReleaseComObject(excelWorkSheet);
                Marshal.ReleaseComObject(excelWorkbook);
                Marshal.ReleaseComObject(excelApp);
            }
        }
    }
}
