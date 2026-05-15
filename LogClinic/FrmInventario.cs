using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Manejadores;
using Entidades;

namespace LogClinic
{
    public partial class FrmInventario : Form
    {
        ManejadorInventario mi;
        ManejadorBitacora mb;
        public static Inventario inventario = new Inventario(0, 0, "", "", 0, 0, "", 0);
        public static Medicamentos mSeleccionado= new Medicamentos(0, "", "", "", "", "", false);
        int fila = 0;
        int columna = 0;

        public FrmInventario()
        {
            InitializeComponent();
            mi=new ManejadorInventario();
            mb = new ManejadorBitacora();
        }

        private void btnAgregarInventario_Click(object sender, EventArgs e)
        {
            mSeleccionado.IdMedicamento = 0;
            mSeleccionado.Nombre = "";
            mSeleccionado.Descripcion = "";
            mSeleccionado.Tipo = "";
            mSeleccionado.Presentacion = "";
            mSeleccionado.Concentracion = "";
            mSeleccionado.RequiereReceta = false;
            FrmRegistroMedicamentos rm = new FrmRegistroMedicamentos();
            rm.ShowDialog();
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            mi.Mostrar($"SELECT * FROM v_inventario where nombre like '%{txtBuscar.Text}%' AND estatus='Activo'",dtgDatos,"v_inventario");
        }

        private void dtgDatos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex;
            columna = e.ColumnIndex;
        }

        private void dtgDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            // 1. Datos para el inventario (stock)
            inventario.IdInventario = int.Parse(dtgDatos.Rows[e.RowIndex].Cells["id_inventario"].Value.ToString());

            // 2. Datos para el medicamento (identidad)
            // Usamos el objeto global de Medicamentos para que el FrmRegistro los lea
            mSeleccionado.IdMedicamento = int.Parse(dtgDatos.Rows[e.RowIndex].Cells["id_medicamento"].Value.ToString());
            mSeleccionado.Nombre = dtgDatos.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
            mSeleccionado.Descripcion = dtgDatos.Rows[e.RowIndex].Cells["Descripción"].Value.ToString();
            mSeleccionado.Tipo = dtgDatos.Rows[e.RowIndex].Cells["Tipo"].Value.ToString();
            mSeleccionado.Presentacion = dtgDatos.Rows[e.RowIndex].Cells["Presentación"].Value.ToString();
            mSeleccionado.Concentracion = dtgDatos.Rows[e.RowIndex].Cells["Concentración"].Value.ToString();
            mSeleccionado.RequiereReceta = Convert.ToBoolean(dtgDatos.Rows[e.RowIndex].Cells["RequiereReceta"].Value);
            switch (e.ColumnIndex)
            {
                case 1:
                    FrmRegistroMedicamentos rm = new FrmRegistroMedicamentos();
                    rm.ShowDialog();
                    btnBuscar.PerformClick();
                    break;
                case 2:
                    DialogResult result = MessageBox.Show("¿Está seguro de eliminar este registro?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        mi.RegistrarMovimiento(
                            inventario.IdInventario,
                            inventario.Cantidad,
                            "Salida",
                            "Eliminación de inventario",
                            FrmInicioSesion.IdUsuarioLogueado
                            );
                        //  Para la bitácora, se registra la acción de eliminación con el ID del usuario logueado
                        string accion = $"Eliminación de inventario: Medicamento {mSeleccionado.Nombre}, Cantidad {inventario.Cantidad}";
                        mb.GuardarBitacora(FrmInicioSesion.IdUsuarioLogueado, accion);

                        MessageBox.Show("Registro eliminado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnBuscar.PerformClick();
                    }
                    break;
                case 3:
                    FrmMovimientosInventario fm = new FrmMovimientosInventario(inventario.IdInventario);
                    fm.ShowDialog();
                    break;
            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Excel files (*.xlsx)|*.xlsx",
                Title = "Guardar Reporte de Inventario",
                // Nombre dinámico con la fecha actual para evitar sobrescribir por error
                FileName = $"Reporte_Inventario_{DateTime.Now:ddMMyyyy}.xlsx"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                System.Data.DataTable dt = mi.ObtenerDatosInventario(txtBuscar.Text);

                if (dt != null && dt.Rows.Count > 0)
                {
                    try
                    {
                        this.Cursor = Cursors.WaitCursor;

                        mi.ExportarInventarioExcel(dt, saveFileDialog.FileName);
                        Manejadores.ManejadorBitacora mb = new Manejadores.ManejadorBitacora();
                        mb.GuardarBitacora(FrmInicioSesion.IdUsuarioLogueado, "Generó reporte de inventario");

                        this.Cursor = Cursors.Default;
                        MessageBox.Show("Reporte de inventario generado con éxito", "Excel",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        this.Cursor = Cursors.Default;
                        MessageBox.Show("Error al exportar inventario: " + ex.Message, "Error",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("No hay datos de inventario disponibles para exportar.",
                                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void FrmInventario_Load(object sender, EventArgs e)
        {
           // mi.Mostrar("SELECT * FROM v_inventario", dtgDatos, "v_inventario");
        }
    }
}
