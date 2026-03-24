using K4os.Compression.LZ4.Internal;
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
using Entidades;
using Google.Protobuf.WellKnownTypes;

namespace LogClinic
{
    public partial class FrmCitas : Form
    {
        ManejadorCitas mc;
        int fila = 0, columna = 0;
        public static Citas cita = new Citas(0, 0, 0, DateTime.MinValue, "", "");
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
            string consulta = "SELECT * FROM v_citas WHERE 1=1";

            if (TxtPaciente.Text != "")
                consulta += $" AND Paciente LIKE '%{TxtPaciente.Text}%'";

            if (DtpDesdeFecha.Value.Date != DtpHastaFecha.Value.Date)
                consulta += $" AND Fecha_Hora BETWEEN '{DtpDesdeFecha.Value:yyyy-MM-dd} 00:00:00' AND '{DtpHastaFecha.Value:yyyy-MM-dd} 23:59:59'";

            if (CmbEstado.Text != "")
                consulta += $" AND Estado = '{CmbEstado.Text}'";

            mc.Mostrar(consulta, DtgDatos, "v_citas");

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

        private void DtgDatos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex;
            columna = e.ColumnIndex;
        }

        private void DtgDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cita.IdCita = int.Parse(DtgDatos.Rows[fila].Cells["Id_Cita"].Value.ToString());
            cita.IdPaciente = int.Parse(DtgDatos.Rows[fila].Cells["Id_Paciente"].Value.ToString());
            cita.IdPersonal = int.Parse(DtgDatos.Rows[fila].Cells["Id_Personal"].Value.ToString());
            cita.FechaHora = DateTime.Parse(DtgDatos.Rows[fila].Cells["Fecha_Hora"].Value.ToString());
            cita.Estado = DtgDatos.Rows[fila].Cells["Estado"].Value.ToString();
            cita.Motivo = DtgDatos.Rows[fila].Cells["Motivo"].Value.ToString();
            switch (columna)
            {
                case 8:
                    {
                        FrmRegristroCitas rc = new FrmRegristroCitas();
                        rc.ShowDialog();
                        DtgDatos.Columns.Clear();

                    }
                    break;

            }
        }
    }
}
