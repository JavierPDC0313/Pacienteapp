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

namespace Pacienteapp
{
    public partial class ListadoPaciente_Medico : Form
    {

        MantenimientoPacientes _mantenimientoPacientes;

        MantenimientoDoctores _mantenimientoMedicos;

        private bool isAdding;

        private bool isPacienteSelected;

        private bool isMedicoSeleceted;

        private int id;

        public ListadoPaciente_Medico()
        {
            InitializeComponent();

            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;

            SqlConnection connection = new SqlConnection(connectionString);

            _mantenimientoPacientes = new MantenimientoPacientes(connection);

            _mantenimientoMedicos = new MantenimientoDoctores(connection);
        }

        #region Events

        private void ListadoPacientes_Load(object sender, EventArgs e)
        {
            if (FrmMantenimientoCitas.Instancia.GetIsAdding() == true)
            {
                isAdding = true;
            }
            else if (FrmMantenimientoCitas.Instancia.GetIsPacienteSelected() == true)
            {
                isPacienteSelected = true;
            }

            LoadData();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSiguiente_Click(object sender, EventArgs e)
        {
            if (isAdding == true)
            {
                FrmMantenimientoCitas.Instancia.Paciente_id = id;

                isAdding = false;
                isPacienteSelected = false;
            }
            else if (isPacienteSelected == true)
            {
                FrmMantenimientoCitas.Instancia.Medico_id = id;

                isAdding = false;
                isPacienteSelected = false;
            }
        }

        private void DgvListado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(DgvListado.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        #endregion

        #region Methods

        private void LoadData()
        {
            if (isAdding == true)
            {
                DgvListado.DataSource = _mantenimientoPacientes.GetAll();
                DgvListado.Columns[0].Visible = false;
                DgvListado.ClearSelection();
            }
            else if(FrmMantenimientoCitas.Instancia.GetIsPacienteSelected() == true)
            {
                DgvListado.DataSource = _mantenimientoMedicos.GetAll();
                DgvListado.Columns[0].Visible = false;
                DgvListado.ClearSelection();
            }
        }

        public int result()
        {
            return id;
        }

        #endregion
    }
}
