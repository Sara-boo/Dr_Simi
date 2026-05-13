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

        public void BuscarPersonal(DataGridView tabla, string busqueda, Image imgModificar, Image imgEliminar)
        {
            string consulta = $"CALL sp_buscar_personal('{busqueda}')";
            DataTable dt = b.Consultar(consulta, "personal").Tables[0];

            tabla.DataSource = null;
            tabla.Columns.Clear();
            tabla.DataSource = dt;

            if (tabla.Columns["id_personal"] != null) tabla.Columns["id_personal"].Visible = false;
            if (tabla.Columns["fkid_rol"] != null) tabla.Columns["fkid_rol"].Visible = false;

            tabla.Columns.Add(CrearColumnaImagen("Modificar", imgModificar));
            tabla.Columns.Add(CrearColumnaImagen("Eliminar", imgEliminar));

            tabla.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(45, 66, 91);
            tabla.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            tabla.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(45, 66, 91);
            tabla.ColumnHeadersDefaultCellStyle.Font = new Font("Javanese Text", 10, FontStyle.Bold);
            tabla.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            tabla.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            tabla.ColumnHeadersHeight = 40;

            tabla.DefaultCellStyle.Font = new Font("Javanese Text", 9);
            tabla.DefaultCellStyle.SelectionBackColor = Color.FromArgb(30, 144, 255);
            tabla.DefaultCellStyle.SelectionForeColor = Color.White;
            tabla.BackgroundColor = Color.White;
            tabla.GridColor = Color.FromArgb(210, 210, 210);

            tabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tabla.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tabla.RowHeadersVisible = false;
            tabla.EnableHeadersVisualStyles = false;

            
            tabla.RowTemplate.Height = 45;
            foreach (DataGridViewRow fila in tabla.Rows)
            {
                fila.Height = 45;
            }

            tabla.AutoResizeColumns();
        }

        public DataTable ObtenerRoles()
        {
            return b.Consultar("SELECT id_rol, nombre_rol FROM tbl_roles", "roles").Tables[0];
        }

        private DataGridViewImageColumn CrearColumnaImagen(string nombre, Image imagen)
        {
            DataGridViewImageColumn columna = new DataGridViewImageColumn();
            columna.Name = nombre;
            columna.HeaderText = nombre;
            columna.Image = imagen;
            columna.ImageLayout = DataGridViewImageCellLayout.Zoom;
           
            columna.DefaultCellStyle.Padding = new Padding(2);
            columna.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            return columna;
        }
    }
}