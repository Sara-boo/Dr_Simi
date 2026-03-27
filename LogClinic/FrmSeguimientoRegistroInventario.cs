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
    public partial class FrmSeguimientoRegistroInventario : Form
    {
        ManejadorMedicamentos mm;
        public int idRecibido;
        public FrmSeguimientoRegistroInventario(int idMed)
        {
            InitializeComponent();
            this.idRecibido = idMed;
            mm = new ManejadorMedicamentos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if(string.IsNullOrWhiteSpace(txtLote.Text) || string.IsNullOrWhiteSpace(txtCantidad.Text))
                {
                    MessageBox.Show("Lote y Cantidad son campos obligatorios");
                    return;
                }
                int idMed = this.idRecibido;
                string lote = txtLote.Text;

                string fechaCad = dtpFechaCaducidad.Value.ToString("yyyy-MM-dd");
                int cant = int.Parse(txtCantidad.Text);
                int stockMin= int.Parse(txtStockMinimo.Text);
                string ubicacion = txtUbicacion.Text;

                int idUsuarioSesion = 1;
                Inventario nuevoInv = new Inventario(0, idMed, lote, fechaCad, cant, stockMin, ubicacion, idUsuarioSesion);
                nuevoInv.FkidUsuario = idUsuarioSesion;

                mm.RegistroInventario(nuevoInv);
                MessageBox.Show("¡Inventario y Movimiento registrado con éxito!","Éxito",MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, introduce números válidos en Cantidad y Stock Mínimo.", "Error de formato");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al procesar el inventario: " + ex.Message);
            }
        }
    }
}
