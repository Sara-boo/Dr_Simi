using AccesoDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Manejadores
{
    public class ManejadorHistorialClinico
    {
        Base b = new Base();
        public void Insertar(HistorialClinico hc)
        {

            b.Comando($"CALL p_insertar_hc()");
        }

        public void Editar(HistorialClinico hc)
        {
            b.Comando($"CALL p_editar_hc()");
        }
    }
}
