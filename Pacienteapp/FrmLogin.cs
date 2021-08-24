using BussinessLayer;
using DatabaseLayer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Pacienteapp
{
    public sealed partial class FrmLogin : Form
    {

        private bool User, Password;
        private string Contraseño;

        public string Usuario { get; set; }

        private ServicioLogin repository;
        private FrmHomeDisplay homeDisplay;
        private Usuarios ItemUsuario;

        private MantenimientoUsuarios _mantenimientos;

        private FrmLogin()
        {
            InitializeComponent();

            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);

            repository = new ServicioLogin(connection);

            _mantenimientos = new MantenimientoUsuarios(connection);

            User = false;
            Password = false;
        }

        public static FrmLogin Login { get; set; } = new FrmLogin();

        #region Events
        private void cBoxVerContraseña_CheckedChanged(object sender, EventArgs e)
        {
            CheckBoxStatus();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            txtContraseño.UseSystemPasswordChar = true;

            if (_mantenimientos.UserIsEmpty() == true)
            {
                Usuarios usuario = new Usuarios
                {
                    Id = 1,
                    TipoUsuario = "Administrador",
                    Nombre = "default",
                    Apellido = "default",
                    Correo = "default@hotmail.com",
                    Nombre_Usuario = "default",
                    Contraseña = "default"
                };

                _mantenimientos.Agregar(usuario);
            }
        }

        private void FrmLogin_VisibleChanged(object sender, EventArgs e)
        {
            txtUsuario.Clear();
            txtContraseño.Clear();
        }

        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;

            DialogResult result = MessageBox.Show("¿Desea salir del programa?", "Alerta", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {
                e.Cancel = false;
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (CheckCredentials() == true)
            {
                OpenHomeDisplay();
            }
        }
        #endregion

        #region Methods
        private void CheckBoxStatus()
        {
            if (cBoxVerContraseña.Checked == true)
            {
                txtContraseño.UseSystemPasswordChar = false;
            }
            else
            {
                txtContraseño.UseSystemPasswordChar = true;
            }
        }

        private bool CheckCredentials()
        {
            bool respuesta = false;

            CredentialsValidation();

            if (User == true && Password == true)
            {
                respuesta = true;
            }
            else
            {
                MessageBox.Show("El nombre de usuario o contraseña no es valido", "Error");
            }

            return respuesta;
        }

        private bool CheckData()
        {
            Usuario = txtUsuario.Text;
            Contraseño = txtContraseño.Text;

            bool respuesta = true;

            if (Usuario.Length <= 0 || Contraseño.Length <= 0)
            {
                respuesta = false;
            }

            return respuesta;
        }

        private void CredentialsValidation()
        {
            if (CheckData() == true)
            {
                if (repository.UserExists(Usuario) == true)
                {
                    User = true;

                    ItemUsuario = repository.GetByUser(Usuario);

                    if (Contraseño == ItemUsuario.Contraseña)
                    {
                        Password = true;
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe llenar todos los campos para avanzar", "Error");
            }
        }

        private void OpenHomeDisplay()
        {
            if (ItemUsuario.TipoUsuario == "Administrador" || ItemUsuario.TipoUsuario == "Medico")
            {
                homeDisplay = FrmHomeDisplay.HomeDisplay;
                homeDisplay.TipoUsuario = ItemUsuario.TipoUsuario;
                homeDisplay.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Su usuario no tiene un rol asignado correctamente", "Error");
            }
        }
        #endregion
    }
}
