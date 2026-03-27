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

    }
}
