using Entidades;
using Entidades.Controladores;

namespace ConsoleTest
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string username = "alejandro";
            string password = "socio1234";
            Usuario user;
            user = Usuario_Controlador.GetUsuarioFromUsername(username, password);

            Console.WriteLine(user.Id);
            Console.WriteLine(user.Username);
            Console.WriteLine(user.Password);
            Console.WriteLine(user.Nombre);
            Console.WriteLine(user.Apellido);
            Console.WriteLine(user.IsAdmin);
        }
    }
}