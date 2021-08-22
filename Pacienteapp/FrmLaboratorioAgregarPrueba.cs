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
    public partial class FrmLaboratorioAgregarPrueba : Form
    {

        private int? id;

        private bool isEdit;

        private FrmAgregar_EditarUsuario Agregar_Editar;

        private MantenimientoPruebasLaboratorio _mantenimiento;

        public FrmLaboratorioAgregarPrueba()
        {
            InitializeComponent();

            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;

            SqlConnection connection = new SqlConnection(connectionString);

            _mantenimiento = new MantenimientoPruebasLaboratorio(connection);
        }

        private void BtnCrearNuevaPrueba_Click(object sender, EventArgs e)


        {


            if (Validations() == false)
            {

                if (GetIsEdit() == false)
                {

                    PruebasLaboratorio nuevaPrueba = new PruebasLaboratorio
                    {
                        Nombre = TxtAgregar.Text
                    };

                    _mantenimiento.Agregar(nuevaPrueba);

                    MessageBox.Show("Prueba creada con éxito!", "Notificación");


                    this.Close();
                }
                else
                {
                    PruebasLaboratorio editPrueba = new PruebasLaboratorio
                    {
                        Id = FrmListadoPruebaLaboratorio.Instancia.GetSelectedItem(),
                        Nombre = TxtAgregar.Text,
                       
                    };

                    _mantenimiento.Editar(editPrueba);

                    MessageBox.Show("Prueba editado exitosamente!", "Notificación");

                    this.Close();

                }
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {

        }

        internal void Eliminar(object p)
        {
            throw new NotImplementedException();


        }
        private bool Validations()
        {
            bool isEmpty = true;

            if (TxtAgregar.Text == "")
            {
                MessageBox.Show("Debe introducir un nombre", "Advertencia");
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

        private void TxtAgregar_TextChanged(object sender, EventArgs e)
        {

        }
    }
             
}
