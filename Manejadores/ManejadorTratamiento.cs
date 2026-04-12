using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccesoDatos;
using Entidades;
using Manejadores;

namespace Manejadores
{
    public class ManejadorTratamiento
    {
        Base b = new Base();
        public void MostrarAlergiasEnfermedades(string consulta, DataGridView tabla, string datos)
        {
            tabla.Columns.Clear();
            tabla.DataSource = b.Consultar(consulta, datos).Tables[0];
            tabla.AutoResizeColumns();
            tabla.AutoResizeRows();
        }
    }
}
