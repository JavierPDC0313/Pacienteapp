using DatabaseLayer.Models;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DatabaseLayer
{
    public class RepositorioCitas
    {
        public SqlConnection connection;

        public RepositorioCitas(SqlConnection sqlConnection)
        {
            connection = sqlConnection;
        }

        #region Metodos_CRUD
        public bool Agregar(Citas item)
        {
            SqlCommand sqlCommand = new SqlCommand("insert into Citas(IdPaciente, IdDoctor, Fecha_Hora_cita, Causa_cita, Estado_cita) values(@idpaciente, @iddoctor, @fecha_hora_cita, @causa_cita, @estado_cita)", connection);

            sqlCommand.Parameters.AddWithValue("@idpaciente", item.IdPaciente);
            sqlCommand.Parameters.AddWithValue("@iddoctor", item.IdDoctor);
            sqlCommand.Parameters.AddWithValue("@fecha_hora_cita", item.FechaHora);
            sqlCommand.Parameters.AddWithValue("@causa_cita", item.Causa);
            sqlCommand.Parameters.AddWithValue("@estado_cita", item.Estado);

            return EjecutarConsulta(sqlCommand);
        }

        public bool Editar(Citas item)
        {
            SqlCommand sqlCommand = new SqlCommand("update Citas set IdPaciente = @idpaciente, IdDoctor = @iddoctor, Fecha_Hora_cita =  @fecha_hora_cita, Causa_cita = @causa_cita, Estado_cita = @estado_cita where Id = @id", connection);

            sqlCommand.Parameters.AddWithValue("@id", item.Id);
            sqlCommand.Parameters.AddWithValue("@idpaciente", item.IdPaciente);
            sqlCommand.Parameters.AddWithValue("@iddoctor", item.IdDoctor);
            sqlCommand.Parameters.AddWithValue("@fecha_hora_cita", item.FechaHora);
            sqlCommand.Parameters.AddWithValue("@causa_cita", item.Causa);
            sqlCommand.Parameters.AddWithValue("@estado_cita", item.Estado);

            return EjecutarConsulta(sqlCommand);
        }

        public bool Eliminar(int id)
        {
            SqlCommand sqlCommand = new SqlCommand("delete Citas where Id = @id", connection);

            sqlCommand.Parameters.AddWithValue("@id", id);

            return EjecutarConsulta(sqlCommand);
        }

        public Citas EnlistarUno(int id)
        {
            Citas citas = new Citas();

            SqlCommand sqlCommand = new SqlCommand("select * from Citas where Id = @id", connection);

            sqlCommand.Parameters.AddWithValue("@id", id);

            try
            {
                connection.Open();

                SqlDataReader dataReader = sqlCommand.ExecuteReader();

                while (dataReader.Read())
                {
                    citas.Id = dataReader.IsDBNull(0) ? 0 : dataReader.GetInt32(0);
                    citas.IdPaciente = dataReader.IsDBNull(1) ? 0 : dataReader.GetInt32(1);
                    citas.IdDoctor = dataReader.IsDBNull(2) ? 0 : dataReader.GetInt32(2);
                    citas.FechaHora = dataReader.IsDBNull(3) ? DateTime.Now : dataReader.GetDateTime(3);
                    citas.Causa = dataReader.IsDBNull(4) ? "NULL" : dataReader.GetString(4);
                    citas.Estado = dataReader.IsDBNull(5) ? 0 : dataReader.GetInt32(5);
                }

                dataReader.Close();
                dataReader.Dispose();

                connection.Close();

                return citas;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public DataTable EnlistarTodo()
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select ci.Id, pac.Nombre + ' ' + pac.Apellido 'NOMBRE PACIENTE', doc.Nombre + ' ' + pac.Apellido 'NOMBRE DOCTOR', ci.Fecha_Hora_cita 'FECHA DE CITA', ci.Causa_Cita 'CAUSA DE CITA', ci.Estado_Cita 'ESTADO DE CITA' from Citas ci INNER JOIN Doctores doc ON (ci.IdDoctor = doc.Id) INNER JOIN Pacientes pac ON (ci.IdPaciente = pac.Id)", connection);
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
