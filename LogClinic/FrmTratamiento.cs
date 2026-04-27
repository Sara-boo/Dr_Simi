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
        int idPacienteRecibido;
        int idCitaRecibida;
        int idUsuarioActual;
        public FrmTratamiento(int idPaciente,int idCita,string NombrePaciente)
        {
            InitializeComponent();
            mt = new ManejadorTratamiento();
            this.idPacienteRecibido = idPaciente;
            this.idCitaRecibida=idCita;
            //this.idUsuarioActual = usuario;
            lblPaciente.Text = "Paciente: " + NombrePaciente;
            mt.MostrarAlergiasEnfermedades($"SELECT alergias, enfermedades_cronicas FROM tbl_pacientes WHERE id_paciente = {idPaciente}", dtgDatosPaciente, "tbl_pacientes");
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int idMedico = FrmInicioSesion.IdUsuarioLogueado;
            if (listaDetalles.Count == 0)
            {
                MessageBox.Show("Debe agregar al menos un medicamento a la receta antes de guardar.",
                                "Receta Vacía", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtSintomas.Text))
            {
                MessageBox.Show("Por favor, ingrese la descripción de los síntomas.",
                                "Datos Faltantes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
               
                Tratamiento cabecera = new Tratamiento(
                    0,
                    this.idPacienteRecibido,
                    txtSintomas.Text,
                    DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                    1
                );

                mt.GuardarConsultaCompleta(this.idCitaRecibida, txtSintomas.Text, "Sin observaciones", listaDetalles,idMedico);


                MessageBox.Show("El tratamiento y la receta se han registrado correctamente. El stock ha sido actualizado.",
                                "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close(); // Regresamos al formulario de citas
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un problema al guardar el tratamiento: " + ex.Message,
                                "Error de Guardado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
