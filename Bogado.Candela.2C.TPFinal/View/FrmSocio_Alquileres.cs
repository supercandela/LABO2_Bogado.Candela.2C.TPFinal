using System.Windows.Forms;
using Entidades;
using Entidades.Controladores;

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
            this.lbxListado.Hide();
            this.dgvListado.Hide();
            this.lblBienvenido.Text = $"Bienvenid@, {this.user.Nombre}";
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

            // con el texto del buscador armar la query según radio button

        }

        private void BuscarPeliculasPorTitulo(string texto)
        {
            this.listaPelis = Pelicula_Controlador.GetPeliculasPorTitulo(texto);
        }

        private void ActualizarListadoDePeliculas()
        {
            //lbxListado.DataSource = null;
            this.dgvListado.Rows.Clear();
            if (this.listaPelis is not null && this.listaPelis.Count > 0)
            {
                this.lblSinPeliculas.Hide();

                foreach (Pelicula peli in this.listaPelis)
                {
                    this.dgvListado.AutoGenerateColumns = false;
                    int n = this.dgvListado.Rows.Add(peli.Titulo, peli.Anio.ToString(), peli.Sinopsis);
                    this.dgvListado.Rows[n].Cells[0].Value = peli.Titulo;
                    this.dgvListado.Rows[n].Cells[1].Value = peli.Anio.ToString();
                    this.dgvListado.Rows[n].Cells[2].Value = peli.Sinopsis;
                }

                this.dgvListado.Show();


                this.dgvListado.DataSource = this.listaPelis;
                //this.lbxListado.Show();
                //this.lbxListado.DataSource = this.listaPelis;
            }
            else
            {
                //this.lbxListado.Hide();
                this.dgvListado.Hide();
                this.lblSinPeliculas.Show();
            }
        }
    }
}