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
            try
            {
                if (FrmVerUsuarios.usuario.IdUsuario == 0)
                {
                    if (CmbPersonal.SelectedValue == null || CmbPersonal.Items.Count == 0)
                    {
                        MessageBox.Show("No hay personal disponible para asignar una cuenta...", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    int idPersonal = Convert.ToInt32(CmbPersonal.SelectedValue);
                    bool activo = Convert.ToBoolean(CmbEstatus.SelectedValue);

                    if (!mu.ValidarCajasVacias(TxtClave, TxtNombre))
                    {
                        MessageBox.Show("Por favor, complete todos los campos.", "¡CAMPOS VACÍOS!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    string resultado = mu.Guardar(new Usuarios(0, TxtNombre.Text, ManejadorUsuarios.Sha1(TxtClave.Text), activo, idPersonal));

                    if (resultado == "Insertado")
                    {
                        ManejadorBitacora mb = new ManejadorBitacora();
                        mb.GuardarBitacora(FrmInicioSesion.IdUsuarioLogueado, $"Registró un nuevo usuario: {TxtNombre.Text}");
                        MessageBox.Show("¡Usuario registrado exitosamente!", "Éxito");
                        Close();
                    }
                }
                else
                {
                    bool activo = Convert.ToBoolean(CmbEstatus.SelectedValue);

                    mu.Editar(new Usuarios(
                        FrmVerUsuarios.usuario.IdUsuario,
                        TxtNombre.Text,
                        ManejadorUsuarios.Sha1(TxtClave.Text),
                        activo,
                        FrmVerUsuarios.usuario.IdPersonal
                    ));

                    ManejadorBitacora mb = new ManejadorBitacora();
                    mb.GuardarBitacora(FrmInicioSesion.IdUsuarioLogueado, $"Actualizó el usuario: {TxtNombre.Text}");
                    MessageBox.Show("¡Usuario actualizado exitosamente!", "Éxito");
                    Close();
                }
            }
            catch (Exception ex)
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
