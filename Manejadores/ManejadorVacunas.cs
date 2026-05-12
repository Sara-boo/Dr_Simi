using AccesoDatos;
using Entidades;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTable = System.Data.DataTable;

namespace Manejadores
{
    public class ManejadorVacunas
    {
        Base b = new Base();
        public void AplicarVacuna(int idInventario, int idUsuario)
        {
            // Llamamos al procedimiento
            b.Comando($"CALL p_registrar_vacunacion({idInventario}, {idUsuario})");
        }
        // ManejadorVacunas.cs
        public DataTable ObtenerVacunas()
        {
            DataSet ds = b.Consultar("SELECT id_inventario, nombre_vacuna FROM v_catalogo_vacunas", "vacunas");
            return ds.Tables["vacunas"];
        }

    } 
}
