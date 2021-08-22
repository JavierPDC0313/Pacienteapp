
namespace Pacienteapp
{
    partial class FrmListadoPruebaLaboratorio
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
            this.BtnCrearNuevaPrueba = new System.Windows.Forms.Button();
            this.BtnEditarPrueba = new System.Windows.Forms.Button();
            this.BtnEliminarPruebLaboratorio = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.LblPruebaLaboratorioCreadas = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.BtnCrearNuevaPrueba, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.BtnEditarPrueba, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.BtnEliminarPruebLaboratorio, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.LblPruebaLaboratorioCreadas, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.45029F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.54971F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(810, 380);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // BtnCrearNuevaPrueba
            // 
            this.BtnCrearNuevaPrueba.Location = new System.Drawing.Point(408, 3);
            this.BtnCrearNuevaPrueba.Name = "BtnCrearNuevaPrueba";
            this.BtnCrearNuevaPrueba.Size = new System.Drawing.Size(399, 40);
            this.BtnCrearNuevaPrueba.TabIndex = 0;
            this.BtnCrearNuevaPrueba.Text = "Crear nueva prueba";
            this.BtnCrearNuevaPrueba.UseVisualStyleBackColor = true;
            this.BtnCrearNuevaPrueba.Click += new System.EventHandler(this.BtnCrearNuevaPrueba_Click);
            // 
            // BtnEditarPrueba
            // 
            this.BtnEditarPrueba.Location = new System.Drawing.Point(408, 345);
            this.BtnEditarPrueba.Name = "BtnEditarPrueba";
            this.BtnEditarPrueba.Size = new System.Drawing.Size(399, 32);
            this.BtnEditarPrueba.TabIndex = 2;
            this.BtnEditarPrueba.Text = "Editar prueba";
            this.BtnEditarPrueba.UseVisualStyleBackColor = true;
            this.BtnEditarPrueba.Click += new System.EventHandler(this.BtnEliminarPrueba_Click);
            // 
            // BtnEliminarPruebLaboratorio
            // 
            this.BtnEliminarPruebLaboratorio.Location = new System.Drawing.Point(3, 345);
            this.BtnEliminarPruebLaboratorio.Name = "BtnEliminarPruebLaboratorio";
            this.BtnEliminarPruebLaboratorio.Size = new System.Drawing.Size(399, 32);
            this.BtnEliminarPruebLaboratorio.TabIndex = 1;
            this.BtnEliminarPruebLaboratorio.Text = "Eliminar prueba de laboratorio";
            this.BtnEliminarPruebLaboratorio.UseVisualStyleBackColor = true;
            this.BtnEliminarPruebLaboratorio.Click += new System.EventHandler(this.BtnEliminarPruebLaboratorio_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.dataGridView1, 2);
            this.dataGridView1.Location = new System.Drawing.Point(3, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(804, 290);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // LblPruebaLaboratorioCreadas
            // 
            this.LblPruebaLaboratorioCreadas.AutoSize = true;
            this.LblPruebaLaboratorioCreadas.Location = new System.Drawing.Point(3, 0);
            this.LblPruebaLaboratorioCreadas.Name = "LblPruebaLaboratorioCreadas";
            this.LblPruebaLaboratorioCreadas.Size = new System.Drawing.Size(167, 15);
            this.LblPruebaLaboratorioCreadas.TabIndex = 4;
            this.LblPruebaLaboratorioCreadas.Text = "Prueba de laboratorio creadas:";
            // 
            // FrmListadoPruebaLaboratorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 399);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrmListadoPruebaLaboratorio";
            this.Text = "Lista de Prueba de Laboratorio";
            this.Load += new System.EventHandler(this.FrmListadoPruebaLaboratorio_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button BtnCrearNuevaPrueba;
        private System.Windows.Forms.Button BtnEditarPrueba;
        private System.Windows.Forms.Button BtnEliminarPruebLaboratorio;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label LblPruebaLaboratorioCreadas;
    }
}