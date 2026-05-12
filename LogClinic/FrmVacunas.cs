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
    public partial class FrmVacunas : Form
    {
        ManejadorVacunas mv = new ManejadorVacunas();
        public FrmVacunas()
        {
            InitializeComponent();
            CargarVacunas();
        }
        private void CargarVacunas()
        {
            try
            {
                DataTable dt = mv.ObtenerVacunas();
                CmbVacunas.DataSource = dt;
                CmbVacunas.DisplayMember = "nombre_vacuna";
                CmbVacunas.ValueMember = "id_inventario";
                CmbVacunas.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar vacunas: " + ex.Message);
            }
        }
        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (CmbVacunas.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione una vacuna");
                return;
            }

            try
            {
                int idInv = Convert.ToInt32(CmbVacunas.SelectedValue);
                int idUser = FrmInicioSesion.IdUsuarioLogueado;

                mv.AplicarVacuna(idInv, idUser);

                // Bitácora general del sistema
                Manejadores.ManejadorBitacora mb = new Manejadores.ManejadorBitacora();
                mb.GuardarBitacora(idUser, $"Aplicó una vacuna (ID Inventario: {idInv})");

                MessageBox.Show("Vacunación registrada y stock actualizado.", "Éxito");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo completar el registro: " + ex.Message);
            }
        }
    }
}
