using System.Windows.Forms;
using Entidades.Clases;
using Entidades.Controladores;

namespace View
{
    public partial class FrmEnConstruccion : Form
    {
        private Usuario user;

        public FrmEnConstruccion(Usuario user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void FrmEnConstruccion_Load(object sender, EventArgs e)
        {
            this.lblBienvenido.Text = $"Bienvenid@, {this.user.Nombre}";
        }

        private void lblVolver_Click(object sender, EventArgs e)
        {
            FrmHome_Admin homeAdmin = new FrmHome_Admin(this.user);
            homeAdmin.Show();
            this.Close();
        }
    }
}