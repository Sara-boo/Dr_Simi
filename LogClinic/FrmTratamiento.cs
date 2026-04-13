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

namespace LogClinic
{
    public partial class FrmTratamiento : Form
    {
        ManejadorTratamiento mt;
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
    }
}
