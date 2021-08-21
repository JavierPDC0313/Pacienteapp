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
    public sealed partial class FrmMantenimientoCitas : Form
    {

        private int? id;

        private bool isEdit;

        private MantenimientoCitas _mantenimiento;

        private FrmMantenimientoCitas()
        {
            InitializeComponent();
        }

        public static FrmMantenimientoCitas Instancia { get; set; } = new FrmMantenimientoCitas();

        private void FrmMantenimientoCitas_Load(object sender, EventArgs e)
        {

        }

        private void FrmMantenimientoCitas_Activated(object sender, EventArgs e)
        {

        }
    }
}
