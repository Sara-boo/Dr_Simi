using AccesoDatos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manejadores
{
    public class ManejadorUsuarios
    {
        Base b = new Base();
        public string Guardar(Usuarios usuario)
        {
       
           DataSet ds = b.Consultar($"CALL p_InsertarUsuario('{usuario.UserName}', '{usuario.Password}', {usuario.Activo}, {usuario.IdPersonal})", "resultado");

            return ds.Tables[0].Rows[0]["msg"].ToString();
        }
        

        public void Editar(Usuarios usuario)
        {
            b.Comando($"CALL p_EditarUsuario({usuario.IdUsuario}, '{usuario.UserName}', '{usuario.Password}',{usuario.IdPersonal}, {usuario.Activo})");
        }

        public void Estado(Usuarios usuario)
        {
            if (usuario.Activo)
            {
                
                var rs = MessageBox.Show(
                    $"¿Desea desactivar al usuario {usuario.UserName}?",
                    "ATENCIÓN",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );
                if (rs == DialogResult.Yes)
                    b.Comando($"CALL p_EstadoUsuario({usuario.IdUsuario})");
            }
            else
            {
                
                b.Comando($"CALL p_EstadoUsuario({usuario.IdUsuario})");
            }
        }
        public void Mostrar(string consulta, DataGridView tabla, string datos)
        {
            var boton = ColorTranslator.FromHtml($"#E2FCD6");
            tabla.Columns.Clear();
            tabla.DataSource = b.Consultar(consulta, datos).Tables[0];

            tabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            tabla.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            tabla.Columns["id_usuario"].Visible = false;
            tabla.Columns["id_personal"].Visible = false;
            tabla.Columns["password"].Visible = false;
            tabla.Columns["created_at"].Visible = false;
            tabla.Columns["updated_at"].Visible = false;
            foreach (DataGridViewColumn col in tabla.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter; 
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; 
            }
            tabla.Columns["Usuario"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            tabla.Columns.Add(Boton("Editar", boton, true)); 

            
        }
        public static DataGridViewButtonColumn Boton(string titulo, Color fondo, bool nombre)
        {
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.Text = titulo;
            btn.UseColumnTextForButtonValue = nombre;
            btn.FlatStyle = FlatStyle.Popup;
            btn.DefaultCellStyle.BackColor = fondo;
            btn.DefaultCellStyle.ForeColor = Color.Black;
            return btn;

        }

        public void LlenarPersonal(ComboBox caja)
        {
            DataTable dt = b.Consultar("SELECT * FROM v_PersonalSinUsuario", "v_PersonalSinUsuario").Tables[0];
            caja.DataSource = dt;
            caja.DisplayMember = "nombre_completo";
            caja.ValueMember = "id_personal"; 
        }

        public void LlenarEstatus(ComboBox caja)
        {
            var valores = new List<object>{
        new { Texto = "Activo",   Valor = true  },
        new { Texto = "Inactivo", Valor = false }};

            caja.DataSource = valores;
            caja.DisplayMember = "Texto";  
            caja.ValueMember = "Valor";    
        }

        //METODO PARA ENCRIPTADO DE CONTRASEÑA
        public static string Sha1(string texto)
        {
            SHA1 sha1 = SHA1CryptoServiceProvider.Create();
            Byte[] textOriginal = ASCIIEncoding.Default.GetBytes(texto);
            Byte[] hash = sha1.ComputeHash(textOriginal);
            StringBuilder cadena = new StringBuilder();

            foreach (byte i in hash)
            {
                cadena.AppendFormat("{0:x2}", i);
            }
            return cadena.ToString();
        }

        //METODO PARA LIMPIAR LAS CAJAS DE TEXTO
        public void LimipiarCajas(TextBox caja1, TextBox caja2)
        {
            caja1.Clear();
            caja2.Clear();
        }

        //METODO PARA VERIFICAR QUE EL USUARIO INGRESE TODOS LOS DATOS DE INICIO DE SESION 
        public bool ValidarCajasVacias(params TextBox[] cajas)
        {
            foreach (TextBox item in cajas)
            {
                if (string.IsNullOrEmpty(item.Text))
                    return false;

            }

            return true;

        }
        public void EstilizarDataGrid(DataGridView dgv)
        {
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AllowUserToResizeRows = false;
            dgv.AllowUserToResizeColumns = false;
            dgv.ReadOnly = true;
            dgv.RowHeadersVisible = false; // Oculta la columna vacía de la izquierda
            dgv.AutoResizeColumns();
            dgv.AutoResizeRows();
            dgv.MultiSelect = false;

            //Colores y bordes generales
            dgv.BorderStyle = BorderStyle.None;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal; // Solo líneas horizontales
            dgv.GridColor = ColorTranslator.FromHtml("#B4B2B2"); // Color de las líneas divisorias 

            //Estilo del encabezado
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Lucida Bright", 16F, FontStyle.Bold);
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.ColumnHeadersHeight = 45;

            //Estilo de las filas
            dgv.DefaultCellStyle.BackColor = Color.White;
            dgv.DefaultCellStyle.ForeColor = Color.Black;
            dgv.DefaultCellStyle.Font = new Font("Lucida Bright", 14F, FontStyle.Regular);
            dgv.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            //Altura de las filas
            dgv.RowTemplate.Height = 50; // Filas más altas para que no se vea tan feo
            dgv.DefaultCellStyle.Padding = new Padding(5); // Margen interno
        }

    }
}
