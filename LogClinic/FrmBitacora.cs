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
            string sql;
            int id = FrmInicioSesion.IdUsuarioLogueado;
            string rol = FrmInicioSesion.RolUsuarioLogueado;

            if (rol == "Admin")
            {
                sql = "SELECT * FROM v_bitacora";
            }
            else
            {
                sql = $"SELECT * FROM v_bitacora WHERE fkid_usuario = {id}";
            }

            // Llamamos a tu método genérico
            mb.Mostrar(sql, DtgDatos, "v_bitacora");
        }
    }
}
