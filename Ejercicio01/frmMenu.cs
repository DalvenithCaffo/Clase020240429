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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmLogin form1 = new frmLogin();
            //Showdialog hace como una emergente sin permitirme darle click atras
            //form1.Show();
            form1.ShowDialog();
        }

        private void btnRegistroUsuario_Click(object sender, EventArgs e)
        {
            frmRegistroUsuario frm = new frmRegistroUsuario();
            frm.Show();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            frmRegistroProducto frm = new frmRegistroProducto();
            frm.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistroProducto form = new frmRegistroProducto();
            form.ShowDialog();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistroUsuario frm = new frmRegistroUsuario();
            frm.ShowDialog();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            frm.ShowDialog();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();    
        }
    }
}
