﻿using System;
using DatabaseLayer;
using DatabaseLayer.Models;

namespace BussinessLayer
{
    public class MantenimientoUsuario
    {

        private UsuarioRepositorio repository;

        public ServicioUsuario(SqlConnection connection)
        {
            repository = new UsuarioRepositorio(connection);
        }

        public bool Agregar(Usuario item)
        {
            return repository.Agregar(item);
        }

        public bool Editar(Usuario item)
        {
            return repository.Editar(item);
        }

        public bool Eliminar(int id)
        {
            return repository.Eliminar(id);
        }

        public DataTable GetAll()
        {
            return repository.GetAll();
        }

        public Usuario GetById(int id)
        {
            return repository.GetById(id);
        }

        public bool UserExists(string nombreUsuario)
        {
            return repository.UserExists(nombreUsuario);
        }

    }
}