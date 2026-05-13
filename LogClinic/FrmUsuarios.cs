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
    public partial class FrmUsuarios : Form
    {
        ManejadorUsuarios mu;
        ManejadorBitacora mb;
        public FrmUsuarios()
        {
            InitializeComponent();
            mu = new ManejadorUsuarios();
            mb = new ManejadorBitacora();
            mu.LlenarPersonal(CmbPersonal);
            mu.LlenarEstatus(CmbEstatus);

           if(FrmVerUsuarios.usuario.IdUsuario > 0)
            {
                TxtNombre.Text = FrmVerUsuarios.usuario.UserName;
                CmbPersonal.Visible = false;
                LblPersonal.Visible = false;
                CmbEstatus.SelectedValue = FrmVerUsuarios.usuario.Activo;
            }
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {

        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            // 1. Validar que el ComboBox no esté vacío o con selección nula
            if (CmbPersonal.SelectedValue == null || CmbPersonal.Items.Count == 0)
            {
                MessageBox.Show("No hay personal disponible para asignar una cuenta. " +
                                "\n\nPor favor, registre primero a un empleado en el catálogo de Personal " +
                                "que no tenga un usuario asignado todavía.",
                                "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Esto detiene el proceso y evita que la app se cierre
            }
            if (CmbPersonal.SelectedValue == null || Convert.ToInt32(CmbPersonal.SelectedValue) == 0)
            {
                MessageBox.Show("Debe seleccionar un miembro del personal para vincular la cuenta.",
                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // 2. Si pasó la validación, ahora sí podemos obtener el ID con seguridad
                int idPersonal = Convert.ToInt32(CmbPersonal.SelectedValue);
                bool activo = Convert.ToBoolean(CmbEstatus.SelectedValue);

                if (!mu.ValidarCajasVacias(TxtClave, TxtNombre))
                {
                    MessageBox.Show("Por favor, complete todos los campos.", "¡CAMPOS VACÍOS!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (FrmVerUsuarios.usuario.IdUsuario == 0)
                {
                    string resultado = mu.Guardar(new Usuarios(0, TxtNombre.Text, ManejadorUsuarios.Sha1(TxtClave.Text),activo,idPersonal));

                    if (resultado == "Insertado")
                    {
                        mb.GuardarBitacora(FrmInicioSesion.IdUsuarioLogueado, $"Registró un nuevo usuario: {TxtNombre.Text}");

                        MessageBox.Show("¡Usuario registrado exitosamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                }
                else  
                {
                    bool Activo = Convert.ToBoolean(CmbEstatus.SelectedValue);

                    mu.Editar(new Usuarios(
                        FrmVerUsuarios.usuario.IdUsuario,
                        TxtNombre.Text,
                        ManejadorUsuarios.Sha1(TxtClave.Text),
                        activo,
                        FrmVerUsuarios.usuario.IdPersonal 
                    ));
                    mb.GuardarBitacora(FrmInicioSesion.IdUsuarioLogueado, $"Actualizó el usuario: {TxtNombre.Text}");

                    MessageBox.Show("¡Usuario actualizado exitosamente!", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
