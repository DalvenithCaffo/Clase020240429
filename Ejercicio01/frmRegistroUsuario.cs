using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio01
{
    public partial class frmRegistroUsuario : Form
    {
        public frmRegistroUsuario()
        {
            InitializeComponent();
        }

        private void btnAnalizar_Click(object sender, EventArgs e)
        {
            if (chkCasado.Checked)
            {
                lblCasado.BackColor = Color.Red;
            }
            else {
                lblCasado.BackColor = Color.Green;
            }

            if (dtpFechaNacimiento.Value.Year < 2000)
            {
                lblMayorEdad.BackColor = Color.Red;
            }
            else
            {
                lblMayorEdad.BackColor = Color.Green;
            }
        }
    }
}
