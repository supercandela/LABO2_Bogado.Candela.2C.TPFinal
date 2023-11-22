namespace Entidades.Clases
{
    public class Artista
    {
        private string nombreCompleto;

        public string NombreCompleto { get => nombreCompleto; set => nombreCompleto = value; }

        public Artista (string nombre) 
        {
            this.nombreCompleto = nombre;
        }

        public Artista ()
            : this("")
        {

        }
    }
}
