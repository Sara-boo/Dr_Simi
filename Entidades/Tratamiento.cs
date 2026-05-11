using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Tratamiento
    {
        public Tratamiento(int id_tratamiento, int fkid_historial, string descripcion, string fecha_Registro, int fkid_usuario)
        {
            Id_tratamiento = id_tratamiento;
            Fkid_historial = fkid_historial;
            Descripcion = descripcion;
            Fecha_Registro = fecha_Registro;
            Fkid_usuario = fkid_usuario;
        }

        public int Id_tratamiento { get; set; }
        public int Fkid_historial { get; set; }
        public string Descripcion { get; set; }
        public string Fecha_Registro { get; set; }
        public int Fkid_usuario { get; set; }
    }
}
