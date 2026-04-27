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
        ManejadorLogin ml;
        private ToolStripButton botonActivoActual = null;
        public FrmPaginaPrincipal(string username)
        {
            InitializeComponent();
            md = new ManejadorDiseño();
            ml = new ManejadorLogin();
            LblUsuarioActivo.Text = ml.ObtenerNombre(username);
            this.IsMdiContainer = true;
            foreach (Control ctrl in this.Controls)
            {
                ctrl.BackColor = ColorTranslator.FromHtml("#CCECEE");
            }
            pSuperior.BackColor = ColorTranslator.FromHtml("#095D7E");
            tsPrincipal.BackColor = ColorTranslator.FromHtml("#095D7E");
            md.QuitarBordesBotones(BtnCerrar);
            md.QuitarBordesBotones(BtnOcultarVentana);
           

        }
        private void FrmPaginaPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void tsPrincipal_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }

        private void tsInicio_Click(object sender, EventArgs e)
        {
            md.Boton(sender, tsPrincipal, botonActivoActual);
            md.CerrarFormulariosActivos(this);
        }

        private void tsbCitas_Click(object sender, EventArgs e)
        {
            md.Boton(sender, tsPrincipal, botonActivoActual);
            md.CerrarFormulariosActivos(this);
            FrmRegristroCitas frmRegristroCitas = new FrmRegristroCitas();
            frmRegristroCitas.MdiParent = this;
            frmRegristroCitas.Show();
        }

        private void tsbUsuario_Click(object sender, EventArgs e)
        {
            md.Boton(sender, tsPrincipal, botonActivoActual);
            md.CerrarFormulariosActivos(this);
            FrmVerUsuarios frmVerUsuarios = new FrmVerUsuarios();
            frmVerUsuarios.MdiParent = this;    
            frmVerUsuarios.Show();
        }

        private void tsbPersonal_Click(object sender, EventArgs e)
        {

        }
    }
}
