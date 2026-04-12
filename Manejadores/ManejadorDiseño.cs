using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Manejadores
{
    public class ManejadorDiseño
    {
        // METODO PARA DAR FORMATO A LOS BOTONES (COLOR DE BORDE, FONDO Y REDONDEADO)
        public void EstilosBoton(Button boton, string fondo, string letra)
        {
            int radio = 25;

            boton.FlatStyle = FlatStyle.Flat;
            boton.FlatAppearance.BorderSize = 0;

            boton.BackColor = ColorTranslator.FromHtml($"#{fondo}");
            boton.ForeColor = ColorTranslator.FromHtml($"#{letra}");

            boton.Paint += (sender, e) =>
            {
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                Rectangle rect = new Rectangle(1, 1, boton.Width - 3, boton.Height - 3);

                GraphicsPath gp = new GraphicsPath();
                gp.AddArc(rect.X, rect.Y, radio, radio, 180, 90);
                gp.AddArc(rect.Right - radio, rect.Y, radio, radio, 270, 90);
                gp.AddArc(rect.Right - radio, rect.Bottom - radio, radio, radio, 0, 90);
                gp.AddArc(rect.X, rect.Bottom - radio, radio, radio, 90, 90);
                gp.CloseFigure();

                boton.Region = new Region(gp);
            };
        }



        // METODO PARA QUITAR LOS BORDES EN BOTONES (BOTONES CON IMAGENES)
        public void QuitarBordesBotones(Button boton)
        {
            boton.FlatAppearance.BorderSize = 0;
            boton.FlatStyle = FlatStyle.Flat;
        }

        // METODO PARA DAR FORMATO A LOS TEXT BOX (COLOR DE BORDE, FONDO Y REDONDEADO)
        public void EstilizarTextBox(TextBox txt, string colorFondo, string colorBorde)
        {
            int radio = 45;
            int borde = 2;

            Panel contenedor = new Panel();

            contenedor.BackColor = ColorTranslator.FromHtml($"#{colorFondo}");
            contenedor.Size = new Size(txt.Width + 40, txt.Height + 18);
            contenedor.Location = txt.Location;
            contenedor.ForeColor = Color.Black;
            txt.BorderStyle = BorderStyle.None;
            txt.BackColor = ColorTranslator.FromHtml($"#{colorFondo}");
            txt.Location = new Point(12, 12);
            txt.Width = contenedor.Width - 24;

            contenedor.Paint += (s, e) =>
            {
                Rectangle rect = new Rectangle(
                    borde,
                    borde,
                    contenedor.Width - borde * 2 - 1,
                    contenedor.Height - borde * 2 - 1
                );

                using (GraphicsPath gp = new GraphicsPath())
                {
                    gp.AddArc(rect.X, rect.Y, radio, radio, 180, 90);
                    gp.AddArc(rect.Right - radio, rect.Y, radio, radio, 270, 90);
                    gp.AddArc(rect.Right - radio, rect.Bottom - radio, radio, radio, 0, 90);
                    gp.AddArc(rect.X, rect.Bottom - radio, radio, radio, 90, 90);
                    gp.CloseFigure();

                    e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

                    using (Pen p = new Pen(ColorTranslator.FromHtml($"#{colorBorde}"), 1))
                    {
                        e.Graphics.DrawPath(p, gp);
                    }
                }
            };

            txt.Parent.Controls.Add(contenedor);
            contenedor.Controls.Add(txt);
            txt.BringToFront();
        }
        // METODO PARA DAR FORMATO A LOS COMBOBOX (Color de borde, fondo y redondeado)
        public void EstilizarComboBox(ComboBox cmb, string colorFondo, string colorBorde)
        {
            int radio = 10; // Radio más sutil para no cortar la flecha desplegable
            int borde = 2;

            Panel contenedor = new Panel();
            contenedor.BackColor = ColorTranslator.FromHtml($"#{colorFondo}");
            contenedor.Size = new Size(cmb.Width + 10, cmb.Height + 10);
            contenedor.Location = cmb.Location;

            cmb.FlatStyle = FlatStyle.Flat; 
            cmb.BackColor = ColorTranslator.FromHtml($"#{colorFondo}");
            cmb.Location = new Point(5, 5);
            cmb.Width = contenedor.Width - 10;

            contenedor.Paint += (s, e) =>
            {
                Rectangle rect = new Rectangle(0, 0, contenedor.Width - 1, contenedor.Height - 1);
                using (System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath())
                {
                    gp.AddArc(rect.X, rect.Y, radio, radio, 180, 90);
                    gp.AddArc(rect.Right - radio, rect.Y, radio, radio, 270, 90);
                    gp.AddArc(rect.Right - radio, rect.Bottom - radio, radio, radio, 0, 90);
                    gp.AddArc(rect.X, rect.Bottom - radio, radio, radio, 90, 90);
                    gp.CloseFigure();

                    e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    using (Pen p = new Pen(ColorTranslator.FromHtml($"#{colorBorde}"), borde))
                    {
                        e.Graphics.DrawPath(p, gp);
                    }
                }
            };

            cmb.Parent.Controls.Add(contenedor);
            contenedor.Controls.Add(cmb);
            cmb.BringToFront();
        }

        // METODO PARA DAR FORMATO A LOS DATETIMEPICKER
        public void EstilizarDateTimePicker(DateTimePicker dtp, string colorFondo)
        {
            int radio = 10;

            Panel contenedor = new Panel();
            contenedor.BackColor = ColorTranslator.FromHtml($"#{colorFondo}");
            contenedor.Size = new Size(dtp.Width + 10, dtp.Height + 10);
            contenedor.Location = dtp.Location;
            dtp.Location = new Point(5, 5);
            dtp.Width = contenedor.Width - 10;

            contenedor.Paint += (s, e) =>
            {
                Rectangle rect = new Rectangle(0, 0, contenedor.Width - 1, contenedor.Height - 1);
                using (System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath())
                {
                    gp.AddArc(rect.X, rect.Y, radio, radio, 180, 90);
                    gp.AddArc(rect.Right - radio, rect.Y, radio, radio, 270, 90);
                    gp.AddArc(rect.Right - radio, rect.Bottom - radio, radio, radio, 0, 90);
                    gp.AddArc(rect.X, rect.Bottom - radio, radio, radio, 90, 90);
                    gp.CloseFigure();

                    e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                   
                }
            };

            dtp.Parent.Controls.Add(contenedor);
            contenedor.Controls.Add(dtp);
            dtp.BringToFront();
        }
    }
}
