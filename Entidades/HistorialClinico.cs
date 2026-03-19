using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class HistorialClinico
    {
        public HistorialClinico(int idHistorial, int idCita, string diagnostico, string tratamiento, string observaciones, DateTime fechaRegistro)
        {
            IdHistorial = idHistorial;
            IdCita = idCita;
            Diagnostico = diagnostico;
            Tratamiento = tratamiento;
            Observaciones = observaciones;
            FechaRegistro = fechaRegistro;
        }

        public int IdHistorial { get; set; }
        public int IdCita { get; set; }
        public string Diagnostico { get; set; }
        public string Tratamiento { get; set; }
        public string Observaciones { get; set; }
        public DateTime FechaRegistro { get; set; }

    }
}
