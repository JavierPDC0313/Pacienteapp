using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BussinessLayer;

namespace Pacienteapp
{
    public sealed partial class FrmListadoPruebaLaboratorio : Form

    {

        private int? id;

        private bool isEdit;

        FrmLaboratorioAgregarPrueba Agregar_Editar;
        MantenimientoPruebasLaboratorio _mantenimiento;


        private FrmListadoPruebaLaboratorio()
        {
            InitializeComponent();
        }

        public static FrmListadoPruebaLaboratorio Instancia { get; set; } = new FrmListadoPruebaLaboratorio();

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {



        }

        private void BtnEliminarPruebLaboratorio_Click(object sender, EventArgs e)
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

        private void BtnEliminarPrueba_Click(object sender, EventArgs e)
        {
            if (id >= 0)
            {
                Agregar_Editar = new FrmLaboratorioAgregarPrueba();

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

        private void BtnCrearNuevaPrueba_Click(object sender, EventArgs e)
        {
            Agregar_Editar = new FrmLaboratorioAgregarPrueba();

            Agregar_Editar.Show();
            this.Hide();
        }

        public bool GetIsEdit()
        {
            return isEdit;

      
       }

        private void LoadData()
        {
            dataGridView1.DataSource = _mantenimiento.GetAll();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.ClearSelection();
        }

        private void FrmListadoPruebaLaboratorio_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
