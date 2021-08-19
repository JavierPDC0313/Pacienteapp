using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using Database.Models;

namespace Database
{
    public class PruebasLaboratorioRepositorio
    {

        private SqlConnection _connection;

        public PruebasLaboratorioRepositorio(SqlConnection connection)
        {
            _connection = connection;
        }

        public bool Agregar(PruebasLaboratorio item)
        {
            SqlCommand command = new SqlCommand("insert into Resultados_Laboratorio(Nombre) values(@nombre)", _connection);

            command.Parameters.AddWithValue("@nombre", item.Nombre);

            return ExecuteDml(command);
        }

        public bool Editar(PruebasLaboratorio item)
        {
            SqlCommand command = new SqlCommand("update Resultados_Laboratorio set Nombre=@nombre where Id = @id", _connection);

            command.Parameters.AddWithValue("@nombre", item.Nombre);
            command.Parameters.AddWithValue("@id", item.id);

            return ExecuteDml(command);
        }

        public bool Eliminar(int id)
        {
            SqlCommand command = new SqlCommand("delete Resultados_Laboratorio where Id = @id", _connection);

            command.Parameters.AddWithValue("@id", id);

            return ExecuteDml(command);
        }


        public DataTable GetAll()
        {
            SqlDataAdapter query = new SqlDataAdapter("select Id, Nombre from Resultados_Laboratorio", _connection);

            return LoadData(query);
        }

        public Usuario GetById(int id)
        {
            try
            {
                _connection.Open();

                SqlCommand command = new SqlCommand("select Id, Nombre from Resultados_Laboratorio where Id = @id", _connection);

                command.Parameters.AddWithValue("@id", id);

                SqlDataReader reader = command.ExecuteReader();

                Usuario retorno = new Usuario();

                while (reader.Read())
                {
                    retorno.id = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                    retorno.Nombre = reader.IsDBNull(1) ? "" : reader.GetString(1);
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