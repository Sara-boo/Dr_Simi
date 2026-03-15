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
    public partial class FrmPaginaPrincipal : Form
    {

        ManejadorDiseño md;
        public FrmPaginaPrincipal()
        {
            InitializeComponent();
            md = new ManejadorDiseño();
            this.IsMdiContainer = true;
            foreach (Control ctrl in this.Controls)
            {
                ctrl.BackColor = ColorTranslator.FromHtml("#CCECEE");
            }
            tsPrincipal.BackColor = ColorTranslator.FromHtml("#095D7E");
            pSuperior.BackColor = ColorTranslator.FromHtml("#095D7E");
            LblUsuarioActivo.ForeColor = ColorTranslator.FromHtml("#CCECEE");
            md.QuitarBordesBotones(BtnCerrar);
            md.QuitarBordesBotones(BtnOcultarVentana);
           
        }
        private void FrmPaginaPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
