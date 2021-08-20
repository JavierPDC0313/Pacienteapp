using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DatabaseLayer;
using DatabaseLayer.Models;

namespace BussinessLayer
{
    public class MantenimientoResultadosLaboratorio
    {

        private RepositorioResultadosLaboratorio repository;

        public MantenimientoResultadosLaboratorio(SqlConnection connection)
        {
            repository = new RepositorioResultadosLaboratorio(connection);
        }

        public bool Agregar(ResultadosLaboratorio item)
        {
            return repository.Agregar(item);
        }

        public bool Editar(ResultadosLaboratorio item)
        {
            return repository.Editar(item);
        }

        public bool Eliminar(int id)
        {
            return repository.Eliminar(id);
        }

        public ResultadosLaboratorio GetById(int id)
        {
            return repository.EnlistarUno(id);
        }

        public DataTable GetAll()
        {
            return repository.EnlistarTodo();
        }

        public DataTable GetAllPending()
        {
            return repository.EnlistarPendientes();
        }

    }
}
