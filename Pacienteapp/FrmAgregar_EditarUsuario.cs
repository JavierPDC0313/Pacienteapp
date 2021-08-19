using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Pacienteapp.CustomControlItems;

namespace Pacienteapp
{
    public partial class FrmAgregar_EditarUsuario : Form
    {
        public FrmAgregar_EditarUsuario()
        {
            InitializeComponent();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (Validations() == false)
            {

                if (GetIsEdit() == false)
                {

                }
                else
                {

                }
            }
        }

        private void FrmAgregar_EditarUsuario_Load(object sender, EventArgs e)
        {
            LoadComboBox();
        }

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
