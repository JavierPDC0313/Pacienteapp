using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pacienteapp
{
    public sealed partial class FrmMantenimientoUsuarios : Form
    {
        private int? id;

        private bool isEdit;

        private FrmAgregar_EditarUsuario Agregar_Editar;
        private FrmMantenimientoUsuarios()
        {
            InitializeComponent();

            Agregar_Editar = new FrmAgregar_EditarUsuario();
        }

        public static FrmMantenimientoUsuarios Instancia { get; set; } = new FrmMantenimientoUsuarios();

        #region Events
        private void DgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                id = Convert.ToInt32(DgvUsuarios.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {

            Agregar_Editar.Show();
            this.Hide();

        }

        private void FrmMantenimientoUsuarios_Activated(object sender, EventArgs e)
        {
            isEdit = false;
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (id != null)
            {
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
            if (id != null)
            {
                DialogResult result = MessageBox.Show("Estás seguro de que deseas eliminar este usuario", "Advertencia", MessageBoxButtons.OKCancel);

                if (result == DialogResult.OK)
                {

                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un campo que eliminar", "Advertencia");
            }
        }
        #endregion

        #region Methods

        public bool GetIsEdit()
        {
            return isEdit;
        }

        #endregion

    }
}
