namespace Entidades
{
    public class Usuario
    {
        private int id;
        private string username;
        private string password;
        private string nombre;
        private string apellido;
        private bool isAdmin;

        public int Id { get => id; set => id = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public bool IsAdmin { get => isAdmin; set => isAdmin = value; }
        
        public Usuario(int id, string username, string password, string nombre, string apellido, bool isAdmin)
        {
            this.id = id;
            this.username = username;
            this.password = password;
            this.nombre = nombre;
            this.apellido = apellido;
            this.isAdmin = isAdmin;
        }

        public Usuario()
            : this(-1,"", "", "", "", false)
        {

        }
    }
}