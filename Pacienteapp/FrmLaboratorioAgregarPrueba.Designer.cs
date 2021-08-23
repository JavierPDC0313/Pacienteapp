
namespace Pacienteapp
{
    partial class FrmLaboratorioAgregarPrueba
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
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.TxtAgregar = new System.Windows.Forms.TextBox();
            this.LblNombreDeLaPrueba = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.BtnGuardar, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.TxtAgregar, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.LblNombreDeLaPrueba, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 7);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.64516F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 69.35484F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(679, 129);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Location = new System.Drawing.Point(342, 42);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(334, 80);
            this.BtnGuardar.TabIndex = 1;
            this.BtnGuardar.Text = "Crear Nueva Prueba";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnCrearNuevaPrueba_Click);
            // 
            // TxtAgregar
            // 
            this.TxtAgregar.Location = new System.Drawing.Point(342, 3);
            this.TxtAgregar.Name = "TxtAgregar";
            this.TxtAgregar.Size = new System.Drawing.Size(313, 23);
            this.TxtAgregar.TabIndex = 2;
            this.TxtAgregar.TextChanged += new System.EventHandler(this.TxtAgregar_TextChanged);
            // 
            // LblNombreDeLaPrueba
            // 
            this.LblNombreDeLaPrueba.AutoSize = true;
            this.LblNombreDeLaPrueba.Location = new System.Drawing.Point(3, 0);
            this.LblNombreDeLaPrueba.Name = "LblNombreDeLaPrueba";
            this.LblNombreDeLaPrueba.Size = new System.Drawing.Size(122, 15);
            this.LblNombreDeLaPrueba.TabIndex = 3;
            this.LblNombreDeLaPrueba.Text = "Nombre de la prueba:";
            // 
            // FrmLaboratorioAgregarPrueba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 144);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrmLaboratorioAgregarPrueba";
            this.Text = "Crear Prueba de Laboratorio";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.TextBox TxtAgregar;
        private System.Windows.Forms.Label LblNombreDeLaPrueba;
    }
}