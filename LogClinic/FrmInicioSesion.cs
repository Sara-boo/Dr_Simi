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
        public FrmInicioSesion()
        {
            InitializeComponent();
            md = new ManejadorDiseño();
            ml = new ManejadorLogin();
            md.EstilosBoton(BtnIngresar, "E2FCD6", "000000");
            md.QuitarBordesBotones(BtnSalir);
            md.QuitarBordesBotones(BtnVer);
            md.EstilizarTextBox(TxtClave, "CCECEE", "14967F");
            md.EstilizarTextBox(TxtUsuario, "CCECEE", "14967F");
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            if(ml.Validar(TxtUsuario, TxtClave))
            {
                FrmPaginaPrincipal pp = new FrmPaginaPrincipal();
                pp.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Error de Credenciales....");
                contador++;
                if (contador >= 2)
                {
                    MessageBox.Show("Sus Credenciales se han Bloqueado, espere 3 segundos....");
                    TxtUsuario.Enabled = false;
                    TxtClave.Enabled = false;
                    Thread.Sleep(3000);
                    MessageBox.Show("Ahora puede Continuar....");
                    TxtUsuario.Enabled = true;
                    TxtClave.Enabled = true;
                    contador = 0;
                }
            }
        }
    }
}
