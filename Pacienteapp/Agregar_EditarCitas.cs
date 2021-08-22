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
    public partial class Agregar_EditarCitas : Form
    {

        private MantenimientoPacientes _mantenimientoPacientes;

        private MantenimientoDoctores _mantenimientoDoctores;

        private MantenimientoCitas _mantenimientoCitas;

        public Agregar_EditarCitas()
        {
            InitializeComponent();

            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;

            SqlConnection connection = new SqlConnection(connectionString);

            _mantenimientoDoctores = new MantenimientoDoctores(connection);

            _mantenimientoPacientes = new MantenimientoPacientes(connection);

            _mantenimientoCitas = new MantenimientoCitas(connection);
        }
        #region Events
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Agregar_EditarCitas_Load(object sender, EventArgs e)
       {
            Pacientes paciente = new Pacientes();
            paciente = _mantenimientoPacientes.GetById(FrmMantenimientoCitas.Instancia.Paciente_id);

            TxtNombrePaciente.Text = paciente.Nombre;

            Doctores medico = new Doctores();
            medico = _mantenimientoDoctores.GetById(FrmMantenimientoCitas.Instancia.Medico_id);

            TxtNombreMedico.Text = medico.Nombre;

            if (FrmMantenimientoCitas.Instancia.GetIsEdit() == true)
            {
                Citas editCita = new Citas();
                editCita = _mantenimientoCitas.GetById(FrmMantenimientoCitas.Instancia.GetSelectedItem());

                TxtFechaCita.Text = editCita.FechaHora.ToString("dd/MM/yyyy");
                TxtHora.Text = editCita.FechaHora.ToString("hh:mm");
                Txtcausa.Text = editCita.Causa;
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (Validations() == false)
            {
                if (FrmMantenimientoCitas.Instancia.GetIsEdit() == true)
                {
                    Citas cita = new Citas
                    {
                        Id = FrmMantenimientoCitas.Instancia.GetSelectedItem(),
                        IdPaciente = FrmMantenimientoCitas.Instancia.Paciente_id,
                        IdDoctor = FrmMantenimientoCitas.Instancia.Medico_id,
                        FechaHora = Convert.ToDateTime(TxtFechaCita.Text +" "+ TxtHora.Text),
                        Causa = Txtcausa.Text
                    };

                    _mantenimientoCitas.Editar(cita);

                    MessageBox.Show("Cita editada con éxito!");

                    this.Close();
                }
                else
                {
                    Citas cita = new Citas
                    {
                        IdPaciente = FrmMantenimientoCitas.Instancia.Paciente_id,
                        IdDoctor = FrmMantenimientoCitas.Instancia.Medico_id,
                        FechaHora = Convert.ToDateTime(TxtFechaCita.Text +" "+ TxtHora.Text),
                        Causa = Txtcausa.Text
                    };

                    _mantenimientoCitas.Agregar(cita);

                    MessageBox.Show("Cita agregada con éxito!", "Notificacion");

                    this.Close();
                }
            }
        }

        #endregion

        #region Methods

        private bool Validations()
        {
            bool isEmpty = true;

            if (TxtFechaCita.Text == "__/__/____")
            {
                MessageBox.Show("Debe insertar la fecha de la cita","Advertencia");
            }
            else if (TxtHora.Text == "__:__")
            {
                MessageBox.Show("Debe insertar la hora de la cita", "Advertencia");
            }
            else if (Txtcausa.Text == "")
            {
                MessageBox.Show("Debe insertar la causa de la cita", "Advertencia");
            }
            else
            {
                isEmpty = false;
            }

            return isEmpty;
        }

        #endregion
    }
}
