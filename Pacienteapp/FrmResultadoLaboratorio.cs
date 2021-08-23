using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Pacienteapp
{
    public sealed partial class FrmResultadoLaboratorio : Form
    {
        public static FrmResultadoLaboratorio ResultadoLaboratorio { get; set; } = new FrmResultadoLaboratorio();
        public FrmResultadoLaboratorio()
        {
            InitializeComponent();
        }
    }
}
