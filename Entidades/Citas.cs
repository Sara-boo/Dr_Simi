using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Citas 
    {
        public Citas(int idCita, int idPaciente, int idPersonal, DateTime fechaHora, string estado, string motivo)
        {
            IdCita = idCita;
            IdPaciente = idPaciente;
            IdPersonal = idPersonal;
            FechaHora = fechaHora;
            Estado = estado;
            Motivo = motivo;
        }

        public int IdCita { get; set; }
        public int IdPaciente { get; set; }
        public int IdPersonal { get; set; }
        public DateTime FechaHora { get; set; }
        public string Estado { get; set; }
        public string Motivo { get; set; }
    }
}
