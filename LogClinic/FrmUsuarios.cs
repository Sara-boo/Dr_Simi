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
        public FrmUsuarios()
        {
            InitializeComponent();
            mu = new ManejadorUsuarios();
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
            int idPersonal = Convert.ToInt32(CmbPersonal.SelectedValue);
            bool activo = Convert.ToBoolean(CmbEstatus.SelectedValue);
            try
            {
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
                        MessageBox.Show("¡Usuario registrado exitosamente!", "Éxito", MessageBoxButtons.OK,MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    {
                        MessageBox.Show(resultado, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        mu.LimipiarCajas(TxtClave, TxtNombre);
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
