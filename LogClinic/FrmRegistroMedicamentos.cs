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
    public partial class FrmRegistroMedicamentos : Form
    {
       ManejadorMedicamentos mm;
        public FrmRegistroMedicamentos()
        {
            InitializeComponent();
            mm= new ManejadorMedicamentos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbTipo.SelectedIndex == -1)
                {
                    MessageBox.Show("Seleccione un tipo de medicamento");
                    return;
                }

                bool requiere = chkRequiereReceta.Checked;
                mm.GuardarMedicamento(new Medicamentos(0, txtNombre.Text, txtDescripcion.Text, cmbTipo.Text, txtPresentacion.Text, txtConcentracion.Text, requiere));

               int ultimoId = mm.ObtenerUltimoIdMedicamento();
                FrmSeguimientoRegistroInventario sm = new FrmSeguimientoRegistroInventario(ultimoId);

               sm.ShowDialog();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el medicamento: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmRegistroMedicamentos_Load(object sender, EventArgs e)
        {

        }
    }
}
