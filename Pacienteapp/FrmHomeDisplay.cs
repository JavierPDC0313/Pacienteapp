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

        private void FrmHomeDisplay_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            
            FrmLogin login = FrmLogin.Login;
            login.Show();

            this.Hide();
        }

        private void FrmHomeDisplay_VisibleChanged(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void btnMatenimiento_Usuario_Paciente_Click(object sender, EventArgs e)
        {
            SwitchbtnMatenimiento_Usuario_Paciente();
        }

        private void btnMatenimiento_Medico_Citas_Click(object sender, EventArgs e)
        {
            SwitchbtnMatenimiento_Medico_Citas();
        }

        private void btnMatenimiento_PruebaLaboratorio_ResultadoLaboratorio_Click(object sender, EventArgs e)
        {
            SwitchbtnMatenimiento_PruebaLaboratorio_ResultadoLaboratorio();
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

        private void SwitchbtnMatenimiento_Usuario_Paciente()
        {
            if (btnMatenimiento_Usuario_Paciente.Text == "Mantenimiento usuarios")
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
        }
        private void SwitchbtnMatenimiento_Medico_Citas()
        {
            if (btnMatenimiento_Medico_Citas.Text == "Mantenimiento médicos")
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
        }
        private void SwitchbtnMatenimiento_PruebaLaboratorio_ResultadoLaboratorio()
        {
            if (btnMatenimiento_PruebaLaboratorio_ResultadoLaboratorio.Text == "Mantenimiento pruebas laboratorio")
            {
                FrmMantenimientoUsuarios mantenimientoUsuarios = FrmMantenimientoUsuarios.Instancia;
                mantenimientoUsuarios.Show();

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
