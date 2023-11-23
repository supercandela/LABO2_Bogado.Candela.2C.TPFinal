using System.Windows.Forms;
using Entidades.Clases;
using Entidades.Controladores;
using Entidades.Excepciones;

namespace View
{
    public partial class FrmPelicula : Form
    {
        private Usuario user;
        private Pelicula pelicula;
        private Usuario_Controlador usuarioControlador;

        public FrmPelicula(Usuario user, Pelicula pelicula)
        {
            InitializeComponent();
            this.user = user;
            this.pelicula = pelicula;
            this.usuarioControlador = new Usuario_Controlador();
        }

        private void FrmPelicula_Load(object sender, EventArgs e)
        {
            this.pcbPoster.LoadAsync($@"{this.pelicula.Poster}");
            this.lblTitulo.Text = this.pelicula.Titulo;
            this.rtbSinopsis.Text = this.pelicula.Sinopsis;
            this.lblAnio.Text = $"Año: {this.pelicula.Anio}.";
            this.lblDuracion.Text = $"Duración: {this.pelicula.Duracion} minutos.";
            //this.lblDireccion.Text = $"Dirección: {this.pelicula.Direccion[0]}";
            //this.lblActuacion.Text = $"Actuación: {this.pelicula.Actuacion[0]}";

            this.lblVolver.Show();
            this.lblAlquilar.Show();

            this.dtpInicio.Hide();
            this.lblCancelar.Hide();
            this.lblConfirmar.Hide();
            this.lblInicio.Hide();
            this.dtpInicio.Hide();
            this.lblFin.Hide();
            this.dtpFin.Hide();

        }

        private void lblAlquilar_Click(object sender, EventArgs e)
        {
            this.rtbSinopsis.Hide();
            this.lblAnio.Hide();
            this.lblDuracion.Hide();
            this.lblDireccion.Hide();
            this.lblActuacion.Hide();

            this.lblVolver.Hide();
            this.lblAlquilar.Hide();

            this.lblCancelar.Show();
            this.lblConfirmar.Show();
            this.lblInicio.Show();
            this.dtpInicio.Show();
            this.lblFin.Show();
            this.dtpFin.Show();
        }

        private void lblVolver_Click(object sender, EventArgs e)
        {
            FrmSocio_Alquileres formAlquileres = new FrmSocio_Alquileres(this.user);
            formAlquileres.Show();
            this.Close();
        }

        private void lblCancelar_Click(object sender, EventArgs e)
        {
            this.lblCancelar.Hide();
            this.lblConfirmar.Hide();
            this.lblInicio.Hide();
            this.dtpInicio.Hide();
            this.lblFin.Hide();
            this.dtpFin.Hide();

            this.rtbSinopsis.Show();
            this.lblAnio.Show();
            this.lblDuracion.Show();
            this.lblDireccion.Show();
            this.lblActuacion.Show();

            this.lblVolver.Show();
            this.lblAlquilar.Show();
        }

        /// <summary>
        /// Chequea las fechas del alquiler, de manera que el fin sea posterior al inicio.
        /// </summary>
        /// <returns>Bool</returns>
        private bool chequearFechas()
        {
            bool fechasOk = false;
            DateOnly inicio = new DateOnly();
            DateOnly fin = new DateOnly();

            if (fin > inicio)
            {
                fechasOk = true;
            }

            return fechasOk;
        }

        private void lblConfirmar_Click(object sender, EventArgs e)
        {
            if (this.chequearFechas())
            {
                try
                {
                    if (this.usuarioControlador.AlquilarPelicula(this.user.Id, this.pelicula.Id, this.dtpInicio.Value.ToString("MM/dd/yyyy"), this.dtpFin.Value.ToString("MM/dd/yyyy")))
                    {
                        MessageBox.Show("¡Que disfrutes tu película!", "Alquiler exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FrmHome_Socio formSocio = new FrmHome_Socio(this.user);
                        formSocio.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Hubo un error al procesar el alquiler. Vuelve a intentarlo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Las fecha de fin del alquiler es anterior a la fecha de inicio. Revisá los valores.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}