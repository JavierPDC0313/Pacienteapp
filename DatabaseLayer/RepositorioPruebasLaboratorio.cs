using DatabaseLayer.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DatabaseLayer
{
    public class RepositorioPruebasLaboratorio
    {
        public SqlConnection connection;

        public RepositorioPruebasLaboratorio(SqlConnection sqlConnection)
        {
            connection = sqlConnection;
        }

        #region Metodos_CRUD
        public bool Agregar(PruebasLaboratorio item)
        {
            SqlCommand sqlCommand = new SqlCommand("insert into PruebasLaboratorio(Nombre) values(@nombre)", connection);

            sqlCommand.Parameters.AddWithValue("@nombre", item.Nombre);

            return EjecutarConsulta(sqlCommand);
        }

        public bool Editar(PruebasLaboratorio item)
        {
            SqlCommand sqlCommand = new SqlCommand("update PruebasLaboratorio set Nombre = @nombre where Id = @id", connection);

            sqlCommand.Parameters.AddWithValue("@id", item.Id);
            sqlCommand.Parameters.AddWithValue("@nombre", item.Nombre);

            return EjecutarConsulta(sqlCommand);
        }

        public bool Eliminar(int id)
        {
            SqlCommand sqlCommand = new SqlCommand("delete PruebasLaboratorio where Id = @id", connection);

            sqlCommand.Parameters.AddWithValue("@id", id);

            return EjecutarConsulta(sqlCommand);
        }

        public PruebasLaboratorio EnlistarUno(int id)
        {
            PruebasLaboratorio pruebasLaboratorio = new PruebasLaboratorio();

            SqlCommand sqlCommand = new SqlCommand("select * from PruebasLaboratorio where Id = @id", connection);

            sqlCommand.Parameters.AddWithValue("@id", id);

            try
            {
                connection.Open();

                SqlDataReader dataReader = sqlCommand.ExecuteReader();

                while (dataReader.Read())
                {
                    pruebasLaboratorio.Id = dataReader.IsDBNull(0) ? 0 : dataReader.GetInt32(0);
                    pruebasLaboratorio.Nombre = dataReader.IsDBNull(1) ? "NULL" : dataReader.GetString(1);
                }

                dataReader.Close();
                dataReader.Dispose();

                connection.Close();

                return pruebasLaboratorio;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public DataTable EnlistarTodo()
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from PruebasLaboratorio", connection);
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
