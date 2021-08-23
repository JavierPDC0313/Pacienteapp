using BussinessLayer;
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
    public sealed partial class FrmMantenimientoPacientes : Form
    {
        public static FrmMantenimientoPacientes MantenimientoPacientes { get; set; } = new FrmMantenimientoPacientes();

        private int? Id;
        private bool Done;

        private MantenimientoPacientes mantenimiento;
        private FrmAgregar_EditarPacientes FrmAdministrar;

        public FrmMantenimientoPacientes()
        {
            InitializeComponent();

            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            mantenimiento = new MantenimientoPacientes(connection);
        }

        #region Events

        private void FrmMantenimientoPacientes_Load(object sender, EventArgs e)
        {
            LoadList();
        }

        private void FrmMantenimientoPacientes_VisibleChanged(object sender, EventArgs e)
        {
            LoadList();
        }

        private void FrmMantenimientoPacientes_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;

            FrmHomeDisplay homeDisplay = FrmHomeDisplay.HomeDisplay;
            homeDisplay.Show();

            this.Hide();
        }

        private void DGVPantallaListado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                Id = Convert.ToInt32(DGVPantallaListado.Rows[e.RowIndex].Cells[0].Value);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AbrirAgregar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            AbrirEditar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
        }

        #endregion

        #region Methods
        private void LoadList()
        {
            DGVPantallaListado.DataSource = mantenimiento.GetAll();
            DGVPantallaListado.Columns[0].Visible = false;
            DGVPantallaListado.ClearSelection();
        }

        private void Eliminar()
        {
            if (Id != null)
            {
                DialogResult dialogResult = MessageBox.Show("¿Desea eliminar este item?", "Alerta", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    Done = mantenimiento.Eliminar(Id.Value);

                    ComprobarEjecucion();
                    LoadList();
                }
            }
            else
            {
                MessageBox.Show("No se ha seleccionado ningun item", "Error");
            }
        }

        private void ComprobarEjecucion()
        {
            if (Done)
            {
                MessageBox.Show("Realizado satisfactoriamente", "Notificación");
            }
            else if (!Done)
            {
                MessageBox.Show("No se han podido efectuar los cambios", "Notificación");
            }
        }

        private void AbrirAgregar()
        {
            FrmAdministrar = FrmAgregar_EditarPacientes.Agregar_EditarPacientes;
            FrmAdministrar.TipoAccionar = "guardar";
            FrmAdministrar.Show();

            this.Hide();
        }

        private void AbrirEditar()
        {
            if (Id != null)
            {
                FrmAdministrar = FrmAgregar_EditarPacientes.Agregar_EditarPacientes;
                FrmAdministrar.TipoAccionar = "editar";
                FrmAdministrar.Id = Id;
                FrmAdministrar.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("No se ha seleccionado ningun item", "Error");
            }
        }
        #endregion
    }
}
