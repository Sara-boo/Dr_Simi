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

namespace LogClinic
{
    public partial class FrmInicioSesion : Form
    {
        ManejadorDiseño md;
        public FrmInicioSesion()
        {
            InitializeComponent();
            md = new ManejadorDiseño();
            PAzul.BackColor = ColorTranslator.FromHtml("#095D7E");
            PBlanco.BackColor = ColorTranslator.FromHtml("#F1F9FF");
            this.BackColor = ColorTranslator.FromHtml("#CCECEE");
            md.EstilosBoton(BtnIngresar, "E2FCD6", "000000");
            md.QuitarBordesBotones(BtnSalir);
            md.QuitarBordesBotones(BtnVer);
            md.EstilizarTextBox(TxtClave, "CCECEE", "14967F");
            md.EstilizarTextBox(TxtUsuario, "CCECEE", "14967F");
        }
    }
}
