using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Pacienteapp
{
    public sealed partial class FrmMantenimientoPacientes : Form
    {
        public static FrmMantenimientoPacientes MantenimientoPacientes { get; set; } = new FrmMantenimientoPacientes();
        public FrmMantenimientoPacientes()
        {
            InitializeComponent();
        }
    }
}
