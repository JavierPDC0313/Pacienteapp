using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BussinessLayer;
using DatabaseLayer.Models;

namespace Pacienteapp
{
    public sealed partial class FrmMantenimientoUsuarios : Form
    {
        private int? id;

        private bool isEdit;

        private bool LoginAgain;

        private MantenimientoUsuarios _mantenimiento;

        private FrmAgregar_EditarUsuario Agregar_Editar;
        private FrmMantenimientoUsuarios()
        {
            InitializeComponent();

            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;

            SqlConnection connection = new SqlConnection(connectionString);

            _mantenimiento = new MantenimientoUsuarios(connection);

        }

        public static FrmMantenimientoUsuarios Instancia { get; set; } = new FrmMantenimientoUsuarios();

        #region Events

        private void DgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                id = Convert.ToInt32(DgvUsuarios.Rows[e.RowIndex].Cells[0].Value.ToString());

                BtnEditar.Visible = true;
                BtnEliminar.Visible = true;
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            Agregar_Editar = new FrmAgregar_EditarUsuario(false);

            Agregar_Editar.Show();
            this.Hide();

        }

        private void FrmMantenimientoUsuarios_Activated(object sender, EventArgs e)
        {
            LoadData();

            isEdit = false;
        }

        private void FrmMantenimientoUsuarios_Deactivate(object sender, EventArgs e)
        {
            LoginAgain = false;
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (id >= 0)
            {
                Usuarios validar = new Usuarios();
                validar = _mantenimiento.GetById(id.Value);

                if (validar.Nombre_Usuario == FrmLogin.Login.Usuario)
                {
                    LoginAgain = true;
                }

                Agregar_Editar = new FrmAgregar_EditarUsuario(LoginAgain);

                isEdit = true;
                Agregar_Editar.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Debe seleccionar un campo que editar", "Advertencia");
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (id >= 0)
            {
                DialogResult result = MessageBox.Show("Estás seguro de que deseas eliminar este usuario", "Advertencia", MessageBoxButtons.OKCancel);

                if (result == DialogResult.OK)
                {
                    _mantenimiento.Eliminar(id.Value);

                    MessageBox.Show("Usuario eliminado satisfactoriamente!");

                    Usuarios validar = new Usuarios();
                    validar = _mantenimiento.GetById(id.Value);

                    if (validar.Nombre_Usuario == FrmLogin.Login.Usuario)
                    {
                        MessageBox.Show("Este usuario fue eliminado, debe volver a iniciar sesion", "Advertencia");

                        LoginAgain = true;

                        this.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un campo que eliminar", "Advertencia");
            }
        }

        private void FrmMantenimientoUsuarios_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void FrmMantenimientoUsuarios_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;

            if (LoginAgain == false)
            {
                FrmHomeDisplay homeDisplay = FrmHomeDisplay.HomeDisplay;
                homeDisplay.Show();
            }
            else
            {
                FrmLogin.Login.Show();
            }

            this.Hide();
        }

        #endregion

        #region Methods

        public bool GetIsEdit()
        {
            return isEdit;
        }

        public int GetSelectedItem()
        {
            return id.Value;
        }

        private void LoadData()
        {
            DgvUsuarios.DataSource = _mantenimiento.GetAll();
            DgvUsuarios.Columns[0].Visible = false;
            DgvUsuarios.ClearSelection();
        }

        #endregion
    }
}
