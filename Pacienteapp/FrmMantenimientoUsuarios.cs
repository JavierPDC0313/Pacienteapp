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
        private int id;

        private bool isEdit;

        private FrmAgregar_EditarUsuario Agregar_Editar;
        private FrmMantenimientoUsuarios()
        {
            InitializeComponent();

            Agregar_Editar = new FrmAgregar_EditarUsuario();
        }

        public FrmMantenimientoUsuarios Instancia { get; set; } = new FrmMantenimientoUsuarios();

        private void DgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = e.RowIndex;
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
            isEdit = true;
            Agregar_Editar.Show();
            this.Hide();
        }
    }
}
