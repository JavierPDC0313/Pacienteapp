using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using Database.Models;

namespace Database
{
    public class PacientesRepositorio
    {

        private SqlConnection _connection;

        public PacientesRepositorio(SqlConnection connection)
        {
            _connection = connection;
        }

        public bool Agregar(Paciente item)
        {
            SqlCommand command = new SqlCommand("insert into Pacientes(Nombre, Apellido, Telefono, Direccion, Cedula, FechaNacimiento, Fumador, Alergias, foto) values(@nombre,@apellido, @telefono, @direccion, @cedula, @fechaNacimiento, @fumador, @alergias, @foto)", _connection);

            command.Parameters.AddWithValue("@nombre", item.Nombre);
            command.Parameters.AddWithValue("@apellido", item.Apellido);
            command.Parameters.AddWithValue("@telefono", item.Telefono);
            command.Parameters.AddWithValue("@direccion", item.Direccion);
            command.Parameters.AddWithValue("@cedula", item.Cedula);
            command.Parameters.AddWithValue("@fechaNacimiento", item.FechaNacimiento);
            command.Parameters.AddWithValue("@fumador", item.Fumador);
            command.Parameters.AddWithValue("@alergias", item.Alergias);
            command.Parameters.AddWithValue("@foto", item.Foto);

            return ExecuteDml(command);
        }

        public bool Editar(Paciente item)
        {
            SqlCommand command = new SqlCommand("update Pacientes set Nombre=@nombre, Apellido = @apellido, Telefono=@telefono, Direccion = @direccion, Cedula = @cedula, FechaNacimiento = @fechaNacimiento, Fumador = @fumador, Alergias = @alergias, foto = @foto where Id = @id", _connection);

            command.Parameters.AddWithValue("@nombre", item.Nombre);
            command.Parameters.AddWithValue("@apellido", item.Apellido);
            command.Parameters.AddWithValue("@telefono", item.Telefono);
            command.Parameters.AddWithValue("@direccion", item.Direccion);
            command.Parameters.AddWithValue("@cedula", item.Cedula);
            command.Parameters.AddWithValue("@fechaNacimiento", item.FechaNacimiento);
            command.Parameters.AddWithValue("@fumador", item.Fumador);
            command.Parameters.AddWithValue("@alergias", item.Alergias);
            command.Parameters.AddWithValue("@foto", item.Foto);
            command.Parameters.AddWithValue("@id", item.id);

            return ExecuteDml(command);
        }

        public bool Eliminar(int id)
        {
            SqlCommand command = new SqlCommand("delete Pacientes where Id = @id", _connection);

            command.Parameters.AddWithValue("@id", id);

            return ExecuteDml(command);
        }


        public DataTable GetAll()
        {
            SqlDataAdapter query = new SqlDataAdapter("select Id as Id_Paciente, Nombre, Apellido, Telefono, Direccion, Cedula, FechaNacimiento, Fumador, Alergias, foto from Pacientes", _connection);

            return LoadData(query);
        }

        public Paciente GetById(int id)
        {
            try
            {
                _connection.Open();

                SqlCommand command = new SqlCommand("select Id as Id_Paciente, Nombre, Apellido, Telefono, Direccion, Cedula, FechaNacimiento, Fumador, Alergias, foto from Pacientes where Id = @id", _connection);

                command.Parameters.AddWithValue("@id", id);

                SqlDataReader reader = command.ExecuteReader();

                Paciente retorno = new Paciente();

                while (reader.Read())
                {
                    retorno.id = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                    retorno.Nombre = reader.IsDBNull(1) ? "" : reader.GetString(1);
                    retorno.Apellido = reader.IsDBNull(2) ? "" : reader.GetString(2);
                    retorno.Telefono = reader.IsDBNull(3) ? "" : reader.GetString(3);
                    retorno.Direccion = reader.IsDBNull(4) ? "" : reader.GetString(4);
                    retorno.Cedula = reader.IsDBNull(5) ? "" : reader.GetString(5);
                    retorno.FechaNacimiento = reader.IsDBNull(6) ? DateTime.MinValue : reader.GetDateTime(6);
                    retorno.Fumador = reader.IsDBNull(7) ? 0 : reader.GetInt32(7);
                    retorno.Alergias = reader.IsDBNull(8) ? "" : reader.GetString(8);
                    retorno.Foto = reader.IsDBNull(9) ? "" : reader.GetString(9);
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
            catch
            {
                return false;
            }
        }

    }
}