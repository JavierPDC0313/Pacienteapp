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

        public int Paciente_id { get; set; }

        public int Medico_id { get; set; }

        public bool isCancel { get; set; } 

        private MantenimientoCitas _mantenimientoCitas;

        private MantenimientoPacientes _mantenimientoPacientes;

        private MantenimientoDoctores _mantenimientoDoctores;

        private ListadoPaciente_Medico _listarPacientes;

        private ListadoPaciente_Medico _listarMedicos;

        private Agregar_EditarCitas _agregar_editar;

        private FrmMantenimientoCitas()
        {
            InitializeComponent();

            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;

            SqlConnection connection = new SqlConnection(connectionString);

            _mantenimientoCitas = new MantenimientoCitas(connection);

            _mantenimientoDoctores = new MantenimientoDoctores(connection);

            _mantenimientoPacientes = new MantenimientoPacientes(connection);
        }

        public static FrmMantenimientoCitas Instancia { get; set; } = new FrmMantenimientoCitas();

        #region Events
        private void DgvCitas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                id = Convert.ToInt32(DgvCitas.Rows[e.RowIndex].Cells[0].Value.ToString());

                Citas cita = new Citas();
                cita = _mantenimientoCitas.GetById(id.Value);

                Paciente_id = cita.IdPaciente;

                Medico_id = cita.IdDoctor;

                BtnEditar.Visible = true;
                BtnEliminar.Visible = true;

                if (GetCitaStatus() == 1)
                {
                    BtnConsultar.Visible = true;
                    BtnConsultarResultado.Visible = false;
                    BtnVerResultados.Visible = false;
                }
                else if (GetCitaStatus() == 2)
                {
                    BtnConsultar.Visible = false;
                    BtnConsultarResultado.Visible = true;
                    BtnVerResultados.Visible = false;
                }
                else
                {
                    BtnConsultar.Visible = false;
                    BtnConsultarResultado.Visible = false;
                    BtnVerResultados.Visible = true;
                }
            }
            else
            {
                BtnConsultar.Visible = false;
                BtnConsultarResultado.Visible = false;
                BtnEditar.Visible = false;
                BtnEliminar.Visible = false;
                BtnVerResultados.Visible = false;
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            isCancel = false;

            isAdding = true;

            isEdit = false;

            _listarPacientes = new ListadoPaciente_Medico();

            _listarPacientes.ShowDialog();

            if (Paciente_id >= 0 && isCancel == false)
            {
                isAdding = false;

                isPacienteSelected = true;

                _listarMedicos = new ListadoPaciente_Medico();

                _listarMedicos.ShowDialog();

                if (Medico_id >= 0 && isCancel == false)
                {
                    isPacienteSelected = false;

                    _agregar_editar = new Agregar_EditarCitas();
                    _agregar_editar.ShowDialog();
                }
            }

        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            FrmListadoPruebas_Resultados listado = new FrmListadoPruebas_Resultados(1);
            listado.Show();
            this.Hide();
        }

        private void BtnConsultarResultado_Click(object sender, EventArgs e)
        {
            FrmListadoPruebas_Resultados listado = new FrmListadoPruebas_Resultados(2);
            listado.Show();
            this.Hide();
        }

        private void BtnVerResultados_Click(object sender, EventArgs e)
        {
            FrmListadoPruebas_Resultados listado = new FrmListadoPruebas_Resultados(3);
            listado.Show();
            this.Hide();
        }

        private void FrmMantenimientoCitas_Activated(object sender, EventArgs e)
        {
            LoadData();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (id >= 0)
            {
                isAdding = true;

                isEdit = true;

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

                        _agregar_editar = new Agregar_EditarCitas();
                        _agregar_editar.ShowDialog();
                    }
                }
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
                    _mantenimientoCitas.Eliminar(GetSelectedItem());

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

            FrmHomeDisplay.HomeDisplay.Show();
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
            DgvCitas.DataSource = _mantenimientoCitas.GetAll();
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

        private int GetCitaStatus()
        {
            Citas cita = new Citas();
            cita = _mantenimientoCitas.GetById(id.Value);

            return cita.Estado;
        }

        #endregion
    }
}
