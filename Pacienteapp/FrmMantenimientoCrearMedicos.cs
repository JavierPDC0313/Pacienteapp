using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BussinessLayer;

namespace Pacienteapp
{
    public partial class FrmMantenimientoCrearMedicos : Form
    {

        private int? id;

        private bool isEdit;

        FrmMantenimientoCrearNuevoMedicos Agregar_Editar;
        MantenimientoDoctores _mantenimiento;
        public FrmMantenimientoCrearMedicos()
        {
            InitializeComponent();

            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;

            SqlConnection connection = new SqlConnection(connectionString);

            _mantenimiento = new MantenimientoDoctores(connection); 
        }

        public static FrmMantenimientoCrearMedicos Instancia { get; set; } = new FrmMantenimientoCrearMedicos();

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void BtnEliminarM_Click(object sender, EventArgs e)
        {
            if (id >= 0)
            {
                DialogResult result = MessageBox.Show("Estás seguro de que deseas eliminar este usuario", "Advertencia", MessageBoxButtons.OKCancel);

                if (result == DialogResult.OK)
                {
                    _mantenimiento.Eliminar(GetSelectedItem());

                    MessageBox.Show("La prueba ha sido eliminada satisfactoriamente!");

                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un campo que eliminar", "Advertencia");
            }


        }

        private void BtnEditarM_Click(object sender, EventArgs e)
        {

            
        }

        private void BtnEditarMedicos_Click(object sender, EventArgs e)
        {
            if (id >= 0)
            {
                Agregar_Editar = new FrmMantenimientoCrearNuevoMedicos();

                isEdit = true;
                Agregar_Editar.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un campo que editar", "Advertencia");
            }

        }

        public int GetSelectedItem()
        {
            return id.Value;
        }

        private void BtnCrearNuevoMed_Click(object sender, EventArgs e)
        {
            FrmMantenimientoCrearNuevoMedicos agregar = new FrmMantenimientoCrearNuevoMedicos();
            agregar.Show();
            this.Hide();
        }

       
        private void TxtBuscarMedicos_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

      
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void DgvMedicosListado_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}
