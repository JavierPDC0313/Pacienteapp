using DatabaseLayer.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DatabaseLayer
{
    public class RepositorioDoctores
    {
        public SqlConnection connection;

        public RepositorioDoctores(SqlConnection sqlConnection)
        {
            connection = sqlConnection;
        }

        #region Metodos_CRUD
        public bool Agregar(Doctores item)
        {
            SqlCommand sqlCommand = new SqlCommand("insert into Dotores(Nombre, Apellido, Correo, Telefono, Cedula, Foto) values(@nombre, @apellido, @correo, @telefono, @cedula, @foto)", connection);

            sqlCommand.Parameters.AddWithValue("@nombre", item.Nombre);
            sqlCommand.Parameters.AddWithValue("@apellido", item.Apellido);
            sqlCommand.Parameters.AddWithValue("@correo", item.Correo);
            sqlCommand.Parameters.AddWithValue("@telefono", item.Telefono);
            sqlCommand.Parameters.AddWithValue("@cedula", item.Cedula);
            sqlCommand.Parameters.AddWithValue("@foto", item.Foto);

            return EjecutarConsulta(sqlCommand);
        }

        public bool Editar(Doctores item)
        {
            SqlCommand sqlCommand = new SqlCommand("update Dotores set Nombre = @nombre, Apellido = @apellido, Correo = @correo, Telefono = @telefono, Cedula = @cedula, Foto = @foto where Id = @id", connection);

            sqlCommand.Parameters.AddWithValue("@id", item.Id);
            sqlCommand.Parameters.AddWithValue("@nombre", item.Nombre);
            sqlCommand.Parameters.AddWithValue("@apellido", item.Apellido);
            sqlCommand.Parameters.AddWithValue("@correo", item.Correo);
            sqlCommand.Parameters.AddWithValue("@telefono", item.Telefono);
            sqlCommand.Parameters.AddWithValue("@cedula", item.Cedula);
            sqlCommand.Parameters.AddWithValue("@foto", item.Foto);

            return EjecutarConsulta(sqlCommand);
        }

        public bool Eliminar(int id)
        {
            SqlCommand sqlCommand = new SqlCommand("delete Dotores where Id = @id", connection);

            sqlCommand.Parameters.AddWithValue("@id", id);

            return EjecutarConsulta(sqlCommand);
        }

        public int EnlistarUltimoId()
        {
            int lastId = 0;

            connection.Open();

            SqlCommand command = new SqlCommand("select max(d.Id) as Id from Doctores d", connection);

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

        public Doctores EnlistarUno(int id)
        {
            Doctores doctores = new Doctores();

            SqlCommand sqlCommand = new SqlCommand("select * from Doctores where Id = @id", connection);

            sqlCommand.Parameters.AddWithValue("@id", id);

            try
            {
                connection.Open();

                SqlDataReader dataReader = sqlCommand.ExecuteReader();

                while (dataReader.Read())
                {
                    doctores.Id = dataReader.IsDBNull(0) ? 0 : dataReader.GetInt32(0);
                    doctores.Nombre = dataReader.IsDBNull(1) ? "NULL" : dataReader.GetString(1);
                    doctores.Apellido = dataReader.IsDBNull(2) ? "NULL" : dataReader.GetString(2);
                    doctores.Correo = dataReader.IsDBNull(3) ? "NULL" : dataReader.GetString(3);
                    doctores.Telefono = dataReader.IsDBNull(4) ? "NULL" : dataReader.GetString(4);
                    doctores.Cedula = dataReader.IsDBNull(5) ? "NULL" : dataReader.GetString(5);
                    doctores.Foto = dataReader.IsDBNull(6) ? "NULL" : dataReader.GetString(6);
                }

                dataReader.Close();
                dataReader.Dispose();

                connection.Close();

                return doctores;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public DataTable EnlistarTodo()
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from Doctores", connection);
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
