using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BussinessLayer;
using DatabaseLayer.Models;

namespace Pacienteapp
{
    public partial class FrmListadoPruebas_Resultados : Form
    {

        int status;

        int id;

        MantenimientoPruebasLaboratorio _mantenimientoPruebas;

        MantenimientoResultadosLaboratorio _mantenimientoResultados;

        MantenimientoCitas _mantenimientoCitas;

        public FrmListadoPruebas_Resultados(int Status)
        {
            InitializeComponent();

            status = Status;

            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;

            SqlConnection connection = new SqlConnection(connectionString);

            _mantenimientoPruebas = new MantenimientoPruebasLaboratorio(connection);

            _mantenimientoCitas = new MantenimientoCitas(connection);

            _mantenimientoResultados = new MantenimientoResultadosLaboratorio(connection);
        }
        #region Events
        private void FrmListadoPruebas_Resultados_Load(object sender, EventArgs e)
        {
            LoadData();

            if (status == 1)
            {
                DgvListado.MultiSelect = true;
                BtnVolver.Visible = false;
            }
            else if (status == 2)
            {
                BtnCompletar.Text = "Completar cita";
                BtnVolver.Text = "Cerrar resultados";
            }
            else
            {
                BtnCompletar.Visible = false;
                DgvListado.Enabled = false;
            }

        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DgvListado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (status != 3)
            {
                if (e.RowIndex >= 0)
                {
                    id = Convert.ToInt32(DgvListado.Rows[e.RowIndex].Cells[0].Value.ToString());

                    BtnCompletar.Visible = true;
                }
            }
        }

        private void BtnCompletar_Click(object sender, EventArgs e)
        {
            if (status == 1)
            {
                if (id >= 0)
                {
                    Citas cita = new Citas();
                    cita = _mantenimientoCitas.GetById(FrmMantenimientoCitas.Instancia.GetSelectedItem());

                    foreach(DataGridViewRow row in DgvListado.SelectedRows)
                    {
                        ResultadosLaboratorio newResultado = new ResultadosLaboratorio
                        {
                            IdPaciente = cita.IdPaciente,
                            IdCita = cita.Id,
                            IdDoctor = cita.IdDoctor,
                            IdPruebaLaboraratorio = Convert.ToInt32(row.Cells[0].Value.ToString()),
                            Resultado = "pendiente",
                            EstadoResultado = 1
                        };

                        _mantenimientoResultados.Agregar(newResultado);
                    }

                    _mantenimientoCitas.UpdateStatus(2, FrmMantenimientoCitas.Instancia.GetSelectedItem());

                    MessageBox.Show("Pruebas asignadas Satisfactoriamente!", "Notificación");

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Debe seleccionar al menos una prueba","Advertencia");
                }
            }
            else
            {
                if (id >= 0)
                {
                    _mantenimientoCitas.UpdateStatus(3, FrmMantenimientoCitas.Instancia.GetSelectedItem());

                    MessageBox.Show("Cita completada con éxito!", "Notificación");

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un resultado", "Advertencia");
                }
            }
        }

        private void FrmListadoPruebas_Resultados_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmMantenimientoCitas.Instancia.Show();
        }

        #endregion

        #region Methods

        private void LoadData()
        {
            if (status == 1) 
            {
                DgvListado.DataSource = _mantenimientoPruebas.GetAll();
                DgvListado.ClearSelection();
            }
            else if (status == 2)
            {
                DgvListado.DataSource = _mantenimientoResultados.GetAllByPatient(FrmMantenimientoCitas.Instancia.Paciente_id);
                DgvListado.ClearSelection();
            }
            else
            {
                DgvListado.DataSource = _mantenimientoResultados.GetAllCompletedByCita(2, FrmMantenimientoCitas.Instancia.GetSelectedItem());
                DgvListado.ClearSelection();
            }
        }

        #endregion
    }
}
