using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Inventario
    {
        public Inventario(int idInventario, int fkidMedicamento, string lote, string fechaCaducidad, int stockActual, int stockMinimo, string ubicacion, DateTime fechaRegistro, string estatus)
        {
            IdInventario = idInventario;
            FkidMedicamento = fkidMedicamento;
            Lote = lote;
            FechaCaducidad = fechaCaducidad;
            StockActual = stockActual;
            StockMinimo = stockMinimo;
            Ubicacion = ubicacion;
            FechaRegistro = fechaRegistro;
            Estatus = estatus;
        }

        public int IdInventario { get; set; }
        public int FkidMedicamento { get; set; }
        public string Lote { get; set; }
        public string FechaCaducidad { get; set; }
        public int StockActual { get; set; }
        public int StockMinimo { get; set; }
        public string Ubicacion { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string Estatus { get; set; }
    }
}
