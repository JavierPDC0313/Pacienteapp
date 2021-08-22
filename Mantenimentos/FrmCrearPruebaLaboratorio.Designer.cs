
namespace Mantenimentos
{
    partial class FrmCrearPruebaLaboratorio
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
            this.button1 = new System.Windows.Forms.Button();
            this.LblNombreDeLaPrueba = new System.Windows.Forms.Label();
            this.TxtAgregarPruebaDeLabotorio = new System.Windows.Forms.TextBox();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.12791F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.87209F));
            this.tableLayoutPanel1.Controls.Add(this.BtnSalir, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.button1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.LblNombreDeLaPrueba, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.TxtAgregarPruebaDeLabotorio, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 8);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58.7963F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.2037F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(672, 239);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Blue;
            this.button1.Location = new System.Drawing.Point(333, 143);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(332, 80);
            this.button1.TabIndex = 0;
            this.button1.Text = "Crear Nueva Prueba";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // LblNombreDeLaPrueba
            // 
            this.LblNombreDeLaPrueba.AutoSize = true;
            this.LblNombreDeLaPrueba.Font = new System.Drawing.Font("Segoe Print", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.LblNombreDeLaPrueba.Location = new System.Drawing.Point(3, 0);
            this.LblNombreDeLaPrueba.Name = "LblNombreDeLaPrueba";
            this.LblNombreDeLaPrueba.Size = new System.Drawing.Size(255, 37);
            this.LblNombreDeLaPrueba.TabIndex = 1;
            this.LblNombreDeLaPrueba.Text = "Nombre de La Prueba:";
            // 
            // TxtAgregarPruebaDeLabotorio
            // 
            this.TxtAgregarPruebaDeLabotorio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtAgregarPruebaDeLabotorio.Location = new System.Drawing.Point(333, 3);
            this.TxtAgregarPruebaDeLabotorio.MaxLength = 200;
            this.TxtAgregarPruebaDeLabotorio.Name = "TxtAgregarPruebaDeLabotorio";
            this.TxtAgregarPruebaDeLabotorio.Size = new System.Drawing.Size(336, 23);
            this.TxtAgregarPruebaDeLabotorio.TabIndex = 2;
            this.TxtAgregarPruebaDeLabotorio.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // BtnSalir
            // 
            this.BtnSalir.ForeColor = System.Drawing.Color.Red;
            this.BtnSalir.Location = new System.Drawing.Point(3, 143);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(324, 80);
            this.BtnSalir.TabIndex = 3;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // FrmCrearPruebaLaboratorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 259);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrmCrearPruebaLaboratorio";
            this.Text = "Agregar Prueba de Laboratorio";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label LblNombreDeLaPrueba;
        private System.Windows.Forms.TextBox TxtAgregarPruebaDeLabotorio;
        private System.Windows.Forms.Button BtnSalir;
    }
}