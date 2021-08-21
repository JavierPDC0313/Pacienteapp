using System;
using System.Collections.Generic;
using System.Text;
using DatabaseLayer;
using DatabaseLayer.Models;
using System.Data;
using System.Data.SqlClient;

namespace BussinessLayer
{
    public class MantenimientoPruebasLaboratorio
    {

        private RepositorioPruebasLaboratorio repository;

        public MantenimientoPruebasLaboratorio(SqlConnection connection)
        {
            repository = new RepositorioPruebasLaboratorio(connection);
        }

        public bool Agregar(PruebasLaboratorio item)
        {
            return repository.Agregar(item);
        }

        public bool Editar(PruebasLaboratorio item)
        {
            return repository.Editar(item);
        }

        public bool Eliminar(int id)
        {
            return repository.Eliminar(id);
        }

        public PruebasLaboratorio GetById(int id)
        {
            return repository.EnlistarUno(id);
        }

        public DataTable GetAll()
        {
            return repository.EnlistarTodo();
        }

    }
}
