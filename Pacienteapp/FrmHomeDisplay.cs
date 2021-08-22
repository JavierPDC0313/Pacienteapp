using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Pacienteapp
{
    public sealed partial class FrmHomeDisplay : Form
    {
        public static FrmHomeDisplay HomeDisplay { get; set; } = new FrmHomeDisplay();
        public string TipoUsuario;

        public FrmHomeDisplay()
        {
            InitializeComponent();
        }

        #region Events

        private void FrmHomeDisplay_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void FrmHomeDisplay_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmLogin login = FrmLogin.Login;
            login.Show();

            this.Close();
        }

        private void FrmHomeDisplay_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }

        #endregion

        #region Methods
        private void LoadForm()
        {
            if (TipoUsuario == "Administrador")
            {
                btnMatenimiento_Usuario_Paciente.Text = "Mantenimiento usuarios";
                btnMatenimiento_Medico_Citas.Text = "Mantenimiento médicos";
                btnMatenimiento_PruebaLaboratorio_ResultadoLaboratorio.Text = "Mantenimiento pruebas laboratorio";
            }
            else if (TipoUsuario == "Medico")
            {
                btnMatenimiento_Usuario_Paciente.Text = "Mantenimiento pacientes";
                btnMatenimiento_Medico_Citas.Text = "Mantenimiento citas";
                btnMatenimiento_PruebaLaboratorio_ResultadoLaboratorio.Text = "Mantenimiento resultados";
            }
        }

        private void SwitchButton()
        {
            if (btnMatenimiento_Usuario_Paciente.Text == "Mantenimiento usuarios")
            {
                FrmMantenimientoUsuarios mantenimientoUsuarios = FrmMantenimientoUsuarios.Instancia;
                mantenimientoUsuarios.Show();

                this.Hide();
            }
            else if (btnMatenimiento_Medico_Citas.Text == "Mantenimiento médicos")
            {
                FrmMantenimientoUsuarios mantenimientoUsuarios = FrmMantenimientoUsuarios.Instancia;
                mantenimientoUsuarios.Show();

                this.Hide();
            }
            else if (btnMatenimiento_PruebaLaboratorio_ResultadoLaboratorio.Text == "Mantenimiento pruebas laboratorio")
            {
                FrmMantenimientoUsuarios mantenimientoUsuarios = FrmMantenimientoUsuarios.Instancia;
                mantenimientoUsuarios.Show();

                this.Hide();
            }
            else if (btnMatenimiento_Usuario_Paciente.Text == "Mantenimiento pacientes")
            {
                FrmMantenimientoUsuarios mantenimientoUsuarios = FrmMantenimientoUsuarios.Instancia;
                mantenimientoUsuarios.Show();

                this.Hide();
            }
            else if (btnMatenimiento_Medico_Citas.Text == "Mantenimiento citas")
            {
                FrmMantenimientoCitas mantenimientoCitas = FrmMantenimientoCitas.Instancia;
                mantenimientoCitas.Show();

                this.Hide();
            }
            else if (btnMatenimiento_PruebaLaboratorio_ResultadoLaboratorio.Text == "Mantenimiento resultados")
            {
                FrmMantenimientoUsuarios mantenimientoUsuarios = FrmMantenimientoUsuarios.Instancia;
                mantenimientoUsuarios.Show();

                this.Hide();
            }
        }
        #endregion
    }
}
