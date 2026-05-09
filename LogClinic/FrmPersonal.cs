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

            DtgDatosPersonal.ReadOnly = true;                    // Evita modo edición
            DtgDatosPersonal.AllowUserToAddRows = false;         // Quita la fila vacía del final
            DtgDatosPersonal.AllowUserToDeleteRows = false;      // Evita borrado con teclado
            DtgDatosPersonal.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DtgDatosPersonal.MultiSelect = false;
        }

        private void FrmPersonal_Load(object sender, EventArgs e)
        {
            mp.BuscarPersonal(DtgDatosPersonal, "");
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            mp.BuscarPersonal(DtgDatosPersonal, TxtBuscador.Text);
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            personal.IdPersonal = 0;

            FrmAgregarPersonal frm = new FrmAgregarPersonal(0); // 0 = Agregar
            frm.ShowDialog();

            mp.BuscarPersonal(DtgDatosPersonal, "");
        }

        // Este evento detecta los clics dentro de la tabla
        private void DtgDatosPersonal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow fila = DtgDatosPersonal.Rows[e.RowIndex];

            if (fila.Cells["id_personal"].Value == null ||
                fila.Cells["id_personal"].Value == DBNull.Value) return;

            personal.IdPersonal = Convert.ToInt32(fila.Cells["id_personal"].Value);
            personal.Nombre = fila.Cells["nombre"].Value?.ToString() ?? "";
            personal.Apellido = fila.Cells["apellido"].Value?.ToString() ?? "";
            personal.Telefono = fila.Cells["telefono"].Value?.ToString() ?? "";
            personal.Correo = fila.Cells["correo"].Value?.ToString() ?? "";
            personal.Especialidad = fila.Cells["especialidad"].Value?.ToString() ?? "";
            personal.Estado = fila.Cells["estado"].Value?.ToString() ?? "";
            personal.FkidRol = Convert.ToInt32(fila.Cells["fkid_rol"].Value);

            string nombreColumna = DtgDatosPersonal.Columns[e.ColumnIndex].HeaderText.Trim().ToLower();

            if (nombreColumna == "modificar")
            {
                FrmAgregarPersonal frm = new FrmAgregarPersonal(1);
                frm.ShowDialog();
                mp.BuscarPersonal(DtgDatosPersonal, "");
            }
            else if (nombreColumna == "eliminar")
            {
                var rs = MessageBox.Show(
                    $"¿Estás seguro de eliminar a {personal.Nombre}?",
                    "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (rs == DialogResult.Yes)
                {
                    try
                    {
                        mp.Eliminar(personal.IdPersonal);

                        // Creamos un mensaje descriptivo que incluya el nombre del afectado en la bitacora
                        string mensajeAccion = $"Eliminó al miembro del personal: {personal.Nombre} {personal.Apellido})";
                        mb.GuardarBitacora(FrmInicioSesion.IdUsuarioLogueado, mensajeAccion);

                        mp.BuscarPersonal(DtgDatosPersonal, "");
                        MessageBox.Show("Personal eliminado correctamente y registrado en bitácora.", "Éxito");
                    }
                    catch (MySql.Data.MySqlClient.MySqlException ex)
                    {
                        MessageBox.Show(ex.Message, "No se puede eliminar",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }
    }
}