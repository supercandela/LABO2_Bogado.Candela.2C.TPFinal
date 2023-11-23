using System.Windows.Forms;

namespace View
{
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            FrmLogin userLogin = new FrmLogin();
            userLogin.Show();
            this.Close();
        }

        private void lblCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}