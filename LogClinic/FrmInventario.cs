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
        int fila = 0;
        int columna = 0;
        
        public FrmInventario()
        {
            InitializeComponent();
            mi=new ManejadorInventario();
        }

        private void btnAgregarInventario_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            mi.Mostrar($"SELECT * FROM v_mostrar_inventario where nombre like '%{txtBuscar.Text}%'",dtgDatos,"v_mostrar_inventario");
        }

        private void dtgDatos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex;
            columna = e.ColumnIndex;
        }

        private void dtgDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            inventario.IdInventario = int.Parse(dtgDatos.Rows[fila].Cells[0].Value.ToString());

        }
    }
}
