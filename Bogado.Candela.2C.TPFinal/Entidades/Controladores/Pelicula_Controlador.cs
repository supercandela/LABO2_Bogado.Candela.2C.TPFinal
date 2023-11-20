using Entidades;
using Entidades.Repositorios;

namespace Entidades.Controladores
{
    public static class Pelicula_Controlador
    {
       public static List<Pelicula> GetPeliculasForHome()
        {
            List<Pelicula> listaPelis = new List<Pelicula>();
            listaPelis = Pelicula_Repositorio.GetPeliculasForHome();
            return listaPelis;
        }

        public static List<Pelicula> GetPeliculasPorTitulo(string texto)
        {
            List<Pelicula> listaPelis = new List<Pelicula>();
            listaPelis = Pelicula_Repositorio.GetPeliculasPorTitulo(texto);
            return listaPelis;
        }
    }
}
