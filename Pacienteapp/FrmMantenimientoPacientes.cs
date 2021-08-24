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
            btnUnselect.Visible = false;
            LoadList();
        }

        private void FrmMantenimientoPacientes_VisibleChanged(object sender, EventArgs e)
        {
            btnUnselect.Visible = false;
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
            btnUnselect.Visible = true;
            if (e.RowIndex >= 0)
                Id = Convert.ToInt32(DGVPantallaListado.Rows[e.RowIndex].Cells[0].Value);
            MostrarFoto();

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

        private void btnUnselect_Click(object sender, EventArgs e)
        {
            DGVPantallaListado.ClearSelection();
            Id = null;
            btnUnselect.Visible = true;
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
            FrmAdministrar = new FrmAgregar_EditarPacientes();
            FrmAdministrar.Show();

            this.Hide();
        }

        private void AbrirEditar()
        {
            if (Id != null)
            {
                FrmAdministrar = new FrmAgregar_EditarPacientes();
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

        private void MostrarFoto()
        {
            if (Id != null)
            {
                try
                {
                    Pacientes pacientes = mantenimiento.GetById(Id.Value);

                    FotoPaciente.ImageLocation = pacientes.Foto;
                }
                catch(Exception e)
                {
                    string direction = @"C: \Users\jorge\Documents\GitHub\Pacienteapp\\1200px - No_sign.svg.png";
                    FotoPaciente.ImageLocation = direction;
                }
            }
        }
        #endregion
    }
}
