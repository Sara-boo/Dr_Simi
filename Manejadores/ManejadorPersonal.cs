using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using AccesoDatos;
using Entidades;

namespace Manejadores
{
    public class ManejadorPersonal
    {
        Base b = new Base();

        public void Guardar(Personal p)
        {
            string consulta = $"CALL sp_agregar_personal('{p.Nombre}', '{p.Apellido}', '{p.Telefono}', '{p.Correo}', '{p.Especialidad}', '{p.Estado}', {p.FkidRol})";
            b.Comando(consulta);
            MessageBox.Show("Personal guardado con éxito.", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void Modificar(Personal p)
        {
            string consulta = $"CALL sp_editar_personal({p.IdPersonal}, '{p.Nombre}', '{p.Apellido}', '{p.Telefono}', '{p.Correo}', '{p.Especialidad}', '{p.Estado}', {p.FkidRol})";
            b.Comando(consulta);
            MessageBox.Show("Personal modificado con éxito.", "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void Eliminar(int idPersonal)
        {
            string consulta = $"CALL sp_eliminar_personal({idPersonal})";
            b.Comando(consulta);
        }

        public void BuscarPersonal(DataGridView tabla, string busqueda)
        {
            string consulta = $"CALL sp_buscar_personal('{busqueda}')";
            DataTable dt = b.Consultar(consulta, "personal").Tables[0];

            tabla.DataSource = null;        // Limpia el origen primero
            tabla.Columns.Clear();          // Luego limpia las columnas
            tabla.DataSource = dt;          // Asigna el nuevo origen

            if (tabla.Columns["id_personal"] != null) tabla.Columns["id_personal"].Visible = false;
            if (tabla.Columns["fkid_rol"] != null) tabla.Columns["fkid_rol"].Visible = false;

            tabla.Columns.Add(Boton("Modificar", Color.Green));
            tabla.Columns.Add(Boton("Eliminar", Color.Red));

            tabla.AutoResizeColumns();
            tabla.AutoResizeRows();
        }

        public DataTable ObtenerRoles()
        {
            return b.Consultar("SELECT id_rol, nombre_rol FROM tbl_roles", "roles").Tables[0];
        }

        private DataGridViewButtonColumn Boton(string titulo, Color fondo)
        {
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.HeaderText = titulo;
            btn.Text = titulo;
            btn.UseColumnTextForButtonValue = true;
            btn.FlatStyle = FlatStyle.Popup;
            btn.DefaultCellStyle.BackColor = fondo;
            btn.DefaultCellStyle.ForeColor = Color.White;
            return btn;
        }
    }
}