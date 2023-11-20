namespace Entidades
{
    public class Pelicula
    {
        private int id;
        private string titulo;
        private int anio;
        private int duracion;
        private string sinopsis;
        private string poster;

        public int Id { get => id; set => id = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public int Anio { get => anio; set => anio = value; }
        public int Duracion { get => duracion; set => duracion = value; }
        public string Sinopsis { get => sinopsis; set => sinopsis = value; }
        public string Poster { get => poster; set => poster = value; }

        public Pelicula(int id, string titulo, int anio, int duracion, string sinopsis, string poster)
        {
            this.id = id;
            this.titulo = titulo;
            this.anio = anio;
            this.duracion = duracion;
            this.sinopsis = sinopsis;
            this.poster = poster;
        }

        public Pelicula()
            : this( -1, "", 0, 0, "", "")
        {

        }
    }
}
