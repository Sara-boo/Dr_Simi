using AccesoDatos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manejadores
{
    public class ManejadorBitacora
    {
        Base b = new Base();
        public void GuardarBitacora(int idUsuario, string accion)
        {
            try
            {
                b.Comando($"CALL p_registrar_bitacora({idUsuario}, '{accion.Replace("'", "''")}')");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en Bitácora: " + ex.Message);
            }
        }
        public void Mostrar(string consulta, DataGridView tabla, string datos)
        {
            tabla.DataSource = null;
            tabla.Columns.Clear();
            tabla.DataSource = b.Consultar(consulta, datos).Tables[0];

            // Forma segura de ocultar columnas sin que la app se cierre
            if (tabla.Columns.Contains("fkid_usuario"))
                tabla.Columns["fkid_usuario"].Visible = false;

            if (tabla.Columns.Contains("id_usuario"))
                tabla.Columns["id_usuario"].Visible = false;

            tabla.EnableHeadersVisualStyles = false;


            tabla.DefaultCellStyle.Font = new Font("LucidaBrigth", 10, FontStyle.Regular);

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

            tabla.AutoResizeColumns();
            tabla.AutoResizeRows();
            //tabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
