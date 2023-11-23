using Entidades.Clases;
using Entidades.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Interfaces
{
    internal interface IUsuario
    {
        Usuario GetUsuarioFromUsername(string username, string password);
        bool AlquilarPelicula(int idUsuario, int idPelicula, string fechaInicio, string fechaFin);
        List<Alquiler> GetHistorialDeAlquileres(int idUsuario);
        bool CrearUsuarioNuevo(string username, string password, string nombre, string apellido, bool isAdmin);
        Usuario BuscarUsuarioPorUsername(string username);
        bool ActualizarDatosUsuario(int id, string username, string password, string nombre, string apellido, bool isAdmin);
        bool EliminarUsuario(int id);


    }
}