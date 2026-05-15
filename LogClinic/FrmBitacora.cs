using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Manejadores;
using Entidades;

namespace LogClinic
{
    public partial class FrmBitacora : Form
    {
        ManejadorBitacora mb;
        public FrmBitacora()
        {
            mb = new ManejadorBitacora();
            InitializeComponent();
        }

        private void FrmBitacora_Load(object sender, EventArgs e)
        {
            int id = FrmInicioSesion.IdUsuarioLogueado;
            string rol = FrmInicioSesion.RolUsuarioLogueado;
            string sql;

            if (rol == "Administrador")
            {
                sql = "SELECT * FROM v_bitacora WHERE DATE(Fecha) = CURDATE() ORDER BY Fecha DESC";
            }
            else
            {
                sql = $"SELECT * FROM v_bitacora WHERE fkid_usuario = {id} AND DATE(Fecha) = CURDATE() ORDER BY Fecha DESC";
            }

            mb.Mostrar(sql, DtgDatos, "v_bitacora");
        }
    }
}
