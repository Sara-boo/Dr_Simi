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
       ManejadorBitacora mb;
        public FrmRegistroMedicamentos()
        {
            InitializeComponent();
            mm = new ManejadorMedicamentos();
            mb = new ManejadorBitacora();
            if (FrmInventario.mSeleccionado.IdMedicamento > 0)
            {
                txtNombre.Text = FrmInventario.mSeleccionado.Nombre;
                txtDescripcion.Text = FrmInventario.mSeleccionado.Descripcion;
                cmbTipo.Text = FrmInventario.mSeleccionado.Tipo;
                txtPresentacion.Text = FrmInventario.mSeleccionado.Presentacion;
                txtConcentracion.Text = FrmInventario.mSeleccionado.Concentracion;
                chkRequiereReceta.Checked = FrmInventario.mSeleccionado.RequiereReceta;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if(string.IsNullOrWhiteSpace(txtNombre.Text) ||
                   string.IsNullOrWhiteSpace(txtDescripcion.Text) ||
                   string.IsNullOrWhiteSpace(cmbTipo.Text) ||
                   string.IsNullOrWhiteSpace(txtPresentacion.Text) ||
                   string.IsNullOrWhiteSpace(txtConcentracion.Text))
                {
                    MessageBox.Show("Por favor, complete todos los campos obligatorios.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                Medicamentos med = new Medicamentos(
                    FrmInventario.mSeleccionado.IdMedicamento,
                    txtNombre.Text,
                    txtDescripcion.Text,
                    cmbTipo.Text,
                    txtPresentacion.Text,
                    txtConcentracion.Text,
                    chkRequiereReceta.Checked
                );
                if (cmbTipo.SelectedIndex == -1)
                {
                    MessageBox.Show("Seleccione un tipo de medicamento");
                    return;
                }

                bool requiere = chkRequiereReceta.Checked;
                if(med.IdMedicamento==0)
                {
                    mm.GuardarMedicamento(med);

                    //Registrar en bitácora
                    mb.GuardarBitacora(FrmInicioSesion.IdUsuarioLogueado, $"Registró un nuevo medicamento: {med.Nombre}");

                    int ultimoId = mm.ObtenerUltimoIdMedicamento();
                    MessageBox.Show("Medicamento registrado. Ahora asigne el lote y stock inicial", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FrmSeguimientoRegistroInventario sm = new FrmSeguimientoRegistroInventario(ultimoId);
                    sm.ShowDialog();
                }
                else
                {
                    mm.Modificar(med);

                    //Registrar en bitácora
                    mb.GuardarBitacora(FrmInicioSesion.IdUsuarioLogueado, $"Modificó el medicamento: {med.Nombre}");
                    MessageBox.Show("Catálogo actualizado correctamente.", "Actualización exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    FrmInventario.mSeleccionado.IdMedicamento = 0;
                }
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
