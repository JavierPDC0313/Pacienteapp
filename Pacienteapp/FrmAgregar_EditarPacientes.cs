using BussinessLayer;
using DatabaseLayer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Pacienteapp
{
    public sealed partial class FrmAgregar_EditarPacientes : Form
    {
        public static FrmAgregar_EditarPacientes Agregar_EditarPacientes { get; set; } = new FrmAgregar_EditarPacientes();

        public string TipoAccionar;
        public int? Id;
        private bool DateChanged = false;
        private bool Done;

        private MantenimientoPacientes mantenimiento;

        public FrmAgregar_EditarPacientes()
        {
            InitializeComponent();

            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            mantenimiento = new MantenimientoPacientes(connection);
        }
        #region Events

        private void FrmAgregar_EditarPacientes_Load(object sender, EventArgs e)
        {
            LoadComponets();
        }

        private void FrmAgregar_EditarPacientes_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;

            CerrarForm();
        }

        private void cBoxFumador_OpcionSi_CheckedChanged(object sender, EventArgs e)
        {
            if (cBoxFumador_OpcionSi.Checked == true)
            {
                cBoxFumador_OpcionNo.Checked = false;
            }
        }

        private void cBoxFumador_OpcionNo_CheckedChanged(object sender, EventArgs e)
        {
            if (cBoxFumador_OpcionNo.Checked == true)
            {
                cBoxFumador_OpcionSi.Checked = false;
            }
        }

        private void dTPFechaNacimiento_ValueChanged(object sender, EventArgs e)
        {
            DateChanged = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Accionar();
        }

        private void btnSeleccionarFoto_Click(object sender, EventArgs e)
        {
            AgregarFoto();
        }
        #endregion

        #region Methods
        private bool CheckData()
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string telefono = txtTelefono.Text;
            string direccion = txtDireccion.Text;
            string cedula = txtCedula.Text;
            bool fumador = cBoxFumador_OpcionSi.Checked ? true : cBoxFumador_OpcionNo.Checked ? true : false;
            string alergia = txtAlergias.Text;
            string foto = txtFoto.Text;

            bool respuesta = true;

            if (nombre.Length <= 0 || apellido.Length <= 0 || telefono.Length <= 0 || direccion.Length <= 0 || cedula.Length <= 0 || DateChanged == false || alergia.Length <= 0 || foto.Length <= 0 || fumador == false)
            {
                respuesta = false;
            }

            return respuesta;
        }

        private void Accionar()
        {
            if (CheckData() == true)
            {
                if (TipoAccionar == "agregar")
                {
                    Pacientes pacientes = new Pacientes();

                    pacientes.Nombre = txtNombre.Text;
                    pacientes.Apellido = txtApellido.Text;
                    pacientes.Telefono = txtTelefono.Text;
                    pacientes.Direccion = txtDireccion.Text;
                    pacientes.Cedula = txtCedula.Text;
                    pacientes.FechaNacimiento = dTPFechaNacimiento.Value;
                    pacientes.Fumador = cBoxFumador_OpcionSi.Checked ? 1 : 0;
                    pacientes.Alergias = txtAlergias.Text;
                    pacientes.Foto = txtFoto.Text;

                    Done = mantenimiento.Agregar(pacientes);

                    MensagePostEjecucion();
                }
                else if (TipoAccionar == "editar")
                {
                    Pacientes pacientes = mantenimiento.GetById(Id.Value);

                    pacientes.Nombre = txtNombre.Text;
                    pacientes.Apellido = txtApellido.Text;
                    pacientes.Telefono = txtTelefono.Text;
                    pacientes.Direccion = txtDireccion.Text;
                    pacientes.Cedula = txtCedula.Text;
                    pacientes.FechaNacimiento = dTPFechaNacimiento.Value;
                    pacientes.Fumador = cBoxFumador_OpcionSi.Checked ? 1 : 0;
                    pacientes.Alergias = txtAlergias.Text;
                    pacientes.Foto = txtFoto.Text;

                    Done = mantenimiento.Editar(pacientes);

                    MensagePostEjecucion();
                    CerrarForm();
                }
            }
            else
            {
                MessageBox.Show("Debe llenar todos los campos para avanzar", "Error");
            }
        }

        private void LoadComponets()
        {
            if (TipoAccionar == "editar")
            {
                Pacientes pacientes = mantenimiento.GetById(Id.Value);

                txtNombre.Text = pacientes.Nombre;
                txtApellido.Text = pacientes.Apellido;
                txtTelefono.Text = pacientes.Telefono;
                txtDireccion.Text = pacientes.Direccion;
                txtCedula.Text = pacientes.Cedula;
                dTPFechaNacimiento.Value = pacientes.FechaNacimiento;
                if (pacientes.Fumador == 1)
                {
                    cBoxFumador_OpcionSi.Checked = true;
                }
                else
                {
                    cBoxFumador_OpcionNo.Checked = true;
                }
                txtAlergias.Text = pacientes.Alergias;
                txtFoto.Text = pacientes.Foto;
            }
        }

        private void DataClear()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtTelefono.Clear();
            txtDireccion.Clear();
            txtCedula.Clear();
            dTPFechaNacimiento.ResetText();
            cBoxFumador_OpcionSi.Checked = false;
            cBoxFumador_OpcionNo.Checked = false;
            txtAlergias.Clear();
            txtFoto.Clear();
        }

        private void MensagePostEjecucion()
        {
            if (Done == true)
            {
                MessageBox.Show("La consulta se a efectuado exitosamente", "Notificacion");

                DataClear();
            }
            else if (Done == false)
            {
                MessageBox.Show("Ha ocurrido un error, revise los datos ingresados", "Error");
            }
        }

        private void CerrarForm()
        {
            FrmMantenimientoPacientes mantenimientoPacientes = FrmMantenimientoPacientes.MantenimientoPacientes;
            mantenimientoPacientes.Show();

            this.Hide();
        }

        private void AgregarFoto()
        {
            DialogResult result = PicturesDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                string file = PicturesDialog.FileName;

                txtFoto.Text = GuardarFoto(file);
            }
        }

        private string GuardarFoto(string file)
        {
            int id = mantenimiento.GetLastId() == 0 ? 0 : mantenimiento.GetLastId() + 1;

            string directorio = @"Images\PacienteApp\medicoId_" + id + "\\";
            string[] fileNameSplit = file.Split('\\');
            string filename = fileNameSplit[(fileNameSplit.Length - 1)];

            mantenimiento.CrearDirectorio(directorio);

            string destino = directorio + filename;

            File.Copy(file, destino, true);

            return destino;
        }
        #endregion
    }
}
