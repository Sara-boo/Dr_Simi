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
        public static Inventario inventario = new Inventario(0, 0, "", "", 0, 0, "", 0);
        public static Medicamentos mSeleccionado= new Medicamentos(0, "", "", "", "", "", false);
        int fila = 0;
        int columna = 0;
        
        public FrmInventario()
        {
            InitializeComponent();
            mi=new ManejadorInventario();
        }

        private void btnAgregarInventario_Click(object sender, EventArgs e)
        {
            FrmRegistroMedicamentos rm = new FrmRegistroMedicamentos();
            rm.ShowDialog();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            mi.Mostrar($"SELECT * FROM v_inventario where nombre like '%{txtBuscar.Text}%'",dtgDatos,"v_inventario");
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
            mSeleccionado.Descripcion = dtgDatos.Rows[e.RowIndex].Cells["Descripcion"].Value.ToString();
            mSeleccionado.Tipo = dtgDatos.Rows[e.RowIndex].Cells["Tipo"].Value.ToString();
            mSeleccionado.Presentacion = dtgDatos.Rows[e.RowIndex].Cells["Presentacion"].Value.ToString();
            mSeleccionado.Concentracion = dtgDatos.Rows[e.RowIndex].Cells["Concentracion"].Value.ToString();
            mSeleccionado.RequiereReceta = Convert.ToBoolean(dtgDatos.Rows[e.RowIndex].Cells["RequiereReceta"].Value);
            switch (e.ColumnIndex)
            {
                case 1:
                    FrmRegistroMedicamentos rm = new FrmRegistroMedicamentos();
                    
                    rm.ShowDialog();
                    break;
                case 2:
                    DialogResult result = MessageBox.Show("¿Está seguro de eliminar este registro?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        mi.RegistrarAjusteStock(inventario.IdInventario, inventario.Cantidad, "Salida", "Eliminación de inventario",FrmInicioSesion.IdUsuarioLogueado);
                        MessageBox.Show("Registro eliminado exitosamente.");
                    }
                    break;
                case 3:
                    FrmMovimientosInventario fm = new FrmMovimientosInventario(inventario.IdInventario);
                    fm.ShowDialog();
                    break;
            }
        }
    }
}
