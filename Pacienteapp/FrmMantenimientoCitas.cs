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
    public sealed partial class FrmMantenimientoCitas : Form
    {

        private int? id;

        private bool isEdit;

        private bool isAdding;

        private bool isPacienteSelected;

        private bool isMedicoSeleceted;

        public int Paciente_id { get; set; }

        public int Medico_id { get; set; }

        public DateTime FechayHora { get; set; }

        private MantenimientoCitas _mantenimiento;

        private ListadoPaciente_Medico _listarPacientes;

        private ListadoPaciente_Medico _listarMedicos;

        private Agregar_EditarCitas _agregar_editar;

        private FrmMantenimientoCitas()
        {
            InitializeComponent();

            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;

            SqlConnection connection = new SqlConnection(connectionString);

            _mantenimiento = new MantenimientoCitas(connection);
        }

        public static FrmMantenimientoCitas Instancia { get; set; } = new FrmMantenimientoCitas();

        #region Events
        private void DgvCitas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                id = Convert.ToInt32(DgvCitas.Rows[e.RowIndex].Cells[0].Value.ToString());

                BtnEditar.Visible = true;
                BtnEliminar.Visible = true;
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {

            isAdding = true;

            _listarPacientes = new ListadoPaciente_Medico();

            _listarPacientes.ShowDialog();

            if (Paciente_id >= 0)
            {
                isAdding = false;

                isPacienteSelected = true;

                _listarMedicos = new ListadoPaciente_Medico();

                _listarMedicos.ShowDialog();

                if (Medico_id >= 0)
                {
                    isPacienteSelected = false;

                    isMedicoSeleceted = true;

                    _agregar_editar = new Agregar_EditarCitas();
                    _agregar_editar.ShowDialog();
                }
            }

            Citas newCita = new Citas 
            { 
                
            };



            MessageBox.Show("Cita agregada con éxito", "");

        }

        private void FrmMantenimientoCitas_Activated(object sender, EventArgs e)
        {
            LoadData();

            isEdit = false;
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (id >= 0)
            {
                _listar = new ListadoPaciente_Medico();

                isEdit = true;
                _listar.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un campo que editar", "Advertencia");
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (id >= 0)
            {
                DialogResult result = MessageBox.Show("Estás seguro de que deseas eliminar esta Cita", "Advertencia", MessageBoxButtons.OKCancel);

                if (result == DialogResult.OK)
                {
                    _mantenimiento.Eliminar(GetSelectedItem());

                    MessageBox.Show("Cita eliminada satisfactoriamente!");

                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un campo que eliminar", "Advertencia");
            }
        }

        private void FrmMantenimientoCitas_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void FrmMantenimientoCitas_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;

            this.Hide();
        }

        #endregion

        #region Methods

        public bool GetIsEdit()
        {
            return isEdit;
        }

        public int GetSelectedItem()
        {
            return id.Value;
        }

        private void LoadData()
        {
            DgvCitas.DataSource = _mantenimiento.GetAll();
            DgvCitas.Columns[0].Visible = false;
            DgvCitas.ClearSelection();
        }

        public bool GetIsAdding()
        {
            return isAdding;
        }

        public bool GetIsPacienteSelected()
        {
            return isPacienteSelected;
        }

        #endregion
    }
}
