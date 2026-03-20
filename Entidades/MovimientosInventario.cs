using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class MovimientosInventario
    {
        public MovimientosInventario(int idMovimiento, int fkidMovimiento, string tipoMovimiento, int cantidad, string motivo, DateTime fecha, int fkidUsuario)
        {
            IdMovimiento = idMovimiento;
            FkidMovimiento = fkidMovimiento;
            TipoMovimiento = tipoMovimiento;
            Cantidad = cantidad;
            Motivo = motivo;
            Fecha = fecha;
            FkidUsuario = fkidUsuario;
        }

        public int IdMovimiento { get; set; }
        public int FkidMovimiento { get; set; }
        public string TipoMovimiento { get; set; }
        public int Cantidad { get; set; }
        public string Motivo { get; set; }
        public DateTime Fecha { get; set; }
        public int FkidUsuario { get; set; }
    }
}
