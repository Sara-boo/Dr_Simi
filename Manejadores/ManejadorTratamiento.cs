using AccesoDatos;
using Entidades;
using Manejadores;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Manejadores
{
    public class ManejadorTratamiento
    {
        Base b = new Base();
        public void MostrarAlergiasEnfermedades(string consulta, DataGridView tabla, string datos)
        {
            tabla.Columns.Clear();
            tabla.DataSource = b.Consultar(consulta, datos).Tables[0];
            tabla.AutoResizeColumns();
            tabla.AutoResizeRows();
        }
        public void LlenarMedicamentos(ComboBox cmb)
        {
            cmb.DataSource = b.Consultar("SELECT DISTINCT nombre FROM tbl_medicamentos ORDER BY nombre", "tbl_medicamentos").Tables[0];
            cmb.DisplayMember = "nombre";
            cmb.ValueMember = "nombre";
        }
        public void CargarPresentaciones(string consulta, ComboBox presentacion, string nombre)
        {
            DataTable dataTable = b.Consultar(consulta, nombre).Tables[0];
            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                presentacion.DataSource = dataTable;
                presentacion.DisplayMember = "Info";
                presentacion.ValueMember = "id_medicamento";
            }
            else
            {
                presentacion.DataSource = null;
            }
        }
        public void GuardarMedicamento(DetalleTratamiento detalle, List<DetalleTratamiento> lista)
        {
            lista.Add(detalle);
        }
        public void MostrarMedicamentos(List<DetalleTratamiento> lista, DataGridView Tabla)
        {
            Tabla.Columns.Clear();
            Tabla.DefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            Tabla.DataSource = lista.ToList();
            Tabla.Columns["Id_detalle"].Visible = false;
            Tabla.Columns["Fkid_tratamiento"].Visible = false;
            Tabla.Columns["Fkid_medicamento"].Visible = false;
            Tabla.Columns["NombreParaMostrar"].HeaderText = "Medicamento";
            Tabla.Columns.Insert(8, Boton("-", Color.Red));
            Tabla.AutoResizeColumns();
            Tabla.AutoResizeRows();
        }
        public void BorrarMedicamento(List<DetalleTratamiento> lista, int fila)
        {
            lista.RemoveAt(fila);
        }
        DataGridViewButtonColumn Boton(string texto, Color fondo)
        {
            DataGridViewButtonColumn MiBoton = new DataGridViewButtonColumn();
            MiBoton.Text = texto;
            MiBoton.UseColumnTextForButtonValue = true;
            MiBoton.FlatStyle = FlatStyle.Popup;
            MiBoton.DefaultCellStyle.BackColor = fondo;
            MiBoton.DefaultCellStyle.ForeColor = Color.White;
            return MiBoton;
        }
        public void GuardarTratamiento(Tratamiento cabecera, List<DetalleTratamiento> detalles)
        {
            try
            {
                string sqlCabecera = $"INSERT INTO tbl_tratamiento (fkid_historial,descripcion_sintomas,fkid_usuario) VALUES ({cabecera.Fkid_historial},'{cabecera.Descripcion}',{cabecera.Fkid_usuario})";
                b.Comando(sqlCabecera, true);

                DataSet dsId= b.Consultar("SELECT LAST_INSERT_ID() AS id_tratamiento", "temp",true);
                int idTratamiento= int.Parse(dsId.Tables[0].Rows[0]["id_tratamiento"].ToString());

                foreach(var item in detalles)
                {
                    string sqlDetalle = $"INSERT INTO tbl_detalle_tratamiento (fkid_tratamiento,fkid_medicamento,cantidad,dosis,frecuencia,duracion) VALUES ({idTratamiento},{item.Fkid_medicamento},{item.Cantidad},'{item.Dosis}','{item.Frecuencia}','{item.Duracion}')";
                    b.Comando(sqlDetalle, true);

                    string sqlSalida= $"CALL p_registrar_salida_inventario({item.Fkid_medicamento}, {item.Cantidad}, {cabecera.Fkid_usuario}, 'Receta Médica - Tratamiento #{idTratamiento}')";
                    b.Comando(sqlSalida, true);

                    b.Consultar("SELECT 1", "temp", false);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrió un error al guardar el tratamiento. Por favor, inténtelo de nuevo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
