using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Manejadores;

namespace LogClinic
{
    public partial class FrmMovimientosInventario : Form
    {
        ManejadorMovimientoInventario mmi;
        public static MovimientosInventario movimientoInventario = new MovimientosInventario(0, 0, "", 0, "", "", 0);
        int fila = 0;
        int columna = 0;
        public FrmMovimientosInventario(int idInventario)
        {
            InitializeComponent();
            mmi = new ManejadorMovimientoInventario();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string busqueda = txtBuscar.Text;
            string filtro = cmbTipo.Text;
            string query = "SELECT * FROM v_mostrar_movimientos WHERE 1=1";

            if (!string.IsNullOrEmpty(busqueda))
            {
                query += $" AND (Medicamento LIKE '%{busqueda}%' OR Lote LIKE '%{busqueda}%')";
            }

            if (filtro != "Todos")
            {
                query += $" AND Acción = '{filtro}'";
            }

            mmi.Mostrar(query, dtgDatos, "v_mostrar_movimientos");
        }

        private void dtgDatos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex;
            columna = e.ColumnIndex;
        }

        private void dtgDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmMovimientosInventario_Load(object sender, EventArgs e)
        {
            cmbTipo.Items.Clear();
            cmbTipo.Items.Add("Todos");
            cmbTipo.Items.Add("Entrada");
            cmbTipo.Items.Add("Salida");
            cmbTipo.Items.Add("Ajuste");
            cmbTipo.SelectedIndex = 0;
        }
    }
}
