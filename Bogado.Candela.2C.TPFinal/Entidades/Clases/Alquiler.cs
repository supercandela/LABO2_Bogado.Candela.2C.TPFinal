namespace Entidades.Clases
{
    public class Alquiler
    {
        private int id;
        private int idUsuario;
        private string username;
        private int idPelicula;
        private string tituloPelicula;
        private string fechaInicio;
        private string fechaFin;

        public int Id { get => id; set => id = value; }
        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public string Username { get => username; set => username = value; }
        public int IdPelicula { get => idPelicula; set => idPelicula = value; }
        public string TituloPelicula { get => tituloPelicula; set => tituloPelicula = value; }
        public string FechaInicio { get => fechaInicio; set => fechaInicio = value; }
        public string FechaFin { get => fechaFin; set => fechaFin = value; }

        public Alquiler(int id, int idUsuario, string username, int idPelicula, string tituloPelicula, string fechaInicio, string fechaFin)
        {
            this.id = id;
            this.idUsuario = idUsuario;
            this.username = username;
            this.idPelicula = idPelicula;
            this.tituloPelicula = tituloPelicula;
            this.fechaInicio = fechaInicio;
            this.fechaFin = fechaFin;
        }

        public Alquiler()
            :this(-1, -1, "", -1, "", "", "")
        {

        }
    }
}