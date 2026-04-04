using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using AccesoDatos;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Manejadores
{
    public class ManejadorMovimientoInventario
    {
        Base b = new Base();
        public void Mostrar(string consulta, DataGridView tabla, string datos)
        {
            tabla.Columns.Clear();
            tabla.DataSource = b.Consultar(consulta, datos).Tables[0];
            tabla.Columns["id_movimiento"].Visible = false;
            tabla.AutoResizeColumns();
            tabla.AutoResizeRows();
        }
    }
}
