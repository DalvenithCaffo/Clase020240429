namespace Ejercicio01
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }


        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "ADMIN" && txtPassword.Text == "ADMIN2024")
            {
                MessageBox.Show("Bienvenido..!");
            }
            else
            {
                MessageBox.Show("Error Usuario/Password ...!");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}
