using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Mantenimentos;

namespace Mantenimentos
{
    public partial class FrmMantenimientoMedicosCrear : Form
    {
        public object MessageBoxIcom { get; private set; }

        public FrmMantenimientoMedicosCrear()
        {
            InitializeComponent();
        }

        //MENSAJE DE CONFIRMACION
        private void MensajeConfirmacion(string mensaje)
        {
            MessageBox.Show(mensaje, "Agregar Medicos", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //MENSAJE DE ERROR
        private void MensajeError(string mensje)
        {
            MessageBox.Show(mensaje, "Agregar Medicos", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //METODO ACCIONES DE LA TABLA
        private void AccionesTablas()
        {
            DataListado.Columns[0].Visible = false;

            DataListado.Columns[1].HeaderText = "Codigos";
            DataListado.Columns[2].HeaderText = "CI o RUC";
            DataListado.Columns[3].HeaderText = "Razon Social";
            DataListado.Columns[4].HeaderText = "Direcion";
            DataListado.Columns[5].HeaderText = "Telefono";
            DataListado.Columns[6].HeaderText = "Correo";
        }
        //METODO MOSTRAR REGISTRO
        private void MostrarMedicos()
        {
            DataListado.DataSource = FrmMedicos.MostrarMedicos();
            AccionesTablas();
        }

        //METODO BUSCAR MEDICOS
        private void BuscarMedicos()
        {
            DataListado.DataSource = FrmMantenimientoMedicosCrear.BuscarMedicos(TxtBuscar.Text);
            LblTotalR.Text = "Total Registro de Medicos: " + DataListado.CurrentRow.Cells.Count;
            AccionesTablas();
        }
        //METODO ACTUALIZAR REGISTRO
        private void ActualizarRegistro(object sender, FormClosedEventArgs e)
        {
            MostrarMedicos();
        }

        //METODO MOSTRAR CUADRO DE DIALOGO
        private void MostrarMensajes()
        {
            TtMensajes.SetToolTip(TxtBuscar, "busque un medico.");
            TtMensajes.SetToolTip(BtnAgregar, "inserte un nuevo medicco al registro.");
            TtMensajes.SetToolTip(BtnEditar, "seleccione para editar un medico.");
            TtMensajes.SetToolTip(BtnEliminar, "Seleccione un medicco para eliminar.");
        }

        private static object BuscarMedicos(string text)
        {
            throw new NotImplementedException();
        }

        private void FrmMantenimientoMedicosCrear_Load(object sender, EventArgs e)
        {
            MostrarMensajes();
            MostrarMedicos();
 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (DataListado.SelectedRows.Count>0)
                {
                    DialogResult opcion;
                    opcion = MessageBox.Show("Realmente deseas eliminar este medico.?", "Medicos", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (opcion==DialogResult.OK)
                    {
                        string respuesta;
                        respuesta = FrmMantenimientoMedicosCrear.EliminarRegistros(Convert.ToInt32(DataListado.CurrentRow.Cells[0].Value));
                        if (respuesta.Equals("OK"))
                        {
                            MensajeConfirmacion("Se elimino Correctamente el Medico.");
                        }

                        else

                        {
                            MensajeError(respuesta);
                        }
                            MostrarMedicos();
                    }
                }
            }

            catch (Exception ex)
            {

                MensajeError("No se pudo Eliminar el Medico");

            }
         
        }

        private static string EliminarRegistros(int v)
        {
            throw new NotImplementedException();
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            BuscarMedicos();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            FrmMedicos nuevomedico = new FrmMedicos();
            nuevomedico.FormClosed += new FormClosedEventHandler(ActualizarRegistro);
            nuevomedico.ShowDialog();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            FrmMedicos editarmedicos = new FrmMedicos();
            editarmedicos.FormClosed += new FormClosedEventHandler(ActualizarRegistro);
            if (DataListado.SelectedRows.Count > 0)
            {
                editarmedicos.Editar = true;
                editarmedicos.TxtIdMedicos = DataListado.CurrentRow.Cells[0].Value.ToString();
                editarmedicos.TxtCodigo = DataListado.CurrentRow.Cells[1].Value.ToString();
                editarmedicos.TxtCIORUC = DataListado.CurrentRow.Cells[1].Value.ToString();
                editarmedicos.TxtRazonSocial = DataListado.CurrentRow.Cells[1].Value.ToString();
                editarmedicos.TxtDireccion = DataListado.CurrentRow.Cells[1].Value.ToString();
                editarmedicos.TxtTelefono = DataListado.CurrentRow.Cells[1].Value.ToString();
                editarmedicos.TxtCorreo = DataListado.CurrentRow.Cells[1].Value.ToString();
                editarmedicos.ShowDialog();

            }
           else
            {
                MensajeError("Seleccione un medico para Editar.");
            }
        }

        private void LblTotalR_Click(object sender, EventArgs e)
        {

        }
    }
}
