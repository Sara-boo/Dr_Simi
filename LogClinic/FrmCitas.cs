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
    public partial class FrmCitas : Form
    {
        ManejadorCitas mc;
        public FrmCitas()
        {
            InitializeComponent();
            mc = new ManejadorCitas();
        }

        private void Citas_Load(object sender, EventArgs e)
        {

        }

        private void BtnFiltrar_Click(object sender, EventArgs e)
        {
            mc.Mostrar($@"SELECT * FROM v_citas 
                  WHERE Paciente LIKE '%{TxtPaciente.Text}%'
                  AND Fecha_Hora BETWEEN '{DtpDesdeFecha.Value:yyyy-MM-dd} 00:00:00' 
                                     AND '{DtpHastaFecha.Value:yyyy-MM-dd} 23:59:59'
                  AND Estado LIKE '%{CmbEstado.Text}%'",
               DtgDatos, "Citas");
        }

        private void BtnNuevaCita_Click(object sender, EventArgs e)
        {
            FrmRegristroCitas rc = new FrmRegristroCitas();
            rc.ShowDialog();
        }

        private void BtnCsv_Click(object sender, EventArgs e)
        {
            mc.Exportar(DtgDatos);
        }
    }
}
