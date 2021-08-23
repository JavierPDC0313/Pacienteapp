using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DatabaseLayer;
using DatabaseLayer.Models;

namespace BussinessLayer
{
    public class MantenimientoResultadosLaboratorio
    {

        private RepositorioResultadosLaboratorio repository;

        public MantenimientoResultadosLaboratorio(SqlConnection connection)
        {
            repository = new RepositorioResultadosLaboratorio(connection);
        }

        public bool Agregar(ResultadosLaboratorio item)
        {
            return repository.Agregar(item);
        }

        public bool UpdateStatus(int status, int id, string resultado)
        {
            return repository.UpdateStatus(status, id, resultado);
        }

        public bool Eliminar(int id)
        {
            return repository.Eliminar(id);
        }

        public ResultadosLaboratorio GetById(int id)
        {
            return repository.EnlistarUno(id);
        }

        public DataTable GetAll()
        {
            return repository.EnlistarTodo();
        }

        public DataTable GetAllByPatient(int idPaciente)
        {
            return repository.GetAllByPatient(idPaciente);
        }

        public DataTable GetAllCompletedByCita(int estadoResultado, int idCita)
        {
            return repository.GetAllCompletedByCita(estadoResultado, idCita);
        }

        public DataTable GetAllPending(int status)
        {
            return repository.EnlistarPendientes(status);
        }

        public DataTable GetAllPendingByCedula(int status, string cedula)
        {
            return repository.EnlistarPendientesPorCedula(status, cedula);
        }

    }
}
