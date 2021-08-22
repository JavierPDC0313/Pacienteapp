
namespace Mantenimentos
{
    partial class FrmMantenimiento_de_Pruebas_de_Laboratorio
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
            this.LblPruebasLC = new System.Windows.Forms.Label();
            this.BtnCrearNuevaPrueba = new System.Windows.Forms.Button();
            this.BtnEliminarPL = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.BtnEditarPrueba = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.66667F));
            this.tableLayoutPanel1.Controls.Add(this.BtnEditarPrueba, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.LblPruebasLC, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.BtnCrearNuevaPrueba, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.BtnEliminarPL, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 7);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.68657F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.31343F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(675, 454);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint_1);
            // 
            // LblPruebasLC
            // 
            this.LblPruebasLC.AutoSize = true;
            this.LblPruebasLC.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.LblPruebasLC.Location = new System.Drawing.Point(3, 0);
            this.LblPruebasLC.Name = "LblPruebasLC";
            this.LblPruebasLC.Size = new System.Drawing.Size(238, 21);
            this.LblPruebasLC.TabIndex = 0;
            this.LblPruebasLC.Text = "Pruebas de laboratorio creadas:";
            this.LblPruebasLC.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // BtnCrearNuevaPrueba
            // 
            this.BtnCrearNuevaPrueba.Location = new System.Drawing.Point(336, 3);
            this.BtnCrearNuevaPrueba.Name = "BtnCrearNuevaPrueba";
            this.BtnCrearNuevaPrueba.Size = new System.Drawing.Size(336, 45);
            this.BtnCrearNuevaPrueba.TabIndex = 1;
            this.BtnCrearNuevaPrueba.Text = "Crear Nueva Prueba";
            this.BtnCrearNuevaPrueba.UseVisualStyleBackColor = true;
            // 
            // BtnEliminarPL
            // 
            this.BtnEliminarPL.Location = new System.Drawing.Point(3, 405);
            this.BtnEliminarPL.Name = "BtnEliminarPL";
            this.BtnEliminarPL.Size = new System.Drawing.Size(327, 46);
            this.BtnEliminarPL.TabIndex = 2;
            this.BtnEliminarPL.Text = "Eliminar Prueba de Laboratorio";
            this.BtnEliminarPL.UseVisualStyleBackColor = true;
            this.BtnEliminarPL.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.dataGridView1, 2);
            this.dataGridView1.Location = new System.Drawing.Point(3, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(669, 345);
            this.dataGridView1.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(3, 309);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 33);
            this.button3.TabIndex = 2;
            this.button3.Text = "Eliminar Prueba de Laboratorio";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.59259F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.40741F));
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 45);
            this.label2.TabIndex = 0;
            this.label2.Text = "Pruebas de laboratorio creadas:";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(116, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(81, 33);
            this.button4.TabIndex = 1;
            this.button4.Text = "Crear Nueva Prueba";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // BtnEditarPrueba
            // 
            this.BtnEditarPrueba.Location = new System.Drawing.Point(336, 405);
            this.BtnEditarPrueba.Name = "BtnEditarPrueba";
            this.BtnEditarPrueba.Size = new System.Drawing.Size(325, 46);
            this.BtnEditarPrueba.TabIndex = 4;
            this.BtnEditarPrueba.Text = "Editar Prueba";
            this.BtnEditarPrueba.UseVisualStyleBackColor = true;
            this.BtnEditarPrueba.Click += new System.EventHandler(this.BtnEditarPrueba_Click);
            // 
            // FrmMantenimiento_de_Pruebas_de_Laboratorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 463);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrmMantenimiento_de_Pruebas_de_Laboratorio";
            this.Text = "Listado Pruebas de Laboratorio";
            this.Load += new System.EventHandler(this.FrmMantenimiento_de_Pruebas_de_Laboratorio_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label LblPruebasLC;
        private System.Windows.Forms.Button BtnCrearNuevaPrueba;
        private System.Windows.Forms.Button BtnEliminarPL;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnEditarPrueba;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button4;
    }
}