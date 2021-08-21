using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Pacienteapp
{
    public partial class FrmLogin : Form
    {
        public static FrmLogin Login { get; set; } = new FrmLogin();
        private bool User, Password;
        private string Usuario, Contraseño, TipoUsuario;

        public FrmLogin()
        {
            InitializeComponent();

            User = false;
            Password = false;
        }

        #region Events
        private void cBoxVerContraseña_CheckedChanged(object sender, EventArgs e)
        {
            CheckBoxStatus();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            txtContraseño.PasswordChar = '*';
            txtContraseño.UseSystemPasswordChar = true;
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

            if (CheckData() == true)
            {
                if (User == true && Password == true)
                {
                    respuesta = true;
                }
                else
                {
                    MessageBox.Show("El nombre de usuario o contraseña no es valido", "Error");
                }
            }
            else
            {
                MessageBox.Show("Debe llenar todos los campos para avanzar", "Error");
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
        #endregion
    }
}
