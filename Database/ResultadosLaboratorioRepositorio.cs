using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using Database.Models;

namespace Database
{
    public class ResultadosLaboratorioRepositorio
    {

        private SqlConnection _connection;

        public ResultadosLaboratorioRepositorio(SqlConnection connection)
        {
            _connection = connection;
        }

        public bool Agregar(ResultadosLaboratorio item)
        {
            SqlCommand command = new SqlCommand("insert into Resultados_Laboratorio(IdPaciente, IdCita, IdPruebaLaboratorio, IdDoctor, Resultado, Estado_Resultado) values(@idPaciente, @idCita, @idPruebaLaboratorio, @idDoctor, @resultado, @estado)", _connection);

            command.Parameters.AddWithValue("@idPaciente", item.IdPaciente);
            command.Parameters.AddWithValue("@idCita", item.IdCita);
            command.Parameters.AddWithValue("@idPruebaLaboratorio", item.IdPruebaLaboratorio);
            command.Parameters.AddWithValue("@idDoctor", item.IdMedico);
            command.Parameters.AddWithValue("@resultado", item.Resultado);
            command.Parameters.AddWithValue("@estado", item.EstadoResultado);

            return ExecuteDml(command);
        }

        public bool Editar(ResultadosLaboratorio item)
        {
            SqlCommand command = new SqlCommand("update Resultados_Laboratorio set IdPaciente=@idPaciente, IdCita = @idCita, IdPruebaLaboratorio = @idPruebaLaboratorio, IdDoctor = @idDoctor, Resultado = @resultado, Estado_Resultado = @estado where Id = @id", _connection);

            command.Parameters.AddWithValue("@idPaciente", item.IdPaciente);
            command.Parameters.AddWithValue("@idCita", item.IdCita);
            command.Parameters.AddWithValue("@idPruebaLaboratorio", item.IdPruebaLaboratorio);
            command.Parameters.AddWithValue("@idDoctor", item.IdMedico);
            command.Parameters.AddWithValue("@resultado", item.Resultado);
            command.Parameters.AddWithValue("@estado", item.EstadoResultado);
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
            SqlDataAdapter query = new SqlDataAdapter("select p.Nombre as Nombre_paciente, p.Apellido as Apellido_paciente, p.Cedula, pl.Nombre as Nombre_prueba, r.Resultado from Resultados_Laboratorio r join Pacientes p on (r.IdPaciente = p.Id) join PruebasLaboratorio pl on (r.IdPruebaLaboraratorio = pl.Id)", _connection);

            return LoadData(query);
        }

        public DataTable GetAllPending()
        {
            SqlDataAdapter query = new SqlDataAdapter("select p.Nombre as Nombre_paciente, p.Apellido as Apellido_paciente, p.Cedula, pl.Nombre as Nombre_prueba, r.Resultado from Resultados_Laboratorio r join Pacientes p on (r.IdPaciente = p.Id) join PruebasLaboratorio pl on (r.IdPruebaLaboraratorio = pl.Id) where Estado_Resultado = 1", _connection);

            return LoadData(query);
        }

        public ResultadosLaboratorio GetById(int id)
        {
            try
            {
                _connection.Open();

                SqlCommand command = new SqlCommand("select Id, IdPaciente, IdCita, IdPruebaLaboraratorio, IdDoctor, Resultado, Estado_Resultado from Resultados_Laboratorio where Id = @id", _connection);

                command.Parameters.AddWithValue("@id", id);

                SqlDataReader reader = command.ExecuteReader();

                ResultadosLaboratorio retorno = new ResultadosLaboratorio();

                while (reader.Read())
                {
                    retorno.id = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                    retorno.IdPaciente = reader.IsDBNull(1) ? 0 : reader.GetInt32(1);
                    retorno.IdCita = reader.IsDBNull(2) ? 0 : reader.GetInt32(2);
                    retorno.IdPruebaLaboratorio = reader.IsDBNull(3) ? 0 : reader.GetInt32(3);
                    retorno.IdMedico = reader.IsDBNull(4) ? 0 : reader.GetInt32(4);
                    retorno.Resultado = reader.IsDBNull(5) ? "" : reader.GetString(5);
                    retorno.EstadoResultado = reader.IsDBNull(6) ? 0 : reader.GetInt32(6);
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
