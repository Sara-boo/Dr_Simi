using AccesoDatos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manejadores
{
    public class ManejadorLogin
    {
        Base b = new Base();

        public bool Validar(TextBox usuario, TextBox clave)
        {

            DataTable dt = b.Consultar($"call p_ValidarLogin('{usuario.Text}','{Sha1(clave.Text)}')", "tbl_usuarios").Tables[0];
            DataRow dr = dt.Rows[0];
            if (dr["rs"].ToString().Equals("Ac3ptad0"))
                return true;
            else
                return false;
        }


        //METODO PARA MOSTRAR CONTRASEÑA O OCULTARLA
        public void MostrarOcultarContrasena(TextBox caja, bool mostrar)
        {
            if (mostrar)
            {
                caja.PasswordChar = '\0';
            }
            else
            {
                caja.PasswordChar = '*';
            }
        }

           

       //METODO PARA OBTENER EL NOMBRE DEL USUARIO QUE INICIA SESION
       public string ObtenerNombre(string username)
        {
            DataTable dt = b.Consultar($"SELECT nombre_completo FROM v_NombreUsuario WHERE username = '{username}'", "v_NombreUsuario").Tables[0];
            return dt.Rows[0]["nombre_completo"].ToString();
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
            foreach(TextBox item in cajas)
            {
                if(string.IsNullOrEmpty(item.Text))
                    return false;
                
            }

            return true;

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
        public DataRow ObtenerDatosCompletos(string username)
        {
            DataTable dt = b.Consultar($"SELECT * FROM v_NombreUsuario WHERE username = '{username}'", "v_NombreUsuario", false).Tables[0];
            if (dt.Rows.Count > 0)
            {
                return dt.Rows[0]; 
            }

            return null;
        }

    }
}
