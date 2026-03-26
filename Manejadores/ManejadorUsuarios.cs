using AccesoDatos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manejadores
{
    public class ManejadorUsuarios
    {
        Base b = new Base();
        public void Guardar(Usuarios usuario)
        {
            b.Comando($"CALL p_insertar_usuario('{usuario.UserName}', '{usuario.Password}',{usuario.IdPersonal})");
        }

        public void Editar(Usuarios usuario)
        {
            b.Comando($"CALL p_editar_usuario({usuario.IdUsuario}, '{usuario.UserName}', '{usuario.Password}',{usuario.IdPersonal})");
        }

        public void Estado(Usuarios usuario)
        {
            var rs = MessageBox.Show($"Esta seguro de desactivar al usuario {usuario.UserName}", "ATENCION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                b.Comando($"CALL p_estado_usuario({usuario.IdUsuario})");
            }
        }
        public void Mostrar(string consulta, DataGridView tabla, string datos)
        {
            tabla.Columns.Clear();
            tabla.DataSource = b.Consultar(consulta, datos).Tables[0];
            tabla.Columns["Id_cita"].Visible = false;
            tabla.Columns["Password"].Visible = false;
            tabla.Columns["created_at"].Visible = false;
            tabla.Columns["updated_at"].Visible = false;
            tabla.Columns["Activo"].Visible = false;
            tabla.Columns.Insert(2, Boton("Editar", Color.Green));
            if (tabla.Rows.Count > 0)
            {
                bool estado = Convert.ToBoolean(tabla.Rows[0].Cells["Activo"].Value);
                if (estado)
                {
                    tabla.Columns.Insert(3, Boton("Desasctivar", Color.Red));
                }
                else
                {
                    tabla.Columns.Insert(3, Boton("Activar", Color.Blue));
                }
            }
            tabla.AutoResizeColumns();
            tabla.AutoResizeRows();

        }
        public static DataGridViewButtonColumn Boton(string titulo, Color fondo)
        {
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.Text = titulo;
            btn.UseColumnTextForButtonValue = true;
            btn.FlatStyle = FlatStyle.Popup;
            btn.DefaultCellStyle.BackColor = fondo;
            btn.DefaultCellStyle.ForeColor = Color.White;
            return btn;

        }
    }
}
