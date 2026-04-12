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
    public partial class FrmTratamiento : Form
    {
        ManejadorTratamiento mt;
        public FrmTratamiento()
        {
            InitializeComponent();
            mt = new ManejadorTratamiento();
            mt.MostrarAlergiasEnfermedades($"SELECT p.alergias AS 'Alergias', p.enfermedades_cronicas AS 'Enfermedades crónicas' FROM tbl_pacientes p WHERE p.nombre_completo = 'Laura Martinez'", dtgDatosPaciente, "tbl_pacientes");
        }
    }
}
