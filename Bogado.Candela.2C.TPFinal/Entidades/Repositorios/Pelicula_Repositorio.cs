using System.Data.SqlClient;

namespace Entidades.Repositorios
{
    internal class Pelicula_Repositorio
    {
        internal static List<Pelicula> GetPeliculasForHome()
        {
            List<Pelicula> listaPeliculas = new List<Pelicula>();

            try
            {
                using (SqlConnection connection = new SqlConnection(GestorSQL.StringConnection))
                {
                    string query = "SELECT TOP 8 * from peliculas";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Pelicula pelicula = new Pelicula();
                        pelicula.Id = reader.GetInt32(0);
                        pelicula.Titulo = reader.GetString(1);
                        pelicula.Anio = reader.GetInt32(2);
                        pelicula.Duracion = reader.GetInt32(3);
                        pelicula.Sinopsis = reader.GetString(4);
                        pelicula.Poster = reader.GetString(5);

                        listaPeliculas.Add(pelicula);
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return listaPeliculas;
        }

        internal static List<Pelicula> GetPeliculasPorTitulo(string texto)
        {
            List<Pelicula> listaPeliculas = new List<Pelicula>();

            try
            {
                using (SqlConnection connection = new SqlConnection(GestorSQL.StringConnection))
                {
                    string query = "SELECT * from peliculas WHERE titulo LIKE @0";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@0", "%" + texto + "%");
                    connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Pelicula pelicula = new Pelicula();
                        pelicula.Id = reader.GetInt32(0);
                        pelicula.Titulo = reader.GetString(1);
                        pelicula.Anio = reader.GetInt32(2);
                        pelicula.Duracion = reader.GetInt32(3);
                        pelicula.Sinopsis = reader.GetString(4);
                        pelicula.Poster = reader.GetString(5);

                        listaPeliculas.Add(pelicula);
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return listaPeliculas;
        }
    }
}
