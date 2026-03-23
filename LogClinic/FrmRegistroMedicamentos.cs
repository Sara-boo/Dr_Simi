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
            btnCancelar.BackColor = Color.FromArgb(94, 226, 252, 214);
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
                if (cmbTipo.SelectedIndex==-1)
                {
                    MessageBox.Show("Seleccione un tipo de medicamento");
                    return;
                }
                if (chkRequiereReceta.Checked)
                {
                    mm.GuardarMedicamento(new Medicamentos(0, txtNombre.Text, txtDescripcion.Text, cmbTipo.Text, txtPresentacion.Text, txtConcentracion.Text,true));
                }
                else
                {
                    mm.GuardarMedicamento(new Medicamentos(0, txtNombre.Text, txtDescripcion.Text, cmbTipo.Text, txtPresentacion.Text, txtConcentracion.Text, false));
                }
                FrmSeguimientoRegistroInventario sm = new FrmSeguimientoRegistroInventario();
                sm.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el medicamento" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
