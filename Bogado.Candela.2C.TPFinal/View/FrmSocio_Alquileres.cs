using Entidades.Clases;
using Entidades.Controladores;
using Entidades.Excepciones;

namespace View
{
    public partial class FrmSocio_Alquileres : Form
    {
        private Usuario user;
        private List<Pelicula> listaPelis;

        public FrmSocio_Alquileres(Usuario user)
        {
            InitializeComponent();
            this.user = user;
            this.listaPelis = new List<Pelicula>();
        }

        private void FrmSocio_Alquileres_Load(object sender, EventArgs e)
        {
            this.lblSinPeliculas.Hide();
            this.dgvListado.Hide();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (this.txtBuscador is not null && this.txtBuscador.Text.Length > 0)
            {
                if (this.rdbPelicula.Checked)
                {
                    this.BuscarPeliculasPorTitulo(this.txtBuscador.Text);
                    this.ActualizarListadoDePeliculas();
                }
                else if (this.rdbArtista.Checked)
                {
                    this.BuscarPeliculasPorArtista(this.txtBuscador.Text);
                    this.ActualizarListadoDePeliculas();
                }
                else
                {
                    MessageBox.Show("Debe seleccionar el método de búsqueda.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar un texto para su búsqueda.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BuscarPeliculasPorArtista(string texto)
        {
            this.listaPelis = Pelicula_Controlador.GetPeliculasPorArtista(texto);
        }

        private void BuscarPeliculasPorTitulo(string texto)
        {
            this.listaPelis = Pelicula_Controlador.GetPeliculasPorTitulo(texto);
        }

        private void ActualizarListadoDePeliculas()
        {
            this.dgvListado.Rows.Clear();
            if (this.listaPelis is not null && this.listaPelis.Count > 0)
            {
                this.lblSinPeliculas.Hide();

                foreach (Pelicula peli in this.listaPelis)
                {
                    this.dgvListado.Rows.Add(peli.Titulo, peli.Anio.ToString(), peli.Sinopsis, peli.Id);
                }

                this.dgvListado.Show();
            }
            else
            {
                this.dgvListado.Hide();
                this.lblSinPeliculas.Show();
            }
        }

        private void dgvListado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int idPelicula = (int)this.dgvListado.SelectedRows[0].Cells["Id"].Value;

                Pelicula peliSeleccionada = new Pelicula();
                peliSeleccionada = Pelicula_Controlador.GetPeliculaPorId(idPelicula);
                if (peliSeleccionada is not null)
                {
                    FrmPelicula formPelicula = new FrmPelicula(this.user, peliSeleccionada);
                    this.Close();
                    formPelicula.Show();
                }
            }
            catch (Exception ex)
            {
                throw new DataGridClickException("Error al capturar la película elegida.", ex);
            }
        }

        private void lblLimpiar_Click(object sender, EventArgs e)
        {
            this.dgvListado.Rows.Clear();
            this.dgvListado.Hide();
            this.lblSinPeliculas.Hide();
        }

        private void lblVolver_Click(object sender, EventArgs e)
        {
            FrmHome_Socio formSocio = new FrmHome_Socio(this.user);
            formSocio.Show();
            this.Close();
        }
    }
}