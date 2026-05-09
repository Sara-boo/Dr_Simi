using Manejadores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LogClinic
{
    public partial class FrmInicioSesion : Form
    {
        ManejadorDiseño md;
        ManejadorLogin ml;
        int contador = 0;
        bool mostrarClave = false;
        public static int IdUsuarioLogueado;
        public static string NombreUsuarioLogueado;
        public static string RolUsuarioLogueado;
        public FrmInicioSesion()
        {
            InitializeComponent();
            md = new ManejadorDiseño();
            ml = new ManejadorLogin();
            md.QuitarBordesBotones(BtnSalir);
            md.QuitarBordesBotones(BtnVer);
            md.QuitarBordesBotones(BtnNoVer);
            md.EstilizarTextBox(TxtClave, "CCECEE", "14967F");
            md.EstilizarTextBox(TxtUsuario, "CCECEE", "14967F");
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            if(!ml.ValidarCajasVacias(TxtClave, TxtUsuario))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "¡CAMPOS VACÍOS!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }

            if (ml.Validar(TxtUsuario, TxtClave))
            {
                DataRow datos = ml.ObtenerDatosCompletos(TxtUsuario.Text);

                if (datos != null) 
                {
                    IdUsuarioLogueado = int.Parse(datos["id_usuario"].ToString());
                    NombreUsuarioLogueado = datos["nombre_completo"].ToString();
                    RolUsuarioLogueado = datos["rol"].ToString(); // ¡Desbloqueado!
                }

                FrmPaginaPrincipal pp = new FrmPaginaPrincipal(TxtUsuario.Text);
                pp.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Error el Usuario o Contraseña son Incorrectos!!!!", "¡ERROR DE AUTENTICACIÓN!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ml.LimipiarCajas(TxtClave, TxtUsuario);

                contador++;
                if (contador >= 3)
                {
                    MessageBox.Show("Ha excedido el número maximo de intentos.\n\nSe activo el bloqueo por 3 segundos.", "¡ERROR DE AUTENTICACIÓN!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ml.LimipiarCajas(TxtClave, TxtUsuario);
                    TxtUsuario.Enabled = false;
                    TxtClave.Enabled = false;
                    BtnSalir.Enabled = false;
                    BtnVer.Enabled = false;
                    BtnNoVer.Enabled = false;
                    Thread.Sleep(3000);
                    MessageBox.Show("Se desactivó el bloqueo temporal, puede intentar nuevamente.", "¡ATENCIÓN!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TxtUsuario.Enabled = true;
                    TxtClave.Enabled = true;
                    BtnSalir.Enabled = true;
                    BtnVer.Enabled = true;
                    BtnNoVer.Enabled = true;
                    contador = 0;
                }
            }
        }

        private void BtnVer_Click(object sender, EventArgs e)
        {
            mostrarClave = true;
            ml.MostrarOcultarContrasena(TxtClave, mostrarClave);
            BtnNoVer.Visible = true;
            BtnVer.Visible = false;
           
        }

        private void BtnNoVer_Click(object sender, EventArgs e)
        {
            mostrarClave = false;
            ml.MostrarOcultarContrasena(TxtClave, mostrarClave);
            BtnVer.Visible = true;
            BtnNoVer.Visible = false;
        }

        private void FrmInicioSesion_Load(object sender, EventArgs e)
        {

        }
    }
}
