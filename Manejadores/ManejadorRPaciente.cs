using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using AccesoDatos;
using Entidades;

namespace Manejadores
{
    public class ManejadorRPaciente
    {
        Base b = new Base();

        public void Guardar(Paciente paciente)
        {
            b.Comando($"INSERT INTO tbl_pacientes (curp, nombre_completo, fecha_nacimiento, sexo, telefono, correo, direccion, tipo_sangre, alergias, enfermedades_cronicas, fecha_registro, activo) " +
                      $"VALUES('{paciente.Curp}', '{paciente.NombreCompleto}', '{paciente.FechaNacimiento:yyyy-MM-dd}', " +
                      $"'{paciente.Sexo}', '{paciente.Telefono}', '{paciente.Correo}', '{paciente.Direccion}', " +
                      $"'{paciente.TipoSangre}', '{paciente.Alergias}', '{paciente.EnfermedadesCronicas}', now(), true)");

            MessageBox.Show("Paciente registrado con éxito", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void Modificar(Paciente paciente)
        {
            b.Comando($"UPDATE tbl_pacientes SET " +
                      $"nombre_completo='{paciente.NombreCompleto}', " +
                      $"curp='{paciente.Curp}', " +
                      $"fecha_nacimiento='{paciente.FechaNacimiento:yyyy-MM-dd}', " +
                      $"sexo='{paciente.Sexo}', " +
                      $"telefono='{paciente.Telefono}', " +
                      $"correo='{paciente.Correo}', " +
                      $"direccion='{paciente.Direccion}', " +
                      $"tipo_sangre='{paciente.TipoSangre}', " +
                      $"alergias='{paciente.Alergias}', " +
                      $"enfermedades_cronicas='{paciente.EnfermedadesCronicas}', " +
                      $"updated_at=now() " +
                      $"WHERE id_paciente = {paciente.IdPaciente}");

            MessageBox.Show("Información modificada correctamente", "Actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void Mostrar(DataGridView tabla, string filtro, Image imgEdit, Image imgDel)
        {
            tabla.Columns.Clear();

            string consulta = "SELECT id_paciente AS ID, nombre_completo AS Nombre, curp AS CURP, " +
                              "fecha_nacimiento, " +
                              "TIMESTAMPDIFF(YEAR, fecha_nacimiento, CURDATE()) AS Edad, " +
                              "sexo AS Sexo, tipo_sangre AS Sangre, enfermedades_cronicas AS 'Enf. Crónicas', " +
                              "alergias AS Alergias, direccion AS Dirección, correo AS Correo, telefono AS Teléfono " +
                              $"FROM tbl_pacientes WHERE curp LIKE '%{filtro}%' AND activo = true";

            tabla.DataSource = b.Consultar(consulta, "tbl_pacientes").Tables[0];

            if (tabla.Columns.Contains("ID")) tabla.Columns["ID"].Visible = false;
            if (tabla.Columns.Contains("fecha_nacimiento")) tabla.Columns["fecha_nacimiento"].Visible = false;

            DataGridViewImageColumn colEditar = new DataGridViewImageColumn();
            colEditar.Image = imgEdit;
            colEditar.Name = "Modificar";
            colEditar.HeaderText = "Editar";
            colEditar.ImageLayout = DataGridViewImageCellLayout.Zoom;
            colEditar.DefaultCellStyle.Padding = new Padding(4); 

            DataGridViewImageColumn colBorrar = new DataGridViewImageColumn();
            colBorrar.Image = imgDel;
            colBorrar.Name = "Borrar";
            colBorrar.HeaderText = "Eliminar";
            colBorrar.ImageLayout = DataGridViewImageCellLayout.Zoom;
            colBorrar.DefaultCellStyle.Padding = new Padding(4);

            tabla.Columns.Add(colEditar);
            tabla.Columns.Add(colBorrar);

            colEditar.DisplayIndex = 0;
            colBorrar.DisplayIndex = 1;

            tabla.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(45, 66, 91);
            tabla.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            tabla.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(45, 66, 91);
            tabla.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            tabla.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            tabla.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            tabla.DefaultCellStyle.Font = new Font("Segoe UI", 9);
            tabla.DefaultCellStyle.SelectionBackColor = Color.FromArgb(30, 144, 255);
            tabla.DefaultCellStyle.SelectionForeColor = Color.White;
            tabla.BackgroundColor = Color.White;
            tabla.GridColor = Color.FromArgb(210, 210, 210);

            tabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            tabla.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tabla.RowHeadersVisible = false;
            tabla.EnableHeadersVisualStyles = false;

            tabla.RowTemplate.Height = 35;
            foreach (DataGridViewRow fila in tabla.Rows)
            {
                fila.Height = 35;
            }

            tabla.AutoResizeColumns();
        }

        public void Borrar(int id, string nombre)
        {
            var r = MessageBox.Show($"¿Seguro que quiere borrar los datos de {nombre}?", "Confirmar",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (r == DialogResult.Yes)
            {
                b.Comando($"UPDATE tbl_pacientes SET activo = false WHERE id_paciente = {id}");
                MessageBox.Show("Registro eliminado");
            }
        }

        public System.Data.DataTable ObtenerDatosReporte(string filtro)
        {
            string consulta = "SELECT id_paciente AS ID, nombre_completo AS Nombre, curp AS CURP, " +
                              "fecha_nacimiento AS 'Fecha Nacimiento', sexo AS Sexo, tipo_sangre AS Sangre, " +
                              "enfermedades_cronicas AS 'Enf. Crónicas', alergias AS Alergias, " +
                              "direccion AS Dirección, correo AS Correo, telefono AS Teléfono " +
                              $"FROM tbl_pacientes WHERE curp LIKE '%{filtro}%' AND activo = true";
            return b.Consultar(consulta, "tbl_pacientes").Tables[0];
        }

        public void ExportarReportePacientesExcel(System.Data.DataTable dt, string rutaArchivo)
        {
            Microsoft.Office.Interop.Excel.Application excelApp = null;
            Excel.Workbooks workbooks = null;
            Excel.Workbook workbook = null;
            Excel._Worksheet workSheet = null;

            try
            {
                excelApp = new Excel.Application();
                workbooks = excelApp.Workbooks;
                workbook = workbooks.Add();
                workSheet = excelApp.ActiveSheet;

                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    var cell = (Excel.Range)workSheet.Cells[1, i + 1];
                    cell.Value = dt.Columns[i].ColumnName;
                    cell.Font.Bold = true;
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(cell);
                }

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    for (int j = 0; j < dt.Columns.Count; j++)
                    {
                        workSheet.Cells[i + 2, j + 1] = dt.Rows[i][j].ToString();
                    }
                }

                workSheet.SaveAs(rutaArchivo);
                workbook.Close(false);
                excelApp.Quit();
            }
            finally
            {
                if (workSheet != null) System.Runtime.InteropServices.Marshal.ReleaseComObject(workSheet);
                if (workbook != null) System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook);
                if (workbooks != null) System.Runtime.InteropServices.Marshal.ReleaseComObject(workbooks);
                if (excelApp != null) System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);

                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
        }
    }
}