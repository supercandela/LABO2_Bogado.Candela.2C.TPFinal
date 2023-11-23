using System.Data.SqlClient;
using Entidades.Clases;
using Entidades.Excepciones;
using Microsoft.VisualBasic;

namespace Entidades.Repositorios
{
    internal static class Usuario_Repositorio
    {
        internal static Usuario GetUsuarioFromUsername(string username, string password)
        {
            Usuario user = new Usuario();
            SqlConnection conn = new SqlConnection(GestorSQL.StringConnection);

            try
            {
                string query = $"SELECT * from usuarios WHERE username = @0 AND password = @1";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@0", username);
                cmd.Parameters.AddWithValue("@1", password);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    user.Id = reader.GetInt32(0);
                    user.Username = reader.GetString(1);
                    user.Password = reader.GetString(2);
                    user.Nombre = reader.GetString(3);
                    user.Apellido = reader.GetString(4);
                    user.IsAdmin = reader.GetBoolean(5);
                }
            }
            catch (Exception ex)
            {
                throw new ConexionDBException("Error al conectar a la base de datos.", ex);
            }
            finally
            {
                if (conn != null && conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            return user;
        }

        internal static bool AlquilarPelicula(int idUsuario, int idPelicula, string fechaInicio, string fechaFin)
        {
            bool retorno = false;

            SqlConnection conn = new SqlConnection(GestorSQL.StringConnection);

            try
            {
                string query =
                    "INSERT INTO alquileres (id_usuario, id_pelicula, fecha_inicio, fecha_fin) " +
                    "VALUES (@0, @1, @2, @3)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@0", idUsuario);
                cmd.Parameters.AddWithValue("@1", idPelicula);
                cmd.Parameters.AddWithValue("@2", fechaInicio);
                cmd.Parameters.AddWithValue("@3", fechaFin);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.RecordsAffected > 0)
                {
                    retorno = true;
                }
            }
            catch (Exception ex)
            {
                throw new ConexionDBException("Error al conectar a la base de datos.", ex);
            }
            finally
            {
                if (conn != null && conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
            }

            return retorno;
        }

        internal static List<Alquiler> GetHistorialDeAlquileres(int idUsuario)
        {
            List<Alquiler> listaAlq = new List<Alquiler> ();

            SqlConnection conn = new SqlConnection(GestorSQL.StringConnection);

            try
            {
                string query =
                    "SELECT " +
                    "alq.id, alq.id_usuario, u.username, " +
                    "alq.id_pelicula, p.titulo, alq.fecha_inicio, alq.fecha_fin " +
                    "FROM Alquileres alq " +
                    "INNER JOIN peliculas p on alq.id_pelicula = p.id " +
                    "INNER JOIN usuarios u on alq.id_usuario = u.id " +
                    "WHERE alq.id_usuario = @0 ";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@0", idUsuario);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Alquiler alq = new Alquiler();
                    alq.Id = reader.GetInt32(0);
                    alq.IdUsuario = reader.GetInt32(1);
                    alq.Username = reader.GetString(2);
                    alq.IdPelicula = reader.GetInt32(3);
                    alq.TituloPelicula = reader.GetString(4);
                    alq.FechaInicio = reader.GetDateTime(5).ToString("MM/dd/yyyy");
                    alq.FechaFin = reader.GetDateTime(6).ToString("MM/dd/yyyy");
                    listaAlq.Add(alq);
                }
            }
            catch (Exception ex)
            {
                throw new ConexionDBException("Error al conectar a la base de datos.", ex);
            }
            finally
            {
                if (conn != null && conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
            }

            return listaAlq;
        }

        internal static bool CrearUsuarioNuevo(string username, string password, string nombre, string apellido, bool isAdmin)
        {
            bool usuarioCreado = false;

            SqlConnection conn = new SqlConnection(GestorSQL.StringConnection);

            try
            {
                string query =
                    "IF NOT EXISTS" +
                    "(SELECT username FROM usuarios WHERE username LIKE @0) " +
                    "BEGIN " +
                    "INSERT INTO usuarios " +
                    "(username, password, nombre, apellido, is_admin) " +
                    "VALUES(@1, @2, @3, @4, @5) " +
                    "END";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@0", "%" + username + "%");
                cmd.Parameters.AddWithValue("@1", username);
                cmd.Parameters.AddWithValue("@2", password);
                cmd.Parameters.AddWithValue("@3", nombre);
                cmd.Parameters.AddWithValue("@4", apellido);
                cmd.Parameters.AddWithValue("@5", isAdmin);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.RecordsAffected > 0)
                {
                    usuarioCreado = true;
                }
            }
            catch (Exception ex)
            {
                throw new ConexionDBException("Error al conectar a la base de datos.", ex);
            }
            finally
            {
                if (conn != null && conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
            }

            return usuarioCreado;
        }

        internal static Usuario BuscarUsuarioPorUsername(string username)
        {
            Usuario user = new Usuario();
            SqlConnection conn = new SqlConnection(GestorSQL.StringConnection);

            try
            {
                string query = $"SELECT * from usuarios WHERE username LIKE @0";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@0", "%" + username + "%");
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    user.Id = reader.GetInt32(0);
                    user.Username = reader.GetString(1);
                    user.Password = reader.GetString(2);
                    user.Nombre = reader.GetString(3);
                    user.Apellido = reader.GetString(4);
                    user.IsAdmin = reader.GetBoolean(5);
                }
            }
            catch (Exception ex)
            {
                throw new ConexionDBException("Error al conectar a la base de datos.", ex);
            }
            finally
            {
                if (conn != null && conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            return user;
        }

        internal static bool ActualizarDatosUsuario(int id, string username, string password, string nombre, string apellido, bool isAdmin)
        {
            bool usuarioActualizado = false;

            SqlConnection conn = new SqlConnection(GestorSQL.StringConnection);

            try
            {
                string query =
                    "UPDATE usuarios SET " +
                    "username = @0, " +
                    "password = @1, " +
                    "nombre = @2, " +
                    "apellido = @3 ," +
                    "is_admin = @4 " +
                    "WHERE id = @5";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@0", username);
                cmd.Parameters.AddWithValue("@1", password);
                cmd.Parameters.AddWithValue("@2", nombre);
                cmd.Parameters.AddWithValue("@3", apellido);
                cmd.Parameters.AddWithValue("@4", isAdmin);
                cmd.Parameters.AddWithValue("@5", id);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.RecordsAffected > 0)
                {
                    usuarioActualizado = true;
                }
            }
            catch (Exception ex)
            {
                throw new ConexionDBException("Error al conectar a la base de datos.", ex);
            }
            finally
            {
                if (conn != null && conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
            }

            return usuarioActualizado;
        }

        internal static bool EliminarUsuario(int id)
        {
            bool usuarioEliminado = false;

            SqlConnection conn = new SqlConnection(GestorSQL.StringConnection);

            try
            {
                string query =
                    "DELETE FROM usuarios WHERE id = @0";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@0", id);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.RecordsAffected > 0)
                {
                    usuarioEliminado = true;
                }
            }
            catch (Exception ex)
            {
                throw new ConexionDBException("Error al conectar a la base de datos.", ex);
            }
            finally
            {
                if (conn != null && conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
            }

            return usuarioEliminado;
        }
    }
}
