using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Database.Models;

namespace Database
{
    public class UsuarioRepositorio
    {

        private SqlConnection _connection;

        public UsuarioRepositorio(SqlConnection connection)
        {
            _connection = connection;
        }

        public bool Agregar(Usuario item)
        {
            SqlCommand command = new SqlCommand("insert into Usuarios(Nombre, Apellido, Correo, Nombre_Usuario, Contraseña, TipoUsuario) values(@nombre,@apellido, @correo, @nombre_usuario, @contraseña, @tipoUsuario)", _connection);

            command.Parameters.AddWithValue("@nombre", item.Nombre);
            command.Parameters.AddWithValue("@apellido", item.Apellido);
            command.Parameters.AddWithValue("@correo", item.Correo);
            command.Parameters.AddWithValue("@nombre_usuario", item.Nombre_Usuario);
            command.Parameters.AddWithValue("@contraseña", item.Contraseña);
            command.Parameters.AddWithValue("@tipoUsuario", item.TipoUsuario);

            return ExecuteDml(command);
        }

        public bool Editar(Usuario item)
        {
            SqlCommand command = new SqlCommand("update Usuarios set Nombre=@nombre, Apellido = @apellido, Correo=@correo, Nombre_Usuario = @nombre_usuario, Contraseña = @contraseña, TipoUsuario = @tipoUsuario where Id = @id", _connection);

            command.Parameters.AddWithValue("@nombre", item.Nombre);
            command.Parameters.AddWithValue("@apellido", item.Apellido);
            command.Parameters.AddWithValue("@correo", item.Correo);
            command.Parameters.AddWithValue("@nombre_usuario", item.Nombre_Usuario);
            command.Parameters.AddWithValue("@contraseña", item.Contraseña);
            command.Parameters.AddWithValue("@tipoUsuario", item.TipoUsuario);
            command.Parameters.AddWithValue("@id", item.id);

            return ExecuteDml(command);
        }

        public bool Eliminar(int id)
        {
            SqlCommand command = new SqlCommand("delete Usuarios where Id = @id", _connection);

            command.Parameters.AddWithValue("@id", id);

            return ExecuteDml(command);
        }


        public DataTable GetAll()
        {
            SqlDataAdapter query = new SqlDataAdapter("select Id, Nombre, Apellido, Correo, Nombre_Usuario, Contraseña, TipoContacto from Usuarios", _connection);

            return LoadData(query);
        }

        public Usuario GetById(int id)
        {
            try
            {
                _connection.Open();

                SqlCommand command = new SqlCommand("select Id, Nombre, Apellido, Correo, Nombre_Usuario, Contraseña, TipoContacto from Usuarios where Id = @id", _connection);

                command.Parameters.AddWithValue("@id", id);

                SqlDataReader reader = command.ExecuteReader();

                Usuario retorno = new Usuario();

                while (reader.Read())
                {
                    retorno.id = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                    retorno.Nombre = reader.IsDBNull(1) ? "" : reader.GetString(1);
                    retorno.Apellido = reader.IsDBNull(2) ? "" : reader.GetString(2);
                    retorno.Correo = reader.IsDBNull(3) ? "" : reader.GetString(3);
                    retorno.Nombre_Usuario = reader.IsDBNull(4) ? "" : reader.GetString(4);
                    retorno.Contraseña = reader.IsDBNull(5) ? "" : reader.GetString(5);
                    retorno.TipoUsuario = reader.IsDBNull(6) ? "" : reader.GetString(6);
                }

                reader.Close();
                reader.Dispose();

                _connection.Close();

                return retorno;
            }
            catch
            {
                return null;
            }
        }

        public bool UserExists(string nombreUsuario)
        {
            try
            {
                bool Exists = true;

                _connection.Open();

                SqlCommand command = new SqlCommand("select Nombre_Usuario from Usuarios where Nombre_Usuario = @nombreUsuario", _connection);

                command.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    if (reader.IsDBNull(0))
                    {
                        Exists = false;
                    }
                }

                reader.Close();
                reader.Dispose();

                _connection.Close();

                return Exists;
            }
            catch
            {
                return false;
            }
        }


        private DataTable LoadData(SqlDataAdapter query)
        {
            try
            {
                DataTable data = new DataTable();

                _connection.Open();

                query.Fill(data);

                _connection.Close();

                return data;
            }
            catch
            {
                return null;
            }
        }

        private bool ExecuteDml(SqlCommand query)
        {
            try
            {
                _connection.Open();

                query.ExecuteNonQuery();

                _connection.Close();

                return true;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);

                return false;
            }
        }

    }
}
