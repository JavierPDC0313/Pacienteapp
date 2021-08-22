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
                            IdPruebaLaboraratorio = Convert.ToInt32(row.Cells[0].Value.ToString()),
                            Resultado = "pendiente",
                            EstadoResultado = 1
                        };

                        _mantenimientoResultados.Agregar(newResultado);
                    }

                    _mantenimientoCitas.UpdateStatus(2, FrmMantenimientoCitas.Instancia.GetSelectedItem());
                }
                else
                {
                    MessageBox.Show("Debe seleccionar al menos una prueba","Advertencia");
                }
            }
            else
            {

            }
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
                DgvListado.DataSource = _mantenimientoResultados.GetAll();
                DgvListado.ClearSelection();
            }
            else
            {

            }
        }

        #endregion
    }
}
