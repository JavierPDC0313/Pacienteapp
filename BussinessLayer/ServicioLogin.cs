using DatabaseLayer;
using DatabaseLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace BussinessLayer
{
    public class ServicioLogin
    {
        private RepositorioUsuarios repository;

        public ServicioLogin(SqlConnection connection)
        {
            repository = new RepositorioUsuarios(connection);
        }

        public Usuarios GetByUser(string nombreUsuario)
        {
            return repository.EnlistarPorUsuario(nombreUsuario);
        }

        public bool UserExists(string nombreUsuario)
        {
            return repository.UserExists(nombreUsuario);
        }
    }
}
