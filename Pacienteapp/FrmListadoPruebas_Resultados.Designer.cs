
namespace Pacienteapp
{
    partial class FrmListadoPruebas_Resultados
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
            this.DgvListado = new System.Windows.Forms.DataGridView();
            this.BtnCompletar = new System.Windows.Forms.Button();
            this.BtnVolver = new System.Windows.Forms.Button();
            this.LblNombreListado = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.DgvListado, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.BtnCompletar, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.BtnVolver, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.LblNombreListado, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.33233F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.33533F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.33233F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(654, 460);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // DgvListado
            // 
            this.DgvListado.AllowUserToAddRows = false;
            this.DgvListado.AllowUserToDeleteRows = false;
            this.DgvListado.AllowUserToResizeColumns = false;
            this.DgvListado.AllowUserToResizeRows = false;
            this.DgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.DgvListado, 3);
            this.DgvListado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvListado.Location = new System.Drawing.Point(3, 110);
            this.DgvListado.MultiSelect = false;
            this.DgvListado.Name = "DgvListado";
            this.DgvListado.ReadOnly = true;
            this.DgvListado.RowTemplate.Height = 25;
            this.DgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvListado.Size = new System.Drawing.Size(648, 239);
            this.DgvListado.TabIndex = 0;
            this.DgvListado.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListado_CellClick);
            // 
            // BtnCompletar
            // 
            this.BtnCompletar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCompletar.AutoSize = true;
            this.BtnCompletar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnCompletar.Location = new System.Drawing.Point(438, 379);
            this.BtnCompletar.Name = "BtnCompletar";
            this.BtnCompletar.Size = new System.Drawing.Size(213, 53);
            this.BtnCompletar.TabIndex = 1;
            this.BtnCompletar.Text = "Realizar Pruebas";
            this.BtnCompletar.UseVisualStyleBackColor = true;
            this.BtnCompletar.Visible = false;
            this.BtnCompletar.Click += new System.EventHandler(this.BtnCompletar_Click);
            // 
            // BtnVolver
            // 
            this.BtnVolver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnVolver.AutoSize = true;
            this.BtnVolver.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnVolver.Location = new System.Drawing.Point(3, 379);
            this.BtnVolver.Name = "BtnVolver";
            this.BtnVolver.Size = new System.Drawing.Size(211, 54);
            this.BtnVolver.TabIndex = 2;
            this.BtnVolver.Text = "Volver Atrás";
            this.BtnVolver.UseVisualStyleBackColor = true;
            this.BtnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
            // 
            // LblNombreListado
            // 
            this.LblNombreListado.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.LblNombreListado, 2);
            this.LblNombreListado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblNombreListado.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblNombreListado.Location = new System.Drawing.Point(3, 0);
            this.LblNombreListado.Name = "LblNombreListado";
            this.LblNombreListado.Size = new System.Drawing.Size(429, 107);
            this.LblNombreListado.TabIndex = 3;
            this.LblNombreListado.Text = "Lista de Pruebas de Laboratorio";
            this.LblNombreListado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FrmListadoPruebas_Resultados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 460);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrmListadoPruebas_Resultados";
            this.Text = "FrmListadoPruebas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmListadoPruebas_Resultados_FormClosing);
            this.Load += new System.EventHandler(this.FrmListadoPruebas_Resultados_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView DgvListado;
        private System.Windows.Forms.Button BtnCompletar;
        private System.Windows.Forms.Button BtnVolver;
        private System.Windows.Forms.Label LblNombreListado;
    }
}