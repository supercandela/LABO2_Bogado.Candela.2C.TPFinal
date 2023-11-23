using System.Text.Json;
using System.Text;
using System.Windows.Forms;
using Entidades.Clases;
using Entidades.Controladores;
using Entidades.Excepciones;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Runtime.CompilerServices;

namespace View
{
    public partial class FrmAdmin_Usuarios : Form
    {
        private Usuario user;
        private Usuario usuarioEnProceso;
        private bool modoEdicion;
        private Usuario_Controlador usuarioControlador;

        public FrmAdmin_Usuarios(Usuario user)
        {
            InitializeComponent();
            this.user = user;
            this.usuarioEnProceso = new Usuario();
            this.modoEdicion = false;
            this.usuarioControlador = new Usuario_Controlador();
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
                this.lblCrear.ForeColor = Color.LawnGreen;
                this.lblCrear.BackColor = Color.Transparent;
                this.lblEditar.BackColor = Color.LawnGreen;
                this.lblEditar.ForeColor = Color.Transparent;
                this.btnEliminarUsuario.Show();
            }
            else
            {
                this.lblBuscador.Hide();
                this.txtBuscador.Hide();
                this.btnBuscar.Hide();
                this.lblEditar.BackColor = Color.Transparent;
                this.lblEditar.ForeColor = Color.LawnGreen;
                this.lblCrear.ForeColor = Color.Transparent;
                this.lblCrear.BackColor = Color.LawnGreen;
                this.btnEliminarUsuario.Hide();
            }
        }

        private void lblVolver_Click(object sender, EventArgs e)
        {
            FrmHome_Admin formHomeAdmin = new FrmHome_Admin(this.user);
            formHomeAdmin.Show();
            this.Close();
        }

        private void LimpiarCamposForm()
        {
            this.txtBuscador.Text = "";
            this.txtUsername.Text = "";
            this.txtPassword.Text = "";
            this.txtNombre.Text = "";
            this.txtApellido.Text = "";
            this.chbIsAdmin.Checked = false;
        }

        private void lblLimpiar_Click(object sender, EventArgs e)
        {
            this.LimpiarCamposForm();
        }

        private void lblEditar_Click(object sender, EventArgs e)
        {
            this.modoEdicion = true;
            this.MostrarElementosModoEdicion();
            this.LimpiarCamposForm();
        }

        private void lblCrear_Click(object sender, EventArgs e)
        {
            this.modoEdicion = false;
            this.MostrarElementosModoEdicion();
            this.LimpiarCamposForm();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            this.OcultarMensajesDeError();
            if (this.txtUsername.Text.Length > 0 && this.txtPassword.Text.Length > 0
                && this.txtNombre.Text.Length > 0 && this.txtApellido.Text.Length > 0)
            {
                this.usuarioEnProceso.Username = this.txtUsername.Text;
                this.usuarioEnProceso.Password = this.txtPassword.Text;
                this.usuarioEnProceso.Nombre = this.txtNombre.Text;
                this.usuarioEnProceso.Apellido = this.txtApellido.Text;
                this.usuarioEnProceso.IsAdmin = this.chbIsAdmin.Checked;

                if (this.modoEdicion)
                {
                    if (this.txtBuscador.Text.Length > 0 && this.usuarioEnProceso.Id > 0)
                    {
                        if (this.ActualizarDatosUsuario())
                        {
                            MessageBox.Show("Usuario actualizado con éxito.", "Usuario actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Error al actualizar el usuario. Volvé a intentarlo.", "Usuario no actualizado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Debe ingresar un nombre de usuario para buscarlo en los registros.", "Usuario no ingresado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    if (this.CrearUsuarioNuevo())
                    {
                        MessageBox.Show("Usuario creado con éxito.", "Usuario creado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.LimpiarCamposForm();
                    }
                    else
                    {
                        MessageBox.Show("Error al crear el usuario. Buscá el nombre de usuario para ver si no existe en nuestros registros.", "Usuario no creado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
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

        private bool CrearUsuarioNuevo()
        {
            bool pudoCrearUnUsuario = this.usuarioControlador.CrearUsuarioNuevo(this.usuarioEnProceso.Username, this.usuarioEnProceso.Password, this.usuarioEnProceso.Nombre, this.usuarioEnProceso.Apellido, this.usuarioEnProceso.IsAdmin);

            return pudoCrearUnUsuario;
        }

        private bool ActualizarDatosUsuario()
        {
            bool pudoActualizarAlUsuario = this.usuarioControlador.ActualizarDatosUsuario(this.usuarioEnProceso.Id, this.usuarioEnProceso.Username, this.usuarioEnProceso.Password, this.usuarioEnProceso.Nombre, this.usuarioEnProceso.Apellido, this.usuarioEnProceso.IsAdmin);
            return pudoActualizarAlUsuario;
        }

        private bool EliminarUsuario()
        {
            bool pudoEliminarAlUsuario = this.usuarioControlador.EliminarUsuario(this.usuarioEnProceso.Id);
            return pudoEliminarAlUsuario;
        }

        private bool BuscarUsuarioPorUsername()
        {
            bool usuarioEncontrado = false;
            if (this.txtBuscador.Text.Length > 0)
            {
                string usernameABuscar = this.txtBuscador.Text;
                this.usuarioEnProceso = this.usuarioControlador.BuscarUsuarioPorUsername(usernameABuscar);
                if (this.usuarioEnProceso.Id > 0)
                {
                    this.txtUsername.Text = this.usuarioEnProceso.Username;
                    this.txtPassword.Text = this.usuarioEnProceso.Password;
                    this.txtNombre.Text = this.usuarioEnProceso.Nombre;
                    this.txtApellido.Text = this.usuarioEnProceso.Apellido;
                    this.chbIsAdmin.Checked = this.usuarioEnProceso.IsAdmin;

                    usuarioEncontrado = true;
                }
                else
                {
                    MessageBox.Show("No se encontró ningún usuario con ese nombre. Confirme el nombre de usuario o cree un nuevo usuario.", "Usuario no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar un nombre de usuario para buscarlo en los registros.", "Usuario no ingresado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return usuarioEncontrado;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.BuscarUsuarioPorUsername();
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            if (this.txtBuscador.Text.Length > 0 && this.usuarioEnProceso.Id > 0)
            {
                DialogResult respuesta = MessageBox.Show("La siguiente acción elimina al usuario mostrado en pantalla. ¿Desea continuar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {
                    if (this.EliminarUsuario())
                    {
                        MessageBox.Show("El usuario fue eliminado con éxito.", "Usuario eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.LimpiarCamposForm();
                    }
                    else
                    {
                        MessageBox.Show("El usuario no fue eliminado. Vuelva a intentarlo.", "Usuario no eliminado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar un nombre de usuario para buscarlo en los registros.", "Usuario no ingresado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}