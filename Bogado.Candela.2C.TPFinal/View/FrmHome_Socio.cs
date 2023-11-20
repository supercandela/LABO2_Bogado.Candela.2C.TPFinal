using System.Windows.Forms;
using Entidades;
using Entidades.Controladores;

namespace View
{
    public partial class FrmHome_Socio : Form
    {
        private Usuario user;
        private List<Pelicula> listaPelis;

        public FrmHome_Socio(Usuario user)
        {
            InitializeComponent();
            this.user = user;
            this.listaPelis = new List<Pelicula>();
        }

        private void FrmHome_Socio_Load(object sender, EventArgs e)
        {
            this.lblBienvenido.Text = $"Bienvenid@, {this.user.Nombre}";
            this.listaPelis = Pelicula_Controlador.GetPeliculasForHome();
            if (this.listaPelis is not null && this.listaPelis.Count > 0)
            {
                this.pcbPoster1.LoadAsync($@"{this.listaPelis[0].Poster}");
                this.lblTitulo1.Text = this.listaPelis[0].Titulo;
                this.lblAnio1.Text = this.listaPelis[0].Anio.ToString();

                this.pcbPoster2.LoadAsync($@"{this.listaPelis[1].Poster}");
                this.lblTitulo2.Text = this.listaPelis[1].Titulo;
                this.lblAnio2.Text = this.listaPelis[1].Anio.ToString();

                this.pcbPoster3.LoadAsync($@"{this.listaPelis[2].Poster}");
                this.lblTitulo3.Text = this.listaPelis[2].Titulo;
                this.lblAnio3.Text = this.listaPelis[2].Anio.ToString();

                this.pcbPoster4.LoadAsync($@"{this.listaPelis[3].Poster}");
                this.lblTitulo4.Text = this.listaPelis[3].Titulo;
                this.lblAnio4.Text = this.listaPelis[3].Anio.ToString();

                this.pcbPoster5.LoadAsync($@"{this.listaPelis[4].Poster}");
                this.lblTitulo5.Text = this.listaPelis[4].Titulo;
                this.lblAnio5.Text = this.listaPelis[4].Anio.ToString();

                this.pcbPoster6.LoadAsync($@"{this.listaPelis[5].Poster}");
                this.lblTitulo6.Text = this.listaPelis[5].Titulo;
                this.lblAnio6.Text = this.listaPelis[5].Anio.ToString();

                this.pcbPoster7.LoadAsync($@"{this.listaPelis[6].Poster}");
                this.lblTitulo7.Text = this.listaPelis[6].Titulo;
                this.lblAnio7.Text = this.listaPelis[6].Anio.ToString();

                this.pcbPoster8.LoadAsync($@"{this.listaPelis[7].Poster}");
                this.lblTitulo8.Text = this.listaPelis[7].Titulo;
                this.lblAnio8.Text = this.listaPelis[7].Anio.ToString();
            }
        }

        private void lblAlquilar_Click(object sender, EventArgs e)
        {
            FrmSocio_Alquileres alquileres = new FrmSocio_Alquileres(this.user);
            this.Close();
            alquileres.ShowDialog();
        }
    }
}