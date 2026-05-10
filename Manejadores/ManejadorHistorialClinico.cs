using AccesoDatos;
using Entidades;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataTable = System.Data.DataTable;
using Font = System.Drawing.Font;

namespace Manejadores
{
    public class ManejadorHistorialClinico
    {
        Base b = new Base();
        public DataRow BuscarFila(string consulta, string datos)
        {
            DataTable dt = b.Consultar(consulta, datos).Tables[0];
            if (dt.Rows.Count > 0)
                return dt.Rows[0];
            return null;
        }
        public void Mostrar(string consulta, DataGridView tabla, string datos)
        {
            tabla.Columns.Clear();
            tabla.DataSource = b.Consultar(consulta, datos).Tables[0];
            tabla.Columns["id_paciente"].Visible = false;
            tabla.Columns["Estado"].Visible = false;
            tabla.AutoResizeColumns();
            tabla.AutoResizeRows();
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
            dgv.BorderStyle = BorderStyle.None;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.Single; // Solo líneas horizontales
            dgv.GridColor = Color.LightGray; // Color de las líneas divisorias 

            //Estilo del encabezado
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#EDF3F5");
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Lucida Bright", 13F, FontStyle.Bold);
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.ColumnHeadersHeight = 45;

            //Estilo de las filas
            dgv.DefaultCellStyle.BackColor = Color.White;
            dgv.DefaultCellStyle.ForeColor = Color.Black;
            dgv.DefaultCellStyle.Font = new Font("Lucida Bright", 12F, FontStyle.Regular);
            dgv.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            //Altura de las filas
            dgv.RowTemplate.Height = 55; // Filas más altas para que no se vea tan feo
            dgv.DefaultCellStyle.Padding = new Padding(8); // Margen interno
        }
    }
}
