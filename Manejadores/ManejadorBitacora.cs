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
            tabla.Columns.Clear();
            tabla.DefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            tabla.DataSource = b.Consultar(consulta, datos).Tables[0];
            tabla.Columns["fkid_usuario"].Visible = false;
            tabla.AutoResizeColumns();
            tabla.AutoResizeRows();
            tabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
