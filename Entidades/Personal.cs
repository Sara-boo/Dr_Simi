using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Personal
    {
        public Personal(int idPersonal, string nombre, string apellido, string telefono, string correo, string especialidad, string estado, int fkidRol)
        {
            IdPersonal = idPersonal;
            Nombre = nombre;
            Apellido = apellido;
            Telefono = telefono;
            Correo = correo;
            Especialidad = especialidad;
            Estado = estado;
            FkidRol = fkidRol;
        }

        public int IdPersonal { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string Especialidad { get; set; }
        public string Estado { get; set; }
        public int FkidRol { get; set; }
    }
}
