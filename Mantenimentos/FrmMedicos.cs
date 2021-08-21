using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Mantenimentos
{
    public partial class FrmMedicos : Form
    {
        public bool Editar = false;
        internal object TxtIdMedicos;
        internal object TxtCodigo;
        internal string TxtDireccion;
        internal string TxtCorreo;

        public FrmMedicos()
        {
            InitializeComponent();
        }

        public string TxtCIORUC { get; internal set; }
        public string TxtRazonSocial { get; internal set; }
        public string TxtTelefono { get; internal set; }

        internal static object MostrarMedicos()
        {
            throw new NotImplementedException();
        }

        private void FrmMedicos_Load(object sender, EventArgs e)
        {

        }
    }
}
