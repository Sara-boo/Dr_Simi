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
    }
}
