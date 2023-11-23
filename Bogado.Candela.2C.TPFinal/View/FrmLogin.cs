using Entidades.Clases;
using Entidades.Controladores;

namespace View
{
    public partial class FrmLogin : Form
    {
        private Usuario usuario;

        public FrmLogin()
        {
            InitializeComponent();
            this.usuario = new Usuario();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            string username = txtUsuario.Text;
            string password = txtPass.Text;

            if (username is null || username.Length == 0)
            {
                MessageBox.Show("Debe ingresar un nombre de usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsuario.Focus();
            }
            else if (password is null || password.Length == 0)
            {
                MessageBox.Show("Debe ingresar una contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPass.Focus();
            }
            else if (username is not null && password is not null)
            {
                this.usuario = Usuario_Controlador.GetUsuarioFromUsername(username, password);

                if (username == this.usuario.Username && password == this.usuario.Password)
                {
                    if (this.usuario.IsAdmin)
                    {
                        //Crear nuevo FORM Admin

                    }
                    else
                    {
                        FrmHome_Socio homeSocio = new FrmHome_Socio(this.usuario);
                        this.Close();
                        homeSocio.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos. Vuelva a ingresar sus datos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void lblCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
