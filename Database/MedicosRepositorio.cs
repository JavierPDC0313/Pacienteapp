using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using Database.Models;

namespace Database
{
    public class MedicosRepositorio
    {

        private SqlConnection _connection;

        public MedicosRepositorio(SqlConnection connection)
        {
            _connection = connection;
        }

        public bool Agregar(Medico item)
        {
            SqlCommand command = new SqlCommand("insert into Doctores(Nombre, Apellido, Correo, Telefono, Cedula, Foto) values(@nombre,@apellido, @correo, @telefono, @cedula, @foto)", _connection);

            command.Parameters.AddWithValue("@nombre", item.Nombre);
            command.Parameters.AddWithValue("@apellido", item.Apellido);
            command.Parameters.AddWithValue("@direccion", item.Correo);
            command.Parameters.AddWithValue("@telefono", item.Telefono);
            command.Parameters.AddWithValue("@cedula", item.Cedula);
            command.Parameters.AddWithValue("@foto", item.Foto);

            return ExecuteDml(command);
        }

        public bool Editar(Medico item)
        {
            SqlCommand command = new SqlCommand("update Doctores set Nombre=@nombre, Apellido = @apellido, Correo = @correo, Telefono=@telefono, Cedula = @cedula, Foto = @foto where Id = @id", _connection);

            command.Parameters.AddWithValue("@nombre", item.Nombre);
            command.Parameters.AddWithValue("@apellido", item.Apellido);
            command.Parameters.AddWithValue("@direccion", item.Correo);
            command.Parameters.AddWithValue("@telefono", item.Telefono);
            command.Parameters.AddWithValue("@cedula", item.Cedula);
            command.Parameters.AddWithValue("@foto", item.Foto);
            command.Parameters.AddWithValue("@id", item.id);

            return ExecuteDml(command);
        }

        public bool Eliminar(int id)
        {
            SqlCommand command = new SqlCommand("delete Doctores where Id = @id", _connection);

            command.Parameters.AddWithValue("@id", id);

            return ExecuteDml(command);
        }


        public DataTable GetAll()
        {
            SqlDataAdapter query = new SqlDataAdapter("select Id as Id_Medico, Nombre, Apellido, Correo, Telefono, Cedula, Foto from Doctores", _connection);

            return LoadData(query);
        }

        public Medico GetById(int id)
        {
            try
            {
                _connection.Open();

                SqlCommand command = new SqlCommand("select Id as Id_Medico, Nombre, Apellido, Correo, Telefono, Cedula, Foto from Doctores where Id = @id", _connection);

                command.Parameters.AddWithValue("@id", id);

                SqlDataReader reader = command.ExecuteReader();

                Medico retorno = new Medico();

                while (reader.Read())
                {
                    retorno.id = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                    retorno.Nombre = reader.IsDBNull(1) ? "" : reader.GetString(1);
                    retorno.Apellido = reader.IsDBNull(2) ? "" : reader.GetString(2);
                    retorno.Correo = reader.IsDBNull(3) ? "" : reader.GetString(3);
                    retorno.Telefono = reader.IsDBNull(4) ? "" : reader.GetString(4);
                    retorno.Cedula = reader.IsDBNull(5) ? "" : reader.GetString(5);
                    retorno.Foto = reader.IsDBNull(6) ? "" : reader.GetString(6);
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
