using DatabaseLayer.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DatabaseLayer
{
    public class RepositorioResultadosLaboratorio
    {
        public SqlConnection connection;

        public RepositorioResultadosLaboratorio(SqlConnection sqlConnection)
        {
            connection = sqlConnection;
        }

        #region Metodos_CRUD
        public bool Agregar(ResultadosLaboratorio item)
        {
            SqlCommand sqlCommand = new SqlCommand("insert into Resultados_Laboratorio(IdPaciente, IdCita, IdPruebaLaboratorio, IdDoctor, Resultado, Estado_Resultado) values(@idpaciente, @idcita, @idpruebalaboratorio, @iddoctor, @resultado, @estado_resultado)", connection);

            sqlCommand.Parameters.AddWithValue("@idpaciente", item.IdPaciente);
            sqlCommand.Parameters.AddWithValue("@idcita", item.IdCita);
            sqlCommand.Parameters.AddWithValue("@idpruebalaboratorio", item.IdPruebaLaboraratorio);
            sqlCommand.Parameters.AddWithValue("@iddoctor", item.IdDoctor);
            sqlCommand.Parameters.AddWithValue("@resultado", item.Resultado);
            sqlCommand.Parameters.AddWithValue("@estado_resultado", item.EstadoResultado);

            return EjecutarConsulta(sqlCommand);
        }

        public bool UpdateStatus(int status, int id, string resultado)
        {
            SqlCommand sqlCommand = new SqlCommand("update Resultados_Laboratorio set Estado_Resultado = @estado_resultado, Resulado = @resultado where Id = @id", connection);

            sqlCommand.Parameters.AddWithValue("@estado_resultado", status);
            sqlCommand.Parameters.AddWithValue("@id", id);
            sqlCommand.Parameters.AddWithValue("@resultado", resultado);

            return EjecutarConsulta(sqlCommand);
        }

        public bool Eliminar(int id)
        {
            SqlCommand sqlCommand = new SqlCommand("delete Resultados_Laboratorio where Id = @id", connection);

            sqlCommand.Parameters.AddWithValue("@id", id);

            return EjecutarConsulta(sqlCommand);
        }


        public ResultadosLaboratorio EnlistarUno(int id)
        {
            ResultadosLaboratorio citas = new ResultadosLaboratorio();

            SqlCommand sqlCommand = new SqlCommand("select * from Resultados_Laboratorio where Id = @id", connection);

            sqlCommand.Parameters.AddWithValue("@id", id);

            try
            {
                connection.Open();

                SqlDataReader dataReader = sqlCommand.ExecuteReader();

                while (dataReader.Read())
                {
                    citas.Id = dataReader.IsDBNull(0) ? 0 : dataReader.GetInt32(0);
                    citas.IdPaciente = dataReader.IsDBNull(1) ? 0 : dataReader.GetInt32(1);
                    citas.IdCita = dataReader.IsDBNull(2) ? 0 : dataReader.GetInt32(2);
                    citas.IdPruebaLaboraratorio = dataReader.IsDBNull(3) ? 0 : dataReader.GetInt32(3);
                    citas.IdDoctor = dataReader.IsDBNull(4) ? 0 : dataReader.GetInt32(4);
                    citas.Resultado = dataReader.IsDBNull(4) ? "NULL" : dataReader.GetString(4);
                    citas.EstadoResultado = dataReader.IsDBNull(5) ? 0 : dataReader.GetInt32(5);
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
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select rl.Id, pa.Nombre+' '+pa.Apellido 'Paciente', pa.Cedula 'Cedula del paciente', pl.Nombre 'Prueba asignada' from Resultados_Laboratorio rl join Pacientes pa on (rl.IdPaciente = pa.Id) join PruebasLaboratorio pl on (rl.IdPruebaLaboratorio = pl.Nombre)", connection);
            return ObtenerDatos(sqlDataAdapter);
        }

        public DataTable GetAllByPatient(int idPaciente)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter("select rl.Id, pa.Nombre +' '+ pa.Apellido 'Paciente', pl.Nombre 'Nombre de la prueba', er.descripcion 'Estado del resultado' from Resultados_Laboratorio rl join Pacientes pa on (rl.IdPaciente = pa.Id) join PruebasLaboratorio pl on (rl.IdPruebaLaboratorio = pl.Id) join Estado_Resultado er on (rl.Estado_Resultado = er.id) where rl.IdPaciente = @idPaciente", connection);

            dataAdapter.SelectCommand.Parameters.AddWithValue("@idPaciente", idPaciente);

            return ObtenerDatos(dataAdapter);
        }

        public DataTable GetAllCompletedByCita(int estadoResultado, int idCita)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter("select pl.Nombre 'Nombre de la prueba', er.descripcion 'Estado del resultado' from Resultados_Laboratorio rl join PruebasLaboratorio pl on (rl.IdPruebaLaboratorio = pl.Id) join Estado_Resultado er on (rl.Estado_Resultado = er.id) where rl.Estado_Resultado = @estadoResultado and  rl.IdCita = @idCita", connection);

            dataAdapter.SelectCommand.Parameters.AddWithValue("@estadoResultado", estadoResultado);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@idCita", idCita);

            return ObtenerDatos(dataAdapter);
        }

        public DataTable EnlistarPendientesPorCedula(int status, string cedula)
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select rl.Id, pa.Nombre+' '+pa.Apellido 'Paciente', pa.Cedula 'Cedula del paciente', pl.Nombre 'Prueba asignada' from Resultados_Laboratorio rl join Pacientes pa on (rl.IdPaciente = pa.Id) join PruebasLaboratorio pl on (rl.IdPruebaLaboratorio = pl.Id) where rl.Estado_Resultado = @estado and pa.Cedula = @cedula", connection);

            sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@estado", status);
            sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@cedula", cedula);

            return ObtenerDatos(sqlDataAdapter);
        }

        public DataTable EnlistarPendientes(int status)
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select rl.Id, pa.Nombre+' '+pa.Apellido 'Paciente', pa.Cedula 'Cedula del paciente', pl.Nombre 'Prueba asignada' from Resultados_Laboratorio rl join Pacientes pa on (rl.IdPaciente = pa.Id) join PruebasLaboratorio pl on (rl.IdPruebaLaboratorio = pl.Id) where rl.Estado_Resultado = @estado", connection);

            sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@estado", status);

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
