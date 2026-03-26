using AccesoDatos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manejadores
{
    public class ManejadorMedicamentos
    {
        Base b = new Base();
        public void GuardarMedicamento(Medicamentos medicamento)
        {
            try
            {
                int requiere = medicamento.RequiereReceta ? 1 : 0;
                b.Comando($"call p_registrar_medicamentos('{medicamento.Nombre}', '{medicamento.Descripcion}', '{medicamento.Tipo}', '{medicamento.Presentacion}', '{medicamento.Concentracion}', {requiere})");
            }
            catch (Exception ex)
            {
                MessageBox.Show( ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error );
            }
        }
        public void RegistroInventario(Inventario invent)
        {
            try
            {
                b.Comando($"call p_registrar_entrada_inventario({invent.FkidMedicamento},'{invent.Lote}','{invent.FechaCaducidad}',{invent.Cantidad},{invent.StockMinimo},'{invent.Ubicacion}',{invent.FkidUsuario})");
            }
            catch (Exception ex )
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public int ObtenerUltimoIdMedicamento()
        {
            int id = 0;
            string query = "SELECT id_medicamento FROM tbl_medicamentos ORDER BY id_medicamento DESC LIMIT 1;";
            DataSet ds = b.Consultar(query, "res");

            if (ds.Tables["res"].Rows.Count > 0)
            {
                id = Convert.ToInt32(ds.Tables["res"].Rows[0][0]);
            }

            return id;
        }
    }
}
