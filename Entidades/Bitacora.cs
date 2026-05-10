using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Bitacora
    {
        public Bitacora(int idBitacora, int fkid_Usuario, string accion, string fecha)
        {
            IdBitacora = idBitacora;
            Fkid_Usuario = fkid_Usuario;
            Accion = accion;
            Fecha = fecha;
        }

        public int IdBitacora { get; set; }
        public int Fkid_Usuario { get; set; }
        public string Accion { get; set; }
        public string Fecha { get; set; }
    }
}
