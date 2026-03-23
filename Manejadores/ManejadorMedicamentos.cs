using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using AccesoDatos;
using System.Windows.Forms;

namespace Manejadores
{
    public class ManejadorMedicamentos
    {
        Base b = new Base();
        public void GuardarMedicamento(Medicamentos medicamento)
        {
            int requiere = medicamento.RequiereReceta ? 1 : 0;
            b.Comando($"call p_registrar_medicamentos('{medicamento.Nombre}', '{medicamento.Descripcion}', '{medicamento.Tipo}', '{medicamento.Presentacion}', '{medicamento.Concentracion}', {requiere})");
        }
    }
}
