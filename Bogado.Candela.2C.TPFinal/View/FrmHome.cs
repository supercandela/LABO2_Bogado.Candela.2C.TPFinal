using System.Windows.Forms;

namespace View
{
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
        }

        private void FrmHome_Load(object sender, EventArgs e)
        {

        }

        private void pictBoxHome_Click(object sender, EventArgs e)
        {

        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            FrmLogin userLogin = new FrmLogin();
            //this.Hide();
            userLogin.ShowDialog();
        }
    }
}