using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Medicamentos
    {
        public Medicamentos(int idMedicamento, string nombre, string descripcion, string tipo, string presentacion, string concentracion, bool requiereReceta)
        {
            IdMedicamento = idMedicamento;
            Nombre = nombre;
            Descripcion = descripcion;
            Tipo = tipo;
            Presentacion = presentacion;
            Concentracion = concentracion;
            RequiereReceta = requiereReceta;
        }

        public int IdMedicamento { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Tipo { get; set; }
        public string Presentacion { get; set; }
        public string Concentracion { get; set; }
        public bool RequiereReceta { get; set; }
    }
}
