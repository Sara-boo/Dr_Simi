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
        public void RegistrarAjusteStock(int idInventario, int NuevaCantidad, string Tipo, string motivo, int usuario)
        {
            try
            {
                // 1. Calculamos la operación para el UPDATE
                string operacion = (Tipo == "Entrada") ? "+" : "-";
                string sqlStock = $"UPDATE tbl_inventario SET stock_actual = stock_actual {operacion} {NuevaCantidad} WHERE id_inventario = {idInventario};";

                // Ejecutamos el update manteniendo la conexión abierta para el siguiente paso
                b.Comando(sqlStock, true);

                // 2. Insertamos el rastro en tbl_movimientos_inventario
                // Usamos la variable global de tu FrmInicioSesion
                string sqlMovimiento = $"INSERT INTO tbl_movimientos_inventario (fkid_inventario, tipo_movimiento, cantidad, motivo, fkid_usuario) " +
                                       $"VALUES ({idInventario}, '{Tipo}', {NuevaCantidad}, '{motivo}', {usuario});";

                b.Comando(sqlMovimiento, true);

                // 3. Cierre de seguridad (ejecutamos una consulta simple para cerrar la conexión)
                b.Consultar("SELECT 1", "dual", false);
            }
            catch (Exception ex)
            {
                // Si algo falla, cerramos la conexión por seguridad
                b.Consultar("SELECT 1", "dual", false);
                throw new Exception("Error al registrar el movimiento: " + ex.Message);
            }
        }
    }
}
