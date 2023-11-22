﻿using System.Data.SqlClient;

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
                string mensaje = ex.Message;
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

        public static bool AlquilarPelicula(int idUsuario, int idPelicula, string fechaInicio, string fechaFin)
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
                string mensaje = ex.Message;
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
    }
}
