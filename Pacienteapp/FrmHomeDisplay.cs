using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Pacienteapp
{
    public partial class FrmHomeDisplay : Form
    {
        public string TipoUsuario;

        public FrmHomeDisplay(string tipoUsuario)
        {
            InitializeComponent();

            TipoUsuario = tipoUsuario;
        }

        #region Events

        private void FrmHomeDisplay_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        #endregion

        #region Methods
        private void LoadForm()
        {
            if (TipoUsuario == "Administrador")
            {
                btnMatenimiento_Usuario_Paciente.Text = "Mantenimiento de usuarios";
                btnMatenimiento_Medico_Citas.Text = "Mantenimiento de médicos";
                btnMatenimiento_PruebaLaboratorio_ResultadoLaboratorio.Text = "Mantenimiento de citas";
            }
            else if (TipoUsuario == "Médico")
            {
                btnMatenimiento_Usuario_Paciente.Text = "Mantenimiento de pacientes";
                btnMatenimiento_Medico_Citas.Text = "Mantenimiento de citas";
                btnMatenimiento_PruebaLaboratorio_ResultadoLaboratorio.Text = "Mantenimiento de resultados";
            }
        }
        #endregion

        private void FrmHomeDisplay_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmLogin.Login.Show();
            this.Close();
        }
    }
}
