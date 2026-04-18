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
            if(dataTable != null && dataTable.Rows.Count > 0)
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
            Tabla.Columns["Fkid_tratamiento"].Visible=false;
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
    }
}
