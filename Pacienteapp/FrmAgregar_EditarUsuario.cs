using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Pacienteapp.CustomControlItems;
using BussinessLayer;
using Database.Models;

namespace Pacienteapp
{
    public partial class FrmAgregar_EditarUsuario : Form
    {
        ServicioUsuario _servicio;

        public FrmAgregar_EditarUsuario()
        {
            InitializeComponent();

            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;

            SqlConnection connection = new SqlConnection(connectionString);

            _servicio = new ServicioUsuario(connection);
        }
        #region Events
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (Validations() == false)
            {
                if (GetIsEdit() == false)
                {
                    ComboBoxItem TipoUsuarioSeleccionado = CbxTipoUsuario.SelectedItem as ComboBoxItem;

                    Usuario nuevoUsuario = new Usuario
                    {
                        Nombre = TxtNombre.Text,
                        Apellido = TxtApellidoUsuario.Text,
                        Correo = TxtCorreoUsuario.Text,
                        Nombre_Usuario = TxtNombreUsuario.Text,
                        Contraseña = TxtContraseña.Text,
                        TipoUsuario = (string)TipoUsuarioSeleccionado.Text
                    };

                    _servicio.Agregar(nuevoUsuario);

                    MessageBox.Show("Usuario creado con éxito!","Notificación");

                    this.Close();
                }
                else
                {

                }
            }
        }

        private void FrmAgregar_EditarUsuario_Load(object sender, EventArgs e)
        {
            LoadComboBox();

            if (GetIsEdit() == true)
            {

                Usuario editUser = new Usuario();

                editUser = _servicio.GetById(FrmMantenimientoUsuarios.Instancia.GetSelectedItem());

                TxtNombre.Text = editUser.Nombre;
                TxtApellidoUsuario.Text = editUser.Apellido;
                TxtCorreoUsuario.Text = editUser.Correo;
                TxtNombreUsuario.Text = editUser.Nombre_Usuario;
                TxtContraseña.Text = editUser.Contraseña;
                TxtConfirmarContraseña.Text = editUser.Contraseña;
                CbxTipoUsuario.SelectedItem = CbxTipoUsuario.FindStringExact(editUser.TipoUsuario);
            }
        }

        private void FrmAgregar_EditarUsuario_FormClosing(object sender, FormClosingEventArgs e)
        {

            FrmMantenimientoUsuarios.Instancia.Show();

        }

        #endregion

        #region Methods
        private bool Validations()
        {
            try
            {
                bool isEmpty = true;

                ComboBoxItem TipoContacto = CbxTipoUsuario.SelectedItem as ComboBoxItem;

                if (TxtNombre.Text == "")
                {
                    MessageBox.Show("Debe introducir un nombre", "Advertencia");
                }
                else if (TxtApellidoUsuario.Text == "")
                {
                    MessageBox.Show("Debe introducir un apellido", "Advertencia");
                }
                else if(TxtCorreoUsuario.Text == "")
                {
                    MessageBox.Show("Debe introducir un correo", "Advertencia");
                }
                else if(TxtContraseña.Text == "")
                {
                    MessageBox.Show("Debe introducir una contraseña", "Advertencia");
                }
                else if(TxtConfirmarContraseña.Text == "")
                {
                    MessageBox.Show("Debe confirmar la contraseña", "Advertencia");
                }
                else if(TxtConfirmarContraseña.Text != TxtContraseña.Text)
                {
                    MessageBox.Show("Ambas contraseñas deben coincidir", "Advertencia");
                }
                else if(TipoContacto.Value == null)
                {
                    MessageBox.Show("Debe seleccionar un tipo de usuario", "Advertencia");
                }
                else if (_servicio.UserExists(TxtNombreUsuario.Text) == true)
                {
                    MessageBox.Show("Este usuario ya existe en el sistema, elije otro nombre", "Advertencia");
                }
                else
                {
                    isEmpty = false;
                }

                return isEmpty;
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error", "Advertencia");

                return true;
            }
        }

        private bool GetIsEdit()
        {
            bool Edit;

            Edit = FrmMantenimientoUsuarios.Instancia.GetIsEdit();

            return Edit;
        }

        private void LoadComboBox()
        {
            ComboBoxItem opcionPorDefecto = new ComboBoxItem
            {
                Text = "Seleccione una opcion...",
                Value = null
            };

            CbxTipoUsuario.Items.Add(opcionPorDefecto);
            CbxTipoUsuario.SelectedItem = opcionPorDefecto;

            ComboBoxItem Administrador = new ComboBoxItem
            {
                Text = "Administrador",
                Value = 1
            };

            ComboBoxItem Medico = new ComboBoxItem
            {
                Text = "Médico",
                Value = 2
            };

            CbxTipoUsuario.Items.Add(Administrador);
            CbxTipoUsuario.Items.Add(Medico);
        }

        #endregion
    }
}
