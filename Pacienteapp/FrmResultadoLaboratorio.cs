using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DatabaseLayer.Models;
using BussinessLayer;
using System.Configuration;
using System.Data.SqlClient;

namespace Pacienteapp
{
    public sealed partial class FrmResultadoLaboratorio : Form
    {
        private int id;

        private bool isClosing;

        MantenimientoResultadosLaboratorio _mantenimientoResultados;
        public static FrmResultadoLaboratorio ResultadoLaboratorio { get; set; } = new FrmResultadoLaboratorio();
        public FrmResultadoLaboratorio()
        {
            InitializeComponent();

            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;

            SqlConnection connection = new SqlConnection(connectionString);

            _mantenimientoResultados = new MantenimientoResultadosLaboratorio(connection);
        }
        #region Events

        private void DgvPantallaListado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                id = Convert.ToInt32(DgvPantallaListado.Rows[e.RowIndex].Cells[0].Value.ToString());

                btnReportarResultados.Visible = true;
            }
        }

        private void btnReportarResultados_Click(object sender, EventArgs e)
        {
            if (id >= 0)
            {
                FrmAgregarResultadoPrueba agregarResultado = new FrmAgregarResultadoPrueba();

                agregarResultado.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un resultado para reportar", "Advertencia");
            }
        }

        private void FrmResultadoLaboratorio_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;

            this.Hide();

            FrmHomeDisplay.HomeDisplay.Show();
        }

        private void FrmResultadoLaboratorio_Activated(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DgvPantallaListado.DataSource = _mantenimientoResultados.GetAllPendingByCedula(1, TxtBuscar.Text);
            DgvPantallaListado.Refresh();
        }

        private void btnLimpiarBusqueda_Click(object sender, EventArgs e)
        {
            TxtBuscar.Text = "";

            LoadData();
        }

        #endregion

        #region Methods

        private void LoadData()
        {
            DgvPantallaListado.DataSource = _mantenimientoResultados.GetAllPending(1);
            DgvPantallaListado.ClearSelection();
        }

        public int GetSelectedItem()
        {
            return id;
        }

        #endregion
    }
}
