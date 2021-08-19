using System;
using System.Data.SqlClient;
using Database;
using Database.Models;

namespace BussinessLayer
{
    public class ServicioUsuario
    {

        private UsuarioRepositorio repository;

        public ServicioUsuario (SqlConnection connection)
        {
            repository = new UsuarioRepositorio(connection);
        }

        public bool Agregar(Usuario item)
        {
            return repository.Agregar(item);
        }

        public 
    }
}
