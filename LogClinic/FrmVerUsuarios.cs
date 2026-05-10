using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Manejadores;

namespace LogClinic
{
    public partial class FrmVerUsuarios : Form
    {
        ManejadorUsuarios mu;
        public static Usuarios usuario = new Usuarios(0, "", "", false, 0);
        int fila = 0;
        int columna = 0;

        public FrmVerUsuarios()
        {
            InitializeComponent();
            mu = new ManejadorUsuarios();
            mu.EstilizarDataGrid(DtgDatos);
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            usuario = new Usuarios(0, "", "", false, 0);
            FrmUsuarios au = new FrmUsuarios();
            au.ShowDialog();
            DtgDatos.Columns.Clear();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            mu.Mostrar($"SELECT * FROM v_usuarios WHERE Usuario LIKE '%{TxtBuscar.Text}%'", DtgDatos,"v_usuarios");
        }

        private void DtgDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            usuario.IdUsuario = Convert.ToInt32(DtgDatos.Rows[e.RowIndex].Cells["id_usuario"].Value);
            usuario.UserName = DtgDatos.Rows[e.RowIndex].Cells["Usuario"].Value.ToString();
            usuario.Password = DtgDatos.Rows[e.RowIndex].Cells["password"].Value.ToString();
            usuario.Activo = Convert.ToBoolean(DtgDatos.Rows[e.RowIndex].Cells["Estatus"].Value);
            usuario.IdPersonal = Convert.ToInt32(DtgDatos.Rows[e.RowIndex].Cells["id_personal"].Value);

            switch (e.ColumnIndex)
            {
                case 6:
                    mu.Estado(usuario);
                    mu.Mostrar($"SELECT * FROM v_usuarios WHERE Usuario LIKE '%{TxtBuscar.Text}%'", DtgDatos, "v_usuarios");
                    break;

                case 9:
                    FrmUsuarios au = new FrmUsuarios();
                    au.ShowDialog();
                    mu.Mostrar($"SELECT * FROM v_usuarios WHERE Usuario LIKE '%{TxtBuscar.Text}%'", DtgDatos, "v_usuarios");
                    break;
            }
        }

        private void DtgDatos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex;;
            columna = e.ColumnIndex;

        }

        private void FrmVerUsuarios_Load(object sender, EventArgs e)
        {
            mu.Mostrar($"SELECT * FROM v_usuarios WHERE Usuario LIKE '%{TxtBuscar.Text}%'", DtgDatos, "v_usuarios");
        }
    }
}
