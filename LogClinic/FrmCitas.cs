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

namespace LogClinic
{
    public partial class FrmCitas : Form
    {
        ManejadorCitas mc;
        int fila =0, columna = 0;
        public static Citas cita = new Citas(0,0,0,DateTime.MinValue,"","");
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

        private void DtgDatos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex;
            columna = e.ColumnIndex;
        }

        private void DtgDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cita.IdCita = int.Parse(DtgDatos.Rows[fila].Cells["Id_Cita"].Value.ToString());
            cita.IdPaciente = int.Parse(DtgDatos.Rows[fila].Cells["Paciente"].Value.ToString());
            cita.Id_mecanico = int.Parse(DtgDatos.Rows[fila].Cells["id_mecanico"].Value.ToString());
            mecanico.Nombre = DtgDatos.Rows[fila].Cells["nombre"].Value.ToString();
            mecanico.Telefono = DtgDatos.Rows[fila].Cells["telefono"].Value.ToString();
            mecanico.Email = DtgDatos.Rows[fila].Cells["email"].Value.ToString();
            mecanico.Estatus = DtgDatos.Rows[fila].Cells["estatus"].Value.ToString();
            switch (columna)
            {
                case 5:
                    {
                        FrmDatosMecanico dme = new FrmDatosMecanico();
                        dme.ShowDialog();
                        DtgDatos.Columns.Clear();

                    }
                    break;
                case 6:
                    {

                        mme.Borrar(mecanico);
                        //actualizar datagridview
                        DtgDatos.Columns.Clear();
                    }

            }
        }
}
