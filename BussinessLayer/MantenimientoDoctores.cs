using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Text;
using DatabaseLayer;
using DatabaseLayer.Models;

namespace BussinessLayer
{
    public class MantenimientoDoctores
    {

        private RepositorioDoctores repository;

        public MantenimientoDoctores(SqlConnection connection)
        {
            repository = new RepositorioDoctores(connection);
        }

        public bool Agregar(Doctores item)
        {
            return repository.Agregar(item);
        }

        public bool Editar(Doctores item)
        {
            return repository.Editar(item);
        }

        public bool Eliminar(int id)
        {
            return repository.Eliminar(id);
        }

        public Doctores GetById(int id)
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
