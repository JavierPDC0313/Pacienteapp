
namespace Pacienteapp
{
    partial class FrmMantenimientoCrearMedicos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnEliminarM = new System.Windows.Forms.Button();
            this.BtnCrearNuevoMed = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnEditarMedicos = new System.Windows.Forms.Button();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.TxtBusqueda = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 277F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.BtnEliminarM, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.BtnCrearNuevoMed, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.BtnEditarMedicos, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.BtnBuscar, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.TxtBusqueda, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.58696F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.41304F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(787, 445);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.dataGridView1, 4);
            this.dataGridView1.Location = new System.Drawing.Point(3, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(781, 321);
            this.dataGridView1.TabIndex = 2;
            // 
            // BtnEliminarM
            // 
            this.BtnEliminarM.Location = new System.Drawing.Point(3, 381);
            this.BtnEliminarM.Name = "BtnEliminarM";
            this.BtnEliminarM.Size = new System.Drawing.Size(242, 61);
            this.BtnEliminarM.TabIndex = 4;
            this.BtnEliminarM.Text = "Eliminar Medicos";
            this.BtnEliminarM.UseVisualStyleBackColor = true;
            this.BtnEliminarM.Click += new System.EventHandler(this.BtnEliminarM_Click);
            // 
            // BtnCrearNuevoMed
            // 
            this.BtnCrearNuevoMed.Location = new System.Drawing.Point(513, 3);
            this.BtnCrearNuevoMed.Name = "BtnCrearNuevoMed";
            this.BtnCrearNuevoMed.Size = new System.Drawing.Size(271, 45);
            this.BtnCrearNuevoMed.TabIndex = 7;
            this.BtnCrearNuevoMed.Text = "Crear Nuevo Medico Aqui";
            this.BtnCrearNuevoMed.UseVisualStyleBackColor = true;
            this.BtnCrearNuevoMed.Click += new System.EventHandler(this.BtnCrearNuevoMed_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(258, 378);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 3;
            // 
            // BtnEditarMedicos
            // 
            this.BtnEditarMedicos.Location = new System.Drawing.Point(513, 381);
            this.BtnEditarMedicos.Name = "BtnEditarMedicos";
            this.BtnEditarMedicos.Size = new System.Drawing.Size(271, 61);
            this.BtnEditarMedicos.TabIndex = 6;
            this.BtnEditarMedicos.Text = "Editar Medicos";
            this.BtnEditarMedicos.UseVisualStyleBackColor = true;
            this.BtnEditarMedicos.Click += new System.EventHandler(this.BtnEditarMedicos_Click);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(3, 3);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(249, 45);
            this.BtnBuscar.TabIndex = 8;
            this.BtnBuscar.Text = "Buscar Medicos";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // TxtBusqueda
            // 
            this.TxtBusqueda.Location = new System.Drawing.Point(258, 3);
            this.TxtBusqueda.Name = "TxtBusqueda";
            this.TxtBusqueda.Size = new System.Drawing.Size(249, 23);
            this.TxtBusqueda.TabIndex = 9;
            this.TxtBusqueda.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // FrmMantenimientoCrearMedicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 459);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrmMantenimientoCrearMedicos";
            this.Text = "Listado de Medicos";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnEliminarM;
        private System.Windows.Forms.Button BtnEditarMedicos;
        private System.Windows.Forms.Button BtnCrearNuevoMed;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.TextBox TxtBusqueda;
    }
}