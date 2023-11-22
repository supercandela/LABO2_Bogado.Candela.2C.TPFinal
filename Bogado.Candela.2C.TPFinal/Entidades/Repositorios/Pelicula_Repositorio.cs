using Entidades.Clases;
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

        internal static Pelicula GetPeliculaPorId(int id)
        {
            Pelicula pelicula = new Pelicula();

            try
            {
                using (SqlConnection connection = new SqlConnection(GestorSQL.StringConnection))
                {
                    string query = "SELECT * from peliculas WHERE id LIKE @0";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@0", id);
                    connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        pelicula.Id = reader.GetInt32(0);
                        pelicula.Titulo = reader.GetString(1);
                        pelicula.Anio = reader.GetInt32(2);
                        pelicula.Duracion = reader.GetInt32(3);
                        pelicula.Sinopsis = reader.GetString(4);
                        pelicula.Poster = reader.GetString(5);
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }

            return pelicula;
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


        internal static List<Pelicula> GetPeliculasPorArtista(string texto)
        {
            List<Pelicula> listaPeliculas = new List<Pelicula>();

            try
            {
                using (SqlConnection connection = new SqlConnection(GestorSQL.StringConnection))
                {
                    string query =
                        "SELECT " +
                        "p.id, p.titulo, p.anio, p.duracion, p.sinopsis, p.poster, " +
                        "a.nombre_completo, " +
                        "r.rol " +
                        "from peliculas p " +
                        "INNER JOIN roles_en_peliculas rp on p.id = rp.id_pelicula " +
                        "INNER JOIN roles r on r.id = rp.id_rol " +
                        "INNER JOIN artistas a on a.id = rp.id_artista " +
                        "WHERE a.nombre_completo LIKE @0";


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
                        if (reader.GetString(7) == "Dirección")
                        {
                            Artista artista = new Artista(reader.GetString(6));
                            pelicula.Direccion.Add(artista);
                        }
                        else if (reader.GetString(7) == "Actuación")
                        {
                            Artista artista = new Artista(reader.GetString(6));
                            pelicula.Direccion.Add(artista);
                        }

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
