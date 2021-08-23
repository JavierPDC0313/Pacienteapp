using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Pacienteapp
{
    public partial class FrmAgregar_EditarPacientes : Form
    {
        private string TipoAccionar;
        public FrmAgregar_EditarPacientes(string tipoAccionar)
        {
            InitializeComponent();

            TipoAccionar = tipoAccionar;
        }
        #region Events
        private void button1_Click(object sender, EventArgs e)
        {

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
            DateTime dateTime = dTPFechaNacimiento.Value;
            bool fumador = cBoxFumador_OpcionSi.Checked ? true : cBoxFumador_OpcionNo.Checked ? true : false;
            string alergia = txtAlergias.Text;
            string foto = txtFoto.Text;

            bool respuesta = true;

            if (nombre.Length <= 0 || apellido.Length <= 0 || telefono.Length <= 0 || direccion.Length <= 0 || cedula.Length <= 0 || dateTime == DateTime.Now || alergia.Length <= 0 || foto.Length <= 0 || fumador == false)
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

                }
                else if (TipoAccionar == "editar")
                {

                }
            }
            else
            {
                MessageBox.Show("Debe llenar todos los campos para avanzar", "Error");
            }
        }
        #endregion
    }
}
