using System;
using System.Drawing;
using System.Windows.Forms;
using AccesoDatos;
using Entidades;

namespace Manejadores
{
    public class ManejadorRPaciente
    {
        Base b = new Base();

        
        public void Guardar(Paciente paciente)
        {
            b.Comando($"INSERT INTO tbl_pacientes VALUES(null, '{paciente.Curp}', '{paciente.NombreCompleto}', " +
                      $"'{paciente.FechaNacimiento:yyyy-MM-dd}', '{paciente.Sexo}', '{paciente.Telefono}', " +
                      $"'{paciente.Correo}', '{paciente.Direccion}', '{paciente.TipoSangre}', " +
                      $"'{paciente.Alergias}', '{paciente.EnfermedadesCronicas}', now(), true, now(), now())");

            MessageBox.Show("Paciente registrado con éxito");
        }

        
        public void Modificar(Paciente paciente)
        {
            b.Comando($"UPDATE tbl_pacientes SET " +
                      $"nombre_completo='{paciente.NombreCompleto}', " +
                      $"curp='{paciente.Curp}', " +
                      $"telefono='{paciente.Telefono}', " +
                      $"correo='{paciente.Correo}', " +
                      $"direccion='{paciente.Direccion}', " +
                      $"tipo_sangre='{paciente.TipoSangre}', " +
                      $"alergias='{paciente.Alergias}', " +
                      $"enfermedades_cronicas='{paciente.EnfermedadesCronicas}' " +
                      $"WHERE id_paciente = {paciente.IdPaciente}");

            MessageBox.Show("Información actualizada");
        }

       
        public void Mostrar(DataGridView tabla, string filtro)
        {
            tabla.Columns.Clear();
            // La parte clave es: TIMESTAMPDIFF(YEAR, fecha_nacimiento, CURDATE()) AS Edad
            string consulta = $"SELECT id_paciente AS ID, nombre_completo AS Nombre, curp AS CURP, " +
                              $"TIMESTAMPDIFF(YEAR, fecha_nacimiento, CURDATE()) AS Edad, " +
                              $"sexo AS Sexo, tipo_sangre AS Sangre, enfermedades_cronicas AS 'Enf. Crónicas', " +
                              $"alergias AS Alergias, direccion AS Dirección, correo AS Correo, telefono AS Teléfono " +
                              $"FROM tbl_pacientes WHERE (curp LIKE '%{filtro}%' OR nombre_completo LIKE '%{filtro}%') " +
                              $"AND activo = true";

            tabla.DataSource = b.Consultar(consulta, "tbl_pacientes").Tables[0];
            tabla.Columns["ID"].Visible = false;

            
            tabla.Columns.Add(Boton("Modificar", Color.LightBlue));
            tabla.Columns.Add(Boton("Borrar", Color.LightPink));
        }

      
        public void Borrar(int id, string nombre)
        {
            var r = MessageBox.Show($"¿Eliminar a {nombre}?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                b.Comando($"UPDATE tbl_pacientes SET activo = false WHERE id_paciente = {id}");
            }
        }

        public static DataGridViewButtonColumn Boton(string titulo, Color fondo)
        {
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.Name = titulo;
            btn.Text = titulo;
            btn.UseColumnTextForButtonValue = true;
            btn.FlatStyle = FlatStyle.Popup;
            btn.DefaultCellStyle.BackColor = fondo;
            return btn;
        }
    }
}