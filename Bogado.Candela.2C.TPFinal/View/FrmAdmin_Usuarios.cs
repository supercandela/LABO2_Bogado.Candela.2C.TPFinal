using System.Windows.Forms;
using Entidades.Clases;
using Entidades.Controladores;

namespace View
{
    public partial class FrmAdmin_Usuarios : Form
    {
        private Usuario user;
        private Usuario usuarioEnProceso;
        private bool modoEdicion;

        public FrmAdmin_Usuarios(Usuario user)
        {
            InitializeComponent();
            this.user = user;
            this.usuarioEnProceso = new Usuario();
            this.modoEdicion = false;
        }

        private void FrmAdmin_Usuarios_Load(object sender, EventArgs e)
        {
            this.OcultarMensajesDeError();
            this.MostrarElementosModoEdicion();
        }

        private void OcultarMensajesDeError()
        {
            this.lblErrorUsername.Hide();
            this.lblErrorPassword.Hide();
            this.lblErrorNombre.Hide();
            this.lblErrorApellido.Hide();
        }

        private void MostrarElementosModoEdicion()
        {
            if (this.modoEdicion)
            {
                this.lblBuscador.Show();
                this.txtBuscador.Show();
                this.btnBuscar.Show();
            }
            else
            {
                this.lblBuscador.Hide();
                this.txtBuscador.Hide();
                this.btnBuscar.Hide();
            }
        }

        private void lblVolver_Click(object sender, EventArgs e)
        {
            FrmHome_Admin formHomeAdmin = new FrmHome_Admin(this.user);
            formHomeAdmin.ShowDialog();
            this.Close();
        }

        private void lblLimpiar_Click(object sender, EventArgs e)
        {
            this.txtBuscador.Text = "";
            this.txtUsername.Text = "";
            this.txtPassword.Text = "";
            this.txtNombre.Text = "";
            this.txtApellido.Text = "";
            this.chbIsAdmin.Checked = false;
        }

        private void lblEditar_Click(object sender, EventArgs e)
        {
            this.modoEdicion = true;
            this.MostrarElementosModoEdicion();
        }

        private void lblCrear_Click(object sender, EventArgs e)
        {
            this.modoEdicion = false;
            this.MostrarElementosModoEdicion();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (this.txtUsername.Text.Length > 0 && this.txtPassword.Text.Length > 0
                && this.txtNombre.Text.Length > 0 && this.txtApellido.Text.Length > 0)
            {
                this.usuarioEnProceso.Username = this.txtUsername.Text;
                this.usuarioEnProceso.Password = this.txtPassword.Text;
                this.usuarioEnProceso.Nombre = this.txtNombre.Text;
                this.usuarioEnProceso.Apellido = this.txtApellido.Text;
                this.usuarioEnProceso.IsAdmin = this.chbIsAdmin.Checked;

                //Al confirmar, ver si está el modo edición o no
                if (this.modoEdicion)
                {
                    //en modo edición, hacer un update del usuario

                }
                else
                {
                    //en modo crear, chequear que no se repita el username y agregarlo

                }
            }
            else
            {
                if (this.txtUsername.Text.Trim() == "")
                {
                    this.lblErrorUsername.Show();
                }
                if (this.txtPassword.Text.Trim() == "")
                {
                    this.lblErrorPassword.Show();
                }
                if (this.txtNombre.Text.Trim() == "")
                {
                    this.lblErrorNombre.Show();
                }
                if (this.txtApellido.Text.Trim() == "")
                {
                    this.lblErrorApellido.Show();
                }
            }
        }
    }
}