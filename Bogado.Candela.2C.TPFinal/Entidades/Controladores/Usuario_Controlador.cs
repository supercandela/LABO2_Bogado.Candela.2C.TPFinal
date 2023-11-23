using Entidades.Clases;
using Entidades.Repositorios;
using Entidades.Interfaces;

namespace Entidades.Controladores
{
    public class Usuario_Controlador : IUsuario
    {
        public Usuario GetUsuarioFromUsername(string username, string password)
        {
            Usuario user = new Usuario();
            if (username != null && username.Length > 0 && password != null && password.Length > 0)
            {
                user = Usuario_Repositorio.GetUsuarioFromUsername(username, password);
            }
            return user;
        }

        public bool AlquilarPelicula(int idUsuario, int idPelicula, string fechaInicio, string fechaFin)
        {
            bool alquilerExitoso = Usuario_Repositorio.AlquilarPelicula(idUsuario, idPelicula, fechaInicio, fechaFin);
            return alquilerExitoso;
        }

        public List<Alquiler> GetHistorialDeAlquileres(int idUsuario)
        {
            List<Alquiler> listaAlq = Usuario_Repositorio.GetHistorialDeAlquileres(idUsuario);
            return listaAlq;
        }

        public bool CrearUsuarioNuevo(string username, string password, string nombre, string apellido, bool isAdmin)
        {
            bool usuarioCreado = Usuario_Repositorio.CrearUsuarioNuevo(username, password, nombre, apellido, isAdmin);
            return usuarioCreado;
        }

        public Usuario BuscarUsuarioPorUsername(string username)
        {
            Usuario user = new Usuario();
            if (username != null && username.Length > 0)
            {
                user = Usuario_Repositorio.BuscarUsuarioPorUsername(username);
            }
            return user;
        }

        public bool ActualizarDatosUsuario(int id, string username, string password, string nombre, string apellido, bool isAdmin)
        {
            bool usuarioActualizado = Usuario_Repositorio.ActualizarDatosUsuario(id, username, password, nombre, apellido, isAdmin);
            return usuarioActualizado;
        }

        public bool EliminarUsuario(int id)
        {
            bool usuarioEliminado = Usuario_Repositorio.EliminarUsuario(id);
            return usuarioEliminado;
        }
    }
}
