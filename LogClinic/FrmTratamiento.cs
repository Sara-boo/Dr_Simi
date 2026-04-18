using Manejadores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using Entidades;

namespace LogClinic
{
    public partial class FrmTratamiento : Form
    {
        ManejadorTratamiento mt;

        List<DetalleTratamiento> listaDetalles = new List<DetalleTratamiento>();
        public FrmTratamiento()
        {
            InitializeComponent();
            mt = new ManejadorTratamiento();
            mt.MostrarAlergiasEnfermedades($"SELECT p.alergias AS 'Alergias', p.enfermedades_cronicas AS 'Enfermedades crónicas' FROM tbl_pacientes p WHERE p.nombre_completo = 'Laura Martinez'", dtgDatosPaciente, "tbl_pacientes");
            mt.LlenarMedicamentos(cmbMedicamento);
        }

        private void cmbMedicamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMedicamento.SelectedIndex != -1)
            {
                string nombreseleccionado = cmbMedicamento.Text;
                string consulta = $@"SELECT m.id_medicamento, 
                    CONCAT(m.presentacion, ' - ', m.concentracion) AS Info 
                    FROM tbl_medicamentos m 
                    INNER JOIN tbl_inventario i ON m.id_medicamento = i.fkid_medicamento 
                    WHERE UPPER(m.nombre) = UPPER('{nombreseleccionado}') 
                    AND i.stock_actual > 0";

                mt.CargarPresentaciones(consulta, cmbPresentacion, "temp");
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbMedicamento.SelectedIndex == -1)
                {
                    MessageBox.Show("Por favor seleccione un medicamento", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (cmbPresentacion.SelectedIndex == -1)
                {
                    MessageBox.Show("Seleccione una presentación", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning );
                    return;
                }

                DetalleTratamiento nuevoDetalle = new DetalleTratamiento(
                    0,                                     // id_detalle
                    0,                                     // fkid_tratamiento
                    int.Parse(cmbPresentacion.SelectedValue.ToString()), // fkid_medicamento
                    cmbMedicamento.Text + " (" + cmbPresentacion.Text + ")", // nombreParaMostrar 
                    int.Parse(txtCantidad.Text),           // cantidad
                    txtDosis.Text,                         // dosis
                    txtFrecuencia.Text,                    // frecuencia
                    txtDuracion.Text                       // duracion
                );

                mt.GuardarMedicamento(nuevoDetalle, listaDetalles);

                mt.MostrarMedicamentos(listaDetalles, dtgMedicamentos);

                txtCantidad.Clear();
                txtDosis.Clear();
                txtFrecuencia.Clear();
                txtDuracion.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrió un error al agregar el medicamento. Verifique los datos ingresados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtgMedicamentos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex == 0 && dtgMedicamentos.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                mt.BorrarMedicamento(listaDetalles, e.RowIndex);
                mt.MostrarMedicamentos(listaDetalles, dtgMedicamentos);
            }
        }
    }
}
