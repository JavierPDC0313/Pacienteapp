using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Pacienteapp
{
    public partial class FrmMantenimientoCrearNuevoMedicos : Form
    {
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
    }
}
