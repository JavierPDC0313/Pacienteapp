using DatabaseLayer.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DatabaseLayer
{
    public class RepositorioPacientes
    {
        public SqlConnection connection;

        public RepositorioPacientes(SqlConnection sqlConnection)
        {
            connection = sqlConnection;
        }

        #region Metodos_CRUD
        public bool Agregar(Pacientes item)
        {
            SqlCommand sqlCommand = new SqlCommand("insert into Pacientes(Nombre, Apellido, Telefono, Direccion, Cedula, FechaNacimiento, Fumador, Alergias, foto) values(@nombre, @apellido, @telefono, @direccion, @cedula, @fechanacimiento, @fumador, @alergias, @foto)", connection);

            sqlCommand.Parameters.AddWithValue("@nombre", item.Nombre);
            sqlCommand.Parameters.AddWithValue("@apellido", item.Apellido);
            sqlCommand.Parameters.AddWithValue("@telefono", item.Telefono);
            sqlCommand.Parameters.AddWithValue("@direccion", item.Direccion);
            sqlCommand.Parameters.AddWithValue("@cedula", item.Cedula);
            sqlCommand.Parameters.AddWithValue("@fechanacimiento", item.FechaNacimiento);
            sqlCommand.Parameters.AddWithValue("@fumador", item.Fumador);
            sqlCommand.Parameters.AddWithValue("@alergias", item.Alergias);
            sqlCommand.Parameters.AddWithValue("@foto", item.Foto);

            return EjecutarConsulta(sqlCommand);
        }

        public bool Editar(Pacientes item)
        {
            SqlCommand sqlCommand = new SqlCommand("update Pacientes set Nombre = @nombre, Apellido = @apellido, Telefono = @telefono, Direccion = @direccion, Cedula = @cedula, FechaNacimiento = @fechanacimiento, Fumador = @fumador, Alergias = @alergias, foto = @foto where Id = @id", connection);

            sqlCommand.Parameters.AddWithValue("@id", item.Id);
            sqlCommand.Parameters.AddWithValue("@nombre", item.Nombre);
            sqlCommand.Parameters.AddWithValue("@apellido", item.Apellido);
            sqlCommand.Parameters.AddWithValue("@telefono", item.Telefono);
            sqlCommand.Parameters.AddWithValue("@direccion", item.Direccion);
            sqlCommand.Parameters.AddWithValue("@cedula", item.Cedula);
            sqlCommand.Parameters.AddWithValue("@fechanacimiento", item.FechaNacimiento);
            sqlCommand.Parameters.AddWithValue("@fumador", item.Fumador);
            sqlCommand.Parameters.AddWithValue("@alergias", item.Alergias);
            sqlCommand.Parameters.AddWithValue("@foto", item.Foto);

            return EjecutarConsulta(sqlCommand);
        }

        public bool Eliminar(int id)
        {
            SqlCommand sqlCommand = new SqlCommand("delete Pacientes where Id = @id", connection);

            sqlCommand.Parameters.AddWithValue("@id", id);

            return EjecutarConsulta(sqlCommand);
        }

        public Pacientes EnlistarUno(int id)
        {
            Pacientes pacientes = new Pacientes();

            SqlCommand sqlCommand = new SqlCommand("select p.Id, p.Nombre, p.Apellido, p.Telefono, p.Direccion, p.Cedula, Cast (p.FechaNacimiento as date),  CASE p.Fumador WHEN 1 THEN 'Si' ELSE 'No' END AS Fumador, p.Alergias, p.foto from Pacientes p where Id = @id", connection);

            sqlCommand.Parameters.AddWithValue("@id", id);

            try
            {
                connection.Open();

                SqlDataReader dataReader = sqlCommand.ExecuteReader();

                while (dataReader.Read())
                {
                    pacientes.Id = dataReader.IsDBNull(0) ? 0 : dataReader.GetInt32(0);
                    pacientes.Nombre = dataReader.IsDBNull(1) ? "NULL" : dataReader.GetString(1);
                    pacientes.Apellido = dataReader.IsDBNull(2) ? "NULL" : dataReader.GetString(2);
                    pacientes.Telefono = dataReader.IsDBNull(3) ? "NULL" : dataReader.GetString(3);
                    pacientes.Direccion = dataReader.IsDBNull(4) ? "NULL" : dataReader.GetString(4);
                    pacientes.Cedula = dataReader.IsDBNull(5) ? "NULL" : dataReader.GetString(5);
                    pacientes.FechaNacimiento = dataReader.IsDBNull(6) ? DateTime.Now : dataReader.GetDateTime(6);
                    pacientes.Fumador = dataReader.IsDBNull(7) ? 0 : dataReader.GetInt32(7);
                    pacientes.Alergias = dataReader.IsDBNull(8) ? "NULL" : dataReader.GetString(8);
                    pacientes.Foto = dataReader.IsDBNull(9) ? "NULL" : dataReader.GetString(9);
                }

                dataReader.Close();
                dataReader.Dispose();

                connection.Close();

                return pacientes;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public int EnlistarUltimoId()
        {
            int lastId = 0;

            connection.Open();

            SqlCommand command = new SqlCommand("select max(p.Id) as Id from Pacientes p", connection);

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                lastId = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
            }

            reader.Close();
            reader.Dispose();


            connection.Close();

            return lastId;
        }

        public DataTable EnlistarTodo()
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select p.Id, p.Nombre, p.Apellido, p.Telefono, p.Direccion, p.Cedula, Cast (p.FechaNacimiento as date),  CASE p.Fumador WHEN 1 THEN 'Si' ELSE 'No' END AS Fumador, p.Alergias, p.foto from Pacientes p", connection);
            return ObtenerDatos(sqlDataAdapter);
        }
        #endregion

        #region Ejecutores_SQL
        private DataTable ObtenerDatos(SqlDataAdapter dataAdapter)
        {
            try
            {
                DataTable data = new DataTable();

                connection.Open();
                dataAdapter.Fill(data);
                connection.Close();

                return data;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        private bool EjecutarConsulta(SqlCommand command)
        {
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        #endregion
    }
}
