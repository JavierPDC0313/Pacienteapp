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
    public partial class FrmLogin : Form
    {
        public static FrmLogin Login { get; set; } = new FrmLogin();

        private bool User, Password;
        private string Usuario;
        private string Contraseño;

        private ServicioLogin repository;
        private FrmHomeDisplay homeDisplay;
        private Usuarios ItemUsuario; 

        public FrmLogin()
        {
            InitializeComponent();
        }

        #region Events
        private void cBoxVerContraseña_CheckedChanged(object sender, EventArgs e)
        {
            CheckBoxStatus();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            LoadLogin();
            txtContraseño.UseSystemPasswordChar = true;
        }

        private void FrmLogin_VisibleChanged(object sender, EventArgs e)
        {
            LoadLogin();
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

        private void LoadLogin()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);

            repository = new ServicioLogin(connection);

            User = false;
            Password = false;
        }
        #endregion
    }
}
