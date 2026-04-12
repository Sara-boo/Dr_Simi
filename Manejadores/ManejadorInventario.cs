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
    public class ManejadorInventario
    {
        Base b = new Base();
        public void Mostrar(string consulta, DataGridView tabla, string datos)
        {
            tabla.Columns.Clear();
            tabla.DefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            tabla.DataSource = b.Consultar(consulta, datos).Tables[0];
            tabla.Columns["id_inventario"].Visible = false;
            tabla.Columns["id_medicamento"].Visible = false;
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
            btn.DefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            return btn;
        }
    }
}
