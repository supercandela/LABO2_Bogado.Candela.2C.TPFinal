﻿using Entidades;
using Entidades.Repositorios;

namespace Entidades.Controladores
{
    public static class Usuario_Controlador
    {

        public static Usuario GetUsuarioFromUsername(string username, string password)
        {
            Usuario user = new Usuario();
            if (username != null && username.Length > 0 && password != null && password.Length > 0)
            {
                user = Usuario_Repositorio.GetUsuarioFromUsername(username, password);
            }
            return user;
        }

    }
}