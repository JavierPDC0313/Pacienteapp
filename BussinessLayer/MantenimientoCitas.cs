using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DatabaseLayer;
using DatabaseLayer.Models;

namespace BussinessLayer
{
    public class MantenimientoCitas
    {

        private RepositorioCitas repository;

        public MantenimientoCitas(SqlConnection connection)
        {
            repository = new RepositorioCitas(connection);
        }

        public bool Agregar(Citas item)
        {
            return repository.Agregar(item);
        }

        public bool Editar(Citas item)
        {
            return repository.Editar(item);
        }

        public bool Eliminar(int id)
        {
            return repository.Eliminar(id);
        }

        public bool UpdateStatus(int status, int id)
        {
            return repository.UpdateStatus(status, id);
        }

        public Citas GetById(int id)
        {
            return repository.EnlistarUno(id);
        }

        public DataTable GetAll()
        {
            return repository.EnlistarTodo();
        }

    }
}
