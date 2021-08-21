using System;
using System.Data;
using System.Data.SqlClient;
using DatabaseLayer;
using DatabaseLayer.Models;

namespace BussinessLayer
{
    public class ServicioUsuario
    {

        private RepositorioUsuarios repository;

        public ServicioUsuario (SqlConnection connection)
        {
            repository = new RepositorioUsuarios(connection);
        }

        public bool Agregar(Usuarios item)
        {
            return repository.Agregar(item);
        }

        public bool Editar(Usuarios item)
        {
            return repository.Editar(item);
        }

        public bool Eliminar(int id)
        {
            return repository.Eliminar(id);
        }

        public DataTable GetAll()
        {
            return repository.EnlistarTodo();
        }

        public Usuarios GetById(int id)
        {
            return repository.EnlistarUno(id);
        }

        public bool UserExists(string nombreUsuario)
        {
            return repository.UserExists(nombreUsuario);
        }
    }
}
