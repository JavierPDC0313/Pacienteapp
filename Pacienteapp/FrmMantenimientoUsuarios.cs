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
    public partial class FrmMantenimientoUsuarios : Form
    {
        private int id;
        public FrmMantenimientoUsuarios()
        {
            InitializeComponent();
        }

        private void DgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = e.RowIndex;
        }
    }
}
