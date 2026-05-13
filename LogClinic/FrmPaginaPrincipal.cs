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
        ManejadorCitas mc;
        private ToolStripButton botonActivoActual = null;
        public FrmPaginaPrincipal(string username)
        {
            InitializeComponent();
            md = new ManejadorDiseño();
            ml = new ManejadorLogin();
            mc = new ManejadorCitas();
            LblUsuarioActivo.Text = ml.ObtenerNombre(username);
            this.IsMdiContainer = true;
            foreach (Control ctrl in this.Controls)
            {
                ctrl.BackColor = ColorTranslator.FromHtml("#CCECEE");
            }
            pSuperior.BackColor = ColorTranslator.FromHtml("#095D7E");
            tsPrincipal.BackColor = ColorTranslator.FromHtml("#095D7E");
            PanelCitasHoy.BackColor = Color.White;
            PanelPacientesActivos.BackColor = Color.White;
            PanelStockC.BackColor = Color.White;
            PanelProximasCitas.BackColor = Color.White;
            tsPrincipal.ForeColor = ColorTranslator.FromHtml("#095D7E");
            md.QuitarBordesBotones(BtnCerrar);
            md.QuitarBordesBotones(BtnOcultarVentana);
            md.RedondearPanel(PanelCitasHoy, 15);
            md.RedondearPanel(PanelPacientesActivos, 15);
            md.RedondearPanel(PanelStockC, 15);
            md.RedondearPanel(PanelProximasCitas, 15);
            md.EstilizarDataGrid(DtgDatos);
        }
        private void FrmPaginaPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                LblFecha.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy");
                LblCitasHoy.Text = mc.Consultar("SELECT * FROM v_total_citas_hoy", "v_total_citas_hoy")
                                   .Tables[0].Rows[0]["Total_Citas_Hoy"].ToString();

                LblStock.Text = mc.Consultar("SELECT * FROM v_total_stock_critico", "v_total_stock_critico")
                                .Tables[0].Rows[0]["Total_Stock_Critico"].ToString();
                LblPacientesA.Text = mc.Consultar("SELECT * FROM v_total_pacientes_activos", "v_total_pacientes_activos")
                                     .Tables[0].Rows[0]["Total_Pacientes_Activos"].ToString();

                mc.MostrarIS("SELECT * FROM v_proximas_citas_hoy", DtgDatos, "v_proximas_citas_hoy"); DtgDatos.Columns["Hora"].Width = 100; // Le damos un ancho fijo para que no se estire de más
                DtgDatos.Columns["Hora"].DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#E2EFEF"); 
                DtgDatos.Columns["Hora"].DefaultCellStyle.ForeColor = ColorTranslator.FromHtml("#0F5B78"); 
                DtgDatos.Columns["Hora"].DefaultCellStyle.Font = new Font("Lucida Bright", 15F, FontStyle.Bold);
                DtgDatos.Columns["Hora"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                DtgDatos.Columns["Paciente"].DefaultCellStyle.Font = new Font("Lucida Bright", 15F, FontStyle.Bold);
                DtgDatos.Columns["Paciente"].DefaultCellStyle.ForeColor = ColorTranslator.FromHtml("#1A3A4A");
                DtgDatos.Columns["Paciente"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
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
            PanelFondo.Visible= true;
            LblModulo.Text = "Inicio";
        }

        private void tsbCitas_Click(object sender, EventArgs e)
        {
            md.Boton(sender, tsPrincipal, botonActivoActual);
            md.CerrarFormulariosActivos(this);
            PanelFondo.SendToBack();
            FrmCitas frmCitas = new FrmCitas();
            frmCitas.MdiParent = this;
            frmCitas.Show();
            LblModulo.Text = "Citas";   
        }

        private void tsbUsuario_Click(object sender, EventArgs e)
        {
            md.Boton(sender, tsPrincipal, botonActivoActual);
            md.CerrarFormulariosActivos(this);
            PanelFondo.SendToBack();
            FrmVerUsuarios frmVerUsuarios = new FrmVerUsuarios();
            frmVerUsuarios.MdiParent = this;
            frmVerUsuarios.Show();
            LblModulo.Text = "Usuarios";
        }

        private void tsbPersonal_Click(object sender, EventArgs e)
        {
            md.Boton(sender, tsPrincipal, botonActivoActual);
            md.CerrarFormulariosActivos(this);
            PanelFondo.SendToBack();
            FrmPersonal frmPersonal = new FrmPersonal();
            frmPersonal.MdiParent = this;
            frmPersonal.Show();
            LblModulo.Text = "Personal";
        }

        private void tsbPacientes_Click(object sender, EventArgs e)
        {
            md.Boton(sender, tsPrincipal, botonActivoActual);
            md.CerrarFormulariosActivos(this);
            PanelFondo.SendToBack();
            FrmPacientes frmPacientes = new FrmPacientes();
            frmPacientes.MdiParent = this;
            frmPacientes.Show();
            LblModulo.Text = "Pacientes";
        }

        private void tsbHistorial_Click(object sender, EventArgs e)
        {
            md.Boton(sender, tsPrincipal, botonActivoActual);
            md.CerrarFormulariosActivos(this);
            PanelFondo.SendToBack();
            FrmHistorialClinico frmHistorialClinico = new FrmHistorialClinico();
            frmHistorialClinico.MdiParent = this;
            frmHistorialClinico.Show();
            LblModulo.Text = "Historial Clínico";
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
            PanelFondo.SendToBack();
            FrmTratamiento frmTratamiento = new FrmTratamiento(0, 0, "");
            frmTratamiento.MdiParent = this;
            frmTratamiento.Show();
        }

        private void tsbInventario_Click(object sender, EventArgs e)
        {
            md.Boton(sender, tsPrincipal, botonActivoActual);
            md.CerrarFormulariosActivos(this);
            PanelFondo.SendToBack();
            FrmInventario frmInventario = new FrmInventario();
            frmInventario.MdiParent = this;
            frmInventario.Show();
            LblModulo.Text = "Inventario";
        }

        private void tsbVacunas_Click(object sender, EventArgs e)
        {
            md.Boton(sender, tsPrincipal, botonActivoActual);
            md.CerrarFormulariosActivos(this);
            PanelFondo.SendToBack();
            FrmVacunas frmVacunas = new FrmVacunas();
            frmVacunas.MdiParent = this;
            frmVacunas.Show();
            LblModulo.Text = "Vacunas";

        }

        private void tsbPacientes_Click_1(object sender, EventArgs e)
        {
            md.Boton(sender, tsPrincipal, botonActivoActual);
            md.CerrarFormulariosActivos(this);
            PanelFondo.SendToBack();
            FrmPacientes frmpacientes = new FrmPacientes();
            frmpacientes.MdiParent = this;
            frmpacientes.Show();
            LblModulo.Text = "Pacientes";
        }

        private void TsbBitacora_Click(object sender, EventArgs e)
        {
            md.Boton(sender, tsPrincipal, botonActivoActual);
            md.CerrarFormulariosActivos(this);
            PanelFondo.SendToBack();
            FrmBitacora frmBitacora = new FrmBitacora();
            frmBitacora.MdiParent = this;
            frmBitacora.Show();
            LblModulo.Text = "Bitácora";
        }
    }
}
