using AccesoDatos;
using Entidades;
using System;
using System.Collections.Generic;
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
    }
}
