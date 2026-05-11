using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DetalleTratamiento
    {
        public DetalleTratamiento(int id_detalle, int fkid_tratamiento, int fkid_medicamento, string nombreParaMostrar, int cantidad, string dosis, string frecuencia, string duracion)
        {
            Id_detalle = id_detalle;
            Fkid_tratamiento = fkid_tratamiento;
            Fkid_medicamento = fkid_medicamento;
            NombreParaMostrar = nombreParaMostrar;
            Cantidad = cantidad;
            Dosis = dosis;
            Frecuencia = frecuencia;
            Duracion = duracion;
        }

        public int Id_detalle { get; set; }
        public int Fkid_tratamiento { get; set; }
        public int Fkid_medicamento { get; set; }
        public string NombreParaMostrar { get; set; }
        public int Cantidad { get; set; }
        public string Dosis { get; set; }
        public string Frecuencia { get; set; }
        public string Duracion { get; set; }
    }
}
