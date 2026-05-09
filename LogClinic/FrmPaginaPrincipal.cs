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
            tsPrincipal.ForeColor = ColorTranslator.FromHtml("#095D7E");
            md.QuitarBordesBotones(BtnCerrar);
            md.QuitarBordesBotones(BtnOcultarVentana);
           

        }
        private void FrmPaginaPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void tsPrincipal_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }

       

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnOcultarVentana_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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
            FrmCitas frmCitas = new FrmCitas();
            frmCitas.MdiParent = this;
            frmCitas.Show();
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
            md.Boton(sender, tsPrincipal, botonActivoActual);
            md.CerrarFormulariosActivos(this);
            FrmPersonal frmPersonal = new FrmPersonal();
            frmPersonal.MdiParent = this;
            frmPersonal.Show();
        }

        private void tsbPacientes_Click(object sender, EventArgs e)
        {
            md.Boton(sender, tsPrincipal, botonActivoActual);
            md.CerrarFormulariosActivos(this);
            FrmPacientes frmPacientes = new FrmPacientes();
            frmPacientes.MdiParent = this;
            frmPacientes.Show();
        }

        private void tsbHistorial_Click(object sender, EventArgs e)
        {
            md.Boton(sender, tsPrincipal, botonActivoActual);
            md.CerrarFormulariosActivos(this);
            FrmHistorialClinico frmHistorialClinico = new FrmHistorialClinico();
            frmHistorialClinico.MdiParent = this;
            frmHistorialClinico.Show();
        }

        private void tsbSalir_Click_1(object sender, EventArgs e)
        {
            md.Boton(sender, tsPrincipal, botonActivoActual);
            Application.Restart();
        }

        private void tsbSalir_Click(object sender, EventArgs e)
        {
            md.Boton(sender, tsPrincipal, botonActivoActual);
            md.CerrarFormulariosActivos(this);
            FrmTratamiento frmTratamiento = new FrmTratamiento(0, 0, "");
            frmTratamiento.MdiParent = this;
            frmTratamiento.Show();
        }

        private void tsbInventario_Click(object sender, EventArgs e)
        {
            md.Boton(sender, tsPrincipal, botonActivoActual);
            md.CerrarFormulariosActivos(this);
            FrmInventario frmInventario = new FrmInventario();
            frmInventario.MdiParent = this;
            frmInventario.Show();
        }

        private void tsbVacunas_Click(object sender, EventArgs e)
        {
            md.Boton(sender, tsPrincipal, botonActivoActual);
            md.CerrarFormulariosActivos(this);

        }

        private void tsbPacientes_Click_1(object sender, EventArgs e)
        {
            md.Boton(sender, tsPrincipal, botonActivoActual);
            FrmPacientes frmpacientes = new FrmPacientes();
            frmpacientes.MdiParent = this;
            frmpacientes.Show();
        }
    }
}
