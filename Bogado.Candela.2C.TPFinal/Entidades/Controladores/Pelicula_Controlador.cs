using Entidades.Clases;
using Entidades.Excepciones;
using Entidades.Repositorios;

namespace Entidades.Controladores
{
    public static class Pelicula_Controlador
    {
       public static List<Pelicula> GetPeliculasForHome()
        {
            try
            {
                List<Pelicula> listaPelis = Pelicula_Repositorio.GetPeliculasForHome();
                return listaPelis;
            }
            catch (Exception ex)
            {
                throw new ConexionDBException("Error al conectar a la base de datos.", ex);
            }
        }

        public static Pelicula GetPeliculaPorId(int id)
        {
            try
            {
                Pelicula pelicula = Pelicula_Repositorio.GetPeliculaPorId(id);
                return pelicula;
            }
            catch (Exception ex)
            {
                throw new ConexionDBException("Error al conectar a la base de datos.", ex);
            }
        }

        public static List<Pelicula> GetPeliculasPorTitulo(string texto)
        {
            try
            {
                List<Pelicula> listaPelis = Pelicula_Repositorio.GetPeliculasPorTitulo(texto);
                return listaPelis;
            }
            catch (Exception ex)
            {
                throw new ConexionDBException("Error al conectar a la base de datos.", ex);
            }
        }

        public static List<Pelicula> GetPeliculasPorArtista(string texto)
        {
            try
            {
                List<Pelicula> listaPelis = Pelicula_Repositorio.GetPeliculasPorArtista(texto);
                return listaPelis;
            }
            catch (Exception ex)
            {
                throw new ConexionDBException("Error al conectar a la base de datos.", ex);
            }
        }
    }
}
