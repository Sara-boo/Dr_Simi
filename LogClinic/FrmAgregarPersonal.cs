using System;
using System.Windows.Forms;
using Entidades;
using Manejadores;

namespace LogClinic
{
    public partial class FrmAgregarPersonal : Form
    {
        ManejadorPersonal mp;
        ManejadorBitacora mb;

        public FrmAgregarPersonal(int accion)
        {
            InitializeComponent();
            mp = new ManejadorPersonal();
            mb = new ManejadorBitacora();
            CmbRol.DataSource = mp.ObtenerRoles();
            CmbRol.DisplayMember = "nombre_rol";
            CmbRol.ValueMember = "id_rol";

            if (accion == 1) // 1 es para Modificar
            {
                TxtNombre.Text = FrmPersonal.personal.Nombre;
                TxtApellidos.Text = FrmPersonal.personal.Apellido;
                TxtTelefono.Text = FrmPersonal.personal.Telefono;
                TxtCorreo.Text = FrmPersonal.personal.Correo;
                TxtEspecialidad.Text = FrmPersonal.personal.Especialidad;
                CmbEstado.Text = FrmPersonal.personal.Estado;
                CmbRol.SelectedValue = FrmPersonal.personal.FkidRol;
            }
            else 
            {
                Limpiar();
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtNombre.Text))
            {
                MessageBox.Show("El nombre no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtNombre.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(CmbEstado.Text))
            {
                MessageBox.Show("Indique el estado del personal.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CmbEstado.Focus();
                return;
            }

            Personal personalParaGuardar = new Personal(
                FrmPersonal.personal.IdPersonal,
                TxtNombre.Text.Trim(),
                TxtApellidos.Text.Trim(),
                TxtTelefono.Text.Trim(),
                TxtCorreo.Text.Trim(),
                TxtEspecialidad.Text.Trim(),
                CmbEstado.Text,
                Convert.ToInt32(CmbRol.SelectedValue)
            );

            try
            {
                if (personalParaGuardar.IdPersonal == 0)
                {
                    // Registramos la acción en la bitácora
                    mb.GuardarBitacora(FrmInicioSesion.IdUsuarioLogueado, $"Registró un nuevo miembro del personal: {personalParaGuardar.Nombre}");
                    mp.Guardar(personalParaGuardar);
                }
                else
                {
                    mp.Modificar(personalParaGuardar);
                    // Registramos la acción en la bitácora indicando qué ID se afectó
                    mb.GuardarBitacora(FrmInicioSesion.IdUsuarioLogueado, $"Modificó los datos del personal: {personalParaGuardar.Nombre} (ID: {personalParaGuardar.IdPersonal})");
                    MessageBox.Show("Datos actualizados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Si marca error, borrar esta línea porque no es necesario limpiar el personal global, ya que se actualizó con los nuevos datos.
                    FrmPersonal.personal.IdPersonal = 0;
                }

                Close();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message, "Error al guardar",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        void Limpiar()
        {
            TxtNombre.Clear();
            TxtApellidos.Clear();
            TxtTelefono.Clear();
            TxtCorreo.Clear();
            TxtEspecialidad.Clear();
            CmbEstado.SelectedIndex = -1;
        }

        private void BtnCancelar_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}