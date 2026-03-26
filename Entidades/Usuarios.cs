using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuarios
    {
        public Usuarios(int idUsuario, string userName, string password, bool activo, int idPersonal)
        {
            IdUsuario = idUsuario;
            UserName = userName;
            Password = password;
            Activo = activo;
            IdPersonal = idPersonal;
        }

        public int IdUsuario { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool Activo { get; set; }
        public int IdPersonal { get; set; }
    }
}
