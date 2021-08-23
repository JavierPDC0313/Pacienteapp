using System;
using System.Collections.Generic;
using System.Text;
using DatabaseLayer;
using DatabaseLayer.Models;
using System.Data.SqlClient;
using System.Data;
using System.IO;

namespace BussinessLayer
{
    public class MantenimientoPacientes
    {

        private RepositorioPacientes repository;

        public MantenimientoPacientes(SqlConnection connection)
        {
            repository = new RepositorioPacientes(connection);
        }

        public bool Agregar(Pacientes item)
        {
            return repository.Agregar(item);
        }

        public bool Editar(Pacientes item)
        {
            return repository.Editar(item);
        }

        public bool Eliminar(int id)
        {
            return repository.Eliminar(id);
        }

        public Pacientes GetById(int id)
        {
            return repository.EnlistarUno(id);
        }

        public DataTable GetAll()
        {
            return repository.EnlistarTodo();
        }

        public int GetLastId()
        {
            return repository.EnlistarUltimoId();
        }

        public void CrearDirectorio(string directory)
        {
            if (!Directory.Exists(directory))
                Directory.CreateDirectory(directory);
        }
    }
}
