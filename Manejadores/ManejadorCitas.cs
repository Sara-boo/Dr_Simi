using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using Entidades;

namespace Manejadores
{
    public class ManejadorCitas
    {
        Base b = new Base();
        public void Insertar(Citas cita)
        {

            b.Comando($"CALL p_insertar_citas()");
        }

        public void Editar(Citas cita)
        {
            b.Comando($"CALL p_editar_citas()");
        }
    }
}
