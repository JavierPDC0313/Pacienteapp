using BussinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Pacienteapp
{
    public sealed partial class FrmMantenimientoPacientes : Form
    {
        public static FrmMantenimientoPacientes MantenimientoPacientes { get; set; } = new FrmMantenimientoPacientes();

        private int? Id;

        private bool isEdit;

        private MantenimientoPacientes mantenimiento;
        private FrmAgregar_EditarPacientes FrmAdministrar;

        public FrmMantenimientoPacientes()
        {
            InitializeComponent();

            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            mantenimiento = new MantenimientoPacientes(connection);
        }
    }
}
