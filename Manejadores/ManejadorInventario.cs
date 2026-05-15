using AccesoDatos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Manejadores
{
    public class ManejadorInventario
    {
        Base b = new Base();
        public void Mostrar(string consulta, DataGridView tabla, string datos)
        {
            tabla.DataSource = null;
            tabla.Columns.Clear();
            tabla.DataSource = b.Consultar(consulta, datos).Tables[0];

            tabla.EnableHeadersVisualStyles = false;

            tabla.DefaultCellStyle.Font = new Font("Lucida Bright", 10, FontStyle.Regular);
            tabla.Columns["id_inventario"].Visible = false;
            tabla.Columns["id_medicamento"].Visible = false;
            tabla.Columns["estatus"].Visible = false;

            // Estilo de los Encabezados (Azul Oscuro)
            tabla.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(45, 66, 91);
            tabla.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            tabla.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(45, 66, 91);
            tabla.ColumnHeadersDefaultCellStyle.Font = new Font("Javanese Text", 10, FontStyle.Bold);
            tabla.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            tabla.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            tabla.ColumnHeadersHeight = 40;

            tabla.DefaultCellStyle.Font = new Font("Javanese Text", 9);
            tabla.DefaultCellStyle.SelectionBackColor = Color.FromArgb(30, 144, 255);
            tabla.DefaultCellStyle.SelectionForeColor = Color.White;
            tabla.BackgroundColor = Color.White;
            tabla.GridColor = Color.FromArgb(210, 210, 210);

            tabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tabla.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tabla.RowHeadersVisible = false; // Ocultar la columna gris de la izquierda


            tabla.Columns.Insert(1,Boton("Editar", Color.Orange));
            tabla.Columns.Insert(2, Boton("Borrar", Color.Red));
            tabla.Columns.Insert(3, Boton("Detalles", Color.SkyBlue));
            tabla.AutoResizeColumns();
            tabla.AutoResizeRows();
        }
        
        public static DataGridViewButtonColumn Boton(string titulo, Color fondo)
        {
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.Text = titulo;
            btn.UseColumnTextForButtonValue = true;
            btn.FlatStyle = FlatStyle.Popup;
            btn.DefaultCellStyle.BackColor = fondo;
            btn.DefaultCellStyle.ForeColor = Color.White;
            btn.DefaultCellStyle.Font = new Font("Lucida Bright", 10, FontStyle.Bold);
            return btn;
        }
        public void RegistrarMovimiento(int idInv, int cant, string tipo, string motivo, int idUser)
        {
            try
            {
                b.Comando($"CALL p_eliminar_o_ajustar_stock({idInv}, {cant}, '{tipo}', '{motivo}', {idUser})");
            }
            catch (Exception ex)
            {
                throw new Exception("Oucrrió un error inesperado: " + ex.Message);
            }
        }
        public void ExportarInventarioExcel(System.Data.DataTable dt, string rutaArchivo)
        {
            Excel.Application excelApp = null;
            Excel.Workbooks workbooks = null;
            Excel.Workbook workbook = null;
            Excel._Worksheet workSheet = null;

            try
            {
                excelApp = new Excel.Application();
                workbooks = excelApp.Workbooks;
                workbook = workbooks.Add();
                workSheet = excelApp.ActiveSheet;
                workSheet.Name = "Reporte de Inventario";

                // 1. Encabezados
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    var cell = (Excel.Range)workSheet.Cells[1, i + 1];
                    cell.Value = dt.Columns[i].ColumnName;
                    cell.Font.Bold = true;
                    cell.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightBlue); // Color al encabezado
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(cell);
                }

                // 2. Datos
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    for (int j = 0; j < dt.Columns.Count; j++)
                    {
                        workSheet.Cells[i + 2, j + 1] = dt.Rows[i][j].ToString();
                    }
                }

                // 3. Formateo: Autoajustar columnas para que se lea bien
                Excel.Range fullRange = workSheet.UsedRange;
                fullRange.Columns.AutoFit();
                System.Runtime.InteropServices.Marshal.ReleaseComObject(fullRange);

                // 4. Guardar y Cerrar
                workbook.SaveAs(rutaArchivo);
                workbook.Close(false);
                excelApp.Quit();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al exportar a Excel: " + ex.Message);
            }
            finally
            {
                // Liberación de recursos COM (importante para que no se quede abierto Excel en segundo plano)
                if (workSheet != null) System.Runtime.InteropServices.Marshal.ReleaseComObject(workSheet);
                if (workbook != null) System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook);
                if (workbooks != null) System.Runtime.InteropServices.Marshal.ReleaseComObject(workbooks);
                if (excelApp != null) System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);

                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
        }
        public System.Data.DataTable ObtenerDatosInventario(string filtro)
        {
            string consulta = $@"SELECT 
                        nombre AS 'Medicamento', 
                        tipo AS 'Categoría', 
                        presentacion AS 'Presentación',
                        lote AS 'Lote', 
                        fecha_caducidad AS 'Fecha Caducidad',
                        stock_actual AS 'Stock Actual',
                        ubicacion AS 'Ubicación'
                      FROM v_mostrar_inventario 
                      WHERE nombre LIKE '%{filtro}%' 
                      ORDER BY nombre ASC";

            return b.Consultar(consulta, "v_mostrar_inventario", false).Tables[0];
        }
    }
}
