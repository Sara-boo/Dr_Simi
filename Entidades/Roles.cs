using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Roles
    {
        public Roles(int idRol, string nombreRol, string descripcion)
        {
            IdRol = idRol;
            NombreRol = nombreRol;
            Descripcion = descripcion;
        }

        public int IdRol { get; set; }
        public string NombreRol { get; set; }
        public string Descripcion { get; set; }
    }
}
