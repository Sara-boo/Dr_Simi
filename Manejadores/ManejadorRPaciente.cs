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
            b.Comando($"INSERT INTO tbl_pacientes (curp, nombre_completo, fecha_nacimiento, sexo, telefono, correo, direccion, tipo_sangre, alergias, enfermedades_cronicas, fecha_registro, activo) " +
                      $"VALUES('{paciente.Curp}', '{paciente.NombreCompleto}', '{paciente.FechaNacimiento:yyyy-MM-dd}', " +
                      $"'{paciente.Sexo}', '{paciente.Telefono}', '{paciente.Correo}', '{paciente.Direccion}', " +
                      $"'{paciente.TipoSangre}', '{paciente.Alergias}', '{paciente.EnfermedadesCronicas}', now(), true)");

            MessageBox.Show("Paciente registrado con éxito", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void Modificar(Paciente paciente)
        {
            b.Comando($"UPDATE tbl_pacientes SET " +
                      $"nombre_completo='{paciente.NombreCompleto}', " +
                      $"curp='{paciente.Curp}', " +
                      $"fecha_nacimiento='{paciente.FechaNacimiento:yyyy-MM-dd}', " +
                      $"sexo='{paciente.Sexo}', " +
                      $"telefono='{paciente.Telefono}', " +
                      $"correo='{paciente.Correo}', " +
                      $"direccion='{paciente.Direccion}', " +
                      $"tipo_sangre='{paciente.TipoSangre}', " +
                      $"alergias='{paciente.Alergias}', " +
                      $"enfermedades_cronicas='{paciente.EnfermedadesCronicas}', " +
                      $"updated_at=now() " +
                      $"WHERE id_paciente = {paciente.IdPaciente}");

            MessageBox.Show("Información modificada correctamente", "Actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void Mostrar(DataGridView tabla, string filtro)
        {
            tabla.Columns.Clear();

            string consulta = "SELECT id_paciente AS ID, nombre_completo AS Nombre, curp AS CURP, " +
                              "fecha_nacimiento, " +
                              "TIMESTAMPDIFF(YEAR, fecha_nacimiento, CURDATE()) AS Edad, " +
                              "sexo AS Sexo, tipo_sangre AS Sangre, enfermedades_cronicas AS 'Enf. Crónicas', " +
                              "alergias AS Alergias, direccion AS Dirección, correo AS Correo, telefono AS Teléfono " +
                              $"FROM tbl_pacientes WHERE curp LIKE '%{filtro}%' AND activo = true";

            tabla.DataSource = b.Consultar(consulta, "tbl_pacientes").Tables[0];

            if (tabla.Columns.Contains("ID")) tabla.Columns["ID"].Visible = false;
            if (tabla.Columns.Contains("fecha_nacimiento")) tabla.Columns["fecha_nacimiento"].Visible = false;

            Color colorAzul = Color.FromArgb(1, 91, 126);
            Color colorTexto = Color.White;

            DataGridViewButtonColumn btnModificar = Boton("Modificar", colorAzul, colorTexto);
            btnModificar.Name = "Modificar";

            DataGridViewButtonColumn btnBorrar = Boton("Borrar", colorAzul, colorTexto);
            btnBorrar.Name = "Borrar";

            tabla.Columns.Add(btnModificar);
            tabla.Columns.Add(btnBorrar);

            btnModificar.DisplayIndex = 0;
            btnBorrar.DisplayIndex = 1;

            tabla.RowTemplate.Height = 35;
        }

        public void Borrar(int id, string nombre)
        {
            var r = MessageBox.Show($"¿Seguro que quiere borrar los datos de {nombre}?", "Confirmar",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (r == DialogResult.Yes)
            {
                b.Comando($"UPDATE tbl_pacientes SET activo = false WHERE id_paciente = {id}");
                MessageBox.Show("Registro eliminado");
            }
        }

        public static DataGridViewButtonColumn Boton(string titulo, Color fondo, Color texto)
        {
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.Name = titulo;
            btn.Text = titulo;
            btn.UseColumnTextForButtonValue = true;
            btn.FlatStyle = FlatStyle.Flat;
            btn.DefaultCellStyle.BackColor = fondo;
            btn.DefaultCellStyle.ForeColor = texto;
            btn.DefaultCellStyle.SelectionBackColor = fondo;
            btn.DefaultCellStyle.SelectionForeColor = texto;
            btn.DefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            return btn;
        }

        public System.Data.DataTable ObtenerDatosReporte(string filtro)
        {
            string consulta = "SELECT id_paciente AS ID, nombre_completo AS Nombre, curp AS CURP, " +
                              "fecha_nacimiento AS 'Fecha Nacimiento', sexo AS Sexo, tipo_sangre AS Sangre, " +
                              "enfermedades_cronicas AS 'Enf. Crónicas', alergias AS Alergias, " +
                              "direccion AS Dirección, correo AS Correo, telefono AS Teléfono " +
                              $"FROM tbl_pacientes WHERE curp LIKE '%{filtro}%' AND activo = true";
            return b.Consultar(consulta, "tbl_pacientes").Tables[0];
        }
    }
}