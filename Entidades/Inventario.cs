using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Inventario
    {
        public Inventario(int idInventario, int fkidMedicamento, string lote, string fechaCaducidad, int cantidad, int stockMinimo, string ubicacion, int fkidUsuario)
        {
            IdInventario = idInventario;
            FkidMedicamento = fkidMedicamento;
            Lote = lote;
            FechaCaducidad = fechaCaducidad;
            Cantidad = cantidad;
            StockMinimo = stockMinimo;
            Ubicacion = ubicacion;
            FkidUsuario = fkidUsuario;
        }

        public int IdInventario { get; set; }
        public int FkidMedicamento { get; set; }
        public string Lote { get; set; }
        public string FechaCaducidad { get; set; }
        public int Cantidad { get; set; }
        public int StockMinimo { get; set; }
        public string Ubicacion { get; set; }
        public int FkidUsuario { get; set; }
    }
}
