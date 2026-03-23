using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogClinic
{
    public partial class FrmSeguimientoRegistroInventario : Form
    {
        public FrmSeguimientoRegistroInventario()
        {
            InitializeComponent();
            btnCancelar.BackColor = Color.FromArgb(94, 226, 252, 214);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
