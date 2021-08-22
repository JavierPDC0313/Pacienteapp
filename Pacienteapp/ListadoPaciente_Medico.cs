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

                LoadData();
                DgvListado.ClearSelection();

                if (FrmMantenimientoCitas.Instancia.GetIsEdit() == true)
                {
                    SearchDgv(Convert.ToString(FrmMantenimientoCitas.Instancia.Paciente_id), 0);
                }
            }
            else if (FrmMantenimientoCitas.Instancia.GetIsPacienteSelected() == true)
            {
                isPacienteSelected = true;

                LblSelecciona.Text = "Selecciona un medico:";

                BtnBuscar.Visible = true;

                BtnLimpiar.Visible = true;

                TxtBuscarCedula.Visible = true;

                LoadData();
                DgvListado.ClearSelection();

                if (FrmMantenimientoCitas.Instancia.GetIsEdit() == true)
                {
                    SearchDgv(Convert.ToString(FrmMantenimientoCitas.Instancia.Medico_id), 0);
                }
            }

        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            SearchDgv(TxtBuscarCedula.Text, 5);

            BtnSiguiente.Visible = true;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            FrmMantenimientoCitas.Instancia.isCancel = true;

            this.Close();
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            TxtBuscarCedula.Text = "";

            DgvListado.ClearSelection();
        }

        private void BtnSiguiente_Click(object sender, EventArgs e)
        {
            if (isAdding == true)
            {
                FrmMantenimientoCitas.Instancia.Paciente_id = id;

                isAdding = false;
                isPacienteSelected = false;

                this.Close();
            }
            else if (isPacienteSelected == true)
            {
                FrmMantenimientoCitas.Instancia.Medico_id = id;

                isAdding = false;
                isPacienteSelected = false;

                this.Close();
            }
        }

        private void DgvListado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(DgvListado.Rows[e.RowIndex].Cells[0].Value.ToString());

            BtnSiguiente.Visible = true;
        }

        #endregion

        #region Methods

        private void LoadData()
        {
            if (isAdding == true)
            {
                DgvListado.DataSource = _mantenimientoPacientes.GetAll();
                DgvListado.Columns[0].Visible = false;
                DgvListado.Columns[7].Visible = false;
                DgvListado.Columns[8].Visible = false;
                DgvListado.Columns[9].Visible = false;
            }
            else if(FrmMantenimientoCitas.Instancia.GetIsPacienteSelected() == true)
            {
                DgvListado.DataSource = _mantenimientoMedicos.GetAll();
                DgvListado.Columns[0].Visible = false;
                DgvListado.Columns[6].Visible = false;
            }
        }

        private void SearchDgv(string parameter, int cell)
        {
            foreach (DataGridViewRow row in DgvListado.Rows)
            {
                if (row.Cells[cell].Value.ToString().Equals(parameter))
                {
                    DgvListado.Rows[row.Index].Selected = true;
                }
            }
        }
        #endregion
    }
}
