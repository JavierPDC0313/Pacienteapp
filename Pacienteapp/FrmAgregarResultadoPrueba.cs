using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DatabaseLayer.Models;
using BussinessLayer;

namespace Pacienteapp
{
    public partial class FrmAgregarResultadoPrueba : Form
    {

        MantenimientoResultadosLaboratorio _mantenimiento;

        public FrmAgregarResultadoPrueba()
        {
            InitializeComponent();

            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;

            SqlConnection connection = new SqlConnection(connectionString);

            _mantenimiento = new MantenimientoResultadosLaboratorio(connection);
        }

        #region Events
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();

            FrmResultadoLaboratorio.ResultadoLaboratorio.Show();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (Validations() == false)
            {
                _mantenimiento.UpdateStatus(2, FrmResultadoLaboratorio.ResultadoLaboratorio.GetSelectedItem(), TxtResultado.Text);

                MessageBox.Show("Resultado agregado con éxito", "Notificacion");

                this.Close();
            }
        }

        private void FrmAgregarResultadoPrueba_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmResultadoLaboratorio.ResultadoLaboratorio.Show();
        }

        #endregion

        #region Methods

        private bool Validations()
        {
            bool isEmpty = true;

            if (TxtResultado.Text == "")
            {
                MessageBox.Show("Debe insertar un resultado","Advertencia");
            }
            else
            {
                isEmpty = false;
            }

            return isEmpty;
        }

        #endregion
    }
}
