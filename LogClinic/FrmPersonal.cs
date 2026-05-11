using System;
using System.Windows.Forms;
using Entidades;
using Manejadores;

namespace LogClinic
{
    public partial class FrmPersonal : Form
    {
        ManejadorPersonal mp;
        ManejadorBitacora mb;
        public static Personal personal = new Personal(0, "", "", "", "", "", "", 0);

        public FrmPersonal()
        {
            InitializeComponent();
            mp = new ManejadorPersonal();
            mb = new ManejadorBitacora();

            DtgDatosPersonal.ReadOnly = true;
            DtgDatosPersonal.AllowUserToAddRows = false;
            DtgDatosPersonal.AllowUserToDeleteRows = false;
            DtgDatosPersonal.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DtgDatosPersonal.MultiSelect = false;
        }

       
        private void ActualizarTabla()
        {
            
            mp.BuscarPersonal(DtgDatosPersonal, TxtBuscador.Text, Properties.Resources.Edit, Properties.Resources.Eliminar_R);
        }

        private void FrmPersonal_Load(object sender, EventArgs e)
        {
            ActualizarTabla();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            ActualizarTabla();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            personal.IdPersonal = 0;
            FrmAgregarPersonal frm = new FrmAgregarPersonal(0);
            frm.ShowDialog();
            ActualizarTabla();
        }

        private void DtgDatosPersonal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow fila = DtgDatosPersonal.Rows[e.RowIndex];

            if (fila.Cells["id_personal"].Value == null || fila.Cells["id_personal"].Value == DBNull.Value) return;

            
            personal.IdPersonal = Convert.ToInt32(fila.Cells["id_personal"].Value);
            personal.Nombre = fila.Cells["nombre"].Value?.ToString() ?? "";
            personal.Apellido = fila.Cells["apellido"].Value?.ToString() ?? "";
            personal.Telefono = fila.Cells["telefono"].Value?.ToString() ?? "";
            personal.Correo = fila.Cells["correo"].Value?.ToString() ?? "";
            personal.Especialidad = fila.Cells["especialidad"].Value?.ToString() ?? "";
            personal.Estado = fila.Cells["estado"].Value?.ToString() ?? "";
            personal.FkidRol = Convert.ToInt32(fila.Cells["fkid_rol"].Value);

            
            string nombreColumna = DtgDatosPersonal.Columns[e.ColumnIndex].Name;

            if (nombreColumna == "Modificar")
            {
                FrmAgregarPersonal frm = new FrmAgregarPersonal(1);
                frm.ShowDialog();
                ActualizarTabla();
            }
            else if (nombreColumna == "Eliminar")
            {
                var rs = MessageBox.Show(
                    $"¿Estás seguro de eliminar a {personal.Nombre}?",
                    "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (rs == DialogResult.Yes)
                {
                    try
                    {
                        mp.Eliminar(personal.IdPersonal);
                        string mensajeAccion = $"Eliminó al miembro del personal: {personal.Nombre} {personal.Apellido}";
                        mb.GuardarBitacora(FrmInicioSesion.IdUsuarioLogueado, mensajeAccion);

                        ActualizarTabla();
                        MessageBox.Show("Personal eliminado correctamente.", "Éxito");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "No se puede eliminar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }
    }
}