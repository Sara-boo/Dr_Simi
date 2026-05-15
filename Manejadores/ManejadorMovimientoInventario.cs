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

namespace Manejadores
{
    public class ManejadorMovimientoInventario
    {
        Base b = new Base();
        public void Mostrar(string consulta, DataGridView tabla, string datos)
        {
            tabla.DataSource = null;
            tabla.DataSource = b.Consultar(consulta, datos).Tables[0];

                tabla.Columns["id_movimiento"].Visible = false;
                tabla.Columns["id_inventario"].Visible = false;

            tabla.EnableHeadersVisualStyles = false;

            // Estilo de los Encabezados (Azul Oscuro)
            tabla.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(45, 66, 91); 
            tabla.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            tabla.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(45, 66, 91); 
            tabla.ColumnHeadersDefaultCellStyle.Font = new Font("Javanese Text", 10, FontStyle.Bold);
            tabla.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            tabla.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            tabla.ColumnHeadersHeight = 35;

            tabla.DefaultCellStyle.Font = new Font("Javanese Text", 9);
            tabla.DefaultCellStyle.SelectionBackColor = Color.FromArgb(30, 144, 255); 
            tabla.DefaultCellStyle.SelectionForeColor = Color.White;
            tabla.BackgroundColor = Color.White; 
            tabla.GridColor = Color.FromArgb(210, 210, 210); 

            tabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; 
            tabla.SelectionMode = DataGridViewSelectionMode.FullRowSelect; 
            tabla.RowHeadersVisible = false; // Ocultar la columna gris de la izquierda

            tabla.AutoResizeRows();
        }
    }
}
