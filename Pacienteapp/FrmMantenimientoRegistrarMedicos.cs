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
    public partial class FrmMantenimientoCrearNuevoMedicos : Form
    {

        private int? id;

        private bool isEdit;

       private MantenimientoPruebasLaboratorio _mantenimiento;


        public FrmMantenimientoCrearNuevoMedicos()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddPhoto()
        {
            DialogResult result = PictureDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string filename = PictureDialog.FileName;
                PbPerfil.ImageLocation = filename;
            } 
        }
        private void BtnSubirFotos_Click(object sender, EventArgs e)
        {
            AddPhoto();
        }

        private void BtnCrearMedico_Click(object sender, EventArgs e)
        {


            if (Validations() == false)
            {

                if (GetIsEdit() == false)
                {

                    PruebasLaboratorio nuevaPrueba = new PruebasLaboratorio
                    {
                        Nombre = TxtNombre.Text
                    };

                    _mantenimiento.Agregar(nuevaPrueba);

                    MessageBox.Show("Medico creado con éxito!", "Notificación");


                    this.Close();
                }
                else
                {
                    PruebasLaboratorio editPrueba = new PruebasLaboratorio
                    {
                        Id = FrmListadoPruebaLaboratorio.Instancia.GetSelectedItem(),
                        Nombre = TxtNombre.Text,

                    };

                    _mantenimiento.Editar(editPrueba);

                    MessageBox.Show("Medico editado exitosamente!", "Notificación");

                    this.Close();

                }
            }
        }
        private bool Validations()
        {
            bool isEmpty = true;

            if (TxtNombre.Text == "")
            {
                MessageBox.Show("Debe introducir un nombre", "Advertencia");
            }
            if (TxtApellido.Text == "")
            {
                MessageBox.Show("Debe introducir un apellido", "Advertencia");
            }
            if (TxtCorreo.Text == "")
            {
                MessageBox.Show("Debe introducir un correo", "Advertencia");
            }
            if (TxtTelefono.Text == "")
            {
                MessageBox.Show("Debe introducir un Telefono", "Advertencia");
            }
            if (TxtCedulas.Text == "")
            {
                MessageBox.Show("Debe introducir un cedula", "Advertencia");
            }
            else
            {
                isEmpty = false;
            }

            return isEmpty;
        }

        private bool GetIsEdit()
        {
            bool Edit;

            Edit = FrmListadoPruebaLaboratorio.Instancia.GetIsEdit();

            return Edit;
        }

        private void MostrarFoto()
        {
            Pacientes pacientes = mantenimiento.GetById(Id.Value);

            FotoPaciente.ImageLocation = pacientes.Foto;
        }
    }
}

