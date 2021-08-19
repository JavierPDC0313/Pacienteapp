using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using Database.Models;

namespace Database
{
    public class CitasRepositorio
    {

        private SqlConnection _connection;

        public CitasRepositorio(SqlConnection connection)
        {
            _connection = connection;
        }

        public bool Agregar(Citas item)
        {
            SqlCommand command = new SqlCommand("insert into Citas(IdPaciente, IdDoctor, Fecha_Hora_Cita, Causa_Cita, Estado_Cita) values(@idPaciente,@idDoctor, @fechaHora, @causa, @estado)", _connection);

            command.Parameters.AddWithValue("@idPaciente", item.IdPaciente);
            command.Parameters.AddWithValue("@idDoctor", item.IdDoctor);
            command.Parameters.AddWithValue("@fechaHora", item.Fecha_HoraCita);
            command.Parameters.AddWithValue("@causa", item.CausaCita);
            command.Parameters.AddWithValue("@estado", item.EstadoCita);

            return ExecuteDml(command);
        }

        public bool Editar(Citas item)
        {
            SqlCommand command = new SqlCommand("update Citas set IdPaciente=@idPaciente, IdDoctor = @idDoctor, Fecha_Hora_Cita = @fechaHora, Causa_Cita=@causa, Estado_Cita = @estado where Id = @id", _connection);

            command.Parameters.AddWithValue("@idPaciente", item.IdPaciente);
            command.Parameters.AddWithValue("@idDoctor", item.IdDoctor);
            command.Parameters.AddWithValue("@fechaHora", item.Fecha_HoraCita);
            command.Parameters.AddWithValue("@causa", item.CausaCita);
            command.Parameters.AddWithValue("@estado", item.EstadoCita);
            command.Parameters.AddWithValue("@id", item.id);

            return ExecuteDml(command);
        }

        public bool Eliminar(int id)
        {
            SqlCommand command = new SqlCommand("delete Citas where Id = @id", _connection);

            command.Parameters.AddWithValue("@id", id);

            return ExecuteDml(command);
        }


        public DataTable GetAll()
        {
            SqlDataAdapter query = new SqlDataAdapter("select c.Id as Id_Citas, p.Nombre as Nombre_Paciente, d.Nombre as Nombre_Medico, Fecha_Hora_cita, Causa_Cita, Estado_Cita from Citas c join Pacientes p on (c.IdPaciente = p.Id) join Doctores d on (c.IdDoctor = d.Nombre)", _connection);

            return LoadData(query);
        }

        public Citas GetById(int id)
        {
            try
            {
                _connection.Open();

                SqlCommand command = new SqlCommand("select Id, IdPaciente, IdDoctor, Fecha_Hora_Cita, Causa_Cita, Estado_Cita from Citas where Id = @id", _connection);

                command.Parameters.AddWithValue("@id", id);

                SqlDataReader reader = command.ExecuteReader();

                Citas retorno = new Citas();

                while (reader.Read())
                {
                    retorno.id = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                    retorno.IdPaciente = reader.IsDBNull(1) ? 0 : reader.GetInt32(1);
                    retorno.IdDoctor = reader.IsDBNull(2) ? 0 : reader.GetInt32(2);
                    retorno.Fecha_HoraCita = reader.IsDBNull(3) ? DateTime.MinValue : reader.GetDateTime(3);
                    retorno.CausaCita = reader.IsDBNull(4) ? "" : reader.GetString(4);
                    retorno.EstadoCita = reader.IsDBNull(5) ? 0 : reader.GetInt32(5);
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
