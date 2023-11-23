using System.Windows.Forms;
using Entidades.Clases;
using Entidades.Controladores;

namespace View
{
    public partial class FrmHome_Admin : Form
    {
        private Usuario user;

        public FrmHome_Admin(Usuario user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void FrmHome_Admin_Load(object sender, EventArgs e)
        {
            this.lblBienvenido.Text = $"Bienvenid@, {this.user.Nombre}";
        }

        private void lblCerrarSesion_Click(object sender, EventArgs e)
        {
            FrmHome formHome = new FrmHome();
            formHome.Show();
            this.Close();
        }

        private void lblUsuarios_Click(object sender, EventArgs e)
        {
            FrmAdmin_Usuarios adminUsuarios = new FrmAdmin_Usuarios(this.user);
            adminUsuarios.Show();
            this.Close();
        }

        private void lblPeliculas_Click(object sender, EventArgs e)
        {
            this.LlamarAFormEnConstruccion();
        }

        private void LlamarAFormEnConstruccion()
        {
            FrmEnConstruccion enCons = new FrmEnConstruccion(this.user);
            enCons.Show();
            this.Close();
        }

        private void lblArtistas_Click(object sender, EventArgs e)
        {
            this.LlamarAFormEnConstruccion();
        }
    }
}